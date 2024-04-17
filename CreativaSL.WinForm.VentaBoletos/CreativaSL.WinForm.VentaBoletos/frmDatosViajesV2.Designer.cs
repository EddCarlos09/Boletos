namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmDatosViajesV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosViajesV2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRpt1 = new System.Windows.Forms.Button();
            this.btnRpt2 = new System.Windows.Forms.Button();
            this.btnRpt3 = new System.Windows.Forms.Button();
            this.btnRpt4 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvdatosviajes);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnRpt4);
            this.panel1.Controls.Add(this.btnRpt3);
            this.panel1.Controls.Add(this.btnRpt2);
            this.panel1.Controls.Add(this.btnRpt1);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 530);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(275, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Acciones";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(43, 69);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(185, 26);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(38, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Busqueda";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-plus-100.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(38, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Resultados Busqueda";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(280, 56);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 84);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(380, 56);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 84);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(482, 56);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 84);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRpt1
            // 
            this.btnRpt1.BackColor = System.Drawing.SystemColors.Control;
            this.btnRpt1.Image = ((System.Drawing.Image)(resources.GetObject("btnRpt1.Image")));
            this.btnRpt1.Location = new System.Drawing.Point(573, 56);
            this.btnRpt1.Name = "btnRpt1";
            this.btnRpt1.Size = new System.Drawing.Size(73, 84);
            this.btnRpt1.TabIndex = 25;
            this.btnRpt1.Text = "Rpt 1";
            this.btnRpt1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRpt1.UseVisualStyleBackColor = false;
            this.btnRpt1.Click += new System.EventHandler(this.btnRpt1_Click);
            // 
            // btnRpt2
            // 
            this.btnRpt2.BackColor = System.Drawing.SystemColors.Control;
            this.btnRpt2.Image = ((System.Drawing.Image)(resources.GetObject("btnRpt2.Image")));
            this.btnRpt2.Location = new System.Drawing.Point(662, 56);
            this.btnRpt2.Name = "btnRpt2";
            this.btnRpt2.Size = new System.Drawing.Size(73, 84);
            this.btnRpt2.TabIndex = 26;
            this.btnRpt2.Text = "Rpt 2";
            this.btnRpt2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRpt2.UseVisualStyleBackColor = false;
            this.btnRpt2.Click += new System.EventHandler(this.btnRpt2_Click);
            // 
            // btnRpt3
            // 
            this.btnRpt3.BackColor = System.Drawing.SystemColors.Control;
            this.btnRpt3.Image = ((System.Drawing.Image)(resources.GetObject("btnRpt3.Image")));
            this.btnRpt3.Location = new System.Drawing.Point(751, 56);
            this.btnRpt3.Name = "btnRpt3";
            this.btnRpt3.Size = new System.Drawing.Size(73, 84);
            this.btnRpt3.TabIndex = 27;
            this.btnRpt3.Text = "Rpt 3";
            this.btnRpt3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRpt3.UseVisualStyleBackColor = false;
            this.btnRpt3.Click += new System.EventHandler(this.btnRpt3_Click);
            // 
            // btnRpt4
            // 
            this.btnRpt4.BackColor = System.Drawing.SystemColors.Control;
            this.btnRpt4.Image = ((System.Drawing.Image)(resources.GetObject("btnRpt4.Image")));
            this.btnRpt4.Location = new System.Drawing.Point(840, 56);
            this.btnRpt4.Name = "btnRpt4";
            this.btnRpt4.Size = new System.Drawing.Size(73, 84);
            this.btnRpt4.TabIndex = 28;
            this.btnRpt4.Text = "Rpt 4";
            this.btnRpt4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRpt4.UseVisualStyleBackColor = false;
            this.btnRpt4.Click += new System.EventHandler(this.btnRpt4_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(931, 56);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 84);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvdatosviajes
            // 
            this.dgvdatosviajes.AllowUserToAddRows = false;
            this.dgvdatosviajes.AllowUserToDeleteRows = false;
            this.dgvdatosviajes.AllowUserToResizeColumns = false;
            this.dgvdatosviajes.AllowUserToResizeRows = false;
            this.dgvdatosviajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdatosviajes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvdatosviajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatosviajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvdatosviajes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatosviajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvdatosviajes.Location = new System.Drawing.Point(27, 227);
            this.dgvdatosviajes.MultiSelect = false;
            this.dgvdatosviajes.Name = "dgvdatosviajes";
            this.dgvdatosviajes.ReadOnly = true;
            this.dgvdatosviajes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvdatosviajes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdatosviajes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatosviajes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosviajes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosviajes.RowTemplate.Height = 28;
            this.dgvdatosviajes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosviajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosviajes.Size = new System.Drawing.Size(990, 284);
            this.dgvdatosviajes.TabIndex = 30;
            // 
            // nombreViaje
            // 
            this.nombreViaje.DataPropertyName = "nombreViaje";
            this.nombreViaje.HeaderText = "Viaje";
            this.nombreViaje.MinimumWidth = 6;
            this.nombreViaje.Name = "nombreViaje";
            this.nombreViaje.ReadOnly = true;
            // 
            // camion
            // 
            this.camion.DataPropertyName = "camion";
            this.camion.HeaderText = "Camion";
            this.camion.MinimumWidth = 6;
            this.camion.Name = "camion";
            this.camion.ReadOnly = true;
            // 
            // ruta
            // 
            this.ruta.DataPropertyName = "ruta";
            this.ruta.HeaderText = "Ruta";
            this.ruta.MinimumWidth = 6;
            this.ruta.Name = "ruta";
            this.ruta.ReadOnly = true;
            // 
            // fecha_salida
            // 
            this.fecha_salida.DataPropertyName = "fecha_salida";
            this.fecha_salida.HeaderText = "Fecha Salida";
            this.fecha_salida.MinimumWidth = 6;
            this.fecha_salida.Name = "fecha_salida";
            this.fecha_salida.ReadOnly = true;
            // 
            // hora_salida
            // 
            this.hora_salida.DataPropertyName = "hora_salida";
            this.hora_salida.HeaderText = "Hora Salida";
            this.hora_salida.MinimumWidth = 6;
            this.hora_salida.Name = "hora_salida";
            this.hora_salida.ReadOnly = true;
            // 
            // id_viaje
            // 
            this.id_viaje.DataPropertyName = "id_viaje";
            this.id_viaje.HeaderText = "id_viaje";
            this.id_viaje.MinimumWidth = 6;
            this.id_viaje.Name = "id_viaje";
            this.id_viaje.ReadOnly = true;
            this.id_viaje.Visible = false;
            // 
            // id_datosViaje
            // 
            this.id_datosViaje.DataPropertyName = "id_datosViaje";
            this.id_datosViaje.HeaderText = "id_datosViaje";
            this.id_datosViaje.MinimumWidth = 6;
            this.id_datosViaje.Name = "id_datosViaje";
            this.id_datosViaje.ReadOnly = true;
            this.id_datosViaje.Visible = false;
            // 
            // id_prestacionServicios1
            // 
            this.id_prestacionServicios1.DataPropertyName = "id_prestacionServicios1";
            this.id_prestacionServicios1.HeaderText = "id_prestacionServicios1";
            this.id_prestacionServicios1.MinimumWidth = 6;
            this.id_prestacionServicios1.Name = "id_prestacionServicios1";
            this.id_prestacionServicios1.ReadOnly = true;
            this.id_prestacionServicios1.Visible = false;
            // 
            // id_prestacionServicios2
            // 
            this.id_prestacionServicios2.DataPropertyName = "id_prestacionServicios2";
            this.id_prestacionServicios2.HeaderText = "id_prestacionServicios2";
            this.id_prestacionServicios2.MinimumWidth = 6;
            this.id_prestacionServicios2.Name = "id_prestacionServicios2";
            this.id_prestacionServicios2.ReadOnly = true;
            this.id_prestacionServicios2.Visible = false;
            // 
            // id_listapasajeros
            // 
            this.id_listapasajeros.DataPropertyName = "id_listapasajeros";
            this.id_listapasajeros.HeaderText = "id_listapasajeros";
            this.id_listapasajeros.MinimumWidth = 6;
            this.id_listapasajeros.Name = "id_listapasajeros";
            this.id_listapasajeros.ReadOnly = true;
            this.id_listapasajeros.Visible = false;
            // 
            // frmDatosViajesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 611);
            this.Controls.Add(this.panel1);
            this.Name = "frmDatosViajesV2";
            this.Text = "Datos Viaje";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRpt1;
        private System.Windows.Forms.Button btnRpt3;
        private System.Windows.Forms.Button btnRpt2;
        private System.Windows.Forms.Button btnRpt4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvdatosviajes;
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
    }
}