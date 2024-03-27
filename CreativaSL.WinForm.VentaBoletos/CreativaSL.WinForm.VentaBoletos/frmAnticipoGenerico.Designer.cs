namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmAnticipoGenerico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnticipoGenerico));
            this.panel_anticipo = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Anticipo = new System.Windows.Forms.TextBox();
            this.brn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Aceptar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panel_anticipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_anticipo
            // 
            this.panel_anticipo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_anticipo.BorderColor = System.Drawing.Color.Transparent;
            this.panel_anticipo.Controls.Add(this.label4);
            this.panel_anticipo.Controls.Add(this.Txt_Anticipo);
            this.panel_anticipo.Controls.Add(this.brn_Cancelar);
            this.panel_anticipo.Controls.Add(this.btn_Aceptar);
            this.panel_anticipo.Controls.Add(this.lblPrecio);
            this.panel_anticipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_anticipo.DrawGradient = false;
            this.panel_anticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_anticipo.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_anticipo.Location = new System.Drawing.Point(0, 0);
            this.panel_anticipo.Name = "panel_anticipo";
            this.panel_anticipo.Size = new System.Drawing.Size(375, 182);
            this.panel_anticipo.SizeLine = 3;
            this.panel_anticipo.SizeTitle = 20;
            this.panel_anticipo.TabIndex = 0;
            this.panel_anticipo.Title = "";
            this.panel_anticipo.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(140, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Anticipo";
            // 
            // Txt_Anticipo
            // 
            this.Txt_Anticipo.Location = new System.Drawing.Point(144, 45);
            this.Txt_Anticipo.MaxLength = 11;
            this.Txt_Anticipo.Name = "Txt_Anticipo";
            this.Txt_Anticipo.Size = new System.Drawing.Size(211, 26);
            this.Txt_Anticipo.TabIndex = 1;
            this.Txt_Anticipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Anticipo_KeyDown);
            this.Txt_Anticipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Anticipo_KeyPress);
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
            this.brn_Cancelar.Location = new System.Drawing.Point(78, 98);
            this.brn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.brn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.brn_Cancelar.Name = "brn_Cancelar";
            this.brn_Cancelar.OffsetPressedContent = true;
            this.brn_Cancelar.Size = new System.Drawing.Size(80, 65);
            this.brn_Cancelar.TabIndex = 2;
            this.brn_Cancelar.Text = "Cancelar";
            this.brn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.btn_Aceptar.Location = new System.Drawing.Point(222, 98);
            this.btn_Aceptar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Aceptar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.OffsetPressedContent = true;
            this.btn_Aceptar.Size = new System.Drawing.Size(80, 65);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Aceptar.TextDropShadow = true;
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(28, 48);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 22);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Anticipo:";
            // 
            // frmAnticipoGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(375, 182);
            this.Controls.Add(this.panel_anticipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnticipoGenerico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.panel_anticipo.ResumeLayout(false);
            this.panel_anticipo.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panel_anticipo;
        private System.Windows.Forms.TextBox Txt_Anticipo;
        private LibControls.WinForms.Button_Creativa brn_Cancelar;
        private LibControls.WinForms.Button_Creativa btn_Aceptar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label4;
    }
}