using System;
using System.Windows.Forms;

namespace paee2_WF
{
    public partial class Form1 : Form
    {
        private LectorRecursosSistema lectorRecursosSistema;

        public Form1()
        {
            InitializeComponent();
            lectorRecursosSistema = new LectorRecursosSistema();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnActualizar.Text = "Iniciar";
            }
            else
            {
                ActualizarDatos();
                timer1.Interval = 1000;
                timer1.Start();
                btnActualizar.Text = "Parar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        public void ActualizarDatos()
        {
            try
            {
                this.labelCPU.Text = lectorRecursosSistema.getCPU();
                this.labelDiscoLectura.Text = lectorRecursosSistema.getDatosDisco(DiskData.Read).ToString();
                this.labelDiscoEscritura.Text = lectorRecursosSistema.getDatosDisco(DiskData.Write).ToString();
                this.labelDiscoLecturaEscritura.Text = lectorRecursosSistema.getDatosDisco(DiskData.ReadAndWrite).ToString();
                this.labelRedRecibidos.Text = lectorRecursosSistema.getDatosRed(NetData.Received).ToString();
                this.labelRedEnviados.Text = lectorRecursosSistema.getDatosRed(NetData.Sent).ToString();
                this.labelRedRecibidosEnviados.Text = lectorRecursosSistema.getDatosRed(NetData.ReceivedAndSent).ToString();
                this.labelDiscosLogicos.Text = lectorRecursosSistema.getDiscosLogicos();
                this.labelMemoriaFisica.Text = lectorRecursosSistema.getMemoriaFisica();
                this.labelMemoriaVirtual.Text = lectorRecursosSistema.getMemoriaVirtual();
                this.labelOrdenadorFabricante.Text = lectorRecursosSistema.getOrdenadorFabricante();
                this.labelOrdenadorModelo.Text = lectorRecursosSistema.getOrdenadorModelo();
                string[] procesadores = lectorRecursosSistema.getProcesadores();
                this.labelOrdenadorProcesador.Text = (procesadores != null && procesadores.Length > 0) ? procesadores[0] : "";
                this.labelUsuario.Text = lectorRecursosSistema.getUsuario();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al actualizar datos: " + ex.Message);
            }
        }
    }
}
