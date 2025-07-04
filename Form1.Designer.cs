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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(273, 50);
            label1.TabIndex = 0;
            label1.Text = "Residecia arboledas";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(106, 156, 253);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 53);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 346);
            panel2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 399);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}
