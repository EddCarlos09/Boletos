namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmVentasV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasV2));
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
            this.btnAdministrarFac = new MaterialSkin.Controls.MaterialCard();
            this.Facturarbtn = new System.Windows.Forms.Button();
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_CambiarNombre = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelarB = new System.Windows.Forms.Button();
            this.btnCancelarA = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFolioBoleto = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_folioVenta = new MaterialSkin.Controls.MaterialTextBox2();
            this.chkNombre = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkFolio = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkFecha = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkFolioVenta = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAdministrarFac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdministrarFac
            // 
            this.btnAdministrarFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdministrarFac.Controls.Add(this.Facturarbtn);
            this.btnAdministrarFac.Controls.Add(this.dgvdatosboleto);
            this.btnAdministrarFac.Controls.Add(this.dtpFecha);
            this.btnAdministrarFac.Controls.Add(this.materialLabel3);
            this.btnAdministrarFac.Controls.Add(this.btn_CambiarNombre);
            this.btnAdministrarFac.Controls.Add(this.btnImprimir);
            this.btnAdministrarFac.Controls.Add(this.btnCancelarB);
            this.btnAdministrarFac.Controls.Add(this.btnCancelarA);
            this.btnAdministrarFac.Controls.Add(this.materialLabel2);
            this.btnAdministrarFac.Controls.Add(this.btnBuscar);
            this.btnAdministrarFac.Controls.Add(this.txtNombreCliente);
            this.btnAdministrarFac.Controls.Add(this.txtFolioBoleto);
            this.btnAdministrarFac.Controls.Add(this.txt_folioVenta);
            this.btnAdministrarFac.Controls.Add(this.chkNombre);
            this.btnAdministrarFac.Controls.Add(this.chkFolio);
            this.btnAdministrarFac.Controls.Add(this.chkFecha);
            this.btnAdministrarFac.Controls.Add(this.chkFolioVenta);
            this.btnAdministrarFac.Controls.Add(this.materialLabel1);
            this.btnAdministrarFac.Depth = 0;
            this.btnAdministrarFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdministrarFac.Location = new System.Drawing.Point(16, 18);
            this.btnAdministrarFac.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.btnAdministrarFac.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdministrarFac.Name = "btnAdministrarFac";
            this.btnAdministrarFac.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.btnAdministrarFac.Size = new System.Drawing.Size(1221, 796);
            this.btnAdministrarFac.TabIndex = 0;
            // 
            // Facturarbtn
            // 
            this.Facturarbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Facturarbtn.Image = ((System.Drawing.Image)(resources.GetObject("Facturarbtn.Image")));
            this.Facturarbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Facturarbtn.Location = new System.Drawing.Point(892, 193);
            this.Facturarbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Facturarbtn.Name = "Facturarbtn";
            this.Facturarbtn.Size = new System.Drawing.Size(109, 94);
            this.Facturarbtn.TabIndex = 21;
            this.Facturarbtn.Text = "Facturar";
            this.Facturarbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Facturarbtn.UseVisualStyleBackColor = true;
            this.Facturarbtn.Click += new System.EventHandler(this.Facturarbtn_Click);
            // 
            // dgvdatosboleto
            // 
            this.dgvdatosboleto.AllowUserToAddRows = false;
            this.dgvdatosboleto.AllowUserToDeleteRows = false;
            this.dgvdatosboleto.AllowUserToResizeColumns = false;
            this.dgvdatosboleto.AllowUserToResizeRows = false;
            this.dgvdatosboleto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosboleto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdatosboleto.Location = new System.Drawing.Point(17, 386);
            this.dgvdatosboleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdatosboleto.MultiSelect = false;
            this.dgvdatosboleto.Name = "dgvdatosboleto";
            this.dgvdatosboleto.ReadOnly = true;
            this.dgvdatosboleto.RowHeadersWidth = 51;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboleto.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboleto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboleto.Size = new System.Drawing.Size(1176, 338);
            this.dgvdatosboleto.TabIndex = 20;
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
            this.id_boleto.Width = 80;
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
            this.id_ventadetalle.Width = 122;
            // 
            // folioVenta
            // 
            this.folioVenta.DataPropertyName = "folioVenta";
            this.folioVenta.HeaderText = "Folio Venta";
            this.folioVenta.MinimumWidth = 6;
            this.folioVenta.Name = "folioVenta";
            this.folioVenta.ReadOnly = true;
            this.folioVenta.Width = 104;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.DataPropertyName = "CodigoBarra";
            this.CodigoBarra.HeaderText = "Folio Boleto";
            this.CodigoBarra.MinimumWidth = 6;
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.ReadOnly = true;
            this.CodigoBarra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoBarra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoBarra.Width = 85;
            // 
            // Viaje
            // 
            this.Viaje.DataPropertyName = "nombreViaje";
            this.Viaje.HeaderText = "Línea";
            this.Viaje.MinimumWidth = 6;
            this.Viaje.Name = "Viaje";
            this.Viaje.ReadOnly = true;
            this.Viaje.Width = 69;
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
            this.Origen.Width = 53;
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "Destino";
            this.Destino.FillWeight = 85F;
            this.Destino.HeaderText = "Destino";
            this.Destino.MinimumWidth = 6;
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Destino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Destino.Width = 59;
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
            this.fecha_salidaV.Width = 51;
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
            this.hora_salidaV.Width = 43;
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
            this.NombrePersona.Width = 62;
            // 
            // asiento
            // 
            this.asiento.DataPropertyName = "asiento";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.asiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.asiento.HeaderText = "Asiento";
            this.asiento.MinimumWidth = 6;
            this.asiento.Name = "asiento";
            this.asiento.ReadOnly = true;
            this.asiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.asiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.asiento.Width = 58;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            dataGridViewCellStyle3.Format = "d";
            this.fechaNacimiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaNacimiento.HeaderText = "Fecha_Nacimiento";
            this.fechaNacimiento.MinimumWidth = 6;
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaNacimiento.Width = 149;
            // 
            // numeroTelefono
            // 
            this.numeroTelefono.DataPropertyName = "numeroTelefono";
            this.numeroTelefono.HeaderText = "Teléfono";
            this.numeroTelefono.MinimumWidth = 6;
            this.numeroTelefono.Name = "numeroTelefono";
            this.numeroTelefono.ReadOnly = true;
            this.numeroTelefono.Width = 90;
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
            this.cantidad_venta.Width = 124;
            // 
            // boletocosto
            // 
            this.boletocosto.DataPropertyName = "boletocosto";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.boletocosto.DefaultCellStyle = dataGridViewCellStyle4;
            this.boletocosto.HeaderText = "Precio";
            this.boletocosto.MinimumWidth = 6;
            this.boletocosto.Name = "boletocosto";
            this.boletocosto.ReadOnly = true;
            this.boletocosto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.boletocosto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.boletocosto.Width = 52;
            // 
            // vdcosto
            // 
            this.vdcosto.DataPropertyName = "vdcosto";
            dataGridViewCellStyle5.Format = "C2";
            this.vdcosto.DefaultCellStyle = dataGridViewCellStyle5;
            this.vdcosto.HeaderText = "Costo";
            this.vdcosto.MinimumWidth = 6;
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
            this.iva.MinimumWidth = 6;
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
            this.pago.MinimumWidth = 6;
            this.pago.Name = "pago";
            this.pago.ReadOnly = true;
            this.pago.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pago.Width = 46;
            // 
            // pendiente
            // 
            this.pendiente.DataPropertyName = "pendiente";
            dataGridViewCellStyle8.Format = "C2";
            this.pendiente.DefaultCellStyle = dataGridViewCellStyle8;
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.MinimumWidth = 6;
            this.pendiente.Name = "pendiente";
            this.pendiente.ReadOnly = true;
            this.pendiente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pendiente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pendiente.Width = 74;
            // 
            // Transf
            // 
            this.Transf.DataPropertyName = "Transf";
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.Transf.DefaultCellStyle = dataGridViewCellStyle9;
            this.Transf.HeaderText = "Transf";
            this.Transf.MinimumWidth = 6;
            this.Transf.Name = "Transf";
            this.Transf.ReadOnly = true;
            this.Transf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Transf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Transf.Width = 51;
            // 
            // Usu_Ins
            // 
            this.Usu_Ins.DataPropertyName = "usuins";
            this.Usu_Ins.HeaderText = "Usu_Ins";
            this.Usu_Ins.MinimumWidth = 6;
            this.Usu_Ins.Name = "Usu_Ins";
            this.Usu_Ins.ReadOnly = true;
            this.Usu_Ins.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Usu_Ins.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Usu_Ins.Width = 61;
            // 
            // Usu_Mod
            // 
            this.Usu_Mod.DataPropertyName = "usuupd";
            this.Usu_Mod.HeaderText = "Usu_Mod";
            this.Usu_Mod.MinimumWidth = 6;
            this.Usu_Mod.Name = "Usu_Mod";
            this.Usu_Mod.ReadOnly = true;
            this.Usu_Mod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Usu_Mod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Usu_Mod.Width = 71;
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
            this.precio.Width = 59;
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
            this.id_venta.Width = 75;
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
            this.id_cliente.Width = 82;
            // 
            // cajero
            // 
            this.cajero.DataPropertyName = "cajero";
            this.cajero.HeaderText = "cajero";
            this.cajero.MinimumWidth = 6;
            this.cajero.Name = "cajero";
            this.cajero.ReadOnly = true;
            this.cajero.Visible = false;
            this.cajero.Width = 77;
            // 
            // bloqueoCancelacionMonedero
            // 
            this.bloqueoCancelacionMonedero.DataPropertyName = "bloqueoCancelacionMonedero";
            this.bloqueoCancelacionMonedero.HeaderText = "bloqueoCancelacionMonedero";
            this.bloqueoCancelacionMonedero.MinimumWidth = 6;
            this.bloqueoCancelacionMonedero.Name = "bloqueoCancelacionMonedero";
            this.bloqueoCancelacionMonedero.ReadOnly = true;
            this.bloqueoCancelacionMonedero.Visible = false;
            this.bloqueoCancelacionMonedero.Width = 250;
            // 
            // bloqueoCancelacionPorFormaDePago
            // 
            this.bloqueoCancelacionPorFormaDePago.DataPropertyName = "bloqueoCancelacionPorFormaDePago";
            this.bloqueoCancelacionPorFormaDePago.HeaderText = "bloqueoCancelacionPorFormaDePago";
            this.bloqueoCancelacionPorFormaDePago.MinimumWidth = 6;
            this.bloqueoCancelacionPorFormaDePago.Name = "bloqueoCancelacionPorFormaDePago";
            this.bloqueoCancelacionPorFormaDePago.ReadOnly = true;
            this.bloqueoCancelacionPorFormaDePago.Visible = false;
            this.bloqueoCancelacionPorFormaDePago.Width = 306;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFecha.Location = new System.Drawing.Point(219, 140);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(249, 22);
            this.dtpFecha.TabIndex = 19;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged_1);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(57, 350);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(147, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Resultado Busqueda";
            // 
            // btn_CambiarNombre
            // 
            this.btn_CambiarNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CambiarNombre.Image = ((System.Drawing.Image)(resources.GetObject("btn_CambiarNombre.Image")));
            this.btn_CambiarNombre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CambiarNombre.Location = new System.Drawing.Point(745, 193);
            this.btn_CambiarNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CambiarNombre.Name = "btn_CambiarNombre";
            this.btn_CambiarNombre.Size = new System.Drawing.Size(109, 94);
            this.btn_CambiarNombre.TabIndex = 16;
            this.btn_CambiarNombre.Text = "Modificar";
            this.btn_CambiarNombre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CambiarNombre.UseVisualStyleBackColor = true;
            this.btn_CambiarNombre.Click += new System.EventHandler(this.btn_CambiarNombre_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(1033, 71);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(109, 94);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Reimp";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelarB
            // 
            this.btnCancelarB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelarB.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarB.Image")));
            this.btnCancelarB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarB.Location = new System.Drawing.Point(892, 71);
            this.btnCancelarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarB.Name = "btnCancelarB";
            this.btnCancelarB.Size = new System.Drawing.Size(109, 94);
            this.btnCancelarB.TabIndex = 13;
            this.btnCancelarB.Text = "Canc. B";
            this.btnCancelarB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarB.UseVisualStyleBackColor = true;
            this.btnCancelarB.Click += new System.EventHandler(this.btnCancelarB_Click);
            // 
            // btnCancelarA
            // 
            this.btnCancelarA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelarA.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarA.Image")));
            this.btnCancelarA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarA.Location = new System.Drawing.Point(745, 71);
            this.btnCancelarA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarA.Name = "btnCancelarA";
            this.btnCancelarA.Size = new System.Drawing.Size(109, 94);
            this.btnCancelarA.TabIndex = 12;
            this.btnCancelarA.Text = "Canc. A";
            this.btnCancelarA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarA.UseVisualStyleBackColor = true;
            this.btnCancelarA.Click += new System.EventHandler(this.btnCancelarA_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(917, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(65, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Acciones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(536, 114);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 94);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreCliente.AnimateReadOnly = false;
            this.txtNombreCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreCliente.Depth = 0;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCliente.HideSelection = true;
            this.txtNombreCliente.LeadingIcon = null;
            this.txtNombreCliente.Location = new System.Drawing.Point(219, 261);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtNombreCliente.Size = new System.Drawing.Size(251, 48);
            this.txtNombreCliente.TabIndex = 9;
            this.txtNombreCliente.TabStop = false;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCliente.TrailingIcon = null;
            this.txtNombreCliente.UseSystemPasswordChar = false;
            // 
            // txtFolioBoleto
            // 
            this.txtFolioBoleto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFolioBoleto.AnimateReadOnly = false;
            this.txtFolioBoleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFolioBoleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFolioBoleto.Depth = 0;
            this.txtFolioBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFolioBoleto.HideSelection = true;
            this.txtFolioBoleto.LeadingIcon = null;
            this.txtFolioBoleto.Location = new System.Drawing.Point(219, 193);
            this.txtFolioBoleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFolioBoleto.MaxLength = 32767;
            this.txtFolioBoleto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFolioBoleto.Name = "txtFolioBoleto";
            this.txtFolioBoleto.PasswordChar = '\0';
            this.txtFolioBoleto.PrefixSuffixText = null;
            this.txtFolioBoleto.ReadOnly = false;
            this.txtFolioBoleto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFolioBoleto.SelectedText = "";
            this.txtFolioBoleto.SelectionLength = 0;
            this.txtFolioBoleto.SelectionStart = 0;
            this.txtFolioBoleto.ShortcutsEnabled = true;
            this.txtFolioBoleto.Size = new System.Drawing.Size(251, 48);
            this.txtFolioBoleto.TabIndex = 8;
            this.txtFolioBoleto.TabStop = false;
            this.txtFolioBoleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFolioBoleto.TrailingIcon = null;
            this.txtFolioBoleto.UseSystemPasswordChar = false;
            // 
            // txt_folioVenta
            // 
            this.txt_folioVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_folioVenta.AnimateReadOnly = false;
            this.txt_folioVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_folioVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_folioVenta.Depth = 0;
            this.txt_folioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_folioVenta.HideSelection = true;
            this.txt_folioVenta.LeadingIcon = null;
            this.txt_folioVenta.Location = new System.Drawing.Point(219, 60);
            this.txt_folioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_folioVenta.MaxLength = 32767;
            this.txt_folioVenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_folioVenta.Name = "txt_folioVenta";
            this.txt_folioVenta.PasswordChar = '\0';
            this.txt_folioVenta.PrefixSuffixText = null;
            this.txt_folioVenta.ReadOnly = false;
            this.txt_folioVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_folioVenta.SelectedText = "";
            this.txt_folioVenta.SelectionLength = 0;
            this.txt_folioVenta.SelectionStart = 0;
            this.txt_folioVenta.ShortcutsEnabled = true;
            this.txt_folioVenta.Size = new System.Drawing.Size(251, 48);
            this.txt_folioVenta.TabIndex = 6;
            this.txt_folioVenta.TabStop = false;
            this.txt_folioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_folioVenta.TrailingIcon = null;
            this.txt_folioVenta.UseSystemPasswordChar = false;
            // 
            // chkNombre
            // 
            this.chkNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkNombre.AutoSize = true;
            this.chkNombre.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkNombre.Checked = true;
            this.chkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNombre.Depth = 0;
            this.chkNombre.Location = new System.Drawing.Point(36, 261);
            this.chkNombre.Margin = new System.Windows.Forms.Padding(0);
            this.chkNombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.ReadOnly = false;
            this.chkNombre.Ripple = true;
            this.chkNombre.Size = new System.Drawing.Size(95, 37);
            this.chkNombre.TabIndex = 5;
            this.chkNombre.Text = "Nombre:";
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkFolio
            // 
            this.chkFolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkFolio.AutoSize = true;
            this.chkFolio.Checked = true;
            this.chkFolio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolio.Depth = 0;
            this.chkFolio.Location = new System.Drawing.Point(36, 193);
            this.chkFolio.Margin = new System.Windows.Forms.Padding(0);
            this.chkFolio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFolio.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFolio.Name = "chkFolio";
            this.chkFolio.ReadOnly = false;
            this.chkFolio.Ripple = true;
            this.chkFolio.Size = new System.Drawing.Size(123, 37);
            this.chkFolio.TabIndex = 4;
            this.chkFolio.Text = "Folio Boleto:";
            this.chkFolio.UseVisualStyleBackColor = true;
            this.chkFolio.CheckedChanged += new System.EventHandler(this.chkFolio_CheckedChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkFecha.AutoSize = true;
            this.chkFecha.Checked = true;
            this.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFecha.Depth = 0;
            this.chkFecha.Location = new System.Drawing.Point(36, 126);
            this.chkFecha.Margin = new System.Windows.Forms.Padding(0);
            this.chkFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.ReadOnly = false;
            this.chkFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFecha.Ripple = true;
            this.chkFecha.Size = new System.Drawing.Size(82, 37);
            this.chkFecha.TabIndex = 3;
            this.chkFecha.Text = "Fecha:";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // chkFolioVenta
            // 
            this.chkFolioVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkFolioVenta.AutoSize = true;
            this.chkFolioVenta.Checked = true;
            this.chkFolioVenta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolioVenta.Depth = 0;
            this.chkFolioVenta.Location = new System.Drawing.Point(36, 60);
            this.chkFolioVenta.Margin = new System.Windows.Forms.Padding(0);
            this.chkFolioVenta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFolioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFolioVenta.Name = "chkFolioVenta";
            this.chkFolioVenta.ReadOnly = false;
            this.chkFolioVenta.Ripple = true;
            this.chkFolioVenta.Size = new System.Drawing.Size(119, 37);
            this.chkFolioVenta.TabIndex = 2;
            this.chkFolioVenta.Text = "Folio Venta:";
            this.chkFolioVenta.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(51, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Busqueda";
            // 
            // frmVentasV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 818);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdministrarFac);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVentasV2";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "frmVentasV2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVentasV2_Load);
            this.btnAdministrarFac.ResumeLayout(false);
            this.btnAdministrarFac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard btnAdministrarFac;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox chkNombre;
        private MaterialSkin.Controls.MaterialCheckbox chkFolio;
        private MaterialSkin.Controls.MaterialCheckbox chkFecha;
        private MaterialSkin.Controls.MaterialCheckbox chkFolioVenta;
        private MaterialSkin.Controls.MaterialTextBox2 txt_folioVenta;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreCliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtFolioBoleto;
        private System.Windows.Forms.Button btnBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Button btn_CambiarNombre;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelarB;
        private System.Windows.Forms.Button btnCancelarA;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvdatosboleto;
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
        private System.Windows.Forms.Button Facturarbtn;
    }
}