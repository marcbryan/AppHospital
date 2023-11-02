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
    public partial class FormPacientesMedico : Form
    {
        private List<Paciente> pacientesMedico;
        private Medico medico;

        public FormPacientesMedico(List<Paciente> pacientesMedico, Medico medico)
        {
            InitializeComponent();

            this.pacientesMedico = pacientesMedico;
            this.medico = medico;

            lblListaPacientes.Text += medico.GetNombreCompleto();

            foreach (Paciente paciente in pacientesMedico)
                lbPacientesMedico.Items.Add(paciente.ToString());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDesasignarPaciente_Click(object sender, EventArgs e)
        {
            bool isSelected = lbPacientesMedico.SelectedIndices.Count > 0 ? true : false;
            if (isSelected)
            {
                int index = lbPacientesMedico.SelectedIndex;
                // Eliminamos el medico del paciente
                Paciente pacienteSeleccionado = medico.PacientesMedico[index];
                pacienteSeleccionado.Medico = null;
                
                // Eliminamos el paciente de la lista de pacientes del médico
                medico.DesasignarPaciente(pacienteSeleccionado);
                lbPacientesMedico.Items.RemoveAt(index);
            }
        }
    }
}
