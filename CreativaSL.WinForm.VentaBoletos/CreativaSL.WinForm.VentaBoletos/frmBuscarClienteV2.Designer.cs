namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmBuscarClienteV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarClienteV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_C_Uno = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_C_Dos = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GridViewGeneral = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.GridViewGeneral);
            this.panel1.Location = new System.Drawing.Point(6, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 502);
            this.panel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.Txt_C_Uno);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.btnAceptar);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.Txt_C_Dos);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.btnBuscar);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(38, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1321, 142);
            this.materialCard1.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Búsqueda";
            // 
            // Txt_C_Uno
            // 
            this.Txt_C_Uno.AnimateReadOnly = false;
            this.Txt_C_Uno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_C_Uno.Depth = 0;
            this.Txt_C_Uno.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_C_Uno.LeadingIcon = null;
            this.Txt_C_Uno.Location = new System.Drawing.Point(184, 55);
            this.Txt_C_Uno.MaxLength = 50;
            this.Txt_C_Uno.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_C_Uno.Multiline = false;
            this.Txt_C_Uno.Name = "Txt_C_Uno";
            this.Txt_C_Uno.Size = new System.Drawing.Size(238, 50);
            this.Txt_C_Uno.TabIndex = 3;
            this.Txt_C_Uno.Text = "";
            this.Txt_C_Uno.TrailingIcon = null;
            this.Txt_C_Uno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_C_Uno_KeyDown);
            this.Txt_C_Uno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_C_Uno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre cliente:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = false;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Icon")));
            this.btnAceptar.Location = new System.Drawing.Point(1131, 55);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(172, 59);
            this.btnAceptar.TabIndex = 136;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(447, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código tarjeta:";
            // 
            // Txt_C_Dos
            // 
            this.Txt_C_Dos.AnimateReadOnly = false;
            this.Txt_C_Dos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_C_Dos.Depth = 0;
            this.Txt_C_Dos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_C_Dos.LeadingIcon = null;
            this.Txt_C_Dos.Location = new System.Drawing.Point(612, 55);
            this.Txt_C_Dos.MaxLength = 50;
            this.Txt_C_Dos.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_C_Dos.Multiline = false;
            this.Txt_C_Dos.Name = "Txt_C_Dos";
            this.Txt_C_Dos.Size = new System.Drawing.Size(199, 50);
            this.Txt_C_Dos.TabIndex = 5;
            this.Txt_C_Dos.Text = "";
            this.Txt_C_Dos.TrailingIcon = null;
            this.Txt_C_Dos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_C_Dos_KeyDown);
            this.Txt_C_Dos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_C_Dos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(956, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Acciones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(827, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnBuscar.Size = new System.Drawing.Size(84, 83);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(33, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 26);
            this.label5.TabIndex = 138;
            this.label5.Text = "Resultados de búsqueda";
            // 
            // GridViewGeneral
            // 
            this.GridViewGeneral.AllowUserToAddRows = false;
            this.GridViewGeneral.AllowUserToDeleteRows = false;
            this.GridViewGeneral.AllowUserToResizeColumns = false;
            this.GridViewGeneral.AllowUserToResizeRows = false;
            this.GridViewGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewGeneral.BackgroundColor = System.Drawing.Color.White;
            this.GridViewGeneral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridViewGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25});
            this.GridViewGeneral.GridColor = System.Drawing.SystemColors.ControlLight;
            this.GridViewGeneral.Location = new System.Drawing.Point(37, 201);
            this.GridViewGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridViewGeneral.MultiSelect = false;
            this.GridViewGeneral.Name = "GridViewGeneral";
            this.GridViewGeneral.ReadOnly = true;
            this.GridViewGeneral.RowHeadersWidth = 51;
            this.GridViewGeneral.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GridViewGeneral.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridViewGeneral.RowTemplate.Height = 28;
            this.GridViewGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewGeneral.Size = new System.Drawing.Size(1322, 262);
            this.GridViewGeneral.TabIndex = 137;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 23;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 23;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 23;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 23;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 23;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 23;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 23;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 23;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 23;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 23;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 23;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 23;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 23;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 23;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 23;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 23;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 23;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 23;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 23;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "";
            this.Column20.MinimumWidth = 6;
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 23;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "";
            this.Column21.MinimumWidth = 6;
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Width = 23;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "";
            this.Column22.MinimumWidth = 6;
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            this.Column22.Width = 23;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "";
            this.Column23.MinimumWidth = 6;
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Width = 23;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "";
            this.Column24.MinimumWidth = 6;
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Width = 23;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "";
            this.Column25.MinimumWidth = 6;
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Width = 23;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Icon")));
            this.btnCancelar.Location = new System.Drawing.Point(951, 55);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(162, 59);
            this.btnCancelar.TabIndex = 135;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmBuscarClienteV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 607);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuscarClienteV2";
            this.Text = "Buscar Cliente";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox Txt_C_Uno;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox Txt_C_Dos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GridViewGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}