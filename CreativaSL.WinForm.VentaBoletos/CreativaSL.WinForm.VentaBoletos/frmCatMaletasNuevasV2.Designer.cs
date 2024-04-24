namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatMaletasNuevasV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatMaletasNuevasV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_PrecioMaleta = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_NumeroMaletas = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_Descripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.Txt_Folio = new MaterialSkin.Controls.MaterialTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_PrecioMaleta);
            this.panel1.Controls.Add(this.Txt_NumeroMaletas);
            this.panel1.Controls.Add(this.Txt_Descripcion);
            this.panel1.Controls.Add(this.Txt_Folio);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(6, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 435);
            this.panel1.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.Location = new System.Drawing.Point(747, 119);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Guardar.Size = new System.Drawing.Size(127, 105);
            this.btn_Guardar.TabIndex = 62;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(908, 120);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Cancelar.Size = new System.Drawing.Size(127, 104);
            this.btn_Cancelar.TabIndex = 63;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(742, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Acciones";
            // 
            // Txt_PrecioMaleta
            // 
            this.Txt_PrecioMaleta.AnimateReadOnly = false;
            this.Txt_PrecioMaleta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_PrecioMaleta.Depth = 0;
            this.Txt_PrecioMaleta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_PrecioMaleta.LeadingIcon = null;
            this.Txt_PrecioMaleta.Location = new System.Drawing.Point(493, 227);
            this.Txt_PrecioMaleta.MaxLength = 50;
            this.Txt_PrecioMaleta.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_PrecioMaleta.Multiline = false;
            this.Txt_PrecioMaleta.Name = "Txt_PrecioMaleta";
            this.Txt_PrecioMaleta.Size = new System.Drawing.Size(202, 50);
            this.Txt_PrecioMaleta.TabIndex = 9;
            this.Txt_PrecioMaleta.Text = "";
            this.Txt_PrecioMaleta.TrailingIcon = null;
            this.Txt_PrecioMaleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PrecioMaleta_KeyPress);
            // 
            // Txt_NumeroMaletas
            // 
            this.Txt_NumeroMaletas.AnimateReadOnly = false;
            this.Txt_NumeroMaletas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NumeroMaletas.Depth = 0;
            this.Txt_NumeroMaletas.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_NumeroMaletas.LeadingIcon = null;
            this.Txt_NumeroMaletas.Location = new System.Drawing.Point(493, 119);
            this.Txt_NumeroMaletas.MaxLength = 50;
            this.Txt_NumeroMaletas.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_NumeroMaletas.Multiline = false;
            this.Txt_NumeroMaletas.Name = "Txt_NumeroMaletas";
            this.Txt_NumeroMaletas.Size = new System.Drawing.Size(202, 50);
            this.Txt_NumeroMaletas.TabIndex = 8;
            this.Txt_NumeroMaletas.Text = "";
            this.Txt_NumeroMaletas.TrailingIcon = null;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descripcion.Depth = 0;
            this.Txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Txt_Descripcion.Location = new System.Drawing.Point(46, 227);
            this.Txt_Descripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(358, 145);
            this.Txt_Descripcion.TabIndex = 7;
            this.Txt_Descripcion.Text = "";
            this.Txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Descripcion_KeyPress);
            // 
            // Txt_Folio
            // 
            this.Txt_Folio.AnimateReadOnly = false;
            this.Txt_Folio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Folio.Depth = 0;
            this.Txt_Folio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Folio.LeadingIcon = null;
            this.Txt_Folio.Location = new System.Drawing.Point(46, 119);
            this.Txt_Folio.MaxLength = 50;
            this.Txt_Folio.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_Folio.Multiline = false;
            this.Txt_Folio.Name = "Txt_Folio";
            this.Txt_Folio.Size = new System.Drawing.Size(358, 50);
            this.Txt_Folio.TabIndex = 6;
            this.Txt_Folio.Text = "";
            this.Txt_Folio.TrailingIcon = null;
            this.Txt_Folio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Folio_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(488, 193);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Precio";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(488, 85);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 25);
            this.label17.TabIndex = 4;
            this.label17.Text = "Num. Maletas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(41, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Descripción";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(41, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Folio Maleta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(41, 21);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 26);
            this.label15.TabIndex = 1;
            this.label15.Text = "Datos Maletas";
            // 
            // frmCatMaletasNuevasV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 524);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatMaletasNuevasV2";
            this.Text = "Maleta Nueva";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialMultiLineTextBox Txt_Descripcion;
        private MaterialSkin.Controls.MaterialTextBox Txt_Folio;
        private MaterialSkin.Controls.MaterialTextBox Txt_PrecioMaleta;
        private MaterialSkin.Controls.MaterialTextBox Txt_NumeroMaletas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}