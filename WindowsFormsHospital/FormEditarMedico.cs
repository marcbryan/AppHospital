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
    public partial class FormEditarMedico : Form
    {
        private Medico medico;

        public FormEditarMedico(Medico medico)
        {
            InitializeComponent();

            this.medico = medico;

            txtNombre.Text = medico.Nombre;
            txtApellidos.Text = medico.Apellidos;
            nmrEdad.Value = medico.Edad;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void GuardarCambios()
        {
            DialogResult = DialogResult.OK;

            medico.Nombre = txtNombre.Text;
            medico.Apellidos = txtApellidos.Text;
            medico.Edad = (int) nmrEdad.Value;
        }

        private void btnListaPacientes_Click(object sender, EventArgs e)
        {
            MostrarFormListaPacientes();
        }

        private void MostrarFormListaPacientes()
        {
            List<Paciente> pacientesMedico = medico.PacientesMedico;
            FormPacientesMedico formPacientesMedico;

            if (pacientesMedico.Count > 0)
            {
                this.Visible = false;

                formPacientesMedico = new FormPacientesMedico(pacientesMedico, medico);
                formPacientesMedico.ShowDialog();

                this.Visible = true;
            }
            else
                MessageBox.Show("Este médico no tiene pacientes!");
        }
    }
}
