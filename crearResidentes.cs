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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Text.RegularExpressions;

namespace examen
{
    public partial class crearResidentes : Form
    {
        public crearResidentes()
        {
            InitializeComponent();

            string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";
            int idR;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('Residentes') + 1", connection);

                try
                {
                    connection.Open();

                    decimal resultado = (decimal)command.ExecuteScalar();
                    idR = Convert.ToInt32(resultado);

                    txtIdResidente.Text = idR.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el próximo ID: " + ex.Message);
                }
            }
        }

        public bool validarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellidoPaterno.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoMaterno.Text) || string.IsNullOrWhiteSpace(txtCalle.Text) ||
                string.IsNullOrWhiteSpace(txtNumero.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }

            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                return false;
            }

            return true;
        }

        private void crearResidentes_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud gestionResidentes = new crud();
            gestionResidentes.ShowDialog();
            this.Close();
        }
    }
}
