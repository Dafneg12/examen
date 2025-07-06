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
            panel1 = new Panel();
            panel2 = new Panel();
            btnGestion = new Button();
            btnHistorial = new Button();
            btnAccesoPrincipal = new Button();
            btnInicio = new Button();
            lblResidentes = new Label();
            btnCrear = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(179, 31);
            label1.TabIndex = 0;
            label1.Text = "Residecia arboledas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 60);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleVioletRed;
            panel2.Controls.Add(btnGestion);
            panel2.Controls.Add(btnHistorial);
            panel2.Controls.Add(btnAccesoPrincipal);
            panel2.Controls.Add(btnInicio);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 604);
            panel2.TabIndex = 6;
            // 
            // btnGestion
            // 
            btnGestion.BackColor = Color.PaleVioletRed;
            btnGestion.FlatStyle = FlatStyle.Flat;
            btnGestion.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnGestion.ForeColor = Color.White;
            btnGestion.Location = new Point(0, 198);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(221, 100);
            btnGestion.TabIndex = 3;
            btnGestion.Text = "Gestion de residentes";
            btnGestion.UseVisualStyleBackColor = false;
            btnGestion.Click += btnGestion_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.PaleVioletRed;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Location = new Point(0, 297);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(221, 100);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "Historial de accesos";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click_1;
            // 
            // btnAccesoPrincipal
            // 
            btnAccesoPrincipal.BackColor = Color.PaleVioletRed;
            btnAccesoPrincipal.FlatStyle = FlatStyle.Flat;
            btnAccesoPrincipal.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnAccesoPrincipal.ForeColor = Color.White;
            btnAccesoPrincipal.Location = new Point(0, 99);
            btnAccesoPrincipal.Name = "btnAccesoPrincipal";
            btnAccesoPrincipal.Size = new Size(221, 100);
            btnAccesoPrincipal.TabIndex = 1;
            btnAccesoPrincipal.Text = "Acceso Principal";
            btnAccesoPrincipal.UseVisualStyleBackColor = false;
            btnAccesoPrincipal.Click += btnAccesoPrincipal_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.PaleVioletRed;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(0, 0);
            btnInicio.Margin = new Padding(1);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(221, 100);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblResidentes
            // 
            lblResidentes.AutoSize = true;
            lblResidentes.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResidentes.Location = new Point(242, 94);
            lblResidentes.Name = "lblResidentes";
            lblResidentes.Size = new Size(122, 28);
            lblResidentes.TabIndex = 7;
            lblResidentes.Text = "Residentes";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Pink;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Location = new Point(395, 96);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(90, 31);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Pink;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Location = new Point(559, 96);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 31);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Pink;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(727, 96);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 31);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // crud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 664);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(lblResidentes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "crud";
            Text = "crud";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label lblResidentes;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnHistorial;
        private Button btnAccesoPrincipal;
        private Button btnInicio;
        private Button btnGestion;
        private Button btnCrear;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}