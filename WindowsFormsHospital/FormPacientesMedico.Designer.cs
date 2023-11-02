namespace WindowsFormsHospital
{
    partial class FormPacientesMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblListaPacientes = new System.Windows.Forms.Label();
            this.btnDesasignarPaciente = new System.Windows.Forms.Button();
            this.lbPacientesMedico = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(217, 394);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(151, 31);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblListaPacientes
            // 
            this.lblListaPacientes.AutoSize = true;
            this.lblListaPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPacientes.Location = new System.Drawing.Point(171, 67);
            this.lblListaPacientes.Name = "lblListaPacientes";
            this.lblListaPacientes.Size = new System.Drawing.Size(151, 20);
            this.lblListaPacientes.TabIndex = 2;
            this.lblListaPacientes.Text = "Lista pacientes de ";
            // 
            // btnDesasignarPaciente
            // 
            this.btnDesasignarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignarPaciente.Location = new System.Drawing.Point(390, 394);
            this.btnDesasignarPaciente.Name = "btnDesasignarPaciente";
            this.btnDesasignarPaciente.Size = new System.Drawing.Size(151, 31);
            this.btnDesasignarPaciente.TabIndex = 3;
            this.btnDesasignarPaciente.Text = "Quitar paciente";
            this.btnDesasignarPaciente.UseVisualStyleBackColor = true;
            this.btnDesasignarPaciente.Click += new System.EventHandler(this.btnDesasignarPaciente_Click);
            // 
            // lbPacientesMedico
            // 
            this.lbPacientesMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacientesMedico.FormattingEnabled = true;
            this.lbPacientesMedico.ItemHeight = 20;
            this.lbPacientesMedico.Location = new System.Drawing.Point(175, 90);
            this.lbPacientesMedico.Name = "lbPacientesMedico";
            this.lbPacientesMedico.Size = new System.Drawing.Size(430, 284);
            this.lbPacientesMedico.TabIndex = 4;
            // 
            // FormPacientesMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPacientesMedico);
            this.Controls.Add(this.btnDesasignarPaciente);
            this.Controls.Add(this.lblListaPacientes);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormPacientesMedico";
            this.Text = "Lista pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblListaPacientes;
        private System.Windows.Forms.Button btnDesasignarPaciente;
        private System.Windows.Forms.ListBox lbPacientesMedico;
    }
}