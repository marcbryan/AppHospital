using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHospital
{
    public partial class FormAddMedico : Form
    {
        private Medico nuevoMedico;

        public Medico NuevoMedico { get { return nuevoMedico; } set { nuevoMedico = value; } }

        public FormAddMedico()
        {
            InitializeComponent();
        }

        private void btnAddMedico_Click(object sender, EventArgs e)
        {
            GuardarNuevoMedico();
        }

        private void GuardarNuevoMedico()
        {
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            int edad = (int) nmrEdad.Value;

            if (nombre != "" && apellidos != "" && edad != 0)
            {
                nuevoMedico = new Medico(nombre, apellidos, edad);

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Faltan datos por añadir!");
        }
    }
}
