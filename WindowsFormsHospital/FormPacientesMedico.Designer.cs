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
            this.lvPacientesMedico = new System.Windows.Forms.ListView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblListaPacientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvPacientesMedico
            // 
            this.lvPacientesMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPacientesMedico.HideSelection = false;
            this.lvPacientesMedico.Location = new System.Drawing.Point(175, 90);
            this.lvPacientesMedico.Name = "lvPacientesMedico";
            this.lvPacientesMedico.Size = new System.Drawing.Size(430, 288);
            this.lvPacientesMedico.TabIndex = 0;
            this.lvPacientesMedico.UseCompatibleStateImageBehavior = false;
            this.lvPacientesMedico.View = System.Windows.Forms.View.List;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(13, 13);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(79, 29);
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
            // FormPacientesMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListaPacientes);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lvPacientesMedico);
            this.Name = "FormPacientesMedico";
            this.Text = "FormPacientesMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPacientesMedico;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblListaPacientes;
    }
}