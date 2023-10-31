namespace WindowsFormsHospital
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.contextMenuPacientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvMedicos = new System.Windows.Forms.ListView();
            this.lblListaMedicos = new System.Windows.Forms.Label();
            this.btnAddMedico = new System.Windows.Forms.Button();
            this.lblListaPacientes = new System.Windows.Forms.Label();
            this.lvPacientes = new System.Windows.Forms.ListView();
            this.btnAddPaciente = new System.Windows.Forms.Button();
            this.contextMenuMedicos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuPacientes.SuspendLayout();
            this.contextMenuMedicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuPacientes
            // 
            this.contextMenuPacientes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuPacientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarPacienteToolStripMenuItem});
            this.contextMenuPacientes.Name = "contextMenuStrip1";
            this.contextMenuPacientes.Size = new System.Drawing.Size(133, 28);
            // 
            // eliminarPacienteToolStripMenuItem
            // 
            this.eliminarPacienteToolStripMenuItem.Name = "eliminarPacienteToolStripMenuItem";
            this.eliminarPacienteToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.eliminarPacienteToolStripMenuItem.Text = "Eliminar";
            this.eliminarPacienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarPacienteToolStripMenuItem_Click);
            // 
            // lvMedicos
            // 
            this.lvMedicos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMedicos.HideSelection = false;
            this.lvMedicos.Location = new System.Drawing.Point(106, 72);
            this.lvMedicos.MultiSelect = false;
            this.lvMedicos.Name = "lvMedicos";
            this.lvMedicos.Size = new System.Drawing.Size(268, 296);
            this.lvMedicos.TabIndex = 4;
            this.lvMedicos.UseCompatibleStateImageBehavior = false;
            this.lvMedicos.View = System.Windows.Forms.View.List;
            this.lvMedicos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMedicos_MouseClick);
            // 
            // lblListaMedicos
            // 
            this.lblListaMedicos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblListaMedicos.AutoSize = true;
            this.lblListaMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaMedicos.Location = new System.Drawing.Point(102, 49);
            this.lblListaMedicos.Name = "lblListaMedicos";
            this.lblListaMedicos.Size = new System.Drawing.Size(114, 20);
            this.lblListaMedicos.TabIndex = 5;
            this.lblListaMedicos.Text = "Lista médicos";
            // 
            // btnAddMedico
            // 
            this.btnAddMedico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedico.Location = new System.Drawing.Point(166, 386);
            this.btnAddMedico.Name = "btnAddMedico";
            this.btnAddMedico.Size = new System.Drawing.Size(145, 32);
            this.btnAddMedico.TabIndex = 6;
            this.btnAddMedico.Text = "Añadir médico";
            this.btnAddMedico.UseVisualStyleBackColor = true;
            this.btnAddMedico.Click += new System.EventHandler(this.btnAddMedico_Click);
            // 
            // lblListaPacientes
            // 
            this.lblListaPacientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblListaPacientes.AutoSize = true;
            this.lblListaPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPacientes.Location = new System.Drawing.Point(412, 49);
            this.lblListaPacientes.Name = "lblListaPacientes";
            this.lblListaPacientes.Size = new System.Drawing.Size(123, 20);
            this.lblListaPacientes.TabIndex = 7;
            this.lblListaPacientes.Text = "Lista pacientes";
            // 
            // lvPacientes
            // 
            this.lvPacientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lvPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPacientes.HideSelection = false;
            this.lvPacientes.Location = new System.Drawing.Point(416, 72);
            this.lvPacientes.MultiSelect = false;
            this.lvPacientes.Name = "lvPacientes";
            this.lvPacientes.Size = new System.Drawing.Size(268, 296);
            this.lvPacientes.TabIndex = 8;
            this.lvPacientes.UseCompatibleStateImageBehavior = false;
            this.lvPacientes.View = System.Windows.Forms.View.List;
            this.lvPacientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvPacientes_MouseClick);
            // 
            // btnAddPaciente
            // 
            this.btnAddPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPaciente.Location = new System.Drawing.Point(473, 386);
            this.btnAddPaciente.Name = "btnAddPaciente";
            this.btnAddPaciente.Size = new System.Drawing.Size(154, 32);
            this.btnAddPaciente.TabIndex = 9;
            this.btnAddPaciente.Text = "Añadir paciente";
            this.btnAddPaciente.UseVisualStyleBackColor = true;
            this.btnAddPaciente.Click += new System.EventHandler(this.btnAddPaciente_Click);
            // 
            // contextMenuMedicos
            // 
            this.contextMenuMedicos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuMedicos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarPacientesToolStripMenuItem});
            this.contextMenuMedicos.Name = "contextMenuMedicos";
            this.contextMenuMedicos.Size = new System.Drawing.Size(197, 28);
            // 
            // mostrarPacientesToolStripMenuItem
            // 
            this.mostrarPacientesToolStripMenuItem.Name = "mostrarPacientesToolStripMenuItem";
            this.mostrarPacientesToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.mostrarPacientesToolStripMenuItem.Text = "Mostrar pacientes";
            this.mostrarPacientesToolStripMenuItem.Click += new System.EventHandler(this.mostrarPacientesToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPaciente);
            this.Controls.Add(this.lvPacientes);
            this.Controls.Add(this.lblListaPacientes);
            this.Controls.Add(this.btnAddMedico);
            this.Controls.Add(this.lblListaMedicos);
            this.Controls.Add(this.lvMedicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "AppHospital";
            this.contextMenuPacientes.ResumeLayout(false);
            this.contextMenuMedicos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuPacientes;
        private System.Windows.Forms.ToolStripMenuItem eliminarPacienteToolStripMenuItem;
        private System.Windows.Forms.ListView lvMedicos;
        private System.Windows.Forms.Label lblListaMedicos;
        private System.Windows.Forms.Button btnAddMedico;
        private System.Windows.Forms.Label lblListaPacientes;
        private System.Windows.Forms.ListView lvPacientes;
        private System.Windows.Forms.Button btnAddPaciente;
        private System.Windows.Forms.ContextMenuStrip contextMenuMedicos;
        private System.Windows.Forms.ToolStripMenuItem mostrarPacientesToolStripMenuItem;
    }
}

