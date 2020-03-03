using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = Convert.ToDouble(txtCant.Text);
                double precio = Convert.ToDouble(txtPrecio.Text);
                double descuento = 0;
                double subtotal = cantidad * precio;
                if (rdoop1.Checked)
                {
                    descuento = (0*subtotal) / 100;
                }
                else if (rdoop2.Checked)
                {
                    descuento = (0.5 * subtotal) / 100;
                }
                else if (rdoop3.Checked)
                {
                    descuento = (0.10 * subtotal) / 100;
                }
                else if (rdoop4.Checked)
                {
                    descuento = (0.15 * subtotal) / 100;
                }
                else if (rdoop5.Checked)
                {
                    descuento = (0.20 * subtotal) / 100;
                }
                txtDesc.Text = string.Format("$ {0:N2}", descuento);
                txtTot.Text = string.Format("$ {0:N2}", subtotal - descuento);


            }
            catch (Exception)
            {
                MessageBox.Show("Error... Ingrese solo numeros");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCant.Clear();
            txtDesc.Clear();
            txtPrecio.Clear();
            txtTot.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
