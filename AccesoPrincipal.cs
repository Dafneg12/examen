using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class AccesoPrincipal : Form
    {
        public AccesoPrincipal()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void btnInicios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial hist = new Historial();
            hist.ShowDialog();
            this.Close();

        }

        private void btnGestionRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud crud = new crud();
            crud.ShowDialog();
            this.Close();
        }
    }
}
