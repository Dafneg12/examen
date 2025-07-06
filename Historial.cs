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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnAccesoPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccesoPrincipal principal = new AccesoPrincipal();
            principal.ShowDialog();
            this.Close();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud gestionResidentes = new crud();
            gestionResidentes.ShowDialog();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }
    }
}
