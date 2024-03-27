namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatUsuarios));
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btn_Guardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.CmbSucursal = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbTurno = new System.Windows.Forms.ComboBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtColonia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtmFechaNac = new System.Windows.Forms.DateTimePicker();
            this.panel_Creativa1.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.btn_Guardar);
            this.panel_Creativa1.Controls.Add(this.btn_Cancelar);
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 571);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(465, 85);
            this.panel_Creativa1.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Guardar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Guardar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Guardar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Guardar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Guardar.FocusRectangle = true;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Image = null;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Guardar.ImageFocused = null;
            this.btn_Guardar.ImageInactive = null;
            this.btn_Guardar.ImageMouseOver = null;
            this.btn_Guardar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.btn_Guardar.ImagePressed = null;
            this.btn_Guardar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Guardar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Guardar.KeyButtonView = false;
            this.btn_Guardar.Location = new System.Drawing.Point(285, 10);
            this.btn_Guardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Guardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.OffsetPressedContent = true;
            this.btn_Guardar.Size = new System.Drawing.Size(80, 65);
            this.btn_Guardar.TabIndex = 13;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.TextDropShadow = true;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Cancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Cancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Cancelar.FocusRectangle = true;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Cancelar.Location = new System.Drawing.Point(375, 10);
            this.btn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.OffsetPressedContent = true;
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 65);
            this.btn_Cancelar.TabIndex = 14;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.TextDropShadow = true;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa1.Controls.Add(this.panel_Creativa1);
            this.panelTitle_Creativa1.Controls.Add(this.label13);
            this.panelTitle_Creativa1.Controls.Add(this.CmbSucursal);
            this.panelTitle_Creativa1.Controls.Add(this.label12);
            this.panelTitle_Creativa1.Controls.Add(this.label11);
            this.panelTitle_Creativa1.Controls.Add(this.CmbTurno);
            this.panelTitle_Creativa1.Controls.Add(this.TxtContraseña);
            this.panelTitle_Creativa1.Controls.Add(this.label10);
            this.panelTitle_Creativa1.Controls.Add(this.TxtUsuario);
            this.panelTitle_Creativa1.Controls.Add(this.label9);
            this.panelTitle_Creativa1.Controls.Add(this.CmbTipoUsuario);
            this.panelTitle_Creativa1.Controls.Add(this.label8);
            this.panelTitle_Creativa1.Controls.Add(this.TxtNumero);
            this.panelTitle_Creativa1.Controls.Add(this.label7);
            this.panelTitle_Creativa1.Controls.Add(this.TxtColonia);
            this.panelTitle_Creativa1.Controls.Add(this.label6);
            this.panelTitle_Creativa1.Controls.Add(this.TxtCalle);
            this.panelTitle_Creativa1.Controls.Add(this.label5);
            this.panelTitle_Creativa1.Controls.Add(this.label4);
            this.panelTitle_Creativa1.Controls.Add(this.TxtApellidoMaterno);
            this.panelTitle_Creativa1.Controls.Add(this.label3);
            this.panelTitle_Creativa1.Controls.Add(this.TxtApellidoPaterno);
            this.panelTitle_Creativa1.Controls.Add(this.label2);
            this.panelTitle_Creativa1.Controls.Add(this.TxtNombre);
            this.panelTitle_Creativa1.Controls.Add(this.label1);
            this.panelTitle_Creativa1.Controls.Add(this.DtmFechaNac);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.DrawGradient = false;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(465, 657);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(176, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Usuarios";
            // 
            // CmbSucursal
            // 
            this.CmbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSucursal.FormattingEnabled = true;
            this.CmbSucursal.Location = new System.Drawing.Point(166, 429);
            this.CmbSucursal.Name = "CmbSucursal";
            this.CmbSucursal.Size = new System.Drawing.Size(261, 28);
            this.CmbSucursal.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sucursal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(106, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Turno";
            // 
            // CmbTurno
            // 
            this.CmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTurno.FormattingEnabled = true;
            this.CmbTurno.Location = new System.Drawing.Point(166, 383);
            this.CmbTurno.Name = "CmbTurno";
            this.CmbTurno.Size = new System.Drawing.Size(261, 28);
            this.CmbTurno.TabIndex = 9;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(166, 524);
            this.TxtContraseña.MaxLength = 32;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(261, 27);
            this.TxtContraseña.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 526);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(167, 478);
            this.TxtUsuario.MaxLength = 15;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(261, 27);
            this.TxtUsuario.TabIndex = 11;
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(94, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Usuario";
            // 
            // CmbTipoUsuario
            // 
            this.CmbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoUsuario.FormattingEnabled = true;
            this.CmbTipoUsuario.Location = new System.Drawing.Point(166, 340);
            this.CmbTipoUsuario.Name = "CmbTipoUsuario";
            this.CmbTipoUsuario.Size = new System.Drawing.Size(261, 28);
            this.CmbTipoUsuario.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tipo usuario";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(166, 295);
            this.TxtNumero.MaxLength = 15;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(261, 27);
            this.TxtNumero.TabIndex = 7;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número";
            // 
            // TxtColonia
            // 
            this.TxtColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColonia.Location = new System.Drawing.Point(166, 248);
            this.TxtColonia.MaxLength = 50;
            this.TxtColonia.Name = "TxtColonia";
            this.TxtColonia.Size = new System.Drawing.Size(261, 27);
            this.TxtColonia.TabIndex = 6;
            this.TxtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtColonia_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Colonia";
            // 
            // TxtCalle
            // 
            this.TxtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCalle.Location = new System.Drawing.Point(167, 206);
            this.TxtCalle.MaxLength = 90;
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(261, 27);
            this.TxtCalle.TabIndex = 5;
            this.TxtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCalle_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha nacimiento";
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(166, 120);
            this.TxtApellidoMaterno.MaxLength = 50;
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(261, 27);
            this.TxtApellidoMaterno.TabIndex = 3;
            this.TxtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoMaterno_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido materno";
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(166, 77);
            this.TxtApellidoPaterno.MaxLength = 50;
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(261, 27);
            this.TxtApellidoPaterno.TabIndex = 2;
            this.TxtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoPaterno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido paterno";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(166, 37);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(261, 27);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // DtmFechaNac
            // 
            this.DtmFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtmFechaNac.Location = new System.Drawing.Point(167, 163);
            this.DtmFechaNac.Name = "DtmFechaNac";
            this.DtmFechaNac.Size = new System.Drawing.Size(261, 27);
            this.DtmFechaNac.TabIndex = 4;
            // 
            // frmCatUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 657);
            this.ControlBox = true;
            this.Controls.Add(this.panelTitle_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmCatUsuarios_Load);
            this.panel_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btn_Guardar;
        private LibControls.WinForms.Button_Creativa btn_Cancelar;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.ComboBox CmbSucursal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbTurno;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbTipoUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtColonia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellidoMaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidoPaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtmFechaNac;
        private System.Windows.Forms.Label label13;
    }
}