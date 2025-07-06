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
            txtInvitado = new TextBox();
            txtApellidos = new TextBox();
            txtNombre = new TextBox();
            lblInvitado = new Label();
            label4 = new Label();
            label3 = new Label();
            lblTipo = new Label();
            panel4 = new Panel();
            btnSalida = new Buttons();
            btnEntrada = new Buttons();
            buttons1 = new Buttons();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(106, 156, 253);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 64);
            panel1.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ControlLightLight;
            lblFecha.Location = new Point(690, 19);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 23);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "fecha";
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(228, 35);
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
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 447);
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
            btnHistorial.Location = new Point(26, 341);
            btnHistorial.Margin = new Padding(3, 4, 3, 4);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(159, 63);
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
            btnGestionRes.Location = new Point(26, 240);
            btnGestionRes.Margin = new Padding(3, 4, 3, 4);
            btnGestionRes.Name = "btnGestionRes";
            btnGestionRes.Size = new Size(159, 60);
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
            btnAccesoPrin.Location = new Point(26, 153);
            btnAccesoPrin.Margin = new Padding(3, 4, 3, 4);
            btnAccesoPrin.Name = "btnAccesoPrin";
            btnAccesoPrin.Size = new Size(159, 55);
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
            btnInicios.Location = new Point(26, 60);
            btnInicios.Margin = new Padding(3, 4, 3, 4);
            btnInicios.Name = "btnInicios";
            btnInicios.Size = new Size(159, 55);
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
            label2.Location = new Point(262, 105);
            label2.Name = "label2";
            label2.Size = new Size(155, 24);
            label2.TabIndex = 6;
            label2.Text = "Ingrese el codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(434, 105);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(219, 27);
            txtCodigo.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtInvitado);
            panel3.Controls.Add(txtApellidos);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(lblInvitado);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblTipo);
            panel3.Location = new Point(262, 189);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 279);
            panel3.TabIndex = 9;
            // 
            // txtInvitado
            // 
            txtInvitado.Location = new Point(101, 199);
            txtInvitado.Margin = new Padding(3, 4, 3, 4);
            txtInvitado.Name = "txtInvitado";
            txtInvitado.Size = new Size(134, 27);
            txtInvitado.TabIndex = 6;
            txtInvitado.Visible = false;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(101, 141);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(134, 27);
            txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 81);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(134, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblInvitado
            // 
            lblInvitado.AutoSize = true;
            lblInvitado.Location = new Point(15, 209);
            lblInvitado.Name = "lblInvitado";
            lblInvitado.Size = new Size(87, 20);
            lblInvitado.TabIndex = 3;
            lblInvitado.Text = "Invitado de:";
            lblInvitado.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 145);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 2;
            label4.Text = "Apellidos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 85);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 1;
            label3.Text = "Nombre:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(56, 35);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(141, 20);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Invitado o residente";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSalida);
            panel4.Controls.Add(btnEntrada);
            panel4.Location = new Point(591, 189);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 279);
            panel4.TabIndex = 10;
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
            btnSalida.Location = new Point(23, 145);
            btnSalida.Margin = new Padding(3, 4, 3, 4);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(171, 53);
            btnSalida.TabIndex = 1;
            btnSalida.Text = "Registrar salida";
            btnSalida.TextColor = Color.FromArgb(3, 52, 149);
            btnSalida.UseVisualStyleBackColor = false;
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
            btnEntrada.Location = new Point(23, 52);
            btnEntrada.Margin = new Padding(3, 4, 3, 4);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(171, 53);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = "Registrar entrada";
            btnEntrada.TextColor = Color.FromArgb(3, 52, 149);
            btnEntrada.UseVisualStyleBackColor = false;
            // 
            // buttons1
            // 
            buttons1.BackColor = Color.FromArgb(3, 52, 149);
            buttons1.BackgroundColor = Color.FromArgb(3, 52, 149);
            buttons1.BorderColor = Color.PaleVioletRed;
            buttons1.BorderRadius = 20;
            buttons1.BorderSize = 0;
            buttons1.FlatAppearance.BorderSize = 0;
            buttons1.FlatStyle = FlatStyle.Flat;
            buttons1.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttons1.ForeColor = Color.White;
            buttons1.Location = new Point(675, 93);
            buttons1.Margin = new Padding(3, 4, 3, 4);
            buttons1.Name = "buttons1";
            buttons1.Size = new Size(110, 52);
            buttons1.TabIndex = 11;
            buttons1.Text = "Validar codigo";
            buttons1.TextColor = Color.White;
            buttons1.UseVisualStyleBackColor = false;
            // 
            // AccesoPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 511);
            Controls.Add(buttons1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AccesoPrincipal";
            Text = "AccesoPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
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
        private Panel panel4;
        private Buttons btnSalida;
        private Buttons btnEntrada;
        private Buttons buttons1;
    }
}