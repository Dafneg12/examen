namespace examen
{
    partial class Historial
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnHistorial = new Buttons();
            btnGestionRes = new Buttons();
            btnAccesoPrin = new Buttons();
            btnInicios = new Buttons();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 48);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 26);
            label1.TabIndex = 0;
            label1.Text = "Residecia arboledas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(btnHistorial);
            panel2.Controls.Add(btnGestionRes);
            panel2.Controls.Add(btnAccesoPrin);
            panel2.Controls.Add(btnInicios);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 48);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 402);
            panel2.TabIndex = 6;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(106, 156, 253);
            btnHistorial.BackgroundColor = Color.FromArgb(106, 156, 253);
            btnHistorial.BorderColor = Color.PaleVioletRed;
            btnHistorial.BorderRadius = 20;
            btnHistorial.BorderSize = 0;
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Location = new Point(23, 256);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(139, 47);
            btnHistorial.TabIndex = 7;
            btnHistorial.Text = "Historial de accesos";
            btnHistorial.TextColor = Color.White;
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnGestionRes
            // 
            btnGestionRes.BackColor = Color.FromArgb(106, 156, 253);
            btnGestionRes.BackgroundColor = Color.FromArgb(106, 156, 253);
            btnGestionRes.BorderColor = Color.PaleVioletRed;
            btnGestionRes.BorderRadius = 20;
            btnGestionRes.BorderSize = 0;
            btnGestionRes.FlatAppearance.BorderSize = 0;
            btnGestionRes.FlatStyle = FlatStyle.Flat;
            btnGestionRes.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionRes.ForeColor = Color.White;
            btnGestionRes.Location = new Point(23, 180);
            btnGestionRes.Name = "btnGestionRes";
            btnGestionRes.Size = new Size(139, 45);
            btnGestionRes.TabIndex = 7;
            btnGestionRes.Text = "Gestión de residentes";
            btnGestionRes.TextColor = Color.White;
            btnGestionRes.UseVisualStyleBackColor = false;
            btnGestionRes.Click += btnGestionRes_Click;
            // 
            // btnAccesoPrin
            // 
            btnAccesoPrin.BackColor = Color.FromArgb(106, 156, 253);
            btnAccesoPrin.BackgroundColor = Color.FromArgb(106, 156, 253);
            btnAccesoPrin.BorderColor = Color.PaleVioletRed;
            btnAccesoPrin.BorderRadius = 20;
            btnAccesoPrin.BorderSize = 0;
            btnAccesoPrin.FlatAppearance.BorderSize = 0;
            btnAccesoPrin.FlatStyle = FlatStyle.Flat;
            btnAccesoPrin.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccesoPrin.ForeColor = Color.White;
            btnAccesoPrin.Location = new Point(23, 115);
            btnAccesoPrin.Name = "btnAccesoPrin";
            btnAccesoPrin.Size = new Size(139, 41);
            btnAccesoPrin.TabIndex = 7;
            btnAccesoPrin.Text = "Acceso principal";
            btnAccesoPrin.TextColor = Color.White;
            btnAccesoPrin.UseVisualStyleBackColor = false;
            btnAccesoPrin.Click += btnAccesoPrin_Click;
            // 
            // btnInicios
            // 
            btnInicios.BackColor = Color.FromArgb(106, 156, 253);
            btnInicios.BackgroundColor = Color.FromArgb(106, 156, 253);
            btnInicios.BorderColor = Color.PaleVioletRed;
            btnInicios.BorderRadius = 20;
            btnInicios.BorderSize = 0;
            btnInicios.FlatAppearance.BorderSize = 0;
            btnInicios.FlatStyle = FlatStyle.Flat;
            btnInicios.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicios.ForeColor = Color.White;
            btnInicios.Location = new Point(23, 45);
            btnInicios.Name = "btnInicios";
            btnInicios.Size = new Size(139, 41);
            btnInicios.TabIndex = 6;
            btnInicios.Text = "Inicio";
            btnInicios.TextColor = Color.White;
            btnInicios.UseVisualStyleBackColor = false;
            btnInicios.Click += btnInicios_Click;
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Historial";
            Text = "Historial";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Buttons btnHistorial;
        private Buttons btnGestionRes;
        private Buttons btnAccesoPrin;
        private Buttons btnInicios;
    }
}