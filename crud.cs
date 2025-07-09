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
        public crud(int idGuardia, DateTime fechaActual)
        {
            InitializeComponent();
            idGuardiaActual = idGuardia;
            this.fechaActual = fechaActual;
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
            Historial hist = new Historial(idGuardiaActual,fechaActual);
            hist.ShowDialog();
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.Hide();
            crearResidentes crear = new crearResidentes(idGuardiaActual,fechaActual);
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
                        int idResidente = Convert.ToInt32(row.Cells["id_residente"].Value);

                        try
                        {
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                conn.Open();

                                // 0. Eliminar accesos de los invitados del residente
                                string deleteAccesos = @"DELETE FROM Accesos WHERE id_invitado 
                                                       IN (SELECT id_invitado FROM Invitados WHERE id_residente = @id)";
                                using (SqlCommand cmd = new SqlCommand(deleteAccesos, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", idResidente);
                                    cmd.ExecuteNonQuery();
                                }

                                // 1. Eliminar invitados
                                string deleteInvitados = "DELETE FROM Invitados WHERE id_residente = @id";
                                using (SqlCommand cmd = new SqlCommand(deleteInvitados, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", idResidente);
                                    cmd.ExecuteNonQuery();
                                }

                                // 2. Eliminar usuario
                                string deleteUsuario = "DELETE FROM UsuariosResidentes WHERE id_residente = @id";
                                using (SqlCommand cmd = new SqlCommand(deleteUsuario, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", idResidente);
                                    cmd.ExecuteNonQuery();
                                }

                                // 3. Eliminar residente
                                string deleteResidente = "DELETE FROM Residentes WHERE id_residente = @id";
                                using (SqlCommand cmd = new SqlCommand(deleteResidente, conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", idResidente);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            dataGridView1.Rows.Remove(row); // Elimina de la vista
                            MessageBox.Show("Residente y datos relacionados eliminados correctamente.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar el residente: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }

    }
}
