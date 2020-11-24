using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;
using Archivo;



namespace CasaDeComida_v2
{

    public delegate bool DelegadoTxT(Comida comida);

    public partial class Main : Form
    {
        //Hilo que auto refrescara los pedidos cada x segundos , mientras la cola de pedidos sea mayor a 0.
        Thread hiloRefresh;
        // Hilo de agregar pedidos , que me va permitir agregar pedidos de mientras el form principal sigue haciendo su trabajo.
        Thread hiloAgregarPedido;

        // Evento que va imprimir el ticket 
        public event DelegadoTxT txtPrinter;

        // Acumulador de $$$ de las ventas.
        int total = 0;
        
        public Main()
        {
            InitializeComponent();
            hiloRefresh = new Thread(this.AutoRefresh);

            hiloAgregarPedido = new Thread(this.AgregarPedido);
            hiloAgregarPedido.Start();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (Inventario.CargarComidasDelXml())
                {
                    MessageBox.Show(@"Se crearon pedidos por defecto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.RefreshEntregados();
                this.RefreshPedidos();

                //Le asigno el manejador al evento 
                txtPrinter += GuardaString.Guardar;

                if (!hiloRefresh.IsAlive)
                {
                    hiloRefresh.Start();
                }
                else
                {
                    hiloRefresh.Abort();
                    hiloRefresh.Start();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// Refrezca automaticamente el form ,siempre y cuando haya pedidos cocinandose.
        /// </summary>
        private void AutoRefresh()
        {
            while (true)
            {
                if (this.lbl_RecaudacionTotal.InvokeRequired)
                {
                    this.lbl_RecaudacionTotal.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lbl_RecaudacionTotal.Text = "Recauldacion total : $ " + total.ToString();
                    });
                }

                if (Inventario.Cocinandose.Count > 0)
                {
                    Comida comidaAux;
                    comidaAux = Inventario.Cocinandose.Dequeue();
                    total = comidaAux.Precio + total;


                    //ConexionBD.SubirComida(comidaAux);
                    Inventario.Preparado.Enqueue(comidaAux);
                    

                    RefreshPedidos();
                    RefreshEntregados();

                    //Esto a futuro lo reemplazare por un evento.
                    //GuardaString.Guardar(comidaAux);

                    //  Invoco a txtPrinter para que me imprima el ticket , que es un evento que tiene como manejador GuardarString.Guardar(Comida obj) , a travez de un delegado
                    txtPrinter.Invoke(comidaAux);

                    //Desestimar , solo para pruebitas
                    //Inventario.SerializarPedidos();

                    //Esta cochinada la hice para usar mi metodo extension de Count.

                    if (this.lbl_NroCocinandose.InvokeRequired && this.lbl_NroEntregados.InvokeRequired)
                    {
                        this.lbl_NroCocinandose.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lbl_NroCocinandose.Text = Inventario.Count(Inventario.Cocinandose).ToString();
                        });

                        this.lbl_NroEntregados.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lbl_NroEntregados.Text = Inventario.Count(Inventario.Preparado).ToString();
                        });


                    }

                }
                Thread.Sleep(6000);
            }
        }







        /// <summary>
        /// Abre el form de agregar pedido.
        /// </summary>
        private void AgregarPedido()
        {
            FormAgregarPedido FormAgregarPedido = new FormAgregarPedido();
            FormAgregarPedido.ShowDialog();
        }


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // SUBIDA ANDA BIEN 
            //Comida comida = new Comida("Nada",ETipo.ComidaGurmet,200);
            //ConexionBD.SubirComida(comida);

            //dgv_Cocinandose.DataSource = ConexionBD.GetComidas();

            RefreshPedidos();

        }

        /// <summary>
        /// Actualiza el data grid de pedidos
        /// </summary>
         public void RefreshPedidos()
         {
            if (this.dgv_Cocinandose.InvokeRequired)
            {
                this.dgv_Cocinandose.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.dgv_Cocinandose.DataSource = null;
                    this.dgv_Cocinandose.DataSource = Inventario.Cocinandose.ToArray();
                });
            }
            else
            {
                this.dgv_Cocinandose.DataSource = null;
                this.dgv_Cocinandose.DataSource = Inventario.Cocinandose.ToArray();
            }
        }

        /// <summary>
        /// Actualiza el data grid de entregados
        /// </summary>
        public void RefreshEntregados()
        {
            if (this.dgv_Entregados.InvokeRequired)
            {
                this.dgv_Entregados.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.dgv_Entregados.DataSource = null;
                    this.dgv_Entregados.DataSource = Inventario.Preparado.ToArray();
                });
            }
            else
            {
                this.dgv_Entregados.DataSource = null;
                this.dgv_Entregados.DataSource = Inventario.Preparado.ToArray();
            }
        }

        private void btn_ActualizarPedidos_Click(object sender, EventArgs e)
        {
            RefreshPedidos();
        }

        private void btn_ActualizarEntregados_Click(object sender, EventArgs e)
        {
            RefreshEntregados();
        }

        private void btn_AgregarPedido_Click(object sender, EventArgs e)
        {
            this.AgregarPedido();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            hiloAgregarPedido.Abort();
            hiloRefresh.Abort();
        }

    }
}
