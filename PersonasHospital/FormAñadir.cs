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
    public partial class FormAñadir : Form
    {
        public FormAñadir()
        {
            InitializeComponent();
        }

        private void btnAddlist_Click(object sender, EventArgs e)
        {
            Persona padd = new Persona(txtNombreAdd.Text,txtApellidoAdd.Text,txtDniAdd.Text);
            Hospital.PersonasDelHospital.Add(padd);
            Close();
        }

        private void btnCancelarAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
