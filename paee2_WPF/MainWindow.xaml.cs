using System;
using System.Windows;
using System.Windows.Threading;

namespace paee2_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LectorRecursosSistema lector;
        private DispatcherTimer dispatcherTimer;

        public MainWindow()
        {
            InitializeComponent();
            lector = new LectorRecursosSistema();

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CargarDatosEstaticos();
            ActualizarDatos();
        }

        private void CargarDatosEstaticos()
        {
            try
            {
                labelOrdenadorFabricante.Content = lector.getOrdenadorFabricante();
                labelOrdenadorModelo.Content = lector.getOrdenadorModelo();

                string[] procesadores = lector.getProcesadores();
                labelOrdenadorProcesador.Content = (procesadores != null && procesadores.Length > 0)
                    ? procesadores[0]
                    : "-";

                labelUsuario.Content = lector.getUsuario();
            }
            catch
            {
                // Fallback
            }
        }

        private void ActualizarDatos()
        {
            try
            {
                labelCPU.Content = lector.getCPU();
                labelMemoriaFisica.Content = lector.getMemoriaFisica();
                labelMemoriaVirtual.Content = lector.getMemoriaVirtual();
                labelDiscosLogicos.Content = lector.getDiscosLogicos();

                labelDiscoLectura.Content = FormatearBytesPorSegundo(lector.getDatosDisco(DiskData.Read));
                labelDiscoEscritura.Content = FormatearBytesPorSegundo(lector.getDatosDisco(DiskData.Write));
                labelDiscoLecturaEscritura.Content = FormatearBytesPorSegundo(lector.getDatosDisco(DiskData.ReadAndWrite));

                labelRedRecibidos.Content = FormatearBytesPorSegundo(lector.getDatosRed(NetData.Received));
                labelRedEnviados.Content = FormatearBytesPorSegundo(lector.getDatosRed(NetData.Sent));
                labelRedRecibidosEnviados.Content = FormatearBytesPorSegundo(lector.getDatosRed(NetData.ReceivedAndSent));
            }
            catch
            {
                // Fallback
            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            ActualizarDatos();

            if (!dispatcherTimer.IsEnabled)
            {
                dispatcherTimer.Start();
                btnActualizar.Content = "Parar";
            }
            else
            {
                dispatcherTimer.Stop();
                btnActualizar.Content = "Actualizar";
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private string FormatearBytesPorSegundo(double bytesPorSegundo)
        {
            if (bytesPorSegundo >= 1024.0 * 1024.0 * 1024.0)
                return string.Format("{0:0.00} GB/s", bytesPorSegundo / (1024.0 * 1024.0 * 1024.0));
            if (bytesPorSegundo >= 1024.0 * 1024.0)
                return string.Format("{0:0.00} MB/s", bytesPorSegundo / (1024.0 * 1024.0));
            if (bytesPorSegundo >= 1024.0)
                return string.Format("{0:0.00} KB/s", bytesPorSegundo / 1024.0);
            return string.Format("{0:0.00} B/s", bytesPorSegundo);
        }
    }
}
