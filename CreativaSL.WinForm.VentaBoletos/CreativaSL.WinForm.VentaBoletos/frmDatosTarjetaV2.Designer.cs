namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmDatosTarjetaV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosTarjetaV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.cmbBancos = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbDocumento = new MaterialSkin.Controls.MaterialComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.txtNumAutorizacion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDNI = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumTarjeta = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Location = new System.Drawing.Point(6, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 537);
            this.panel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txt_mensaje);
            this.materialCard1.Controls.Add(this.cmbBancos);
            this.materialCard1.Controls.Add(this.cmbDocumento);
            this.materialCard1.Controls.Add(this.label8);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.btnAceptar);
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.txtNumAutorizacion);
            this.materialCard1.Controls.Add(this.txtDNI);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Controls.Add(this.label7);
            this.materialCard1.Controls.Add(this.txtMonto);
            this.materialCard1.Controls.Add(this.txtNumTarjeta);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(52, 25);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(877, 483);
            this.materialCard1.TabIndex = 135;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txt_mensaje.Location = new System.Drawing.Point(23, 350);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_mensaje.Size = new System.Drawing.Size(790, 53);
            this.txt_mensaje.TabIndex = 140;
            this.txt_mensaje.TabStop = false;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.Visible = false;
            // 
            // cmbBancos
            // 
            this.cmbBancos.AutoResize = false;
            this.cmbBancos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBancos.Depth = 0;
            this.cmbBancos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBancos.DropDownHeight = 174;
            this.cmbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBancos.DropDownWidth = 121;
            this.cmbBancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBancos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.IntegralHeight = false;
            this.cmbBancos.ItemHeight = 43;
            this.cmbBancos.Location = new System.Drawing.Point(23, 295);
            this.cmbBancos.MaxDropDownItems = 4;
            this.cmbBancos.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(360, 49);
            this.cmbBancos.StartIndex = 0;
            this.cmbBancos.TabIndex = 139;
            this.cmbBancos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBancos_KeyPress);
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.AutoResize = false;
            this.cmbDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDocumento.Depth = 0;
            this.cmbDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDocumento.DropDownHeight = 174;
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.DropDownWidth = 121;
            this.cmbDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.IntegralHeight = false;
            this.cmbDocumento.ItemHeight = 43;
            this.cmbDocumento.Location = new System.Drawing.Point(453, 90);
            this.cmbDocumento.MaxDropDownItems = 4;
            this.cmbDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(360, 49);
            this.cmbDocumento.StartIndex = 0;
            this.cmbDocumento.TabIndex = 138;
            this.cmbDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDocumento_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(18, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 137;
            this.label8.Text = "Banco";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(18, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 135;
            this.label2.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(18, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 26);
            this.label4.TabIndex = 120;
            this.label4.Text = "Datos de la tarjeta de crédito/ débito";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 136;
            this.label1.Text = "Número";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = false;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Icon")));
            this.btnAceptar.Location = new System.Drawing.Point(213, 404);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(172, 59);
            this.btnAceptar.TabIndex = 133;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Icon")));
            this.btnCancelar.Location = new System.Drawing.Point(436, 404);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(162, 59);
            this.btnCancelar.TabIndex = 134;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNumAutorizacion
            // 
            this.txtNumAutorizacion.AnimateReadOnly = false;
            this.txtNumAutorizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumAutorizacion.Depth = 0;
            this.txtNumAutorizacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumAutorizacion.LeadingIcon = null;
            this.txtNumAutorizacion.Location = new System.Drawing.Point(23, 89);
            this.txtNumAutorizacion.MaxLength = 50;
            this.txtNumAutorizacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumAutorizacion.Multiline = false;
            this.txtNumAutorizacion.Name = "txtNumAutorizacion";
            this.txtNumAutorizacion.Size = new System.Drawing.Size(360, 50);
            this.txtNumAutorizacion.TabIndex = 121;
            this.txtNumAutorizacion.Text = "";
            this.txtNumAutorizacion.TrailingIcon = null;
            this.txtNumAutorizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAutorizacion_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.AnimateReadOnly = false;
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Depth = 0;
            this.txtDNI.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDNI.LeadingIcon = null;
            this.txtDNI.Location = new System.Drawing.Point(23, 186);
            this.txtDNI.MaxLength = 50;
            this.txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(360, 50);
            this.txtDNI.TabIndex = 122;
            this.txtDNI.Text = "";
            this.txtDNI.TrailingIcon = null;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIFE_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(448, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 132;
            this.label5.Text = "Monto";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(448, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 131;
            this.label6.Text = "Número Tarjeta";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(448, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 130;
            this.label7.Text = "Identificación";
            // 
            // txtMonto
            // 
            this.txtMonto.AnimateReadOnly = false;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Depth = 0;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtMonto.LeadingIcon = null;
            this.txtMonto.Location = new System.Drawing.Point(453, 294);
            this.txtMonto.MaxLength = 50;
            this.txtMonto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMonto.Multiline = false;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(360, 50);
            this.txtMonto.TabIndex = 129;
            this.txtMonto.Text = "0.00";
            this.txtMonto.TrailingIcon = null;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.txtMonto.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonto_Validating);
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.AnimateReadOnly = false;
            this.txtNumTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumTarjeta.Depth = 0;
            this.txtNumTarjeta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumTarjeta.LeadingIcon = null;
            this.txtNumTarjeta.Location = new System.Drawing.Point(453, 186);
            this.txtNumTarjeta.MaxLength = 50;
            this.txtNumTarjeta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumTarjeta.Multiline = false;
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(360, 50);
            this.txtNumTarjeta.TabIndex = 128;
            this.txtNumTarjeta.Text = "";
            this.txtNumTarjeta.TrailingIcon = null;
            this.txtNumTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTarjeta_KeyPress);
            // 
            // frmDatosTarjetaV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 625);
            this.Controls.Add(this.panel1);
            this.Name = "frmDatosTarjetaV2";
            this.Text = "Datos de la tarjeta";
            this.Load += new System.EventHandler(this.btnCancelar_Click);
            this.panel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtDNI;
        private MaterialSkin.Controls.MaterialTextBox txtNumAutorizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox txtMonto;
        private MaterialSkin.Controls.MaterialTextBox txtNumTarjeta;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialComboBox cmbBancos;
        private MaterialSkin.Controls.MaterialComboBox cmbDocumento;
        private System.Windows.Forms.TextBox txt_mensaje;
    }
}