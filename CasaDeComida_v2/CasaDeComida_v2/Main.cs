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



namespace CasaDeComida_v2
{
    public partial class Main : Form
    {
        Thread hiloRefresh;
        Thread hiloAgregarPedido;
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
                    ConexionBD.SubirComida(comidaAux);
                    Inventario.Preparado.Enqueue(comidaAux);
                    total = comidaAux.Precio + total;

                    RefreshPedidos();
                    RefreshEntregados();
                    GuardaString.Guardar(comidaAux);

                    //Desestimar , solo para pruebitas
                    //Inventario.SerializarPedidos();

                }
                Thread.Sleep(6000);
            }
        }

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

            dgv_Cocinandose.DataSource = ConexionBD.GetComidas();
            RefreshPedidos();

        }

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

        private void btn_AgregarPedido_Click_1(object sender, EventArgs e)
        {
            AgregarPedido();
        }

        private void btn_ActualizarPedidos_Click(object sender, EventArgs e)
        {
            RefreshPedidos();
        }

        private void btn_ActualizarEntregados_Click(object sender, EventArgs e)
        {
            RefreshEntregados();
        }

    }
}
