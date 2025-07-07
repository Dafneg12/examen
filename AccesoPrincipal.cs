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
        public AccesoPrincipal()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString();
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
            if(pictureBox1.Image != null)
            {
                
                BarcodeReader lector = new BarcodeReader();
                Result resultado = lector.Decode((Bitmap)pictureBox1.Image);
                if (resultado != null) { 
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
                string query = "SELECT r.nombre, r.apellido_paterno FROM Residentes r JOIN Codigos c ON r.id_residente = c.id_residenteS WHERE c.codigo =@codigo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@codigo",codigo);
                

                SqlDataReader reader = cmd.ExecuteReader(); //new

                if (reader.Read()) { 
                 string nombre = reader["nombre"].ToString();
                    string apellido = reader["apellido_paterno"].ToString();
                    txtNombre.Text = nombre;
                    txtApellidos.Text = apellido;
                }
                else
                {
                    MessageBox.Show("codigo qr no encontrado");
                }
            }
        }
    }
}
