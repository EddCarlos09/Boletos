namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmMaletas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaletas));
            this.panelBusqueda = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.chkFolio = new System.Windows.Forms.CheckBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtFolioVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaletas = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnBuscar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelBusqueda.BorderColor = System.Drawing.Color.Transparent;
            this.panelBusqueda.Controls.Add(this.label5);
            this.panelBusqueda.Controls.Add(this.label6);
            this.panelBusqueda.Controls.Add(this.dgvdatosboleto);
            this.panelBusqueda.Controls.Add(this.label4);
            this.panelBusqueda.Controls.Add(this.btnMaletas);
            this.panelBusqueda.Controls.Add(this.chkNombre);
            this.panelBusqueda.Controls.Add(this.btnSalir);
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
            this.panelBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBusqueda.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1344, 550);
            this.panelBusqueda.SizeLine = 3;
            this.panelBusqueda.SizeTitle = 20;
            this.panelBusqueda.TabIndex = 8;
            this.panelBusqueda.Title = "";
            this.panelBusqueda.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(1067, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Acciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(595, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 26);
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
            this.dgvdatosboleto.Location = new System.Drawing.Point(11, 202);
            this.dgvdatosboleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdatosboleto.Name = "dgvdatosboleto";
            this.dgvdatosboleto.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboleto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboleto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboleto.Size = new System.Drawing.Size(1320, 334);
            this.dgvdatosboleto.TabIndex = 10;
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
            this.id_boleto.Width = 69;
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
            this.id_ventadetalle.Width = 105;
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
            this.CodigoBarra.Width = 60;
            // 
            // viaje
            // 
            this.viaje.DataPropertyName = "nombreViaje";
            this.viaje.HeaderText = "Linea";
            this.viaje.MinimumWidth = 6;
            this.viaje.Name = "viaje";
            this.viaje.ReadOnly = true;
            this.viaje.Width = 89;
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
            this.Origen.Width = 77;
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
            this.Destino.Width = 84;
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
            this.fecha_salidaV.Width = 73;
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
            this.hora_salidaV.Width = 60;
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
            this.NombrePersona.Width = 87;
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
            this.asiento.Width = 84;
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
            this.cantidad_venta.Width = 105;
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
            this.boletocosto.Width = 73;
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
            this.vdcosto.Width = 48;
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
            this.iva.Width = 51;
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
            this.pago.Width = 64;
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
            this.pendiente.Width = 106;
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
            this.precio.Width = 52;
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
            this.id_venta.Width = 64;
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
            this.id_cliente.Width = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(233, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Búsqueda";
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Checked = true;
            this.chkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNombre.Location = new System.Drawing.Point(53, 130);
            this.chkNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(18, 17);
            this.chkNombre.TabIndex = 3;
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkFolio
            // 
            this.chkFolio.AutoSize = true;
            this.chkFolio.Checked = true;
            this.chkFolio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolio.Location = new System.Drawing.Point(53, 91);
            this.chkFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFolio.Name = "chkFolio";
            this.chkFolio.Size = new System.Drawing.Size(18, 17);
            this.chkFolio.TabIndex = 2;
            this.chkFolio.UseVisualStyleBackColor = true;
            this.chkFolio.CheckedChanged += new System.EventHandler(this.chkFolio_CheckedChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Checked = true;
            this.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFecha.Location = new System.Drawing.Point(53, 53);
            this.chkFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(18, 17);
            this.chkFecha.TabIndex = 1;
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(181, 118);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(348, 30);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // txtFolioVenta
            // 
            this.txtFolioVenta.Location = new System.Drawing.Point(181, 82);
            this.txtFolioVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFolioVenta.Name = "txtFolioVenta";
            this.txtFolioVenta.Size = new System.Drawing.Size(348, 30);
            this.txtFolioVenta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Folio:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(181, 52);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(219, 26);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // btnMaletas
            // 
            this.btnMaletas.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMaletas.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMaletas.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMaletas.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnMaletas.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnMaletas.FocusRectangle = true;
            this.btnMaletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnMaletas.Image = null;
            this.btnMaletas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaletas.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnMaletas.ImageFocused = null;
            this.btnMaletas.ImageInactive = null;
            this.btnMaletas.ImageMouseOver = null;
            this.btnMaletas.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._35aceptar;
            this.btnMaletas.ImagePressed = null;
            this.btnMaletas.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMaletas.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnMaletas.KeyButtonView = false;
            this.btnMaletas.Location = new System.Drawing.Point(1029, 66);
            this.btnMaletas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaletas.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnMaletas.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnMaletas.Name = "btnMaletas";
            this.btnMaletas.OffsetPressedContent = true;
            this.btnMaletas.Size = new System.Drawing.Size(107, 80);
            this.btnMaletas.TabIndex = 8;
            this.btnMaletas.Text = "Agregar";
            this.btnMaletas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaletas.TextDropShadow = true;
            this.btnMaletas.UseVisualStyleBackColor = false;
            this.btnMaletas.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnSalir.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.FocusRectangle = true;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
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
            this.btnSalir.Location = new System.Drawing.Point(1136, 66);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(107, 80);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnBuscar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.FocusRectangle = true;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
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
            this.btnBuscar.Location = new System.Drawing.Point(569, 63);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnBuscar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OffsetPressedContent = true;
            this.btnBuscar.Size = new System.Drawing.Size(107, 80);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextDropShadow = true;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmMaletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 550);
            this.Controls.Add(this.panelBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaletas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boletos";
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
        private LibControls.WinForms.Button_Creativa btnMaletas;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkFolio;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.DataGridView dgvdatosboleto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
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