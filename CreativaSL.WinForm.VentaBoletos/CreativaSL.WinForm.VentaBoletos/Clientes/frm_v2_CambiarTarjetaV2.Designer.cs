namespace CreativaSL.WinForm.VentaBoletos.Clientes
{
    partial class frm_v2_CambiarTarjetaV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_v2_CambiarTarjetaV2));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumTarjeta = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(62, 279);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 42;
            this.materialLabel1.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCliente.AnimateReadOnly = false;
            this.txtCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCliente.Depth = 0;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente.HideSelection = true;
            this.txtCliente.LeadingIcon = null;
            this.txtCliente.Location = new System.Drawing.Point(181, 250);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.PrefixSuffixText = null;
            this.txtCliente.ReadOnly = false;
            this.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.ShortcutsEnabled = true;
            this.txtCliente.Size = new System.Drawing.Size(250, 48);
            this.txtCliente.TabIndex = 43;
            this.txtCliente.TabStop = false;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCliente.TrailingIcon = null;
            this.txtCliente.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(62, 337);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 44;
            this.materialLabel2.Text = "Num:";
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.AllowPromptAsInput = true;
            this.txtNumTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumTarjeta.AnimateReadOnly = false;
            this.txtNumTarjeta.AsciiOnly = false;
            this.txtNumTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNumTarjeta.BeepOnError = false;
            this.txtNumTarjeta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNumTarjeta.Depth = 0;
            this.txtNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumTarjeta.HidePromptOnLeave = false;
            this.txtNumTarjeta.HideSelection = true;
            this.txtNumTarjeta.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNumTarjeta.LeadingIcon = null;
            this.txtNumTarjeta.Location = new System.Drawing.Point(181, 318);
            this.txtNumTarjeta.Mask = "";
            this.txtNumTarjeta.MaxLength = 32767;
            this.txtNumTarjeta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.PasswordChar = '\0';
            this.txtNumTarjeta.PrefixSuffixText = null;
            this.txtNumTarjeta.PromptChar = '_';
            this.txtNumTarjeta.ReadOnly = false;
            this.txtNumTarjeta.RejectInputOnFirstFailure = false;
            this.txtNumTarjeta.ResetOnPrompt = true;
            this.txtNumTarjeta.ResetOnSpace = true;
            this.txtNumTarjeta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumTarjeta.SelectedText = "";
            this.txtNumTarjeta.SelectionLength = 0;
            this.txtNumTarjeta.SelectionStart = 0;
            this.txtNumTarjeta.ShortcutsEnabled = true;
            this.txtNumTarjeta.Size = new System.Drawing.Size(250, 48);
            this.txtNumTarjeta.SkipLiterals = true;
            this.txtNumTarjeta.TabIndex = 45;
            this.txtNumTarjeta.TabStop = false;
            this.txtNumTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumTarjeta.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNumTarjeta.TrailingIcon = null;
            this.txtNumTarjeta.UseSystemPasswordChar = false;
            this.txtNumTarjeta.ValidatingType = null;
            this.txtNumTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTarjeta_KeyPress);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_Guardar);
            this.materialCard1.Controls.Add(this.btn_Cancelar);
            this.materialCard1.Controls.Add(this.txt_mensaje);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 383);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(839, 154);
            this.materialCard1.TabIndex = 12139;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(69, 67);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(269, 39);
            this.txt_mensaje.TabIndex = 12139;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mensaje.Visible = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(337, 75);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(113, 19);
            this.materialLabel3.TabIndex = 12140;
            this.materialLabel3.Text = "Asignar Tarjeta ";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.Location = new System.Drawing.Point(642, 30);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(110, 94);
            this.btn_Guardar.TabIndex = 12141;
            this.btn_Guardar.Text = "Aceptar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(503, 30);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 94);
            this.btn_Cancelar.TabIndex = 12140;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(600, 250);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 90);
            this.btnBuscar.TabIndex = 12136;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.CardSilver;
            this.pictureBox1.Location = new System.Drawing.Point(313, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // frm_v2_CambiarTarjetaV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 554);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumTarjeta);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_v2_CambiarTarjetaV2";
            this.Text = "frm_v2_CambiarTarjetaV2";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAsignarTarjetaV2_KeyPress);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNumTarjeta;
        private System.Windows.Forms.Button btnBuscar;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_mensaje;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}