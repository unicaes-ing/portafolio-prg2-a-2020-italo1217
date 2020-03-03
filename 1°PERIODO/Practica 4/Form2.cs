using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int Buscar(int num, params string[] numeros)
        {
            int encontrar = 0;
            foreach (string numero in numeros)
            {
                if (Convert.ToInt32(numero) == num)
                {
                    encontrar++;
                }
            }
            return encontrar;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtAgregarNum.Text);
                lstList.Items.Add(txtAgregarNum.Text);
                txtAgregarNum.Clear();
                txtAgregarNum.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese solo numeros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int encontnum = Convert.ToInt32(txtBuscarNumero.Text);
                int buscar;
                string[] num = new string[lstList.Items.Count];
                lstList.Items.CopyTo(num, 0);
                buscar = Buscar(encontnum, num);
                MessageBox.Show("El numero " + encontnum + " se encontro " + buscar + " veces.");

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscarNumero.SelectAll();
                txtBuscarNumero.Focus();
            }
           
        }
    }
} 
