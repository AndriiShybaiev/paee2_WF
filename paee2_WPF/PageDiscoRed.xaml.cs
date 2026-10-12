using System;
using System.Windows.Controls;

namespace paee2_WPF
{
    public partial class PageDiscoRed : Page, IActualizable
    {
        public PageDiscoRed()
        {
            InitializeComponent();
        }

        public void ActualizarDatos(LectorRecursosSistema lector)
        {
            if (lector == null) return;

            labelDiscosLogicos.Content = lector.getDiscosLogicos();
            labelDiscoLectura.Content = lector.getDatosDisco(DiskData.Read).ToString("F2") + " B/s";
            labelDiscoEscritura.Content = lector.getDatosDisco(DiskData.Write).ToString("F2") + " B/s";
            labelDiscoLecturaEscritura.Content = lector.getDatosDisco(DiskData.ReadAndWrite).ToString("F2") + " B/s";
            labelRedRecibidos.Content = lector.getDatosRed(NetData.Received).ToString("F2") + " B/s";
            labelRedEnviados.Content = lector.getDatosRed(NetData.Sent).ToString("F2") + " B/s";
            labelRedRecibidosEnviados.Content = lector.getDatosRed(NetData.ReceivedAndSent).ToString("F2") + " B/s";
        }
    }
}
