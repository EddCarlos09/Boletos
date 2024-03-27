namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmFechasViajesDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFechasViajesDetalle));
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.panel_login_validator = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.dtPickerAnioMes = new System.Windows.Forms.DateTimePicker();
            this.LabelFechaInicio = new System.Windows.Forms.Label();
            this.dgvdatosViajesXFechas = new System.Windows.Forms.DataGridView();
            this.viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa1.SuspendLayout();
            this.panel_login_validator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosViajesXFechas)).BeginInit();
            this.panel_Creativa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa1.Controls.Add(this.panel_login_validator);
            this.panelTitle_Creativa1.Controls.Add(this.dgvdatosViajesXFechas);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(553, 334);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 5;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // panel_login_validator
            // 
            this.panel_login_validator.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_login_validator.BorderColor = System.Drawing.Color.Transparent;
            this.panel_login_validator.Controls.Add(this.dtPickerAnioMes);
            this.panel_login_validator.Controls.Add(this.LabelFechaInicio);
            this.panel_login_validator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_login_validator.DrawGradient = false;
            this.panel_login_validator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login_validator.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_login_validator.Location = new System.Drawing.Point(0, 0);
            this.panel_login_validator.Name = "panel_login_validator";
            this.panel_login_validator.Size = new System.Drawing.Size(553, 65);
            this.panel_login_validator.SizeLine = 3;
            this.panel_login_validator.SizeTitle = 20;
            this.panel_login_validator.TabIndex = 0;
            this.panel_login_validator.Title = "";
            this.panel_login_validator.TitleColor = System.Drawing.Color.Transparent;
            // 
            // dtPickerAnioMes
            // 
            this.dtPickerAnioMes.CustomFormat = "MM/yyyy";
            this.dtPickerAnioMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerAnioMes.Location = new System.Drawing.Point(270, 19);
            this.dtPickerAnioMes.Name = "dtPickerAnioMes";
            this.dtPickerAnioMes.Size = new System.Drawing.Size(124, 26);
            this.dtPickerAnioMes.TabIndex = 1;
            this.dtPickerAnioMes.ValueChanged += new System.EventHandler(this.dtPickerAnioMes_ValueChanged);
            // 
            // LabelFechaInicio
            // 
            this.LabelFechaInicio.AutoSize = true;
            this.LabelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaInicio.Location = new System.Drawing.Point(134, 21);
            this.LabelFechaInicio.Name = "LabelFechaInicio";
            this.LabelFechaInicio.Size = new System.Drawing.Size(60, 22);
            this.LabelFechaInicio.TabIndex = 0;
            this.LabelFechaInicio.Text = "Fecha";
            // 
            // dgvdatosViajesXFechas
            // 
            this.dgvdatosViajesXFechas.AllowUserToAddRows = false;
            this.dgvdatosViajesXFechas.AllowUserToDeleteRows = false;
            this.dgvdatosViajesXFechas.AllowUserToResizeColumns = false;
            this.dgvdatosViajesXFechas.AllowUserToResizeRows = false;
            this.dgvdatosViajesXFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosViajesXFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosViajesXFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viaje,
            this.fecha_viaje,
            this.hora_viaje,
            this.activo,
            this.Status});
            this.dgvdatosViajesXFechas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdatosViajesXFechas.Location = new System.Drawing.Point(0, 64);
            this.dgvdatosViajesXFechas.MultiSelect = false;
            this.dgvdatosViajesXFechas.Name = "dgvdatosViajesXFechas";
            this.dgvdatosViajesXFechas.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosViajesXFechas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatosViajesXFechas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosViajesXFechas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosViajesXFechas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosViajesXFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosViajesXFechas.Size = new System.Drawing.Size(553, 270);
            this.dgvdatosViajesXFechas.TabIndex = 2;
            // 
            // viaje
            // 
            this.viaje.DataPropertyName = "nombre";
            this.viaje.HeaderText = "Viaje";
            this.viaje.Name = "viaje";
            this.viaje.ReadOnly = true;
            this.viaje.Width = 69;
            // 
            // fecha_viaje
            // 
            this.fecha_viaje.DataPropertyName = "fechaviaje";
            this.fecha_viaje.HeaderText = "Fecha";
            this.fecha_viaje.Name = "fecha_viaje";
            this.fecha_viaje.ReadOnly = true;
            this.fecha_viaje.Width = 79;
            // 
            // hora_viaje
            // 
            this.hora_viaje.DataPropertyName = "horario";
            this.hora_viaje.HeaderText = "Hora ";
            this.hora_viaje.Name = "hora_viaje";
            this.hora_viaje.ReadOnly = true;
            this.hora_viaje.Width = 73;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            this.activo.Width = 75;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 62;
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.btn_Cancelar);
            this.panel_Creativa1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 333);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(553, 80);
            this.panel_Creativa1.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Cancelar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cancelar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Cancelar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Cancelar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Cancelar.FocusRectangle = true;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = null;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Cancelar.ImageFocused = null;
            this.btn_Cancelar.ImageInactive = null;
            this.btn_Cancelar.ImageMouseOver = null;
            this.btn_Cancelar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._10cancelar;
            this.btn_Cancelar.ImagePressed = null;
            this.btn_Cancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Cancelar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Cancelar.KeyButtonView = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(457, 8);
            this.btn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.OffsetPressedContent = true;
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 65);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.TextDropShadow = true;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frmFechasViajesDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(553, 413);
            this.Controls.Add(this.panel_Creativa1);
            this.Controls.Add(this.panelTitle_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFechasViajesDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechas Viaje";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFechasViajesDetalle_Load);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panel_login_validator.ResumeLayout(false);
            this.panel_login_validator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosViajesXFechas)).EndInit();
            this.panel_Creativa1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.DataGridView dgvdatosViajesXFechas;
        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btn_Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private LibControls.WinForms.PanelTitle_Creativa panel_login_validator;
        private System.Windows.Forms.DateTimePicker dtPickerAnioMes;
        private System.Windows.Forms.Label LabelFechaInicio;
    }
}