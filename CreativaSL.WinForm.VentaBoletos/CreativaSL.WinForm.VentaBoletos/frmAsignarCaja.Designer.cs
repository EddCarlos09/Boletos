namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmAsignarCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarCaja));
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btn_Guardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.button_Creativa1 = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.txtnameprinter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCaja = new System.Windows.Forms.ComboBox();
            this.TxtMac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Creativa1.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.btn_Guardar);
            this.panel_Creativa1.Controls.Add(this.btn_Cancelar);
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 279);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(419, 85);
            this.panel_Creativa1.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Guardar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Guardar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Guardar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Guardar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Guardar.FocusRectangle = true;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Image = null;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Guardar.ImageFocused = null;
            this.btn_Guardar.ImageInactive = null;
            this.btn_Guardar.ImageMouseOver = null;
            this.btn_Guardar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.btn_Guardar.ImagePressed = null;
            this.btn_Guardar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Guardar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Guardar.KeyButtonView = false;
            this.btn_Guardar.Location = new System.Drawing.Point(239, 12);
            this.btn_Guardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Guardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.OffsetPressedContent = true;
            this.btn_Guardar.Size = new System.Drawing.Size(80, 65);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.TextDropShadow = true;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Cancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Cancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Cancelar.FocusRectangle = true;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = null;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Cancelar.ImageFocused = null;
            this.btn_Cancelar.ImageInactive = null;
            this.btn_Cancelar.ImageMouseOver = null;
            this.btn_Cancelar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.btn_Cancelar.ImagePressed = null;
            this.btn_Cancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Cancelar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Cancelar.KeyButtonView = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(328, 12);
            this.btn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.OffsetPressedContent = true;
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 65);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.TextDropShadow = true;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa1.Controls.Add(this.panel_Creativa1);
            this.panelTitle_Creativa1.Controls.Add(this.button_Creativa1);
            this.panelTitle_Creativa1.Controls.Add(this.txtnameprinter);
            this.panelTitle_Creativa1.Controls.Add(this.label5);
            this.panelTitle_Creativa1.Controls.Add(this.label3);
            this.panelTitle_Creativa1.Controls.Add(this.txtDescripcion);
            this.panelTitle_Creativa1.Controls.Add(this.label4);
            this.panelTitle_Creativa1.Controls.Add(this.label2);
            this.panelTitle_Creativa1.Controls.Add(this.CmbCaja);
            this.panelTitle_Creativa1.Controls.Add(this.TxtMac);
            this.panelTitle_Creativa1.Controls.Add(this.label1);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.DrawGradient = false;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(422, 367);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // button_Creativa1
            // 
            this.button_Creativa1.BackColor = System.Drawing.Color.SkyBlue;
            this.button_Creativa1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Creativa1.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Creativa1.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.button_Creativa1.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.button_Creativa1.FocusRectangle = true;
            this.button_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Creativa1.Image = null;
            this.button_Creativa1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Creativa1.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.button_Creativa1.ImageFocused = null;
            this.button_Creativa1.ImageInactive = null;
            this.button_Creativa1.ImageMouseOver = null;
            this.button_Creativa1.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.button_Creativa1.ImagePressed = null;
            this.button_Creativa1.ImageSize = new System.Drawing.Size(40, 40);
            this.button_Creativa1.KeyButton = System.Windows.Forms.Keys.None;
            this.button_Creativa1.KeyButtonView = false;
            this.button_Creativa1.Location = new System.Drawing.Point(175, 205);
            this.button_Creativa1.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.button_Creativa1.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.button_Creativa1.Name = "button_Creativa1";
            this.button_Creativa1.OffsetPressedContent = true;
            this.button_Creativa1.Size = new System.Drawing.Size(80, 65);
            this.button_Creativa1.TabIndex = 5;
            this.button_Creativa1.Text = "Seleccionar";
            this.button_Creativa1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Creativa1.TextDropShadow = true;
            this.button_Creativa1.UseVisualStyleBackColor = false;
            this.button_Creativa1.Click += new System.EventHandler(this.button_Creativa1_Click);
            // 
            // txtnameprinter
            // 
            this.txtnameprinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnameprinter.Location = new System.Drawing.Point(140, 168);
            this.txtnameprinter.MaxLength = 100;
            this.txtnameprinter.Name = "txtnameprinter";
            this.txtnameprinter.Size = new System.Drawing.Size(262, 27);
            this.txtnameprinter.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name Printer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(141, 115);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(261, 45);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(138, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Asignar Cajas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Caja";
            // 
            // CmbCaja
            // 
            this.CmbCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCaja.FormattingEnabled = true;
            this.CmbCaja.Location = new System.Drawing.Point(141, 78);
            this.CmbCaja.Name = "CmbCaja";
            this.CmbCaja.Size = new System.Drawing.Size(261, 28);
            this.CmbCaja.TabIndex = 2;
            // 
            // TxtMac
            // 
            this.TxtMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMac.Location = new System.Drawing.Point(141, 40);
            this.TxtMac.MaxLength = 500;
            this.TxtMac.Name = "TxtMac";
            this.TxtMac.ReadOnly = true;
            this.TxtMac.Size = new System.Drawing.Size(261, 27);
            this.TxtMac.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mac";
            // 
            // frmAsignarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 367);
            this.ControlBox = true;
            this.Controls.Add(this.panelTitle_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmAsignarCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.panel_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btn_Guardar;
        private LibControls.WinForms.Button_Creativa btn_Cancelar;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.TextBox TxtMac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbCaja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnameprinter;
        private LibControls.WinForms.Button_Creativa button_Creativa1;
    }
}