namespace paee2_WF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHeaderCPU = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelHeaderMemoria = new System.Windows.Forms.Label();
            this.labelDescMemoriaFisica = new System.Windows.Forms.Label();
            this.labelMemoriaFisica = new System.Windows.Forms.Label();
            this.labelDescMemoriaVirtual = new System.Windows.Forms.Label();
            this.labelMemoriaVirtual = new System.Windows.Forms.Label();
            this.labelHeaderDisco = new System.Windows.Forms.Label();
            this.labelDescDiscosLogicos = new System.Windows.Forms.Label();
            this.labelDiscosLogicos = new System.Windows.Forms.Label();
            this.labelDescDiscoLectura = new System.Windows.Forms.Label();
            this.labelDiscoLectura = new System.Windows.Forms.Label();
            this.labelDescDiscoEscritura = new System.Windows.Forms.Label();
            this.labelDiscoEscritura = new System.Windows.Forms.Label();
            this.labelDescDiscoLecturaEscritura = new System.Windows.Forms.Label();
            this.labelDiscoLecturaEscritura = new System.Windows.Forms.Label();
            this.labelHeaderRed = new System.Windows.Forms.Label();
            this.labelDescRedRecibidos = new System.Windows.Forms.Label();
            this.labelRedRecibidos = new System.Windows.Forms.Label();
            this.labelDescRedEnviados = new System.Windows.Forms.Label();
            this.labelRedEnviados = new System.Windows.Forms.Label();
            this.labelDescRedRecibidosEnviados = new System.Windows.Forms.Label();
            this.labelRedRecibidosEnviados = new System.Windows.Forms.Label();
            this.labelHeaderOrdenador = new System.Windows.Forms.Label();
            this.labelDescFabricante = new System.Windows.Forms.Label();
            this.labelOrdenadorFabricante = new System.Windows.Forms.Label();
            this.labelDescModelo = new System.Windows.Forms.Label();
            this.labelOrdenadorModelo = new System.Windows.Forms.Label();
            this.labelDescProcesador = new System.Windows.Forms.Label();
            this.labelOrdenadorProcesador = new System.Windows.Forms.Label();
            this.labelDescUsuario = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderCPU, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCPU, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderMemoria, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDescMemoriaFisica, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelMemoriaFisica, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDescMemoriaVirtual, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelMemoriaVirtual, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderDisco, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelDescDiscosLogicos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelDiscosLogicos, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelDescDiscoLectura, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelDiscoLectura, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelDescDiscoEscritura, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelDiscoEscritura, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelDescDiscoLecturaEscritura, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelDiscoLecturaEscritura, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderRed, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelDescRedRecibidos, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelRedRecibidos, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelDescRedEnviados, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelRedEnviados, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelDescRedRecibidosEnviados, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelRedRecibidosEnviados, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderOrdenador, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.labelDescFabricante, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.labelOrdenadorFabricante, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.labelDescModelo, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.labelOrdenadorModelo, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.labelDescProcesador, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.labelOrdenadorProcesador, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.labelDescUsuario, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.labelUsuario, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 1, 18);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 19;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelHeaderCPU
            // 
            this.labelHeaderCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeaderCPU.AutoSize = true;
            this.labelHeaderCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderCPU.Location = new System.Drawing.Point(100, 0);
            this.labelHeaderCPU.Name = "labelHeaderCPU";
            this.labelHeaderCPU.Size = new System.Drawing.Size(46, 20);
            this.labelHeaderCPU.TabIndex = 0;
            this.labelHeaderCPU.Text = "CPU";
            this.labelHeaderCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCPU
            // 
            this.labelCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCPU.AutoSize = true;
            this.labelCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.Location = new System.Drawing.Point(159, 0);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(10, 28);
            this.labelCPU.TabIndex = 1;
            this.labelCPU.Text = "-";
            this.labelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeaderMemoria
            // 
            this.labelHeaderMemoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeaderMemoria.AutoSize = true;
            this.labelHeaderMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderMemoria.Location = new System.Drawing.Point(70, 28);
            this.labelHeaderMemoria.Name = "labelHeaderMemoria";
            this.labelHeaderMemoria.Size = new System.Drawing.Size(77, 20);
            this.labelHeaderMemoria.TabIndex = 2;
            this.labelHeaderMemoria.Text = "Memoria";
            this.labelHeaderMemoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDescMemoriaFisica
            // 
            this.labelDescMemoriaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescMemoriaFisica.AutoSize = true;
            this.labelDescMemoriaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescMemoriaFisica.Location = new System.Drawing.Point(110, 56);
            this.labelDescMemoriaFisica.Name = "labelDescMemoriaFisica";
            this.labelDescMemoriaFisica.Size = new System.Drawing.Size(37, 13);
            this.labelDescMemoriaFisica.TabIndex = 3;
            this.labelDescMemoriaFisica.Text = "Física";
            this.labelDescMemoriaFisica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMemoriaFisica
            // 
            this.labelMemoriaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMemoriaFisica.AutoSize = true;
            this.labelMemoriaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemoriaFisica.Location = new System.Drawing.Point(159, 56);
            this.labelMemoriaFisica.Name = "labelMemoriaFisica";
            this.labelMemoriaFisica.Size = new System.Drawing.Size(10, 22);
            this.labelMemoriaFisica.TabIndex = 4;
            this.labelMemoriaFisica.Text = "-";
            this.labelMemoriaFisica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescMemoriaVirtual
            // 
            this.labelDescMemoriaVirtual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescMemoriaVirtual.AutoSize = true;
            this.labelDescMemoriaVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescMemoriaVirtual.Location = new System.Drawing.Point(111, 78);
            this.labelDescMemoriaVirtual.Name = "labelDescMemoriaVirtual";
            this.labelDescMemoriaVirtual.Size = new System.Drawing.Size(36, 13);
            this.labelDescMemoriaVirtual.TabIndex = 5;
            this.labelDescMemoriaVirtual.Text = "Virtual";
            this.labelDescMemoriaVirtual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMemoriaVirtual
            // 
            this.labelMemoriaVirtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMemoriaVirtual.AutoSize = true;
            this.labelMemoriaVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemoriaVirtual.Location = new System.Drawing.Point(159, 78);
            this.labelMemoriaVirtual.Name = "labelMemoriaVirtual";
            this.labelMemoriaVirtual.Size = new System.Drawing.Size(10, 22);
            this.labelMemoriaVirtual.TabIndex = 6;
            this.labelMemoriaVirtual.Text = "-";
            this.labelMemoriaVirtual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeaderDisco
            // 
            this.labelHeaderDisco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeaderDisco.AutoSize = true;
            this.labelHeaderDisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderDisco.Location = new System.Drawing.Point(92, 100);
            this.labelHeaderDisco.Name = "labelHeaderDisco";
            this.labelHeaderDisco.Size = new System.Drawing.Size(55, 20);
            this.labelHeaderDisco.TabIndex = 7;
            this.labelHeaderDisco.Text = "Disco";
            this.labelHeaderDisco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDescDiscosLogicos
            // 
            this.labelDescDiscosLogicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescDiscosLogicos.AutoSize = true;
            this.labelDescDiscosLogicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescDiscosLogicos.Location = new System.Drawing.Point(70, 128);
            this.labelDescDiscosLogicos.Name = "labelDescDiscosLogicos";
            this.labelDescDiscosLogicos.Size = new System.Drawing.Size(77, 13);
            this.labelDescDiscosLogicos.TabIndex = 8;
            this.labelDescDiscosLogicos.Text = "Discos lógicos";
            this.labelDescDiscosLogicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDiscosLogicos
            // 
            this.labelDiscosLogicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDiscosLogicos.AutoSize = true;
            this.labelDiscosLogicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscosLogicos.Location = new System.Drawing.Point(159, 128);
            this.labelDiscosLogicos.Name = "labelDiscosLogicos";
            this.labelDiscosLogicos.Size = new System.Drawing.Size(10, 22);
            this.labelDiscosLogicos.TabIndex = 9;
            this.labelDiscosLogicos.Text = "-";
            this.labelDiscosLogicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescDiscoLectura
            // 
            this.labelDescDiscoLectura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescDiscoLectura.AutoSize = true;
            this.labelDescDiscoLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescDiscoLectura.Location = new System.Drawing.Point(104, 150);
            this.labelDescDiscoLectura.Name = "labelDescDiscoLectura";
            this.labelDescDiscoLectura.Size = new System.Drawing.Size(43, 13);
            this.labelDescDiscoLectura.TabIndex = 10;
            this.labelDescDiscoLectura.Text = "Lectura";
            this.labelDescDiscoLectura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDiscoLectura
            // 
            this.labelDiscoLectura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDiscoLectura.AutoSize = true;
            this.labelDiscoLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoLectura.Location = new System.Drawing.Point(159, 150);
            this.labelDiscoLectura.Name = "labelDiscoLectura";
            this.labelDiscoLectura.Size = new System.Drawing.Size(10, 22);
            this.labelDiscoLectura.TabIndex = 11;
            this.labelDiscoLectura.Text = "-";
            this.labelDiscoLectura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescDiscoEscritura
            // 
            this.labelDescDiscoEscritura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescDiscoEscritura.AutoSize = true;
            this.labelDescDiscoEscritura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescDiscoEscritura.Location = new System.Drawing.Point(99, 172);
            this.labelDescDiscoEscritura.Name = "labelDescDiscoEscritura";
            this.labelDescDiscoEscritura.Size = new System.Drawing.Size(48, 13);
            this.labelDescDiscoEscritura.TabIndex = 12;
            this.labelDescDiscoEscritura.Text = "Escritura";
            this.labelDescDiscoEscritura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDiscoEscritura
            // 
            this.labelDiscoEscritura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDiscoEscritura.AutoSize = true;
            this.labelDiscoEscritura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoEscritura.Location = new System.Drawing.Point(159, 172);
            this.labelDiscoEscritura.Name = "labelDiscoEscritura";
            this.labelDiscoEscritura.Size = new System.Drawing.Size(10, 22);
            this.labelDiscoEscritura.TabIndex = 13;
            this.labelDiscoEscritura.Text = "-";
            this.labelDiscoEscritura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescDiscoLecturaEscritura
            // 
            this.labelDescDiscoLecturaEscritura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescDiscoLecturaEscritura.AutoSize = true;
            this.labelDescDiscoLecturaEscritura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescDiscoLecturaEscritura.Location = new System.Drawing.Point(48, 194);
            this.labelDescDiscoLecturaEscritura.Name = "labelDescDiscoLecturaEscritura";
            this.labelDescDiscoLecturaEscritura.Size = new System.Drawing.Size(99, 13);
            this.labelDescDiscoLecturaEscritura.TabIndex = 14;
            this.labelDescDiscoLecturaEscritura.Text = "Lectura / Escritura";
            this.labelDescDiscoLecturaEscritura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDiscoLecturaEscritura
            // 
            this.labelDiscoLecturaEscritura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDiscoLecturaEscritura.AutoSize = true;
            this.labelDiscoLecturaEscritura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoLecturaEscritura.Location = new System.Drawing.Point(159, 194);
            this.labelDiscoLecturaEscritura.Name = "labelDiscoLecturaEscritura";
            this.labelDiscoLecturaEscritura.Size = new System.Drawing.Size(10, 22);
            this.labelDiscoLecturaEscritura.TabIndex = 15;
            this.labelDiscoLecturaEscritura.Text = "-";
            this.labelDiscoLecturaEscritura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeaderRed
            // 
            this.labelHeaderRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeaderRed.AutoSize = true;
            this.labelHeaderRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderRed.Location = new System.Drawing.Point(105, 216);
            this.labelHeaderRed.Name = "labelHeaderRed";
            this.labelHeaderRed.Size = new System.Drawing.Size(42, 20);
            this.labelHeaderRed.TabIndex = 16;
            this.labelHeaderRed.Text = "Red";
            this.labelHeaderRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDescRedRecibidos
            // 
            this.labelDescRedRecibidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescRedRecibidos.AutoSize = true;
            this.labelDescRedRecibidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescRedRecibidos.Location = new System.Drawing.Point(93, 244);
            this.labelDescRedRecibidos.Name = "labelDescRedRecibidos";
            this.labelDescRedRecibidos.Size = new System.Drawing.Size(54, 13);
            this.labelDescRedRecibidos.TabIndex = 17;
            this.labelDescRedRecibidos.Text = "Recibidos";
            this.labelDescRedRecibidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRedRecibidos
            // 
            this.labelRedRecibidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRedRecibidos.AutoSize = true;
            this.labelRedRecibidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedRecibidos.Location = new System.Drawing.Point(159, 244);
            this.labelRedRecibidos.Name = "labelRedRecibidos";
            this.labelRedRecibidos.Size = new System.Drawing.Size(10, 22);
            this.labelRedRecibidos.TabIndex = 18;
            this.labelRedRecibidos.Text = "-";
            this.labelRedRecibidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescRedEnviados
            // 
            this.labelDescRedEnviados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescRedEnviados.AutoSize = true;
            this.labelDescRedEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescRedEnviados.Location = new System.Drawing.Point(96, 266);
            this.labelDescRedEnviados.Name = "labelDescRedEnviados";
            this.labelDescRedEnviados.Size = new System.Drawing.Size(51, 13);
            this.labelDescRedEnviados.TabIndex = 19;
            this.labelDescRedEnviados.Text = "Enviados";
            this.labelDescRedEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRedEnviados
            // 
            this.labelRedEnviados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRedEnviados.AutoSize = true;
            this.labelRedEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedEnviados.Location = new System.Drawing.Point(159, 266);
            this.labelRedEnviados.Name = "labelRedEnviados";
            this.labelRedEnviados.Size = new System.Drawing.Size(10, 22);
            this.labelRedEnviados.TabIndex = 20;
            this.labelRedEnviados.Text = "-";
            this.labelRedEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescRedRecibidosEnviados
            // 
            this.labelDescRedRecibidosEnviados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescRedRecibidosEnviados.AutoSize = true;
            this.labelDescRedRecibidosEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescRedRecibidosEnviados.Location = new System.Drawing.Point(36, 288);
            this.labelDescRedRecibidosEnviados.Name = "labelDescRedRecibidosEnviados";
            this.labelDescRedRecibidosEnviados.Size = new System.Drawing.Size(111, 13);
            this.labelDescRedRecibidosEnviados.TabIndex = 21;
            this.labelDescRedRecibidosEnviados.Text = "Recibidos / Enviados";
            this.labelDescRedRecibidosEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRedRecibidosEnviados
            // 
            this.labelRedRecibidosEnviados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRedRecibidosEnviados.AutoSize = true;
            this.labelRedRecibidosEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedRecibidosEnviados.Location = new System.Drawing.Point(159, 288);
            this.labelRedRecibidosEnviados.Name = "labelRedRecibidosEnviados";
            this.labelRedRecibidosEnviados.Size = new System.Drawing.Size(10, 22);
            this.labelRedRecibidosEnviados.TabIndex = 22;
            this.labelRedRecibidosEnviados.Text = "-";
            this.labelRedRecibidosEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeaderOrdenador
            // 
            this.labelHeaderOrdenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeaderOrdenador.AutoSize = true;
            this.labelHeaderOrdenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderOrdenador.Location = new System.Drawing.Point(54, 310);
            this.labelHeaderOrdenador.Name = "labelHeaderOrdenador";
            this.labelHeaderOrdenador.Size = new System.Drawing.Size(93, 20);
            this.labelHeaderOrdenador.TabIndex = 23;
            this.labelHeaderOrdenador.Text = "Ordenador";
            this.labelHeaderOrdenador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDescFabricante
            // 
            this.labelDescFabricante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescFabricante.AutoSize = true;
            this.labelDescFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescFabricante.Location = new System.Drawing.Point(90, 338);
            this.labelDescFabricante.Name = "labelDescFabricante";
            this.labelDescFabricante.Size = new System.Drawing.Size(57, 13);
            this.labelDescFabricante.TabIndex = 24;
            this.labelDescFabricante.Text = "Fabricante";
            this.labelDescFabricante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOrdenadorFabricante
            // 
            this.labelOrdenadorFabricante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOrdenadorFabricante.AutoSize = true;
            this.labelOrdenadorFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenadorFabricante.Location = new System.Drawing.Point(159, 338);
            this.labelOrdenadorFabricante.Name = "labelOrdenadorFabricante";
            this.labelOrdenadorFabricante.Size = new System.Drawing.Size(10, 22);
            this.labelOrdenadorFabricante.TabIndex = 25;
            this.labelOrdenadorFabricante.Text = "-";
            this.labelOrdenadorFabricante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescModelo
            // 
            this.labelDescModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescModelo.AutoSize = true;
            this.labelDescModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescModelo.Location = new System.Drawing.Point(105, 360);
            this.labelDescModelo.Name = "labelDescModelo";
            this.labelDescModelo.Size = new System.Drawing.Size(42, 13);
            this.labelDescModelo.TabIndex = 26;
            this.labelDescModelo.Text = "Modelo";
            this.labelDescModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOrdenadorModelo
            // 
            this.labelOrdenadorModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOrdenadorModelo.AutoSize = true;
            this.labelOrdenadorModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenadorModelo.Location = new System.Drawing.Point(159, 360);
            this.labelOrdenadorModelo.Name = "labelOrdenadorModelo";
            this.labelOrdenadorModelo.Size = new System.Drawing.Size(10, 22);
            this.labelOrdenadorModelo.TabIndex = 27;
            this.labelOrdenadorModelo.Text = "-";
            this.labelOrdenadorModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescProcesador
            // 
            this.labelDescProcesador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescProcesador.AutoSize = true;
            this.labelDescProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescProcesador.Location = new System.Drawing.Point(86, 382);
            this.labelDescProcesador.Name = "labelDescProcesador";
            this.labelDescProcesador.Size = new System.Drawing.Size(61, 13);
            this.labelDescProcesador.TabIndex = 28;
            this.labelDescProcesador.Text = "Procesador";
            this.labelDescProcesador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOrdenadorProcesador
            // 
            this.labelOrdenadorProcesador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOrdenadorProcesador.AutoSize = true;
            this.labelOrdenadorProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenadorProcesador.Location = new System.Drawing.Point(159, 382);
            this.labelOrdenadorProcesador.Name = "labelOrdenadorProcesador";
            this.labelOrdenadorProcesador.Size = new System.Drawing.Size(10, 22);
            this.labelOrdenadorProcesador.TabIndex = 29;
            this.labelOrdenadorProcesador.Text = "-";
            this.labelOrdenadorProcesador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescUsuario
            // 
            this.labelDescUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescUsuario.AutoSize = true;
            this.labelDescUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescUsuario.Location = new System.Drawing.Point(76, 404);
            this.labelDescUsuario.Name = "labelDescUsuario";
            this.labelDescUsuario.Size = new System.Drawing.Size(71, 20);
            this.labelDescUsuario.TabIndex = 30;
            this.labelDescUsuario.Text = "Usuario";
            this.labelDescUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(159, 404);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(10, 28);
            this.labelUsuario.TabIndex = 31;
            this.labelUsuario.Text = "-";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(159, 435);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 28);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "Iniciar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor de sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelHeaderCPU;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelHeaderMemoria;
        private System.Windows.Forms.Label labelDescMemoriaFisica;
        private System.Windows.Forms.Label labelMemoriaFisica;
        private System.Windows.Forms.Label labelDescMemoriaVirtual;
        private System.Windows.Forms.Label labelMemoriaVirtual;
        private System.Windows.Forms.Label labelHeaderDisco;
        private System.Windows.Forms.Label labelDescDiscosLogicos;
        private System.Windows.Forms.Label labelDiscosLogicos;
        private System.Windows.Forms.Label labelDescDiscoLectura;
        private System.Windows.Forms.Label labelDiscoLectura;
        private System.Windows.Forms.Label labelDescDiscoEscritura;
        private System.Windows.Forms.Label labelDiscoEscritura;
        private System.Windows.Forms.Label labelDescDiscoLecturaEscritura;
        private System.Windows.Forms.Label labelDiscoLecturaEscritura;
        private System.Windows.Forms.Label labelHeaderRed;
        private System.Windows.Forms.Label labelDescRedRecibidos;
        private System.Windows.Forms.Label labelRedRecibidos;
        private System.Windows.Forms.Label labelDescRedEnviados;
        private System.Windows.Forms.Label labelRedEnviados;
        private System.Windows.Forms.Label labelDescRedRecibidosEnviados;
        private System.Windows.Forms.Label labelRedRecibidosEnviados;
        private System.Windows.Forms.Label labelHeaderOrdenador;
        private System.Windows.Forms.Label labelDescFabricante;
        private System.Windows.Forms.Label labelOrdenadorFabricante;
        private System.Windows.Forms.Label labelDescModelo;
        private System.Windows.Forms.Label labelOrdenadorModelo;
        private System.Windows.Forms.Label labelDescProcesador;
        private System.Windows.Forms.Label labelOrdenadorProcesador;
        private System.Windows.Forms.Label labelDescUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button btnActualizar;
    }
}
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderCPU, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDescCPU, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCPU, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderMemoria, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDescMemoriaFisica, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelMemoriaFisica, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelDescMemoriaVirtual, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelMemoriaVirtual, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderDisco, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelDescDiscosLogicos, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelDiscosLogicos, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelDescDiscoLectura, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelDiscoLectura, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelDescDiscoEscritura, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelDiscoEscritura, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelDescDiscoLecturaEscritura, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelDiscoLecturaEscritura, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderRed, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelDescRedRecibidos, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelRedRecibidos, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelDescRedEnviados, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelRedEnviados, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelDescRedRecibidosEnviados, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.labelRedRecibidosEnviados, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.labelHeaderOrdenador, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.labelDescFabricante, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.labelOrdenadorFabricante, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.labelDescModelo, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.labelOrdenadorModelo, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.labelDescProcesador, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.labelOrdenadorProcesador, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.labelDescUsuario, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.labelUsuario, 1, 18);
            this.tableLayoutPanel1.Controls.Add(this.buttonIniciar, 0, 19);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 616);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelHeaderCPU
            // 
            this.labelHeaderCPU.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelHeaderCPU, 2);
            this.labelHeaderCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderCPU.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.labelHeaderCPU.Location = new System.Drawing.Point(11, 8);
            this.labelHeaderCPU.Name = "labelHeaderCPU";
            this.labelHeaderCPU.Size = new System.Drawing.Size(538, 32);
            this.labelHeaderCPU.TabIndex = 0;
            this.labelHeaderCPU.Text = "CPU";
            this.labelHeaderCPU.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelDescCPU
            // 
            this.labelDescCPU.AutoSize = true;
            this.labelDescCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescCPU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescCPU.Location = new System.Drawing.Point(11, 40);
            this.labelDescCPU.Name = "labelDescCPU";
            this.labelDescCPU.Size = new System.Drawing.Size(184, 26);
            this.labelDescCPU.TabIndex = 1;
            this.labelDescCPU.Text = "Uso CPU:";
            this.labelDescCPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCPU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPU.Location = new System.Drawing.Point(201, 40);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(348, 26);
            this.labelCPU.TabIndex = 2;
            this.labelCPU.Text = "-";
            this.labelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeaderMemoria
            // 
            this.labelHeaderMemoria.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelHeaderMemoria, 2);
            this.labelHeaderMemoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderMemoria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderMemoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.labelHeaderMemoria.Location = new System.Drawing.Point(11, 66);
            this.labelHeaderMemoria.Name = "labelHeaderMemoria";
            this.labelHeaderMemoria.Size = new System.Drawing.Size(538, 32);
            this.labelHeaderMemoria.TabIndex = 3;
            this.labelHeaderMemoria.Text = "Memoria";
            this.labelHeaderMemoria.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelDescMemoriaFisica
            // 
            this.labelDescMemoriaFisica.AutoSize = true;
            this.labelDescMemoriaFisica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescMemoriaFisica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescMemoriaFisica.Location = new System.Drawing.Point(11, 98);
            this.labelDescMemoriaFisica.Name = "labelDescMemoriaFisica";
            this.labelDescMemoriaFisica.Size = new System.Drawing.Size(184, 26);
            this.labelDescMemoriaFisica.TabIndex = 4;
            this.labelDescMemoriaFisica.Text = "Memoria Física:";
            this.labelDescMemoriaFisica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemoriaFisica
            // 
            this.labelMemoriaFisica.AutoSize = true;
            this.labelMemoriaFisica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMemoriaFisica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemoriaFisica.Location = new System.Drawing.Point(201, 98);
            this.labelMemoriaFisica.Name = "labelMemoriaFisica";
            this.labelMemoriaFisica.Size = new System.Drawing.Size(348, 26);
            this.labelMemoriaFisica.TabIndex = 5;
            this.labelMemoriaFisica.Text = "-";
            this.labelMemoriaFisica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescMemoriaVirtual
            // 
            this.labelDescMemoriaVirtual.AutoSize = true;
            this.labelDescMemoriaVirtual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescMemoriaVirtual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescMemoriaVirtual.Location = new System.Drawing.Point(11, 124);
            this.labelDescMemoriaVirtual.Name = "labelDescMemoriaVirtual";
            this.labelDescMemoriaVirtual.Size = new System.Drawing.Size(184, 26);
            this.labelDescMemoriaVirtual.TabIndex = 6;
            this.labelDescMemoriaVirtual.Text = "Memoria Virtual:";
            this.labelDescMemoriaVirtual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemoriaVirtual
            // 
            this.labelMemoriaVirtual.AutoSize = true;
            this.labelMemoriaVirtual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMemoriaVirtual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemoriaVirtual.Location = new System.Drawing.Point(201, 124);
            this.labelMemoriaVirtual.Name = "labelMemoriaVirtual";
            this.labelMemoriaVirtual.Size = new System.Drawing.Size(348, 26);
            this.labelMemoriaVirtual.TabIndex = 7;
            this.labelMemoriaVirtual.Text = "-";
            this.labelMemoriaVirtual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeaderDisco
            // 
            this.labelHeaderDisco.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelHeaderDisco, 2);
            this.labelHeaderDisco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderDisco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderDisco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.labelHeaderDisco.Location = new System.Drawing.Point(11, 150);
            this.labelHeaderDisco.Name = "labelHeaderDisco";
            this.labelHeaderDisco.Size = new System.Drawing.Size(538, 32);
            this.labelHeaderDisco.TabIndex = 8;
            this.labelHeaderDisco.Text = "Disco";
            this.labelHeaderDisco.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelDescDiscosLogicos
            // 
            this.labelDescDiscosLogicos.AutoSize = true;
            this.labelDescDiscosLogicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescDiscosLogicos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescDiscosLogicos.Location = new System.Drawing.Point(11, 182);
            this.labelDescDiscosLogicos.Name = "labelDescDiscosLogicos";
            this.labelDescDiscosLogicos.Size = new System.Drawing.Size(184, 26);
            this.labelDescDiscosLogicos.TabIndex = 9;
            this.labelDescDiscosLogicos.Text = "Discos Lógicos:";
            this.labelDescDiscosLogicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDiscosLogicos
            // 
            this.labelDiscosLogicos.AutoSize = true;
            this.labelDiscosLogicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDiscosLogicos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscosLogicos.Location = new System.Drawing.Point(201, 182);
            this.labelDiscosLogicos.Name = "labelDiscosLogicos";
            this.labelDiscosLogicos.Size = new System.Drawing.Size(348, 26);
            this.labelDiscosLogicos.TabIndex = 10;
            this.labelDiscosLogicos.Text = "-";
            this.labelDiscosLogicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescDiscoLectura
            // 
            this.labelDescDiscoLectura.AutoSize = true;
            this.labelDescDiscoLectura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescDiscoLectura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescDiscoLectura.Location = new System.Drawing.Point(11, 208);
            this.labelDescDiscoLectura.Name = "labelDescDiscoLectura";
            this.labelDescDiscoLectura.Size = new System.Drawing.Size(184, 26);
            this.labelDescDiscoLectura.TabIndex = 11;
            this.labelDescDiscoLectura.Text = "Lectura:";
            this.labelDescDiscoLectura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDiscoLectura
            // 
            this.labelDiscoLectura.AutoSize = true;
            this.labelDiscoLectura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDiscoLectura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoLectura.Location = new System.Drawing.Point(201, 208);
            this.labelDiscoLectura.Name = "labelDiscoLectura";
            this.labelDiscoLectura.Size = new System.Drawing.Size(348, 26);
            this.labelDiscoLectura.TabIndex = 12;
            this.labelDiscoLectura.Text = "-";
            this.labelDiscoLectura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescDiscoEscritura
            // 
            this.labelDescDiscoEscritura.AutoSize = true;
            this.labelDescDiscoEscritura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescDiscoEscritura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescDiscoEscritura.Location = new System.Drawing.Point(11, 234);
            this.labelDescDiscoEscritura.Name = "labelDescDiscoEscritura";
            this.labelDescDiscoEscritura.Size = new System.Drawing.Size(184, 26);
            this.labelDescDiscoEscritura.TabIndex = 13;
            this.labelDescDiscoEscritura.Text = "Escritura:";
            this.labelDescDiscoEscritura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDiscoEscritura
            // 
            this.labelDiscoEscritura.AutoSize = true;
            this.labelDiscoEscritura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDiscoEscritura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoEscritura.Location = new System.Drawing.Point(201, 234);
            this.labelDiscoEscritura.Name = "labelDiscoEscritura";
            this.labelDiscoEscritura.Size = new System.Drawing.Size(348, 26);
            this.labelDiscoEscritura.TabIndex = 14;
            this.labelDiscoEscritura.Text = "-";
            this.labelDiscoEscritura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescDiscoLecturaEscritura
            // 
            this.labelDescDiscoLecturaEscritura.AutoSize = true;
            this.labelDescDiscoLecturaEscritura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescDiscoLecturaEscritura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescDiscoLecturaEscritura.Location = new System.Drawing.Point(11, 260);
            this.labelDescDiscoLecturaEscritura.Name = "labelDescDiscoLecturaEscritura";
            this.labelDescDiscoLecturaEscritura.Size = new System.Drawing.Size(184, 26);
            this.labelDescDiscoLecturaEscritura.TabIndex = 15;
            this.labelDescDiscoLecturaEscritura.Text = "Lectura y Escritura:";
            this.labelDescDiscoLecturaEscritura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDiscoLecturaEscritura
            // 
            this.labelDiscoLecturaEscritura.AutoSize = true;
            this.labelDiscoLecturaEscritura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDiscoLecturaEscritura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscoLecturaEscritura.Location = new System.Drawing.Point(201, 260);
            this.labelDiscoLecturaEscritura.Name = "labelDiscoLecturaEscritura";
            this.labelDiscoLecturaEscritura.Size = new System.Drawing.Size(348, 26);
            this.labelDiscoLecturaEscritura.TabIndex = 16;
            this.labelDiscoLecturaEscritura.Text = "-";
            this.labelDiscoLecturaEscritura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeaderRed
            // 
            this.labelHeaderRed.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelHeaderRed, 2);
            this.labelHeaderRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderRed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.labelHeaderRed.Location = new System.Drawing.Point(11, 286);
            this.labelHeaderRed.Name = "labelHeaderRed";
            this.labelHeaderRed.Size = new System.Drawing.Size(538, 32);
            this.labelHeaderRed.TabIndex = 17;
            this.labelHeaderRed.Text = "Red";
            this.labelHeaderRed.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelDescRedRecibidos
            // 
            this.labelDescRedRecibidos.AutoSize = true;
            this.labelDescRedRecibidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescRedRecibidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescRedRecibidos.Location = new System.Drawing.Point(11, 318);
            this.labelDescRedRecibidos.Name = "labelDescRedRecibidos";
            this.labelDescRedRecibidos.Size = new System.Drawing.Size(184, 26);
            this.labelDescRedRecibidos.TabIndex = 18;
            this.labelDescRedRecibidos.Text = "Recibidos:";
            this.labelDescRedRecibidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRedRecibidos
            // 
            this.labelRedRecibidos.AutoSize = true;
            this.labelRedRecibidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRedRecibidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedRecibidos.Location = new System.Drawing.Point(201, 318);
            this.labelRedRecibidos.Name = "labelRedRecibidos";
            this.labelRedRecibidos.Size = new System.Drawing.Size(348, 26);
            this.labelRedRecibidos.TabIndex = 19;
            this.labelRedRecibidos.Text = "-";
            this.labelRedRecibidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescRedEnviados
            // 
            this.labelDescRedEnviados.AutoSize = true;
            this.labelDescRedEnviados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescRedEnviados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescRedEnviados.Location = new System.Drawing.Point(11, 344);
            this.labelDescRedEnviados.Name = "labelDescRedEnviados";
            this.labelDescRedEnviados.Size = new System.Drawing.Size(184, 26);
            this.labelDescRedEnviados.TabIndex = 20;
            this.labelDescRedEnviados.Text = "Enviados:";
            this.labelDescRedEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRedEnviados
            // 
            this.labelRedEnviados.AutoSize = true;
            this.labelRedEnviados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRedEnviados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedEnviados.Location = new System.Drawing.Point(201, 344);
            this.labelRedEnviados.Name = "labelRedEnviados";
            this.labelRedEnviados.Size = new System.Drawing.Size(348, 26);
            this.labelRedEnviados.TabIndex = 21;
            this.labelRedEnviados.Text = "-";
            this.labelRedEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescRedRecibidosEnviados
            // 
            this.labelDescRedRecibidosEnviados.AutoSize = true;
            this.labelDescRedRecibidosEnviados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescRedRecibidosEnviados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescRedRecibidosEnviados.Location = new System.Drawing.Point(11, 370);
            this.labelDescRedRecibidosEnviados.Name = "labelDescRedRecibidosEnviados";
            this.labelDescRedRecibidosEnviados.Size = new System.Drawing.Size(184, 26);
            this.labelDescRedRecibidosEnviados.TabIndex = 22;
            this.labelDescRedRecibidosEnviados.Text = "Recibidos y Enviados:";
            this.labelDescRedRecibidosEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRedRecibidosEnviados
            // 
            this.labelRedRecibidosEnviados.AutoSize = true;
            this.labelRedRecibidosEnviados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRedRecibidosEnviados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedRecibidosEnviados.Location = new System.Drawing.Point(201, 370);
            this.labelRedRecibidosEnviados.Name = "labelRedRecibidosEnviados";
            this.labelRedRecibidosEnviados.Size = new System.Drawing.Size(348, 26);
            this.labelRedRecibidosEnviados.TabIndex = 23;
            this.labelRedRecibidosEnviados.Text = "-";
            this.labelRedRecibidosEnviados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeaderOrdenador
            // 
            this.labelHeaderOrdenador.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelHeaderOrdenador, 2);
            this.labelHeaderOrdenador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderOrdenador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderOrdenador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.labelHeaderOrdenador.Location = new System.Drawing.Point(11, 396);
            this.labelHeaderOrdenador.Name = "labelHeaderOrdenador";
            this.labelHeaderOrdenador.Size = new System.Drawing.Size(538, 32);
            this.labelHeaderOrdenador.TabIndex = 24;
            this.labelHeaderOrdenador.Text = "Ordenador";
            this.labelHeaderOrdenador.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelDescFabricante
            // 
            this.labelDescFabricante.AutoSize = true;
            this.labelDescFabricante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescFabricante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescFabricante.Location = new System.Drawing.Point(11, 428);
            this.labelDescFabricante.Name = "labelDescFabricante";
            this.labelDescFabricante.Size = new System.Drawing.Size(184, 26);
            this.labelDescFabricante.TabIndex = 25;
            this.labelDescFabricante.Text = "Fabricante:";
            this.labelDescFabricante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOrdenadorFabricante
            // 
            this.labelOrdenadorFabricante.AutoSize = true;
            this.labelOrdenadorFabricante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOrdenadorFabricante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenadorFabricante.Location = new System.Drawing.Point(201, 428);
            this.labelOrdenadorFabricante.Name = "labelOrdenadorFabricante";
            this.labelOrdenadorFabricante.Size = new System.Drawing.Size(348, 26);
            this.labelOrdenadorFabricante.TabIndex = 26;
            this.labelOrdenadorFabricante.Text = "-";
            this.labelOrdenadorFabricante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescModelo
            // 
            this.labelDescModelo.AutoSize = true;
            this.labelDescModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescModelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescModelo.Location = new System.Drawing.Point(11, 454);
            this.labelDescModelo.Name = "labelDescModelo";
            this.labelDescModelo.Size = new System.Drawing.Size(184, 26);
            this.labelDescModelo.TabIndex = 27;
            this.labelDescModelo.Text = "Modelo:";
            this.labelDescModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOrdenadorModelo
            // 
            this.labelOrdenadorModelo.AutoSize = true;
            this.labelOrdenadorModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOrdenadorModelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenadorModelo.Location = new System.Drawing.Point(201, 454);
            this.labelOrdenadorModelo.Name = "labelOrdenadorModelo";
            this.labelOrdenadorModelo.Size = new System.Drawing.Size(348, 26);
            this.labelOrdenadorModelo.TabIndex = 28;
            this.labelOrdenadorModelo.Text = "-";
            this.labelOrdenadorModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescProcesador
            // 
            this.labelDescProcesador.AutoSize = true;
            this.labelDescProcesador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescProcesador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescProcesador.Location = new System.Drawing.Point(11, 480);
            this.labelDescProcesador.Name = "labelDescProcesador";
            this.labelDescProcesador.Size = new System.Drawing.Size(184, 26);
            this.labelDescProcesador.TabIndex = 29;
            this.labelDescProcesador.Text = "Procesador:";
            this.labelDescProcesador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOrdenadorProcesador
            // 
            this.labelOrdenadorProcesador.AutoSize = true;
            this.labelOrdenadorProcesador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOrdenadorProcesador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenadorProcesador.Location = new System.Drawing.Point(201, 480);
            this.labelOrdenadorProcesador.Name = "labelOrdenadorProcesador";
            this.labelOrdenadorProcesador.Size = new System.Drawing.Size(348, 26);
            this.labelOrdenadorProcesador.TabIndex = 30;
            this.labelOrdenadorProcesador.Text = "-";
            this.labelOrdenadorProcesador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescUsuario
            // 
            this.labelDescUsuario.AutoSize = true;
            this.labelDescUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescUsuario.Location = new System.Drawing.Point(11, 506);
            this.labelDescUsuario.Name = "labelDescUsuario";
            this.labelDescUsuario.Size = new System.Drawing.Size(184, 26);
            this.labelDescUsuario.TabIndex = 31;
            this.labelDescUsuario.Text = "Usuario:";
            this.labelDescUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(201, 506);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(348, 26);
            this.labelUsuario.TabIndex = 32;
            this.labelUsuario.Text = "-";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tableLayoutPanel1.SetColumnSpan(this.buttonIniciar, 2);
            this.buttonIniciar.FlatAppearance.BorderSize = 0;
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.ForeColor = System.Drawing.Color.White;
            this.buttonIniciar.Location = new System.Drawing.Point(190, 542);
            this.buttonIniciar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(180, 32);
            this.buttonIniciar.TabIndex = 33;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(584, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor de sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelHeaderCPU;
        private System.Windows.Forms.Label labelDescCPU;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelHeaderMemoria;
        private System.Windows.Forms.Label labelDescMemoriaFisica;
        private System.Windows.Forms.Label labelMemoriaFisica;
        private System.Windows.Forms.Label labelDescMemoriaVirtual;
        private System.Windows.Forms.Label labelMemoriaVirtual;
        private System.Windows.Forms.Label labelHeaderDisco;
        private System.Windows.Forms.Label labelDescDiscosLogicos;
        private System.Windows.Forms.Label labelDiscosLogicos;
        private System.Windows.Forms.Label labelDescDiscoLectura;
        private System.Windows.Forms.Label labelDiscoLectura;
        private System.Windows.Forms.Label labelDescDiscoEscritura;
        private System.Windows.Forms.Label labelDiscoEscritura;
        private System.Windows.Forms.Label labelDescDiscoLecturaEscritura;
        private System.Windows.Forms.Label labelDiscoLecturaEscritura;
        private System.Windows.Forms.Label labelHeaderRed;
        private System.Windows.Forms.Label labelDescRedRecibidos;
        private System.Windows.Forms.Label labelRedRecibidos;
        private System.Windows.Forms.Label labelDescRedEnviados;
        private System.Windows.Forms.Label labelRedEnviados;
        private System.Windows.Forms.Label labelDescRedRecibidosEnviados;
        private System.Windows.Forms.Label labelRedRecibidosEnviados;
        private System.Windows.Forms.Label labelHeaderOrdenador;
        private System.Windows.Forms.Label labelDescFabricante;
        private System.Windows.Forms.Label labelOrdenadorFabricante;
        private System.Windows.Forms.Label labelDescModelo;
        private System.Windows.Forms.Label labelOrdenadorModelo;
        private System.Windows.Forms.Label labelDescProcesador;
        private System.Windows.Forms.Label labelOrdenadorProcesador;
        private System.Windows.Forms.Label labelDescUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button buttonIniciar;
    }
}
