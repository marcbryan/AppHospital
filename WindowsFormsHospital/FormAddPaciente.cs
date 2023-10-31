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
    public partial class FormAddPaciente : Form
    {
        private List<Medico> medicos;
        private Paciente nuevoPaciente;

        public Paciente NuevoPaciente { get { return nuevoPaciente; } set { nuevoPaciente = value; } }

        public FormAddPaciente(List<Medico> medicos)
        {
            InitializeComponent();

            this.medicos = medicos;

            foreach (Medico medico in medicos)
                cbMedicos.Items.Add(medico.GetNombreCompleto());
        }

        private void btnAddPaciente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            int edad = (int) nmrEdad.Value;
            int indexMedico = cbMedicos.SelectedIndex;

            if (nombre != "" && apellidos != "" && indexMedico != -1)
            {
                nuevoPaciente = new Paciente(nombre, apellidos, edad, medicos[indexMedico]);

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Faltan datos por añadir!");
        }
    }
}
