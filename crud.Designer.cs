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
            btnCrear = new Buttons();
            btnActualizar = new Buttons();
            btnEliminar = new Buttons();
            dataGridView1 = new DataGridView();
            txtBuscar = new TextBox();
            btnBuscar = new Buttons();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(179, 31);
            label1.TabIndex = 0;
            label1.Text = "Residecia arboledas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(132, 176, 198);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 60);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(159, 209, 234);
            panel2.Controls.Add(btnGestion);
            panel2.Controls.Add(btnHistorial);
            panel2.Controls.Add(btnAccesoPrincipal);
            panel2.Controls.Add(btnInicio);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 604);
            panel2.TabIndex = 6;
            // 
            // btnGestion
            // 
            btnGestion.BackColor = Color.FromArgb(159, 209, 234);
            btnGestion.FlatStyle = FlatStyle.Flat;
            btnGestion.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnGestion.ForeColor = Color.Black;
            btnGestion.Location = new Point(0, 198);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(212, 100);
            btnGestion.TabIndex = 3;
            btnGestion.Text = "Gestion de residentes";
            btnGestion.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(159, 209, 234);
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnHistorial.ForeColor = Color.Black;
            btnHistorial.Location = new Point(0, 297);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(212, 100);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "Historial de accesos";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click_1;
            // 
            // btnAccesoPrincipal
            // 
            btnAccesoPrincipal.BackColor = Color.FromArgb(159, 209, 234);
            btnAccesoPrincipal.FlatStyle = FlatStyle.Flat;
            btnAccesoPrincipal.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnAccesoPrincipal.ForeColor = Color.Black;
            btnAccesoPrincipal.Location = new Point(0, 99);
            btnAccesoPrincipal.Name = "btnAccesoPrincipal";
            btnAccesoPrincipal.Size = new Size(212, 100);
            btnAccesoPrincipal.TabIndex = 1;
            btnAccesoPrincipal.Text = "Acceso Principal";
            btnAccesoPrincipal.UseVisualStyleBackColor = false;
            btnAccesoPrincipal.Click += btnAccesoPrincipal_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(159, 209, 234);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnInicio.ForeColor = Color.Black;
            btnInicio.Location = new Point(0, 0);
            btnInicio.Margin = new Padding(1);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(212, 100);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblResidentes
            // 
            lblResidentes.AutoSize = true;
            lblResidentes.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResidentes.Location = new Point(242, 95);
            lblResidentes.Name = "lblResidentes";
            lblResidentes.Size = new Size(122, 28);
            lblResidentes.TabIndex = 7;
            lblResidentes.Text = "Residentes";
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(132, 176, 198);
            btnCrear.BackgroundColor = Color.FromArgb(132, 176, 198);
            btnCrear.BorderColor = Color.FromArgb(202, 111, 150);
            btnCrear.BorderRadius = 20;
            btnCrear.BorderSize = 0;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Candara Light", 10.2F);
            btnCrear.ForeColor = Color.Black;
            btnCrear.Location = new Point(381, 90);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(100, 40);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "Crear";
            btnCrear.TextColor = Color.Black;
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(132, 176, 198);
            btnActualizar.BackgroundColor = Color.FromArgb(132, 176, 198);
            btnActualizar.BorderColor = Color.FromArgb(202, 111, 150);
            btnActualizar.BorderRadius = 20;
            btnActualizar.BorderSize = 0;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Candara Light", 10.2F);
            btnActualizar.ForeColor = Color.Black;
            btnActualizar.Location = new Point(509, 91);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 40);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextColor = Color.Black;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(132, 176, 198);
            btnEliminar.BackgroundColor = Color.FromArgb(132, 176, 198);
            btnEliminar.BorderColor = Color.FromArgb(202, 111, 150);
            btnEliminar.BorderRadius = 20;
            btnEliminar.BorderSize = 0;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Candara Light", 10.2F);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(637, 90);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 40);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextColor = Color.Black;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(242, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(930, 472);
            dataGridView1.TabIndex = 14;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Candara Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(769, 89);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Busqueda (nombre/domicilio)...";
            txtBuscar.Size = new Size(352, 42);
            txtBuscar.TabIndex = 15;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Control;
            btnBuscar.BackgroundColor = SystemColors.Control;
            btnBuscar.BorderColor = SystemColors.ControlLight;
            btnBuscar.BorderRadius = 20;
            btnBuscar.BorderSize = 0;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1127, 91);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(45, 39);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "🔍";
            btnBuscar.TextColor = Color.Black;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // crud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 664);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(lblResidentes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "crud";
            Text = "crud";
            Load += crud_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Buttons btnCrear;
        private Buttons btnActualizar;
        private Buttons btnEliminar;
        private DataGridView dataGridView1;
        private TextBox txtBuscar;
        private Buttons btnBuscar;
    }
}