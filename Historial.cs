using Microsoft.Data.SqlClient;
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
        string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";
        private SqlConnection connection;
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

        private void Historial_Load(object sender, EventArgs e)
        {
            string query = @"SELECT a.id_acceso, a.fecha, a.tipo_acceso, r.nombre AS nombre_residente, i.nombre AS nombre_invitado, g.nombre AS nombre_guardia
                             FROM Accesos a
                             LEFT JOIN Residentes r ON a.id_residente = r.id_residente
                             LEFT JOIN Invitados i ON a.id_invitado = i.id_invitado
                             LEFT JOIN Guardias g ON a.id_guardia = g.id_guardia
                             ORDER BY a.fecha DESC";

            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable historial = new DataTable();
                da.Fill(historial);
                dataGridView1.DataSource = historial;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial: " + ex.Message);
            }
        }
    }
}
