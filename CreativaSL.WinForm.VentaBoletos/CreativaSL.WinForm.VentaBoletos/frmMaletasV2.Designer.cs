namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmMaletasV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaletasV2));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgvdatosboleto = new System.Windows.Forms.DataGridView();
            this.id_boleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ventadetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_salidaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salidaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boletocosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdcosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFolioVenta = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.chkNombre = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkFolio = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkFecha = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvdatosboleto);
            this.materialCard1.Controls.Add(this.btnAceptar);
            this.materialCard1.Controls.Add(this.btnBuscar);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.txtNombreCliente);
            this.materialCard1.Controls.Add(this.txtFolioVenta);
            this.materialCard1.Controls.Add(this.dtpFecha);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.chkNombre);
            this.materialCard1.Controls.Add(this.chkFolio);
            this.materialCard1.Controls.Add(this.chkFecha);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(1, 9);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.Size = new System.Drawing.Size(1060, 462);
            this.materialCard1.TabIndex = 0;
            // 
            // dgvdatosboleto
            // 
            this.dgvdatosboleto.AllowUserToAddRows = false;
            this.dgvdatosboleto.AllowUserToDeleteRows = false;
            this.dgvdatosboleto.AllowUserToResizeColumns = false;
            this.dgvdatosboleto.AllowUserToResizeRows = false;
            this.dgvdatosboleto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdatosboleto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosboleto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdatosboleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatosboleto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvdatosboleto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdatosboleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosboleto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_boleto,
            this.id_ventadetalle,
            this.CodigoBarra,
            this.viaje,
            this.Origen,
            this.Destino,
            this.fecha_salidaV,
            this.hora_salidaV,
            this.NombrePersona,
            this.asiento,
            this.cantidad_venta,
            this.boletocosto,
            this.vdcosto,
            this.iva,
            this.pago,
            this.pendiente,
            this.precio,
            this.id_venta,
            this.id_cliente});
            this.dgvdatosboleto.Location = new System.Drawing.Point(393, 117);
            this.dgvdatosboleto.Name = "dgvdatosboleto";
            this.dgvdatosboleto.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboleto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboleto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboleto.Size = new System.Drawing.Size(653, 325);
            this.dgvdatosboleto.TabIndex = 23;
            // 
            // id_boleto
            // 
            this.id_boleto.DataPropertyName = "id_boleto";
            this.id_boleto.HeaderText = "id_boleto";
            this.id_boleto.MinimumWidth = 6;
            this.id_boleto.Name = "id_boleto";
            this.id_boleto.ReadOnly = true;
            this.id_boleto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_boleto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_boleto.Visible = false;
            // 
            // id_ventadetalle
            // 
            this.id_ventadetalle.DataPropertyName = "id_ventadetalle";
            this.id_ventadetalle.HeaderText = "id_ventadetalle";
            this.id_ventadetalle.MinimumWidth = 6;
            this.id_ventadetalle.Name = "id_ventadetalle";
            this.id_ventadetalle.ReadOnly = true;
            this.id_ventadetalle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_ventadetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_ventadetalle.Visible = false;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.DataPropertyName = "CodigoBarra";
            this.CodigoBarra.HeaderText = "Folio";
            this.CodigoBarra.MinimumWidth = 6;
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.ReadOnly = true;
            this.CodigoBarra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoBarra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoBarra.Width = 35;
            // 
            // viaje
            // 
            this.viaje.DataPropertyName = "nombreViaje";
            this.viaje.HeaderText = "Linea";
            this.viaje.MinimumWidth = 6;
            this.viaje.Name = "viaje";
            this.viaje.ReadOnly = true;
            this.viaje.Width = 58;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "Origen";
            this.Origen.HeaderText = "Origen";
            this.Origen.MinimumWidth = 6;
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Origen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Origen.Width = 44;
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "Destino";
            this.Destino.HeaderText = "Destino";
            this.Destino.MinimumWidth = 6;
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Destino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Destino.Width = 49;
            // 
            // fecha_salidaV
            // 
            this.fecha_salidaV.DataPropertyName = "fecha_salidaV";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fecha_salidaV.DefaultCellStyle = dataGridViewCellStyle1;
            this.fecha_salidaV.HeaderText = "Fecha";
            this.fecha_salidaV.MinimumWidth = 6;
            this.fecha_salidaV.Name = "fecha_salidaV";
            this.fecha_salidaV.ReadOnly = true;
            this.fecha_salidaV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fecha_salidaV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fecha_salidaV.Width = 43;
            // 
            // hora_salidaV
            // 
            this.hora_salidaV.DataPropertyName = "hora_salidaV";
            this.hora_salidaV.HeaderText = "Hora";
            this.hora_salidaV.MinimumWidth = 6;
            this.hora_salidaV.Name = "hora_salidaV";
            this.hora_salidaV.ReadOnly = true;
            this.hora_salidaV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hora_salidaV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hora_salidaV.Width = 36;
            // 
            // NombrePersona
            // 
            this.NombrePersona.DataPropertyName = "NombrePersona";
            this.NombrePersona.HeaderText = "Nombre";
            this.NombrePersona.MinimumWidth = 6;
            this.NombrePersona.Name = "NombrePersona";
            this.NombrePersona.ReadOnly = true;
            this.NombrePersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombrePersona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombrePersona.Width = 50;
            // 
            // asiento
            // 
            this.asiento.DataPropertyName = "asiento";
            this.asiento.HeaderText = "Asiento";
            this.asiento.MinimumWidth = 6;
            this.asiento.Name = "asiento";
            this.asiento.ReadOnly = true;
            this.asiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.asiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.asiento.Width = 48;
            // 
            // cantidad_venta
            // 
            this.cantidad_venta.DataPropertyName = "cantidad_venta";
            this.cantidad_venta.HeaderText = "cantidad_venta";
            this.cantidad_venta.MinimumWidth = 6;
            this.cantidad_venta.Name = "cantidad_venta";
            this.cantidad_venta.ReadOnly = true;
            this.cantidad_venta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidad_venta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidad_venta.Visible = false;
            // 
            // boletocosto
            // 
            this.boletocosto.DataPropertyName = "boletocosto";
            this.boletocosto.HeaderText = "Precio";
            this.boletocosto.MinimumWidth = 6;
            this.boletocosto.Name = "boletocosto";
            this.boletocosto.ReadOnly = true;
            this.boletocosto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boletocosto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.boletocosto.Width = 43;
            // 
            // vdcosto
            // 
            this.vdcosto.DataPropertyName = "vdcosto";
            this.vdcosto.HeaderText = "Costo";
            this.vdcosto.MinimumWidth = 6;
            this.vdcosto.Name = "vdcosto";
            this.vdcosto.ReadOnly = true;
            this.vdcosto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vdcosto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vdcosto.Visible = false;
            // 
            // iva
            // 
            this.iva.DataPropertyName = "iva";
            this.iva.HeaderText = "IVA";
            this.iva.MinimumWidth = 6;
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iva.Width = 30;
            // 
            // pago
            // 
            this.pago.DataPropertyName = "pago";
            this.pago.HeaderText = "Pago";
            this.pago.MinimumWidth = 6;
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            this.pago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pago.Width = 38;
            // 
            // pendiente
            // 
            this.pendiente.DataPropertyName = "pendiente";
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.MinimumWidth = 6;
            this.pendiente.Name = "pendiente";
            this.pendiente.ReadOnly = true;
            this.pendiente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pendiente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pendiente.Width = 61;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precio.Visible = false;
            // 
            // id_venta
            // 
            this.id_venta.DataPropertyName = "id_venta";
            this.id_venta.HeaderText = "id_venta";
            this.id_venta.MinimumWidth = 6;
            this.id_venta.Name = "id_venta";
            this.id_venta.ReadOnly = true;
            this.id_venta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_venta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_venta.Visible = false;
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.MinimumWidth = 6;
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_cliente.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(208, 271);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 76);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(75, 271);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 76);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(650, 30);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(147, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Resultado Búsqueda";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.AnimateReadOnly = false;
            this.txtNombreCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreCliente.Depth = 0;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCliente.HideSelection = true;
            this.txtNombreCliente.LeadingIcon = null;
            this.txtNombreCliente.Location = new System.Drawing.Point(143, 204);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCliente.MaxLength = 32767;
            this.txtNombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.PasswordChar = '\0';
            this.txtNombreCliente.PrefixSuffixText = null;
            this.txtNombreCliente.ReadOnly = false;
            this.txtNombreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreCliente.SelectedText = "";
            this.txtNombreCliente.SelectionLength = 0;
            this.txtNombreCliente.SelectionStart = 0;
            this.txtNombreCliente.ShortcutsEnabled = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(168, 48);
            this.txtNombreCliente.TabIndex = 6;
            this.txtNombreCliente.TabStop = false;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCliente.TrailingIcon = null;
            this.txtNombreCliente.UseSystemPasswordChar = false;
            // 
            // txtFolioVenta
            // 
            this.txtFolioVenta.AnimateReadOnly = false;
            this.txtFolioVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFolioVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFolioVenta.Depth = 0;
            this.txtFolioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFolioVenta.HideSelection = true;
            this.txtFolioVenta.LeadingIcon = null;
            this.txtFolioVenta.Location = new System.Drawing.Point(143, 128);
            this.txtFolioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtFolioVenta.MaxLength = 32767;
            this.txtFolioVenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFolioVenta.Name = "txtFolioVenta";
            this.txtFolioVenta.PasswordChar = '\0';
            this.txtFolioVenta.PrefixSuffixText = null;
            this.txtFolioVenta.ReadOnly = false;
            this.txtFolioVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFolioVenta.SelectedText = "";
            this.txtFolioVenta.SelectionLength = 0;
            this.txtFolioVenta.SelectionStart = 0;
            this.txtFolioVenta.ShortcutsEnabled = true;
            this.txtFolioVenta.Size = new System.Drawing.Size(168, 48);
            this.txtFolioVenta.TabIndex = 5;
            this.txtFolioVenta.TabStop = false;
            this.txtFolioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFolioVenta.TrailingIcon = null;
            this.txtFolioVenta.UseSystemPasswordChar = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(143, 70);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(167, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(194, 23);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Busqueda";
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Checked = true;
            this.chkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNombre.Depth = 0;
            this.chkNombre.Location = new System.Drawing.Point(47, 213);
            this.chkNombre.Margin = new System.Windows.Forms.Padding(0);
            this.chkNombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.ReadOnly = false;
            this.chkNombre.Ripple = true;
            this.chkNombre.Size = new System.Drawing.Size(91, 37);
            this.chkNombre.TabIndex = 2;
            this.chkNombre.Text = "Nombre";
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkFolio
            // 
            this.chkFolio.AutoSize = true;
            this.chkFolio.Checked = true;
            this.chkFolio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolio.Depth = 0;
            this.chkFolio.Location = new System.Drawing.Point(47, 137);
            this.chkFolio.Margin = new System.Windows.Forms.Padding(0);
            this.chkFolio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFolio.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFolio.Name = "chkFolio";
            this.chkFolio.ReadOnly = false;
            this.chkFolio.Ripple = true;
            this.chkFolio.Size = new System.Drawing.Size(70, 37);
            this.chkFolio.TabIndex = 1;
            this.chkFolio.Text = "Folio";
            this.chkFolio.UseVisualStyleBackColor = true;
            this.chkFolio.CheckedChanged += new System.EventHandler(this.chkFolio_CheckedChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Checked = true;
            this.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFecha.Depth = 0;
            this.chkFecha.Location = new System.Drawing.Point(47, 67);
            this.chkFecha.Margin = new System.Windows.Forms.Padding(0);
            this.chkFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.ReadOnly = false;
            this.chkFecha.Ripple = true;
            this.chkFecha.Size = new System.Drawing.Size(78, 37);
            this.chkFecha.TabIndex = 0;
            this.chkFecha.Text = "Fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // frmMaletasV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 457);
            this.ControlBox = false;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMaletasV2";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "frmMaletasV2";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCheckbox chkFecha;
        private MaterialSkin.Controls.MaterialCheckbox chkNombre;
        private MaterialSkin.Controls.MaterialCheckbox chkFolio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreCliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtFolioVenta;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvdatosboleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_boleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ventadetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_salidaV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salidaV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn boletocosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdcosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
    }
}