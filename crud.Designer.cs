namespace examen
{
    partial class crud
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
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            btnInicio = new Button();
            btnAcceso = new Button();
            btnGestionResidentes = new Button();
            btnHistorialAccesos = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(179, 31);
            label1.TabIndex = 0;
            label1.Text = "Residecia arboledas";
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
            panel2.Size = new Size(206, 611);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(106, 156, 253);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 53);
            panel1.TabIndex = 3;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(0, 6);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(206, 92);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnAcceso
            // 
            btnAcceso.Location = new Point(0, 100);
            btnAcceso.Name = "btnAcceso";
            btnAcceso.Size = new Size(206, 92);
            btnAcceso.TabIndex = 1;
            btnAcceso.Text = "Panel de acceso principal";
            btnAcceso.UseVisualStyleBackColor = true;
            // 
            // btnGestionResidentes
            // 
            btnGestionResidentes.Location = new Point(0, 195);
            btnGestionResidentes.Name = "btnGestionResidentes";
            btnGestionResidentes.Size = new Size(206, 92);
            btnGestionResidentes.TabIndex = 2;
            btnGestionResidentes.Text = "Gestion de residentes";
            btnGestionResidentes.UseVisualStyleBackColor = true;
            // 
            // btnHistorialAccesos
            // 
            btnHistorialAccesos.Location = new Point(-1, 290);
            btnHistorialAccesos.Name = "btnHistorialAccesos";
            btnHistorialAccesos.Size = new Size(206, 92);
            btnHistorialAccesos.TabIndex = 3;
            btnHistorialAccesos.Text = "Historial de accesos";
            btnHistorialAccesos.UseVisualStyleBackColor = true;
            // 
            // crud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 664);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "crud";
            Text = "crud";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button btnGestionResidentes;
        private Button btnAcceso;
        private Button btnInicio;
        private Button btnHistorialAccesos;
    }
}