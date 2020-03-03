using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double precio, cantidad, subt, impuesto, total;
            cantidad = Convert.ToDouble(textcantidad.Text);
            precio = Convert.ToDouble(textprecio.Text);
            subt = precio * cantidad;
            impuesto = subt * 0.13;
            total = subt + impuesto;
            texttotal.Text = string.Format("{0}", total);
            textsubt.Text = string.Format("{0}", subt);
            textimpuesto.Text = string.Format("{0}", impuesto);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            texttotal.Clear();
            textsubt.Clear();
            textprecio.Clear();
            textcantidad.Clear();
            textimpuesto.Clear();
            cbotitulo.ResetText();

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
