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
            lblFecha.Text = DateTime.Now.ToString();
            CargarComboBox();

        }
        private void CargarComboBox()
        {
            string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";
            string query = "SELECT id_guardia, nombre+' '+apellido_paterno +' '+ apellido_materno as nombre FROM Guardias"; 
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
            if (cboGuardia.SelectedIndex > 0)
            {
                int idGuardia = Convert.ToInt32(cboGuardia.SelectedValue);
                DateTime fecha = DateTime.Parse(lblFecha.Text);
                this.Hide();
                crud gestionResidentes = new crud(idGuardia,fecha);
                gestionResidentes.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un guardia primero.");
            }
        }

        private void btnAccesoPrincipal_Click(object sender, EventArgs e)
        {
            if (cboGuardia.SelectedIndex > 0)
            {
                DateTime fecha = DateTime.Parse(lblFecha.Text);
                int idGuardia = Convert.ToInt32(cboGuardia.SelectedValue);
                MessageBox.Show("ID del guardia seleccionado: " + idGuardia);
                // Pasar el ID y la fecha al formulario principal
                AccesoPrincipal principal = new AccesoPrincipal(idGuardia, fecha);
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un guardia primero."); 
            }
           
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (cboGuardia.SelectedIndex > 0)
            {
                int idGuardia = Convert.ToInt32(cboGuardia.SelectedValue);
                DateTime fecha = DateTime.Parse(lblFecha.Text);
                this.Hide();
                Historial hist = new Historial(idGuardia,fecha);
                hist.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un guardia primero.");
            }
        }
    }
}
