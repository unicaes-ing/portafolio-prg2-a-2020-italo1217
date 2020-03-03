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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double examen1, examen2, examen3, promedio;
            examen1 = Convert.ToDouble(textexa1.Text);
            examen2 = Convert.ToDouble(textexa2.Text);
            examen3 = Convert.ToDouble(textexa3.Text);
            promedio = (examen1 + examen2 + examen3) / 3;
            textpromedio.Text = string.Format("{0}", promedio);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textexa1.Clear();
            textexa2.Clear();
            textexa3.Clear();
            textpromedio.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
