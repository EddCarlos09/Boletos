namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel_login = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnAceptar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_login.BorderColor = System.Drawing.Color.Transparent;
            this.panel_login.Controls.Add(this.label4);
            this.panel_login.Controls.Add(this.btnCancelar);
            this.panel_login.Controls.Add(this.btnAceptar);
            this.panel_login.Controls.Add(this.txt_mensaje);
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.txtUsuario);
            this.panel_login.Controls.Add(this.txtContraseña);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.pictureBox1);
            this.panel_login.DrawGradient = false;
            this.panel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_login.Location = new System.Drawing.Point(12, 16);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(602, 269);
            this.panel_login.SizeLine = 3;
            this.panel_login.SizeTitle = 20;
            this.panel_login.TabIndex = 0;
            this.panel_login.Title = "";
            this.panel_login.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(118, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingrese los datos de su cuenta de usuario";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnCancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FocusRectangle = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.ImageFocused = null;
            this.btnCancelar.ImageInactive = null;
            this.btnCancelar.ImageMouseOver = null;
            this.btnCancelar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.btnCancelar.ImagePressed = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCancelar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnCancelar.KeyButtonView = false;
            this.btnCancelar.Location = new System.Drawing.Point(421, 188);
            this.btnCancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OffsetPressedContent = true;
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TextDropShadow = true;
            this.toolTipLogin.SetToolTip(this.btnCancelar, "Salir del sistema");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAceptar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnAceptar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnAceptar.FocusRectangle = true;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = null;
            this.btnAceptar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnAceptar.ImageFocused = null;
            this.btnAceptar.ImageInactive = null;
            this.btnAceptar.ImageMouseOver = null;
            this.btnAceptar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.btnAceptar.ImagePressed = null;
            this.btnAceptar.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAceptar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnAceptar.KeyButtonView = false;
            this.btnAceptar.Location = new System.Drawing.Point(501, 188);
            this.btnAceptar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAceptar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OffsetPressedContent = true;
            this.btnAceptar.Size = new System.Drawing.Size(80, 65);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.TextDropShadow = true;
            this.toolTipLogin.SetToolTip(this.btnAceptar, "Ingresar al sistema");
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(12, 196);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(401, 46);
            this.txt_mensaje.TabIndex = 0;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mensaje.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(310, 69);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(271, 27);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(310, 117);
            this.txtContraseña.MaxLength = 32;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(271, 27);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.Administrator;
            this.pictureBox1.Location = new System.Drawing.Point(43, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolTipLogin
            // 
            this.toolTipLogin.IsBalloon = true;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(626, 309);
            this.Controls.Add(this.panel_login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Aury";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyUp);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panel_login;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LibControls.WinForms.Button_Creativa btnAceptar;
        private System.Windows.Forms.ToolTip toolTipLogin;
        private LibControls.WinForms.Button_Creativa btnCancelar;
        private System.Windows.Forms.Label label4;

    }

}