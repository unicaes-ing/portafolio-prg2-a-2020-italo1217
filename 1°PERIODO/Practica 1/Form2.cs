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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numdecimal;
               numdecimal = Convert.ToInt32(textdecimal.Text);
            textbinario.Text = Convert.ToString(numdecimal, 2);
            textoctal.Text = Convert.ToString(numdecimal, 8);
            texthexadecimal.Text = Convert.ToString(numdecimal, 16);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            textdecimal.Clear();
            textoctal.Clear();
            textbinario.Clear();
            texthexadecimal.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
