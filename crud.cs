using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace examen
{
    public partial class crud : Form
    {
        string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";
        private DataTable tablaResidentes;
        public crud()
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

        private void btnHistorial_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Historial hist = new Historial();
            hist.ShowDialog();
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.Hide();
            crearResidentes crear = new crearResidentes();
            crear.ShowDialog();
            this.Close();
        }

        private void crud_Load(object sender, EventArgs e)
        {
            cargarResidentes();
        }

        private void cargarResidentes()
        {
            string query = "SELECT * FROM Residentes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    tablaResidentes = new DataTable();
                    adapter.Fill(tablaResidentes);
                    dataGridView1.DataSource = tablaResidentes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaResidentes == null || tablaResidentes.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados.");
                return;
            }

            string texto = txtBuscar.Text.Trim().Replace("'", "''");

            tablaResidentes.DefaultView.RowFilter = $"nombre LIKE '%{txtBuscar.Text}%' OR calle LIKE '%{txtBuscar.Text}%'";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                tablaResidentes.DefaultView.RowFilter = string.Empty;
            }
            
        }
    }
}
