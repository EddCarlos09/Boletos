namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmDatosViajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosViajes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBusqueda = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.btnRpt4 = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnRpt3 = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnRpt1 = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnRpt2 = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnEliminar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnModificar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnNuevo = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvdatosviajes = new System.Windows.Forms.DataGridView();
            this.nombreViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_datosViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prestacionServicios1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prestacionServicios2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_listapasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelBusqueda.BorderColor = System.Drawing.Color.Transparent;
            this.panelBusqueda.Controls.Add(this.btnRpt4);
            this.panelBusqueda.Controls.Add(this.btnRpt3);
            this.panelBusqueda.Controls.Add(this.btnRpt1);
            this.panelBusqueda.Controls.Add(this.btnRpt2);
            this.panelBusqueda.Controls.Add(this.btnEliminar);
            this.panelBusqueda.Controls.Add(this.btnModificar);
            this.panelBusqueda.Controls.Add(this.btnNuevo);
            this.panelBusqueda.Controls.Add(this.label6);
            this.panelBusqueda.Controls.Add(this.dgvdatosviajes);
            this.panelBusqueda.Controls.Add(this.label5);
            this.panelBusqueda.Controls.Add(this.label4);
            this.panelBusqueda.Controls.Add(this.btnSalir);
            this.panelBusqueda.Controls.Add(this.dtpFecha);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusqueda.DrawGradient = false;
            this.panelBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBusqueda.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1008, 447);
            this.panelBusqueda.SizeLine = 3;
            this.panelBusqueda.SizeTitle = 20;
            this.panelBusqueda.TabIndex = 8;
            this.panelBusqueda.Title = "";
            this.panelBusqueda.TitleColor = System.Drawing.Color.Transparent;
            // 
            // btnRpt4
            // 
            this.btnRpt4.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRpt4.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRpt4.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRpt4.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnRpt4.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnRpt4.FocusRectangle = true;
            this.btnRpt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRpt4.Image = null;
            this.btnRpt4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRpt4.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnRpt4.ImageFocused = null;
            this.btnRpt4.ImageInactive = null;
            this.btnRpt4.ImageMouseOver = null;
            this.btnRpt4.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnRpt4.ImageNormal")));
            this.btnRpt4.ImagePressed = null;
            this.btnRpt4.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRpt4.KeyButton = System.Windows.Forms.Keys.None;
            this.btnRpt4.KeyButtonView = false;
            this.btnRpt4.Location = new System.Drawing.Point(839, 49);
            this.btnRpt4.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRpt4.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRpt4.Name = "btnRpt4";
            this.btnRpt4.OffsetPressedContent = true;
            this.btnRpt4.Size = new System.Drawing.Size(85, 65);
            this.btnRpt4.TabIndex = 8;
            this.btnRpt4.Text = "Rpt4";
            this.btnRpt4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRpt4.TextDropShadow = true;
            this.btnRpt4.UseVisualStyleBackColor = false;
            this.btnRpt4.Click += new System.EventHandler(this.btnRpt4_Click);
            // 
            // btnRpt3
            // 
            this.btnRpt3.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRpt3.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRpt3.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRpt3.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnRpt3.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnRpt3.FocusRectangle = true;
            this.btnRpt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRpt3.Image = null;
            this.btnRpt3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRpt3.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnRpt3.ImageFocused = null;
            this.btnRpt3.ImageInactive = null;
            this.btnRpt3.ImageMouseOver = null;
            this.btnRpt3.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnRpt3.ImageNormal")));
            this.btnRpt3.ImagePressed = null;
            this.btnRpt3.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRpt3.KeyButton = System.Windows.Forms.Keys.None;
            this.btnRpt3.KeyButtonView = false;
            this.btnRpt3.Location = new System.Drawing.Point(754, 49);
            this.btnRpt3.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRpt3.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRpt3.Name = "btnRpt3";
            this.btnRpt3.OffsetPressedContent = true;
            this.btnRpt3.Size = new System.Drawing.Size(85, 65);
            this.btnRpt3.TabIndex = 7;
            this.btnRpt3.Text = "Rpt3";
            this.btnRpt3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRpt3.TextDropShadow = true;
            this.btnRpt3.UseVisualStyleBackColor = false;
            this.btnRpt3.Click += new System.EventHandler(this.btnRpt3_Click);
            // 
            // btnRpt1
            // 
            this.btnRpt1.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRpt1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRpt1.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRpt1.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnRpt1.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnRpt1.FocusRectangle = true;
            this.btnRpt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRpt1.Image = null;
            this.btnRpt1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRpt1.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnRpt1.ImageFocused = null;
            this.btnRpt1.ImageInactive = null;
            this.btnRpt1.ImageMouseOver = null;
            this.btnRpt1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnRpt1.ImageNormal")));
            this.btnRpt1.ImagePressed = null;
            this.btnRpt1.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRpt1.KeyButton = System.Windows.Forms.Keys.None;
            this.btnRpt1.KeyButtonView = false;
            this.btnRpt1.Location = new System.Drawing.Point(584, 49);
            this.btnRpt1.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRpt1.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRpt1.Name = "btnRpt1";
            this.btnRpt1.OffsetPressedContent = true;
            this.btnRpt1.Size = new System.Drawing.Size(85, 65);
            this.btnRpt1.TabIndex = 5;
            this.btnRpt1.Text = "Rpt1";
            this.btnRpt1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRpt1.TextDropShadow = true;
            this.btnRpt1.UseVisualStyleBackColor = false;
            this.btnRpt1.Click += new System.EventHandler(this.btnRpt1_Click);
            // 
            // btnRpt2
            // 
            this.btnRpt2.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRpt2.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRpt2.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRpt2.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnRpt2.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnRpt2.FocusRectangle = true;
            this.btnRpt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRpt2.Image = null;
            this.btnRpt2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRpt2.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnRpt2.ImageFocused = null;
            this.btnRpt2.ImageInactive = null;
            this.btnRpt2.ImageMouseOver = null;
            this.btnRpt2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnRpt2.ImageNormal")));
            this.btnRpt2.ImagePressed = null;
            this.btnRpt2.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRpt2.KeyButton = System.Windows.Forms.Keys.None;
            this.btnRpt2.KeyButtonView = false;
            this.btnRpt2.Location = new System.Drawing.Point(669, 49);
            this.btnRpt2.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRpt2.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnRpt2.Name = "btnRpt2";
            this.btnRpt2.OffsetPressedContent = true;
            this.btnRpt2.Size = new System.Drawing.Size(85, 65);
            this.btnRpt2.TabIndex = 6;
            this.btnRpt2.Text = "Rpt2";
            this.btnRpt2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRpt2.TextDropShadow = true;
            this.btnRpt2.UseVisualStyleBackColor = false;
            this.btnRpt2.Click += new System.EventHandler(this.btnRpt2_Click);
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
            this.btnEliminar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEliminar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnEliminar.KeyButtonView = false;
            this.btnEliminar.Location = new System.Drawing.Point(499, 49);
            this.btnEliminar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEliminar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OffsetPressedContent = true;
            this.btnEliminar.Size = new System.Drawing.Size(85, 65);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextDropShadow = true;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
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
            this.btnModificar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnModificar.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnModificar.KeyButtonView = false;
            this.btnModificar.Location = new System.Drawing.Point(414, 49);
            this.btnModificar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnModificar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OffsetPressedContent = true;
            this.btnModificar.Size = new System.Drawing.Size(85, 65);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.TextDropShadow = true;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
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
            this.btnNuevo.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._4agregar;
            this.btnNuevo.ImagePressed = null;
            this.btnNuevo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNuevo.KeyButton = System.Windows.Forms.Keys.F1;
            this.btnNuevo.KeyButtonView = false;
            this.btnNuevo.Location = new System.Drawing.Point(329, 49);
            this.btnNuevo.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnNuevo.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OffsetPressedContent = true;
            this.btnNuevo.Size = new System.Drawing.Size(85, 65);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextDropShadow = true;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.label6.Text = "Resultados Busqueda";
            // 
            // dgvdatosviajes
            // 
            this.dgvdatosviajes.AllowUserToAddRows = false;
            this.dgvdatosviajes.AllowUserToDeleteRows = false;
            this.dgvdatosviajes.AllowUserToResizeColumns = false;
            this.dgvdatosviajes.AllowUserToResizeRows = false;
            this.dgvdatosviajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosviajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosviajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreViaje,
            this.camion,
            this.ruta,
            this.fecha_salida,
            this.hora_salida,
            this.id_viaje,
            this.id_datosViaje,
            this.id_prestacionServicios1,
            this.id_prestacionServicios2,
            this.id_listapasajeros});
            this.dgvdatosviajes.Location = new System.Drawing.Point(11, 170);
            this.dgvdatosviajes.MultiSelect = false;
            this.dgvdatosviajes.Name = "dgvdatosviajes";
            this.dgvdatosviajes.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosviajes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatosviajes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosviajes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosviajes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosviajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosviajes.Size = new System.Drawing.Size(990, 271);
            this.dgvdatosviajes.TabIndex = 10;
            // 
            // nombreViaje
            // 
            this.nombreViaje.DataPropertyName = "nombreViaje";
            this.nombreViaje.HeaderText = "Viaje";
            this.nombreViaje.Name = "nombreViaje";
            this.nombreViaje.ReadOnly = true;
            this.nombreViaje.Width = 69;
            // 
            // camion
            // 
            this.camion.DataPropertyName = "camion";
            this.camion.HeaderText = "Camion";
            this.camion.Name = "camion";
            this.camion.ReadOnly = true;
            this.camion.Width = 88;
            // 
            // ruta
            // 
            this.ruta.DataPropertyName = "ruta";
            this.ruta.HeaderText = "Ruta";
            this.ruta.Name = "ruta";
            this.ruta.ReadOnly = true;
            this.ruta.Width = 69;
            // 
            // fecha_salida
            // 
            this.fecha_salida.DataPropertyName = "fecha_salida";
            this.fecha_salida.HeaderText = "Fecha Salida";
            this.fecha_salida.Name = "fecha_salida";
            this.fecha_salida.ReadOnly = true;
            this.fecha_salida.Width = 127;
            // 
            // hora_salida
            // 
            this.hora_salida.DataPropertyName = "hora_salida";
            this.hora_salida.HeaderText = "Hora Salida";
            this.hora_salida.Name = "hora_salida";
            this.hora_salida.ReadOnly = true;
            this.hora_salida.Width = 117;
            // 
            // id_viaje
            // 
            this.id_viaje.DataPropertyName = "id_viaje";
            this.id_viaje.HeaderText = "id_viaje";
            this.id_viaje.Name = "id_viaje";
            this.id_viaje.ReadOnly = true;
            this.id_viaje.Visible = false;
            this.id_viaje.Width = 86;
            // 
            // id_datosViaje
            // 
            this.id_datosViaje.DataPropertyName = "id_datosViaje";
            this.id_datosViaje.HeaderText = "id_datosViaje";
            this.id_datosViaje.Name = "id_datosViaje";
            this.id_datosViaje.ReadOnly = true;
            this.id_datosViaje.Visible = false;
            this.id_datosViaje.Width = 130;
            // 
            // id_prestacionServicios1
            // 
            this.id_prestacionServicios1.DataPropertyName = "id_prestacionServicios1";
            this.id_prestacionServicios1.HeaderText = "id_prestacionServicios1";
            this.id_prestacionServicios1.Name = "id_prestacionServicios1";
            this.id_prestacionServicios1.ReadOnly = true;
            this.id_prestacionServicios1.Visible = false;
            this.id_prestacionServicios1.Width = 201;
            // 
            // id_prestacionServicios2
            // 
            this.id_prestacionServicios2.DataPropertyName = "id_prestacionServicios2";
            this.id_prestacionServicios2.HeaderText = "id_prestacionServicios2";
            this.id_prestacionServicios2.Name = "id_prestacionServicios2";
            this.id_prestacionServicios2.ReadOnly = true;
            this.id_prestacionServicios2.Visible = false;
            this.id_prestacionServicios2.Width = 201;
            // 
            // id_listapasajeros
            // 
            this.id_listapasajeros.DataPropertyName = "id_listapasajeros";
            this.id_listapasajeros.HeaderText = "id_listapasajeros";
            this.id_listapasajeros.Name = "id_listapasajeros";
            this.id_listapasajeros.ReadOnly = true;
            this.id_listapasajeros.Visible = false;
            this.id_listapasajeros.Width = 152;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(645, 26);
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
            this.label4.Location = new System.Drawing.Point(115, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Busqueda";
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
            this.btnSalir.Location = new System.Drawing.Point(924, 49);
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
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(86, 80);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(185, 23);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // frmDatosViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 447);
            this.ControlBox = true;
            this.Controls.Add(this.panelBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatosViajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Viaje";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panelBusqueda;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private System.Windows.Forms.DataGridView dgvdatosviajes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private LibControls.WinForms.Button_Creativa btnModificar;
        private LibControls.WinForms.Button_Creativa btnNuevo;
        private LibControls.WinForms.Button_Creativa btnEliminar;
        private LibControls.WinForms.Button_Creativa btnRpt3;
        private LibControls.WinForms.Button_Creativa btnRpt1;
        private LibControls.WinForms.Button_Creativa btnRpt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn camion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_datosViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prestacionServicios1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prestacionServicios2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_listapasajeros;
        private LibControls.WinForms.Button_Creativa btnRpt4;
    }
}