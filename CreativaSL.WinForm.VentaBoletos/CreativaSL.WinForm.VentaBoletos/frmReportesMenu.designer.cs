namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmReportesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesMenu));
            this.panel_login = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.checkBox_Estadisticos = new System.Windows.Forms.CheckBox();
            this.checkBox_Mensual = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCajaXFechas = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Vendedores = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnBoleto = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_TotalesCajaDia = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnViajes = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnClienteComprador = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnClienteFrecuente = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnCaja = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_login.BorderColor = System.Drawing.Color.Transparent;
            this.panel_login.Controls.Add(this.checkBox_Estadisticos);
            this.panel_login.Controls.Add(this.checkBox_Mensual);
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Controls.Add(this.label4);
            this.panel_login.Controls.Add(this.btnCajaXFechas);
            this.panel_login.Controls.Add(this.btn_Vendedores);
            this.panel_login.Controls.Add(this.btnBoleto);
            this.panel_login.Controls.Add(this.btn_TotalesCajaDia);
            this.panel_login.Controls.Add(this.btnViajes);
            this.panel_login.Controls.Add(this.btnClienteComprador);
            this.panel_login.Controls.Add(this.btnClienteFrecuente);
            this.panel_login.Controls.Add(this.btnCaja);
            this.panel_login.Controls.Add(this.btnSalir);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_login.Location = new System.Drawing.Point(0, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(591, 427);
            this.panel_login.SizeLine = 3;
            this.panel_login.SizeTitle = 20;
            this.panel_login.TabIndex = 11;
            this.panel_login.Title = "";
            this.panel_login.TitleColor = System.Drawing.Color.Transparent;
            // 
            // checkBox_Estadisticos
            // 
            this.checkBox_Estadisticos.AutoSize = true;
            this.checkBox_Estadisticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Estadisticos.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox_Estadisticos.Location = new System.Drawing.Point(366, 47);
            this.checkBox_Estadisticos.Name = "checkBox_Estadisticos";
            this.checkBox_Estadisticos.Size = new System.Drawing.Size(126, 24);
            this.checkBox_Estadisticos.TabIndex = 2;
            this.checkBox_Estadisticos.Text = "Estadísticos";
            this.checkBox_Estadisticos.UseVisualStyleBackColor = true;
            this.checkBox_Estadisticos.CheckedChanged += new System.EventHandler(this.checkBox_Estadisticos_CheckedChanged);
            // 
            // checkBox_Mensual
            // 
            this.checkBox_Mensual.AutoSize = true;
            this.checkBox_Mensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Mensual.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox_Mensual.Location = new System.Drawing.Point(110, 47);
            this.checkBox_Mensual.Name = "checkBox_Mensual";
            this.checkBox_Mensual.Size = new System.Drawing.Size(95, 24);
            this.checkBox_Mensual.TabIndex = 1;
            this.checkBox_Mensual.Text = "Mensual";
            this.checkBox_Mensual.UseVisualStyleBackColor = true;
            this.checkBox_Mensual.CheckedChanged += new System.EventHandler(this.checkBox_Mensual_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(407, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monedero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(56, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Viajes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(261, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cajas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(200, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione un Reporte";
            // 
            // btnCajaXFechas
            // 
            this.btnCajaXFechas.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCajaXFechas.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCajaXFechas.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCajaXFechas.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnCajaXFechas.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnCajaXFechas.FocusRectangle = true;
            this.btnCajaXFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajaXFechas.Image = null;
            this.btnCajaXFechas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCajaXFechas.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnCajaXFechas.ImageFocused = null;
            this.btnCajaXFechas.ImageInactive = null;
            this.btnCajaXFechas.ImageMouseOver = null;
            this.btnCajaXFechas.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnCajaXFechas.ImageNormal")));
            this.btnCajaXFechas.ImagePressed = null;
            this.btnCajaXFechas.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCajaXFechas.KeyButton = System.Windows.Forms.Keys.None;
            this.btnCajaXFechas.KeyButtonView = false;
            this.btnCajaXFechas.Location = new System.Drawing.Point(248, 107);
            this.btnCajaXFechas.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCajaXFechas.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCajaXFechas.Name = "btnCajaXFechas";
            this.btnCajaXFechas.OffsetPressedContent = true;
            this.btnCajaXFechas.Size = new System.Drawing.Size(100, 80);
            this.btnCajaXFechas.TabIndex = 3;
            this.btnCajaXFechas.Text = "Caja X Fechas";
            this.btnCajaXFechas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCajaXFechas.TextDropShadow = true;
            this.btnCajaXFechas.UseVisualStyleBackColor = false;
            this.btnCajaXFechas.Click += new System.EventHandler(this.btnCajaXFechas_Click);
            // 
            // btn_Vendedores
            // 
            this.btn_Vendedores.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Vendedores.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Vendedores.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Vendedores.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Vendedores.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Vendedores.FocusRectangle = true;
            this.btn_Vendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vendedores.Image = null;
            this.btn_Vendedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Vendedores.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Vendedores.ImageFocused = null;
            this.btn_Vendedores.ImageInactive = null;
            this.btn_Vendedores.ImageMouseOver = null;
            this.btn_Vendedores.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_Vendedores.ImageNormal")));
            this.btn_Vendedores.ImagePressed = null;
            this.btn_Vendedores.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Vendedores.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Vendedores.KeyButtonView = false;
            this.btn_Vendedores.Location = new System.Drawing.Point(348, 107);
            this.btn_Vendedores.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Vendedores.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Vendedores.Name = "btn_Vendedores";
            this.btn_Vendedores.OffsetPressedContent = true;
            this.btn_Vendedores.Size = new System.Drawing.Size(100, 80);
            this.btn_Vendedores.TabIndex = 4;
            this.btn_Vendedores.Text = "Vendedores";
            this.btn_Vendedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Vendedores.TextDropShadow = true;
            this.btn_Vendedores.UseVisualStyleBackColor = false;
            this.btn_Vendedores.Click += new System.EventHandler(this.btn_Vendedores_Click);
            // 
            // btnBoleto
            // 
            this.btnBoleto.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBoleto.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBoleto.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBoleto.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnBoleto.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnBoleto.FocusRectangle = true;
            this.btnBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoleto.Image = null;
            this.btnBoleto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBoleto.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnBoleto.ImageFocused = null;
            this.btnBoleto.ImageInactive = null;
            this.btnBoleto.ImageMouseOver = null;
            this.btnBoleto.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnBoleto.ImageNormal")));
            this.btnBoleto.ImagePressed = null;
            this.btnBoleto.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBoleto.KeyButton = System.Windows.Forms.Keys.None;
            this.btnBoleto.KeyButtonView = false;
            this.btnBoleto.Location = new System.Drawing.Point(449, 107);
            this.btnBoleto.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnBoleto.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.OffsetPressedContent = true;
            this.btnBoleto.Size = new System.Drawing.Size(100, 80);
            this.btnBoleto.TabIndex = 5;
            this.btnBoleto.Text = "Boleto";
            this.btnBoleto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBoleto.TextDropShadow = true;
            this.btnBoleto.UseVisualStyleBackColor = false;
            this.btnBoleto.Click += new System.EventHandler(this.btnBoleto_Click);
            // 
            // btn_TotalesCajaDia
            // 
            this.btn_TotalesCajaDia.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_TotalesCajaDia.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_TotalesCajaDia.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_TotalesCajaDia.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_TotalesCajaDia.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_TotalesCajaDia.FocusRectangle = true;
            this.btn_TotalesCajaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TotalesCajaDia.Image = null;
            this.btn_TotalesCajaDia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_TotalesCajaDia.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_TotalesCajaDia.ImageFocused = null;
            this.btn_TotalesCajaDia.ImageInactive = null;
            this.btn_TotalesCajaDia.ImageMouseOver = null;
            this.btn_TotalesCajaDia.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btn_TotalesCajaDia.ImageNormal")));
            this.btn_TotalesCajaDia.ImagePressed = null;
            this.btn_TotalesCajaDia.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_TotalesCajaDia.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_TotalesCajaDia.KeyButtonView = false;
            this.btn_TotalesCajaDia.Location = new System.Drawing.Point(148, 107);
            this.btn_TotalesCajaDia.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_TotalesCajaDia.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_TotalesCajaDia.Name = "btn_TotalesCajaDia";
            this.btn_TotalesCajaDia.OffsetPressedContent = true;
            this.btn_TotalesCajaDia.Size = new System.Drawing.Size(100, 80);
            this.btn_TotalesCajaDia.TabIndex = 2;
            this.btn_TotalesCajaDia.Text = "Totales Caja Día";
            this.btn_TotalesCajaDia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TotalesCajaDia.TextDropShadow = true;
            this.btn_TotalesCajaDia.UseVisualStyleBackColor = false;
            this.btn_TotalesCajaDia.Click += new System.EventHandler(this.btn_TotalesCajaDia_Click);
            // 
            // btnViajes
            // 
            this.btnViajes.BackColor = System.Drawing.Color.SkyBlue;
            this.btnViajes.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViajes.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViajes.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnViajes.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnViajes.FocusRectangle = true;
            this.btnViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViajes.Image = null;
            this.btnViajes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViajes.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnViajes.ImageFocused = null;
            this.btnViajes.ImageInactive = null;
            this.btnViajes.ImageMouseOver = null;
            this.btnViajes.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnViajes.ImageNormal")));
            this.btnViajes.ImagePressed = null;
            this.btnViajes.ImageSize = new System.Drawing.Size(50, 50);
            this.btnViajes.KeyButton = System.Windows.Forms.Keys.None;
            this.btnViajes.KeyButtonView = false;
            this.btnViajes.Location = new System.Drawing.Point(48, 251);
            this.btnViajes.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnViajes.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.OffsetPressedContent = true;
            this.btnViajes.Size = new System.Drawing.Size(100, 80);
            this.btnViajes.TabIndex = 6;
            this.btnViajes.Text = "Viajes";
            this.btnViajes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViajes.TextDropShadow = true;
            this.btnViajes.UseVisualStyleBackColor = false;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnClienteComprador
            // 
            this.btnClienteComprador.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClienteComprador.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClienteComprador.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClienteComprador.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnClienteComprador.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnClienteComprador.FocusRectangle = true;
            this.btnClienteComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteComprador.Image = null;
            this.btnClienteComprador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClienteComprador.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnClienteComprador.ImageFocused = null;
            this.btnClienteComprador.ImageInactive = null;
            this.btnClienteComprador.ImageMouseOver = null;
            this.btnClienteComprador.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnClienteComprador.ImageNormal")));
            this.btnClienteComprador.ImagePressed = null;
            this.btnClienteComprador.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClienteComprador.KeyButton = System.Windows.Forms.Keys.None;
            this.btnClienteComprador.KeyButtonView = false;
            this.btnClienteComprador.Location = new System.Drawing.Point(349, 251);
            this.btnClienteComprador.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnClienteComprador.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnClienteComprador.Name = "btnClienteComprador";
            this.btnClienteComprador.OffsetPressedContent = true;
            this.btnClienteComprador.Size = new System.Drawing.Size(100, 80);
            this.btnClienteComprador.TabIndex = 7;
            this.btnClienteComprador.Text = "Cliente Comp";
            this.btnClienteComprador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClienteComprador.TextDropShadow = true;
            this.btnClienteComprador.UseVisualStyleBackColor = false;
            this.btnClienteComprador.Click += new System.EventHandler(this.btnClienteComprador_Click);
            // 
            // btnClienteFrecuente
            // 
            this.btnClienteFrecuente.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClienteFrecuente.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClienteFrecuente.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClienteFrecuente.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnClienteFrecuente.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnClienteFrecuente.FocusRectangle = true;
            this.btnClienteFrecuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteFrecuente.Image = null;
            this.btnClienteFrecuente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClienteFrecuente.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnClienteFrecuente.ImageFocused = null;
            this.btnClienteFrecuente.ImageInactive = null;
            this.btnClienteFrecuente.ImageMouseOver = null;
            this.btnClienteFrecuente.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnClienteFrecuente.ImageNormal")));
            this.btnClienteFrecuente.ImagePressed = null;
            this.btnClienteFrecuente.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClienteFrecuente.KeyButton = System.Windows.Forms.Keys.None;
            this.btnClienteFrecuente.KeyButtonView = false;
            this.btnClienteFrecuente.Location = new System.Drawing.Point(449, 251);
            this.btnClienteFrecuente.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnClienteFrecuente.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnClienteFrecuente.Name = "btnClienteFrecuente";
            this.btnClienteFrecuente.OffsetPressedContent = true;
            this.btnClienteFrecuente.Size = new System.Drawing.Size(100, 80);
            this.btnClienteFrecuente.TabIndex = 8;
            this.btnClienteFrecuente.Text = "Cliente Frec.";
            this.btnClienteFrecuente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClienteFrecuente.TextDropShadow = true;
            this.btnClienteFrecuente.UseVisualStyleBackColor = false;
            this.btnClienteFrecuente.Click += new System.EventHandler(this.btnClienteFrecuente_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCaja.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCaja.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCaja.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnCaja.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnCaja.FocusRectangle = true;
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.Image = null;
            this.btnCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCaja.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnCaja.ImageFocused = null;
            this.btnCaja.ImageInactive = null;
            this.btnCaja.ImageMouseOver = null;
            this.btnCaja.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnCaja.ImageNormal")));
            this.btnCaja.ImagePressed = null;
            this.btnCaja.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCaja.KeyButton = System.Windows.Forms.Keys.None;
            this.btnCaja.KeyButtonView = false;
            this.btnCaja.Location = new System.Drawing.Point(48, 107);
            this.btnCaja.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCaja.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.OffsetPressedContent = true;
            this.btnCaja.Size = new System.Drawing.Size(100, 80);
            this.btnCaja.TabIndex = 1;
            this.btnCaja.Text = "Caja";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaja.TextDropShadow = true;
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnSalir.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.FocusRectangle = true;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = null;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnSalir.ImageFocused = null;
            this.btnSalir.ImageInactive = null;
            this.btnSalir.ImageMouseOver = null;
            this.btnSalir.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._11salir;
            this.btnSalir.ImagePressed = null;
            this.btnSalir.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSalir.KeyButton = System.Windows.Forms.Keys.None;
            this.btnSalir.KeyButtonView = false;
            this.btnSalir.Location = new System.Drawing.Point(508, 352);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(80, 65);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmReportesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(591, 427);
            this.Controls.Add(this.panel_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportesMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.TopMost = true;
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panel_login;
        private LibControls.WinForms.Button_Creativa btnCaja;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private LibControls.WinForms.Button_Creativa btnClienteComprador;
        private LibControls.WinForms.Button_Creativa btnClienteFrecuente;
        private LibControls.WinForms.Button_Creativa btnViajes;
        private LibControls.WinForms.Button_Creativa btn_TotalesCajaDia;
        private LibControls.WinForms.Button_Creativa btnBoleto;
        private LibControls.WinForms.Button_Creativa btn_Vendedores;
        private LibControls.WinForms.Button_Creativa btnCajaXFechas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Estadisticos;
        private System.Windows.Forms.CheckBox checkBox_Mensual;
    }
}