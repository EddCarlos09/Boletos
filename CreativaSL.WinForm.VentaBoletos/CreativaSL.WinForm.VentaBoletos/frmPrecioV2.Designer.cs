namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmPrecioV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrecioV2));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrecio = new MaterialSkin.Controls.MaterialLabel();
            this.CmbPrecio = new MaterialSkin.Controls.MaterialComboBox();
            this.lblMensaje = new MaterialSkin.Controls.MaterialLabel();
            this.lblCliente = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigoTarjeta = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.brn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(85, 102);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Precios";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Depth = 0;
            this.lblPrecio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecio.Location = new System.Drawing.Point(69, 146);
            this.lblPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(109, 19);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precios Normal";
            // 
            // CmbPrecio
            // 
            this.CmbPrecio.AutoResize = false;
            this.CmbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbPrecio.Depth = 0;
            this.CmbPrecio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbPrecio.DropDownHeight = 174;
            this.CmbPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPrecio.DropDownWidth = 121;
            this.CmbPrecio.Enabled = false;
            this.CmbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbPrecio.FormattingEnabled = true;
            this.CmbPrecio.IntegralHeight = false;
            this.CmbPrecio.ItemHeight = 43;
            this.CmbPrecio.Location = new System.Drawing.Point(50, 185);
            this.CmbPrecio.MaxDropDownItems = 4;
            this.CmbPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbPrecio.Name = "CmbPrecio";
            this.CmbPrecio.Size = new System.Drawing.Size(385, 49);
            this.CmbPrecio.StartIndex = 0;
            this.CmbPrecio.TabIndex = 2;
            this.CmbPrecio.SelectionChangeCommitted += new System.EventHandler(this.CmbPrecio_SelectionChangeCommitted);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Depth = 0;
            this.lblMensaje.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMensaje.Location = new System.Drawing.Point(56, 287);
            this.lblMensaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(282, 19);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Ingrese el código de la tarjeta del cliente";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Depth = 0;
            this.lblCliente.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCliente.Location = new System.Drawing.Point(69, 343);
            this.lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 19);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Codigo";
            // 
            // txtCodigoTarjeta
            // 
            this.txtCodigoTarjeta.AnimateReadOnly = false;
            this.txtCodigoTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodigoTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigoTarjeta.Depth = 0;
            this.txtCodigoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoTarjeta.HideSelection = true;
            this.txtCodigoTarjeta.LeadingIcon = null;
            this.txtCodigoTarjeta.Location = new System.Drawing.Point(50, 391);
            this.txtCodigoTarjeta.MaxLength = 32767;
            this.txtCodigoTarjeta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoTarjeta.Name = "txtCodigoTarjeta";
            this.txtCodigoTarjeta.PasswordChar = '\0';
            this.txtCodigoTarjeta.PrefixSuffixText = null;
            this.txtCodigoTarjeta.ReadOnly = false;
            this.txtCodigoTarjeta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigoTarjeta.SelectedText = "";
            this.txtCodigoTarjeta.SelectionLength = 0;
            this.txtCodigoTarjeta.SelectionStart = 0;
            this.txtCodigoTarjeta.ShortcutsEnabled = true;
            this.txtCodigoTarjeta.Size = new System.Drawing.Size(327, 48);
            this.txtCodigoTarjeta.TabIndex = 5;
            this.txtCodigoTarjeta.TabStop = false;
            this.txtCodigoTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoTarjeta.TrailingIcon = null;
            this.txtCodigoTarjeta.UseSystemPasswordChar = false;
            this.txtCodigoTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoTarjeta_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.Location = new System.Drawing.Point(69, 460);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 19);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.AnimateReadOnly = false;
            this.txtNombreCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreCliente.Depth = 0;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCliente.HideSelection = true;
            this.txtNombreCliente.LeadingIcon = null;
            this.txtNombreCliente.Location = new System.Drawing.Point(50, 492);
            this.txtNombreCliente.MaxLength = 32767;
            this.txtNombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.PasswordChar = '\0';
            this.txtNombreCliente.PrefixSuffixText = null;
            this.txtNombreCliente.ReadOnly = false;
            this.txtNombreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreCliente.SelectedText = "";
            this.txtNombreCliente.SelectionLength = 0;
            this.txtNombreCliente.SelectionStart = 0;
            this.txtNombreCliente.ShortcutsEnabled = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(458, 48);
            this.txtNombreCliente.TabIndex = 7;
            this.txtNombreCliente.TabStop = false;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCliente.TrailingIcon = null;
            this.txtNombreCliente.UseSystemPasswordChar = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(425, 374);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(96, 90);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.Image")));
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Aceptar.Location = new System.Drawing.Point(314, 560);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(110, 94);
            this.btn_Aceptar.TabIndex = 67;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // brn_Cancelar
            // 
            this.brn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.brn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.brn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.brn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("brn_Cancelar.Image")));
            this.brn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brn_Cancelar.Location = new System.Drawing.Point(115, 560);
            this.brn_Cancelar.Name = "brn_Cancelar";
            this.brn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.brn_Cancelar.Size = new System.Drawing.Size(118, 94);
            this.brn_Cancelar.TabIndex = 66;
            this.brn_Cancelar.Text = "Cancelar";
            this.brn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_Cancelar.UseVisualStyleBackColor = true;
            this.brn_Cancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmPrecioV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 672);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.brn_Cancelar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigoTarjeta);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.CmbPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmPrecioV2";
            this.Text = "frmPreciosV2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblPrecio;
        private MaterialSkin.Controls.MaterialComboBox CmbPrecio;
        private MaterialSkin.Controls.MaterialLabel lblMensaje;
        private MaterialSkin.Controls.MaterialLabel lblCliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigoTarjeta;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreCliente;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button brn_Cancelar;
    }
}