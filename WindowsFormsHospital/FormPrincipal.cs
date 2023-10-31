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
                lvMedicos.Visible = false;
                btnAddPaciente.Enabled = false;
            }

            int numPacientes = hospital.ContarPacientes();
            if (numPacientes == 0)
            {
                lblListaPacientes.Text = "No hay ningún paciente";
                lvPacientes.Visible = false;
            }
        }

        private void btnAddMedico_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
            FormAddMedico formAddMedico = new FormAddMedico();
            formAddMedico.ShowDialog();

            this.Visible = true;

            if (formAddMedico.DialogResult == DialogResult.OK)
            {
                lblListaMedicos.Text = "Lista médicos";
                hospital.AddMedico(formAddMedico.NuevoMedico);
                lvMedicos.Items.Add(formAddMedico.NuevoMedico.GetNombreCompleto());
                lvMedicos.Visible = true;
                btnAddPaciente.Enabled = true;
            }
        }

        private void btnAddPaciente_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FormAddPaciente formAddPaciente = new FormAddPaciente(hospital.GetMedicos());
            formAddPaciente.ShowDialog();

            this.Visible = true;

            if (formAddPaciente.DialogResult == DialogResult.OK)
            {
                lblListaPacientes.Text = "Lista pacientes";
                hospital.AddPaciente(formAddPaciente.NuevoPaciente);
                lvPacientes.Items.Add(formAddPaciente.NuevoPaciente.GetNombreCompleto());
                lvPacientes.Visible = true;
            }
        }

        private void lvPacientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem focusedItem = lvPacientes.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                    contextMenuPacientes.Show(Cursor.Position);
            }
        }

        private void eliminarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = lvPacientes.SelectedItems[0].Index;
            hospital.EliminarPaciente(index);
            lvPacientes.Items.RemoveAt(index);
        }

        private void lvMedicos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem focusedItem = lvMedicos.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                    contextMenuMedicos.Show(Cursor.Position);
            }
        }

        private void mostrarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Mostrar formulario con sus pacientes
            int index = lvMedicos.SelectedItems[0].Index;
            List<Paciente> pacientesMedico = hospital.ObtenerPacientesMedico(index);

            FormPacientesMedico formPacientesMedico;
            if (pacientesMedico.Count > 0)
            {
                this.Visible = false;
                
                formPacientesMedico = new FormPacientesMedico(pacientesMedico, lvMedicos.Items[index].Text);
                formPacientesMedico.ShowDialog();

                this.Visible = true;
            }
            else
                MessageBox.Show("Este médico no tiene pacientes!");
        }
    }
}
