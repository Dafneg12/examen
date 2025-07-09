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

//prueba
namespace examen
{
    public partial class crearResidentes : Form
    {
        string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";
        int idR;
        private int idGuardiaActual;
        private DateTime fechaActual;

        public crearResidentes(int idGuardia, DateTime fechaActual)
        {
            InitializeComponent();
            idGuardiaActual = idGuardia;
            this.fechaActual = fechaActual;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT ISNULL(MAX(id_residente), 0) + 1 FROM Residentes", connection);

                try
                {
                    connection.Open();
                    object resultado = command.ExecuteScalar();
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud gestionResidentes = new crud(idGuardiaActual,fechaActual);
            gestionResidentes.ShowDialog();
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("Los datos no son validos, intenta de nuevo");
            }
            else
            {
                string nombre = txtNombre.Text.Trim();
                string apellido_paterno = txtApellidoPaterno.Text.Trim();
                string apellido_materno = txtApellidoMaterno.Text.Trim();
                string calle = txtCalle.Text.Trim();
                string numero = txtNumero.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string contraseña = txtContraseña.Text.Trim();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // 1. Insertar en Residentes y obtener el ID generado
                        string queryResidente = @"INSERT INTO Residentes(nombre, apellido_paterno, apellido_materno, calle, numero, telefono)
                                                VALUES (@nombre, @apellido_paterno, @apellido_materno, @calle, @numero, @telefono);
                                                SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdResidente = new SqlCommand(queryResidente, connection, transaction);

                        cmdResidente.Parameters.AddWithValue("@nombre", nombre);
                        cmdResidente.Parameters.AddWithValue("@apellido_paterno", apellido_paterno);
                        cmdResidente.Parameters.AddWithValue("@apellido_materno", apellido_materno);
                        cmdResidente.Parameters.AddWithValue("@calle", calle);
                        cmdResidente.Parameters.AddWithValue("@numero", numero);
                        cmdResidente.Parameters.AddWithValue("@telefono", telefono);

                        object result = cmdResidente.ExecuteScalar();
                        int nuevoIdResidente = Convert.ToInt32(result);

                        // 2. Insertar en UsuariosResidentes
                        string queryUsuario = @"INSERT INTO UsuariosResidentes (id_residente, correo, contraseña)
                                                VALUES (@id_residente, @correo, @contraseña);";

                        SqlCommand cmdUsuario = new SqlCommand(queryUsuario, connection, transaction);

                        cmdUsuario.Parameters.AddWithValue("@id_residente", nuevoIdResidente);
                        cmdUsuario.Parameters.AddWithValue("@correo", correo);
                        cmdUsuario.Parameters.AddWithValue("@contraseña", contraseña);

                        cmdUsuario.ExecuteNonQuery();

                        // 3. Confirmar la transacción
                        transaction.Commit();

                        MessageBox.Show("Residente y usuario guardados correctamente.");
                        txtIdResidente.Text = nuevoIdResidente.ToString(); 

                        txtNombre.Clear();
                        txtApellidoPaterno.Clear();
                        txtApellidoMaterno.Clear();
                        txtCalle.Clear();
                        txtNumero.Clear();
                        txtTelefono.Clear();
                        txtCorreo.Clear();
                        txtContraseña.Clear();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                }
            }
        }
    }
}
