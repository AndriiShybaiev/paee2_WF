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
        private readonly LectorRecursosSistema _lector;
        private readonly DispatcherTimer _dispatcherTimer;

        private readonly PageCpuMemoria _pageCpuMemoria;
        private readonly PageDiscoRed _pageDiscoRed;
        private readonly PageSistema _pageSistema;

        public MainWindow()
        {
            InitializeComponent();

            _lector = new LectorRecursosSistema();

            _pageCpuMemoria = new PageCpuMemoria();
            _pageDiscoRed = new PageDiscoRed();
            _pageSistema = new PageSistema();

            _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Tick += dispatcherTimer_Tick;
            _dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NavegarAPagina(_pageCpuMemoria);
        }

        private void btnNavCpuMemoria_Click(object sender, RoutedEventArgs e)
        {
            NavegarAPagina(_pageCpuMemoria);
        }

        private void btnNavDiscoRed_Click(object sender, RoutedEventArgs e)
        {
            NavegarAPagina(_pageDiscoRed);
        }

        private void btnNavSistema_Click(object sender, RoutedEventArgs e)
        {
            NavegarAPagina(_pageSistema);
        }

        private void btnNavAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            VentanaAcercaDe dlg = new VentanaAcercaDe();
            dlg.Owner = this;
            dlg.ShowDialog();
        }

        private void NavegarAPagina(object page)
        {
            mainFrame.Navigate(page);
            if (page is IActualizable actualizable)
            {
                actualizable.ActualizarDatos(_lector);
            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            ActualizarPaginaActiva();

            if (!_dispatcherTimer.IsEnabled)
            {
                _dispatcherTimer.Start();
                btnActualizar.Content = "Parar";
            }
            else
            {
                _dispatcherTimer.Stop();
                btnActualizar.Content = "Actualizar";
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            ActualizarPaginaActiva();
        }

        private void ActualizarPaginaActiva()
        {
            if (mainFrame.Content is IActualizable actualizable)
            {
                actualizable.ActualizarDatos(_lector);
            }
        }
    }
}
