using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Validaciones;

namespace CasaDeComida_v2
{
    public partial class FormAgregarPedido : Form
    {
        public FormAgregarPedido()
        {
            InitializeComponent();
        }

        private void AgregarPedido_Load(object sender, EventArgs e)
        {

        }

        private void btn_AgregarPedido_Click(object sender, EventArgs e)
        {
            bool nombreOk = false;
            bool clasePedidoOk = false;
            bool precioPedidoOk = false;
            int auxPrecio;

            StringBuilder mensajeError = new StringBuilder();


            // NOMBRE COMIDA 
            if (!(ValidacionesTexto.ValidarStringSoloLetrasNumerosEspacios(this.tb_pedido.Text)))
            {
                mensajeError.AppendLine("Ocurrio un error con el nombre de la comida pedida");
            }
            else
            {
                nombreOk = true;
            }

            //Clase Pedido
            if ((this.cb_Tipo.SelectedIndex == -1))
            {
                mensajeError.AppendLine("Debe elegir un tipo");
            }
            else
            {
                clasePedidoOk = true;
            }

            // Precio

            if (!(int.TryParse(this.tb_precio.Text, out auxPrecio)))
            {
                mensajeError.AppendLine("Ocurrio un error con el precio");
            }
            else
            {
                precioPedidoOk = true;
            }

            // Si se pasan las validadciones proceso a crear la comida

            if (nombreOk && clasePedidoOk && precioPedidoOk )
            {
                Comida comida = new Comida(tb_pedido.Text, MapeoStringAeTipo(cb_Tipo.SelectedItem.ToString()), int.Parse(tb_precio.Text));
                Inventario.Cocinandose.Enqueue(comida);
                MessageBox.Show("Pedido cargado con exito");
            }
            else
            {
                MessageBox.Show(mensajeError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


        }

        public static ETipo MapeoStringAeTipo(string aux)
        {
            switch (aux)
            {
                case "Comida Rapida":
                    return ETipo.ComidaRapida;
                case "Comida Gurmet":
                    return ETipo.ComidaGurmet;
                case "Postre":
                    return ETipo.Postre;
                default:
                    return ETipo.Indefinido;
            }
        }

        private void lbl_Cliente_Click(object sender, EventArgs e)
        {

        }
    }
}
