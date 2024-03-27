namespace CreativaSL.WinForm.VentaBoletos.Clientes
{
    partial class frm_v2_ClasificacionUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvClientes1 = new CreativaSL.WinForm.VentaBoletos.Controls.CSLDataGridView();
            this.dataGridViewIDClasificacionTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacionClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnEliminar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnModificar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnNuevo = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.tlpBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.LblTipoBusqueda = new System.Windows.Forms.Label();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.CmbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.IDClasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacionClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionClienteBindingSource1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tlpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(954, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 447);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvClientes1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 375);
            this.panel3.TabIndex = 1;
            // 
            // dgvClientes1
            // 
            this.dgvClientes1.AccessibleDescription = "";
            this.dgvClientes1.AllowUserToAddRows = false;
            this.dgvClientes1.AllowUserToDeleteRows = false;
            this.dgvClientes1.AutoGenerateColumns = false;
            this.dgvClientes1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewIDClasificacionTextBoxColumn1,
            this.descripcionDataGridViewTextBoxColumn,
            this.porcentajeDataGridViewTextBoxColumn});
            this.dgvClientes1.DataSource = this.clasificacionClienteBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "P";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes1.Location = new System.Drawing.Point(0, 29);
            this.dgvClientes1.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes1.MultiSelect = false;
            this.dgvClientes1.Name = "dgvClientes1";
            this.dgvClientes1.RowTemplate.Height = 28;
            this.dgvClientes1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes1.Size = new System.Drawing.Size(954, 346);
            this.dgvClientes1.TabIndex = 1;
            //this.dgvClientes1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes1_CellContentClick);
            // 
            // dataGridViewIDClasificacionTextBoxColumn1
            // 
            this.dataGridViewIDClasificacionTextBoxColumn1.DataPropertyName = "IDClasificacion";
            this.dataGridViewIDClasificacionTextBoxColumn1.HeaderText = "IDClasificacion";
            this.dataGridViewIDClasificacionTextBoxColumn1.Name = "dataGridViewIDClasificacionTextBoxColumn1";
            this.dataGridViewIDClasificacionTextBoxColumn1.ReadOnly = true;
            this.dataGridViewIDClasificacionTextBoxColumn1.Visible = false;
            this.dataGridViewIDClasificacionTextBoxColumn1.Width = 150;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
            // 
            // porcentajeDataGridViewTextBoxColumn
            // 
            this.porcentajeDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.HeaderText = "Porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.Name = "porcentajeDataGridViewTextBoxColumn";
            this.porcentajeDataGridViewTextBoxColumn.Width = 83;
            // 
            // clasificacionClienteBindingSource1
            // 
            this.clasificacionClienteBindingSource1.DataSource = typeof(CreativaSL.Dll.VentaBoletosGlobal.ClasificacionCliente);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(954, 29);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(954, 29);
            this.label2.TabIndex = 124;
            this.label2.Text = "Resultados de búsqueda";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.tlpBusqueda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 72);
            this.panel2.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnSalir.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FocusRectangle = true;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSalir.Image = null;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnSalir.ImageFocused = null;
            this.btnSalir.ImageInactive = null;
            this.btnSalir.ImageMouseOver = null;
            this.btnSalir.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._11salir;
            this.btnSalir.ImagePressed = null;
            this.btnSalir.ImageSize = new System.Drawing.Size(70, 70);
            this.btnSalir.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnSalir.KeyButtonView = false;
            this.btnSalir.Location = new System.Drawing.Point(862, 2);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(79, 65);
            this.btnSalir.TabIndex = 128;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEliminar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnEliminar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnEliminar.FocusRectangle = true;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnEliminar.ImageFocused = null;
            this.btnEliminar.ImageInactive = null;
            this.btnEliminar.ImageMouseOver = null;
            this.btnEliminar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._7eliminar;
            this.btnEliminar.ImagePressed = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(70, 70);
            this.btnEliminar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnEliminar.KeyButtonView = false;
            this.btnEliminar.Location = new System.Drawing.Point(606, 3);
            this.btnEliminar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEliminar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OffsetPressedContent = true;
            this.btnEliminar.Size = new System.Drawing.Size(81, 65);
            this.btnEliminar.TabIndex = 127;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextDropShadow = true;
            this.btnEliminar.UseVisualStyleBackColor = false;
            //this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnModificar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnModificar.FocusRectangle = true;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnModificar.Image = null;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnModificar.ImageFocused = null;
            this.btnModificar.ImageInactive = null;
            this.btnModificar.ImageMouseOver = null;
            this.btnModificar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._31modificar;
            this.btnModificar.ImagePressed = null;
            this.btnModificar.ImageSize = new System.Drawing.Size(70, 70);
            this.btnModificar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnModificar.KeyButtonView = false;
            this.btnModificar.Location = new System.Drawing.Point(692, 3);
            this.btnModificar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnModificar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OffsetPressedContent = true;
            this.btnModificar.Size = new System.Drawing.Size(79, 65);
            this.btnModificar.TabIndex = 126;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.TextDropShadow = true;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNuevo.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevo.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevo.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnNuevo.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnNuevo.FocusRectangle = true;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnNuevo.Image = null;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnNuevo.ImageFocused = null;
            this.btnNuevo.ImageInactive = null;
            this.btnNuevo.ImageMouseOver = null;
            this.btnNuevo.ImageNormal = null;
            this.btnNuevo.ImagePressed = null;
            this.btnNuevo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNuevo.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnNuevo.KeyButtonView = false;
            this.btnNuevo.Location = new System.Drawing.Point(558, 2);
            this.btnNuevo.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnNuevo.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OffsetPressedContent = true;
            this.btnNuevo.Size = new System.Drawing.Size(53, 42);
            this.btnNuevo.TabIndex = 125;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextDropShadow = true;
            this.btnNuevo.UseVisualStyleBackColor = false;
            //this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tlpBusqueda
            // 
            this.tlpBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBusqueda.ColumnCount = 5;
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.12963F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.70422F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.042253F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBusqueda.Controls.Add(this.btnBuscar, 4, 0);
            this.tlpBusqueda.Controls.Add(this.LblTipoBusqueda, 0, 0);
            this.tlpBusqueda.Controls.Add(this.TxtBusqueda, 3, 0);
            this.tlpBusqueda.Controls.Add(this.CmbTipoBusqueda, 1, 0);
            this.tlpBusqueda.Location = new System.Drawing.Point(12, 12);
            this.tlpBusqueda.Name = "tlpBusqueda";
            this.tlpBusqueda.RowCount = 1;
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBusqueda.Size = new System.Drawing.Size(526, 35);
            this.tlpBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnBuscar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnBuscar.FocusRectangle = true;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnBuscar.ImageFocused = null;
            this.btnBuscar.ImageInactive = null;
            this.btnBuscar.ImageMouseOver = null;
            this.btnBuscar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._34busqueda;
            this.btnBuscar.ImagePressed = null;
            this.btnBuscar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBuscar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnBuscar.KeyButtonView = false;
            this.btnBuscar.Location = new System.Drawing.Point(379, 3);
            this.btnBuscar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnBuscar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OffsetPressedContent = true;
            this.btnBuscar.Size = new System.Drawing.Size(30, 29);
            this.btnBuscar.TabIndex = 122;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextDropShadow = true;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // LblTipoBusqueda
            // 
            this.LblTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTipoBusqueda.AutoSize = true;
            this.LblTipoBusqueda.Location = new System.Drawing.Point(3, 0);
            this.LblTipoBusqueda.Name = "LblTipoBusqueda";
            this.LblTipoBusqueda.Size = new System.Drawing.Size(62, 35);
            this.LblTipoBusqueda.TabIndex = 1;
            this.LblTipoBusqueda.Text = "Tipo de búsqueda:";
            this.LblTipoBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusqueda.Location = new System.Drawing.Point(178, 7);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(195, 20);
            this.TxtBusqueda.TabIndex = 2;
            // 
            // CmbTipoBusqueda
            // 
            this.CmbTipoBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbTipoBusqueda.FormattingEnabled = true;
            this.CmbTipoBusqueda.Location = new System.Drawing.Point(71, 7);
            this.CmbTipoBusqueda.Name = "CmbTipoBusqueda";
            this.CmbTipoBusqueda.Size = new System.Drawing.Size(93, 21);
            this.CmbTipoBusqueda.TabIndex = 0;
            // 
            // IDClasificacion
            // 
            this.IDClasificacion.DataPropertyName = "IDClasificacion";
            this.IDClasificacion.HeaderText = "IDTipoClasificacion";
            this.IDClasificacion.Name = "IDClasificacion";
            this.IDClasificacion.ReadOnly = true;
            this.IDClasificacion.Visible = false;
            this.IDClasificacion.Width = 123;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Clasificación";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 91;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "Porcentaje";
            dataGridViewCellStyle2.Format = "P";
            this.Porcentaje.DefaultCellStyle = dataGridViewCellStyle2;
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            this.Porcentaje.Width = 83;
            // 
            // clasificacionClienteBindingSource
            // 
            this.clasificacionClienteBindingSource.DataSource = typeof(CreativaSL.Dll.VentaBoletosGlobal.ClasificacionCliente);

            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNuevo.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevo.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNuevo.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnNuevo.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnNuevo.FocusRectangle = true;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnNuevo.Image = null;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnNuevo.ImageFocused = null;
            this.btnNuevo.ImageInactive = null;
            this.btnNuevo.ImageMouseOver = null;
            this.btnNuevo.ImageNormal = null;
            this.btnNuevo.ImagePressed = null;
            this.btnNuevo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNuevo.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnNuevo.KeyButtonView = false;
            this.btnNuevo.Location = new System.Drawing.Point(838, 3);
            this.btnNuevo.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnNuevo.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OffsetPressedContent = true;
            this.btnNuevo.Size = new System.Drawing.Size(80, 65);
            this.btnNuevo.TabIndex = 125;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextDropShadow = true;
            this.btnNuevo.UseVisualStyleBackColor = false;
            //this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            // 
            // frm_v2_ClasificacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 421);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(915, 460);
            this.Name = "frm_v2_ClasificacionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorías de cliente";
            this.TopMost = true;
            //this.Load += new System.EventHandler(this.frm_v2_ClasificacionUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionClienteBindingSource1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tlpBusqueda.ResumeLayout(false);
            this.tlpBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private Controls.CSLDataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDClasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private Controls.CSLDataGridView dgvClientes1;
        private System.Windows.Forms.BindingSource clasificacionClienteBindingSource;
        private System.Windows.Forms.BindingSource clasificacionClienteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewIDClasificacionTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private LibControls.WinForms.Button_Creativa btnEliminar;
        private LibControls.WinForms.Button_Creativa btnModificar;
        private LibControls.WinForms.Button_Creativa btnNuevo;
        private System.Windows.Forms.TableLayoutPanel tlpBusqueda;
        private LibControls.WinForms.Button_Creativa btnBuscar;
        private System.Windows.Forms.Label LblTipoBusqueda;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.ComboBox CmbTipoBusqueda;
    }
}