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
            btnRegresar = new Button();
            label1 = new Label();
            txtNombreR = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            txtApellidoPaterno = new TextBox();
            panel4 = new Panel();
            txtApellidoMaterno = new TextBox();
            buttons1 = new Buttons();
            txtIdResidente = new TextBox();
            panel5 = new Panel();
            txtTelefono = new TextBox();
            panel6 = new Panel();
            txtNumero = new TextBox();
            panel7 = new Panel();
            txtCalle = new TextBox();
            panel8 = new Panel();
            label2 = new Label();
            panel9 = new Panel();
            txtCorreo = new TextBox();
            panel11 = new Panel();
            txtContraseña = new TextBox();
            panel13 = new Panel();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(202, 111, 150);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 60);
            panel1.TabIndex = 4;
            // 
            // btnRegresar
            // 
            btnRegresar.AutoSize = true;
            btnRegresar.BackColor = Color.FromArgb(202, 111, 150);
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
            // txtNombreR
            // 
            txtNombreR.BackColor = Color.FromArgb(206, 144, 170);
            txtNombreR.BorderStyle = BorderStyle.None;
            txtNombreR.Font = new Font("Candara", 12F);
            txtNombreR.ForeColor = SystemColors.InactiveBorder;
            txtNombreR.Location = new Point(30, 74);
            txtNombreR.Multiline = true;
            txtNombreR.Name = "txtNombreR";
            txtNombreR.Size = new Size(372, 41);
            txtNombreR.TabIndex = 5;
            txtNombreR.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(30, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 1);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.ForeColor = SystemColors.ControlLight;
            panel3.Location = new Point(30, 191);
            panel3.Name = "panel3";
            panel3.Size = new Size(372, 1);
            panel3.TabIndex = 8;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.BackColor = Color.FromArgb(206, 144, 170);
            txtApellidoPaterno.BorderStyle = BorderStyle.None;
            txtApellidoPaterno.Font = new Font("Candara", 12F);
            txtApellidoPaterno.ForeColor = SystemColors.InactiveBorder;
            txtApellidoPaterno.Location = new Point(30, 147);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(372, 41);
            txtApellidoPaterno.TabIndex = 7;
            txtApellidoPaterno.Text = "Apellido paterno";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.ForeColor = SystemColors.ControlLight;
            panel4.Location = new Point(30, 265);
            panel4.Name = "panel4";
            panel4.Size = new Size(372, 1);
            panel4.TabIndex = 10;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.BackColor = Color.FromArgb(206, 144, 170);
            txtApellidoMaterno.BorderStyle = BorderStyle.None;
            txtApellidoMaterno.Font = new Font("Candara", 12F);
            txtApellidoMaterno.ForeColor = SystemColors.InactiveBorder;
            txtApellidoMaterno.Location = new Point(30, 221);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(372, 41);
            txtApellidoMaterno.TabIndex = 9;
            txtApellidoMaterno.Text = "Apellido materno";
            // 
            // buttons1
            // 
            buttons1.BackColor = Color.FromArgb(202, 111, 150);
            buttons1.BackgroundColor = Color.FromArgb(202, 111, 150);
            buttons1.BorderColor = Color.PaleVioletRed;
            buttons1.BorderRadius = 20;
            buttons1.BorderSize = 0;
            buttons1.FlatAppearance.BorderSize = 0;
            buttons1.FlatStyle = FlatStyle.Flat;
            buttons1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttons1.ForeColor = Color.White;
            buttons1.Location = new Point(168, 812);
            buttons1.Name = "buttons1";
            buttons1.Size = new Size(128, 51);
            buttons1.TabIndex = 11;
            buttons1.Text = "Crear";
            buttons1.TextColor = Color.White;
            buttons1.UseVisualStyleBackColor = false;
            // 
            // txtIdResidente
            // 
            txtIdResidente.Location = new Point(65, 22);
            txtIdResidente.Name = "txtIdResidente";
            txtIdResidente.ReadOnly = true;
            txtIdResidente.Size = new Size(53, 27);
            txtIdResidente.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.ForeColor = SystemColors.ControlLight;
            panel5.Location = new Point(30, 472);
            panel5.Name = "panel5";
            panel5.Size = new Size(372, 1);
            panel5.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(206, 144, 170);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Candara", 12F);
            txtTelefono.ForeColor = SystemColors.InactiveBorder;
            txtTelefono.Location = new Point(30, 428);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(372, 41);
            txtTelefono.TabIndex = 17;
            txtTelefono.Text = "Telefono";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.ForeColor = SystemColors.ControlLight;
            panel6.Location = new Point(30, 404);
            panel6.Name = "panel6";
            panel6.Size = new Size(372, 1);
            panel6.TabIndex = 16;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(206, 144, 170);
            txtNumero.BorderStyle = BorderStyle.None;
            txtNumero.Font = new Font("Candara", 12F);
            txtNumero.ForeColor = SystemColors.InactiveBorder;
            txtNumero.Location = new Point(30, 360);
            txtNumero.Multiline = true;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(372, 41);
            txtNumero.TabIndex = 15;
            txtNumero.Text = "Numero";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.ForeColor = SystemColors.ControlLight;
            panel7.Location = new Point(30, 334);
            panel7.Name = "panel7";
            panel7.Size = new Size(372, 1);
            panel7.TabIndex = 14;
            // 
            // txtCalle
            // 
            txtCalle.BackColor = Color.FromArgb(206, 144, 170);
            txtCalle.BorderStyle = BorderStyle.None;
            txtCalle.Font = new Font("Candara", 12F);
            txtCalle.ForeColor = SystemColors.InactiveBorder;
            txtCalle.Location = new Point(30, 290);
            txtCalle.Multiline = true;
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(372, 41);
            txtCalle.TabIndex = 13;
            txtCalle.Text = "Calle";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(206, 144, 170);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(txtNumero);
            panel8.Controls.Add(panel5);
            panel8.Controls.Add(txtNombreR);
            panel8.Controls.Add(txtTelefono);
            panel8.Controls.Add(panel2);
            panel8.Controls.Add(panel6);
            panel8.Controls.Add(txtApellidoPaterno);
            panel8.Controls.Add(panel3);
            panel8.Controls.Add(panel7);
            panel8.Controls.Add(txtApellidoMaterno);
            panel8.Controls.Add(txtCalle);
            panel8.Controls.Add(panel4);
            panel8.Controls.Add(txtIdResidente);
            panel8.Location = new Point(25, 82);
            panel8.Name = "panel8";
            panel8.Size = new Size(440, 505);
            panel8.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 22);
            label2.Name = "label2";
            label2.Size = new Size(29, 24);
            label2.TabIndex = 19;
            label2.Text = "ID";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(206, 144, 170);
            panel9.Controls.Add(txtCorreo);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(txtContraseña);
            panel9.Controls.Add(panel13);
            panel9.Location = new Point(25, 602);
            panel9.Name = "panel9";
            panel9.Size = new Size(440, 194);
            panel9.TabIndex = 20;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(206, 144, 170);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Candara", 12F);
            txtCorreo.ForeColor = SystemColors.InactiveBorder;
            txtCorreo.Location = new Point(30, 21);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(372, 41);
            txtCorreo.TabIndex = 9;
            txtCorreo.Text = "Correo";
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ButtonHighlight;
            panel11.ForeColor = SystemColors.ButtonHighlight;
            panel11.Location = new Point(29, 63);
            panel11.Name = "panel11";
            panel11.Size = new Size(372, 1);
            panel11.TabIndex = 6;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(206, 144, 170);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Candara", 12F);
            txtContraseña.ForeColor = SystemColors.InactiveBorder;
            txtContraseña.Location = new Point(29, 92);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(372, 41);
            txtContraseña.TabIndex = 7;
            txtContraseña.Text = "Contraseña";
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.ButtonHighlight;
            panel13.ForeColor = SystemColors.ControlLight;
            panel13.Location = new Point(29, 136);
            panel13.Name = "panel13";
            panel13.Size = new Size(372, 1);
            panel13.TabIndex = 8;
            // 
            // crearResidentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 229, 225);
            ClientSize = new Size(488, 872);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(buttons1);
            Controls.Add(panel1);
            Name = "crearResidentes";
            Text = "crearResidentes";
            Load += crearResidentes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtNombreR;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtApellidoPaterno;
        private Panel panel4;
        private TextBox txtApellidoMaterno;
        private Buttons buttons1;
        private Button btnRegresar;
        private TextBox txtIdResidente;
        private Panel panel5;
        private TextBox txtTelefono;
        private Panel panel6;
        private TextBox txtNumero;
        private Panel panel7;
        private TextBox txtCalle;
        private Panel panel8;
        private Label label2;
        private Panel panel9;
        private Label label3;
        private TextBox textBox1;
        private Panel panel10;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel11;
        private Panel panel12;
        private TextBox txtContraseña;
        private Panel panel13;
        private Panel panel14;
        private TextBox textBox5;
        private TextBox textBox6;
        private Panel panel15;
        private TextBox textBox7;
        private TextBox txtCorreo;
    }
}