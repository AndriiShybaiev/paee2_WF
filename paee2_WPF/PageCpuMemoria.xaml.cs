using System;
using System.Windows.Controls;

namespace paee2_WPF
{
    public partial class PageCpuMemoria : Page, IActualizable
    {
        public PageCpuMemoria()
        {
            InitializeComponent();
        }

        public void ActualizarDatos(LectorRecursosSistema lector)
        {
            if (lector == null) return;

            labelCPU.Content = lector.getCPU();
            labelMemoriaFisica.Content = lector.getMemoriaFisica();
            labelMemoriaVirtual.Content = lector.getMemoriaVirtual();
        }
    }
}
