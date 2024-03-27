namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmBusquedaCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaCambio));
            this.panelBusqueda = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dgvdatosboleto = new System.Windows.Forms.DataGridView();
            this.id_boleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ventadetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Usu_Ins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueoTransferencia24Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.chkFolio = new System.Windows.Forms.CheckBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.txtFolioVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelBusqueda.BorderColor = System.Drawing.Color.Transparent;
            this.panelBusqueda.Controls.Add(this.label6);
            this.panelBusqueda.Controls.Add(this.dgvdatosboleto);
            this.panelBusqueda.Controls.Add(this.label5);
            this.panelBusqueda.Controls.Add(this.btnAceptar);
            this.panelBusqueda.Controls.Add(this.label4);
            this.panelBusqueda.Controls.Add(this.btnSalir);
            this.panelBusqueda.Controls.Add(this.chkNombre);
            this.panelBusqueda.Controls.Add(this.chkFolio);
            this.panelBusqueda.Controls.Add(this.chkFecha);
            this.panelBusqueda.Controls.Add(this.label3);
            this.panelBusqueda.Controls.Add(this.txtNombreCliente);
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Controls.Add(this.txtFolioVenta);
            this.panelBusqueda.Controls.Add(this.label2);
            this.panelBusqueda.Controls.Add(this.dtpFecha);
            this.panelBusqueda.Controls.Add(this.label1);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusqueda.DrawGradient = false;
            this.panelBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBusqueda.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1008, 438);
            this.panelBusqueda.SizeLine = 3;
            this.panelBusqueda.SizeTitle = 20;
            this.panelBusqueda.TabIndex = 8;
            this.panelBusqueda.Title = "";
            this.panelBusqueda.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(462, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Resultados Búsqueda";
            // 
            // dgvdatosboleto
            // 
            this.dgvdatosboleto.AllowUserToAddRows = false;
            this.dgvdatosboleto.AllowUserToDeleteRows = false;
            this.dgvdatosboleto.AllowUserToResizeColumns = false;
            this.dgvdatosboleto.AllowUserToResizeRows = false;
            this.dgvdatosboleto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosboleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosboleto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_boleto,
            this.id_ventadetalle,
            this.CodigoBarra,
            this.Viaje,
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
            this.Usu_Ins,
            this.Usu_Mod,
            this.precio,
            this.id_venta,
            this.id_cliente,
            this.bloqueoTransferencia24Horas});
            this.dgvdatosboleto.Location = new System.Drawing.Point(13, 169);
            this.dgvdatosboleto.MultiSelect = false;
            this.dgvdatosboleto.Name = "dgvdatosboleto";
            this.dgvdatosboleto.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboleto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboleto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboleto.Size = new System.Drawing.Size(980, 258);
            this.dgvdatosboleto.TabIndex = 10;
            // 
            // id_boleto
            // 
            this.id_boleto.DataPropertyName = "id_boleto";
            this.id_boleto.HeaderText = "id_boleto";
            this.id_boleto.Name = "id_boleto";
            this.id_boleto.ReadOnly = true;
            this.id_boleto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_boleto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_boleto.Visible = false;
            this.id_boleto.Width = 80;
            // 
            // id_ventadetalle
            // 
            this.id_ventadetalle.DataPropertyName = "id_ventadetalle";
            this.id_ventadetalle.HeaderText = "id_ventadetalle";
            this.id_ventadetalle.Name = "id_ventadetalle";
            this.id_ventadetalle.ReadOnly = true;
            this.id_ventadetalle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_ventadetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_ventadetalle.Visible = false;
            this.id_ventadetalle.Width = 122;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.DataPropertyName = "CodigoBarra";
            this.CodigoBarra.HeaderText = "Folio";
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.ReadOnly = true;
            this.CodigoBarra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoBarra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoBarra.Width = 49;
            // 
            // Viaje
            // 
            this.Viaje.DataPropertyName = "nombreViaje";
            this.Viaje.HeaderText = "Linea";
            this.Viaje.Name = "Viaje";
            this.Viaje.ReadOnly = true;
            this.Viaje.Width = 73;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "Origen";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Origen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Origen.Width = 62;
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "Destino";
            this.Destino.FillWeight = 85F;
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Destino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Destino.Width = 70;
            // 
            // fecha_salidaV
            // 
            this.fecha_salidaV.DataPropertyName = "fecha_salidaV";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fecha_salidaV.DefaultCellStyle = dataGridViewCellStyle1;
            this.fecha_salidaV.HeaderText = "Fecha";
            this.fecha_salidaV.Name = "fecha_salidaV";
            this.fecha_salidaV.ReadOnly = true;
            this.fecha_salidaV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fecha_salidaV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fecha_salidaV.Width = 60;
            // 
            // hora_salidaV
            // 
            this.hora_salidaV.DataPropertyName = "hora_salidaV";
            this.hora_salidaV.HeaderText = "Hora";
            this.hora_salidaV.Name = "hora_salidaV";
            this.hora_salidaV.ReadOnly = true;
            this.hora_salidaV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hora_salidaV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hora_salidaV.Width = 50;
            // 
            // NombrePersona
            // 
            this.NombrePersona.DataPropertyName = "NombrePersona";
            this.NombrePersona.HeaderText = "Nombre";
            this.NombrePersona.Name = "NombrePersona";
            this.NombrePersona.ReadOnly = true;
            this.NombrePersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombrePersona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombrePersona.Width = 71;
            // 
            // asiento
            // 
            this.asiento.DataPropertyName = "asiento";
            this.asiento.HeaderText = "Asiento";
            this.asiento.Name = "asiento";
            this.asiento.ReadOnly = true;
            this.asiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.asiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.asiento.Width = 69;
            // 
            // cantidad_venta
            // 
            this.cantidad_venta.DataPropertyName = "cantidad_venta";
            this.cantidad_venta.HeaderText = "cantidad_venta";
            this.cantidad_venta.Name = "cantidad_venta";
            this.cantidad_venta.ReadOnly = true;
            this.cantidad_venta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidad_venta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidad_venta.Visible = false;
            this.cantidad_venta.Width = 124;
            // 
            // boletocosto
            // 
            this.boletocosto.DataPropertyName = "boletocosto";
            this.boletocosto.HeaderText = "Precio";
            this.boletocosto.Name = "boletocosto";
            this.boletocosto.ReadOnly = true;
            this.boletocosto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boletocosto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.boletocosto.Width = 59;
            // 
            // vdcosto
            // 
            this.vdcosto.DataPropertyName = "vdcosto";
            this.vdcosto.HeaderText = "Costo";
            this.vdcosto.Name = "vdcosto";
            this.vdcosto.ReadOnly = true;
            this.vdcosto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vdcosto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vdcosto.Visible = false;
            this.vdcosto.Width = 57;
            // 
            // iva
            // 
            this.iva.DataPropertyName = "iva";
            this.iva.HeaderText = "IVA";
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iva.Visible = false;
            this.iva.Width = 42;
            // 
            // pago
            // 
            this.pago.DataPropertyName = "pago";
            this.pago.HeaderText = "Pago";
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            this.pago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pago.Width = 52;
            // 
            // pendiente
            // 
            this.pendiente.DataPropertyName = "pendiente";
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.Name = "pendiente";
            this.pendiente.ReadOnly = true;
            this.pendiente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pendiente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pendiente.Width = 87;
            // 
            // Usu_Ins
            // 
            this.Usu_Ins.DataPropertyName = "usuins";
            this.Usu_Ins.HeaderText = "Usu_Ins";
            this.Usu_Ins.Name = "Usu_Ins";
            this.Usu_Ins.ReadOnly = true;
            this.Usu_Ins.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Usu_Ins.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Usu_Ins.Width = 75;
            // 
            // Usu_Mod
            // 
            this.Usu_Mod.DataPropertyName = "usuupd";
            this.Usu_Mod.HeaderText = "Usu_Mod";
            this.Usu_Mod.Name = "Usu_Mod";
            this.Usu_Mod.ReadOnly = true;
            this.Usu_Mod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Usu_Mod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Usu_Mod.Width = 84;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precio.Visible = false;
            this.precio.Width = 59;
            // 
            // id_venta
            // 
            this.id_venta.DataPropertyName = "id_venta";
            this.id_venta.HeaderText = "id_venta";
            this.id_venta.Name = "id_venta";
            this.id_venta.ReadOnly = true;
            this.id_venta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_venta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_venta.Visible = false;
            this.id_venta.Width = 75;
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "id_cliente";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.ReadOnly = true;
            this.id_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_cliente.Visible = false;
            this.id_cliente.Width = 82;
            // 
            // bloqueoTransferencia24Horas
            // 
            this.bloqueoTransferencia24Horas.DataPropertyName = "bloqueoTransferencia24Horas";
            this.bloqueoTransferencia24Horas.HeaderText = "bloqueoTransferencia24Horas";
            this.bloqueoTransferencia24Horas.Name = "bloqueoTransferencia24Horas";
            this.bloqueoTransferencia24Horas.ReadOnly = true;
            this.bloqueoTransferencia24Horas.Visible = false;
            this.bloqueoTransferencia24Horas.Width = 249;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(764, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Acciones";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAceptar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAceptar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnAceptar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnAceptar.FocusRectangle = true;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = null;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnAceptar.ImageFocused = null;
            this.btnAceptar.ImageInactive = null;
            this.btnAceptar.ImageMouseOver = null;
            this.btnAceptar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._35aceptar;
            this.btnAceptar.ImagePressed = null;
            this.btnAceptar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAceptar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnAceptar.KeyButtonView = false;
            this.btnAceptar.Location = new System.Drawing.Point(724, 46);
            this.btnAceptar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAceptar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.OffsetPressedContent = true;
            this.btnAceptar.Size = new System.Drawing.Size(80, 65);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.TextDropShadow = true;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(135, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Búsqueda";
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
            this.btnSalir.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._11salir;
            this.btnSalir.ImagePressed = null;
            this.btnSalir.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSalir.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnSalir.KeyButtonView = false;
            this.btnSalir.Location = new System.Drawing.Point(820, 46);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(80, 65);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Checked = true;
            this.chkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNombre.Location = new System.Drawing.Point(56, 109);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(15, 14);
            this.chkNombre.TabIndex = 3;
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkFolio
            // 
            this.chkFolio.AutoSize = true;
            this.chkFolio.Checked = true;
            this.chkFolio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolio.Location = new System.Drawing.Point(56, 77);
            this.chkFolio.Name = "chkFolio";
            this.chkFolio.Size = new System.Drawing.Size(15, 14);
            this.chkFolio.TabIndex = 2;
            this.chkFolio.UseVisualStyleBackColor = true;
            this.chkFolio.CheckedChanged += new System.EventHandler(this.chkFolio_CheckedChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Checked = true;
            this.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFecha.Location = new System.Drawing.Point(56, 46);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(15, 14);
            this.chkFecha.TabIndex = 1;
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(152, 99);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(262, 26);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnBuscar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.FocusRectangle = true;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnBuscar.ImageFocused = null;
            this.btnBuscar.ImageInactive = null;
            this.btnBuscar.ImageMouseOver = null;
            this.btnBuscar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._34busqueda;
            this.btnBuscar.ImagePressed = null;
            this.btnBuscar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBuscar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnBuscar.KeyButtonView = false;
            this.btnBuscar.Location = new System.Drawing.Point(429, 46);
            this.btnBuscar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnBuscar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OffsetPressedContent = true;
            this.btnBuscar.Size = new System.Drawing.Size(80, 65);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextDropShadow = true;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFolioVenta
            // 
            this.txtFolioVenta.Location = new System.Drawing.Point(152, 70);
            this.txtFolioVenta.Name = "txtFolioVenta";
            this.txtFolioVenta.Size = new System.Drawing.Size(262, 26);
            this.txtFolioVenta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Folio:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(152, 45);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(165, 23);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // frmBusquedaCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 438);
            this.Controls.Add(this.panelBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusquedaCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Boletos";
            this.TopMost = true;
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panelBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolioVenta;
        private LibControls.WinForms.Button_Creativa btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private LibControls.WinForms.Button_Creativa btnAceptar;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkFolio;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.DataGridView dgvdatosboleto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_boleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ventadetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viaje;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Ins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloqueoTransferencia24Horas;
    }
}