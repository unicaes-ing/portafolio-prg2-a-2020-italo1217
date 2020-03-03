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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow celda in dataGridView1.Rows)
            //{
            //total+= dataGridView1.Rows.Add(celda.Cells["Total"].Value);
            //}
            //int contTotal = 0;
            //for (int f = 0; f < dataGridView1.Rows.Count ; f++)
            //{
            // if (dataGridView1.Rows[f].Cells[6].Value.Equals("Column6"))
            //{
            //   contTotal++;
            //}
            // }         
            string Nombre = Convert.ToString(txtNombre.Text);
            int Hora = Convert.ToInt32(txtHorasT.Text);
            double valor = Convert.ToDouble(txtValorporhora.Text);
            double sub, total, iva;
            sub = Hora * valor;
            iva = sub * 0.13;
            total = sub + iva;
            dataGridView1.Rows.Add(Nombre, Hora, valor, sub, iva, total);

            dataGridView1.ClearSelection();
           
            int tot = 0;
            for (int f = 0; f < dataGridView1.Rows.Count; f++)
            {
                total+= Convert.ToInt32(dataGridView1.Rows[f].Cells[3].Value);
                lblTott.Text = string.Format("{0:C2}", tot);   
            }
            txtValorporhora.Clear();
            txtNombre.Clear();
            txtNombre.Focus();  
            txtHorasT.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
