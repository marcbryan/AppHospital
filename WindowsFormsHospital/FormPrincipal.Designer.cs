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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lblListaMedicos = new System.Windows.Forms.Label();
            this.btnAddMedico = new System.Windows.Forms.Button();
            this.lblListaPacientes = new System.Windows.Forms.Label();
            this.btnAddPaciente = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarMedico = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.lbMedicos = new System.Windows.Forms.ListBox();
            this.lbPacientes = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListaMedicos
            // 
            this.lblListaMedicos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblListaMedicos.AutoSize = true;
            this.lblListaMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaMedicos.Location = new System.Drawing.Point(29, 110);
            this.lblListaMedicos.Name = "lblListaMedicos";
            this.lblListaMedicos.Size = new System.Drawing.Size(114, 20);
            this.lblListaMedicos.TabIndex = 5;
            this.lblListaMedicos.Text = "Lista médicos";
            // 
            // btnAddMedico
            // 
            this.btnAddMedico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedico.Location = new System.Drawing.Point(33, 483);
            this.btnAddMedico.Name = "btnAddMedico";
            this.btnAddMedico.Size = new System.Drawing.Size(170, 32);
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
            this.lblListaPacientes.Location = new System.Drawing.Point(419, 110);
            this.lblListaPacientes.Name = "lblListaPacientes";
            this.lblListaPacientes.Size = new System.Drawing.Size(123, 20);
            this.lblListaPacientes.TabIndex = 7;
            this.lblListaPacientes.Text = "Lista pacientes";
            // 
            // btnAddPaciente
            // 
            this.btnAddPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPaciente.Location = new System.Drawing.Point(423, 483);
            this.btnAddPaciente.Name = "btnAddPaciente";
            this.btnAddPaciente.Size = new System.Drawing.Size(170, 32);
            this.btnAddPaciente.TabIndex = 9;
            this.btnAddPaciente.Text = "Añadir paciente";
            this.btnAddPaciente.UseVisualStyleBackColor = true;
            this.btnAddPaciente.Click += new System.EventHandler(this.btnAddPaciente_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(268, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 38);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Gestión Hospital";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 11;
            // 
            // btnEliminarMedico
            // 
            this.btnEliminarMedico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarMedico.Enabled = false;
            this.btnEliminarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMedico.Location = new System.Drawing.Point(209, 483);
            this.btnEliminarMedico.Name = "btnEliminarMedico";
            this.btnEliminarMedico.Size = new System.Drawing.Size(170, 32);
            this.btnEliminarMedico.TabIndex = 12;
            this.btnEliminarMedico.Text = "Eliminar médico";
            this.btnEliminarMedico.UseVisualStyleBackColor = true;
            this.btnEliminarMedico.Click += new System.EventHandler(this.btnEliminarMedico_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarPaciente.Enabled = false;
            this.btnEliminarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaciente.Location = new System.Drawing.Point(599, 483);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(170, 32);
            this.btnEliminarPaciente.TabIndex = 13;
            this.btnEliminarPaciente.Text = "Eliminar paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // lbMedicos
            // 
            this.lbMedicos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedicos.FormattingEnabled = true;
            this.lbMedicos.ItemHeight = 20;
            this.lbMedicos.Location = new System.Drawing.Point(33, 133);
            this.lbMedicos.Name = "lbMedicos";
            this.lbMedicos.Size = new System.Drawing.Size(346, 344);
            this.lbMedicos.TabIndex = 14;
            this.lbMedicos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbMedicos_MouseDoubleClick);
            // 
            // lbPacientes
            // 
            this.lbPacientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacientes.FormattingEnabled = true;
            this.lbPacientes.ItemHeight = 20;
            this.lbPacientes.Location = new System.Drawing.Point(423, 133);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(346, 344);
            this.lbPacientes.TabIndex = 15;
            this.lbPacientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbPacientes_MouseDoubleClick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.lbPacientes);
            this.Controls.Add(this.lbMedicos);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Controls.Add(this.btnEliminarMedico);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddPaciente);
            this.Controls.Add(this.lblListaPacientes);
            this.Controls.Add(this.btnAddMedico);
            this.Controls.Add(this.lblListaMedicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "AppHospital";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListaMedicos;
        private System.Windows.Forms.Button btnAddMedico;
        private System.Windows.Forms.Label lblListaPacientes;
        private System.Windows.Forms.Button btnAddPaciente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarMedico;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.ListBox lbMedicos;
        private System.Windows.Forms.ListBox lbPacientes;
    }
}

