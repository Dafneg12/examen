namespace examen
{
    partial class AccesoPrincipal
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblFecha = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnHistorial = new Buttons();
            btnGestionRes = new Buttons();
            btnAccesoPrin = new Buttons();
            btnInicios = new Buttons();
            label2 = new Label();
            txtCodigo = new TextBox();
            panel3 = new Panel();
            txtID = new TextBox();
            txtInvitado = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            lblInvitado = new Label();
            label4 = new Label();
            label3 = new Label();
            lblTipo = new Label();
            btnSalida = new Buttons();
            btnEntrada = new Buttons();
            pictureBox1 = new PictureBox();
            btnEscanear = new Buttons();
            timer1 = new System.Windows.Forms.Timer(components);
            cboTipo = new ComboBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(106, 156, 253);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 48);
            panel1.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ControlLightLight;
            lblFecha.Location = new Point(604, 14);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(43, 18);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "fecha";
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 26);
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
            panel2.Size = new Size(194, 397);
            panel2.TabIndex = 5;
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
            btnHistorial.Click += btnHistorial_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(3, 52, 149);
            label2.Location = new Point(283, 129);
            label2.Name = "label2";
            label2.Size = new Size(125, 19);
            label2.TabIndex = 6;
            label2.Text = "Ingrese el codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(747, 162);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(139, 23);
            txtCodigo.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(txtInvitado);
            panel3.Controls.Add(txtApellidos);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(lblInvitado);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblTipo);
            panel3.Location = new Point(500, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 261);
            panel3.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Location = new Point(18, 47);
            txtID.Name = "txtID";
            txtID.Size = new Size(37, 23);
            txtID.TabIndex = 7;
            // 
            // txtInvitado
            // 
            txtInvitado.Location = new Point(88, 180);
            txtInvitado.Name = "txtInvitado";
            txtInvitado.Size = new Size(118, 23);
            txtInvitado.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(88, 137);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(118, 23);
            txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblInvitado
            // 
            lblInvitado.AutoSize = true;
            lblInvitado.Location = new Point(13, 188);
            lblInvitado.Name = "lblInvitado";
            lblInvitado.Size = new Size(69, 15);
            lblInvitado.TabIndex = 3;
            lblInvitado.Text = "Invitado de:";
            lblInvitado.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 140);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 2;
            label4.Text = "Apellidos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 95);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Nombre:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(51, 13);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(111, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Invitado o residente";
            // 
            // btnSalida
            // 
            btnSalida.BackColor = Color.FromArgb(254, 229, 225);
            btnSalida.BackgroundColor = Color.FromArgb(254, 229, 225);
            btnSalida.BorderColor = Color.PaleVioletRed;
            btnSalida.BorderRadius = 20;
            btnSalida.BorderSize = 0;
            btnSalida.FlatAppearance.BorderSize = 0;
            btnSalida.FlatStyle = FlatStyle.Flat;
            btnSalida.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalida.ForeColor = Color.FromArgb(3, 52, 149);
            btnSalida.Location = new Point(747, 296);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(150, 40);
            btnSalida.TabIndex = 1;
            btnSalida.Text = "Registrar salida";
            btnSalida.TextColor = Color.FromArgb(3, 52, 149);
            btnSalida.UseVisualStyleBackColor = false;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnEntrada
            // 
            btnEntrada.BackColor = Color.FromArgb(254, 229, 225);
            btnEntrada.BackgroundColor = Color.FromArgb(254, 229, 225);
            btnEntrada.BorderColor = Color.PaleVioletRed;
            btnEntrada.BorderRadius = 20;
            btnEntrada.BorderSize = 0;
            btnEntrada.FlatAppearance.BorderSize = 0;
            btnEntrada.FlatStyle = FlatStyle.Flat;
            btnEntrada.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrada.ForeColor = Color.FromArgb(3, 52, 149);
            btnEntrada.Location = new Point(747, 216);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(150, 40);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = "Registrar entrada";
            btnEntrada.TextColor = Color.FromArgb(3, 52, 149);
            btnEntrada.UseVisualStyleBackColor = false;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(251, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 209);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnEscanear
            // 
            btnEscanear.BackColor = Color.CornflowerBlue;
            btnEscanear.BackgroundColor = Color.CornflowerBlue;
            btnEscanear.BorderColor = Color.PaleVioletRed;
            btnEscanear.BorderRadius = 20;
            btnEscanear.BorderSize = 0;
            btnEscanear.Enabled = false;
            btnEscanear.FlatAppearance.BorderSize = 0;
            btnEscanear.FlatStyle = FlatStyle.Flat;
            btnEscanear.ForeColor = Color.White;
            btnEscanear.Location = new Point(283, 384);
            btnEscanear.Name = "btnEscanear";
            btnEscanear.Size = new Size(109, 40);
            btnEscanear.TabIndex = 13;
            btnEscanear.Text = "Escanear codigo";
            btnEscanear.TextColor = Color.White;
            btnEscanear.UseVisualStyleBackColor = false;
            btnEscanear.Click += btnEscanear_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(615, 75);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(282, 23);
            cboTipo.TabIndex = 14;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 76);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 15;
            label5.Text = "Invitado/Residente";
            // 
            // AccesoPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 445);
            Controls.Add(label5);
            Controls.Add(cboTipo);
            Controls.Add(btnSalida);
            Controls.Add(btnEscanear);
            Controls.Add(btnEntrada);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AccesoPrincipal";
            Text = "AccesoPrincipal";
            Load += AccesoPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Buttons btnInicios;
        private Buttons btnAccesoPrin;
        private Buttons btnGestionRes;
        private Buttons btnHistorial;
        private Label lblFecha;
        private Label label2;
        private TextBox txtCodigo;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label lblTipo;
        private Label lblInvitado;
        private TextBox txtInvitado;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private Buttons btnSalida;
        private Buttons btnEntrada;
        private PictureBox pictureBox1;
        private Buttons btnEscanear;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtID;
        private ComboBox cboTipo;
        private Label label5;
    }
}