namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmReportesMenuV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesMenuV2));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.checkBox_Mensual = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkBox_Estadisticos = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnBoleto = new System.Windows.Forms.Button();
            this.btn_Vendedores = new System.Windows.Forms.Button();
            this.btnCajaXFechas = new System.Windows.Forms.Button();
            this.btn_TotalesCajaDia = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnViajes = new System.Windows.Forms.Button();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnClienteFrecuente = new System.Windows.Forms.Button();
            this.btnClienteComprador = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(37, 106);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(158, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Selecciona un Reporte";
            // 
            // checkBox_Mensual
            // 
            this.checkBox_Mensual.AutoSize = true;
            this.checkBox_Mensual.Depth = 0;
            this.checkBox_Mensual.Location = new System.Drawing.Point(40, 139);
            this.checkBox_Mensual.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_Mensual.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox_Mensual.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox_Mensual.Name = "checkBox_Mensual";
            this.checkBox_Mensual.ReadOnly = false;
            this.checkBox_Mensual.Ripple = true;
            this.checkBox_Mensual.Size = new System.Drawing.Size(96, 37);
            this.checkBox_Mensual.TabIndex = 1;
            this.checkBox_Mensual.Text = "Mensual";
            this.checkBox_Mensual.UseVisualStyleBackColor = true;
            this.checkBox_Mensual.CheckedChanged += new System.EventHandler(this.checkBox_Mensual_CheckedChanged);
            // 
            // checkBox_Estadisticos
            // 
            this.checkBox_Estadisticos.AutoSize = true;
            this.checkBox_Estadisticos.Depth = 0;
            this.checkBox_Estadisticos.Location = new System.Drawing.Point(178, 139);
            this.checkBox_Estadisticos.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_Estadisticos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox_Estadisticos.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox_Estadisticos.Name = "checkBox_Estadisticos";
            this.checkBox_Estadisticos.ReadOnly = false;
            this.checkBox_Estadisticos.Ripple = true;
            this.checkBox_Estadisticos.Size = new System.Drawing.Size(121, 37);
            this.checkBox_Estadisticos.TabIndex = 2;
            this.checkBox_Estadisticos.Text = "Estadisticos";
            this.checkBox_Estadisticos.UseVisualStyleBackColor = true;
            this.checkBox_Estadisticos.CheckedChanged += new System.EventHandler(this.checkBox_Estadisticos_CheckedChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 188);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(41, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Cajas";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnBoleto);
            this.materialCard1.Controls.Add(this.btn_Vendedores);
            this.materialCard1.Controls.Add(this.btnCajaXFechas);
            this.materialCard1.Controls.Add(this.btn_TotalesCajaDia);
            this.materialCard1.Controls.Add(this.btnCaja);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(31, 221);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(817, 124);
            this.materialCard1.TabIndex = 4;
            // 
            // btnBoleto
            // 
            this.btnBoleto.Image = ((System.Drawing.Image)(resources.GetObject("btnBoleto.Image")));
            this.btnBoleto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBoleto.Location = new System.Drawing.Point(651, 17);
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.Size = new System.Drawing.Size(134, 90);
            this.btnBoleto.TabIndex = 4;
            this.btnBoleto.Text = "Boletos";
            this.btnBoleto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBoleto.UseVisualStyleBackColor = true;
            this.btnBoleto.Click += new System.EventHandler(this.btnBoleto_Click);
            // 
            // btn_Vendedores
            // 
            this.btn_Vendedores.Image = ((System.Drawing.Image)(resources.GetObject("btn_Vendedores.Image")));
            this.btn_Vendedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Vendedores.Location = new System.Drawing.Point(490, 17);
            this.btn_Vendedores.Name = "btn_Vendedores";
            this.btn_Vendedores.Size = new System.Drawing.Size(134, 90);
            this.btn_Vendedores.TabIndex = 3;
            this.btn_Vendedores.Text = "Vendedores";
            this.btn_Vendedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Vendedores.UseVisualStyleBackColor = true;
            this.btn_Vendedores.Click += new System.EventHandler(this.btn_Vendedores_Click);
            // 
            // btnCajaXFechas
            // 
            this.btnCajaXFechas.Image = ((System.Drawing.Image)(resources.GetObject("btnCajaXFechas.Image")));
            this.btnCajaXFechas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCajaXFechas.Location = new System.Drawing.Point(333, 17);
            this.btnCajaXFechas.Name = "btnCajaXFechas";
            this.btnCajaXFechas.Size = new System.Drawing.Size(134, 90);
            this.btnCajaXFechas.TabIndex = 2;
            this.btnCajaXFechas.Text = "Caja x Fechas";
            this.btnCajaXFechas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCajaXFechas.UseVisualStyleBackColor = true;
            this.btnCajaXFechas.Click += new System.EventHandler(this.btnCajaXFechas_Click);
            // 
            // btn_TotalesCajaDia
            // 
            this.btn_TotalesCajaDia.Image = ((System.Drawing.Image)(resources.GetObject("btn_TotalesCajaDia.Image")));
            this.btn_TotalesCajaDia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_TotalesCajaDia.Location = new System.Drawing.Point(177, 17);
            this.btn_TotalesCajaDia.Name = "btn_TotalesCajaDia";
            this.btn_TotalesCajaDia.Size = new System.Drawing.Size(134, 90);
            this.btn_TotalesCajaDia.TabIndex = 1;
            this.btn_TotalesCajaDia.Text = "Totales Caja Dia";
            this.btn_TotalesCajaDia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TotalesCajaDia.UseVisualStyleBackColor = true;
            this.btn_TotalesCajaDia.Click += new System.EventHandler(this.btn_TotalesCajaDia_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCaja.Image")));
            this.btnCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCaja.Location = new System.Drawing.Point(21, 17);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(134, 90);
            this.btnCaja.TabIndex = 0;
            this.btnCaja.Text = "Caja";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnViajes);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(31, 364);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(180, 146);
            this.materialCard2.TabIndex = 5;
            // 
            // btnViajes
            // 
            this.btnViajes.Image = ((System.Drawing.Image)(resources.GetObject("btnViajes.Image")));
            this.btnViajes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViajes.Location = new System.Drawing.Point(17, 17);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(134, 112);
            this.btnViajes.TabIndex = 5;
            this.btnViajes.Text = "VIajes";
            this.btnViajes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViajes.UseVisualStyleBackColor = true;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnClienteFrecuente);
            this.materialCard3.Controls.Add(this.btnClienteComprador);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(313, 364);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(381, 146);
            this.materialCard3.TabIndex = 6;
            // 
            // btnClienteFrecuente
            // 
            this.btnClienteFrecuente.Image = ((System.Drawing.Image)(resources.GetObject("btnClienteFrecuente.Image")));
            this.btnClienteFrecuente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClienteFrecuente.Location = new System.Drawing.Point(208, 17);
            this.btnClienteFrecuente.Name = "btnClienteFrecuente";
            this.btnClienteFrecuente.Size = new System.Drawing.Size(134, 112);
            this.btnClienteFrecuente.TabIndex = 6;
            this.btnClienteFrecuente.Text = "Cliente Frec";
            this.btnClienteFrecuente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClienteFrecuente.UseVisualStyleBackColor = true;
            this.btnClienteFrecuente.Click += new System.EventHandler(this.btnClienteFrecuente_Click);
            // 
            // btnClienteComprador
            // 
            this.btnClienteComprador.Image = ((System.Drawing.Image)(resources.GetObject("btnClienteComprador.Image")));
            this.btnClienteComprador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClienteComprador.Location = new System.Drawing.Point(41, 17);
            this.btnClienteComprador.Name = "btnClienteComprador";
            this.btnClienteComprador.Size = new System.Drawing.Size(134, 112);
            this.btnClienteComprador.TabIndex = 7;
            this.btnClienteComprador.Text = "Cliente Comp";
            this.btnClienteComprador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClienteComprador.UseVisualStyleBackColor = true;
            this.btnClienteComprador.Click += new System.EventHandler(this.btnClienteComprador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(738, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 94);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmReportesMenuV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 558);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.checkBox_Estadisticos);
            this.Controls.Add(this.checkBox_Mensual);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmReportesMenuV2";
            this.Text = "frmReportesMenuV2";
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox checkBox_Mensual;
        private MaterialSkin.Controls.MaterialCheckbox checkBox_Estadisticos;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Button btnBoleto;
        private System.Windows.Forms.Button btn_Vendedores;
        private System.Windows.Forms.Button btnCajaXFechas;
        private System.Windows.Forms.Button btn_TotalesCajaDia;
        private System.Windows.Forms.Button btnCaja;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Button btnViajes;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Button btnClienteFrecuente;
        private System.Windows.Forms.Button btnClienteComprador;
        private System.Windows.Forms.Button btnSalir;
    }
}