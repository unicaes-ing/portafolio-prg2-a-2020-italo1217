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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double inver1, inver2, inver3, porc1, porc2, porc3, total;
            inver1 = Convert.ToDouble(textinver1.Text);
            inver2 = Convert.ToDouble(textinver2.Text);
            inver3 = Convert.ToDouble(textinver3.Text);
            total = (inver1 + inver2 + inver3);
            texttotal.Text = string.Format("{0}", total);
            porc1 = (inver1 / total);
            porc2 = (inver2 / total);
            porc3 = (inver3 / total);
            textporc1.Text = string.Format("{0:P}", porc1);
            textporc2.Text = string.Format("{0:P}", porc2);
            textporc3.Text = string.Format("{0:P}", porc3);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textinver1.Clear();
            textinver2.Clear();
            textinver3.Clear();
            textporc1.Clear();
            textporc2.Clear();
            textporc3.Clear();
            texttotal.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
