using System;
using System.Drawing;
using System.Windows.Forms;

namespace paee2_WF
{
    public partial class Form1 : Form
    {
        private readonly LectorRecursosSistema lector;

        public Form1()
        {
            InitializeComponent();
            lector = new LectorRecursosSistema();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarInformacionEstatica();
            ActualizarDatos();
        }

        private void CargarInformacionEstatica()
        {
            try
            {
                labelOrdenadorFabricante.Text = lector.getOrdenadorFabricante();
                labelOrdenadorModelo.Text = lector.getOrdenadorModelo();
                labelOrdenadorProcesador.Text = string.Join("; ", lector.getProcesadores());
                labelUsuario.Text = lector.getUsuario();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al cargar información estática: " + ex.Message);
            }
        }

        public void ActualizarDatos()
        {
            try
            {
                // CPU
                labelCPU.Text = lector.getCPU();

                // Memoria
                labelMemoriaFisica.Text = lector.getMemoriaFisica();
                labelMemoriaVirtual.Text = lector.getMemoriaVirtual();

                // Disco
                labelDiscosLogicos.Text = lector.getDiscosLogicos();
                labelDiscoLectura.Text = FormatearTasaBytes(lector.getDatosDisco(DiskData.Read));
                labelDiscoEscritura.Text = FormatearTasaBytes(lector.getDatosDisco(DiskData.Write));
                labelDiscoLecturaEscritura.Text = FormatearTasaBytes(lector.getDatosDisco(DiskData.ReadAndWrite));

                // Red
                labelRedRecibidos.Text = FormatearTasaBytes(lector.getDatosRed(NetData.Received));
                labelRedEnviados.Text = FormatearTasaBytes(lector.getDatosRed(NetData.Sent));
                labelRedRecibidosEnviados.Text = FormatearTasaBytes(lector.getDatosRed(NetData.ReceivedAndSent));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al actualizar datos de recursos: " + ex.Message);
            }
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                buttonIniciar.Text = "Iniciar";
                buttonIniciar.BackColor = Color.FromArgb(0, 122, 204);
            }
            else
            {
                ActualizarDatos();
                timer1.Start();
                buttonIniciar.Text = "Parar";
                buttonIniciar.BackColor = Color.FromArgb(204, 51, 51);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private string FormatearTasaBytes(double bytesPerSec)
        {
            if (bytesPerSec >= 1024.0 * 1024.0 * 1024.0)
                return string.Format("{0:0.00} GB/s", bytesPerSec / (1024.0 * 1024.0 * 1024.0));
            if (bytesPerSec >= 1024.0 * 1024.0)
                return string.Format("{0:0.00} MB/s", bytesPerSec / (1024.0 * 1024.0));
            if (bytesPerSec >= 1024.0)
                return string.Format("{0:0.00} KB/s", bytesPerSec / 1024.0);
            return string.Format("{0:0.00} B/s", bytesPerSec);
        }
    }
}
