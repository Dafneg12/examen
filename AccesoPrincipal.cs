using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;

namespace examen
{
    public partial class AccesoPrincipal : Form
    {
        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice camara;
        private int idGuardiaActual;
        private DateTime fechaActual;
        public AccesoPrincipal(int idGuardia, DateTime fechaActual)
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString();
            idGuardiaActual = idGuardia;
            this.fechaActual = fechaActual;
        }

        private void btnInicios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial hist = new Historial();
            hist.ShowDialog();
            this.Close();

        }

        private void btnGestionRes_Click(object sender, EventArgs e)
        {
            this.Hide();
            crud crud = new crud();
            crud.ShowDialog();
            this.Close();
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (dispositivos.Count > 0)
            {
                camara = new VideoCaptureDevice(dispositivos[0].MonikerString);
                camara.NewFrame += new NewFrameEventHandler(CapturarFrame);
                camara.Start();
                timer1.Start();
            }
            else
            {
                MessageBox.Show("No se encontro ninguna camara");
            }
        }

        private void CapturarFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                BarcodeReader lector = new BarcodeReader();
                Result resultado = lector.Decode((Bitmap)pictureBox1.Image);
                if (resultado != null)
                {
                    txtCodigo.Text = resultado.Text;
                    timer1.Stop();
                    camara.SignalToStop();
                    camara.WaitForStop();
                    MessageBox.Show("codigo detectado " + resultado.Text);
                    BuscarBase(resultado.Text);
                }
            }
        }
        private void BuscarBase(string codigo)
        {
            string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //verificar si es residente o invitado
                //string ver = "SELECT COUNT(*) FROM Codigos WHERE codigo = @codigo";
                //SqlCommand cmdCheck = new SqlCommand(ver, conn);
                //cmdCheck.Parameters.AddWithValue("@codigo", codigo);
                //int count = (int)cmdCheck.ExecuteScalar();

                //if (count > 0)
                //{
                //    string query = "SELECT r.nombre, r.apellido_paterno, r.id_residente FROM Residentes r JOIN Codigos c ON r.id_residente = c.id_residenteS WHERE c.codigo =@codigo";
                //    SqlCommand cmd = new SqlCommand(query, conn);
                //    cmd.Parameters.AddWithValue("@codigo", codigo);


                //    SqlDataReader reader = cmd.ExecuteReader(); //new

                //    if (reader.Read())
                //    {
                //        string nombre = reader["nombre"].ToString();
                //        string apellido = reader["apellido_paterno"].ToString();
                //        string dat = lblFecha.Text.ToString();
                //        int id = (int)reader["id_residente"];
                //        txtNombre.Text = nombre;
                //        txtApellidos.Text = apellido;
                //        lblTipo.Text = "Residente";
                //        txtID.Text = id.ToString();
                //    }
                //    else
                //    {
                //        MessageBox.Show("codigo qr no encontrado");
                //    }
                //}//termina de verificar en residentes
                //else
                //{
                //string verf = "SELECT COUNT(*) FROM Invitados WHERE codigo = @codigo";
                //SqlCommand cmdChecks = new SqlCommand(verf, conn);
                //cmdChecks.Parameters.AddWithValue("@codigo", codigo);
                //int counts = (int)cmdCheck.ExecuteScalar();
                //if (counts > 0) {
                
                string query = "SELECT i.nombre as nombre, i.apellido_paterno as apellido_paterno, i.id_invitado as id_invitado, r.nombre as nombreResidente,CAST(i.fecha AS DATE) AS fechaCodigo FROM Invitados i JOIN Residentes r ON i.id_residente = r.id_residente WHERE i.codigo = @codigo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);


                SqlDataReader reader = cmd.ExecuteReader(); //new

                if (reader.Read())
                {
                    DateTime fechaCodigo = Convert.ToDateTime(reader["fechaCodigo"]);
                    DateTime fechaHoy = DateTime.Now.Date;

                    if (fechaCodigo != fechaHoy)
                    {
                        MessageBox.Show("Código QR caducado. Solo es válido el día de su generación.");
                        return;
                    }
                    string nombre = reader["nombre"].ToString();
                    string apellido = reader["apellido_paterno"].ToString();
                    string dat = lblFecha.Text.ToString();
                    string quieninvita = reader["nombreResidente"].ToString();
                    int id = (int)reader["id_invitado"];
                    txtNombre.Text = nombre;
                    txtApellidos.Text = apellido;
                    lblTipo.Text = "Invitado";
                    txtID.Text = id.ToString();
                    txtInvitado.Text = quieninvita;
                }
                else
                {
                    MessageBox.Show("codigo qr no encontrado");
                }
                //    }
                //}
            }
        }
        private void CrearHistorial(string nombre, string apellido, string tipoAcceso)
        {


        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";
            int id = int.Parse(txtID.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (lblTipo.Text == "Residente")
                {
                    string insert = "INSERT into Accesos(fecha, tipo_acceso, id_residente, id_guardia) VALUES " +
                           "(@fecha, @tipo, @idresidente, @idguardia)";
                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@fecha", fechaActual);
                    cmd.Parameters.AddWithValue("@tipo", "Entrada");
                    cmd.Parameters.AddWithValue("@idresidente", id);
                    cmd.Parameters.AddWithValue("@idguardia", idGuardiaActual);
                }
                else if (lblTipo.Text == "Invitado")
                {
                    string insert = "INSERT into Accesos(fecha, tipo_acceso, id_invitado, id_guardia) VALUES " +
                           "(@fecha, @tipo, @idinvitado, @idguardia)";
                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@fecha", fechaActual);
                    cmd.Parameters.AddWithValue("@tipo", "Entrada");
                    cmd.Parameters.AddWithValue("@idinvitado", id);
                    cmd.Parameters.AddWithValue("@idguardia", idGuardiaActual);
                }//final using
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entrada registrada correctamente.");
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";
            int id = int.Parse(txtID.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if (lblTipo.Text == "Residente")
                {
                    string insert = "INSERT into Accesos(fecha, tipo_acceso, id_residente, id_guardia) VALUES " +
                           "(@fecha, @tipo, @idresidente, @idguardia)";
                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@fecha", fechaActual);
                    cmd.Parameters.AddWithValue("@tipo", "Salida");
                    cmd.Parameters.AddWithValue("@idresidente", id);
                    cmd.Parameters.AddWithValue("@idguardia", idGuardiaActual);
                }
                else if (lblTipo.Text == "Invitado")
                {
                    string insert = "INSERT into Accesos(fecha, tipo_acceso, id_invitado, id_guardia) VALUES " +
                           "(@fecha, @tipo, @idinvitado, @idguardia) WHERE ";
                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@fecha", fechaActual);
                    cmd.Parameters.AddWithValue("@tipo", "Salida");
                    cmd.Parameters.AddWithValue("@idinvitado", id);
                    cmd.Parameters.AddWithValue("@idguardia", idGuardiaActual);
                }//final using
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entrada registrada correctamente.");
            }
        }

        private void CargarComboBox()
        {
            string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";
            string query = "SELECT id_residente AS id_persona, 'Residente - ' + nombre + ' ' + apellido_paterno + ' ' + apellido_materno AS nombre  FROM Residentes UNION SELECT id_invitado AS id_persona, 'Invitado - ' + nombre + ' ' + apellido_paterno + ' ' + apellido_materno FROM Invitados";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader(); //new

                DataTable dt = new DataTable();
                dt.Load(reader);

                DataRow fila = dt.NewRow();
                fila["id_persona"] = 0;
                fila["nombre"] = "Seleccione una persona";
                dt.Rows.InsertAt(fila, 0);

                cboTipo.DisplayMember = "nombre";
                cboTipo.ValueMember = "id_persona";
                cboTipo.DataSource = dt;

            }
        }

        private void AccesoPrincipal_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cboTipo.Text;
            if(seleccion.StartsWith("Invitado -"))
            {
                btnEscanear.Enabled = true;
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtID.Text = "";
                lblTipo.Text = "Invitado";
            }
            else
            {
                btnEscanear.Enabled = false;

                int idResidente = (int)cboTipo.SelectedValue;

                // Consultar datos completos del residente
                string connectionString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SistemaAccesos; Integrated Security = True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT nombre, apellido_paterno, apellido_materno FROM Residentes WHERE id_residente = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idResidente);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNombre.Text = reader["nombre"].ToString();
                                txtApellidos.Text = reader["apellido_paterno"].ToString() + " " + reader["apellido_materno"].ToString();
                                txtID.Text = idResidente.ToString();
                                lblTipo.Text = "Residente";
                            }
                            
                        }
                    }
                }
            }

        }
    }
}
