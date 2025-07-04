namespace examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionResidentes_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud gestionResidentes = new crud();
            gestionResidentes.ShowDialog();
        }
    }
}
