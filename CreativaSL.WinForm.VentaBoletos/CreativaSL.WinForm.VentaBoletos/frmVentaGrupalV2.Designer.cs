namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmVentaGrupalV2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentaGrupalV2));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.brn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_nombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_numeroTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.AllowDrop = true;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.brn_Cancelar);
            this.materialCard1.Controls.Add(this.btn_Aceptar);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.dtpFechaNacimiento);
            this.materialCard1.Controls.Add(this.txt_nombre);
            this.materialCard1.Controls.Add(this.txt_numeroTelefono);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1144, 288);
            this.materialCard1.TabIndex = 0;
            // 
            // brn_Cancelar
            // 
            this.brn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.brn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brn_Cancelar.ImageKey = "CANCELGRUPAL";
            this.brn_Cancelar.Location = new System.Drawing.Point(570, 190);
            this.brn_Cancelar.Name = "brn_Cancelar";
            this.brn_Cancelar.Size = new System.Drawing.Size(160, 62);
            this.brn_Cancelar.TabIndex = 8;
            this.brn_Cancelar.Text = "Cancelar";
            this.brn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_Cancelar.UseVisualStyleBackColor = true;
            this.brn_Cancelar.Click += new System.EventHandler(this.brn_Cancelar_Click_1);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Aceptar.ImageKey = "(ninguno)";
            this.btn_Aceptar.Location = new System.Drawing.Point(343, 190);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(160, 62);
            this.btn_Aceptar.TabIndex = 7;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(829, 42);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(149, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Numero de Telefono:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(456, 42);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(154, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Fecha de Nacimiento:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(107, 42);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(110, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Nombre Boleto:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(427, 104);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNacimiento.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombre.AnimateReadOnly = false;
            this.txt_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.HideSelection = true;
            this.txt_nombre.LeadingIcon = null;
            this.txt_nombre.Location = new System.Drawing.Point(50, 94);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.PrefixSuffixText = null;
            this.txt_nombre.ReadOnly = false;
            this.txt_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(250, 48);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TabStop = false;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nombre.TrailingIcon = null;
            this.txt_nombre.UseSystemPasswordChar = false;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress_1);
            // 
            // txt_numeroTelefono
            // 
            this.txt_numeroTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_numeroTelefono.AnimateReadOnly = false;
            this.txt_numeroTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_numeroTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_numeroTelefono.Depth = 0;
            this.txt_numeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_numeroTelefono.HideSelection = true;
            this.txt_numeroTelefono.LeadingIcon = null;
            this.txt_numeroTelefono.Location = new System.Drawing.Point(767, 94);
            this.txt_numeroTelefono.MaxLength = 32767;
            this.txt_numeroTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_numeroTelefono.Name = "txt_numeroTelefono";
            this.txt_numeroTelefono.PasswordChar = '\0';
            this.txt_numeroTelefono.PrefixSuffixText = null;
            this.txt_numeroTelefono.ReadOnly = false;
            this.txt_numeroTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_numeroTelefono.SelectedText = "";
            this.txt_numeroTelefono.SelectionLength = 0;
            this.txt_numeroTelefono.SelectionStart = 0;
            this.txt_numeroTelefono.ShortcutsEnabled = true;
            this.txt_numeroTelefono.Size = new System.Drawing.Size(250, 48);
            this.txt_numeroTelefono.TabIndex = 1;
            this.txt_numeroTelefono.TabStop = false;
            this.txt_numeroTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_numeroTelefono.TrailingIcon = null;
            this.txt_numeroTelefono.UseSystemPasswordChar = false;
            this.txt_numeroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numeroTelefono_KeyPress_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Venta Grupal";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CANCELGRUPAL");
            this.imageList1.Images.SetKeyName(1, "CheckGrupal");
            // 
            // frmVentaGrupalV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 355);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmVentaGrupalV2";
            this.Text = "frmVentaGrupalV2";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private MaterialSkin.Controls.MaterialTextBox2 txt_nombre;
        private MaterialSkin.Controls.MaterialTextBox2 txt_numeroTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Button brn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.ImageList imageList1;
    }
}