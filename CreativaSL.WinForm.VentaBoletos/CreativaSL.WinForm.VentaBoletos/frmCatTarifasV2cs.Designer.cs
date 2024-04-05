namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatTarifasV2cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatTarifasV2cs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvTarifas = new MaterialSkin.Controls.MaterialListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbViajes = new MaterialSkin.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.dgvTarifas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbViajes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 532);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(398, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCancelar.Size = new System.Drawing.Size(154, 52);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(197, 431);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGuardar.Size = new System.Drawing.Size(154, 52);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.AutoSizeTable = false;
            this.dgvTarifas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTarifas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTarifas.Depth = 0;
            this.dgvTarifas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTarifas.FullRowSelect = true;
            this.dgvTarifas.HideSelection = false;
            this.dgvTarifas.Location = new System.Drawing.Point(54, 208);
            this.dgvTarifas.MinimumSize = new System.Drawing.Size(200, 100);
            this.dgvTarifas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dgvTarifas.MouseState = MaterialSkin.MouseState.OUT;
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.OwnerDraw = true;
            this.dgvTarifas.Size = new System.Drawing.Size(722, 181);
            this.dgvTarifas.TabIndex = 5;
            this.dgvTarifas.UseCompatibleStateImageBehavior = false;
            this.dgvTarifas.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(49, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Terminales Destino";
            // 
            // cmbViajes
            // 
            this.cmbViajes.AutoResize = false;
            this.cmbViajes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbViajes.Depth = 0;
            this.cmbViajes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbViajes.DropDownHeight = 174;
            this.cmbViajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViajes.DropDownWidth = 121;
            this.cmbViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbViajes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbViajes.FormattingEnabled = true;
            this.cmbViajes.IntegralHeight = false;
            this.cmbViajes.ItemHeight = 43;
            this.cmbViajes.Location = new System.Drawing.Point(210, 90);
            this.cmbViajes.MaxDropDownItems = 4;
            this.cmbViajes.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbViajes.Name = "cmbViajes";
            this.cmbViajes.Size = new System.Drawing.Size(317, 49);
            this.cmbViajes.StartIndex = 0;
            this.cmbViajes.TabIndex = 3;
            this.cmbViajes.SelectedIndexChanged += new System.EventHandler(this.cmbViajes_SelectedIndexChanged);
            this.cmbViajes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbViajes_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre Viaje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(49, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tarifas";
            // 
            // frmCatTarifasV2cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 599);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatTarifasV2cs";
            this.Text = "frmCatTarifasV2cs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialComboBox cmbViajes;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialListView dgvTarifas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}