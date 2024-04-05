namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatCamionesV2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.txtCaracteristicas = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVerDiseñoCamion = new MaterialSkin.Controls.MaterialButton();
            this.cmbDisenio = new MaterialSkin.Controls.MaterialComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtnumCamion = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSubmarcas = new MaterialSkin.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMarcas = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbTipoCamion = new MaterialSkin.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_mensaje);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtCaracteristicas);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnVerDiseñoCamion);
            this.panel1.Controls.Add(this.cmbDisenio);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtnumCamion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbSubmarcas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbMarcas);
            this.panel1.Controls.Add(this.cmbTipoCamion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 693);
            this.panel1.TabIndex = 0;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(98, 577);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(615, 32);
            this.txt_mensaje.TabIndex = 18;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mensaje.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(342, 614);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCaracteristicas
            // 
            this.txtCaracteristicas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCaracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaracteristicas.Depth = 0;
            this.txtCaracteristicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCaracteristicas.Location = new System.Drawing.Point(98, 509);
            this.txtCaracteristicas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCaracteristicas.Name = "txtCaracteristicas";
            this.txtCaracteristicas.Size = new System.Drawing.Size(615, 62);
            this.txtCaracteristicas.TabIndex = 16;
            this.txtCaracteristicas.Text = "";
            this.txtCaracteristicas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracteristicas_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(96, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Caracteristicas";
            // 
            // btnVerDiseñoCamion
            // 
            this.btnVerDiseñoCamion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerDiseñoCamion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerDiseñoCamion.Depth = 0;
            this.btnVerDiseñoCamion.HighEmphasis = true;
            this.btnVerDiseñoCamion.Icon = null;
            this.btnVerDiseñoCamion.Location = new System.Drawing.Point(456, 315);
            this.btnVerDiseñoCamion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerDiseñoCamion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerDiseñoCamion.Name = "btnVerDiseñoCamion";
            this.btnVerDiseñoCamion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerDiseñoCamion.Size = new System.Drawing.Size(113, 36);
            this.btnVerDiseñoCamion.TabIndex = 14;
            this.btnVerDiseñoCamion.Text = "Ver diseños";
            this.btnVerDiseñoCamion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerDiseñoCamion.UseAccentColor = false;
            this.btnVerDiseñoCamion.UseVisualStyleBackColor = true;
            this.btnVerDiseñoCamion.Click += new System.EventHandler(this.btnVerDiseñoCamion_Click);
            // 
            // cmbDisenio
            // 
            this.cmbDisenio.AutoResize = false;
            this.cmbDisenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDisenio.Depth = 0;
            this.cmbDisenio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDisenio.DropDownHeight = 174;
            this.cmbDisenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisenio.DropDownWidth = 121;
            this.cmbDisenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDisenio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDisenio.FormattingEnabled = true;
            this.cmbDisenio.IntegralHeight = false;
            this.cmbDisenio.ItemHeight = 43;
            this.cmbDisenio.Location = new System.Drawing.Point(98, 302);
            this.cmbDisenio.MaxDropDownItems = 4;
            this.cmbDisenio.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDisenio.Name = "cmbDisenio";
            this.cmbDisenio.Size = new System.Drawing.Size(247, 49);
            this.cmbDisenio.StartIndex = 0;
            this.cmbDisenio.TabIndex = 13;
            this.cmbDisenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDisenio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(93, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Diseño Camión";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(93, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescripcion.Location = new System.Drawing.Point(98, 399);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(615, 62);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.Text = "";
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtnumCamion
            // 
            this.txtnumCamion.AnimateReadOnly = false;
            this.txtnumCamion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumCamion.Depth = 0;
            this.txtnumCamion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnumCamion.LeadingIcon = null;
            this.txtnumCamion.Location = new System.Drawing.Point(456, 205);
            this.txtnumCamion.MaxLength = 50;
            this.txtnumCamion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnumCamion.Multiline = false;
            this.txtnumCamion.Name = "txtnumCamion";
            this.txtnumCamion.Size = new System.Drawing.Size(252, 50);
            this.txtnumCamion.TabIndex = 9;
            this.txtnumCamion.Text = "";
            this.txtnumCamion.TrailingIcon = null;
            this.txtnumCamion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumCamion_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(460, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero de camión";
            // 
            // cmbSubmarcas
            // 
            this.cmbSubmarcas.AutoResize = false;
            this.cmbSubmarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSubmarcas.Depth = 0;
            this.cmbSubmarcas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSubmarcas.DropDownHeight = 174;
            this.cmbSubmarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubmarcas.DropDownWidth = 121;
            this.cmbSubmarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSubmarcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSubmarcas.FormattingEnabled = true;
            this.cmbSubmarcas.IntegralHeight = false;
            this.cmbSubmarcas.ItemHeight = 43;
            this.cmbSubmarcas.Location = new System.Drawing.Point(93, 206);
            this.cmbSubmarcas.MaxDropDownItems = 4;
            this.cmbSubmarcas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSubmarcas.Name = "cmbSubmarcas";
            this.cmbSubmarcas.Size = new System.Drawing.Size(247, 49);
            this.cmbSubmarcas.StartIndex = 0;
            this.cmbSubmarcas.TabIndex = 7;
            this.cmbSubmarcas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMarcas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(88, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Submarca";
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.AutoResize = false;
            this.cmbMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMarcas.Depth = 0;
            this.cmbMarcas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMarcas.DropDownHeight = 174;
            this.cmbMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcas.DropDownWidth = 121;
            this.cmbMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbMarcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.IntegralHeight = false;
            this.cmbMarcas.ItemHeight = 43;
            this.cmbMarcas.Location = new System.Drawing.Point(465, 112);
            this.cmbMarcas.MaxDropDownItems = 4;
            this.cmbMarcas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(243, 49);
            this.cmbMarcas.StartIndex = 0;
            this.cmbMarcas.TabIndex = 5;
            this.cmbMarcas.SelectedIndexChanged += new System.EventHandler(this.cmbMarcas_SelectedIndexChanged);
            // 
            // cmbTipoCamion
            // 
            this.cmbTipoCamion.AutoResize = false;
            this.cmbTipoCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTipoCamion.Depth = 0;
            this.cmbTipoCamion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipoCamion.DropDownHeight = 174;
            this.cmbTipoCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCamion.DropDownWidth = 121;
            this.cmbTipoCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipoCamion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTipoCamion.FormattingEnabled = true;
            this.cmbTipoCamion.IntegralHeight = false;
            this.cmbTipoCamion.ItemHeight = 43;
            this.cmbTipoCamion.Location = new System.Drawing.Point(93, 112);
            this.cmbTipoCamion.MaxDropDownItems = 4;
            this.cmbTipoCamion.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoCamion.Name = "cmbTipoCamion";
            this.cmbTipoCamion.Size = new System.Drawing.Size(247, 49);
            this.cmbTipoCamion.StartIndex = 0;
            this.cmbTipoCamion.TabIndex = 4;
            this.cmbTipoCamion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoCamion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(460, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(88, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo camión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(311, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "camiones";
            // 
            // frmCatCamionesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 760);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatCamionesV2";
            this.Text = "frmCatCamionesV2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialComboBox cmbSubmarcas;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialComboBox cmbMarcas;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoCamion;
        private MaterialSkin.Controls.MaterialTextBox txtnumCamion;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialComboBox cmbDisenio;
        private MaterialSkin.Controls.MaterialButton btnVerDiseñoCamion;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtCaracteristicas;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private System.Windows.Forms.TextBox txt_mensaje;
    }
}