namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmAnticipoGenericoV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnticipoGenericoV2));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_Anticipo = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.brn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(271, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ANTICIPO";
            // 
            // Txt_Anticipo
            // 
            this.Txt_Anticipo.AnimateReadOnly = false;
            this.Txt_Anticipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_Anticipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_Anticipo.Depth = 0;
            this.Txt_Anticipo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Anticipo.HideSelection = true;
            this.Txt_Anticipo.LeadingIcon = null;
            this.Txt_Anticipo.Location = new System.Drawing.Point(108, 149);
            this.Txt_Anticipo.MaxLength = 32767;
            this.Txt_Anticipo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_Anticipo.Name = "Txt_Anticipo";
            this.Txt_Anticipo.PasswordChar = '\0';
            this.Txt_Anticipo.PrefixSuffixText = null;
            this.Txt_Anticipo.ReadOnly = false;
            this.Txt_Anticipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Anticipo.SelectedText = "";
            this.Txt_Anticipo.SelectionLength = 0;
            this.Txt_Anticipo.SelectionStart = 0;
            this.Txt_Anticipo.ShortcutsEnabled = true;
            this.Txt_Anticipo.Size = new System.Drawing.Size(421, 48);
            this.Txt_Anticipo.TabIndex = 1;
            this.Txt_Anticipo.TabStop = false;
            this.Txt_Anticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Anticipo.TrailingIcon = null;
            this.Txt_Anticipo.UseSystemPasswordChar = false;
            this.Txt_Anticipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Anticipo_KeyDown);
            this.Txt_Anticipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Anticipo_KeyPress);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.Image")));
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Aceptar.Location = new System.Drawing.Point(341, 248);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(110, 94);
            this.btn_Aceptar.TabIndex = 12143;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // brn_Cancelar
            // 
            this.brn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.brn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.brn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.brn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("brn_Cancelar.Image")));
            this.brn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brn_Cancelar.Location = new System.Drawing.Point(153, 248);
            this.brn_Cancelar.Name = "brn_Cancelar";
            this.brn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.brn_Cancelar.Size = new System.Drawing.Size(110, 94);
            this.brn_Cancelar.TabIndex = 12142;
            this.brn_Cancelar.Text = "Cancelar";
            this.brn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_Cancelar.UseVisualStyleBackColor = true;
            this.brn_Cancelar.Click += new System.EventHandler(this.brn_Cancelar_Click);
            // 
            // frmAnticipoGenericoV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 383);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.brn_Cancelar);
            this.Controls.Add(this.Txt_Anticipo);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmAnticipoGenericoV2";
            this.Text = "frmAnticipoGenericoV2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_Anticipo;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button brn_Cancelar;
    }
}