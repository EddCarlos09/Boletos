namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmDescuentoGenericoV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescuentoGenericoV2));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Txt_DescuentoGenerico = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.brn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_Aceptar);
            this.materialCard1.Controls.Add(this.brn_Cancelar);
            this.materialCard1.Controls.Add(this.Txt_DescuentoGenerico);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(556, 381);
            this.materialCard1.TabIndex = 0;
            // 
            // Txt_DescuentoGenerico
            // 
            this.Txt_DescuentoGenerico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Txt_DescuentoGenerico.AnimateReadOnly = false;
            this.Txt_DescuentoGenerico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_DescuentoGenerico.Depth = 0;
            this.Txt_DescuentoGenerico.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_DescuentoGenerico.LeadingIcon = null;
            this.Txt_DescuentoGenerico.Location = new System.Drawing.Point(89, 174);
            this.Txt_DescuentoGenerico.MaxLength = 50;
            this.Txt_DescuentoGenerico.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_DescuentoGenerico.Multiline = false;
            this.Txt_DescuentoGenerico.Name = "Txt_DescuentoGenerico";
            this.Txt_DescuentoGenerico.Size = new System.Drawing.Size(393, 50);
            this.Txt_DescuentoGenerico.TabIndex = 7;
            this.Txt_DescuentoGenerico.Text = "";
            this.Txt_DescuentoGenerico.TrailingIcon = null;
            this.Txt_DescuentoGenerico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_DescuentoGenerico_KeyDown);
            this.Txt_DescuentoGenerico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DescuentoGenerico_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(201, 42);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(142, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Descuento Generico";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(218, 119);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Descuento:";
            // 
            // brn_Cancelar
            // 
            this.brn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.brn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.brn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.brn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("brn_Cancelar.Image")));
            this.brn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brn_Cancelar.Location = new System.Drawing.Point(118, 258);
            this.brn_Cancelar.Name = "brn_Cancelar";
            this.brn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.brn_Cancelar.Size = new System.Drawing.Size(110, 94);
            this.brn_Cancelar.TabIndex = 64;
            this.brn_Cancelar.Text = "Cancelar";
            this.brn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_Cancelar.UseVisualStyleBackColor = true;
            this.brn_Cancelar.Click += new System.EventHandler(this.brn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.Image")));
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Aceptar.Location = new System.Drawing.Point(309, 258);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(121, 87);
            this.btn_Aceptar.TabIndex = 65;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // frmDescuentoGenericoV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 461);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmDescuentoGenericoV2";
            this.Text = "frmDescuentoGenericoV2";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox Txt_DescuentoGenerico;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button brn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}