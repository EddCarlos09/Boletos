namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatRutas));
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.txtTiempo2 = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdTerminal = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnDelTerminal = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnAddTerminal = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.lblGrid = new System.Windows.Forms.TextBox();
            this.dgv_Rutasinter = new System.Windows.Forms.DataGridView();
            this.id_ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipoTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_terminalOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_terminalDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_minutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btnGuardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnCancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rutasinter)).BeginInit();
            this.panel_Creativa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa1.Controls.Add(this.label8);
            this.panelTitle_Creativa1.Controls.Add(this.txt_mensaje);
            this.panelTitle_Creativa1.Controls.Add(this.txtTiempo2);
            this.panelTitle_Creativa1.Controls.Add(this.btnUpdTerminal);
            this.panelTitle_Creativa1.Controls.Add(this.btnDelTerminal);
            this.panelTitle_Creativa1.Controls.Add(this.btnAddTerminal);
            this.panelTitle_Creativa1.Controls.Add(this.lblGrid);
            this.panelTitle_Creativa1.Controls.Add(this.dgv_Rutasinter);
            this.panelTitle_Creativa1.Controls.Add(this.label3);
            this.panelTitle_Creativa1.Controls.Add(this.cmbDestino);
            this.panelTitle_Creativa1.Controls.Add(this.label2);
            this.panelTitle_Creativa1.Controls.Add(this.label1);
            this.panelTitle_Creativa1.Controls.Add(this.cmbOrigen);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.DrawGradient = false;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(754, 633);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 0;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(346, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rutas";
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(96, 509);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(496, 32);
            this.txt_mensaje.TabIndex = 0;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mensaje.Visible = false;
            // 
            // txtTiempo2
            // 
            this.txtTiempo2.Location = new System.Drawing.Point(169, 126);
            this.txtTiempo2.Mask = "00:00";
            this.txtTiempo2.Name = "txtTiempo2";
            this.txtTiempo2.PromptChar = '0';
            this.txtTiempo2.Size = new System.Drawing.Size(83, 26);
            this.txtTiempo2.TabIndex = 3;
            this.txtTiempo2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtTiempo2.ValidatingType = typeof(System.DateTime);
            // 
            // btnUpdTerminal
            // 
            this.btnUpdTerminal.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdTerminal.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdTerminal.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdTerminal.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnUpdTerminal.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnUpdTerminal.FocusRectangle = true;
            this.btnUpdTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdTerminal.Image = null;
            this.btnUpdTerminal.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnUpdTerminal.ImageFocused = null;
            this.btnUpdTerminal.ImageInactive = null;
            this.btnUpdTerminal.ImageMouseOver = null;
            this.btnUpdTerminal.ImageNormal = null;
            this.btnUpdTerminal.ImagePressed = null;
            this.btnUpdTerminal.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUpdTerminal.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnUpdTerminal.KeyButtonView = false;
            this.btnUpdTerminal.Location = new System.Drawing.Point(684, 323);
            this.btnUpdTerminal.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnUpdTerminal.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnUpdTerminal.Name = "btnUpdTerminal";
            this.btnUpdTerminal.OffsetPressedContent = true;
            this.btnUpdTerminal.Size = new System.Drawing.Size(54, 47);
            this.btnUpdTerminal.TabIndex = 7;
            this.btnUpdTerminal.Text = "/";
            this.btnUpdTerminal.TextDropShadow = true;
            this.btnUpdTerminal.UseVisualStyleBackColor = false;
            this.btnUpdTerminal.Click += new System.EventHandler(this.btnUpdTerminal_Click);
            // 
            // btnDelTerminal
            // 
            this.btnDelTerminal.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelTerminal.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelTerminal.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelTerminal.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnDelTerminal.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnDelTerminal.FocusRectangle = true;
            this.btnDelTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTerminal.Image = null;
            this.btnDelTerminal.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnDelTerminal.ImageFocused = null;
            this.btnDelTerminal.ImageInactive = null;
            this.btnDelTerminal.ImageMouseOver = null;
            this.btnDelTerminal.ImageNormal = null;
            this.btnDelTerminal.ImagePressed = null;
            this.btnDelTerminal.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDelTerminal.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnDelTerminal.KeyButtonView = false;
            this.btnDelTerminal.Location = new System.Drawing.Point(684, 270);
            this.btnDelTerminal.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDelTerminal.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnDelTerminal.Name = "btnDelTerminal";
            this.btnDelTerminal.OffsetPressedContent = true;
            this.btnDelTerminal.Size = new System.Drawing.Size(54, 47);
            this.btnDelTerminal.TabIndex = 6;
            this.btnDelTerminal.Text = "-";
            this.btnDelTerminal.TextDropShadow = true;
            this.btnDelTerminal.UseVisualStyleBackColor = false;
            this.btnDelTerminal.Click += new System.EventHandler(this.btnDelTerminal_Click);
            // 
            // btnAddTerminal
            // 
            this.btnAddTerminal.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddTerminal.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddTerminal.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddTerminal.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnAddTerminal.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnAddTerminal.FocusRectangle = true;
            this.btnAddTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTerminal.Image = null;
            this.btnAddTerminal.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnAddTerminal.ImageFocused = null;
            this.btnAddTerminal.ImageInactive = null;
            this.btnAddTerminal.ImageMouseOver = null;
            this.btnAddTerminal.ImageNormal = null;
            this.btnAddTerminal.ImagePressed = null;
            this.btnAddTerminal.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddTerminal.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnAddTerminal.KeyButtonView = false;
            this.btnAddTerminal.Location = new System.Drawing.Point(684, 217);
            this.btnAddTerminal.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddTerminal.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnAddTerminal.Name = "btnAddTerminal";
            this.btnAddTerminal.OffsetPressedContent = true;
            this.btnAddTerminal.Size = new System.Drawing.Size(54, 47);
            this.btnAddTerminal.TabIndex = 5;
            this.btnAddTerminal.Text = "+";
            this.btnAddTerminal.TextDropShadow = true;
            this.btnAddTerminal.UseVisualStyleBackColor = false;
            this.btnAddTerminal.Click += new System.EventHandler(this.btnAddTerminal_Click);
            // 
            // lblGrid
            // 
            this.lblGrid.BackColor = System.Drawing.Color.SteelBlue;
            this.lblGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGrid.ForeColor = System.Drawing.Color.White;
            this.lblGrid.Location = new System.Drawing.Point(12, 171);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.ReadOnly = true;
            this.lblGrid.Size = new System.Drawing.Size(725, 19);
            this.lblGrid.TabIndex = 0;
            this.lblGrid.TabStop = false;
            this.lblGrid.Text = "TERMINALES INTERMEDIAS";
            this.lblGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_Rutasinter
            // 
            this.dgv_Rutasinter.AllowUserToAddRows = false;
            this.dgv_Rutasinter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rutasinter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ruta,
            this.id_tipoTerminal,
            this.id_terminalOrigen,
            this.id_terminalDestino,
            this.terminalOrigen,
            this.terminalDestino,
            this.tiempo,
            this.tiempo_minutos});
            this.dgv_Rutasinter.Location = new System.Drawing.Point(12, 196);
            this.dgv_Rutasinter.MultiSelect = false;
            this.dgv_Rutasinter.Name = "dgv_Rutasinter";
            this.dgv_Rutasinter.ReadOnly = true;
            this.dgv_Rutasinter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Rutasinter.Size = new System.Drawing.Size(663, 301);
            this.dgv_Rutasinter.TabIndex = 4;
            // 
            // id_ruta
            // 
            this.id_ruta.DataPropertyName = "id_ruta";
            this.id_ruta.HeaderText = "id_ruta";
            this.id_ruta.Name = "id_ruta";
            this.id_ruta.ReadOnly = true;
            this.id_ruta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_ruta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_ruta.Visible = false;
            // 
            // id_tipoTerminal
            // 
            this.id_tipoTerminal.DataPropertyName = "id_tipoTerminal";
            this.id_tipoTerminal.HeaderText = "id_tipoTerminal";
            this.id_tipoTerminal.Name = "id_tipoTerminal";
            this.id_tipoTerminal.ReadOnly = true;
            this.id_tipoTerminal.Visible = false;
            // 
            // id_terminalOrigen
            // 
            this.id_terminalOrigen.DataPropertyName = "id_terminalOrigen";
            this.id_terminalOrigen.HeaderText = "id_terminalOrigen";
            this.id_terminalOrigen.Name = "id_terminalOrigen";
            this.id_terminalOrigen.ReadOnly = true;
            this.id_terminalOrigen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_terminalOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_terminalOrigen.Visible = false;
            // 
            // id_terminalDestino
            // 
            this.id_terminalDestino.DataPropertyName = "id_terminalDestino";
            this.id_terminalDestino.HeaderText = "id_terminalDestino";
            this.id_terminalDestino.Name = "id_terminalDestino";
            this.id_terminalDestino.ReadOnly = true;
            this.id_terminalDestino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_terminalDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_terminalDestino.Visible = false;
            // 
            // terminalOrigen
            // 
            this.terminalOrigen.DataPropertyName = "terminalOrigen";
            this.terminalOrigen.HeaderText = "Terminal Origen";
            this.terminalOrigen.Name = "terminalOrigen";
            this.terminalOrigen.ReadOnly = true;
            this.terminalOrigen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.terminalOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.terminalOrigen.Width = 220;
            // 
            // terminalDestino
            // 
            this.terminalDestino.DataPropertyName = "terminalDestino";
            this.terminalDestino.HeaderText = "Terminal Destino";
            this.terminalDestino.Name = "terminalDestino";
            this.terminalDestino.ReadOnly = true;
            this.terminalDestino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.terminalDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.terminalDestino.Width = 220;
            // 
            // tiempo
            // 
            this.tiempo.DataPropertyName = "tiempo";
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            this.tiempo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tiempo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tiempo.Width = 180;
            // 
            // tiempo_minutos
            // 
            this.tiempo_minutos.DataPropertyName = "tiempo_minutos";
            this.tiempo_minutos.HeaderText = "tiempo_minutos";
            this.tiempo_minutos.Name = "tiempo_minutos";
            this.tiempo_minutos.ReadOnly = true;
            this.tiempo_minutos.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(51, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiempo Viaje";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(173, 82);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(564, 28);
            this.cmbDestino.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Terminal Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terminal Origen";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(173, 45);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(564, 28);
            this.cmbOrigen.TabIndex = 1;
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.btnGuardar);
            this.panel_Creativa1.Controls.Add(this.btnCancelar);
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 547);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(754, 85);
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
            this.btnGuardar.Location = new System.Drawing.Point(568, 10);
            this.btnGuardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGuardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OffsetPressedContent = true;
            this.btnGuardar.Size = new System.Drawing.Size(80, 65);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextDropShadow = true;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnCancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnCancelar.FocusRectangle = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.ImageFocused = null;
            this.btnCancelar.ImageInactive = null;
            this.btnCancelar.ImageMouseOver = null;
            this.btnCancelar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.btnCancelar.ImagePressed = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancelar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnCancelar.KeyButtonView = false;
            this.btnCancelar.Location = new System.Drawing.Point(658, 10);
            this.btnCancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OffsetPressedContent = true;
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextDropShadow = true;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCatRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(754, 633);
            this.ControlBox = true;
            this.Controls.Add(this.panel_Creativa1);
            this.Controls.Add(this.panelTitle_Creativa1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmCatRutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutas";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmRutas_Load);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rutasinter)).EndInit();
            this.panel_Creativa1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Rutasinter;
        private System.Windows.Forms.TextBox lblGrid;
        private LibControls.WinForms.Button_Creativa btnUpdTerminal;
        private LibControls.WinForms.Button_Creativa btnDelTerminal;
        private LibControls.WinForms.Button_Creativa btnAddTerminal;
        private LibControls.WinForms.Button_Creativa btnGuardar;
        private LibControls.WinForms.Button_Creativa btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipoTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_minutos;
        private System.Windows.Forms.MaskedTextBox txtTiempo2;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.Label label8;
    }
}