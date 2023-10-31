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
            this.SuspendLayout();
            // 
            // lvPacientesMedico
            // 
            this.lvPacientesMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPacientesMedico.HideSelection = false;
            this.lvPacientesMedico.Location = new System.Drawing.Point(170, 73);
            this.lvPacientesMedico.Name = "lvPacientesMedico";
            this.lvPacientesMedico.Size = new System.Drawing.Size(430, 288);
            this.lvPacientesMedico.TabIndex = 0;
            this.lvPacientesMedico.UseCompatibleStateImageBehavior = false;
            this.lvPacientesMedico.View = System.Windows.Forms.View.List;
            // 
            // FormPacientesMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvPacientesMedico);
            this.Name = "FormPacientesMedico";
            this.Text = "FormPacientesMedico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPacientesMedico;
    }
}