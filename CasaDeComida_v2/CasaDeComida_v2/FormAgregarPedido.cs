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
         
            Comida comida = new Comida(tb_pedido.Text, MapeoStringAeTipo(cb_Tipo.SelectedItem.ToString()), int.Parse(tb_precio.Text));

            Inventario.Cocinandose.Enqueue(comida);
            

            MessageBox.Show("Pedido cargado con exito");
           

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

    }
}
