namespace CreativaSL.WinForm.VentaBoletos
{
    partial class CatalogoFactura
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
            this.dtgvFactura = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelarTimbrado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvFactura
            // 
            this.dtgvFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvFactura.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFactura.Location = new System.Drawing.Point(69, 209);
            this.dtgvFactura.Name = "dtgvFactura";
            this.dtgvFactura.RowHeadersWidth = 51;
            this.dtgvFactura.RowTemplate.Height = 24;
            this.dtgvFactura.Size = new System.Drawing.Size(836, 312);
            this.dtgvFactura.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(217, 109);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 78);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Factura";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelarTimbrado
            // 
            this.btnCancelarTimbrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarTimbrado.Location = new System.Drawing.Point(640, 109);
            this.btnCancelarTimbrado.Name = "btnCancelarTimbrado";
            this.btnCancelarTimbrado.Size = new System.Drawing.Size(92, 78);
            this.btnCancelarTimbrado.TabIndex = 2;
            this.btnCancelarTimbrado.Text = "Cancelar Timbrado";
            this.btnCancelarTimbrado.UseVisualStyleBackColor = true;
            // 
            // CatalogoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 538);
            this.Controls.Add(this.btnCancelarTimbrado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtgvFactura);
            this.Name = "CatalogoFactura";
            this.Text = "CatalogoFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvFactura;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelarTimbrado;
    }
}