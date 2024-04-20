namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmPagoExtraV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagoExtraV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.brn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.Txt_PagoExtraGenerico = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.brn_Cancelar);
            this.panel1.Controls.Add(this.btn_Aceptar);
            this.panel1.Controls.Add(this.Txt_PagoExtraGenerico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 358);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(268, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 26);
            this.label4.TabIndex = 119;
            this.label4.Text = "Pago Extra Generico";
            // 
            // brn_Cancelar
            // 
            this.brn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.brn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("brn_Cancelar.Image")));
            this.brn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brn_Cancelar.Location = new System.Drawing.Point(226, 214);
            this.brn_Cancelar.Name = "brn_Cancelar";
            this.brn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.brn_Cancelar.Size = new System.Drawing.Size(132, 109);
            this.brn_Cancelar.TabIndex = 64;
            this.brn_Cancelar.Text = "Cancelar";
            this.brn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_Cancelar.UseVisualStyleBackColor = true;
            this.brn_Cancelar.Click += new System.EventHandler(this.brn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.Image")));
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Aceptar.Location = new System.Drawing.Point(406, 214);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Aceptar.Size = new System.Drawing.Size(129, 109);
            this.btn_Aceptar.TabIndex = 63;
            this.btn_Aceptar.Text = "Guardar";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // Txt_PagoExtraGenerico
            // 
            this.Txt_PagoExtraGenerico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_PagoExtraGenerico.AnimateReadOnly = false;
            this.Txt_PagoExtraGenerico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_PagoExtraGenerico.Depth = 0;
            this.Txt_PagoExtraGenerico.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_PagoExtraGenerico.LeadingIcon = null;
            this.Txt_PagoExtraGenerico.Location = new System.Drawing.Point(191, 113);
            this.Txt_PagoExtraGenerico.MaxLength = 50;
            this.Txt_PagoExtraGenerico.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_PagoExtraGenerico.Multiline = false;
            this.Txt_PagoExtraGenerico.Name = "Txt_PagoExtraGenerico";
            this.Txt_PagoExtraGenerico.Size = new System.Drawing.Size(390, 50);
            this.Txt_PagoExtraGenerico.TabIndex = 6;
            this.Txt_PagoExtraGenerico.Text = "";
            this.Txt_PagoExtraGenerico.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(288, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pago extra";
            // 
            // frmPagoExtraV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.panel1);
            this.Name = "frmPagoExtraV2";
            this.Text = "Pago Extragenerico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button brn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private MaterialSkin.Controls.MaterialTextBox Txt_PagoExtraGenerico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}