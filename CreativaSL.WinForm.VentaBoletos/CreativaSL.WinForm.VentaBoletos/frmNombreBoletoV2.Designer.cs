namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmNombreBoletoV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNombreBoletoV2));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_C_nombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_C_numerotelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.DtmFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(93, 126);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nombre Boleto";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(428, 126);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(154, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Fecha de Nacimiento ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(765, 126);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(145, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Número de Telefono";
            // 
            // txt_C_nombre
            // 
            this.txt_C_nombre.AnimateReadOnly = false;
            this.txt_C_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_C_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_C_nombre.Depth = 0;
            this.txt_C_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_C_nombre.HideSelection = true;
            this.txt_C_nombre.LeadingIcon = null;
            this.txt_C_nombre.Location = new System.Drawing.Point(39, 188);
            this.txt_C_nombre.MaxLength = 32767;
            this.txt_C_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_C_nombre.Name = "txt_C_nombre";
            this.txt_C_nombre.PasswordChar = '\0';
            this.txt_C_nombre.PrefixSuffixText = null;
            this.txt_C_nombre.ReadOnly = false;
            this.txt_C_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_C_nombre.SelectedText = "";
            this.txt_C_nombre.SelectionLength = 0;
            this.txt_C_nombre.SelectionStart = 0;
            this.txt_C_nombre.ShortcutsEnabled = true;
            this.txt_C_nombre.Size = new System.Drawing.Size(250, 48);
            this.txt_C_nombre.TabIndex = 3;
            this.txt_C_nombre.TabStop = false;
            this.txt_C_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_C_nombre.TrailingIcon = null;
            this.txt_C_nombre.UseSystemPasswordChar = false;
            // 
            // txt_C_numerotelefono
            // 
            this.txt_C_numerotelefono.AnimateReadOnly = false;
            this.txt_C_numerotelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_C_numerotelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_C_numerotelefono.Depth = 0;
            this.txt_C_numerotelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_C_numerotelefono.HideSelection = true;
            this.txt_C_numerotelefono.LeadingIcon = null;
            this.txt_C_numerotelefono.Location = new System.Drawing.Point(712, 188);
            this.txt_C_numerotelefono.MaxLength = 32767;
            this.txt_C_numerotelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_C_numerotelefono.Name = "txt_C_numerotelefono";
            this.txt_C_numerotelefono.PasswordChar = '\0';
            this.txt_C_numerotelefono.PrefixSuffixText = null;
            this.txt_C_numerotelefono.ReadOnly = false;
            this.txt_C_numerotelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_C_numerotelefono.SelectedText = "";
            this.txt_C_numerotelefono.SelectionLength = 0;
            this.txt_C_numerotelefono.SelectionStart = 0;
            this.txt_C_numerotelefono.ShortcutsEnabled = true;
            this.txt_C_numerotelefono.Size = new System.Drawing.Size(250, 48);
            this.txt_C_numerotelefono.TabIndex = 5;
            this.txt_C_numerotelefono.TabStop = false;
            this.txt_C_numerotelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_C_numerotelefono.TrailingIcon = null;
            this.txt_C_numerotelefono.UseSystemPasswordChar = false;
            // 
            // DtmFechaNac
            // 
            this.DtmFechaNac.Location = new System.Drawing.Point(400, 198);
            this.DtmFechaNac.Name = "DtmFechaNac";
            this.DtmFechaNac.Size = new System.Drawing.Size(227, 22);
            this.DtmFechaNac.TabIndex = 6;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(257, 290);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(200, 71);
            this.btn_Guardar.TabIndex = 64;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(537, 290);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Cancelar.Size = new System.Drawing.Size(208, 71);
            this.btn_Cancelar.TabIndex = 65;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(451, 89);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(100, 19);
            this.materialLabel4.TabIndex = 66;
            this.materialLabel4.Text = "Datos Boletos";
            // 
            // frmNombreBoletoV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 401);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.DtmFechaNac);
            this.Controls.Add(this.txt_C_numerotelefono);
            this.Controls.Add(this.txt_C_nombre);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmNombreBoletoV2";
            this.Text = "frmNombreBoletoV2";
            //this.Load += new System.EventHandler(this.frmNombreBoletoV2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txt_C_nombre;
        private MaterialSkin.Controls.MaterialTextBox2 txt_C_numerotelefono;
        private System.Windows.Forms.DateTimePicker DtmFechaNac;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}