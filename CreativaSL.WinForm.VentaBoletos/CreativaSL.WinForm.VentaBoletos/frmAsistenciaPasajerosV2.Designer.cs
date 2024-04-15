namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmAsistenciaPasajerosV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.CmbViaje = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_folio = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvdatosboleto = new System.Windows.Forms.DataGridView();
            this.id_boleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(386, 216);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(205, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Listado Asistencia Pasajeros";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CmbViaje);
            this.materialCard1.Controls.Add(this.txt_folio);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(998, 124);
            this.materialCard1.TabIndex = 7;
            // 
            // CmbViaje
            // 
            this.CmbViaje.AutoResize = false;
            this.CmbViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbViaje.Depth = 0;
            this.CmbViaje.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbViaje.DropDownHeight = 174;
            this.CmbViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbViaje.DropDownWidth = 121;
            this.CmbViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbViaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbViaje.FormattingEnabled = true;
            this.CmbViaje.IntegralHeight = false;
            this.CmbViaje.ItemHeight = 43;
            this.CmbViaje.Location = new System.Drawing.Point(100, 58);
            this.CmbViaje.MaxDropDownItems = 4;
            this.CmbViaje.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbViaje.Name = "CmbViaje";
            this.CmbViaje.Size = new System.Drawing.Size(250, 49);
            this.CmbViaje.StartIndex = 0;
            this.CmbViaje.TabIndex = 10;
            this.CmbViaje.SelectedValueChanged += new System.EventHandler(this.CmbViaje_SelectedValueChanged);
            // 
            // txt_folio
            // 
            this.txt_folio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_folio.AnimateReadOnly = false;
            this.txt_folio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_folio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_folio.Depth = 0;
            this.txt_folio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_folio.HideSelection = true;
            this.txt_folio.LeadingIcon = null;
            this.txt_folio.Location = new System.Drawing.Point(674, 59);
            this.txt_folio.MaxLength = 32767;
            this.txt_folio.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_folio.Name = "txt_folio";
            this.txt_folio.PasswordChar = '\0';
            this.txt_folio.PrefixSuffixText = null;
            this.txt_folio.ReadOnly = false;
            this.txt_folio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_folio.SelectedText = "";
            this.txt_folio.SelectionLength = 0;
            this.txt_folio.SelectionStart = 0;
            this.txt_folio.ShortcutsEnabled = true;
            this.txt_folio.Size = new System.Drawing.Size(250, 48);
            this.txt_folio.TabIndex = 9;
            this.txt_folio.TabStop = false;
            this.txt_folio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_folio.TrailingIcon = null;
            this.txt_folio.UseSystemPasswordChar = false;
            this.txt_folio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_folio_KeyDown);
            this.txt_folio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_folio_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(714, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(165, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Ingrese Folio del Boleto";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(613, 69);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(36, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Folio";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(199, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Viaje";
            // 
            // dgvdatosboleto
            // 
            this.dgvdatosboleto.AllowUserToAddRows = false;
            this.dgvdatosboleto.AllowUserToDeleteRows = false;
            this.dgvdatosboleto.AllowUserToResizeColumns = false;
            this.dgvdatosboleto.AllowUserToResizeRows = false;
            this.dgvdatosboleto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosboleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosboleto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_boleto,
            this.asiento,
            this.CodigoBarra,
            this.NombrePersona,
            this.numeroTelefono,
            this.asistencia,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatosboleto.Location = new System.Drawing.Point(17, 249);
            this.dgvdatosboleto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdatosboleto.MultiSelect = false;
            this.dgvdatosboleto.Name = "dgvdatosboleto";
            this.dgvdatosboleto.ReadOnly = true;
            this.dgvdatosboleto.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboleto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboleto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboleto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboleto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboleto.Size = new System.Drawing.Size(998, 341);
            this.dgvdatosboleto.TabIndex = 15;
            // 
            // id_boleto
            // 
            this.id_boleto.DataPropertyName = "id_boleto";
            this.id_boleto.HeaderText = "id_boleto";
            this.id_boleto.MinimumWidth = 6;
            this.id_boleto.Name = "id_boleto";
            this.id_boleto.ReadOnly = true;
            this.id_boleto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_boleto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_boleto.Visible = false;
            this.id_boleto.Width = 80;
            // 
            // asiento
            // 
            this.asiento.DataPropertyName = "asiento";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.asiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.asiento.HeaderText = "Asiento";
            this.asiento.MinimumWidth = 6;
            this.asiento.Name = "asiento";
            this.asiento.ReadOnly = true;
            this.asiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.asiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.asiento.Width = 58;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.DataPropertyName = "folio";
            this.CodigoBarra.HeaderText = "Folio";
            this.CodigoBarra.MinimumWidth = 6;
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.ReadOnly = true;
            this.CodigoBarra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoBarra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoBarra.Width = 43;
            // 
            // NombrePersona
            // 
            this.NombrePersona.DataPropertyName = "cliente_nombre";
            this.NombrePersona.HeaderText = "Nombre";
            this.NombrePersona.MinimumWidth = 6;
            this.NombrePersona.Name = "NombrePersona";
            this.NombrePersona.ReadOnly = true;
            this.NombrePersona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombrePersona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombrePersona.Width = 62;
            // 
            // numeroTelefono
            // 
            this.numeroTelefono.DataPropertyName = "numeroTelefono";
            this.numeroTelefono.HeaderText = "Teléfono";
            this.numeroTelefono.MinimumWidth = 6;
            this.numeroTelefono.Name = "numeroTelefono";
            this.numeroTelefono.ReadOnly = true;
            this.numeroTelefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numeroTelefono.Width = 67;
            // 
            // asistencia
            // 
            this.asistencia.DataPropertyName = "asistencia";
            this.asistencia.HeaderText = "asistencia";
            this.asistencia.MinimumWidth = 6;
            this.asistencia.Name = "asistencia";
            this.asistencia.ReadOnly = true;
            this.asistencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.asistencia.Visible = false;
            this.asistencia.Width = 86;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 50;
            // 
            // frmAsistenciaPasajerosV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 624);
            this.Controls.Add(this.dgvdatosboleto);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialLabel4);
            this.Name = "frmAsistenciaPasajerosV2";
            this.Text = "frmAsistenciaPasajerosV2";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboleto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_folio;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox CmbViaje;
        private System.Windows.Forms.DataGridView dgvdatosboleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_boleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn asistencia;
        private System.Windows.Forms.DataGridViewImageColumn Status;
    }
}