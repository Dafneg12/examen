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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            cboGuardia = new ComboBox();
            label2 = new Label();
            btnAccesoPrincipal = new Buttons();
            btnGestionResidentes = new Buttons();
            btnHistorial = new Buttons();
            pictureBox1 = new PictureBox();
            lblFecha = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(3, 52, 149);
            label1.Location = new Point(226, 39);
            label1.Name = "label1";
            label1.Size = new Size(216, 71);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboGuardia
            // 
            cboGuardia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboGuardia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGuardia.FormattingEnabled = true;
            cboGuardia.ItemHeight = 20;
            cboGuardia.Location = new Point(277, 144);
            cboGuardia.Margin = new Padding(3, 4, 3, 4);
            cboGuardia.Name = "cboGuardia";
            cboGuardia.Size = new Size(277, 28);
            cboGuardia.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(3, 52, 149);
            label2.Location = new Point(135, 135);
            label2.Name = "label2";
            label2.Size = new Size(110, 41);
            label2.TabIndex = 2;
            label2.Text = "Guardia";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAccesoPrincipal
            // 
            btnAccesoPrincipal.BackColor = Color.FromArgb(106, 156, 253);
            btnAccesoPrincipal.BackgroundColor = Color.FromArgb(106, 156, 253);
            btnAccesoPrincipal.BorderColor = Color.PaleVioletRed;
            btnAccesoPrincipal.BorderRadius = 20;
            btnAccesoPrincipal.BorderSize = 0;
            btnAccesoPrincipal.FlatAppearance.BorderSize = 0;
            btnAccesoPrincipal.FlatStyle = FlatStyle.Flat;
            btnAccesoPrincipal.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccesoPrincipal.ForeColor = Color.White;
            btnAccesoPrincipal.Location = new Point(216, 235);
            btnAccesoPrincipal.Margin = new Padding(3, 4, 3, 4);
            btnAccesoPrincipal.Name = "btnAccesoPrincipal";
            btnAccesoPrincipal.Size = new Size(259, 65);
            btnAccesoPrincipal.TabIndex = 3;
            btnAccesoPrincipal.Text = "Acceso Principal";
            btnAccesoPrincipal.TextColor = Color.White;
            btnAccesoPrincipal.UseVisualStyleBackColor = false;
            btnAccesoPrincipal.Click += btnAccesoPrincipal_Click;
            // 
            // btnGestionResidentes
            // 
            btnGestionResidentes.BackColor = Color.FromArgb(106, 156, 253);
            btnGestionResidentes.BackgroundColor = Color.FromArgb(106, 156, 253);
            btnGestionResidentes.BorderColor = Color.PaleVioletRed;
            btnGestionResidentes.BorderRadius = 20;
            btnGestionResidentes.BorderSize = 0;
            btnGestionResidentes.FlatAppearance.BorderSize = 0;
            btnGestionResidentes.FlatStyle = FlatStyle.Flat;
            btnGestionResidentes.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionResidentes.ForeColor = Color.White;
            btnGestionResidentes.Location = new Point(216, 340);
            btnGestionResidentes.Margin = new Padding(3, 4, 3, 4);
            btnGestionResidentes.Name = "btnGestionResidentes";
            btnGestionResidentes.Size = new Size(259, 65);
            btnGestionResidentes.TabIndex = 4;
            btnGestionResidentes.Text = "Gestión de residentes";
            btnGestionResidentes.TextColor = Color.White;
            btnGestionResidentes.UseVisualStyleBackColor = false;
            btnGestionResidentes.Click += btnGestionResidentes_Click_1;
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
            btnHistorial.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Location = new Point(216, 449);
            btnHistorial.Margin = new Padding(3, 4, 3, 4);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(259, 65);
            btnHistorial.TabIndex = 5;
            btnHistorial.Text = "Historial de accesos";
            btnHistorial.TextColor = Color.White;
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 69);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Candara", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(3, 52, 149);
            lblFecha.Location = new Point(511, 12);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 21);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "fecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(688, 596);
            Controls.Add(lblFecha);
            Controls.Add(pictureBox1);
            Controls.Add(btnHistorial);
            Controls.Add(btnGestionResidentes);
            Controls.Add(btnAccesoPrincipal);
            Controls.Add(label2);
            Controls.Add(cboGuardia);
            Controls.Add(label1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboGuardia;
        private Label label2;
        private Buttons btnAccesoPrincipal;
        private Buttons btnGestionResidentes;
        private Buttons btnHistorial;
        private PictureBox pictureBox1;
        private Label lblFecha;
    }
}
