namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmVentasGrupal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasGrupal));
            this.panelBusqueda = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label6 = new System.Windows.Forms.Label();
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
            this.btnCancelarA = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.btnPagoEfectivo = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.chkFolio = new System.Windows.Forms.CheckBox();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
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
            this.panelBusqueda.Controls.Add(this.label6);
            this.panelBusqueda.Controls.Add(this.dgvdatosboleto);
            this.panelBusqueda.Controls.Add(this.btnCancelarA);
            this.panelBusqueda.Controls.Add(this.label5);
            this.panelBusqueda.Controls.Add(this.label4);
            this.panelBusqueda.Controls.Add(this.chkNombre);
            this.panelBusqueda.Controls.Add(this.btnPagoEfectivo);
            this.panelBusqueda.Controls.Add(this.chkFolio);
            this.panelBusqueda.Controls.Add(this.btnSalir);
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
            this.panelBusqueda.Size = new System.Drawing.Size(1084, 447);
            this.panelBusqueda.SizeLine = 3;
            this.panelBusqueda.SizeTitle = 20;
            this.panelBusqueda.TabIndex = 9;
            this.panelBusqueda.Title = "";
            this.panelBusqueda.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(421, 143);
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
            this.dgvdatosboleto.Location = new System.Drawing.Point(11, 170);
            this.dgvdatosboleto.MultiSelect = false;
            this.dgvdatosboleto.Name = "dgvdatosboleto";
            this.dgvdatosboleto.ReadOnly = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboleto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboleto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboleto.Size = new System.Drawing.Size(1061, 271);
            this.dgvdatosboleto.TabIndex = 11;
            // 
            // folio
            // 
            this.folio.DataPropertyName = "folio";
            this.folio.HeaderText = "Folio";
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            this.folio.Width = 68;
            // 
            // fechaVenta
            // 
            this.fechaVenta.DataPropertyName = "fec_venta";
            this.fechaVenta.HeaderText = "Fecha_Venta";
            this.fechaVenta.Name = "fechaVenta";
            this.fechaVenta.ReadOnly = true;
            this.fechaVenta.Width = 131;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 90;
            // 
            // numeroTelefono
            // 
            this.numeroTelefono.DataPropertyName = "numeroTelefono";
            this.numeroTelefono.HeaderText = "Número_Teléfono";
            this.numeroTelefono.Name = "numeroTelefono";
            this.numeroTelefono.ReadOnly = true;
            this.numeroTelefono.Width = 161;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha_Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Width = 167;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle1;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 69;
            // 
            // cobroCancelacion
            // 
            this.cobroCancelacion.DataPropertyName = "cobroCancelacion";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "C2";
            this.cobroCancelacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.cobroCancelacion.HeaderText = "Cobro_Canc.";
            this.cobroCancelacion.Name = "cobroCancelacion";
            this.cobroCancelacion.ReadOnly = true;
            this.cobroCancelacion.Width = 127;
            // 
            // retornoCancelacion
            // 
            this.retornoCancelacion.DataPropertyName = "retornoCancelacion";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "C2";
            this.retornoCancelacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.retornoCancelacion.HeaderText = "Retorno_Canc.";
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
            this.pendiente.Name = "pendiente";
            this.pendiente.ReadOnly = true;
            this.pendiente.Width = 106;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Estatus";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 89;
            // 
            // Usu_Ins
            // 
            this.Usu_Ins.DataPropertyName = "usuins";
            this.Usu_Ins.HeaderText = "Usu_Ins";
            this.Usu_Ins.Name = "Usu_Ins";
            this.Usu_Ins.ReadOnly = true;
            this.Usu_Ins.Width = 94;
            // 
            // Usu_Mod
            // 
            this.Usu_Mod.DataPropertyName = "usuupd";
            this.Usu_Mod.HeaderText = "Usu_Mod";
            this.Usu_Mod.Name = "Usu_Mod";
            this.Usu_Mod.ReadOnly = true;
            this.Usu_Mod.Width = 103;
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
            // id_venta
            // 
            this.id_venta.DataPropertyName = "id_venta";
            this.id_venta.HeaderText = "id_venta";
            this.id_venta.Name = "id_venta";
            this.id_venta.ReadOnly = true;
            this.id_venta.Visible = false;
            this.id_venta.Width = 94;
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
            // IDStatusCobro
            // 
            this.IDStatusCobro.DataPropertyName = "IDStatusCobro";
            this.IDStatusCobro.HeaderText = "IDStatusCobro";
            this.IDStatusCobro.Name = "IDStatusCobro";
            this.IDStatusCobro.ReadOnly = true;
            this.IDStatusCobro.Visible = false;
            this.IDStatusCobro.Width = 141;
            // 
            // IDStatusPago
            // 
            this.IDStatusPago.DataPropertyName = "IDStatusPago";
            this.IDStatusPago.HeaderText = "IDStatusPago";
            this.IDStatusPago.Name = "IDStatusPago";
            this.IDStatusPago.ReadOnly = true;
            this.IDStatusPago.Visible = false;
            this.IDStatusPago.Width = 135;
            // 
            // numeroBoletos
            // 
            this.numeroBoletos.DataPropertyName = "numeroBoletos";
            this.numeroBoletos.HeaderText = "Núm. Boletos";
            this.numeroBoletos.Name = "numeroBoletos";
            this.numeroBoletos.ReadOnly = true;
            this.numeroBoletos.Width = 129;
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
            this.btnCancelarA.Location = new System.Drawing.Point(706, 55);
            this.btnCancelarA.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancelarA.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnCancelarA.Name = "btnCancelarA";
            this.btnCancelarA.OffsetPressedContent = true;
            this.btnCancelarA.Size = new System.Drawing.Size(80, 65);
            this.btnCancelarA.TabIndex = 8;
            this.btnCancelarA.Text = "Canc.  A";
            this.btnCancelarA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarA.TextDropShadow = true;
            this.btnCancelarA.UseVisualStyleBackColor = false;
            this.btnCancelarA.Click += new System.EventHandler(this.btnCancelarA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(725, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Acciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(186, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Búsqueda";
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.Checked = true;
            this.chkNombre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNombre.Location = new System.Drawing.Point(13, 113);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(15, 14);
            this.chkNombre.TabIndex = 3;
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // btnPagoEfectivo
            // 
            this.btnPagoEfectivo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPagoEfectivo.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPagoEfectivo.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPagoEfectivo.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnPagoEfectivo.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnPagoEfectivo.FocusRectangle = true;
            this.btnPagoEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoEfectivo.Image = null;
            this.btnPagoEfectivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagoEfectivo.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnPagoEfectivo.ImageFocused = null;
            this.btnPagoEfectivo.ImageInactive = null;
            this.btnPagoEfectivo.ImageMouseOver = null;
            this.btnPagoEfectivo.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.cancelacion_boletos;
            this.btnPagoEfectivo.ImagePressed = null;
            this.btnPagoEfectivo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPagoEfectivo.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnPagoEfectivo.KeyButtonView = false;
            this.btnPagoEfectivo.Location = new System.Drawing.Point(786, 55);
            this.btnPagoEfectivo.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnPagoEfectivo.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnPagoEfectivo.Name = "btnPagoEfectivo";
            this.btnPagoEfectivo.OffsetPressedContent = true;
            this.btnPagoEfectivo.Size = new System.Drawing.Size(80, 65);
            this.btnPagoEfectivo.TabIndex = 9;
            this.btnPagoEfectivo.Text = "Pago Efec";
            this.btnPagoEfectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagoEfectivo.TextDropShadow = true;
            this.btnPagoEfectivo.UseVisualStyleBackColor = false;
            this.btnPagoEfectivo.Click += new System.EventHandler(this.btnPagoEfectivo_Click);
            // 
            // chkFolio
            // 
            this.chkFolio.AutoSize = true;
            this.chkFolio.Checked = true;
            this.chkFolio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFolio.Location = new System.Drawing.Point(13, 81);
            this.chkFolio.Name = "chkFolio";
            this.chkFolio.Size = new System.Drawing.Size(15, 14);
            this.chkFolio.TabIndex = 2;
            this.chkFolio.UseVisualStyleBackColor = true;
            this.chkFolio.CheckedChanged += new System.EventHandler(this.chkFolio_CheckedChanged);
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
            this.btnSalir.Location = new System.Drawing.Point(866, 55);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(80, 65);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Checked = true;
            this.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFecha.Location = new System.Drawing.Point(13, 50);
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
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(137, 104);
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
            this.btnBuscar.Location = new System.Drawing.Point(426, 50);
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
            // txtFolioBoleto
            // 
            this.txtFolioBoleto.Location = new System.Drawing.Point(137, 75);
            this.txtFolioBoleto.Name = "txtFolioBoleto";
            this.txtFolioBoleto.Size = new System.Drawing.Size(262, 26);
            this.txtFolioBoleto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Folio Venta:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(137, 50);
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
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // frmVentasGrupal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 447);
            this.Controls.Add(this.panelBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentasGrupal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta Grupal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmVentasGrupal_Load);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panelBusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvdatosboleto;
        private LibControls.WinForms.Button_Creativa btnCancelarA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkNombre;
        private LibControls.WinForms.Button_Creativa btnPagoEfectivo;
        private System.Windows.Forms.CheckBox chkFolio;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private LibControls.WinForms.Button_Creativa btnBuscar;
        private System.Windows.Forms.TextBox txtFolioBoleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
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
    }
}