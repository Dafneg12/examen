using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
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
                }
            }
        }
    }
}
