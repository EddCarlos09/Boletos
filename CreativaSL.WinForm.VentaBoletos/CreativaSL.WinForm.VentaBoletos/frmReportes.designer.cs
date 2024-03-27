namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.panelBusqueda = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.btn_VerTodos = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.LabelFolio = new System.Windows.Forms.Label();
            this.btn_Buscar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.LabelTurno = new System.Windows.Forms.Label();
            this.TxtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.LabelFechaFin = new System.Windows.Forms.Label();
            this.LabelFechaInicio = new System.Windows.Forms.Label();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa2 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelBusqueda.SuspendLayout();
            this.panelTitle_Creativa2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelBusqueda.BorderColor = System.Drawing.Color.Transparent;
            this.panelBusqueda.Controls.Add(this.btn_VerTodos);
            this.panelBusqueda.Controls.Add(this.label5);
            this.panelBusqueda.Controls.Add(this.label4);
            this.panelBusqueda.Controls.Add(this.txtFolio);
            this.panelBusqueda.Controls.Add(this.LabelFolio);
            this.panelBusqueda.Controls.Add(this.btn_Buscar);
            this.panelBusqueda.Controls.Add(this.cmbTurno);
            this.panelBusqueda.Controls.Add(this.LabelTurno);
            this.panelBusqueda.Controls.Add(this.TxtFechaFin);
            this.panelBusqueda.Controls.Add(this.TxtFechaInicio);
            this.panelBusqueda.Controls.Add(this.LabelFechaFin);
            this.panelBusqueda.Controls.Add(this.LabelFechaInicio);
            this.panelBusqueda.Controls.Add(this.btnSalir);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBusqueda.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1354, 131);
            this.panelBusqueda.SizeLine = 3;
            this.panelBusqueda.SizeTitle = 20;
            this.panelBusqueda.TabIndex = 8;
            this.panelBusqueda.Title = "";
            this.panelBusqueda.TitleColor = System.Drawing.Color.Transparent;
            // 
            // btn_VerTodos
            // 
            this.btn_VerTodos.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_VerTodos.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_VerTodos.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_VerTodos.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_VerTodos.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_VerTodos.FocusRectangle = true;
            this.btn_VerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerTodos.Image = null;
            this.btn_VerTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_VerTodos.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_VerTodos.ImageFocused = null;
            this.btn_VerTodos.ImageInactive = null;
            this.btn_VerTodos.ImageMouseOver = null;
            this.btn_VerTodos.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.CardGold;
            this.btn_VerTodos.ImagePressed = null;
            this.btn_VerTodos.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_VerTodos.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_VerTodos.KeyButtonView = false;
            this.btn_VerTodos.Location = new System.Drawing.Point(1050, 53);
            this.btn_VerTodos.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_VerTodos.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_VerTodos.Name = "btn_VerTodos";
            this.btn_VerTodos.OffsetPressedContent = true;
            this.btn_VerTodos.Size = new System.Drawing.Size(80, 65);
            this.btn_VerTodos.TabIndex = 42;
            this.btn_VerTodos.Text = "Ver Todos";
            this.btn_VerTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_VerTodos.TextDropShadow = true;
            this.btn_VerTodos.UseVisualStyleBackColor = false;
            this.btn_VerTodos.Click += new System.EventHandler(this.btn_VerTodos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(1138, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Acciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(271, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Búsqueda";
            // 
            // txtFolio
            // 
            this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.Location = new System.Drawing.Point(433, 88);
            this.txtFolio.MaxLength = 18;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(275, 27);
            this.txtFolio.TabIndex = 4;
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // LabelFolio
            // 
            this.LabelFolio.AutoSize = true;
            this.LabelFolio.BackColor = System.Drawing.Color.Transparent;
            this.LabelFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFolio.Location = new System.Drawing.Point(289, 89);
            this.LabelFolio.Name = "LabelFolio";
            this.LabelFolio.Size = new System.Drawing.Size(110, 22);
            this.LabelFolio.TabIndex = 39;
            this.LabelFolio.Text = "Folio Boleto:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Buscar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Buscar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Buscar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Buscar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Buscar.FocusRectangle = true;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Image = null;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Buscar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Buscar.ImageFocused = null;
            this.btn_Buscar.ImageInactive = null;
            this.btn_Buscar.ImageMouseOver = null;
            this.btn_Buscar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._34busqueda;
            this.btn_Buscar.ImagePressed = null;
            this.btn_Buscar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Buscar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Buscar.KeyButtonView = false;
            this.btn_Buscar.Location = new System.Drawing.Point(733, 53);
            this.btn_Buscar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Buscar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.OffsetPressedContent = true;
            this.btn_Buscar.Size = new System.Drawing.Size(80, 65);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Buscar.TextDropShadow = true;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(433, 54);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(275, 28);
            this.cmbTurno.TabIndex = 3;
            // 
            // LabelTurno
            // 
            this.LabelTurno.AutoSize = true;
            this.LabelTurno.BackColor = System.Drawing.Color.Transparent;
            this.LabelTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTurno.Location = new System.Drawing.Point(289, 56);
            this.LabelTurno.Name = "LabelTurno";
            this.LabelTurno.Size = new System.Drawing.Size(120, 22);
            this.LabelTurno.TabIndex = 36;
            this.LabelTurno.Text = "Caja / Cajero:";
            // 
            // TxtFechaFin
            // 
            this.TxtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaFin.Location = new System.Drawing.Point(128, 90);
            this.TxtFechaFin.Name = "TxtFechaFin";
            this.TxtFechaFin.Size = new System.Drawing.Size(124, 26);
            this.TxtFechaFin.TabIndex = 2;
            this.TxtFechaFin.ValueChanged += new System.EventHandler(this.TxtFechaFin_ValueChanged);
            // 
            // TxtFechaInicio
            // 
            this.TxtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaInicio.Location = new System.Drawing.Point(128, 53);
            this.TxtFechaInicio.Name = "TxtFechaInicio";
            this.TxtFechaInicio.Size = new System.Drawing.Size(124, 26);
            this.TxtFechaInicio.TabIndex = 1;
            this.TxtFechaInicio.ValueChanged += new System.EventHandler(this.TxtFechaInicio_ValueChanged);
            // 
            // LabelFechaFin
            // 
            this.LabelFechaFin.AutoSize = true;
            this.LabelFechaFin.BackColor = System.Drawing.Color.Transparent;
            this.LabelFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaFin.Location = new System.Drawing.Point(16, 90);
            this.LabelFechaFin.Name = "LabelFechaFin";
            this.LabelFechaFin.Size = new System.Drawing.Size(90, 22);
            this.LabelFechaFin.TabIndex = 33;
            this.LabelFechaFin.Text = "Fecha Fin";
            // 
            // LabelFechaInicio
            // 
            this.LabelFechaInicio.AutoSize = true;
            this.LabelFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.LabelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaInicio.Location = new System.Drawing.Point(16, 53);
            this.LabelFechaInicio.Name = "LabelFechaInicio";
            this.LabelFechaInicio.Size = new System.Drawing.Size(106, 22);
            this.LabelFechaInicio.TabIndex = 32;
            this.LabelFechaInicio.Text = "Fecha Inicio";
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
            this.btnSalir.KeyButton = System.Windows.Forms.Keys.None;
            this.btnSalir.KeyButtonView = false;
            this.btnSalir.Location = new System.Drawing.Point(1146, 53);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(80, 65);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelTitle_Creativa2
            // 
            this.panelTitle_Creativa2.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa2.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelTitle_Creativa2.Controls.Add(this.reportViewer1);
            this.panelTitle_Creativa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa2.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa2.Location = new System.Drawing.Point(0, 131);
            this.panelTitle_Creativa2.Name = "panelTitle_Creativa2";
            this.panelTitle_Creativa2.Size = new System.Drawing.Size(1354, 602);
            this.panelTitle_Creativa2.SizeLine = 3;
            this.panelTitle_Creativa2.SizeTitle = 20;
            this.panelTitle_Creativa2.TabIndex = 9;
            this.panelTitle_Creativa2.Title = "Informe";
            this.panelTitle_Creativa2.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(1354, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panelTitle_Creativa2);
            this.Controls.Add(this.panelBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelTitle_Creativa2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panelBusqueda;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa2;        
        private LibControls.WinForms.Button_Creativa btn_Buscar;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label LabelTurno;
        private System.Windows.Forms.DateTimePicker TxtFechaFin;
        private System.Windows.Forms.DateTimePicker TxtFechaInicio;
        private System.Windows.Forms.Label LabelFechaFin;
        private System.Windows.Forms.Label LabelFechaInicio;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label LabelFolio;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private LibControls.WinForms.Button_Creativa btn_VerTodos;
    }
}