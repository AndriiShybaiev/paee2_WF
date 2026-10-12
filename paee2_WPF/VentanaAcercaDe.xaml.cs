using System;
using System.Windows;

namespace paee2_WPF
{
    public partial class VentanaAcercaDe : Window
    {
        public VentanaAcercaDe()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
