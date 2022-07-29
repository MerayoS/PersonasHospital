using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonasHospital
{

    public partial class FormLista : Form
    {

        public FormLista()
        {
            InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
        {
            Hospital.RellenarLista();
            Hospital.MostrarListaDebug();
            Hospital.MostrarLista(listBoxPersonas);
        }

        private void listBoxPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            var myForm = new FormAñadir();
            myForm.ShowDialog();
            listBoxPersonas.Items.Clear();
            Hospital.MostrarLista(listBoxPersonas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxPersonas.Items.Clear();
            Hospital.MostrarLista(listBoxPersonas);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxPersonas.SelectedItem != null)
            {
                Hospital.PersonasDelHospital.Remove((Persona)listBoxPersonas.SelectedItem);
                listBoxPersonas.Items.Remove((Persona)listBoxPersonas.SelectedItem);
            }
            else
                MessageBox.Show("Debe seleccionar la fila que quiere eliminar");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var myForm = new FormMod();
            myForm.ShowDialog();
        }
        public void Modificar()
        {

        }
    }
}
