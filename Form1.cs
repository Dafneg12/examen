using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //lblFecha.Text = DateTime.Now.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CargarComboBox()
        {
            string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";


            string query = "SELECT id_guardia, nombre FROM Guardias";


            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader(); //new

                DataTable dt = new DataTable();
                dt.Load(reader);

                DataRow fila = dt.NewRow();
                fila["id_guardia"] = 0; 
                fila["nombre"] = "Seleccione el guardia";
                dt.Rows.InsertAt(fila, 0);

                cboGuardia.DisplayMember = "nombre"; 
                cboGuardia.ValueMember = "id_guardia";       
                cboGuardia.DataSource = dt;
            }
        }



        private void btnGestionResidentes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            crud gestionResidentes = new crud();
            gestionResidentes.ShowDialog();
            this.Close();
        }

        private void btnAccesoPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccesoPrincipal principal = new AccesoPrincipal();
            principal.ShowDialog();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial hist = new Historial();
            hist.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            lblFecha.Text = DateTime.Now.ToString();
        }
    }
}
