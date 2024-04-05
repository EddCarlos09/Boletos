namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatRutasV2
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
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.btnUpdTerminal = new MaterialSkin.Controls.MaterialButton();
            this.btnDelTerminal = new MaterialSkin.Controls.MaterialButton();
            this.btnAddTerminal = new MaterialSkin.Controls.MaterialButton();
            this.txtTiempo2 = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Rutasinter = new MaterialSkin.Controls.MaterialListView();
            this.lblGrid = new System.Windows.Forms.TextBox();
            this.cmbDestino = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbOrigen = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txt_mensaje);
            this.panel1.Controls.Add(this.btnUpdTerminal);
            this.panel1.Controls.Add(this.btnDelTerminal);
            this.panel1.Controls.Add(this.btnAddTerminal);
            this.panel1.Controls.Add(this.txtTiempo2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgv_Rutasinter);
            this.panel1.Controls.Add(this.lblGrid);
            this.panel1.Controls.Add(this.cmbDestino);
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 625);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(94, 570);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(659, 570);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(150, 510);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(496, 32);
            this.txt_mensaje.TabIndex = 13;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mensaje.Visible = false;
            // 
            // btnUpdTerminal
            // 
            this.btnUpdTerminal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdTerminal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdTerminal.Depth = 0;
            this.btnUpdTerminal.HighEmphasis = true;
            this.btnUpdTerminal.Icon = null;
            this.btnUpdTerminal.Location = new System.Drawing.Point(686, 468);
            this.btnUpdTerminal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdTerminal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdTerminal.Name = "btnUpdTerminal";
            this.btnUpdTerminal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdTerminal.Size = new System.Drawing.Size(64, 36);
            this.btnUpdTerminal.TabIndex = 12;
            this.btnUpdTerminal.Text = "/";
            this.btnUpdTerminal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdTerminal.UseAccentColor = false;
            this.btnUpdTerminal.UseVisualStyleBackColor = true;
            this.btnUpdTerminal.Click += new System.EventHandler(this.btnUpdTerminal_Click);
            // 
            // btnDelTerminal
            // 
            this.btnDelTerminal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelTerminal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelTerminal.Depth = 0;
            this.btnDelTerminal.HighEmphasis = true;
            this.btnDelTerminal.Icon = null;
            this.btnDelTerminal.Location = new System.Drawing.Point(686, 412);
            this.btnDelTerminal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelTerminal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelTerminal.Name = "btnDelTerminal";
            this.btnDelTerminal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelTerminal.Size = new System.Drawing.Size(64, 36);
            this.btnDelTerminal.TabIndex = 11;
            this.btnDelTerminal.Text = "-";
            this.btnDelTerminal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelTerminal.UseAccentColor = false;
            this.btnDelTerminal.UseVisualStyleBackColor = true;
            this.btnDelTerminal.Click += new System.EventHandler(this.btnDelTerminal_Click);
            // 
            // btnAddTerminal
            // 
            this.btnAddTerminal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTerminal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddTerminal.Depth = 0;
            this.btnAddTerminal.HighEmphasis = true;
            this.btnAddTerminal.Icon = null;
            this.btnAddTerminal.Location = new System.Drawing.Point(686, 364);
            this.btnAddTerminal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddTerminal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTerminal.Name = "btnAddTerminal";
            this.btnAddTerminal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddTerminal.Size = new System.Drawing.Size(64, 36);
            this.btnAddTerminal.TabIndex = 10;
            this.btnAddTerminal.Text = "+";
            this.btnAddTerminal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTerminal.UseAccentColor = false;
            this.btnAddTerminal.UseVisualStyleBackColor = true;
            this.btnAddTerminal.Click += new System.EventHandler(this.btnAddTerminal_Click);
            // 
            // txtTiempo2
            // 
            this.txtTiempo2.AnimateReadOnly = false;
            this.txtTiempo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempo2.Depth = 0;
            this.txtTiempo2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTiempo2.Hint = "00:00";
            this.txtTiempo2.LeadingIcon = null;
            this.txtTiempo2.Location = new System.Drawing.Point(94, 270);
            this.txtTiempo2.MaxLength = 50;
            this.txtTiempo2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTiempo2.Multiline = false;
            this.txtTiempo2.Name = "txtTiempo2";
            this.txtTiempo2.Size = new System.Drawing.Size(134, 50);
            this.txtTiempo2.TabIndex = 9;
            this.txtTiempo2.Text = "";
            this.txtTiempo2.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(89, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tiempo Viaje";
            // 
            // dgv_Rutasinter
            // 
            this.dgv_Rutasinter.AutoSizeTable = false;
            this.dgv_Rutasinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Rutasinter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Rutasinter.Depth = 0;
            this.dgv_Rutasinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Rutasinter.FullRowSelect = true;
            this.dgv_Rutasinter.HideSelection = false;
            this.dgv_Rutasinter.Location = new System.Drawing.Point(97, 361);
            this.dgv_Rutasinter.MinimumSize = new System.Drawing.Size(200, 100);
            this.dgv_Rutasinter.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dgv_Rutasinter.MouseState = MaterialSkin.MouseState.OUT;
            this.dgv_Rutasinter.Name = "dgv_Rutasinter";
            this.dgv_Rutasinter.OwnerDraw = true;
            this.dgv_Rutasinter.Size = new System.Drawing.Size(582, 143);
            this.dgv_Rutasinter.TabIndex = 7;
            this.dgv_Rutasinter.UseCompatibleStateImageBehavior = false;
            this.dgv_Rutasinter.View = System.Windows.Forms.View.Details;
            // 
            // lblGrid
            // 
            this.lblGrid.BackColor = System.Drawing.Color.SteelBlue;
            this.lblGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGrid.ForeColor = System.Drawing.Color.White;
            this.lblGrid.Location = new System.Drawing.Point(97, 340);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.ReadOnly = true;
            this.lblGrid.Size = new System.Drawing.Size(650, 15);
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
            this.cmbDestino.Location = new System.Drawing.Point(94, 179);
            this.cmbDestino.MaxDropDownItems = 4;
            this.cmbDestino.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(653, 49);
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
            this.cmbOrigen.Location = new System.Drawing.Point(94, 88);
            this.cmbOrigen.MaxDropDownItems = 4;
            this.cmbOrigen.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(653, 49);
            this.cmbOrigen.StartIndex = 0;
            this.cmbOrigen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(89, 151);
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
            this.label1.Location = new System.Drawing.Point(89, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Terminal Origen";
            // 
            // frmCatRutasV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 692);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatRutasV2";
            this.Text = "fmrCatRutasV2";
            this.Load += new System.EventHandler(this.frmRutas_Load);
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
        private MaterialSkin.Controls.MaterialListView dgv_Rutasinter;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtTiempo2;
        private MaterialSkin.Controls.MaterialButton btnDelTerminal;
        private MaterialSkin.Controls.MaterialButton btnAddTerminal;
        private MaterialSkin.Controls.MaterialButton btnUpdTerminal;
        private System.Windows.Forms.TextBox txt_mensaje;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
    }
}