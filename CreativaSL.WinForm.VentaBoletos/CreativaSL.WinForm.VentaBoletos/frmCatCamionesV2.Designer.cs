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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatCamionesV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.txtCaracteristicas = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.cmbDisenio = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtnumCamion = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbSubmarcas = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbMarcas = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbTipoCamion = new MaterialSkin.Controls.MaterialComboBox();
            this.btnVerDiseñoCamion = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnVerDiseñoCamion);
            this.panel1.Controls.Add(this.txt_mensaje);
            this.panel1.Controls.Add(this.txtCaracteristicas);
            this.panel1.Controls.Add(this.cmbDisenio);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtnumCamion);
            this.panel1.Controls.Add(this.cmbSubmarcas);
            this.panel1.Controls.Add(this.cmbMarcas);
            this.panel1.Controls.Add(this.cmbTipoCamion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 606);
            this.panel1.TabIndex = 0;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(179, 520);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(615, 32);
            this.txt_mensaje.TabIndex = 18;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mensaje.Visible = false;
            // 
            // txtCaracteristicas
            // 
            this.txtCaracteristicas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCaracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaracteristicas.Depth = 0;
            this.txtCaracteristicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCaracteristicas.Location = new System.Drawing.Point(570, 275);
            this.txtCaracteristicas.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCaracteristicas.Name = "txtCaracteristicas";
            this.txtCaracteristicas.Size = new System.Drawing.Size(397, 117);
            this.txtCaracteristicas.TabIndex = 16;
            this.txtCaracteristicas.Text = "";
            this.txtCaracteristicas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracteristicas_KeyPress);
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
            this.cmbDisenio.Location = new System.Drawing.Point(233, 426);
            this.cmbDisenio.MaxDropDownItems = 4;
            this.cmbDisenio.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDisenio.Name = "cmbDisenio";
            this.cmbDisenio.Size = new System.Drawing.Size(185, 49);
            this.cmbDisenio.StartIndex = 0;
            this.cmbDisenio.TabIndex = 13;
            this.cmbDisenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDisenio_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescripcion.Location = new System.Drawing.Point(570, 105);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(397, 116);
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
            this.txtnumCamion.Location = new System.Drawing.Point(233, 342);
            this.txtnumCamion.MaxLength = 50;
            this.txtnumCamion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnumCamion.Multiline = false;
            this.txtnumCamion.Name = "txtnumCamion";
            this.txtnumCamion.Size = new System.Drawing.Size(282, 50);
            this.txtnumCamion.TabIndex = 9;
            this.txtnumCamion.Text = "";
            this.txtnumCamion.TrailingIcon = null;
            this.txtnumCamion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumCamion_KeyPress);
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
            this.cmbSubmarcas.Location = new System.Drawing.Point(233, 264);
            this.cmbSubmarcas.MaxDropDownItems = 4;
            this.cmbSubmarcas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSubmarcas.Name = "cmbSubmarcas";
            this.cmbSubmarcas.Size = new System.Drawing.Size(282, 49);
            this.cmbSubmarcas.StartIndex = 0;
            this.cmbSubmarcas.TabIndex = 7;
            this.cmbSubmarcas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMarcas_KeyPress);
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
            this.cmbMarcas.Location = new System.Drawing.Point(233, 184);
            this.cmbMarcas.MaxDropDownItems = 4;
            this.cmbMarcas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(282, 49);
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
            this.cmbTipoCamion.Location = new System.Drawing.Point(233, 105);
            this.cmbTipoCamion.MaxDropDownItems = 4;
            this.cmbTipoCamion.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoCamion.Name = "cmbTipoCamion";
            this.cmbTipoCamion.Size = new System.Drawing.Size(282, 49);
            this.cmbTipoCamion.StartIndex = 0;
            this.cmbTipoCamion.TabIndex = 4;
            this.cmbTipoCamion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoCamion_KeyPress);
            // 
            // btnVerDiseñoCamion
            // 
            this.btnVerDiseñoCamion.BackColor = System.Drawing.Color.Transparent;
            this.btnVerDiseñoCamion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerDiseñoCamion.BackgroundImage")));
            this.btnVerDiseñoCamion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerDiseñoCamion.Location = new System.Drawing.Point(444, 426);
            this.btnVerDiseñoCamion.Name = "btnVerDiseñoCamion";
            this.btnVerDiseñoCamion.Size = new System.Drawing.Size(71, 61);
            this.btnVerDiseñoCamion.TabIndex = 20;
            this.btnVerDiseñoCamion.UseVisualStyleBackColor = false;
            this.btnVerDiseñoCamion.Click += new System.EventHandler(this.btnVerDiseñoCamion_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(569, 413);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGuardar.Size = new System.Drawing.Size(154, 74);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(759, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCancelar.Size = new System.Drawing.Size(148, 76);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(46, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 29);
            this.label9.TabIndex = 61;
            this.label9.Text = "Camiones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(46, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Tipo Camión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(46, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(46, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Submarca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(46, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Núm de Camión";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(46, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 66;
            this.label5.Text = "Diseño Camión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(567, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(565, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 68;
            this.label6.Text = "Caracteristicas";
            // 
            // frmCatCamionesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 673);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatCamionesV2";
            this.Text = "frmCatCamionesV2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialComboBox cmbSubmarcas;
        private MaterialSkin.Controls.MaterialComboBox cmbMarcas;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoCamion;
        private MaterialSkin.Controls.MaterialTextBox txtnumCamion;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtDescripcion;
        private MaterialSkin.Controls.MaterialComboBox cmbDisenio;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtCaracteristicas;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.Button btnVerDiseñoCamion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}