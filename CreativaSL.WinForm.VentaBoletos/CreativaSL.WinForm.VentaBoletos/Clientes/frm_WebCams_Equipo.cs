using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace CreativaSL.WinForm.VentaBoletos.Clientes
{
    public partial class frm_WebCams_Equipo : Form
    {

        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;

        public frm_WebCams_Equipo()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
            {
                cbxDispositivo.Items.Add(Dispositivos[0].Name.ToString());
                cbxDispositivo.Text = cbxDispositivo.Items[0].ToString();
            }
        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }
            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }

        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            imagenCamara.Image = Imagen;

        }
        //Ahora vamos a codificar el botón de iniciar una vez tengamos creados todos nuestros métodos..
        // dentro del nuestro Boton  colocamos lo siguiente:

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (this.btnIniciar.Text == "Iniciar")
            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivo.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    lblEstado.Text = "Ejecutando Dispositivo…";
                    btnIniciar.Text = "Detener";
                    cbxDispositivo.Enabled = false;
                    groupBox1.Text = DispositivoDeVideo[cbxDispositivo.SelectedIndex].Name.ToString();
                }
                else
                    lblEstado.Text = "Error: No se encuenta el dispositivo";
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    lblEstado.Text = "Dispositivo Detenido…";
                    btnIniciar.Text = "Iniciar";
                    cbxDispositivo.Enabled = true;
                }
            }
        }
    }
}
