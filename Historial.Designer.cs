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
            btnGestion = new Button();
            btnInicio = new Button();
            btnHistorial = new Button();
            btnAccesoPrincipal = new Button();
            lblHistorial = new Label();
            panel3 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            lblFiltros = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(132, 176, 198);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 48);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 1;
            label1.Text = "Residecia arboledas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(159, 209, 234);
            panel2.Controls.Add(btnGestion);
            panel2.Controls.Add(btnInicio);
            panel2.Controls.Add(btnHistorial);
            panel2.Controls.Add(btnAccesoPrincipal);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 48);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 415);
            panel2.TabIndex = 6;
            // 
            // btnGestion
            // 
            btnGestion.BackColor = Color.FromArgb(159, 209, 234);
            btnGestion.FlatStyle = FlatStyle.Flat;
            btnGestion.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnGestion.ForeColor = Color.Black;
            btnGestion.Location = new Point(0, 150);
            btnGestion.Margin = new Padding(3, 2, 3, 2);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(193, 75);
            btnGestion.TabIndex = 10;
            btnGestion.Text = "Gestion de residentes";
            btnGestion.UseVisualStyleBackColor = false;
            btnGestion.Click += btnGestion_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(159, 209, 234);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnInicio.ForeColor = Color.Black;
            btnInicio.Location = new Point(0, 2);
            btnInicio.Margin = new Padding(1);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(193, 75);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(159, 209, 234);
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnHistorial.ForeColor = Color.Black;
            btnHistorial.Location = new Point(0, 220);
            btnHistorial.Margin = new Padding(3, 2, 3, 2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(193, 75);
            btnHistorial.TabIndex = 9;
            btnHistorial.Text = "Historial de accesos";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnAccesoPrincipal
            // 
            btnAccesoPrincipal.BackColor = Color.FromArgb(159, 209, 234);
            btnAccesoPrincipal.FlatStyle = FlatStyle.Flat;
            btnAccesoPrincipal.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnAccesoPrincipal.ForeColor = Color.Black;
            btnAccesoPrincipal.Location = new Point(0, 76);
            btnAccesoPrincipal.Margin = new Padding(3, 2, 3, 2);
            btnAccesoPrincipal.Name = "btnAccesoPrincipal";
            btnAccesoPrincipal.Size = new Size(193, 75);
            btnAccesoPrincipal.TabIndex = 8;
            btnAccesoPrincipal.Text = "Acceso Principal";
            btnAccesoPrincipal.UseVisualStyleBackColor = false;
            btnAccesoPrincipal.Click += btnAccesoPrincipal_Click;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorial.Location = new Point(214, 53);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(161, 23);
            lblHistorial.TabIndex = 8;
            lblHistorial.Text = "Historial de acceso";
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(lblFiltros);
            panel3.Location = new Point(213, 85);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(878, 47);
            panel3.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "", "Entrada", "Salida" });
            comboBox2.Location = new Point(409, 14);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "Tipo de acceso";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "Residente", "Invitado" });
            comboBox1.Location = new Point(252, 14);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Tipo de persona";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(102, 14);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.Font = new Font("Candara", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFiltros.Location = new Point(10, 14);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(57, 22);
            lblFiltros.TabIndex = 9;
            lblFiltros.Text = "Filtros";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(213, 150);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(878, 304);
            dataGridView1.TabIndex = 10;
            // 
            // Historial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 463);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(lblHistorial);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Historial";
            Text = "Historial";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnGestion;
        private Button btnInicio;
        private Button btnHistorial;
        private Button btnAccesoPrincipal;
        private Label label1;
        private Label lblHistorial;
        private Panel panel3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label lblFiltros;
        private DataGridView dataGridView1;
    }
}