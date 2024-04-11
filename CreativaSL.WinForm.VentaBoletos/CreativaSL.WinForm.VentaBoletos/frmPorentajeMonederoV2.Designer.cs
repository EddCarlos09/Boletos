namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmPorentajeMonederoV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPorentajeMonederoV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.TxtMontoCancelacion = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtPorcentajeMonedero = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.TxtMontoCancelacion);
            this.panel1.Controls.Add(this.TxtPorcentajeMonedero);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 449);
            this.panel1.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(408, 311);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Cancelar.Size = new System.Drawing.Size(132, 109);
            this.btn_Cancelar.TabIndex = 64;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.Location = new System.Drawing.Point(233, 311);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Guardar.Size = new System.Drawing.Size(129, 109);
            this.btn_Guardar.TabIndex = 63;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // TxtMontoCancelacion
            // 
            this.TxtMontoCancelacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMontoCancelacion.AnimateReadOnly = false;
            this.TxtMontoCancelacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMontoCancelacion.Depth = 0;
            this.TxtMontoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtMontoCancelacion.LeadingIcon = null;
            this.TxtMontoCancelacion.Location = new System.Drawing.Point(194, 240);
            this.TxtMontoCancelacion.MaxLength = 50;
            this.TxtMontoCancelacion.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtMontoCancelacion.Multiline = false;
            this.TxtMontoCancelacion.Name = "TxtMontoCancelacion";
            this.TxtMontoCancelacion.Size = new System.Drawing.Size(390, 50);
            this.TxtMontoCancelacion.TabIndex = 7;
            this.TxtMontoCancelacion.Text = "";
            this.TxtMontoCancelacion.TrailingIcon = null;
            // 
            // TxtPorcentajeMonedero
            // 
            this.TxtPorcentajeMonedero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPorcentajeMonedero.AnimateReadOnly = false;
            this.TxtPorcentajeMonedero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPorcentajeMonedero.Depth = 0;
            this.TxtPorcentajeMonedero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPorcentajeMonedero.LeadingIcon = null;
            this.TxtPorcentajeMonedero.Location = new System.Drawing.Point(194, 136);
            this.TxtPorcentajeMonedero.MaxLength = 50;
            this.TxtPorcentajeMonedero.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPorcentajeMonedero.Multiline = false;
            this.TxtPorcentajeMonedero.Name = "TxtPorcentajeMonedero";
            this.TxtPorcentajeMonedero.Size = new System.Drawing.Size(390, 50);
            this.TxtPorcentajeMonedero.TabIndex = 6;
            this.TxtPorcentajeMonedero.Text = "";
            this.TxtPorcentajeMonedero.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(293, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "$ Cancelación";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(293, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "% Monedero";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(293, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Configuración";
            // 
            // frmPorentajeMonederoV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 516);
            this.Controls.Add(this.panel1);
            this.Name = "frmPorentajeMonederoV2";
            this.Text = "frmPorentajeMonederoV2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox TxtMontoCancelacion;
        private MaterialSkin.Controls.MaterialTextBox TxtPorcentajeMonedero;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}