namespace examen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            btnHistorialAccesos = new Button();
            btnGestionResidentes = new Button();
            btnAcceso = new Button();
            btnInicio = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(106, 156, 253);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 53);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(btnHistorialAccesos);
            panel2.Controls.Add(btnGestionResidentes);
            panel2.Controls.Add(btnAcceso);
            panel2.Controls.Add(btnInicio);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 444);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 31);
            label1.TabIndex = 3;
            label1.Text = "Residecia arboledas";
            // 
            // btnHistorialAccesos
            // 
            btnHistorialAccesos.Location = new Point(4, 288);
            btnHistorialAccesos.Name = "btnHistorialAccesos";
            btnHistorialAccesos.Size = new Size(180, 92);
            btnHistorialAccesos.TabIndex = 7;
            btnHistorialAccesos.Text = "Historial de accesos";
            btnHistorialAccesos.UseVisualStyleBackColor = true;
            // 
            // btnGestionResidentes
            // 
            btnGestionResidentes.Location = new Point(5, 193);
            btnGestionResidentes.Name = "btnGestionResidentes";
            btnGestionResidentes.Size = new Size(180, 92);
            btnGestionResidentes.TabIndex = 6;
            btnGestionResidentes.Text = "Gestion de residentes";
            btnGestionResidentes.UseVisualStyleBackColor = true;
            btnGestionResidentes.Click += btnGestionResidentes_Click;
            // 
            // btnAcceso
            // 
            btnAcceso.Location = new Point(5, 98);
            btnAcceso.Name = "btnAcceso";
            btnAcceso.Size = new Size(180, 92);
            btnAcceso.TabIndex = 5;
            btnAcceso.Text = "Panel de acceso principal";
            btnAcceso.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(5, 4);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(180, 92);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 497);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnHistorialAccesos;
        private Button btnGestionResidentes;
        private Button btnAcceso;
        private Button btnInicio;
    }
}
