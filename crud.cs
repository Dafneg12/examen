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
        private SqlDataAdapter adapter;
        private SqlConnection connection;
        private int idGuardiaActual;
        private DateTime fechaActual;
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
            AccesoPrincipal principal = new AccesoPrincipal(idGuardiaActual,fechaActual);
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

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                tablaResidentes = new DataTable();
                adapter.Fill(tablaResidentes);
                dataGridView1.DataSource = tablaResidentes;
                dataGridView1.Columns["id_residente"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

            dataGridView1.AllowUserToDeleteRows = true;
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
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                tablaResidentes.DefaultView.RowFilter = string.Empty;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(tablaResidentes);
                MessageBox.Show("Cambios guardados correctamente.");
                connection?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
                try
                {
                    adapter.Update(tablaResidentes);
                    MessageBox.Show("Residente eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el residente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }
    }
}
