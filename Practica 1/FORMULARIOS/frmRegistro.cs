using Practica_1.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class frmRegistro : Form
    {
        List<Persona> persona = new List<Persona>();
        public frmRegistro()
        {
            InitializeComponent();
        }



        private void RegistrarB_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona()
            {
                Nombre = Nombrebox.Text,
                Apellido = apellidosbox.Text,
                Fecha = Fecha.Value
            });
            MessageBox.Show("Registro Exitoso");

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==1)
            {
                dgvPersona.DataSource = null;
                dgvPersona.DataSource = persona;
               
            }
        }
    }
}
