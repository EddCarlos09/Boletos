namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatMaletas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatMaletas));
            this.panelTitle_Creativa2 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.dgvdatosMaletas = new System.Windows.Forms.DataGridView();
            this.folio_Maleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_maleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_boleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.Txt_NumeroMaletas = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Salir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_asiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_origen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_linea = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_folioBoleto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnImprimir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.Txt_TotalMaletas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Agregar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnImprimirC = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosMaletas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle_Creativa2
            // 
            this.panelTitle_Creativa2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTitle_Creativa2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTitle_Creativa2.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa2.Controls.Add(this.btnImprimirC);
            this.panelTitle_Creativa2.Controls.Add(this.dgvdatosMaletas);
            this.panelTitle_Creativa2.Controls.Add(this.btnEliminar);
            this.panelTitle_Creativa2.Controls.Add(this.Txt_NumeroMaletas);
            this.panelTitle_Creativa2.Controls.Add(this.label17);
            this.panelTitle_Creativa2.Controls.Add(this.label16);
            this.panelTitle_Creativa2.Controls.Add(this.btn_Salir);
            this.panelTitle_Creativa2.Controls.Add(this.label15);
            this.panelTitle_Creativa2.Controls.Add(this.label10);
            this.panelTitle_Creativa2.Controls.Add(this.txt_asiento);
            this.panelTitle_Creativa2.Controls.Add(this.label1);
            this.panelTitle_Creativa2.Controls.Add(this.txt_precio);
            this.panelTitle_Creativa2.Controls.Add(this.label3);
            this.panelTitle_Creativa2.Controls.Add(this.txt_nombre);
            this.panelTitle_Creativa2.Controls.Add(this.label7);
            this.panelTitle_Creativa2.Controls.Add(this.txt_hora);
            this.panelTitle_Creativa2.Controls.Add(this.label6);
            this.panelTitle_Creativa2.Controls.Add(this.txt_fecha);
            this.panelTitle_Creativa2.Controls.Add(this.label5);
            this.panelTitle_Creativa2.Controls.Add(this.txt_destino);
            this.panelTitle_Creativa2.Controls.Add(this.label4);
            this.panelTitle_Creativa2.Controls.Add(this.txt_origen);
            this.panelTitle_Creativa2.Controls.Add(this.label11);
            this.panelTitle_Creativa2.Controls.Add(this.txt_linea);
            this.panelTitle_Creativa2.Controls.Add(this.label13);
            this.panelTitle_Creativa2.Controls.Add(this.txt_folioBoleto);
            this.panelTitle_Creativa2.Controls.Add(this.label14);
            this.panelTitle_Creativa2.Controls.Add(this.btnImprimir);
            this.panelTitle_Creativa2.Controls.Add(this.Txt_TotalMaletas);
            this.panelTitle_Creativa2.Controls.Add(this.label12);
            this.panelTitle_Creativa2.Controls.Add(this.btn_Agregar);
            this.panelTitle_Creativa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa2.DrawGradient = false;
            this.panelTitle_Creativa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa2.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa2.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa2.Name = "panelTitle_Creativa2";
            this.panelTitle_Creativa2.Size = new System.Drawing.Size(1019, 397);
            this.panelTitle_Creativa2.SizeLine = 3;
            this.panelTitle_Creativa2.SizeTitle = 20;
            this.panelTitle_Creativa2.TabIndex = 26;
            this.panelTitle_Creativa2.Title = "";
            this.panelTitle_Creativa2.TitleColor = System.Drawing.Color.Transparent;
            // 
            // dgvdatosMaletas
            // 
            this.dgvdatosMaletas.AllowUserToAddRows = false;
            this.dgvdatosMaletas.AllowUserToDeleteRows = false;
            this.dgvdatosMaletas.AllowUserToResizeColumns = false;
            this.dgvdatosMaletas.AllowUserToResizeRows = false;
            this.dgvdatosMaletas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosMaletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosMaletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folio_Maleta,
            this.descripcion,
            this.Cantidad,
            this.Precio,
            this.id_maleta,
            this.id_boleto});
            this.dgvdatosMaletas.Location = new System.Drawing.Point(378, 51);
            this.dgvdatosMaletas.Name = "dgvdatosMaletas";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosMaletas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatosMaletas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosMaletas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosMaletas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosMaletas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosMaletas.Size = new System.Drawing.Size(528, 254);
            this.dgvdatosMaletas.TabIndex = 10;
            // 
            // folio_Maleta
            // 
            this.folio_Maleta.DataPropertyName = "folioMaleta";
            this.folio_Maleta.HeaderText = "Folio";
            this.folio_Maleta.Name = "folio_Maleta";
            this.folio_Maleta.ReadOnly = true;
            this.folio_Maleta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.folio_Maleta.Width = 49;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descripcion.Width = 98;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "numeroMaletas";
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 53;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Precio.Width = 59;
            // 
            // id_maleta
            // 
            this.id_maleta.DataPropertyName = "id_maleta";
            this.id_maleta.HeaderText = "id_maleta";
            this.id_maleta.Name = "id_maleta";
            this.id_maleta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_maleta.Visible = false;
            this.id_maleta.Width = 84;
            // 
            // id_boleto
            // 
            this.id_boleto.DataPropertyName = "id_boleto";
            this.id_boleto.HeaderText = "id_boleto";
            this.id_boleto.Name = "id_boleto";
            this.id_boleto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_boleto.Visible = false;
            this.id_boleto.Width = 80;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEliminar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnEliminar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnEliminar.FocusRectangle = true;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnEliminar.ImageFocused = null;
            this.btnEliminar.ImageInactive = null;
            this.btnEliminar.ImageMouseOver = null;
            this.btnEliminar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._7eliminar;
            this.btnEliminar.ImagePressed = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEliminar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnEliminar.KeyButtonView = false;
            this.btnEliminar.Location = new System.Drawing.Point(925, 113);
            this.btnEliminar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEliminar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OffsetPressedContent = true;
            this.btnEliminar.Size = new System.Drawing.Size(80, 65);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextDropShadow = true;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Txt_NumeroMaletas
            // 
            this.Txt_NumeroMaletas.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Txt_NumeroMaletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumeroMaletas.ForeColor = System.Drawing.Color.Black;
            this.Txt_NumeroMaletas.Location = new System.Drawing.Point(378, 342);
            this.Txt_NumeroMaletas.MaxLength = 10;
            this.Txt_NumeroMaletas.Name = "Txt_NumeroMaletas";
            this.Txt_NumeroMaletas.ReadOnly = true;
            this.Txt_NumeroMaletas.Size = new System.Drawing.Size(261, 47);
            this.Txt_NumeroMaletas.TabIndex = 11;
            this.Txt_NumeroMaletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(456, 312);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 22);
            this.label17.TabIndex = 0;
            this.label17.Text = "Num. Maletas";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(921, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 21);
            this.label16.TabIndex = 155;
            this.label16.Text = "Acciones";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Salir.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Salir.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Salir.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Salir.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Salir.FocusRectangle = true;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Image = null;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Salir.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Salir.ImageFocused = null;
            this.btn_Salir.ImageInactive = null;
            this.btn_Salir.ImageMouseOver = null;
            this.btn_Salir.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.btn_Salir.ImagePressed = null;
            this.btn_Salir.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Salir.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Salir.KeyButtonView = false;
            this.btn_Salir.Location = new System.Drawing.Point(926, 306);
            this.btn_Salir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Salir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.OffsetPressedContent = true;
            this.btn_Salir.Size = new System.Drawing.Size(80, 65);
            this.btn_Salir.TabIndex = 16;
            this.btn_Salir.Text = "Cancelar";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Salir.TextDropShadow = true;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(586, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Datos Maletas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Asiento";
            // 
            // txt_asiento
            // 
            this.txt_asiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_asiento.Location = new System.Drawing.Point(91, 345);
            this.txt_asiento.MaxLength = 30;
            this.txt_asiento.Name = "txt_asiento";
            this.txt_asiento.ReadOnly = true;
            this.txt_asiento.Size = new System.Drawing.Size(270, 27);
            this.txt_asiento.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio";
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(91, 306);
            this.txt_precio.MaxLength = 30;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.ReadOnly = true;
            this.txt_precio.Size = new System.Drawing.Size(270, 27);
            this.txt_precio.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(91, 272);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(270, 27);
            this.txt_nombre.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hora";
            // 
            // txt_hora
            // 
            this.txt_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hora.Location = new System.Drawing.Point(91, 237);
            this.txt_hora.MaxLength = 30;
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.ReadOnly = true;
            this.txt_hora.Size = new System.Drawing.Size(270, 27);
            this.txt_hora.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(91, 202);
            this.txt_fecha.MaxLength = 30;
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(270, 27);
            this.txt_fecha.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Destino";
            // 
            // txt_destino
            // 
            this.txt_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_destino.Location = new System.Drawing.Point(91, 166);
            this.txt_destino.MaxLength = 30;
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.ReadOnly = true;
            this.txt_destino.Size = new System.Drawing.Size(270, 27);
            this.txt_destino.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Origen";
            // 
            // txt_origen
            // 
            this.txt_origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_origen.Location = new System.Drawing.Point(91, 129);
            this.txt_origen.MaxLength = 30;
            this.txt_origen.Name = "txt_origen";
            this.txt_origen.ReadOnly = true;
            this.txt_origen.Size = new System.Drawing.Size(270, 27);
            this.txt_origen.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Linea";
            // 
            // txt_linea
            // 
            this.txt_linea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_linea.Location = new System.Drawing.Point(91, 90);
            this.txt_linea.MaxLength = 30;
            this.txt_linea.Name = "txt_linea";
            this.txt_linea.ReadOnly = true;
            this.txt_linea.Size = new System.Drawing.Size(270, 27);
            this.txt_linea.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Folio";
            // 
            // txt_folioBoleto
            // 
            this.txt_folioBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_folioBoleto.Location = new System.Drawing.Point(91, 52);
            this.txt_folioBoleto.MaxLength = 30;
            this.txt_folioBoleto.Name = "txt_folioBoleto";
            this.txt_folioBoleto.ReadOnly = true;
            this.txt_folioBoleto.Size = new System.Drawing.Size(270, 27);
            this.txt_folioBoleto.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(121, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Datos Boletos";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnImprimir.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImprimir.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImprimir.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnImprimir.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnImprimir.FocusRectangle = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = null;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnImprimir.ImageFocused = null;
            this.btnImprimir.ImageInactive = null;
            this.btnImprimir.ImageMouseOver = null;
            this.btnImprimir.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.imprimir;
            this.btnImprimir.ImagePressed = null;
            this.btnImprimir.ImageSize = new System.Drawing.Size(40, 40);
            this.btnImprimir.KeyButton = System.Windows.Forms.Keys.None;
            this.btnImprimir.KeyButtonView = false;
            this.btnImprimir.Location = new System.Drawing.Point(926, 178);
            this.btnImprimir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnImprimir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OffsetPressedContent = true;
            this.btnImprimir.Size = new System.Drawing.Size(80, 65);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextDropShadow = true;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Txt_TotalMaletas
            // 
            this.Txt_TotalMaletas.BackColor = System.Drawing.Color.RoyalBlue;
            this.Txt_TotalMaletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalMaletas.ForeColor = System.Drawing.Color.Black;
            this.Txt_TotalMaletas.Location = new System.Drawing.Point(645, 342);
            this.Txt_TotalMaletas.MaxLength = 10;
            this.Txt_TotalMaletas.Name = "Txt_TotalMaletas";
            this.Txt_TotalMaletas.ReadOnly = true;
            this.Txt_TotalMaletas.Size = new System.Drawing.Size(261, 47);
            this.Txt_TotalMaletas.TabIndex = 12;
            this.Txt_TotalMaletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_TotalMaletas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PrecioMaleta_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(743, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Agregar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Agregar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Agregar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Agregar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Agregar.FocusRectangle = true;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Image = null;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Agregar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Agregar.ImageFocused = null;
            this.btn_Agregar.ImageInactive = null;
            this.btn_Agregar.ImageMouseOver = null;
            this.btn_Agregar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.btn_Agregar.ImagePressed = null;
            this.btn_Agregar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Agregar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Agregar.KeyButtonView = false;
            this.btn_Agregar.Location = new System.Drawing.Point(925, 49);
            this.btn_Agregar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Agregar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.OffsetPressedContent = true;
            this.btn_Agregar.Size = new System.Drawing.Size(80, 65);
            this.btn_Agregar.TabIndex = 13;
            this.btn_Agregar.Text = "Nuevo";
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Agregar.TextDropShadow = true;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btnImprimirC
            // 
            this.btnImprimirC.BackColor = System.Drawing.Color.SkyBlue;
            this.btnImprimirC.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImprimirC.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImprimirC.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnImprimirC.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnImprimirC.FocusRectangle = true;
            this.btnImprimirC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirC.Image = null;
            this.btnImprimirC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimirC.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnImprimirC.ImageFocused = null;
            this.btnImprimirC.ImageInactive = null;
            this.btnImprimirC.ImageMouseOver = null;
            this.btnImprimirC.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.imprimir;
            this.btnImprimirC.ImagePressed = null;
            this.btnImprimirC.ImageSize = new System.Drawing.Size(40, 40);
            this.btnImprimirC.KeyButton = System.Windows.Forms.Keys.None;
            this.btnImprimirC.KeyButtonView = false;
            this.btnImprimirC.Location = new System.Drawing.Point(926, 242);
            this.btnImprimirC.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnImprimirC.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnImprimirC.Name = "btnImprimirC";
            this.btnImprimirC.OffsetPressedContent = true;
            this.btnImprimirC.Size = new System.Drawing.Size(80, 65);
            this.btnImprimirC.TabIndex = 156;
            this.btnImprimirC.Text = "Imprimir C";
            this.btnImprimirC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirC.TextDropShadow = true;
            this.btnImprimirC.UseVisualStyleBackColor = false;
            this.btnImprimirC.Click += new System.EventHandler(this.BtnImprimirC_Click);
            // 
            // frmCatMaletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 397);
            this.Controls.Add(this.panelTitle_Creativa2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatMaletas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maletas Detalles";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCatMaletas_Load);
            this.panelTitle_Creativa2.ResumeLayout(false);
            this.panelTitle_Creativa2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosMaletas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa2;
        private LibControls.WinForms.Button_Creativa btn_Agregar;
        private System.Windows.Forms.TextBox Txt_TotalMaletas;
        private System.Windows.Forms.Label label12;
        private LibControls.WinForms.Button_Creativa btnImprimir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_asiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_origen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_linea;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_folioBoleto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private LibControls.WinForms.Button_Creativa btn_Salir;
        private System.Windows.Forms.TextBox Txt_NumeroMaletas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private LibControls.WinForms.Button_Creativa btnEliminar;
        private System.Windows.Forms.DataGridView dgvdatosMaletas;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio_Maleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_maleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_boleto;
        private LibControls.WinForms.Button_Creativa btnImprimirC;
    }
}