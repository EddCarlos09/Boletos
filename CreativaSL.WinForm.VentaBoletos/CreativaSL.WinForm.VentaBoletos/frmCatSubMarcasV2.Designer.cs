namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatSubMarcasV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatSubMarcasV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.CmbMarca = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreSubMarca = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.CmbMarca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtNombreSubMarca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(3, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 367);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(619, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btnCancelar.Size = new System.Drawing.Size(154, 133);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(446, 158);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btnGuardar.Size = new System.Drawing.Size(146, 133);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // CmbMarca
            // 
            this.CmbMarca.AutoResize = false;
            this.CmbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbMarca.Depth = 0;
            this.CmbMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbMarca.DropDownHeight = 174;
            this.CmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarca.DropDownWidth = 121;
            this.CmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.IntegralHeight = false;
            this.CmbMarca.ItemHeight = 43;
            this.CmbMarca.Location = new System.Drawing.Point(45, 254);
            this.CmbMarca.MaxDropDownItems = 4;
            this.CmbMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(354, 49);
            this.CmbMarca.StartIndex = 0;
            this.CmbMarca.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca";
            // 
            // TxtNombreSubMarca
            // 
            this.TxtNombreSubMarca.AnimateReadOnly = false;
            this.TxtNombreSubMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreSubMarca.Depth = 0;
            this.TxtNombreSubMarca.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNombreSubMarca.LeadingIcon = null;
            this.TxtNombreSubMarca.Location = new System.Drawing.Point(45, 146);
            this.TxtNombreSubMarca.MaxLength = 50;
            this.TxtNombreSubMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNombreSubMarca.Multiline = false;
            this.TxtNombreSubMarca.Name = "TxtNombreSubMarca";
            this.TxtNombreSubMarca.Size = new System.Drawing.Size(354, 50);
            this.TxtNombreSubMarca.TabIndex = 3;
            this.TxtNombreSubMarca.Text = "";
            this.TxtNombreSubMarca.TrailingIcon = null;
            this.TxtNombreSubMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreSubMarca_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "SubMarca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(40, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Submarcas";
            // 
            // frmCatSubMarcasV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatSubMarcasV2";
            this.Text = "Sub marcas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox TxtNombreSubMarca;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox CmbMarca;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}