namespace examen
{
    partial class crearResidentes
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
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel4 = new Panel();
            textBox3 = new TextBox();
            buttons1 = new Buttons();
            btnRegresar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 141, 181);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 60);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(256, 18);
            label1.Name = "label1";
            label1.Size = new Size(240, 31);
            label1.TabIndex = 0;
            label1.Text = "Residencia arboledas";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(254, 229, 225);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(49, 134);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 41);
            textBox1.TabIndex = 5;
            textBox1.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(49, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 1);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.ForeColor = SystemColors.ControlLight;
            panel3.Location = new Point(49, 275);
            panel3.Name = "panel3";
            panel3.Size = new Size(372, 1);
            panel3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(254, 229, 225);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(49, 228);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(372, 41);
            textBox2.TabIndex = 7;
            textBox2.Text = "Apellidos";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.ForeColor = SystemColors.ControlLight;
            panel4.Location = new Point(49, 370);
            panel4.Name = "panel4";
            panel4.Size = new Size(372, 1);
            panel4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(254, 229, 225);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(49, 323);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(372, 41);
            textBox3.TabIndex = 9;
            textBox3.Text = "Telefono";
            // 
            // buttons1
            // 
            buttons1.BackColor = Color.FromArgb(235, 141, 181);
            buttons1.BackgroundColor = Color.FromArgb(235, 141, 181);
            buttons1.BorderColor = Color.PaleVioletRed;
            buttons1.BorderRadius = 20;
            buttons1.BorderSize = 0;
            buttons1.FlatAppearance.BorderSize = 0;
            buttons1.FlatStyle = FlatStyle.Flat;
            buttons1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttons1.ForeColor = Color.White;
            buttons1.Location = new Point(161, 423);
            buttons1.Name = "buttons1";
            buttons1.Size = new Size(128, 51);
            buttons1.TabIndex = 11;
            buttons1.Text = "Crear";
            buttons1.TextColor = Color.White;
            buttons1.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            btnRegresar.AutoSize = true;
            btnRegresar.BackColor = Color.FromArgb(235, 141, 181);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(0, 0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(55, 60);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "<";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // crearResidentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 229, 225);
            ClientSize = new Size(458, 564);
            Controls.Add(buttons1);
            Controls.Add(panel4);
            Controls.Add(textBox3);
            Controls.Add(panel3);
            Controls.Add(textBox2);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "crearResidentes";
            Text = "crearResidentes";
            Load += crearResidentes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox2;
        private Panel panel4;
        private TextBox textBox3;
        private Buttons buttons1;
        private Button btnRegresar;
    }
}