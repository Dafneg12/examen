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
