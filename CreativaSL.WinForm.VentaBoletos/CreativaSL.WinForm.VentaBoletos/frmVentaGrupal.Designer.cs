namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmVentaGrupal
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
            this.panel_login_validator = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.txt_numeroTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.brn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Aceptar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel_login_validator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login_validator
            // 
            this.panel_login_validator.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_login_validator.BorderColor = System.Drawing.Color.Transparent;
            this.panel_login_validator.Controls.Add(this.txt_numeroTelefono);
            this.panel_login_validator.Controls.Add(this.label2);
            this.panel_login_validator.Controls.Add(this.dtpFechaNacimiento);
            this.panel_login_validator.Controls.Add(this.label1);
            this.panel_login_validator.Controls.Add(this.label4);
            this.panel_login_validator.Controls.Add(this.txt_nombre);
            this.panel_login_validator.Controls.Add(this.brn_Cancelar);
            this.panel_login_validator.Controls.Add(this.btn_Aceptar);
            this.panel_login_validator.Controls.Add(this.lblNombre);
            this.panel_login_validator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login_validator.DrawGradient = false;
            this.panel_login_validator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login_validator.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_login_validator.Location = new System.Drawing.Point(0, 0);
            this.panel_login_validator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_login_validator.Name = "panel_login_validator";
            this.panel_login_validator.Size = new System.Drawing.Size(604, 290);
            this.panel_login_validator.SizeLine = 3;
            this.panel_login_validator.SizeTitle = 20;
            this.panel_login_validator.TabIndex = 41;
            this.panel_login_validator.Title = "";
            this.panel_login_validator.TitleColor = System.Drawing.Color.Transparent;
            // 
            // txt_numeroTelefono
            // 
            this.txt_numeroTelefono.Location = new System.Drawing.Point(248, 149);
            this.txt_numeroTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_numeroTelefono.MaxLength = 50;
            this.txt_numeroTelefono.Name = "txt_numeroTelefono";
            this.txt_numeroTelefono.Size = new System.Drawing.Size(339, 30);
            this.txt_numeroTelefono.TabIndex = 3;
            this.txt_numeroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numeroTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número Teléfono:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(248, 102);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(339, 30);
            this.dtpFechaNacimiento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(217, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 122;
            this.label4.Text = "Venta Grupal";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(248, 52);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.MaxLength = 150;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(339, 30);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(164, 26);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Boleto:";
            // 
            // brn_Cancelar
            // 
            this.brn_Cancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.brn_Cancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.brn_Cancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.brn_Cancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.brn_Cancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.brn_Cancelar.FocusRectangle = true;
            this.brn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Cancelar.Image = null;
            this.brn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brn_Cancelar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.brn_Cancelar.ImageFocused = null;
            this.brn_Cancelar.ImageInactive = null;
            this.brn_Cancelar.ImageMouseOver = null;
            this.brn_Cancelar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.brn_Cancelar.ImagePressed = null;
            this.brn_Cancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.brn_Cancelar.KeyButton = System.Windows.Forms.Keys.None;
            this.brn_Cancelar.KeyButtonView = false;
            this.brn_Cancelar.Location = new System.Drawing.Point(147, 202);
            this.brn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.brn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.brn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.brn_Cancelar.Name = "brn_Cancelar";
            this.brn_Cancelar.OffsetPressedContent = true;
            this.brn_Cancelar.Size = new System.Drawing.Size(107, 80);
            this.brn_Cancelar.TabIndex = 5;
            this.brn_Cancelar.Text = "Cancelar";
            this.brn_Cancelar.TextDropShadow = true;
            this.brn_Cancelar.UseVisualStyleBackColor = false;
            this.brn_Cancelar.Click += new System.EventHandler(this.brn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Aceptar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Aceptar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Aceptar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Aceptar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Aceptar.FocusRectangle = true;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Image = null;
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Aceptar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Aceptar.ImageFocused = null;
            this.btn_Aceptar.ImageInactive = null;
            this.btn_Aceptar.ImageMouseOver = null;
            this.btn_Aceptar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.btn_Aceptar.ImagePressed = null;
            this.btn_Aceptar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Aceptar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Aceptar.KeyButtonView = false;
            this.btn_Aceptar.Location = new System.Drawing.Point(339, 202);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Aceptar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Aceptar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.OffsetPressedContent = true;
            this.btn_Aceptar.Size = new System.Drawing.Size(107, 80);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextDropShadow = true;
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // frmVentaGrupal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(604, 290);
            this.ControlBox = false;
            this.Controls.Add(this.panel_login_validator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentaGrupal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.panel_login_validator.ResumeLayout(false);
            this.panel_login_validator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panel_login_validator;
        private System.Windows.Forms.TextBox txt_nombre;
        private LibControls.WinForms.Button_Creativa brn_Cancelar;
        private LibControls.WinForms.Button_Creativa btn_Aceptar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numeroTelefono;
        private System.Windows.Forms.Label label2;
    }
}