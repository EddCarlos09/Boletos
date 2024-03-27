namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmDepositosRetiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositosRetiros));
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btnAceptar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnCancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelDeposito = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.panel_Creativa1.SuspendLayout();
            this.panelDeposito.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.btnAceptar);
            this.panel_Creativa1.Controls.Add(this.btnCancelar);
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 154);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(534, 85);
            this.panel_Creativa1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAceptar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnAceptar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnAceptar.FocusRectangle = true;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = null;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnAceptar.ImageFocused = null;
            this.btnAceptar.ImageInactive = null;
            this.btnAceptar.ImageMouseOver = null;
            this.btnAceptar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.btnAceptar.ImagePressed = null;
            this.btnAceptar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAceptar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnAceptar.KeyButtonView = false;
            this.btnAceptar.Location = new System.Drawing.Point(351, 9);
            this.btnAceptar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAceptar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OffsetPressedContent = true;
            this.btnAceptar.Size = new System.Drawing.Size(80, 65);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.TextDropShadow = true;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnCancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FocusRectangle = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.ImageFocused = null;
            this.btnCancelar.ImageInactive = null;
            this.btnCancelar.ImageMouseOver = null;
            this.btnCancelar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.btnCancelar.ImagePressed = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancelar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnCancelar.KeyButtonView = false;
            this.btnCancelar.Location = new System.Drawing.Point(442, 9);
            this.btnCancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OffsetPressedContent = true;
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextDropShadow = true;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelDeposito
            // 
            this.panelDeposito.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelDeposito.BorderColor = System.Drawing.Color.Transparent;
            this.panelDeposito.Controls.Add(this.label9);
            this.panelDeposito.Controls.Add(this.panel_Creativa1);
            this.panelDeposito.Controls.Add(this.txtConcepto);
            this.panelDeposito.Controls.Add(this.label2);
            this.panelDeposito.Controls.Add(this.label1);
            this.panelDeposito.Controls.Add(this.txtMonto);
            this.panelDeposito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDeposito.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelDeposito.Location = new System.Drawing.Point(0, 0);
            this.panelDeposito.Name = "panelDeposito";
            this.panelDeposito.Size = new System.Drawing.Size(534, 240);
            this.panelDeposito.SizeLine = 3;
            this.panelDeposito.SizeTitle = 20;
            this.panelDeposito.TabIndex = 0;
            this.panelDeposito.Title = "Datos del Deposito";
            this.panelDeposito.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(177, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Datos del Deposito";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(106, 78);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(417, 70);
            this.txtConcepto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Concepto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(106, 46);
            this.txtMonto.MaxLength = 9;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(172, 26);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.Text = "0";
            this.txtMonto.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonto_Validating);
            // 
            // frmDepositosRetiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(534, 240);
            this.ControlBox = true;
            this.Controls.Add(this.panelDeposito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmDepositosRetiros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositos y Retiros";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmDepositosRetiros_Load);
            this.panel_Creativa1.ResumeLayout(false);
            this.panelDeposito.ResumeLayout(false);
            this.panelDeposito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btnCancelar;
        private LibControls.WinForms.Button_Creativa btnAceptar;
        private LibControls.WinForms.PanelTitle_Creativa panelDeposito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label9;
    }


}