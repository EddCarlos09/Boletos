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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_VerTodos = new System.Windows.Forms.Button();
            this.d = new MaterialSkin.Controls.MaterialLabel();
            this.TxtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbTurno = new MaterialSkin.Controls.MaterialComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txtFolio = new MaterialSkin.Controls.MaterialTextBox2();
            this.LabelFolio = new MaterialSkin.Controls.MaterialLabel();
            this.LabelTurno = new MaterialSkin.Controls.MaterialLabel();
            this.LabelFechaFin = new MaterialSkin.Controls.MaterialLabel();
            this.LabelFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.btn_VerTodos);
            this.materialCard1.Controls.Add(this.d);
            this.materialCard1.Controls.Add(this.TxtFechaFin);
            this.materialCard1.Controls.Add(this.TxtFechaInicio);
            this.materialCard1.Controls.Add(this.cmbTurno);
            this.materialCard1.Controls.Add(this.reportViewer1);
            this.materialCard1.Controls.Add(this.btn_Buscar);
            this.materialCard1.Controls.Add(this.txtFolio);
            this.materialCard1.Controls.Add(this.LabelFolio);
            this.materialCard1.Controls.Add(this.LabelTurno);
            this.materialCard1.Controls.Add(this.LabelFechaFin);
            this.materialCard1.Controls.Add(this.LabelFechaInicio);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(4, 20);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1290, 636);
            this.materialCard1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(73, 25);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Busqueda";
            // 
            // btn_VerTodos
            // 
            this.btn_VerTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_VerTodos.Image = ((System.Drawing.Image)(resources.GetObject("btn_VerTodos.Image")));
            this.btn_VerTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_VerTodos.Location = new System.Drawing.Point(1039, 125);
            this.btn_VerTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_VerTodos.Name = "btn_VerTodos";
            this.btn_VerTodos.Size = new System.Drawing.Size(105, 94);
            this.btn_VerTodos.TabIndex = 31;
            this.btn_VerTodos.Text = "Ver Todo";
            this.btn_VerTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_VerTodos.UseVisualStyleBackColor = true;
            // 
            // d
            // 
            this.d.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.d.AutoSize = true;
            this.d.Depth = 0;
            this.d.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.d.Location = new System.Drawing.Point(1128, 52);
            this.d.MouseState = MaterialSkin.MouseState.HOVER;
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(65, 19);
            this.d.TabIndex = 30;
            this.d.Text = "Acciones";
            // 
            // TxtFechaFin
            // 
            this.TxtFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtFechaFin.Location = new System.Drawing.Point(77, 210);
            this.TxtFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFechaFin.Name = "TxtFechaFin";
            this.TxtFechaFin.Size = new System.Drawing.Size(200, 22);
            this.TxtFechaFin.TabIndex = 29;
            // 
            // TxtFechaInicio
            // 
            this.TxtFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtFechaInicio.Location = new System.Drawing.Point(77, 110);
            this.TxtFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtFechaInicio.Name = "TxtFechaInicio";
            this.TxtFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.TxtFechaInicio.TabIndex = 28;
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
            this.cmbTurno.Location = new System.Drawing.Point(331, 99);
            this.cmbTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTurno.MaxDropDownItems = 4;
            this.cmbTurno.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(453, 49);
            this.cmbTurno.StartIndex = 0;
            this.cmbTurno.TabIndex = 27;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Location = new System.Drawing.Point(8, 267);
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
            this.reportViewer1.Size = new System.Drawing.Size(1274, 345);
            this.reportViewer1.TabIndex = 26;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Buscar.Location = new System.Drawing.Point(869, 125);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(105, 94);
            this.btn_Buscar.TabIndex = 25;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Buscar.UseVisualStyleBackColor = true;
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
            this.txtFolio.Location = new System.Drawing.Point(331, 196);
            this.txtFolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtFolio.Size = new System.Drawing.Size(453, 48);
            this.txtFolio.TabIndex = 24;
            this.txtFolio.TabStop = false;
            this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFolio.TrailingIcon = null;
            this.txtFolio.UseSystemPasswordChar = false;
            // 
            // LabelFolio
            // 
            this.LabelFolio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelFolio.AutoSize = true;
            this.LabelFolio.Depth = 0;
            this.LabelFolio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFolio.Location = new System.Drawing.Point(327, 162);
            this.LabelFolio.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFolio.Name = "LabelFolio";
            this.LabelFolio.Size = new System.Drawing.Size(106, 19);
            this.LabelFolio.TabIndex = 23;
            this.LabelFolio.Text = "Folio de Boleto";
            // 
            // LabelTurno
            // 
            this.LabelTurno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelTurno.AutoSize = true;
            this.LabelTurno.Depth = 0;
            this.LabelTurno.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelTurno.Location = new System.Drawing.Point(327, 67);
            this.LabelTurno.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTurno.Name = "LabelTurno";
            this.LabelTurno.Size = new System.Drawing.Size(85, 19);
            this.LabelTurno.TabIndex = 22;
            this.LabelTurno.Text = "Caja/Cajero";
            // 
            // LabelFechaFin
            // 
            this.LabelFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelFechaFin.AutoSize = true;
            this.LabelFechaFin.Depth = 0;
            this.LabelFechaFin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFechaFin.Location = new System.Drawing.Point(75, 162);
            this.LabelFechaFin.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFechaFin.Name = "LabelFechaFin";
            this.LabelFechaFin.Size = new System.Drawing.Size(74, 19);
            this.LabelFechaFin.TabIndex = 21;
            this.LabelFechaFin.Text = "Fecha Fin:";
            // 
            // LabelFechaInicio
            // 
            this.LabelFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelFechaInicio.AutoSize = true;
            this.LabelFechaInicio.Depth = 0;
            this.LabelFechaInicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelFechaInicio.Location = new System.Drawing.Point(75, 67);
            this.LabelFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelFechaInicio.Name = "LabelFechaInicio";
            this.LabelFechaInicio.Size = new System.Drawing.Size(90, 19);
            this.LabelFechaInicio.TabIndex = 20;
            this.LabelFechaInicio.Text = "Fecha Inicio:";
            // 
            // frmReportesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 672);
            this.ControlBox = false;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReportesV2";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "frmReportesV2";
            this.Load += new System.EventHandler(this.frmReportesV2_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel label4;
        private System.Windows.Forms.Button btn_VerTodos;
        private MaterialSkin.Controls.MaterialLabel d;
        private System.Windows.Forms.DateTimePicker TxtFechaFin;
        private System.Windows.Forms.DateTimePicker TxtFechaInicio;
        private MaterialSkin.Controls.MaterialComboBox cmbTurno;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_Buscar;
        private MaterialSkin.Controls.MaterialTextBox2 txtFolio;
        private MaterialSkin.Controls.MaterialLabel LabelFolio;
        private MaterialSkin.Controls.MaterialLabel LabelTurno;
        private MaterialSkin.Controls.MaterialLabel LabelFechaFin;
        private MaterialSkin.Controls.MaterialLabel LabelFechaInicio;
    }
}