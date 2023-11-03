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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsHospital
{
    public partial class FormPrincipal : Form
    {
        private Hospital hospital;

        public Hospital Hospital { get { return hospital; } set { hospital = value; } }
        
        public FormPrincipal()
        {
            InitializeComponent();

            hospital = new Hospital();

            int numMedicos = hospital.ContarMedicos();
            if (numMedicos == 0)
            {
                lblListaMedicos.Text = "No hay ningún médico";
                lbMedicos.Visible = false;
                btnAddPaciente.Enabled = false;
            }

            int numPacientes = hospital.ContarPacientes();
            if (numPacientes == 0)
            {
                lblListaPacientes.Text = "No hay ningún paciente";
                lbPacientes.Visible = false;
            }
        }

        private void btnAddMedico_Click(object sender, EventArgs e)
        {
            AddMedico();
        }

        private void AddMedico()
        {
            this.Visible = false;

            FormAddMedico formAddMedico = new FormAddMedico();
            formAddMedico.ShowDialog();

            this.Visible = true;

            if (formAddMedico.DialogResult == DialogResult.OK)
            {
                lblListaMedicos.Text = "Lista médicos";

                hospital.AddMedico(formAddMedico.NuevoMedico);
                lbMedicos.Items.Add(formAddMedico.NuevoMedico.GetNombreCompleto());

                lbMedicos.Visible = true;
                btnAddPaciente.Enabled = true;
                btnEliminarMedico.Enabled = true;
            }
        }

        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            EliminarMedico();
        }

        private void EliminarMedico()
        {
            bool isSelected = lbMedicos.SelectedIndices.Count > 0 ? true : false;
            if (isSelected)
            {
                int index = lbMedicos.SelectedIndices[0];
                hospital.EliminarMedico(index);
                lbMedicos.Items.RemoveAt(index);
            }
            else
                MessageBox.Show("No has seleccionado a un médico");
        }

        private void btnAddPaciente_Click(object sender, EventArgs e)
        {
            AddPaciente();
        }

        private void AddPaciente()
        {
            this.Visible = false;

            FormAddPaciente formAddPaciente = new FormAddPaciente(hospital.GetMedicos());
            formAddPaciente.ShowDialog();

            this.Visible = true;

            if (formAddPaciente.DialogResult == DialogResult.OK)
            {
                lblListaPacientes.Text = "Lista pacientes";

                hospital.AddPaciente(formAddPaciente.NuevoPaciente);
                lbPacientes.Items.Add(formAddPaciente.NuevoPaciente.GetNombreCompleto());

                lbPacientes.Visible = true;
                btnEliminarPaciente.Enabled = true;
            }
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            EliminarPaciente();
        }

        private void EliminarPaciente()
        {
            bool isSelected = lbPacientes.SelectedIndices.Count > 0 ? true : false;
            if (isSelected)
            {
                int index = lbPacientes.SelectedIndex;
                hospital.EliminarPaciente(index);
                lbPacientes.Items.RemoveAt(index);
            }
            else
                MessageBox.Show("No has seleccionado a un paciente");
        }

        private void lbMedicos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarFormEditarMedico();
        }

        private void MostrarFormEditarMedico()
        {
            int index = lbMedicos.SelectedIndex;
            if (index != -1)
            {
                List<Medico> medicos = hospital.GetMedicos();

                this.Visible = false;

                FormEditarMedico formEditarMedico = new FormEditarMedico(medicos[index]);
                formEditarMedico.ShowDialog();

                if (formEditarMedico.DialogResult == DialogResult.OK)
                    lbMedicos.Items[index] = medicos[index].GetNombreCompleto();

                this.Visible = true;
            }
        }

        private void lbPacientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarFormEditarPaciente();                
        }

        private void MostrarFormEditarPaciente()
        {
            int index = lbPacientes.SelectedIndex;
            if (index != -1)
            {
                Paciente pacienteSeleccionado = hospital.GetPacientes()[index];

                List<Medico> medicos = hospital.GetMedicos();

                this.Visible = false;

                FormEditarPaciente formCambiarMedicoPaciente = new FormEditarPaciente(medicos, pacienteSeleccionado);
                formCambiarMedicoPaciente.ShowDialog();

                this.Visible = true;

                if (formCambiarMedicoPaciente.DialogResult == DialogResult.OK)
                {
                    Medico medicoAnterior = pacienteSeleccionado.Medico;
                    Medico nuevoMedico = formCambiarMedicoPaciente.NuevoMedico;

                    if (medicoAnterior != nuevoMedico)
                    {
                        if (medicoAnterior != null)
                            medicoAnterior.DesasignarPaciente(pacienteSeleccionado);

                        if (nuevoMedico != null)
                            nuevoMedico.AddPaciente(pacienteSeleccionado);

                        pacienteSeleccionado.Medico = nuevoMedico;
                    }

                    lbPacientes.Items[index] = pacienteSeleccionado.GetNombreCompleto();
                }
            }
        }
    }
}
