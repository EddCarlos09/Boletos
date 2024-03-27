namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.panelBusqueda = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.chkFolioVenta = new System.Windows.Forms.CheckBox();
            this.txt_folioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvdatosboleto = new System.Windows.Forms.DataGridView();
            this.id_boleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ventadetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_salidaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salidaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boletocosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdcosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Ins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueoCancelacionMonedero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueoCancelacionPorFormaDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CambiarNombre = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnCancelarA = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnCancelarB = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnImprimir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.chkFolio = new System.Windows.Forms.CheckBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.txtFolioBoleto = new System.Windows.Forms.TextBox();
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
            this.panelBusqueda.Controls.Add(this.chkFolioVenta);
            this.panelBusqueda.Controls.Add(this.txt_folioVenta);
            this.panelBusqueda.Controls.Add(this.label7);
            this.panelBusqueda.Controls.Add(this.dgvdatosboleto);
            this.panelBusqueda.Controls.Add(this.label6);
            this.panelBusqueda.Controls.Add(this.label5);
            this.panelBusqueda.Controls.Add(this.label4);
            this.panelBusqueda.Controls.Add(this.btn_CambiarNombre);
            this.panelBusqueda.Controls.Add(this.btnCancelarA);
            this.panelBusqueda.Controls.Add(this.btnCancelarB);
            this.panelBusqueda.Controls.Add(this.btnSalir);
            this.panelBusqueda.Controls.Add(this.btnImprimir);
            this.panelBusqueda.Controls.Add(this.chkNombre);
            this.panelBusqueda.Controls.Add(this.chkFolio);
            this.panelBusqueda.Controls.Add(this.chkFecha);
            this.panelBusqueda.Controls.Add(this.label3);
            this.panelBusqueda.Controls.Add(this.txtNombreCliente);
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Controls.Add(this.txtFolioBoleto);
            this.panelBusqueda.Controls.Add(this.label2);
            this.panelBusqueda.Controls.Add(this.dtpFecha);
            this.panelBusqueda.Controls.Add(this.label1);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusqueda.DrawGradient = false;
            this.panelBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBusqueda.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1084, 436);
            this.panelBusqueda.SizeLine = 3;
            this.panelBusqueda.SizeTitle = 20;
            this.panelBusqueda.TabIndex = 8;
            this.panelBusqueda.Title = "";
            this.panelBusqueda.TitleColor = System.Drawing.Color.Transparent;
            // 
            // chkFolioVenta
            // 
            this.chkFolioVenta.AutoSize = true;
            this.chkFolioVenta.Checked = true;
            this.chkFolioVenta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolioVenta.Location = new System.Drawing.Point(7, 49);
            this.chkFolioVenta.Name = "chkFolioVenta";
            this.chkFolioVenta.Size = new System.Drawing.Size(15, 14);
            this.chkFolioVenta.TabIndex = 1;
            this.chkFolioVenta.UseVisualStyleBackColor = true;
            // 
            // txt_folioVenta
            // 
            this.txt_folioVenta.Location = new System.Drawing.Point(130, 42);
            this.txt_folioVenta.Name = "txt_folioVenta";
            this.txt_folioVenta.Size = new System.Drawing.Size(262, 26);
            this.txt_folioVenta.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Folio Venta:";
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
            this.folioVenta,
            this.CodigoBarra,
            this.Viaje,
            this.Origen,
            this.Destino,
            this.fecha_salidaV,
            this.hora_salidaV,
            this.NombrePersona,
            this.asiento,
            this.fechaNacimiento,
            this.numeroTelefono,
            this.cantidad_venta,
            this.boletocosto,
            this.vdcosto,
            this.iva,
            this.pago,
            this.pendiente,
            this.Transf,
            this.Usu_Ins,
            this.Usu_Mod,
            this.precio,
            this.id_venta,
            this.id_cliente,
            this.cajero,
            this.bloqueoCancelacionMonedero,
            this.bloqueoCancelacionPorFormaDePago});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdatosboleto.Location = new System.Drawing.Point(5, 173);
            this.dgvdatosboleto.MultiSelect = false;
            this.dgvdatosboleto.Name = "dgvdatosboleto";
            this.dgvdatosboleto.ReadOnly = true;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboleto.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboleto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboleto.Size = new System.Drawing.Size(1075, 260);
            this.dgvdatosboleto.TabIndex = 13;
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
            // folioVenta
            // 
            this.folioVenta.DataPropertyName = "folioVenta";
            this.folioVenta.HeaderText = "Folio Venta";
            this.folioVenta.Name = "folioVenta";
            this.folioVenta.ReadOnly = true;
            this.folioVenta.Width = 115;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.DataPropertyName = "CodigoBarra";
            this.CodigoBarra.HeaderText = "Folio Boleto";
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.ReadOnly = true;
            this.CodigoBarra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoBarra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoBarra.Width = 99;
            // 
            // Viaje
            // 
            this.Viaje.DataPropertyName = "nombreViaje";
            this.Viaje.HeaderText = "Línea";
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
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.asiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.asiento.HeaderText = "Asiento";
            this.asiento.Name = "asiento";
            this.asiento.ReadOnly = true;
            this.asiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.asiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.asiento.Width = 69;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            dataGridViewCellStyle3.Format = "d";
            this.fechaNacimiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaNacimiento.HeaderText = "Fecha_Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaNacimiento.Width = 167;
            // 
            // numeroTelefono
            // 
            this.numeroTelefono.DataPropertyName = "numeroTelefono";
            this.numeroTelefono.HeaderText = "Teléfono";
            this.numeroTelefono.Name = "numeroTelefono";
            this.numeroTelefono.ReadOnly = true;
            this.numeroTelefono.Width = 96;
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
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.boletocosto.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Format = "C2";
            this.vdcosto.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Format = "C2";
            this.iva.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Format = "C2";
            this.pago.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Format = "C2";
            this.pendiente.DefaultCellStyle = dataGridViewCellStyle8;
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.Name = "pendiente";
            this.pendiente.ReadOnly = true;
            this.pendiente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pendiente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pendiente.Width = 87;
            // 
            // Transf
            // 
            this.Transf.DataPropertyName = "Transf";
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.Transf.DefaultCellStyle = dataGridViewCellStyle9;
            this.Transf.HeaderText = "Transf";
            this.Transf.Name = "Transf";
            this.Transf.ReadOnly = true;
            this.Transf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Transf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Transf.Width = 60;
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
            // cajero
            // 
            this.cajero.DataPropertyName = "cajero";
            this.cajero.HeaderText = "cajero";
            this.cajero.Name = "cajero";
            this.cajero.ReadOnly = true;
            this.cajero.Visible = false;
            this.cajero.Width = 77;
            // 
            // bloqueoCancelacionMonedero
            // 
            this.bloqueoCancelacionMonedero.DataPropertyName = "bloqueoCancelacionMonedero";
            this.bloqueoCancelacionMonedero.HeaderText = "bloqueoCancelacionMonedero";
            this.bloqueoCancelacionMonedero.Name = "bloqueoCancelacionMonedero";
            this.bloqueoCancelacionMonedero.ReadOnly = true;
            this.bloqueoCancelacionMonedero.Visible = false;
            this.bloqueoCancelacionMonedero.Width = 250;
            // 
            // bloqueoCancelacionPorFormaDePago
            // 
            this.bloqueoCancelacionPorFormaDePago.DataPropertyName = "bloqueoCancelacionPorFormaDePago";
            this.bloqueoCancelacionPorFormaDePago.HeaderText = "bloqueoCancelacionPorFormaDePago";
            this.bloqueoCancelacionPorFormaDePago.Name = "bloqueoCancelacionPorFormaDePago";
            this.bloqueoCancelacionPorFormaDePago.ReadOnly = true;
            this.bloqueoCancelacionPorFormaDePago.Visible = false;
            this.bloqueoCancelacionPorFormaDePago.Width = 306;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(489, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Resultados Búsqueda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(814, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Acciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(197, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Búsqueda";
            // 
            // btn_CambiarNombre
            // 
            this.btn_CambiarNombre.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_CambiarNombre.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_CambiarNombre.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_CambiarNombre.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_CambiarNombre.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_CambiarNombre.FocusRectangle = true;
            this.btn_CambiarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CambiarNombre.Image = null;
            this.btn_CambiarNombre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CambiarNombre.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_CambiarNombre.ImageFocused = null;
            this.btn_CambiarNombre.ImageInactive = null;
            this.btn_CambiarNombre.ImageMouseOver = null;
            this.btn_CambiarNombre.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.cambiar;
            this.btn_CambiarNombre.ImagePressed = null;
            this.btn_CambiarNombre.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_CambiarNombre.KeyButton = System.Windows.Forms.Keys.F1;
            this.btn_CambiarNombre.KeyButtonView = false;
            this.btn_CambiarNombre.Location = new System.Drawing.Point(898, 66);
            this.btn_CambiarNombre.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_CambiarNombre.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_CambiarNombre.Name = "btn_CambiarNombre";
            this.btn_CambiarNombre.OffsetPressedContent = true;
            this.btn_CambiarNombre.Size = new System.Drawing.Size(80, 65);
            this.btn_CambiarNombre.TabIndex = 13;
            this.btn_CambiarNombre.Text = "Modificar";
            this.btn_CambiarNombre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CambiarNombre.TextDropShadow = true;
            this.btn_CambiarNombre.UseVisualStyleBackColor = false;
            this.btn_CambiarNombre.Click += new System.EventHandler(this.btn_CambiarNombre_Click);
            // 
            // btnCancelarA
            // 
            this.btnCancelarA.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelarA.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelarA.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelarA.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnCancelarA.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnCancelarA.FocusRectangle = true;
            this.btnCancelarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarA.Image = null;
            this.btnCancelarA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarA.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnCancelarA.ImageFocused = null;
            this.btnCancelarA.ImageInactive = null;
            this.btnCancelarA.ImageMouseOver = null;
            this.btnCancelarA.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.cancelacion_boletos;
            this.btnCancelarA.ImagePressed = null;
            this.btnCancelarA.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancelarA.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnCancelarA.KeyButtonView = false;
            this.btnCancelarA.Location = new System.Drawing.Point(658, 66);
            this.btnCancelarA.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancelarA.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCancelarA.Name = "btnCancelarA";
            this.btnCancelarA.OffsetPressedContent = true;
            this.btnCancelarA.Size = new System.Drawing.Size(80, 65);
            this.btnCancelarA.TabIndex = 10;
            this.btnCancelarA.Text = "Canc. A";
            this.btnCancelarA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarA.TextDropShadow = true;
            this.btnCancelarA.UseVisualStyleBackColor = false;
            this.btnCancelarA.Click += new System.EventHandler(this.btnCancelarA_Click);
            // 
            // btnCancelarB
            // 
            this.btnCancelarB.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelarB.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelarB.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancelarB.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnCancelarB.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnCancelarB.FocusRectangle = true;
            this.btnCancelarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarB.Image = null;
            this.btnCancelarB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarB.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnCancelarB.ImageFocused = null;
            this.btnCancelarB.ImageInactive = null;
            this.btnCancelarB.ImageMouseOver = null;
            this.btnCancelarB.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.cancelacion_boletos;
            this.btnCancelarB.ImagePressed = null;
            this.btnCancelarB.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancelarB.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnCancelarB.KeyButtonView = false;
            this.btnCancelarB.Location = new System.Drawing.Point(738, 66);
            this.btnCancelarB.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancelarB.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCancelarB.Name = "btnCancelarB";
            this.btnCancelarB.OffsetPressedContent = true;
            this.btnCancelarB.Size = new System.Drawing.Size(80, 65);
            this.btnCancelarB.TabIndex = 11;
            this.btnCancelarB.Text = "Canc. B";
            this.btnCancelarB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarB.TextDropShadow = true;
            this.btnCancelarB.UseVisualStyleBackColor = false;
            this.btnCancelarB.Click += new System.EventHandler(this.btnCancelarB_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnSalir.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.FocusRectangle = true;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSalir.Location = new System.Drawing.Point(979, 66);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(80, 65);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnImprimir.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnImprimir.KeyButtonView = false;
            this.btnImprimir.Location = new System.Drawing.Point(818, 66);
            this.btnImprimir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnImprimir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OffsetPressedContent = true;
            this.btnImprimir.Size = new System.Drawing.Size(80, 65);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Reimp";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextDropShadow = true;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Checked = true;
            this.chkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNombre.Location = new System.Drawing.Point(7, 138);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(15, 14);
            this.chkNombre.TabIndex = 4;
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkFolio
            // 
            this.chkFolio.AutoSize = true;
            this.chkFolio.Checked = true;
            this.chkFolio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolio.Location = new System.Drawing.Point(7, 106);
            this.chkFolio.Name = "chkFolio";
            this.chkFolio.Size = new System.Drawing.Size(15, 14);
            this.chkFolio.TabIndex = 3;
            this.chkFolio.UseVisualStyleBackColor = true;
            this.chkFolio.CheckedChanged += new System.EventHandler(this.chkFolio_CheckedChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Checked = true;
            this.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFecha.Location = new System.Drawing.Point(7, 76);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(15, 14);
            this.chkFecha.TabIndex = 2;
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(130, 128);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(262, 26);
            this.txtNombreCliente.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnBuscar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.FocusRectangle = true;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnBuscar.Location = new System.Drawing.Point(423, 66);
            this.btnBuscar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnBuscar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OffsetPressedContent = true;
            this.btnBuscar.Size = new System.Drawing.Size(80, 65);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextDropShadow = true;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFolioBoleto
            // 
            this.txtFolioBoleto.Location = new System.Drawing.Point(130, 99);
            this.txtFolioBoleto.Name = "txtFolioBoleto";
            this.txtFolioBoleto.Size = new System.Drawing.Size(262, 26);
            this.txtFolioBoleto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Folio Boleto:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(130, 74);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(165, 23);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1084, 436);
            this.ControlBox = true;
            this.Controls.Add(this.panelBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de Boletos";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmVentas_Load);
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
        private System.Windows.Forms.TextBox txtFolioBoleto;
        private LibControls.WinForms.Button_Creativa btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkFolio;
        private System.Windows.Forms.CheckBox chkFecha;
        private LibControls.WinForms.Button_Creativa btn_CambiarNombre;
        private LibControls.WinForms.Button_Creativa btnCancelarA;
        private LibControls.WinForms.Button_Creativa btnCancelarB;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private LibControls.WinForms.Button_Creativa btnImprimir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvdatosboleto;
        private System.Windows.Forms.CheckBox chkFolioVenta;
        private System.Windows.Forms.TextBox txt_folioVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_boleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ventadetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_salidaV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salidaV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn boletocosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdcosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Ins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloqueoCancelacionMonedero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloqueoCancelacionPorFormaDePago;
    }
}