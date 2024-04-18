namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmReportesV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesV2));
            this.LabelFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.LabelFechaFin = new MaterialSkin.Controls.MaterialLabel();
            this.LabelTurno = new MaterialSkin.Controls.MaterialLabel();
            this.LabelFolio = new MaterialSkin.Controls.MaterialLabel();
            this.txtFolio = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbTurno = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.d = new MaterialSkin.Controls.MaterialLabel();
            this.btn_VerTodos = new System.Windows.Forms.Button();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // LabelFechaInicio
            // 
            this.LabelFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelFechaInicio.AutoSize = true;
            this.LabelFechaInicio.Depth = 0;
            this.LabelFechaInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFechaInicio.Location = new System.Drawing.Point(56, 86);
            this.LabelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFechaInicio.Name = "LabelFechaInicio";
            this.LabelFechaInicio.Size = new System.Drawing.Size(90, 19);
            this.LabelFechaInicio.TabIndex = 0;
            this.LabelFechaInicio.Text = "Fecha Inicio:";
            // 
            // LabelFechaFin
            // 
            this.LabelFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelFechaFin.AutoSize = true;
            this.LabelFechaFin.Depth = 0;
            this.LabelFechaFin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFechaFin.Location = new System.Drawing.Point(56, 163);
            this.LabelFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFechaFin.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFechaFin.Name = "LabelFechaFin";
            this.LabelFechaFin.Size = new System.Drawing.Size(74, 19);
            this.LabelFechaFin.TabIndex = 1;
            this.LabelFechaFin.Text = "Fecha Fin:";
            // 
            // LabelTurno
            // 
            this.LabelTurno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelTurno.AutoSize = true;
            this.LabelTurno.Depth = 0;
            this.LabelTurno.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelTurno.Location = new System.Drawing.Point(245, 86);
            this.LabelTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTurno.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTurno.Name = "LabelTurno";
            this.LabelTurno.Size = new System.Drawing.Size(85, 19);
            this.LabelTurno.TabIndex = 4;
            this.LabelTurno.Text = "Caja/Cajero";
            // 
            // LabelFolio
            // 
            this.LabelFolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelFolio.AutoSize = true;
            this.LabelFolio.Depth = 0;
            this.LabelFolio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFolio.Location = new System.Drawing.Point(245, 163);
            this.LabelFolio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFolio.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFolio.Name = "LabelFolio";
            this.LabelFolio.Size = new System.Drawing.Size(106, 19);
            this.LabelFolio.TabIndex = 5;
            this.LabelFolio.Text = "Folio de Boleto";
            // 
            // txtFolio
            // 
            this.txtFolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFolio.AnimateReadOnly = false;
            this.txtFolio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFolio.Depth = 0;
            this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFolio.HideSelection = true;
            this.txtFolio.LeadingIcon = null;
            this.txtFolio.Location = new System.Drawing.Point(248, 191);
            this.txtFolio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFolio.MaxLength = 32767;
            this.txtFolio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.PasswordChar = '\0';
            this.txtFolio.PrefixSuffixText = null;
            this.txtFolio.ReadOnly = false;
            this.txtFolio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFolio.SelectedText = "";
            this.txtFolio.SelectionLength = 0;
            this.txtFolio.SelectionStart = 0;
            this.txtFolio.ShortcutsEnabled = true;
            this.txtFolio.Size = new System.Drawing.Size(340, 48);
            this.txtFolio.TabIndex = 6;
            this.txtFolio.TabStop = false;
            this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFolio.TrailingIcon = null;
            this.txtFolio.UseSystemPasswordChar = false;
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Buscar.Location = new System.Drawing.Point(652, 133);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(79, 76);
            this.btn_Buscar.TabIndex = 11;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Location = new System.Drawing.Point(16, 249);
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
            this.reportViewer1.Size = new System.Drawing.Size(937, 281);
            this.reportViewer1.TabIndex = 12;
            // 
            // cmbTurno
            // 
            this.cmbTurno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTurno.AutoResize = false;
            this.cmbTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTurno.Depth = 0;
            this.cmbTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTurno.DropDownHeight = 174;
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.DropDownWidth = 121;
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.IntegralHeight = false;
            this.cmbTurno.ItemHeight = 43;
            this.cmbTurno.Location = new System.Drawing.Point(248, 112);
            this.cmbTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTurno.MaxDropDownItems = 4;
            this.cmbTurno.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(341, 49);
            this.cmbTurno.StartIndex = 0;
            this.cmbTurno.TabIndex = 13;
            // 
            // TxtFechaInicio
            // 
            this.TxtFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtFechaInicio.Location = new System.Drawing.Point(58, 121);
            this.TxtFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFechaInicio.Name = "TxtFechaInicio";
            this.TxtFechaInicio.Size = new System.Drawing.Size(151, 20);
            this.TxtFechaInicio.TabIndex = 14;
            this.TxtFechaInicio.ValueChanged += new System.EventHandler(this.TxtFechaInicio_ValueChanged);
            // 
            // TxtFechaFin
            // 
            this.TxtFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtFechaFin.Location = new System.Drawing.Point(58, 202);
            this.TxtFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFechaFin.Name = "TxtFechaFin";
            this.TxtFechaFin.Size = new System.Drawing.Size(151, 20);
            this.TxtFechaFin.TabIndex = 15;
            this.TxtFechaFin.ValueChanged += new System.EventHandler(this.TxtFechaFin_ValueChanged);
            // 
            // d
            // 
            this.d.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.d.AutoSize = true;
            this.d.Depth = 0;
            this.d.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.d.Location = new System.Drawing.Point(846, 74);
            this.d.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.d.MouseState = MaterialSkin.MouseState.HOVER;
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(65, 19);
            this.d.TabIndex = 16;
            this.d.Text = "Acciones";
            // 
            // btn_VerTodos
            // 
            this.btn_VerTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_VerTodos.Image = ((System.Drawing.Image)(resources.GetObject("btn_VerTodos.Image")));
            this.btn_VerTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_VerTodos.Location = new System.Drawing.Point(779, 133);
            this.btn_VerTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_VerTodos.Name = "btn_VerTodos";
            this.btn_VerTodos.Size = new System.Drawing.Size(79, 76);
            this.btn_VerTodos.TabIndex = 17;
            this.btn_VerTodos.Text = "Ver Todo";
            this.btn_VerTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_VerTodos.UseVisualStyleBackColor = true;
            this.btn_VerTodos.Click += new System.EventHandler(this.btn_VerTodos_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(55, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Busqueda";
            // 
            // frmReportesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 546);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_VerTodos);
            this.Controls.Add(this.d);
            this.Controls.Add(this.TxtFechaFin);
            this.Controls.Add(this.TxtFechaInicio);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.LabelFolio);
            this.Controls.Add(this.LabelTurno);
            this.Controls.Add(this.LabelFechaFin);
            this.Controls.Add(this.LabelFechaInicio);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReportesV2";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "frmReportesV2";
            this.Load += new System.EventHandler(this.frmReportesV2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabelFechaInicio;
        private MaterialSkin.Controls.MaterialLabel LabelFechaFin;
        private MaterialSkin.Controls.MaterialLabel LabelTurno;
        private MaterialSkin.Controls.MaterialLabel LabelFolio;
        private MaterialSkin.Controls.MaterialTextBox2 txtFolio;
        private System.Windows.Forms.Button btn_Buscar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MaterialSkin.Controls.MaterialComboBox cmbTurno;
        private System.Windows.Forms.DateTimePicker TxtFechaInicio;
        private System.Windows.Forms.DateTimePicker TxtFechaFin;
        private MaterialSkin.Controls.MaterialLabel d;
        private System.Windows.Forms.Button btn_VerTodos;
        private MaterialSkin.Controls.MaterialLabel label4;
    }
}