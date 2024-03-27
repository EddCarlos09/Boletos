namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatTarifas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatTarifas));
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btnGuardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.cmbViajes = new System.Windows.Forms.ComboBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Creativa1.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.btnGuardar);
            this.panel_Creativa1.Controls.Add(this.btnSalir);
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 305);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(760, 85);
            this.panel_Creativa1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnGuardar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.FocusRectangle = true;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnGuardar.ImageFocused = null;
            this.btnGuardar.ImageInactive = null;
            this.btnGuardar.ImageMouseOver = null;
            this.btnGuardar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.btnGuardar.ImagePressed = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGuardar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnGuardar.KeyButtonView = false;
            this.btnGuardar.Location = new System.Drawing.Point(569, 10);
            this.btnGuardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGuardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OffsetPressedContent = true;
            this.btnGuardar.Size = new System.Drawing.Size(80, 65);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextDropShadow = true;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnSalir.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.FocusRectangle = true;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = null;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnSalir.ImageFocused = null;
            this.btnSalir.ImageInactive = null;
            this.btnSalir.ImageMouseOver = null;
            this.btnSalir.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.btnSalir.ImagePressed = null;
            this.btnSalir.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSalir.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnSalir.KeyButtonView = false;
            this.btnSalir.Location = new System.Drawing.Point(666, 10);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(80, 65);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa1.Controls.Add(this.label10);
            this.panelTitle_Creativa1.Controls.Add(this.panel_Creativa1);
            this.panelTitle_Creativa1.Controls.Add(this.txtPiso);
            this.panelTitle_Creativa1.Controls.Add(this.cmbViajes);
            this.panelTitle_Creativa1.Controls.Add(this.dgvTarifas);
            this.panelTitle_Creativa1.Controls.Add(this.label4);
            this.panelTitle_Creativa1.DrawGradient = false;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(760, 400);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(344, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tarifas";
            // 
            // txtPiso
            // 
            this.txtPiso.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiso.ForeColor = System.Drawing.Color.White;
            this.txtPiso.Location = new System.Drawing.Point(24, 82);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.ReadOnly = true;
            this.txtPiso.Size = new System.Drawing.Size(716, 19);
            this.txtPiso.TabIndex = 0;
            this.txtPiso.TabStop = false;
            this.txtPiso.Text = "Terminales Destino";
            this.txtPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbViajes
            // 
            this.cmbViajes.FormattingEnabled = true;
            this.cmbViajes.Location = new System.Drawing.Point(191, 43);
            this.cmbViajes.Name = "cmbViajes";
            this.cmbViajes.Size = new System.Drawing.Size(482, 28);
            this.cmbViajes.TabIndex = 1;
            this.cmbViajes.SelectedIndexChanged += new System.EventHandler(this.cmbViajes_SelectedIndexChanged);
            this.cmbViajes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbViajes_KeyPress);
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.AllowUserToAddRows = false;
            this.dgvTarifas.AllowUserToDeleteRows = false;
            this.dgvTarifas.AllowUserToResizeColumns = false;
            this.dgvTarifas.AllowUserToResizeRows = false;
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
            this.dgvTarifas.Location = new System.Drawing.Point(12, 111);
            this.dgvTarifas.MultiSelect = false;
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarifas.Size = new System.Drawing.Size(736, 188);
            this.dgvTarifas.TabIndex = 2;
            this.dgvTarifas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTarifas_DataError);
            // 
            // id_tarifa
            // 
            this.id_tarifa.DataPropertyName = "id_tarifa";
            this.id_tarifa.HeaderText = "id_tarifa";
            this.id_tarifa.Name = "id_tarifa";
            this.id_tarifa.ReadOnly = true;
            this.id_tarifa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_tarifa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_tarifa.Visible = false;
            // 
            // id_identificador
            // 
            this.id_identificador.DataPropertyName = "id_identificador";
            this.id_identificador.HeaderText = "id_identificador";
            this.id_identificador.Name = "id_identificador";
            this.id_identificador.ReadOnly = true;
            this.id_identificador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_identificador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_identificador.Visible = false;
            // 
            // id_terminalXruta
            // 
            this.id_terminalXruta.DataPropertyName = "id_terminalXruta";
            this.id_terminalXruta.HeaderText = "id_terminalXruta";
            this.id_terminalXruta.Name = "id_terminalXruta";
            this.id_terminalXruta.ReadOnly = true;
            this.id_terminalXruta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_terminalXruta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_terminalXruta.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre Viaje";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombre.Visible = false;
            // 
            // terminalOrigen
            // 
            this.terminalOrigen.DataPropertyName = "terminalOrigen";
            this.terminalOrigen.HeaderText = "Terminal Origen";
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
            this.terminalDestino.Name = "terminalDestino";
            this.terminalDestino.ReadOnly = true;
            this.terminalDestino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.terminalDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.terminalDestino.Width = 190;
            // 
            // precioNormal1
            // 
            this.precioNormal1.DataPropertyName = "precioNormal1";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.precioNormal1.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioNormal1.HeaderText = "Precio 1 Piso";
            this.precioNormal1.Name = "precioNormal1";
            this.precioNormal1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioNormal1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioNormal1.Width = 150;
            // 
            // precioEspecial1
            // 
            this.precioEspecial1.DataPropertyName = "precioEspecial1";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.precioEspecial1.DefaultCellStyle = dataGridViewCellStyle2;
            this.precioEspecial1.HeaderText = "Precio Especial 1 Piso";
            this.precioEspecial1.Name = "precioEspecial1";
            this.precioEspecial1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioEspecial1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioEspecial1.Visible = false;
            // 
            // precioInfantil1
            // 
            this.precioInfantil1.DataPropertyName = "precioInfantil1";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.precioInfantil1.DefaultCellStyle = dataGridViewCellStyle3;
            this.precioInfantil1.HeaderText = "Precio Infantil 1 Piso";
            this.precioInfantil1.Name = "precioInfantil1";
            this.precioInfantil1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioInfantil1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioInfantil1.Visible = false;
            // 
            // precioTerceraEdad1
            // 
            this.precioTerceraEdad1.DataPropertyName = "precioTerceraEdad1";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.precioTerceraEdad1.DefaultCellStyle = dataGridViewCellStyle4;
            this.precioTerceraEdad1.HeaderText = "Precio Tercera Edad 1 Piso";
            this.precioTerceraEdad1.Name = "precioTerceraEdad1";
            this.precioTerceraEdad1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioTerceraEdad1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioTerceraEdad1.Visible = false;
            // 
            // precioNormal2
            // 
            this.precioNormal2.DataPropertyName = "precioNormal2";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.precioNormal2.DefaultCellStyle = dataGridViewCellStyle5;
            this.precioNormal2.HeaderText = "Precio 2 Piso";
            this.precioNormal2.Name = "precioNormal2";
            this.precioNormal2.Width = 150;
            // 
            // precioEspecial2
            // 
            this.precioEspecial2.DataPropertyName = "precioEspecial2";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.precioEspecial2.DefaultCellStyle = dataGridViewCellStyle6;
            this.precioEspecial2.HeaderText = "Precio Especial 2 Piso";
            this.precioEspecial2.Name = "precioEspecial2";
            this.precioEspecial2.Visible = false;
            // 
            // precioInfantil2
            // 
            this.precioInfantil2.DataPropertyName = "precioInfantil2";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.precioInfantil2.DefaultCellStyle = dataGridViewCellStyle7;
            this.precioInfantil2.HeaderText = "Precio Infantil 2 Piso";
            this.precioInfantil2.Name = "precioInfantil2";
            this.precioInfantil2.Visible = false;
            // 
            // precioTerceraEdad2
            // 
            this.precioTerceraEdad2.DataPropertyName = "precioTerceraEdad2";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.precioTerceraEdad2.DefaultCellStyle = dataGridViewCellStyle8;
            this.precioTerceraEdad2.HeaderText = "Precio Tercera Edad 2 Piso";
            this.precioTerceraEdad2.Name = "precioTerceraEdad2";
            this.precioTerceraEdad2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(72, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre Viaje";
            // 
            // frmCatTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 392);
            this.ControlBox = true;
            this.Controls.Add(this.panelTitle_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmCatTarifas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifas";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmCatSalidas_Load);
            this.panel_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btnGuardar;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbViajes;
        private System.Windows.Forms.DataGridView dgvTarifas;
        private System.Windows.Forms.TextBox txtPiso;
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
        private System.Windows.Forms.Label label10;
    }
}