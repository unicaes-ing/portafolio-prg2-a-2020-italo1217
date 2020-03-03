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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static int Mayor(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }   
        public static int Mayor(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }     
        private void btnMayor_Click(object sender, EventArgs e)
        {
            try
            {
                int N1 = Convert.ToInt32(txtnum1.Text);
                int N2 = Convert.ToInt32(txtnum2.Text);
                lblMayor.Text = string.Format("{0}", Mayor(N1, N2));
                if (!string.IsNullOrEmpty(txtnum3.Text))
                {
                    int N3 = Convert.ToInt32(txtnum3.Text);
                    lblMayor.Text = string.Format("{0}", Mayor(N1, N2, N3));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Complete todos los campos e ingrese solo numeros","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
             
        }
    }
}
