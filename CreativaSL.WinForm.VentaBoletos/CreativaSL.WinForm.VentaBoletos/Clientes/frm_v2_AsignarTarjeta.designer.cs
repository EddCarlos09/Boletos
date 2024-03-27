namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frm_v2_AsignarTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_v2_AsignarTarjeta));
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.panel_login_validator = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.button_Creativa1 = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.IDTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTarjetas = new CreativaSL.WinForm.VentaBoletos.Controls.CSLDataGridView();
            this.IDTarjetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitle_Creativa1.SuspendLayout();
            this.panel_login_validator.SuspendLayout();
            this.panel_Creativa1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.BackColor = System.Drawing.Color.White;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa1.Controls.Add(this.dgvTarjetas);
            this.panelTitle_Creativa1.Controls.Add(this.panel_login_validator);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(445, 334);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 5;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // panel_login_validator
            // 
            this.panel_login_validator.BackColor = System.Drawing.Color.White;
            this.panel_login_validator.BorderColor = System.Drawing.Color.Transparent;
            this.panel_login_validator.Controls.Add(this.LabelTitulo);
            this.panel_login_validator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_login_validator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login_validator.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_login_validator.Location = new System.Drawing.Point(0, 0);
            this.panel_login_validator.Name = "panel_login_validator";
            this.panel_login_validator.Size = new System.Drawing.Size(445, 64);
            this.panel_login_validator.SizeLine = 3;
            this.panel_login_validator.SizeTitle = 20;
            this.panel_login_validator.TabIndex = 41;
            this.panel_login_validator.Title = "";
            this.panel_login_validator.TitleColor = System.Drawing.Color.Transparent;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(53, 21);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(227, 22);
            this.LabelTitulo.TabIndex = 35;
            this.LabelTitulo.Text = "Numero Tajetas Disponible";
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.txtCantidad);
            this.panel_Creativa1.Controls.Add(this.lblCantidad2);
            this.panel_Creativa1.Controls.Add(this.lblCantidad);
            this.panel_Creativa1.Controls.Add(this.button_Creativa1);
            this.panel_Creativa1.Controls.Add(this.btn_Cancelar);
            this.panel_Creativa1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Creativa1.DrawGradient = true;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 315);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(445, 80);
            this.panel_Creativa1.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(115, 25);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(102, 23);
            this.txtCantidad.TabIndex = 145;
            this.txtCantidad.Text = "50";
            this.txtCantidad.Visible = false;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtPorcentaje_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad2.ForeColor = System.Drawing.Color.Maroon;
            this.lblCantidad2.Location = new System.Drawing.Point(5, 25);
            this.lblCantidad2.Margin = new System.Windows.Forms.Padding(0);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(23, 23);
            this.lblCantidad2.TabIndex = 144;
            this.lblCantidad2.Text = "*";
            this.lblCantidad2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCantidad2.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(28, 25);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(100, 23);
            this.lblCantidad.TabIndex = 143;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCantidad.Visible = false;
            // 
            // button_Creativa1
            // 
            this.button_Creativa1.BackColor = System.Drawing.Color.SkyBlue;
            this.button_Creativa1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Creativa1.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Creativa1.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.button_Creativa1.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.button_Creativa1.FocusRectangle = true;
            this.button_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Creativa1.Image = null;
            this.button_Creativa1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Creativa1.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.button_Creativa1.ImageFocused = null;
            this.button_Creativa1.ImageInactive = null;
            this.button_Creativa1.ImageMouseOver = null;
            this.button_Creativa1.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._35aceptar;
            this.button_Creativa1.ImagePressed = null;
            this.button_Creativa1.ImageSize = new System.Drawing.Size(40, 40);
            this.button_Creativa1.KeyButton = System.Windows.Forms.Keys.None;
            this.button_Creativa1.KeyButtonView = false;
            this.button_Creativa1.Location = new System.Drawing.Point(266, 7);
            this.button_Creativa1.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.button_Creativa1.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.button_Creativa1.Name = "button_Creativa1";
            this.button_Creativa1.OffsetPressedContent = true;
            this.button_Creativa1.Size = new System.Drawing.Size(80, 65);
            this.button_Creativa1.TabIndex = 23;
            this.button_Creativa1.Text = "Aceptar";
            this.button_Creativa1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Creativa1.TextDropShadow = true;
            this.button_Creativa1.UseVisualStyleBackColor = false;
            this.button_Creativa1.Click += new System.EventHandler(this.button_Creativa1_Click);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(353, 7);
            this.btn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.OffsetPressedContent = true;
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 65);
            this.btn_Cancelar.TabIndex = 22;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.TextDropShadow = true;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // IDTarjeta
            // 
            this.IDTarjeta.DataPropertyName = "IDTarjeta";
            this.IDTarjeta.HeaderText = "IDTarjeta";
            this.IDTarjeta.Name = "IDTarjeta";
            this.IDTarjeta.ReadOnly = true;
            this.IDTarjeta.Visible = false;
            // 
            // Folio
            // 
            this.Folio.DataPropertyName = "Folio";
            this.Folio.HeaderText = "Código";
            this.Folio.Name = "Folio";
            this.Folio.ReadOnly = true;
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTarjetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTarjetas,
            this.Folios});
            this.dgvTarjetas.Location = new System.Drawing.Point(0, 61);
            this.dgvTarjetas.MultiSelect = false;
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarjetas.Size = new System.Drawing.Size(445, 255);
            this.dgvTarjetas.TabIndex = 42;
            this.dgvTarjetas.ScrollMax += new System.EventHandler(this.dgvTarjetas_ScrollMax);
            // 
            // IDTarjetas
            // 
            this.IDTarjetas.DataPropertyName = "IDTarjeta";
            this.IDTarjetas.HeaderText = "IDTarjeta";
            this.IDTarjetas.Name = "IDTarjetas";
            this.IDTarjetas.ReadOnly = true;
            this.IDTarjetas.Visible = false;
            // 
            // Folios
            // 
            this.Folios.DataPropertyName = "Folio";
            this.Folios.HeaderText = "Código";
            this.Folios.Name = "Folios";
            this.Folios.ReadOnly = true;
            // 
            // frm_v2_AsignarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(445, 395);
            this.Controls.Add(this.panel_Creativa1);
            this.Controls.Add(this.panelTitle_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_v2_AsignarTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarjetas Disponibles";
            this.TopMost = true;
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panel_login_validator.ResumeLayout(false);
            this.panel_login_validator.PerformLayout();
            this.panel_Creativa1.ResumeLayout(false);
            this.panel_Creativa1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btn_Cancelar;
        private LibControls.WinForms.PanelTitle_Creativa panel_login_validator;
        private System.Windows.Forms.Label LabelTitulo;
        private Controls.CSLDataGridView dgvTarjetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private LibControls.WinForms.Button_Creativa button_Creativa1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCantidad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTarjetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folios;
    }
}