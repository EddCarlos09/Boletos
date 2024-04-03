namespace CreativaSL.WinForm.VentaBoletos
{
    partial class fmrCatRutasV2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGrid = new System.Windows.Forms.TextBox();
            this.cmbDestino = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbOrigen = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialListView1);
            this.panel1.Controls.Add(this.lblGrid);
            this.panel1.Controls.Add(this.cmbDestino);
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblGrid
            // 
            this.lblGrid.BackColor = System.Drawing.Color.SteelBlue;
            this.lblGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGrid.ForeColor = System.Drawing.Color.White;
            this.lblGrid.Location = new System.Drawing.Point(43, 303);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.ReadOnly = true;
            this.lblGrid.Size = new System.Drawing.Size(725, 15);
            this.lblGrid.TabIndex = 6;
            this.lblGrid.TabStop = false;
            this.lblGrid.Text = "TERMINALES INTERMEDIAS";
            this.lblGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbDestino
            // 
            this.cmbDestino.AutoResize = false;
            this.cmbDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDestino.Depth = 0;
            this.cmbDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDestino.DropDownHeight = 174;
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.DropDownWidth = 121;
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.IntegralHeight = false;
            this.cmbDestino.ItemHeight = 43;
            this.cmbDestino.Location = new System.Drawing.Point(94, 225);
            this.cmbDestino.MaxDropDownItems = 4;
            this.cmbDestino.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(599, 49);
            this.cmbDestino.StartIndex = 0;
            this.cmbDestino.TabIndex = 5;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.AutoResize = false;
            this.cmbOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbOrigen.Depth = 0;
            this.cmbOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbOrigen.DropDownHeight = 174;
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.DropDownWidth = 121;
            this.cmbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.IntegralHeight = false;
            this.cmbOrigen.ItemHeight = 43;
            this.cmbOrigen.Location = new System.Drawing.Point(94, 114);
            this.cmbOrigen.MaxDropDownItems = 4;
            this.cmbOrigen.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(599, 49);
            this.cmbOrigen.StartIndex = 0;
            this.cmbOrigen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(89, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Terminal Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(320, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Rutas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(89, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Terminal Origen";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(94, 324);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(582, 100);
            this.materialListView1.TabIndex = 7;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // fmrCatRutasV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fmrCatRutasV2";
            this.Text = "fmrCatRutasV2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox cmbDestino;
        private MaterialSkin.Controls.MaterialComboBox cmbOrigen;
        private System.Windows.Forms.TextBox lblGrid;
        private MaterialSkin.Controls.MaterialListView materialListView1;
    }
}