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
    public partial class FormEditarPaciente : Form
    {
        private Paciente pacienteSeleccionado;
        private List<Medico> medicos;

        private Medico nuevoMedico;
        public Medico NuevoMedico { get { return nuevoMedico; } set { nuevoMedico = value; } }
        
        public FormEditarPaciente(List<Medico> medicos, Paciente pacienteSeleccionado)
        {
            InitializeComponent();

            this.medicos = medicos;
            this.pacienteSeleccionado = pacienteSeleccionado;

            txtNombre.Text = pacienteSeleccionado.Nombre;
            txtApellidos.Text = pacienteSeleccionado.Apellidos;
            nmrEdad.Value = pacienteSeleccionado.Edad;

            foreach (Medico medico in medicos)
                cbMedicoPaciente.Items.Add(medico.GetNombreCompleto());

            int index = medicos.IndexOf(pacienteSeleccionado.Medico);
            cbMedicoPaciente.SelectedIndex = index;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            pacienteSeleccionado.Nombre = txtNombre.Text;
            pacienteSeleccionado.Apellidos = txtApellidos.Text;
            pacienteSeleccionado.Edad = (int) nmrEdad.Value;

            int indexNuevoMedico = cbMedicoPaciente.SelectedIndex;
            if (indexNuevoMedico != -1)
                nuevoMedico = medicos[indexNuevoMedico];
            else
                nuevoMedico = null;

            this.Close();
        }
    }
}
