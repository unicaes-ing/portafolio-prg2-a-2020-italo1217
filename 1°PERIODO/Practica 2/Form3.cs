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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double longi = Convert.ToDouble(txtLong.Text);
            double total;
            if (lstde.Text == "Pulgadas" && lsta.Text == "Pulgadas")
            {
                total = longi * 1;
                txtLongconvert.Text = string.Format("{0}", total);
            }
            else if (lstde.Text == "Pulgadas" && lsta.Text == "Pies")
            {
                total = longi * 0.0833333;
                txtLongconvert.Text = string.Format("{0:N2}", total);
            }
            else if (lstde.Text == "Pulgadas" && lsta.Text == "Yardas")
            {
                total = longi * 0.0277778;
                txtLongconvert.Text = string.Format("{0:N2}", total);
            }
            else if (lstde.Text == "Pies" && lsta.Text == "Pulgadas")
            {
                total = longi * 12;
                txtLongconvert.Text = string.Format("{0}", total);
            }
            else if (lstde.Text == "Pies" && lsta.Text == "Pies")
            {
                total = longi * 1;
                txtLongconvert.Text = string.Format("{0}", total);
            }
            else if (lstde.Text == "Pies" && lsta.Text == "Yardas")
            {
                total = longi * 0.333333;
                txtLongconvert.Text = string.Format("{0:N2}", total);
            }
            else if (lstde.Text == "Yardas" && lsta.Text == "Pulgadas")
            {
                total = longi * 36;
                txtLongconvert.Text = string.Format("{0}", total);
            }
            else if (lstde.Text == "Yardas" && lsta.Text == "Pies")
            {
                total = longi * 3;
                txtLongconvert.Text = string.Format("{0}", total);
            }
            else if (lstde.Text == "Yardas" && lsta.Text == "Yardas")
            {
                total = longi * 1;
                txtLongconvert.Text = string.Format("{0}", total);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
