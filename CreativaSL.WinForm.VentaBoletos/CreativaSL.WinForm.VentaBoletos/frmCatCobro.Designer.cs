﻿namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatCobro));
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_PagoMonedero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Pendiente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Pagar = new System.Windows.Forms.TextBox();
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btn_Cobrar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Cambio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_PagoEfectivo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_TiempoVenta = new System.Windows.Forms.TextBox();
            this.timerVenta = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerVenta = new System.ComponentModel.BackgroundWorker();
            this.panelTitle_Creativa0 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_NewMonedero = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Txt_Monedero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTitle_Creativa1.SuspendLayout();
            this.panel_Creativa1.SuspendLayout();
            this.panelTitle_Creativa0.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa1.Controls.Add(this.label7);
            this.panelTitle_Creativa1.Controls.Add(this.Txt_PagoMonedero);
            this.panelTitle_Creativa1.Controls.Add(this.label5);
            this.panelTitle_Creativa1.Controls.Add(this.label4);
            this.panelTitle_Creativa1.Controls.Add(this.Txt_Pendiente);
            this.panelTitle_Creativa1.Controls.Add(this.label3);
            this.panelTitle_Creativa1.Controls.Add(this.Txt_Pagar);
            this.panelTitle_Creativa1.Controls.Add(this.panel_Creativa1);
            this.panelTitle_Creativa1.Controls.Add(this.label2);
            this.panelTitle_Creativa1.Controls.Add(this.Txt_Cambio);
            this.panelTitle_Creativa1.Controls.Add(this.label1);
            this.panelTitle_Creativa1.Controls.Add(this.Txt_PagoEfectivo);
            this.panelTitle_Creativa1.Controls.Add(this.label11);
            this.panelTitle_Creativa1.Controls.Add(this.Txt_Total);
            this.panelTitle_Creativa1.DrawGradient = false;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 122);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(1008, 538);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 1;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(465, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "MontoPago";
            // 
            // Txt_PagoMonedero
            // 
            this.Txt_PagoMonedero.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PagoMonedero.Location = new System.Drawing.Point(537, 221);
            this.Txt_PagoMonedero.MaxLength = 10;
            this.Txt_PagoMonedero.Name = "Txt_PagoMonedero";
            this.Txt_PagoMonedero.Size = new System.Drawing.Size(312, 74);
            this.Txt_PagoMonedero.TabIndex = 9;
            this.Txt_PagoMonedero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_PagoMonedero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_PagoMonedero_KeyDown);
            this.Txt_PagoMonedero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PagoMonedero_KeyPress);
            this.Txt_PagoMonedero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_PagoMonedero_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(566, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pago Monedero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(744, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pendiente:";
            // 
            // Txt_Pendiente
            // 
            this.Txt_Pendiente.BackColor = System.Drawing.Color.Plum;
            this.Txt_Pendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pendiente.Location = new System.Drawing.Point(679, 83);
            this.Txt_Pendiente.Name = "Txt_Pendiente";
            this.Txt_Pendiente.ReadOnly = true;
            this.Txt_Pendiente.Size = new System.Drawing.Size(312, 74);
            this.Txt_Pendiente.TabIndex = 7;
            this.Txt_Pendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(446, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pagar:";
            // 
            // Txt_Pagar
            // 
            this.Txt_Pagar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Txt_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Pagar.Location = new System.Drawing.Point(349, 83);
            this.Txt_Pagar.Name = "Txt_Pagar";
            this.Txt_Pagar.ReadOnly = true;
            this.Txt_Pagar.Size = new System.Drawing.Size(312, 74);
            this.Txt_Pagar.TabIndex = 6;
            this.Txt_Pagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.btn_Cobrar);
            this.panel_Creativa1.Controls.Add(this.btn_Cancelar);
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 450);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(1008, 82);
            this.panel_Creativa1.TabIndex = 37;
            // 
            // btn_Cobrar
            // 
            this.btn_Cobrar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Cobrar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cobrar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cobrar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Cobrar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Cobrar.FocusRectangle = true;
            this.btn_Cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cobrar.Image = null;
            this.btn_Cobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cobrar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Cobrar.ImageFocused = null;
            this.btn_Cobrar.ImageInactive = null;
            this.btn_Cobrar.ImageMouseOver = null;
            this.btn_Cobrar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._35aceptar;
            this.btn_Cobrar.ImagePressed = null;
            this.btn_Cobrar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Cobrar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Cobrar.KeyButtonView = false;
            this.btn_Cobrar.Location = new System.Drawing.Point(397, 10);
            this.btn_Cobrar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Cobrar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Cobrar.Name = "btn_Cobrar";
            this.btn_Cobrar.OffsetPressedContent = true;
            this.btn_Cobrar.Size = new System.Drawing.Size(80, 65);
            this.btn_Cobrar.TabIndex = 11;
            this.btn_Cobrar.Text = "Cobrar";
            this.btn_Cobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cobrar.TextDropShadow = true;
            this.btn_Cobrar.UseVisualStyleBackColor = false;
            this.btn_Cobrar.Click += new System.EventHandler(this.btn_Cobrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Cancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Cancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Cancelar.FocusRectangle = true;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = null;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Cancelar.ImageFocused = null;
            this.btn_Cancelar.ImageInactive = null;
            this.btn_Cancelar.ImageMouseOver = null;
            this.btn_Cancelar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.btn_Cancelar.ImagePressed = null;
            this.btn_Cancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Cancelar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Cancelar.KeyButtonView = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(524, 10);
            this.btn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.OffsetPressedContent = true;
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 65);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.TextDropShadow = true;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(408, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cambio:";
            // 
            // Txt_Cambio
            // 
            this.Txt_Cambio.BackColor = System.Drawing.Color.OrangeRed;
            this.Txt_Cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cambio.Location = new System.Drawing.Point(327, 359);
            this.Txt_Cambio.Name = "Txt_Cambio";
            this.Txt_Cambio.ReadOnly = true;
            this.Txt_Cambio.Size = new System.Drawing.Size(312, 74);
            this.Txt_Cambio.TabIndex = 10;
            this.Txt_Cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Cambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cambio_KeyPress);
            this.Txt_Cambio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Cambio_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(196, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago Efectivo:";
            // 
            // Txt_PagoEfectivo
            // 
            this.Txt_PagoEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PagoEfectivo.Location = new System.Drawing.Point(144, 223);
            this.Txt_PagoEfectivo.MaxLength = 10;
            this.Txt_PagoEfectivo.Name = "Txt_PagoEfectivo";
            this.Txt_PagoEfectivo.Size = new System.Drawing.Size(312, 74);
            this.Txt_PagoEfectivo.TabIndex = 8;
            this.Txt_PagoEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_PagoEfectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Pago_KeyDown);
            this.Txt_PagoEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Pago_KeyPress);
            this.Txt_PagoEfectivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Pago_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(127, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 37);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total:";
            // 
            // Txt_Total
            // 
            this.Txt_Total.BackColor = System.Drawing.Color.RoyalBlue;
            this.Txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.Location = new System.Drawing.Point(17, 83);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(312, 74);
            this.Txt_Total.TabIndex = 5;
            this.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Total_KeyPress);
            this.Txt_Total.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Total_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(778, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tiempo Venta:";
            // 
            // Txt_TiempoVenta
            // 
            this.Txt_TiempoVenta.BackColor = System.Drawing.Color.OrangeRed;
            this.Txt_TiempoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TiempoVenta.Location = new System.Drawing.Point(791, 57);
            this.Txt_TiempoVenta.Multiline = true;
            this.Txt_TiempoVenta.Name = "Txt_TiempoVenta";
            this.Txt_TiempoVenta.ReadOnly = true;
            this.Txt_TiempoVenta.Size = new System.Drawing.Size(87, 37);
            this.Txt_TiempoVenta.TabIndex = 4;
            this.Txt_TiempoVenta.Text = "00:00";
            this.Txt_TiempoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerVenta
            // 
            this.timerVenta.Enabled = true;
            this.timerVenta.Interval = 1000;
            this.timerVenta.Tick += new System.EventHandler(this.timerVenta_Tick);
            // 
            // backgroundWorkerVenta
            // 
            this.backgroundWorkerVenta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerVenta_DoWork);
            this.backgroundWorkerVenta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerVenta_RunWorkerCompleted);
            // 
            // panelTitle_Creativa0
            // 
            this.panelTitle_Creativa0.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTitle_Creativa0.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa0.Controls.Add(this.label8);
            this.panelTitle_Creativa0.Controls.Add(this.Txt_NewMonedero);
            this.panelTitle_Creativa0.Controls.Add(this.label15);
            this.panelTitle_Creativa0.Controls.Add(this.label10);
            this.panelTitle_Creativa0.Controls.Add(this.Txt_TiempoVenta);
            this.panelTitle_Creativa0.Controls.Add(this.Txt_Monedero);
            this.panelTitle_Creativa0.Controls.Add(this.label16);
            this.panelTitle_Creativa0.Controls.Add(this.TxtNombreCliente);
            this.panelTitle_Creativa0.Controls.Add(this.label14);
            this.panelTitle_Creativa0.Controls.Add(this.label6);
            this.panelTitle_Creativa0.DrawGradient = false;
            this.panelTitle_Creativa0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa0.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa0.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa0.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle_Creativa0.Name = "panelTitle_Creativa0";
            this.panelTitle_Creativa0.Size = new System.Drawing.Size(1008, 122);
            this.panelTitle_Creativa0.SizeLine = 3;
            this.panelTitle_Creativa0.SizeTitle = 20;
            this.panelTitle_Creativa0.TabIndex = 39;
            this.panelTitle_Creativa0.Title = "";
            this.panelTitle_Creativa0.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(445, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Datos del Cliente";
            // 
            // Txt_NewMonedero
            // 
            this.Txt_NewMonedero.BackColor = System.Drawing.Color.PaleGreen;
            this.Txt_NewMonedero.Location = new System.Drawing.Point(535, 79);
            this.Txt_NewMonedero.Name = "Txt_NewMonedero";
            this.Txt_NewMonedero.ReadOnly = true;
            this.Txt_NewMonedero.Size = new System.Drawing.Size(104, 26);
            this.Txt_NewMonedero.TabIndex = 3;
            this.Txt_NewMonedero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(384, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "$ Nuevo Monedero:";
            // 
            // Txt_Monedero
            // 
            this.Txt_Monedero.BackColor = System.Drawing.Color.PaleGreen;
            this.Txt_Monedero.Location = new System.Drawing.Point(535, 38);
            this.Txt_Monedero.Name = "Txt_Monedero";
            this.Txt_Monedero.Size = new System.Drawing.Size(104, 26);
            this.Txt_Monedero.TabIndex = 2;
            this.Txt_Monedero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(388, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "$ Monedero:";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BackColor = System.Drawing.Color.PaleGreen;
            this.TxtNombreCliente.Location = new System.Drawing.Point(141, 57);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.ReadOnly = true;
            this.TxtNombreCliente.Size = new System.Drawing.Size(232, 26);
            this.TxtNombreCliente.TabIndex = 1;
            this.TxtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(72, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(806, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 37;
            // 
            // frmCatCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 654);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitle_Creativa0);
            this.Controls.Add(this.panelTitle_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobro";
            this.TopMost = true;
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            this.panel_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa0.ResumeLayout(false);
            this.panelTitle_Creativa0.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Cambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_PagoEfectivo;
        private System.Windows.Forms.Label label11;
        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btn_Cobrar;
        private LibControls.WinForms.Button_Creativa btn_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Pagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Pendiente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_TiempoVenta;
        private System.Windows.Forms.Timer timerVenta;
        private System.ComponentModel.BackgroundWorker backgroundWorkerVenta;
        private System.Windows.Forms.TextBox Txt_PagoMonedero;
        private System.Windows.Forms.Label label5;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa0;
        private System.Windows.Forms.TextBox Txt_NewMonedero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Txt_Monedero;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}