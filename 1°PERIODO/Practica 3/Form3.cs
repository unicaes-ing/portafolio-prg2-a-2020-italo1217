using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            int c = 0;
            Random r = new Random();
            lstNumers.Items.Clear();
            for (int i = 1; i <= 5001; i++)
            {
                int numero = r.Next(1, 7);
                if (numero == 6) c++;
                lstNumers.Items.Add(numero);
            }
            MessageBox.Show("Se obtuvo " + c + " veces el 6");
        }
    }
}
