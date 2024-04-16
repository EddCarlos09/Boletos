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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbViajes = new MaterialSkin.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvTarifas = new System.Windows.Forms.DataGridView();
            this.id_tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_terminalXruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioNormal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioEspecial1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioInfantil1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTerceraEdad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioNormal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioEspecial2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioInfantil2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTerceraEdad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTarifas);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
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
            // dgvTarifas
            // 
            this.dgvTarifas.AllowUserToAddRows = false;
            this.dgvTarifas.AllowUserToDeleteRows = false;
            this.dgvTarifas.AllowUserToResizeColumns = false;
            this.dgvTarifas.AllowUserToResizeRows = false;
            this.dgvTarifas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTarifas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTarifas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tarifa,
            this.id_identificador,
            this.id_terminalXruta,
            this.nombre,
            this.terminalOrigen,
            this.terminalDestino,
            this.precioNormal1,
            this.precioEspecial1,
            this.precioInfantil1,
            this.precioTerceraEdad1,
            this.precioNormal2,
            this.precioEspecial2,
            this.precioInfantil2,
            this.precioTerceraEdad2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarifas.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTarifas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTarifas.Location = new System.Drawing.Point(54, 219);
            this.dgvTarifas.MultiSelect = false;
            this.dgvTarifas.Name = "dgvTarifas";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTarifas.RowHeadersWidth = 51;
            this.dgvTarifas.RowTemplate.Height = 28;
            this.dgvTarifas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarifas.Size = new System.Drawing.Size(736, 188);
            this.dgvTarifas.TabIndex = 60;
            this.dgvTarifas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTarifas_DataError);
            // 
            // id_tarifa
            // 
            this.id_tarifa.DataPropertyName = "id_tarifa";
            this.id_tarifa.HeaderText = "id_tarifa";
            this.id_tarifa.MinimumWidth = 6;
            this.id_tarifa.Name = "id_tarifa";
            this.id_tarifa.ReadOnly = true;
            this.id_tarifa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_tarifa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_tarifa.Visible = false;
            this.id_tarifa.Width = 125;
            // 
            // id_identificador
            // 
            this.id_identificador.DataPropertyName = "id_identificador";
            this.id_identificador.HeaderText = "id_identificador";
            this.id_identificador.MinimumWidth = 6;
            this.id_identificador.Name = "id_identificador";
            this.id_identificador.ReadOnly = true;
            this.id_identificador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_identificador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_identificador.Visible = false;
            this.id_identificador.Width = 125;
            // 
            // id_terminalXruta
            // 
            this.id_terminalXruta.DataPropertyName = "id_terminalXruta";
            this.id_terminalXruta.HeaderText = "id_terminalXruta";
            this.id_terminalXruta.MinimumWidth = 6;
            this.id_terminalXruta.Name = "id_terminalXruta";
            this.id_terminalXruta.ReadOnly = true;
            this.id_terminalXruta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_terminalXruta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_terminalXruta.Visible = false;
            this.id_terminalXruta.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre Viaje";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombre.Visible = false;
            this.nombre.Width = 125;
            // 
            // terminalOrigen
            // 
            this.terminalOrigen.DataPropertyName = "terminalOrigen";
            this.terminalOrigen.HeaderText = "Terminal Origen";
            this.terminalOrigen.MinimumWidth = 6;
            this.terminalOrigen.Name = "terminalOrigen";
            this.terminalOrigen.ReadOnly = true;
            this.terminalOrigen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.terminalOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.terminalOrigen.Width = 190;
            // 
            // terminalDestino
            // 
            this.terminalDestino.DataPropertyName = "terminalDestino";
            this.terminalDestino.HeaderText = "Terminal Destino";
            this.terminalDestino.MinimumWidth = 6;
            this.terminalDestino.Name = "terminalDestino";
            this.terminalDestino.ReadOnly = true;
            this.terminalDestino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.terminalDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.terminalDestino.Width = 190;
            // 
            // precioNormal1
            // 
            this.precioNormal1.DataPropertyName = "precioNormal1";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.precioNormal1.DefaultCellStyle = dataGridViewCellStyle2;
            this.precioNormal1.HeaderText = "Precio 1 Piso";
            this.precioNormal1.MinimumWidth = 6;
            this.precioNormal1.Name = "precioNormal1";
            this.precioNormal1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioNormal1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioNormal1.Width = 150;
            // 
            // precioEspecial1
            // 
            this.precioEspecial1.DataPropertyName = "precioEspecial1";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.precioEspecial1.DefaultCellStyle = dataGridViewCellStyle3;
            this.precioEspecial1.HeaderText = "Precio Especial 1 Piso";
            this.precioEspecial1.MinimumWidth = 6;
            this.precioEspecial1.Name = "precioEspecial1";
            this.precioEspecial1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioEspecial1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioEspecial1.Visible = false;
            this.precioEspecial1.Width = 125;
            // 
            // precioInfantil1
            // 
            this.precioInfantil1.DataPropertyName = "precioInfantil1";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.precioInfantil1.DefaultCellStyle = dataGridViewCellStyle4;
            this.precioInfantil1.HeaderText = "Precio Infantil 1 Piso";
            this.precioInfantil1.MinimumWidth = 6;
            this.precioInfantil1.Name = "precioInfantil1";
            this.precioInfantil1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioInfantil1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioInfantil1.Visible = false;
            this.precioInfantil1.Width = 125;
            // 
            // precioTerceraEdad1
            // 
            this.precioTerceraEdad1.DataPropertyName = "precioTerceraEdad1";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.precioTerceraEdad1.DefaultCellStyle = dataGridViewCellStyle5;
            this.precioTerceraEdad1.HeaderText = "Precio Tercera Edad 1 Piso";
            this.precioTerceraEdad1.MinimumWidth = 6;
            this.precioTerceraEdad1.Name = "precioTerceraEdad1";
            this.precioTerceraEdad1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioTerceraEdad1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioTerceraEdad1.Visible = false;
            this.precioTerceraEdad1.Width = 125;
            // 
            // precioNormal2
            // 
            this.precioNormal2.DataPropertyName = "precioNormal2";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.precioNormal2.DefaultCellStyle = dataGridViewCellStyle6;
            this.precioNormal2.HeaderText = "Precio 2 Piso";
            this.precioNormal2.MinimumWidth = 6;
            this.precioNormal2.Name = "precioNormal2";
            this.precioNormal2.Width = 150;
            // 
            // precioEspecial2
            // 
            this.precioEspecial2.DataPropertyName = "precioEspecial2";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.precioEspecial2.DefaultCellStyle = dataGridViewCellStyle7;
            this.precioEspecial2.HeaderText = "Precio Especial 2 Piso";
            this.precioEspecial2.MinimumWidth = 6;
            this.precioEspecial2.Name = "precioEspecial2";
            this.precioEspecial2.Visible = false;
            this.precioEspecial2.Width = 125;
            // 
            // precioInfantil2
            // 
            this.precioInfantil2.DataPropertyName = "precioInfantil2";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.precioInfantil2.DefaultCellStyle = dataGridViewCellStyle8;
            this.precioInfantil2.HeaderText = "Precio Infantil 2 Piso";
            this.precioInfantil2.MinimumWidth = 6;
            this.precioInfantil2.Name = "precioInfantil2";
            this.precioInfantil2.Visible = false;
            this.precioInfantil2.Width = 125;
            // 
            // precioTerceraEdad2
            // 
            this.precioTerceraEdad2.DataPropertyName = "precioTerceraEdad2";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0.00";
            this.precioTerceraEdad2.DefaultCellStyle = dataGridViewCellStyle9;
            this.precioTerceraEdad2.HeaderText = "Precio Tercera Edad 2 Piso";
            this.precioTerceraEdad2.MinimumWidth = 6;
            this.precioTerceraEdad2.Name = "precioTerceraEdad2";
            this.precioTerceraEdad2.Visible = false;
            this.precioTerceraEdad2.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialComboBox cmbViajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvTarifas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalXruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioNormal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioEspecial1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioInfantil1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTerceraEdad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioNormal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioEspecial2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioInfantil2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTerceraEdad2;
    }
}