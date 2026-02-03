using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class frn_Burbuja : Form
    {
        public frn_Burbuja()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrdenarB_Click(object sender, EventArgs e)
        {
            int [] ordenado = new int[Ddesordenado.RowCount-1];
            for (int i = 0; i < Ddesordenado.RowCount; i++)
            {
                ordenado[i] = Convert.ToInt32(Ddesordenado.Rows[i].Cells[0].Value);
            }
        }
    }
}
