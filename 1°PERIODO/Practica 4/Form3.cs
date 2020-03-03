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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static int Fibonacci(int num)
        {
            if (num == 1 || num == 0)
            {
                return num;
            }
            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        } 
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNum.Text); 
            for (int i = 0; i <= numero - 1; i++) 
            { 
                textFibonacci.Text = string.Format("{0}", Fibonacci(i)); 
            }
            txtNum.Focus();
            txtNum.Clear(); 
            
        }
    }
}
