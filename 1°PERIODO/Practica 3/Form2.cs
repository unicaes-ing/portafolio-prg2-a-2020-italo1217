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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstAlfabto.ForeColor = Color.Purple;
            lstAlfabto.Font = new Font("Arial", 19, FontStyle.Bold | FontStyle.Italic);
            lstAlfabto.Items.Clear();
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                lstAlfabto.Items.Add(letra);
            }
            lstAlfabto.Items.Insert(14, 'Ñ');
        }
    }
}
