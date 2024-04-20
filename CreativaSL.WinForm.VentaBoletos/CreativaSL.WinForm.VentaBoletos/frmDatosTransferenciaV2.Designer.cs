namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmDatosTransferenciaV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosTransferenciaV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.cmbBancos = new MaterialSkin.Controls.MaterialComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumCheque = new MaterialSkin.Controls.MaterialTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Location = new System.Drawing.Point(6, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 535);
            this.panel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnAceptar);
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.txt_mensaje);
            this.materialCard1.Controls.Add(this.txtMonto);
            this.materialCard1.Controls.Add(this.cmbBancos);
            this.materialCard1.Controls.Add(this.label8);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.txtNumCheque);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(937, 507);
            this.materialCard1.TabIndex = 0;
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
            this.cmbBancos.Location = new System.Drawing.Point(280, 193);
            this.cmbBancos.MaxDropDownItems = 4;
            this.cmbBancos.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(360, 49);
            this.cmbBancos.StartIndex = 0;
            this.cmbBancos.TabIndex = 145;
            this.cmbBancos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBancos_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(408, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 144;
            this.label8.Text = "Banco";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(408, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 142;
            this.label2.Text = "Monto";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(408, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 143;
            this.label1.Text = "Número";
            // 
            // txtNumCheque
            // 
            this.txtNumCheque.AnimateReadOnly = false;
            this.txtNumCheque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumCheque.Depth = 0;
            this.txtNumCheque.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumCheque.LeadingIcon = null;
            this.txtNumCheque.Location = new System.Drawing.Point(279, 94);
            this.txtNumCheque.MaxLength = 50;
            this.txtNumCheque.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumCheque.Multiline = false;
            this.txtNumCheque.Name = "txtNumCheque";
            this.txtNumCheque.Size = new System.Drawing.Size(360, 50);
            this.txtNumCheque.TabIndex = 140;
            this.txtNumCheque.Text = "";
            this.txtNumCheque.TrailingIcon = null;
            this.txtNumCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAutorizacion_KeyPress);
            this.txtNumCheque.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumCheque_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(329, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 26);
            this.label4.TabIndex = 121;
            this.label4.Text = "Datos de la transferencia";
            // 
            // txtMonto
            // 
            this.txtMonto.AnimateReadOnly = false;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Depth = 0;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtMonto.LeadingIcon = null;
            this.txtMonto.Location = new System.Drawing.Point(282, 290);
            this.txtMonto.MaxLength = 50;
            this.txtMonto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMonto.Multiline = false;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(357, 50);
            this.txtMonto.TabIndex = 146;
            this.txtMonto.Text = "0.00";
            this.txtMonto.TrailingIcon = null;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.txtMonto.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonto_Validating);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(17, 290);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(258, 200);
            this.txt_mensaje.TabIndex = 147;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.Visible = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(282, 411);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(160, 59);
            this.btnAceptar.TabIndex = 148;
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
            this.btnCancelar.Location = new System.Drawing.Point(477, 411);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(157, 59);
            this.btnCancelar.TabIndex = 149;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmDatosTransferenciaV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 621);
            this.Controls.Add(this.panel1);
            this.Name = "frmDatosTransferenciaV2";
            this.Text = "Datos tranferencia";
            this.Load += new System.EventHandler(this.frmDatosCheque_Load);
            this.panel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialComboBox cmbBancos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtNumCheque;
        private MaterialSkin.Controls.MaterialTextBox txtMonto;
        private System.Windows.Forms.TextBox txt_mensaje;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}