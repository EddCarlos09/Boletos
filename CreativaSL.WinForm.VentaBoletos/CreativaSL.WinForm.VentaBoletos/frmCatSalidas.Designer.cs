namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatSalidas));
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btnGuardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnCancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.panelDias = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.panelFechas = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.txtNombreViaje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDisenioCamion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoCamion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumCamion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.cmbCamion = new System.Windows.Forms.ComboBox();
            this.cmbRutas = new System.Windows.Forms.ComboBox();
            this.dgvRutasInt = new System.Windows.Forms.DataGridView();
            this.terminalOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbtnEspecial = new System.Windows.Forms.RadioButton();
            this.rdbtnLineas = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Creativa1.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.panelDias.SuspendLayout();
            this.panelFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasInt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.btnGuardar);
            this.panel_Creativa1.Controls.Add(this.btnCancelar);
            this.panel_Creativa1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 622);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(703, 85);
            this.panel_Creativa1.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnGuardar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.FocusRectangle = true;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnGuardar.ImageFocused = null;
            this.btnGuardar.ImageInactive = null;
            this.btnGuardar.ImageMouseOver = null;
            this.btnGuardar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.btnGuardar.ImagePressed = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGuardar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnGuardar.KeyButtonView = false;
            this.btnGuardar.Location = new System.Drawing.Point(509, 10);
            this.btnGuardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGuardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OffsetPressedContent = true;
            this.btnGuardar.Size = new System.Drawing.Size(80, 65);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextDropShadow = true;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnCancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FocusRectangle = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.ImageFocused = null;
            this.btnCancelar.ImageInactive = null;
            this.btnCancelar.ImageMouseOver = null;
            this.btnCancelar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.btnCancelar.ImagePressed = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancelar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnCancelar.KeyButtonView = false;
            this.btnCancelar.Location = new System.Drawing.Point(610, 10);
            this.btnCancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OffsetPressedContent = true;
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextDropShadow = true;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTitle_Creativa1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa1.Controls.Add(this.label10);
            this.panelTitle_Creativa1.Controls.Add(this.label9);
            this.panelTitle_Creativa1.Controls.Add(this.dtpHora);
            this.panelTitle_Creativa1.Controls.Add(this.txt_mensaje);
            this.panelTitle_Creativa1.Controls.Add(this.panelDias);
            this.panelTitle_Creativa1.Controls.Add(this.panelFechas);
            this.panelTitle_Creativa1.Controls.Add(this.txtNombreViaje);
            this.panelTitle_Creativa1.Controls.Add(this.label8);
            this.panelTitle_Creativa1.Controls.Add(this.txtDisenioCamion);
            this.panelTitle_Creativa1.Controls.Add(this.label7);
            this.panelTitle_Creativa1.Controls.Add(this.txtTipoCamion);
            this.panelTitle_Creativa1.Controls.Add(this.label6);
            this.panelTitle_Creativa1.Controls.Add(this.txtNumCamion);
            this.panelTitle_Creativa1.Controls.Add(this.label5);
            this.panelTitle_Creativa1.Controls.Add(this.txtPiso);
            this.panelTitle_Creativa1.Controls.Add(this.cmbCamion);
            this.panelTitle_Creativa1.Controls.Add(this.cmbRutas);
            this.panelTitle_Creativa1.Controls.Add(this.dgvRutasInt);
            this.panelTitle_Creativa1.Controls.Add(this.label2);
            this.panelTitle_Creativa1.Controls.Add(this.rdbtnEspecial);
            this.panelTitle_Creativa1.Controls.Add(this.rdbtnLineas);
            this.panelTitle_Creativa1.Controls.Add(this.label4);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.DrawGradient = false;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(703, 707);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 4;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(313, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Viajes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(30, 548);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Horario de salida:";
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm:ss";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(206, 544);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(130, 26);
            this.dtpHora.TabIndex = 19;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(73, 581);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(496, 32);
            this.txt_mensaje.TabIndex = 0;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mensaje.Visible = false;
            // 
            // panelDias
            // 
            this.panelDias.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelDias.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelDias.Controls.Add(this.chkDomingo);
            this.panelDias.Controls.Add(this.chkSabado);
            this.panelDias.Controls.Add(this.chkViernes);
            this.panelDias.Controls.Add(this.chkJueves);
            this.panelDias.Controls.Add(this.chkMiercoles);
            this.panelDias.Controls.Add(this.chkMartes);
            this.panelDias.Controls.Add(this.chkLunes);
            this.panelDias.DrawGradient = false;
            this.panelDias.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelDias.Location = new System.Drawing.Point(27, 143);
            this.panelDias.Name = "panelDias";
            this.panelDias.Size = new System.Drawing.Size(322, 100);
            this.panelDias.SizeLine = 3;
            this.panelDias.SizeTitle = 20;
            this.panelDias.TabIndex = 41;
            this.panelDias.Title = "Días";
            this.panelDias.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.Location = new System.Drawing.Point(272, 44);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(40, 24);
            this.chkDomingo.TabIndex = 10;
            this.chkDomingo.Text = "D";
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(229, 43);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(39, 24);
            this.chkSabado.TabIndex = 9;
            this.chkSabado.Text = "S";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(186, 44);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(39, 24);
            this.chkViernes.TabIndex = 8;
            this.chkViernes.Text = "V";
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(145, 44);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(36, 24);
            this.chkJueves.TabIndex = 7;
            this.chkJueves.Text = "J";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(100, 44);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(41, 24);
            this.chkMiercoles.TabIndex = 6;
            this.chkMiercoles.Text = "M";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(54, 44);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(41, 24);
            this.chkMartes.TabIndex = 5;
            this.chkMartes.Text = "M";
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(11, 44);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(37, 24);
            this.chkLunes.TabIndex = 4;
            this.chkLunes.Text = "L";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // panelFechas
            // 
            this.panelFechas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelFechas.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelFechas.Controls.Add(this.label3);
            this.panelFechas.Controls.Add(this.dtpFecInicio);
            this.panelFechas.Controls.Add(this.label1);
            this.panelFechas.Controls.Add(this.dtpFecFin);
            this.panelFechas.DrawGradient = false;
            this.panelFechas.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelFechas.Location = new System.Drawing.Point(369, 143);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(309, 100);
            this.panelFechas.SizeLine = 3;
            this.panelFechas.SizeTitle = 20;
            this.panelFechas.TabIndex = 40;
            this.panelFechas.Title = "Fechas";
            this.panelFechas.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Inicio";
            // 
            // dtpFecInicio
            // 
            this.dtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecInicio.Location = new System.Drawing.Point(148, 33);
            this.dtpFecInicio.Name = "dtpFecInicio";
            this.dtpFecInicio.Size = new System.Drawing.Size(117, 26);
            this.dtpFecInicio.TabIndex = 11;
            this.dtpFecInicio.ValueChanged += new System.EventHandler(this.dtpFecInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Final";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(148, 60);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(117, 26);
            this.dtpFecFin.TabIndex = 12;
            this.dtpFecFin.ValueChanged += new System.EventHandler(this.dtpFecFin_ValueChanged);
            // 
            // txtNombreViaje
            // 
            this.txtNombreViaje.Location = new System.Drawing.Point(29, 66);
            this.txtNombreViaje.Name = "txtNombreViaje";
            this.txtNombreViaje.Size = new System.Drawing.Size(325, 26);
            this.txtNombreViaje.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(32, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre Viaje";
            // 
            // txtDisenioCamion
            // 
            this.txtDisenioCamion.Location = new System.Drawing.Point(174, 511);
            this.txtDisenioCamion.Name = "txtDisenioCamion";
            this.txtDisenioCamion.ReadOnly = true;
            this.txtDisenioCamion.Size = new System.Drawing.Size(323, 26);
            this.txtDisenioCamion.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(28, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Diseño Camión";
            // 
            // txtTipoCamion
            // 
            this.txtTipoCamion.Location = new System.Drawing.Point(438, 482);
            this.txtTipoCamion.Name = "txtTipoCamion";
            this.txtTipoCamion.ReadOnly = true;
            this.txtTipoCamion.Size = new System.Drawing.Size(240, 26);
            this.txtTipoCamion.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(316, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo Camión";
            // 
            // txtNumCamion
            // 
            this.txtNumCamion.Location = new System.Drawing.Point(154, 479);
            this.txtNumCamion.Name = "txtNumCamion";
            this.txtNumCamion.ReadOnly = true;
            this.txtNumCamion.Size = new System.Drawing.Size(156, 26);
            this.txtNumCamion.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Núm. Camión";
            // 
            // txtPiso
            // 
            this.txtPiso.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiso.ForeColor = System.Drawing.Color.White;
            this.txtPiso.Location = new System.Drawing.Point(27, 300);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.ReadOnly = true;
            this.txtPiso.Size = new System.Drawing.Size(651, 19);
            this.txtPiso.TabIndex = 0;
            this.txtPiso.TabStop = false;
            this.txtPiso.Text = "Terminales Destino";
            this.txtPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbCamion
            // 
            this.cmbCamion.FormattingEnabled = true;
            this.cmbCamion.Location = new System.Drawing.Point(100, 445);
            this.cmbCamion.Name = "cmbCamion";
            this.cmbCamion.Size = new System.Drawing.Size(578, 28);
            this.cmbCamion.TabIndex = 15;
            this.cmbCamion.SelectedIndexChanged += new System.EventHandler(this.cmbCamion_SelectedIndexChanged);
            this.cmbCamion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCamion_KeyPress);
            // 
            // cmbRutas
            // 
            this.cmbRutas.FormattingEnabled = true;
            this.cmbRutas.Location = new System.Drawing.Point(73, 266);
            this.cmbRutas.Name = "cmbRutas";
            this.cmbRutas.Size = new System.Drawing.Size(605, 28);
            this.cmbRutas.TabIndex = 13;
            this.cmbRutas.SelectedIndexChanged += new System.EventHandler(this.cmbRutas_SelectedIndexChanged);
            this.cmbRutas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRutas_KeyPress);
            // 
            // dgvRutasInt
            // 
            this.dgvRutasInt.AllowUserToAddRows = false;
            this.dgvRutasInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutasInt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.terminalOrigen,
            this.terminalDestino,
            this.tiempo});
            this.dgvRutasInt.Location = new System.Drawing.Point(24, 324);
            this.dgvRutasInt.MultiSelect = false;
            this.dgvRutasInt.Name = "dgvRutasInt";
            this.dgvRutasInt.ReadOnly = true;
            this.dgvRutasInt.Size = new System.Drawing.Size(654, 115);
            this.dgvRutasInt.TabIndex = 14;
            // 
            // terminalOrigen
            // 
            this.terminalOrigen.DataPropertyName = "terminalOrigen";
            this.terminalOrigen.HeaderText = "Terminal Origen";
            this.terminalOrigen.Name = "terminalOrigen";
            this.terminalOrigen.ReadOnly = true;
            this.terminalOrigen.Width = 200;
            // 
            // terminalDestino
            // 
            this.terminalDestino.DataPropertyName = "terminalDestino";
            this.terminalDestino.HeaderText = "Terminal Destino";
            this.terminalDestino.Name = "terminalDestino";
            this.terminalDestino.ReadOnly = true;
            this.terminalDestino.Width = 200;
            // 
            // tiempo
            // 
            this.tiempo.DataPropertyName = "tiempo";
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            this.tiempo.Width = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Camión";
            // 
            // rdbtnEspecial
            // 
            this.rdbtnEspecial.AutoSize = true;
            this.rdbtnEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rdbtnEspecial.Location = new System.Drawing.Point(246, 103);
            this.rdbtnEspecial.Name = "rdbtnEspecial";
            this.rdbtnEspecial.Size = new System.Drawing.Size(140, 24);
            this.rdbtnEspecial.TabIndex = 3;
            this.rdbtnEspecial.Text = "Viaje Especial";
            this.rdbtnEspecial.UseVisualStyleBackColor = true;
            this.rdbtnEspecial.CheckedChanged += new System.EventHandler(this.rdbtnEspecial_CheckedChanged);
            // 
            // rdbtnLineas
            // 
            this.rdbtnLineas.AutoSize = true;
            this.rdbtnLineas.Checked = true;
            this.rdbtnLineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rdbtnLineas.Location = new System.Drawing.Point(31, 103);
            this.rdbtnLineas.Name = "rdbtnLineas";
            this.rdbtnLineas.Size = new System.Drawing.Size(130, 24);
            this.rdbtnLineas.TabIndex = 2;
            this.rdbtnLineas.TabStop = true;
            this.rdbtnLineas.Text = "Viaje Líneas ";
            this.rdbtnLineas.UseVisualStyleBackColor = true;
            this.rdbtnLineas.CheckedChanged += new System.EventHandler(this.rdbtnLineas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(23, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ruta";
            // 
            // frmCatSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(703, 707);
            this.ControlBox = true;
            this.Controls.Add(this.panel_Creativa1);
            this.Controls.Add(this.panelTitle_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmCatSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajes";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmCatTarifas_Load);
            this.panel_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            this.panelDias.ResumeLayout(false);
            this.panelDias.PerformLayout();
            this.panelFechas.ResumeLayout(false);
            this.panelFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasInt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btnGuardar;
        private LibControls.WinForms.Button_Creativa btnCancelar;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private LibControls.WinForms.PanelTitle_Creativa panelDias;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkLunes;
        private LibControls.WinForms.PanelTitle_Creativa panelFechas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.TextBox txtNombreViaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDisenioCamion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoCamion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumCamion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.ComboBox cmbCamion;
        private System.Windows.Forms.ComboBox cmbRutas;
        private System.Windows.Forms.DataGridView dgvRutasInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbtnEspecial;
        private System.Windows.Forms.RadioButton rdbtnLineas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label10;
    }
}