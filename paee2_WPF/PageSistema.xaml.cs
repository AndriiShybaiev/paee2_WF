using System;
using System.Windows.Controls;

namespace paee2_WPF
{
    public partial class PageSistema : Page, IActualizable
    {
        public PageSistema()
        {
            InitializeComponent();
        }

        public void ActualizarDatos(LectorRecursosSistema lector)
        {
            if (lector == null) return;

            labelOrdenadorFabricante.Content = lector.getOrdenadorFabricante();
            labelOrdenadorModelo.Content = lector.getOrdenadorModelo();
            string[] procesadores = lector.getProcesadores();
            labelOrdenadorProcesador.Content = (procesadores != null && procesadores.Length > 0) ? string.Join(", ", procesadores) : "-";
            labelUsuario.Content = lector.getUsuario();
        }
    }
}
