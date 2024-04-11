namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmFechaViajeDetalleV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFechaViajeDetalleV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvdatosViajesXFechas = new System.Windows.Forms.DataGridView();
            this.viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dtPickerAnioMes = new System.Windows.Forms.DateTimePicker();
            this.LabelFechaInicio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosViajesXFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvdatosViajesXFechas);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.dtPickerAnioMes);
            this.panel1.Controls.Add(this.LabelFechaInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 466);
            this.panel1.TabIndex = 0;
            // 
            // dgvdatosViajesXFechas
            // 
            this.dgvdatosViajesXFechas.AllowUserToAddRows = false;
            this.dgvdatosViajesXFechas.AllowUserToDeleteRows = false;
            this.dgvdatosViajesXFechas.AllowUserToResizeColumns = false;
            this.dgvdatosViajesXFechas.AllowUserToResizeRows = false;
            this.dgvdatosViajesXFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosViajesXFechas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvdatosViajesXFechas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvdatosViajesXFechas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatosViajesXFechas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdatosViajesXFechas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatosViajesXFechas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatosViajesXFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosViajesXFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viaje,
            this.fecha_viaje,
            this.hora_viaje,
            this.activo,
            this.Status});
            this.dgvdatosViajesXFechas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvdatosViajesXFechas.Location = new System.Drawing.Point(60, 67);
            this.dgvdatosViajesXFechas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdatosViajesXFechas.MultiSelect = false;
            this.dgvdatosViajesXFechas.Name = "dgvdatosViajesXFechas";
            this.dgvdatosViajesXFechas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatosViajesXFechas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatosViajesXFechas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosViajesXFechas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdatosViajesXFechas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosViajesXFechas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosViajesXFechas.RowTemplate.Height = 28;
            this.dgvdatosViajesXFechas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosViajesXFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosViajesXFechas.Size = new System.Drawing.Size(687, 259);
            this.dgvdatosViajesXFechas.TabIndex = 64;
            // 
            // viaje
            // 
            this.viaje.DataPropertyName = "nombre";
            this.viaje.HeaderText = "Viaje";
            this.viaje.MinimumWidth = 6;
            this.viaje.Name = "viaje";
            this.viaje.ReadOnly = true;
            this.viaje.Width = 85;
            // 
            // fecha_viaje
            // 
            this.fecha_viaje.DataPropertyName = "fechaviaje";
            this.fecha_viaje.HeaderText = "Fecha";
            this.fecha_viaje.MinimumWidth = 6;
            this.fecha_viaje.Name = "fecha_viaje";
            this.fecha_viaje.ReadOnly = true;
            this.fecha_viaje.Width = 96;
            // 
            // hora_viaje
            // 
            this.hora_viaje.DataPropertyName = "horario";
            this.hora_viaje.HeaderText = "Hora ";
            this.hora_viaje.MinimumWidth = 6;
            this.hora_viaje.Name = "hora_viaje";
            this.hora_viaje.ReadOnly = true;
            this.hora_viaje.Width = 88;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            this.activo.Width = 92;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 74;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(618, 333);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_Cancelar.Size = new System.Drawing.Size(129, 113);
            this.btn_Cancelar.TabIndex = 63;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dtPickerAnioMes
            // 
            this.dtPickerAnioMes.CustomFormat = "MM/yyyy";
            this.dtPickerAnioMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerAnioMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerAnioMes.Location = new System.Drawing.Point(170, 29);
            this.dtPickerAnioMes.Margin = new System.Windows.Forms.Padding(4);
            this.dtPickerAnioMes.Name = "dtPickerAnioMes";
            this.dtPickerAnioMes.Size = new System.Drawing.Size(156, 30);
            this.dtPickerAnioMes.TabIndex = 2;
            this.dtPickerAnioMes.ValueChanged += new System.EventHandler(this.dtPickerAnioMes_ValueChanged);
            // 
            // LabelFechaInicio
            // 
            this.LabelFechaInicio.AutoSize = true;
            this.LabelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaInicio.ForeColor = System.Drawing.Color.Navy;
            this.LabelFechaInicio.Location = new System.Drawing.Point(55, 29);
            this.LabelFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFechaInicio.Name = "LabelFechaInicio";
            this.LabelFechaInicio.Size = new System.Drawing.Size(77, 26);
            this.LabelFechaInicio.TabIndex = 1;
            this.LabelFechaInicio.Text = "Fecha";
            // 
            // frmFechaViajeDetalleV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 533);
            this.Controls.Add(this.panel1);
            this.Name = "frmFechaViajeDetalleV2";
            this.Text = "frmFechaViajeDetalleV2";
            this.Load += new System.EventHandler(this.frmFechasViajesDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosViajesXFechas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelFechaInicio;
        private System.Windows.Forms.DateTimePicker dtPickerAnioMes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridView dgvdatosViajesXFechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewImageColumn Status;
    }
}