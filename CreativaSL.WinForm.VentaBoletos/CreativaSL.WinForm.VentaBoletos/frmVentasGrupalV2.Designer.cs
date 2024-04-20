namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmVentasGrupalV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasGrupalV2));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgvdatosboleto = new System.Windows.Forms.DataGridView();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobroCancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retornoCancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Ins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueoCancelacionMonedero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueoCancelacionPorFormaDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDStatusCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDStatusPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroBoletos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPagoEfectivo = new System.Windows.Forms.Button();
            this.btnCancelarA = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFolioBoleto = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.materialCard1.Controls.Add(this.dtpFecha);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.btnSalir);
            this.materialCard1.Controls.Add(this.btnPagoEfectivo);
            this.materialCard1.Controls.Add(this.btnCancelarA);
            this.materialCard1.Controls.Add(this.btnBuscar);
            this.materialCard1.Controls.Add(this.txtNombreCliente);
            this.materialCard1.Controls.Add(this.txtFolioBoleto);
            this.materialCard1.Controls.Add(this.chkNombre);
            this.materialCard1.Controls.Add(this.chkFolio);
            this.materialCard1.Controls.Add(this.chkFecha);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 19);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1250, 763);
            this.materialCard1.TabIndex = 0;
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
            this.folio,
            this.fechaVenta,
            this.nombre,
            this.numeroTelefono,
            this.fechaNacimiento,
            this.total,
            this.cobroCancelacion,
            this.retornoCancelacion,
            this.pendiente,
            this.status,
            this.Usu_Ins,
            this.Usu_Mod,
            this.bloqueoCancelacionMonedero,
            this.id_venta,
            this.bloqueoCancelacionPorFormaDePago,
            this.IDStatusCobro,
            this.IDStatusPago,
            this.numeroBoletos});
            this.dgvdatosboleto.Location = new System.Drawing.Point(22, 335);
            this.dgvdatosboleto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdatosboleto.MultiSelect = false;
            this.dgvdatosboleto.Name = "dgvdatosboleto";
            this.dgvdatosboleto.ReadOnly = true;
            this.dgvdatosboleto.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboleto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboleto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboleto.Size = new System.Drawing.Size(1167, 334);
            this.dgvdatosboleto.TabIndex = 44;
            // 
            // folio
            // 
            this.folio.DataPropertyName = "folio";
            this.folio.HeaderText = "Folio";
            this.folio.MinimumWidth = 6;
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            this.folio.Width = 66;
            // 
            // fechaVenta
            // 
            this.fechaVenta.DataPropertyName = "fec_venta";
            this.fechaVenta.HeaderText = "Fecha_Venta";
            this.fechaVenta.MinimumWidth = 6;
            this.fechaVenta.Name = "fechaVenta";
            this.fechaVenta.ReadOnly = true;
            this.fechaVenta.Width = 116;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 85;
            // 
            // numeroTelefono
            // 
            this.numeroTelefono.DataPropertyName = "numeroTelefono";
            this.numeroTelefono.HeaderText = "Número_Teléfono";
            this.numeroTelefono.MinimumWidth = 6;
            this.numeroTelefono.Name = "numeroTelefono";
            this.numeroTelefono.ReadOnly = true;
            this.numeroTelefono.Width = 145;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha_Nacimiento";
            this.fechaNacimiento.MinimumWidth = 6;
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Width = 149;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle1;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 67;
            // 
            // cobroCancelacion
            // 
            this.cobroCancelacion.DataPropertyName = "cobroCancelacion";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "C2";
            this.cobroCancelacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.cobroCancelacion.HeaderText = "Cobro_Canc.";
            this.cobroCancelacion.MinimumWidth = 6;
            this.cobroCancelacion.Name = "cobroCancelacion";
            this.cobroCancelacion.ReadOnly = true;
            this.cobroCancelacion.Width = 114;
            // 
            // retornoCancelacion
            // 
            this.retornoCancelacion.DataPropertyName = "retornoCancelacion";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "C2";
            this.retornoCancelacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.retornoCancelacion.HeaderText = "Retorno_Canc.";
            this.retornoCancelacion.MinimumWidth = 6;
            this.retornoCancelacion.Name = "retornoCancelacion";
            this.retornoCancelacion.ReadOnly = true;
            this.retornoCancelacion.Visible = false;
            this.retornoCancelacion.Width = 142;
            // 
            // pendiente
            // 
            this.pendiente.DataPropertyName = "pendiente";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.pendiente.DefaultCellStyle = dataGridViewCellStyle4;
            this.pendiente.HeaderText = "Pendiente";
            this.pendiente.MinimumWidth = 6;
            this.pendiente.Name = "pendiente";
            this.pendiente.ReadOnly = true;
            this.pendiente.Width = 97;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Estatus";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 80;
            // 
            // Usu_Ins
            // 
            this.Usu_Ins.DataPropertyName = "usuins";
            this.Usu_Ins.HeaderText = "Usu_Ins";
            this.Usu_Ins.MinimumWidth = 6;
            this.Usu_Ins.Name = "Usu_Ins";
            this.Usu_Ins.ReadOnly = true;
            this.Usu_Ins.Width = 84;
            // 
            // Usu_Mod
            // 
            this.Usu_Mod.DataPropertyName = "usuupd";
            this.Usu_Mod.HeaderText = "Usu_Mod";
            this.Usu_Mod.MinimumWidth = 6;
            this.Usu_Mod.Name = "Usu_Mod";
            this.Usu_Mod.ReadOnly = true;
            this.Usu_Mod.Width = 94;
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
            // id_venta
            // 
            this.id_venta.DataPropertyName = "id_venta";
            this.id_venta.HeaderText = "id_venta";
            this.id_venta.MinimumWidth = 6;
            this.id_venta.Name = "id_venta";
            this.id_venta.ReadOnly = true;
            this.id_venta.Visible = false;
            this.id_venta.Width = 94;
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
            // IDStatusCobro
            // 
            this.IDStatusCobro.DataPropertyName = "IDStatusCobro";
            this.IDStatusCobro.HeaderText = "IDStatusCobro";
            this.IDStatusCobro.MinimumWidth = 6;
            this.IDStatusCobro.Name = "IDStatusCobro";
            this.IDStatusCobro.ReadOnly = true;
            this.IDStatusCobro.Visible = false;
            this.IDStatusCobro.Width = 141;
            // 
            // IDStatusPago
            // 
            this.IDStatusPago.DataPropertyName = "IDStatusPago";
            this.IDStatusPago.HeaderText = "IDStatusPago";
            this.IDStatusPago.MinimumWidth = 6;
            this.IDStatusPago.Name = "IDStatusPago";
            this.IDStatusPago.ReadOnly = true;
            this.IDStatusPago.Visible = false;
            this.IDStatusPago.Width = 135;
            // 
            // numeroBoletos
            // 
            this.numeroBoletos.DataPropertyName = "numeroBoletos";
            this.numeroBoletos.HeaderText = "Núm. Boletos";
            this.numeroBoletos.MinimumWidth = 6;
            this.numeroBoletos.Name = "numeroBoletos";
            this.numeroBoletos.ReadOnly = true;
            this.numeroBoletos.Width = 116;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(188, 21);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 43;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(66, 307);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(147, 19);
            this.materialLabel3.TabIndex = 42;
            this.materialLabel3.Text = "Resultado Busqueda";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(1000, 25);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 94);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPagoEfectivo
            // 
            this.btnPagoEfectivo.Image = ((System.Drawing.Image)(resources.GetObject("btnPagoEfectivo.Image")));
            this.btnPagoEfectivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagoEfectivo.Location = new System.Drawing.Point(858, 25);
            this.btnPagoEfectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagoEfectivo.Name = "btnPagoEfectivo";
            this.btnPagoEfectivo.Size = new System.Drawing.Size(109, 94);
            this.btnPagoEfectivo.TabIndex = 40;
            this.btnPagoEfectivo.Text = "Pago Efec";
            this.btnPagoEfectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagoEfectivo.UseVisualStyleBackColor = true;
            this.btnPagoEfectivo.Click += new System.EventHandler(this.btnPagoEfectivo_Click);
            // 
            // btnCancelarA
            // 
            this.btnCancelarA.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarA.Image")));
            this.btnCancelarA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarA.Location = new System.Drawing.Point(718, 25);
            this.btnCancelarA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarA.Name = "btnCancelarA";
            this.btnCancelarA.Size = new System.Drawing.Size(109, 94);
            this.btnCancelarA.TabIndex = 39;
            this.btnCancelarA.Text = "Canc. A";
            this.btnCancelarA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarA.UseVisualStyleBackColor = true;
            this.btnCancelarA.Click += new System.EventHandler(this.btnCancelarA_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(506, 83);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 94);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.txtNombreCliente.Location = new System.Drawing.Point(192, 151);
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
            this.txtNombreCliente.TabIndex = 37;
            this.txtNombreCliente.TabStop = false;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCliente.TrailingIcon = null;
            this.txtNombreCliente.UseSystemPasswordChar = false;
            // 
            // txtFolioBoleto
            // 
            this.txtFolioBoleto.AnimateReadOnly = false;
            this.txtFolioBoleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFolioBoleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFolioBoleto.Depth = 0;
            this.txtFolioBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFolioBoleto.HideSelection = true;
            this.txtFolioBoleto.LeadingIcon = null;
            this.txtFolioBoleto.Location = new System.Drawing.Point(192, 83);
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
            this.txtFolioBoleto.TabIndex = 36;
            this.txtFolioBoleto.TabStop = false;
            this.txtFolioBoleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFolioBoleto.TrailingIcon = null;
            this.txtFolioBoleto.UseSystemPasswordChar = false;
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Checked = true;
            this.chkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNombre.Depth = 0;
            this.chkNombre.Location = new System.Drawing.Point(8, 151);
            this.chkNombre.Margin = new System.Windows.Forms.Padding(0);
            this.chkNombre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.ReadOnly = false;
            this.chkNombre.Ripple = true;
            this.chkNombre.Size = new System.Drawing.Size(95, 37);
            this.chkNombre.TabIndex = 35;
            this.chkNombre.Text = "Nombre:";
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkFolio_CheckedChanged);
            // 
            // chkFolio
            // 
            this.chkFolio.AutoSize = true;
            this.chkFolio.Checked = true;
            this.chkFolio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolio.Depth = 0;
            this.chkFolio.Location = new System.Drawing.Point(8, 83);
            this.chkFolio.Margin = new System.Windows.Forms.Padding(0);
            this.chkFolio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFolio.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFolio.Name = "chkFolio";
            this.chkFolio.ReadOnly = false;
            this.chkFolio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFolio.Ripple = true;
            this.chkFolio.Size = new System.Drawing.Size(82, 37);
            this.chkFolio.TabIndex = 34;
            this.chkFolio.Text = "Fecha:";
            this.chkFolio.UseVisualStyleBackColor = true;
            this.chkFolio.CheckedChanged += new System.EventHandler(this.chkFolio_CheckedChanged);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Checked = true;
            this.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFecha.Depth = 0;
            this.chkFecha.Location = new System.Drawing.Point(8, 17);
            this.chkFecha.Margin = new System.Windows.Forms.Padding(0);
            this.chkFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.ReadOnly = false;
            this.chkFecha.Ripple = true;
            this.chkFecha.Size = new System.Drawing.Size(119, 37);
            this.chkFecha.TabIndex = 33;
            this.chkFecha.Text = "Folio Venta:";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // frmVentasGrupalV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 779);
            this.ControlBox = false;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVentasGrupalV2";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "frmVentasGrupalV2";
            this.Load += new System.EventHandler(this.frmVentasGrupalV2_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView dgvdatosboleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobroCancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn retornoCancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Ins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloqueoCancelacionMonedero;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloqueoCancelacionPorFormaDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStatusCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStatusPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroBoletos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPagoEfectivo;
        private System.Windows.Forms.Button btnCancelarA;
        private System.Windows.Forms.Button btnBuscar;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreCliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtFolioBoleto;
        private MaterialSkin.Controls.MaterialCheckbox chkNombre;
        private MaterialSkin.Controls.MaterialCheckbox chkFolio;
        private MaterialSkin.Controls.MaterialCheckbox chkFecha;
    }
}