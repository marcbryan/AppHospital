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
        public FormPacientesMedico(List<Paciente> pacientesMedico, string nombreMedico)
        {
            InitializeComponent();

            lblListaPacientes.Text += nombreMedico;

            foreach (Paciente paciente in pacientesMedico)
                lvPacientesMedico.Items.Add(paciente.ToString());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
