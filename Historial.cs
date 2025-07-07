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
        private int idGuardiaActual;
        private DateTime fechaActual;
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
            AccesoPrincipal principal = new AccesoPrincipal(idGuardiaActual,fechaActual);
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
            connection = new SqlConnection(connectionString);

            cboTipoPersona.SelectedIndex = 0;
            cboTipoAcceso.SelectedIndex = 0;

            try
            {
                connection.Open();
                cargarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void aplicarFiltros()
        {
            DateTime fecha = dateTimePicker1.Value.Date;
            string tipoPersona = cboTipoPersona.SelectedItem?.ToString() ?? "Todos";
            string tipoAcceso = cboTipoAcceso.SelectedItem?.ToString() ?? "Todos";

            string query = @" SELECT a.id_acceso, a.fecha, a.tipo_acceso, r.nombre AS nombre_residente, i.nombre AS nombre_invitado, g.nombre AS nombre_guardia
                              FROM Accesos a
                              LEFT JOIN Residentes r ON a.id_residente = r.id_residente
                              LEFT JOIN Invitados i ON a.id_invitado = i.id_invitado
                              LEFT JOIN Guardias g ON a.id_guardia = g.id_guardia
                              WHERE 1 = 1";

            // Filtro por fecha
            query += " AND CAST(a.fecha AS DATE) = @fecha";

            // Filtro por tipo de persona
            if (tipoPersona == "Residente")
                query += " AND a.id_residente IS NOT NULL AND a.id_invitado IS NULL";
            else if (tipoPersona == "Invitado")
                query += " AND a.id_invitado IS NOT NULL AND a.id_residente IS NULL";

            // Filtro por tipo de acceso
            if (tipoAcceso == "Entrada" || tipoAcceso == "Salida")
                query += " AND a.tipo_acceso = @tipoAcceso";

            query += " ORDER BY a.fecha DESC";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fecha", fecha);

                if (tipoAcceso == "Entrada" || tipoAcceso == "Salida")
                    cmd.Parameters.AddWithValue("@tipoAcceso", tipoAcceso);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable historial = new DataTable();
                da.Fill(historial);
                dataGridView1.DataSource = historial;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros: " + ex.Message);
            }
        }

        private void cargarTodo()
        {
            string query = @" SELECT a.id_acceso, a.fecha, a.tipo_acceso, r.nombre AS nombre_residente, i.nombre AS nombre_invitado, g.nombre AS nombre_guardia
                              FROM Accesos a
                              LEFT JOIN Residentes r ON a.id_residente = r.id_residente
                              LEFT JOIN Invitados i ON a.id_invitado = i.id_invitado
                              LEFT JOIN Guardias g ON a.id_guardia = g.id_guardia
                              ORDER BY a.fecha DESC";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable historial = new DataTable();
                da.Fill(historial);
                dataGridView1.DataSource = historial;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todos los accesos: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            aplicarFiltros();
        }

        private void cboTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            aplicarFiltros();
        }

        private void cboTipoAcceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            aplicarFiltros();
        }
    }
}
