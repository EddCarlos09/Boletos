namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatTerminalIntermediaV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatTerminalIntermediaV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTiempo2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.cmbDestino = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbOrigen = new MaterialSkin.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTiempo2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txt_mensaje);
            this.panel1.Controls.Add(this.cmbDestino);
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 457);
            this.panel1.TabIndex = 0;
            // 
            // txtTiempo2
            // 
            this.txtTiempo2.AllowPromptAsInput = true;
            this.txtTiempo2.AnimateReadOnly = false;
            this.txtTiempo2.AsciiOnly = false;
            this.txtTiempo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTiempo2.BeepOnError = false;
            this.txtTiempo2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTiempo2.Depth = 0;
            this.txtTiempo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTiempo2.HidePromptOnLeave = false;
            this.txtTiempo2.HideSelection = true;
            this.txtTiempo2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTiempo2.LeadingIcon = null;
            this.txtTiempo2.Location = new System.Drawing.Point(603, 151);
            this.txtTiempo2.Mask = "00:00";
            this.txtTiempo2.MaxLength = 32767;
            this.txtTiempo2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTiempo2.Name = "txtTiempo2";
            this.txtTiempo2.PasswordChar = '\0';
            this.txtTiempo2.PrefixSuffixText = null;
            this.txtTiempo2.PromptChar = '_';
            this.txtTiempo2.ReadOnly = false;
            this.txtTiempo2.RejectInputOnFirstFailure = false;
            this.txtTiempo2.ResetOnPrompt = true;
            this.txtTiempo2.ResetOnSpace = true;
            this.txtTiempo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTiempo2.SelectedText = "";
            this.txtTiempo2.SelectionLength = 0;
            this.txtTiempo2.SelectionStart = 0;
            this.txtTiempo2.ShortcutsEnabled = true;
            this.txtTiempo2.Size = new System.Drawing.Size(134, 48);
            this.txtTiempo2.SkipLiterals = true;
            this.txtTiempo2.TabIndex = 62;
            this.txtTiempo2.TabStop = false;
            this.txtTiempo2.Text = "__:__";
            this.txtTiempo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTiempo2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtTiempo2.TrailingIcon = null;
            this.txtTiempo2.UseSystemPasswordChar = false;
            this.txtTiempo2.ValidatingType = null;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(399, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btnCancelar.Size = new System.Drawing.Size(163, 98);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(191, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btnGuardar.Size = new System.Drawing.Size(163, 98);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(174, 223);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(412, 32);
            this.txt_mensaje.TabIndex = 8;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mensaje.Visible = false;
            // 
            // cmbDestino
            // 
            this.cmbDestino.AutoResize = false;
            this.cmbDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDestino.Depth = 0;
            this.cmbDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDestino.DropDownHeight = 174;
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.DropDownWidth = 121;
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.IntegralHeight = false;
            this.cmbDestino.ItemHeight = 43;
            this.cmbDestino.Location = new System.Drawing.Point(327, 151);
            this.cmbDestino.MaxDropDownItems = 4;
            this.cmbDestino.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(239, 49);
            this.cmbDestino.StartIndex = 0;
            this.cmbDestino.TabIndex = 6;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.AutoResize = false;
            this.cmbOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbOrigen.Depth = 0;
            this.cmbOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbOrigen.DropDownHeight = 174;
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.DropDownWidth = 121;
            this.cmbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.IntegralHeight = false;
            this.cmbOrigen.ItemHeight = 43;
            this.cmbOrigen.Location = new System.Drawing.Point(50, 153);
            this.cmbOrigen.MaxDropDownItems = 4;
            this.cmbOrigen.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(243, 49);
            this.cmbOrigen.StartIndex = 0;
            this.cmbOrigen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(598, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiempo Viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(322, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Terminal Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(45, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Terminal Origen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(45, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ruta Intermedia";
            // 
            // frmCatTerminalIntermediaV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatTerminalIntermediaV2";
            this.Text = "frm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialComboBox cmbDestino;
        private MaterialSkin.Controls.MaterialComboBox cmbOrigen;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTiempo2;
    }
}