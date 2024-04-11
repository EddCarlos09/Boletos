namespace CreativaSL.WinForm.VentaBoletos.Clientes
{
    partial class frm_v2_AsignarTarjetaV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_v2_AsignarTarjetaV2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.button_Creativa1 = new System.Windows.Forms.Button();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTarjetas = new CreativaSL.WinForm.VentaBoletos.Controls.CSLDataGridView();
            this.IDTarjetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvTarjetas);
            this.panel1.Controls.Add(this.lblCantidad2);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.button_Creativa1);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 507);
            this.panel1.TabIndex = 0;
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad2.ForeColor = System.Drawing.Color.Maroon;
            this.lblCantidad2.Location = new System.Drawing.Point(44, 91);
            this.lblCantidad2.Margin = new System.Windows.Forms.Padding(0);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(31, 28);
            this.lblCantidad2.TabIndex = 145;
            this.lblCantidad2.Text = "*";
            this.lblCantidad2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCantidad2.Visible = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(416, 385);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Cancelar.Size = new System.Drawing.Size(163, 98);
            this.btn_Cancelar.TabIndex = 61;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // button_Creativa1
            // 
            this.button_Creativa1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Creativa1.ForeColor = System.Drawing.Color.DimGray;
            this.button_Creativa1.Image = ((System.Drawing.Image)(resources.GetObject("button_Creativa1.Image")));
            this.button_Creativa1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Creativa1.Location = new System.Drawing.Point(202, 385);
            this.button_Creativa1.Name = "button_Creativa1";
            this.button_Creativa1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.button_Creativa1.Size = new System.Drawing.Size(163, 98);
            this.button_Creativa1.TabIndex = 60;
            this.button_Creativa1.Text = "Guardar";
            this.button_Creativa1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Creativa1.UseVisualStyleBackColor = true;
            this.button_Creativa1.Click += new System.EventHandler(this.button_Creativa1_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.AnimateReadOnly = false;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(190, 79);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(223, 50);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "50";
            this.txtCantidad.TrailingIcon = null;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Gray;
            this.lblCantidad.Location = new System.Drawing.Point(78, 92);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(91, 25);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Tajetas Disponible";
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTarjetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarjetas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTarjetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarjetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTarjetas,
            this.Folios});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarjetas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTarjetas.Location = new System.Drawing.Point(53, 146);
            this.dgvTarjetas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTarjetas.MultiSelect = false;
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.RowHeadersWidth = 51;
            this.dgvTarjetas.RowTemplate.Height = 30;
            this.dgvTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarjetas.Size = new System.Drawing.Size(648, 217);
            this.dgvTarjetas.TabIndex = 146;
            this.dgvTarjetas.ScrollMax += new System.EventHandler(this.dgvTarjetas_ScrollMax);
            // 
            // IDTarjetas
            // 
            this.IDTarjetas.DataPropertyName = "IDTarjeta";
            this.IDTarjetas.HeaderText = "IDTarjeta";
            this.IDTarjetas.MinimumWidth = 6;
            this.IDTarjetas.Name = "IDTarjetas";
            this.IDTarjetas.ReadOnly = true;
            this.IDTarjetas.Visible = false;
            // 
            // Folios
            // 
            this.Folios.DataPropertyName = "Folio";
            this.Folios.HeaderText = "Código";
            this.Folios.MinimumWidth = 6;
            this.Folios.Name = "Folios";
            this.Folios.ReadOnly = true;
            // 
            // frm_v2_AsignarTarjetaV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.panel1);
            this.Name = "frm_v2_AsignarTarjetaV2";
            this.Text = "frm_v2_AsignarTarjetaV2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidad;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private System.Windows.Forms.Button button_Creativa1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lblCantidad2;
        private Controls.CSLDataGridView dgvTarjetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTarjetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folios;
    }
}