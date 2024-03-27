namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmPrecio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrecio));
            this.lblPrecio = new System.Windows.Forms.Label();
            this.CmbPrecio = new System.Windows.Forms.ComboBox();
            this.panel_login_validator = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.BtnBuscar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtCodigoTarjeta = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Aceptar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel_login_validator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(28, 40);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(128, 22);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio Normal:";
            // 
            // CmbPrecio
            // 
            this.CmbPrecio.Enabled = false;
            this.CmbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPrecio.FormattingEnabled = true;
            this.CmbPrecio.Location = new System.Drawing.Point(185, 37);
            this.CmbPrecio.Name = "CmbPrecio";
            this.CmbPrecio.Size = new System.Drawing.Size(191, 28);
            this.CmbPrecio.TabIndex = 39;
            this.CmbPrecio.SelectionChangeCommitted += new System.EventHandler(this.CmbPrecio_SelectionChangeCommitted);
            // 
            // panel_login_validator
            // 
            this.panel_login_validator.BackColor = System.Drawing.Color.White;
            this.panel_login_validator.BorderColor = System.Drawing.Color.Transparent;
            this.panel_login_validator.Controls.Add(this.BtnBuscar);
            this.panel_login_validator.Controls.Add(this.txtNombreCliente);
            this.panel_login_validator.Controls.Add(this.lblNombre);
            this.panel_login_validator.Controls.Add(this.lblMensaje);
            this.panel_login_validator.Controls.Add(this.txtCodigoTarjeta);
            this.panel_login_validator.Controls.Add(this.lblCliente);
            this.panel_login_validator.Controls.Add(this.label4);
            this.panel_login_validator.Controls.Add(this.brn_Cancelar);
            this.panel_login_validator.Controls.Add(this.CmbPrecio);
            this.panel_login_validator.Controls.Add(this.btn_Aceptar);
            this.panel_login_validator.Controls.Add(this.lblPrecio);
            this.panel_login_validator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login_validator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login_validator.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_login_validator.Location = new System.Drawing.Point(0, 0);
            this.panel_login_validator.Name = "panel_login_validator";
            this.panel_login_validator.Size = new System.Drawing.Size(554, 277);
            this.panel_login_validator.SizeLine = 3;
            this.panel_login_validator.SizeTitle = 20;
            this.panel_login_validator.TabIndex = 40;
            this.panel_login_validator.Title = "";
            this.panel_login_validator.TitleColor = System.Drawing.Color.Transparent;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnBuscar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBuscar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBuscar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.BtnBuscar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.BtnBuscar.FocusRectangle = true;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = null;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.BtnBuscar.ImageFocused = null;
            this.BtnBuscar.ImageInactive = null;
            this.BtnBuscar.ImageMouseOver = null;
            this.BtnBuscar.ImageNormal = null;
            this.BtnBuscar.ImagePressed = null;
            this.BtnBuscar.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnBuscar.KeyButton = System.Windows.Forms.Keys.F10;
            this.BtnBuscar.KeyButtonView = true;
            this.BtnBuscar.Location = new System.Drawing.Point(382, 103);
            this.BtnBuscar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.BtnBuscar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.OffsetPressedContent = true;
            this.BtnBuscar.Size = new System.Drawing.Size(80, 26);
            this.BtnBuscar.TabIndex = 126;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextDropShadow = true;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(185, 141);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(357, 26);
            this.txtNombreCliente.TabIndex = 125;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(28, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(128, 22);
            this.lblNombre.TabIndex = 124;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Location = new System.Drawing.Point(28, 75);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(358, 26);
            this.lblMensaje.TabIndex = 123;
            this.lblMensaje.Text = "Ingrese el código de la tarjeta del cliente";
            // 
            // txtCodigoTarjeta
            // 
            this.txtCodigoTarjeta.Location = new System.Drawing.Point(185, 103);
            this.txtCodigoTarjeta.Name = "txtCodigoTarjeta";
            this.txtCodigoTarjeta.Size = new System.Drawing.Size(191, 26);
            this.txtCodigoTarjeta.TabIndex = 122;
            this.txtCodigoTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoTarjeta_KeyPress);
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(28, 106);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(128, 22);
            this.lblCliente.TabIndex = 121;
            this.lblCliente.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(141, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 120;
            this.label4.Tag = "";
            this.label4.Text = "Precios";
            // 
            // brn_Cancelar
            // 
            this.brn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brn_Cancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.brn_Cancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.brn_Cancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.brn_Cancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.brn_Cancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.brn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brn_Cancelar.FocusRectangle = true;
            this.brn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Cancelar.Image = null;
            this.brn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brn_Cancelar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.brn_Cancelar.ImageFocused = null;
            this.brn_Cancelar.ImageInactive = null;
            this.brn_Cancelar.ImageMouseOver = null;
            this.brn_Cancelar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.brn_Cancelar.ImagePressed = null;
            this.brn_Cancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.brn_Cancelar.KeyButton = System.Windows.Forms.Keys.None;
            this.brn_Cancelar.KeyButtonView = false;
            this.brn_Cancelar.Location = new System.Drawing.Point(157, 200);
            this.brn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.brn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.brn_Cancelar.Name = "brn_Cancelar";
            this.brn_Cancelar.OffsetPressedContent = true;
            this.brn_Cancelar.Size = new System.Drawing.Size(80, 65);
            this.brn_Cancelar.TabIndex = 4;
            this.brn_Cancelar.Text = "Cancelar";
            this.brn_Cancelar.TextDropShadow = true;
            this.brn_Cancelar.UseVisualStyleBackColor = false;
            this.brn_Cancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Aceptar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Aceptar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Aceptar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Aceptar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Aceptar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Aceptar.FocusRectangle = true;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Image = null;
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Aceptar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Aceptar.ImageFocused = null;
            this.btn_Aceptar.ImageInactive = null;
            this.btn_Aceptar.ImageMouseOver = null;
            this.btn_Aceptar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.btn_Aceptar.ImagePressed = null;
            this.btn_Aceptar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Aceptar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Aceptar.KeyButtonView = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(243, 200);
            this.btn_Aceptar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Aceptar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.OffsetPressedContent = true;
            this.btn_Aceptar.Size = new System.Drawing.Size(80, 65);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextDropShadow = true;
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.brn_Cancelar;
            this.ClientSize = new System.Drawing.Size(554, 277);
            this.Controls.Add(this.panel_login_validator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrecio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Precios";
            this.TopMost = true;
            this.panel_login_validator.ResumeLayout(false);
            this.panel_login_validator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox CmbPrecio;
        private LibControls.WinForms.PanelTitle_Creativa panel_login_validator;
        private LibControls.WinForms.Button_Creativa brn_Cancelar;
        private LibControls.WinForms.Button_Creativa btn_Aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtCodigoTarjeta;
        private System.Windows.Forms.Label lblCliente;
        private LibControls.WinForms.Button_Creativa BtnBuscar;
    }
}