namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmTipoObjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoObjeto));
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.txtBar = new System.Windows.Forms.PictureBox();
            this.txtWC = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.panel_Creativa1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.txtBar);
            this.panel_Creativa1.Controls.Add(this.txtWC);
            this.panel_Creativa1.Controls.Add(this.pictureBox1);
            this.panel_Creativa1.Controls.Add(this.label5);
            this.panel_Creativa1.Controls.Add(this.label4);
            this.panel_Creativa1.Controls.Add(this.label3);
            this.panel_Creativa1.Controls.Add(this.label2);
            this.panel_Creativa1.Controls.Add(this.label1);
            this.panel_Creativa1.Controls.Add(this.txtAsiento);
            this.panel_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(444, 198);
            this.panel_Creativa1.TabIndex = 0;
            // 
            // txtBar
            // 
            this.txtBar.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.bar;
            this.txtBar.Location = new System.Drawing.Point(336, 22);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(70, 56);
            this.txtBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtBar.TabIndex = 10;
            this.txtBar.TabStop = false;
            this.txtBar.Click += new System.EventHandler(this.txtBar_Click);
            // 
            // txtWC
            // 
            this.txtWC.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.wc;
            this.txtWC.Location = new System.Drawing.Point(189, 22);
            this.txtWC.Name = "txtWC";
            this.txtWC.Size = new System.Drawing.Size(70, 56);
            this.txtWC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtWC.TabIndex = 9;
            this.txtWC.TabStop = false;
            this.txtWC.Click += new System.EventHandler(this.txtWC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.disponible;
            this.pictureBox1.Location = new System.Drawing.Point(44, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "asiento que se asignará y presione ENTER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "En caso de elegir Asiento debe escribir el número de ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(353, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(199, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baño";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Asiento";
            // 
            // txtAsiento
            // 
            this.txtAsiento.BackColor = System.Drawing.Color.SkyBlue;
            this.txtAsiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsiento.Location = new System.Drawing.Point(44, 99);
            this.txtAsiento.Multiline = true;
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(70, 23);
            this.txtAsiento.TabIndex = 0;
            this.txtAsiento.Text = "0";
            this.txtAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAsiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAsiento_KeyDown);
            // 
            // frmTipoObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(444, 198);
            this.ControlBox = true;
            this.Controls.Add(this.panel_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoObjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione Tipo de Objeto";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.panel_Creativa1.ResumeLayout(false);
            this.panel_Creativa1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox txtBar;
        private System.Windows.Forms.PictureBox txtWC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}