namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmFechasViajesDetalleV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFechasViajesDetalleV2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dtPickerAnioMes = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdatosViajesXFechas = new System.Windows.Forms.DataGridView();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosViajesXFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvdatosViajesXFechas);
            this.materialCard1.Controls.Add(this.btn_Cancelar);
            this.materialCard1.Controls.Add(this.dtPickerAnioMes);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(2, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(969, 493);
            this.materialCard1.TabIndex = 0;
            // 
            // dtPickerAnioMes
            // 
            this.dtPickerAnioMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtPickerAnioMes.Location = new System.Drawing.Point(351, 23);
            this.dtPickerAnioMes.Name = "dtPickerAnioMes";
            this.dtPickerAnioMes.Size = new System.Drawing.Size(289, 22);
            this.dtPickerAnioMes.TabIndex = 1;
            this.dtPickerAnioMes.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            this.dtPickerAnioMes.ValueChanged += new System.EventHandler(this.dtPickerAnioMes_ValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(160, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Fecha:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(775, 17);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 94);
            this.btn_Cancelar.TabIndex = 65;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            // 
            // hora_viaje
            // 
            this.hora_viaje.DataPropertyName = "horario";
            this.hora_viaje.HeaderText = "Hora ";
            this.hora_viaje.MinimumWidth = 6;
            this.hora_viaje.Name = "hora_viaje";
            this.hora_viaje.ReadOnly = true;
            // 
            // fecha_viaje
            // 
            this.fecha_viaje.DataPropertyName = "fechaviaje";
            this.fecha_viaje.HeaderText = "Fecha";
            this.fecha_viaje.MinimumWidth = 6;
            this.fecha_viaje.Name = "fecha_viaje";
            this.fecha_viaje.ReadOnly = true;
            // 
            // viaje
            // 
            this.viaje.DataPropertyName = "nombre";
            this.viaje.HeaderText = "Viaje";
            this.viaje.MinimumWidth = 6;
            this.viaje.Name = "viaje";
            this.viaje.ReadOnly = true;
            // 
            // dgvdatosViajesXFechas
            // 
            this.dgvdatosViajesXFechas.AllowUserToAddRows = false;
            this.dgvdatosViajesXFechas.AllowUserToDeleteRows = false;
            this.dgvdatosViajesXFechas.AllowUserToResizeColumns = false;
            this.dgvdatosViajesXFechas.AllowUserToResizeRows = false;
            this.dgvdatosViajesXFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdatosViajesXFechas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdatosViajesXFechas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdatosViajesXFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosViajesXFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viaje,
            this.fecha_viaje,
            this.hora_viaje,
            this.activo,
            this.Status});
            this.dgvdatosViajesXFechas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdatosViajesXFechas.Location = new System.Drawing.Point(14, 147);
            this.dgvdatosViajesXFechas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdatosViajesXFechas.MultiSelect = false;
            this.dgvdatosViajesXFechas.Name = "dgvdatosViajesXFechas";
            this.dgvdatosViajesXFechas.ReadOnly = true;
            this.dgvdatosViajesXFechas.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosViajesXFechas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatosViajesXFechas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosViajesXFechas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosViajesXFechas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosViajesXFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosViajesXFechas.Size = new System.Drawing.Size(941, 332);
            this.dgvdatosViajesXFechas.TabIndex = 66;
            // 
            // frmFechasViajesDetalleV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 573);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmFechasViajesDetalleV2";
            this.Text = "frmFechasViajesDetalleV2";
            this.Load += new System.EventHandler(this.frmFechasViajesDetalleV2_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosViajesXFechas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
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