namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmTipoObjetoV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoObjetoV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBar = new System.Windows.Forms.PictureBox();
            this.txtWC = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAsiento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBar);
            this.panel1.Controls.Add(this.txtWC);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(6, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 363);
            this.panel1.TabIndex = 0;
            // 
            // txtAsiento
            // 
            this.txtAsiento.BackColor = System.Drawing.Color.White;
            this.txtAsiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsiento.Location = new System.Drawing.Point(108, 182);
            this.txtAsiento.Multiline = true;
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(109, 23);
            this.txtAsiento.TabIndex = 17;
            this.txtAsiento.Text = "0";
            this.txtAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAsiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAsiento_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(492, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(296, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Baño";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(118, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Asiento";
            // 
            // txtBar
            // 
            this.txtBar.Image = ((System.Drawing.Image)(resources.GetObject("txtBar.Image")));
            this.txtBar.Location = new System.Drawing.Point(463, 39);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(109, 101);
            this.txtBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtBar.TabIndex = 13;
            this.txtBar.TabStop = false;
            this.txtBar.Click += new System.EventHandler(this.txtBar_Click);
            // 
            // txtWC
            // 
            this.txtWC.Image = ((System.Drawing.Image)(resources.GetObject("txtWC.Image")));
            this.txtWC.InitialImage = ((System.Drawing.Image)(resources.GetObject("txtWC.InitialImage")));
            this.txtWC.Location = new System.Drawing.Point(284, 39);
            this.txtWC.Name = "txtWC";
            this.txtWC.Size = new System.Drawing.Size(109, 101);
            this.txtWC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtWC.TabIndex = 12;
            this.txtWC.TabStop = false;
            this.txtWC.Click += new System.EventHandler(this.txtWC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(385, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "asiento que se asignará y presione ENTER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(106, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(472, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "En caso de elegir Asiento debe escribir el número de ";
            // 
            // frmTipoObjetoV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 472);
            this.Controls.Add(this.panel1);
            this.Name = "frmTipoObjetoV2";
            this.Text = "Seleccione Tipo de Objeto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox txtBar;
        private System.Windows.Forms.PictureBox txtWC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}