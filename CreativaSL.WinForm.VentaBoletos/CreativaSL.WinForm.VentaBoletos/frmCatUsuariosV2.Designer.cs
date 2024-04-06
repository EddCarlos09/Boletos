namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatUsuariosV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatUsuariosV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.DtmFechaNac = new System.Windows.Forms.DateTimePicker();
            this.TxtContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbTipoUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbSucursal = new MaterialSkin.Controls.MaterialComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbTurno = new MaterialSkin.Controls.MaterialComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtColonia = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCalle = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtApellidoMaterno = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtApellidoPaterno = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.DtmFechaNac);
            this.panel1.Controls.Add(this.TxtContraseña);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CmbTipoUsuario);
            this.panel1.Controls.Add(this.CmbSucursal);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.CmbTurno);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TxtNumero);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtColonia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtCalle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtApellidoMaterno);
            this.panel1.Controls.Add(this.TxtApellidoPaterno);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 590);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(505, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCancelar.Size = new System.Drawing.Size(156, 76);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(264, 492);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGuardar.Size = new System.Drawing.Size(156, 74);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // DtmFechaNac
            // 
            this.DtmFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtmFechaNac.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtmFechaNac.Location = new System.Drawing.Point(28, 405);
            this.DtmFechaNac.Name = "DtmFechaNac";
            this.DtmFechaNac.Size = new System.Drawing.Size(240, 38);
            this.DtmFechaNac.TabIndex = 27;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.AnimateReadOnly = false;
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Depth = 0;
            this.TxtContraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtContraseña.LeadingIcon = null;
            this.TxtContraseña.Location = new System.Drawing.Point(614, 405);
            this.TxtContraseña.MaxLength = 50;
            this.TxtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtContraseña.Multiline = false;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Password = true;
            this.TxtContraseña.Size = new System.Drawing.Size(246, 50);
            this.TxtContraseña.TabIndex = 26;
            this.TxtContraseña.Text = "";
            this.TxtContraseña.TrailingIcon = null;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(611, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.AnimateReadOnly = false;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUsuario.LeadingIcon = null;
            this.TxtUsuario.Location = new System.Drawing.Point(614, 308);
            this.TxtUsuario.MaxLength = 50;
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUsuario.Multiline = false;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(246, 50);
            this.TxtUsuario.TabIndex = 24;
            this.TxtUsuario.Text = "";
            this.TxtUsuario.TrailingIcon = null;
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(611, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Usuario";
            // 
            // CmbTipoUsuario
            // 
            this.CmbTipoUsuario.AutoResize = false;
            this.CmbTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbTipoUsuario.Depth = 0;
            this.CmbTipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbTipoUsuario.DropDownHeight = 174;
            this.CmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoUsuario.DropDownWidth = 121;
            this.CmbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbTipoUsuario.FormattingEnabled = true;
            this.CmbTipoUsuario.IntegralHeight = false;
            this.CmbTipoUsuario.ItemHeight = 43;
            this.CmbTipoUsuario.Location = new System.Drawing.Point(330, 404);
            this.CmbTipoUsuario.MaxDropDownItems = 4;
            this.CmbTipoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbTipoUsuario.Name = "CmbTipoUsuario";
            this.CmbTipoUsuario.Size = new System.Drawing.Size(246, 49);
            this.CmbTipoUsuario.StartIndex = 0;
            this.CmbTipoUsuario.TabIndex = 22;
            // 
            // CmbSucursal
            // 
            this.CmbSucursal.AutoResize = false;
            this.CmbSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbSucursal.Depth = 0;
            this.CmbSucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbSucursal.DropDownHeight = 174;
            this.CmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSucursal.DropDownWidth = 121;
            this.CmbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbSucursal.FormattingEnabled = true;
            this.CmbSucursal.IntegralHeight = false;
            this.CmbSucursal.ItemHeight = 43;
            this.CmbSucursal.Location = new System.Drawing.Point(614, 210);
            this.CmbSucursal.MaxDropDownItems = 4;
            this.CmbSucursal.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbSucursal.Name = "CmbSucursal";
            this.CmbSucursal.Size = new System.Drawing.Size(246, 49);
            this.CmbSucursal.StartIndex = 0;
            this.CmbSucursal.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(609, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sucursal";
            // 
            // CmbTurno
            // 
            this.CmbTurno.AutoResize = false;
            this.CmbTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbTurno.Depth = 0;
            this.CmbTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbTurno.DropDownHeight = 174;
            this.CmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTurno.DropDownWidth = 121;
            this.CmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbTurno.FormattingEnabled = true;
            this.CmbTurno.IntegralHeight = false;
            this.CmbTurno.ItemHeight = 43;
            this.CmbTurno.Location = new System.Drawing.Point(614, 113);
            this.CmbTurno.MaxDropDownItems = 4;
            this.CmbTurno.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbTurno.Name = "CmbTurno";
            this.CmbTurno.Size = new System.Drawing.Size(246, 49);
            this.CmbTurno.StartIndex = 0;
            this.CmbTurno.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(609, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Turno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(325, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo usuario";
            // 
            // TxtNumero
            // 
            this.TxtNumero.AnimateReadOnly = false;
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumero.Depth = 0;
            this.TxtNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNumero.LeadingIcon = null;
            this.TxtNumero.Location = new System.Drawing.Point(330, 307);
            this.TxtNumero.MaxLength = 50;
            this.TxtNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNumero.Multiline = false;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(246, 50);
            this.TxtNumero.TabIndex = 16;
            this.TxtNumero.Text = "";
            this.TxtNumero.TrailingIcon = null;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(325, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Número";
            // 
            // TxtColonia
            // 
            this.TxtColonia.AnimateReadOnly = false;
            this.TxtColonia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtColonia.Depth = 0;
            this.TxtColonia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtColonia.LeadingIcon = null;
            this.TxtColonia.Location = new System.Drawing.Point(330, 209);
            this.TxtColonia.MaxLength = 50;
            this.TxtColonia.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtColonia.Multiline = false;
            this.TxtColonia.Name = "TxtColonia";
            this.TxtColonia.Size = new System.Drawing.Size(246, 50);
            this.TxtColonia.TabIndex = 14;
            this.TxtColonia.Text = "";
            this.TxtColonia.TrailingIcon = null;
            this.TxtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtColonia_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(325, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Colonia";
            // 
            // TxtCalle
            // 
            this.TxtCalle.AnimateReadOnly = false;
            this.TxtCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCalle.Depth = 0;
            this.TxtCalle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCalle.LeadingIcon = null;
            this.TxtCalle.Location = new System.Drawing.Point(330, 111);
            this.TxtCalle.MaxLength = 50;
            this.TxtCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCalle.Multiline = false;
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(246, 50);
            this.TxtCalle.TabIndex = 12;
            this.TxtCalle.Text = "";
            this.TxtCalle.TrailingIcon = null;
            this.TxtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCalle_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(325, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Calle";
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.AnimateReadOnly = false;
            this.TxtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtApellidoMaterno.Depth = 0;
            this.TxtApellidoMaterno.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtApellidoMaterno.LeadingIcon = null;
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(28, 307);
            this.TxtApellidoMaterno.MaxLength = 50;
            this.TxtApellidoMaterno.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtApellidoMaterno.Multiline = false;
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(246, 50);
            this.TxtApellidoMaterno.TabIndex = 9;
            this.TxtApellidoMaterno.Text = "";
            this.TxtApellidoMaterno.TrailingIcon = null;
            this.TxtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoMaterno_KeyPress);
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.AnimateReadOnly = false;
            this.TxtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtApellidoPaterno.Depth = 0;
            this.TxtApellidoPaterno.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtApellidoPaterno.LeadingIcon = null;
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(28, 208);
            this.TxtApellidoPaterno.MaxLength = 50;
            this.TxtApellidoPaterno.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtApellidoPaterno.Multiline = false;
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(246, 50);
            this.TxtApellidoPaterno.TabIndex = 8;
            this.TxtApellidoPaterno.Text = "";
            this.TxtApellidoPaterno.TrailingIcon = null;
            this.TxtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoPaterno_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.AnimateReadOnly = false;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNombre.LeadingIcon = null;
            this.TxtNombre.Location = new System.Drawing.Point(28, 112);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(246, 50);
            this.TxtNombre.TabIndex = 7;
            this.TxtNombre.Text = "";
            this.TxtNombre.TrailingIcon = null;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(23, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(23, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(23, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(23, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "Usuarios";
            // 
            // frmCatUsuariosV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 657);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatUsuariosV2";
            this.Text = "frmCatUsuariosV2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox TxtApellidoMaterno;
        private MaterialSkin.Controls.MaterialTextBox TxtApellidoPaterno;
        private MaterialSkin.Controls.MaterialTextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox TxtCalle;
        private MaterialSkin.Controls.MaterialTextBox TxtColonia;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox TxtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialComboBox CmbTurno;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialComboBox CmbTipoUsuario;
        private MaterialSkin.Controls.MaterialComboBox CmbSucursal;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialTextBox TxtUsuario;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialTextBox TxtContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DtmFechaNac;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}