namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatTipoCamion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatTipoCamion));
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btn_Guardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombreTipoCamion = new System.Windows.Forms.TextBox();
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
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 136);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(474, 85);
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
            this.btn_Guardar.Location = new System.Drawing.Point(277, 8);
            this.btn_Guardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Guardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.OffsetPressedContent = true;
            this.btn_Guardar.Size = new System.Drawing.Size(80, 65);
            this.btn_Guardar.TabIndex = 3;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(382, 8);
            this.btn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.OffsetPressedContent = true;
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 65);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.TextDropShadow = true;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTitle_Creativa1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa1.Controls.Add(this.label6);
            this.panelTitle_Creativa1.Controls.Add(this.TxtNombreTipoCamion);
            this.panelTitle_Creativa1.Controls.Add(this.label1);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.DrawGradient = false;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(474, 222);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(163, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo de Camión";
            // 
            // TxtNombreTipoCamion
            // 
            this.TxtNombreTipoCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreTipoCamion.Location = new System.Drawing.Point(189, 58);
            this.TxtNombreTipoCamion.MaxLength = 500;
            this.TxtNombreTipoCamion.Name = "TxtNombreTipoCamion";
            this.TxtNombreTipoCamion.Size = new System.Drawing.Size(261, 27);
            this.TxtNombreTipoCamion.TabIndex = 1;
            this.TxtNombreTipoCamion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreTipoCamion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Camión";
            // 
            // frmCatTipoCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 222);
            this.ControlBox = true;
            this.Controls.Add(this.panel_Creativa1);
            this.Controls.Add(this.panelTitle_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatTipoCamion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Camión";
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
        private System.Windows.Forms.TextBox TxtNombreTipoCamion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}