namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmUsuariosDatosV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosDatosV2));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new MaterialSkin.Controls.MaterialButton();
            this.TxtTipoUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_FechaHoraIngreso = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtApellidoMaterno = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtContraseña = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtApellidoPaterno = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(46, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(176, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Datos Usuario Logueado";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnSalir);
            this.materialCard1.Controls.Add(this.btnCambiarContraseña);
            this.materialCard1.Controls.Add(this.TxtTipoUsuario);
            this.materialCard1.Controls.Add(this.materialLabel9);
            this.materialCard1.Controls.Add(this.Txt_FechaHoraIngreso);
            this.materialCard1.Controls.Add(this.TxtApellidoMaterno);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.TxtContraseña);
            this.materialCard1.Controls.Add(this.TxtApellidoPaterno);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.TxtUsuario);
            this.materialCard1.Controls.Add(this.TxtNombre);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 125);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(848, 600);
            this.materialCard1.TabIndex = 19;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(529, 422);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 68);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCambiarContraseña.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCambiarContraseña.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarContraseña.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCambiarContraseña.Depth = 0;
            this.btnCambiarContraseña.HighEmphasis = true;
            this.btnCambiarContraseña.Icon = null;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(680, 197);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCambiarContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCambiarContraseña.Size = new System.Drawing.Size(86, 36);
            this.btnCambiarContraseña.TabIndex = 33;
            this.btnCambiarContraseña.Text = "Cambiar";
            this.btnCambiarContraseña.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCambiarContraseña.UseAccentColor = false;
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // TxtTipoUsuario
            // 
            this.TxtTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtTipoUsuario.AnimateReadOnly = false;
            this.TxtTipoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtTipoUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtTipoUsuario.Depth = 0;
            this.TxtTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtTipoUsuario.HideSelection = true;
            this.TxtTipoUsuario.LeadingIcon = null;
            this.TxtTipoUsuario.Location = new System.Drawing.Point(32, 442);
            this.TxtTipoUsuario.MaxLength = 32767;
            this.TxtTipoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtTipoUsuario.Name = "TxtTipoUsuario";
            this.TxtTipoUsuario.PasswordChar = '\0';
            this.TxtTipoUsuario.PrefixSuffixText = null;
            this.TxtTipoUsuario.ReadOnly = false;
            this.TxtTipoUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtTipoUsuario.SelectedText = "";
            this.TxtTipoUsuario.SelectionLength = 0;
            this.TxtTipoUsuario.SelectionStart = 0;
            this.TxtTipoUsuario.ShortcutsEnabled = true;
            this.TxtTipoUsuario.Size = new System.Drawing.Size(307, 48);
            this.TxtTipoUsuario.TabIndex = 32;
            this.TxtTipoUsuario.TabStop = false;
            this.TxtTipoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtTipoUsuario.TrailingIcon = null;
            this.TxtTipoUsuario.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(29, 394);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(112, 19);
            this.materialLabel9.TabIndex = 31;
            this.materialLabel9.Text = "Tipo de Usuario";
            // 
            // Txt_FechaHoraIngreso
            // 
            this.Txt_FechaHoraIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_FechaHoraIngreso.AnimateReadOnly = false;
            this.Txt_FechaHoraIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_FechaHoraIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_FechaHoraIngreso.Depth = 0;
            this.Txt_FechaHoraIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_FechaHoraIngreso.HideSelection = true;
            this.Txt_FechaHoraIngreso.LeadingIcon = null;
            this.Txt_FechaHoraIngreso.Location = new System.Drawing.Point(433, 318);
            this.Txt_FechaHoraIngreso.MaxLength = 32767;
            this.Txt_FechaHoraIngreso.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_FechaHoraIngreso.Name = "Txt_FechaHoraIngreso";
            this.Txt_FechaHoraIngreso.PasswordChar = '\0';
            this.Txt_FechaHoraIngreso.PrefixSuffixText = null;
            this.Txt_FechaHoraIngreso.ReadOnly = false;
            this.Txt_FechaHoraIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_FechaHoraIngreso.SelectedText = "";
            this.Txt_FechaHoraIngreso.SelectionLength = 0;
            this.Txt_FechaHoraIngreso.SelectionStart = 0;
            this.Txt_FechaHoraIngreso.ShortcutsEnabled = true;
            this.Txt_FechaHoraIngreso.Size = new System.Drawing.Size(306, 48);
            this.Txt_FechaHoraIngreso.TabIndex = 30;
            this.Txt_FechaHoraIngreso.TabStop = false;
            this.Txt_FechaHoraIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_FechaHoraIngreso.TrailingIcon = null;
            this.Txt_FechaHoraIngreso.UseSystemPasswordChar = false;
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtApellidoMaterno.AnimateReadOnly = false;
            this.TxtApellidoMaterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtApellidoMaterno.Depth = 0;
            this.TxtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtApellidoMaterno.HideSelection = true;
            this.TxtApellidoMaterno.LeadingIcon = null;
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(32, 318);
            this.TxtApellidoMaterno.MaxLength = 32767;
            this.TxtApellidoMaterno.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.PasswordChar = '\0';
            this.TxtApellidoMaterno.PrefixSuffixText = null;
            this.TxtApellidoMaterno.ReadOnly = false;
            this.TxtApellidoMaterno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtApellidoMaterno.SelectedText = "";
            this.TxtApellidoMaterno.SelectionLength = 0;
            this.TxtApellidoMaterno.SelectionStart = 0;
            this.TxtApellidoMaterno.ShortcutsEnabled = true;
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(307, 48);
            this.TxtApellidoMaterno.TabIndex = 29;
            this.TxtApellidoMaterno.TabStop = false;
            this.TxtApellidoMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtApellidoMaterno.TrailingIcon = null;
            this.TxtApellidoMaterno.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Coral;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(430, 270);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(171, 19);
            this.materialLabel6.TabIndex = 28;
            this.materialLabel6.Text = "Fecha y Hora de ingreso";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(29, 270);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(121, 19);
            this.materialLabel7.TabIndex = 27;
            this.materialLabel7.Text = "Apellido Materno";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtContraseña.AnimateReadOnly = false;
            this.TxtContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtContraseña.Depth = 0;
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtContraseña.HideSelection = true;
            this.TxtContraseña.LeadingIcon = null;
            this.TxtContraseña.Location = new System.Drawing.Point(433, 197);
            this.TxtContraseña.MaxLength = 32767;
            this.TxtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.PrefixSuffixText = null;
            this.TxtContraseña.ReadOnly = false;
            this.TxtContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtContraseña.SelectedText = "";
            this.TxtContraseña.SelectionLength = 0;
            this.TxtContraseña.SelectionStart = 0;
            this.TxtContraseña.ShortcutsEnabled = true;
            this.TxtContraseña.Size = new System.Drawing.Size(203, 48);
            this.TxtContraseña.TabIndex = 26;
            this.TxtContraseña.TabStop = false;
            this.TxtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtContraseña.TrailingIcon = null;
            this.TxtContraseña.UseSystemPasswordChar = false;
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtApellidoPaterno.AnimateReadOnly = false;
            this.TxtApellidoPaterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtApellidoPaterno.Depth = 0;
            this.TxtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtApellidoPaterno.HideSelection = true;
            this.TxtApellidoPaterno.LeadingIcon = null;
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(32, 197);
            this.TxtApellidoPaterno.MaxLength = 32767;
            this.TxtApellidoPaterno.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.PasswordChar = '\0';
            this.TxtApellidoPaterno.PrefixSuffixText = null;
            this.TxtApellidoPaterno.ReadOnly = false;
            this.TxtApellidoPaterno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtApellidoPaterno.SelectedText = "";
            this.TxtApellidoPaterno.SelectionLength = 0;
            this.TxtApellidoPaterno.SelectionStart = 0;
            this.TxtApellidoPaterno.ShortcutsEnabled = true;
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(307, 48);
            this.TxtApellidoPaterno.TabIndex = 25;
            this.TxtApellidoPaterno.TabStop = false;
            this.TxtApellidoPaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtApellidoPaterno.TrailingIcon = null;
            this.TxtApellidoPaterno.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(430, 149);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(82, 19);
            this.materialLabel4.TabIndex = 24;
            this.materialLabel4.Text = "Contraseña";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(29, 149);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(117, 19);
            this.materialLabel5.TabIndex = 23;
            this.materialLabel5.Text = "Apellido Paterno";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtUsuario.AnimateReadOnly = false;
            this.TxtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUsuario.HideSelection = true;
            this.TxtUsuario.LeadingIcon = null;
            this.TxtUsuario.Location = new System.Drawing.Point(433, 73);
            this.TxtUsuario.MaxLength = 32767;
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.PrefixSuffixText = null;
            this.TxtUsuario.ReadOnly = false;
            this.TxtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.ShortcutsEnabled = true;
            this.TxtUsuario.Size = new System.Drawing.Size(306, 48);
            this.TxtUsuario.TabIndex = 22;
            this.TxtUsuario.TabStop = false;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUsuario.TrailingIcon = null;
            this.TxtUsuario.UseSystemPasswordChar = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNombre.AnimateReadOnly = false;
            this.TxtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNombre.HideSelection = true;
            this.TxtNombre.LeadingIcon = null;
            this.TxtNombre.Location = new System.Drawing.Point(32, 73);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.PrefixSuffixText = null;
            this.TxtNombre.ReadOnly = false;
            this.TxtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.ShortcutsEnabled = true;
            this.TxtNombre.Size = new System.Drawing.Size(307, 48);
            this.TxtNombre.TabIndex = 21;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNombre.TrailingIcon = null;
            this.TxtNombre.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(430, 25);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(29, 25);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Nombre";
            // 
            // frmUsuariosDatosV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 742);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmUsuariosDatosV2";
            this.Text = "Datos Usuario";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Button btnSalir;
        private MaterialSkin.Controls.MaterialButton btnCambiarContraseña;
        private MaterialSkin.Controls.MaterialTextBox2 TxtTipoUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_FechaHoraIngreso;
        private MaterialSkin.Controls.MaterialTextBox2 TxtApellidoMaterno;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 TxtContraseña;
        private MaterialSkin.Controls.MaterialTextBox2 TxtApellidoPaterno;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 TxtUsuario;
        private MaterialSkin.Controls.MaterialTextBox2 TxtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}