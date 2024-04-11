namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCambioBoletoViajeV2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioBoletoViajeV2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvdatosboletosviajenuevo = new System.Windows.Forms.DataGridView();
            this.num2_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen2_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre2_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status2_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_terminalXruta2_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ruta2_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_terminalSalida2_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_terminalDestino2_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdatosboletosviajeviejo = new System.Windows.Forms.DataGridView();
            this.num1_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen1_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino1_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_status1_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_terminalXruta1_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ruta1_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_terminalSalida1_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_terminalDestino1_asientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdatosviajenuevo = new System.Windows.Forms.DataGridView();
            this.rutas_origen2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutas_destino2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_rutas_boletos_ocup2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.CmbViajeViejo = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbViajeNuevo = new MaterialSkin.Controls.MaterialComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_AsientosOcupadosNuevo = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_AsientosNuevo = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_HoraNuevo = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_FechaNuevo = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_LineaNuevo = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_AsientosOcupadosViejo = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_AsientosViejo = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_HoraViejo = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_FechaViejo = new MaterialSkin.Controls.MaterialTextBox();
            this.Txt_LineaViejo = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.DtmFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvdatosviajeviejo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboletosviajenuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboletosviajeviejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajenuevo)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajeviejo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dgvdatosviajeviejo);
            this.panel1.Controls.Add(this.dgvdatosboletosviajenuevo);
            this.panel1.Controls.Add(this.dgvdatosboletosviajeviejo);
            this.panel1.Controls.Add(this.dgvdatosviajenuevo);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnComprobar);
            this.panel1.Controls.Add(this.CmbViajeViejo);
            this.panel1.Controls.Add(this.CmbViajeNuevo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txt_AsientosOcupadosNuevo);
            this.panel1.Controls.Add(this.Txt_AsientosNuevo);
            this.panel1.Controls.Add(this.Txt_HoraNuevo);
            this.panel1.Controls.Add(this.Txt_FechaNuevo);
            this.panel1.Controls.Add(this.Txt_LineaNuevo);
            this.panel1.Controls.Add(this.Txt_AsientosOcupadosViejo);
            this.panel1.Controls.Add(this.Txt_AsientosViejo);
            this.panel1.Controls.Add(this.Txt_HoraViejo);
            this.panel1.Controls.Add(this.Txt_FechaViejo);
            this.panel1.Controls.Add(this.Txt_LineaViejo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 1035);
            this.panel1.TabIndex = 6;
            // 
            // dgvdatosboletosviajenuevo
            // 
            this.dgvdatosboletosviajenuevo.AllowUserToAddRows = false;
            this.dgvdatosboletosviajenuevo.AllowUserToDeleteRows = false;
            this.dgvdatosboletosviajenuevo.AllowUserToResizeColumns = false;
            this.dgvdatosboletosviajenuevo.AllowUserToResizeRows = false;
            this.dgvdatosboletosviajenuevo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosboletosviajenuevo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvdatosboletosviajenuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosboletosviajenuevo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num2_asientos,
            this.origen2_asientos,
            this.Destino,
            this.nombre2_asientos,
            this.id_status2_asientos,
            this.id_terminalXruta2_asientos,
            this.id_ruta2_asientos,
            this.id_terminalSalida2_asientos,
            this.id_terminalDestino2_asientos});
            this.dgvdatosboletosviajenuevo.Location = new System.Drawing.Point(504, 852);
            this.dgvdatosboletosviajenuevo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdatosboletosviajenuevo.MultiSelect = false;
            this.dgvdatosboletosviajenuevo.Name = "dgvdatosboletosviajenuevo";
            this.dgvdatosboletosviajenuevo.ReadOnly = true;
            this.dgvdatosboletosviajenuevo.RowHeadersWidth = 51;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboletosviajenuevo.RowsDefaultCellStyle = dataGridViewCellStyle50;
            this.dgvdatosboletosviajenuevo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboletosviajenuevo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboletosviajenuevo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboletosviajenuevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboletosviajenuevo.Size = new System.Drawing.Size(421, 176);
            this.dgvdatosboletosviajenuevo.TabIndex = 33;
            // 
            // num2_asientos
            // 
            this.num2_asientos.DataPropertyName = "asiento";
            this.num2_asientos.HeaderText = "#";
            this.num2_asientos.MinimumWidth = 6;
            this.num2_asientos.Name = "num2_asientos";
            this.num2_asientos.ReadOnly = true;
            this.num2_asientos.Width = 43;
            // 
            // origen2_asientos
            // 
            this.origen2_asientos.DataPropertyName = "origen";
            this.origen2_asientos.HeaderText = "Origen";
            this.origen2_asientos.MinimumWidth = 6;
            this.origen2_asientos.Name = "origen2_asientos";
            this.origen2_asientos.ReadOnly = true;
            this.origen2_asientos.Width = 76;
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "destino";
            this.Destino.HeaderText = "Destino";
            this.Destino.MinimumWidth = 6;
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 82;
            // 
            // nombre2_asientos
            // 
            this.nombre2_asientos.DataPropertyName = "cliente_nombre";
            this.nombre2_asientos.HeaderText = "Nombre";
            this.nombre2_asientos.MinimumWidth = 6;
            this.nombre2_asientos.Name = "nombre2_asientos";
            this.nombre2_asientos.ReadOnly = true;
            this.nombre2_asientos.Width = 85;
            // 
            // id_status2_asientos
            // 
            this.id_status2_asientos.DataPropertyName = "id_status";
            this.id_status2_asientos.HeaderText = "id_status";
            this.id_status2_asientos.MinimumWidth = 6;
            this.id_status2_asientos.Name = "id_status2_asientos";
            this.id_status2_asientos.ReadOnly = true;
            this.id_status2_asientos.Visible = false;
            this.id_status2_asientos.Width = 89;
            // 
            // id_terminalXruta2_asientos
            // 
            this.id_terminalXruta2_asientos.DataPropertyName = "id_terminalXruta";
            this.id_terminalXruta2_asientos.HeaderText = "id_terminalXruta";
            this.id_terminalXruta2_asientos.MinimumWidth = 6;
            this.id_terminalXruta2_asientos.Name = "id_terminalXruta2_asientos";
            this.id_terminalXruta2_asientos.ReadOnly = true;
            this.id_terminalXruta2_asientos.Visible = false;
            this.id_terminalXruta2_asientos.Width = 131;
            // 
            // id_ruta2_asientos
            // 
            this.id_ruta2_asientos.DataPropertyName = "id_ruta";
            this.id_ruta2_asientos.HeaderText = "id_ruta";
            this.id_ruta2_asientos.MinimumWidth = 6;
            this.id_ruta2_asientos.Name = "id_ruta2_asientos";
            this.id_ruta2_asientos.ReadOnly = true;
            this.id_ruta2_asientos.Visible = false;
            this.id_ruta2_asientos.Width = 76;
            // 
            // id_terminalSalida2_asientos
            // 
            this.id_terminalSalida2_asientos.DataPropertyName = "id_terminalSalida";
            this.id_terminalSalida2_asientos.HeaderText = "id_terminalSalida";
            this.id_terminalSalida2_asientos.MinimumWidth = 6;
            this.id_terminalSalida2_asientos.Name = "id_terminalSalida2_asientos";
            this.id_terminalSalida2_asientos.ReadOnly = true;
            this.id_terminalSalida2_asientos.Visible = false;
            this.id_terminalSalida2_asientos.Width = 140;
            // 
            // id_terminalDestino2_asientos
            // 
            this.id_terminalDestino2_asientos.DataPropertyName = "id_terminalDestino";
            this.id_terminalDestino2_asientos.HeaderText = "id_terminalDestino";
            this.id_terminalDestino2_asientos.MinimumWidth = 6;
            this.id_terminalDestino2_asientos.Name = "id_terminalDestino2_asientos";
            this.id_terminalDestino2_asientos.ReadOnly = true;
            this.id_terminalDestino2_asientos.Visible = false;
            this.id_terminalDestino2_asientos.Width = 147;
            // 
            // dgvdatosboletosviajeviejo
            // 
            this.dgvdatosboletosviajeviejo.AllowUserToAddRows = false;
            this.dgvdatosboletosviajeviejo.AllowUserToDeleteRows = false;
            this.dgvdatosboletosviajeviejo.AllowUserToResizeColumns = false;
            this.dgvdatosboletosviajeviejo.AllowUserToResizeRows = false;
            this.dgvdatosboletosviajeviejo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosboletosviajeviejo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvdatosboletosviajeviejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosboletosviajeviejo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num1_asientos,
            this.origen1_asientos,
            this.destino1_asientos,
            this.nombre1_asientos,
            this.id_status1_asientos,
            this.id_terminalXruta1_asientos,
            this.id_ruta1_asientos,
            this.id_terminalSalida1_asientos,
            this.id_terminalDestino1_asientos});
            this.dgvdatosboletosviajeviejo.Location = new System.Drawing.Point(34, 852);
            this.dgvdatosboletosviajeviejo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdatosboletosviajeviejo.MultiSelect = false;
            this.dgvdatosboletosviajeviejo.Name = "dgvdatosboletosviajeviejo";
            this.dgvdatosboletosviajeviejo.ReadOnly = true;
            this.dgvdatosboletosviajeviejo.RowHeadersWidth = 51;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboletosviajeviejo.RowsDefaultCellStyle = dataGridViewCellStyle51;
            this.dgvdatosboletosviajeviejo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboletosviajeviejo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboletosviajeviejo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboletosviajeviejo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboletosviajeviejo.Size = new System.Drawing.Size(418, 176);
            this.dgvdatosboletosviajeviejo.TabIndex = 32;
            // 
            // num1_asientos
            // 
            this.num1_asientos.DataPropertyName = "asiento";
            this.num1_asientos.HeaderText = "#";
            this.num1_asientos.MinimumWidth = 6;
            this.num1_asientos.Name = "num1_asientos";
            this.num1_asientos.ReadOnly = true;
            this.num1_asientos.Width = 43;
            // 
            // origen1_asientos
            // 
            this.origen1_asientos.DataPropertyName = "origen";
            this.origen1_asientos.HeaderText = "Origen";
            this.origen1_asientos.MinimumWidth = 6;
            this.origen1_asientos.Name = "origen1_asientos";
            this.origen1_asientos.ReadOnly = true;
            this.origen1_asientos.Width = 76;
            // 
            // destino1_asientos
            // 
            this.destino1_asientos.DataPropertyName = "destino";
            this.destino1_asientos.HeaderText = "Destino";
            this.destino1_asientos.MinimumWidth = 6;
            this.destino1_asientos.Name = "destino1_asientos";
            this.destino1_asientos.ReadOnly = true;
            this.destino1_asientos.Width = 82;
            // 
            // nombre1_asientos
            // 
            this.nombre1_asientos.DataPropertyName = "cliente_nombre";
            this.nombre1_asientos.HeaderText = "Nombre";
            this.nombre1_asientos.MinimumWidth = 6;
            this.nombre1_asientos.Name = "nombre1_asientos";
            this.nombre1_asientos.ReadOnly = true;
            this.nombre1_asientos.Width = 85;
            // 
            // id_status1_asientos
            // 
            this.id_status1_asientos.DataPropertyName = "id_status";
            this.id_status1_asientos.HeaderText = "id_status";
            this.id_status1_asientos.MinimumWidth = 6;
            this.id_status1_asientos.Name = "id_status1_asientos";
            this.id_status1_asientos.ReadOnly = true;
            this.id_status1_asientos.Visible = false;
            this.id_status1_asientos.Width = 89;
            // 
            // id_terminalXruta1_asientos
            // 
            this.id_terminalXruta1_asientos.DataPropertyName = "id_terminalXruta";
            this.id_terminalXruta1_asientos.HeaderText = "id_terminalXruta";
            this.id_terminalXruta1_asientos.MinimumWidth = 6;
            this.id_terminalXruta1_asientos.Name = "id_terminalXruta1_asientos";
            this.id_terminalXruta1_asientos.ReadOnly = true;
            this.id_terminalXruta1_asientos.Visible = false;
            this.id_terminalXruta1_asientos.Width = 131;
            // 
            // id_ruta1_asientos
            // 
            this.id_ruta1_asientos.DataPropertyName = "id_ruta";
            this.id_ruta1_asientos.HeaderText = "id_ruta";
            this.id_ruta1_asientos.MinimumWidth = 6;
            this.id_ruta1_asientos.Name = "id_ruta1_asientos";
            this.id_ruta1_asientos.ReadOnly = true;
            this.id_ruta1_asientos.Visible = false;
            this.id_ruta1_asientos.Width = 76;
            // 
            // id_terminalSalida1_asientos
            // 
            this.id_terminalSalida1_asientos.DataPropertyName = "id_terminalSalida";
            this.id_terminalSalida1_asientos.HeaderText = "id_terminalSalida";
            this.id_terminalSalida1_asientos.MinimumWidth = 6;
            this.id_terminalSalida1_asientos.Name = "id_terminalSalida1_asientos";
            this.id_terminalSalida1_asientos.ReadOnly = true;
            this.id_terminalSalida1_asientos.Visible = false;
            this.id_terminalSalida1_asientos.Width = 140;
            // 
            // id_terminalDestino1_asientos
            // 
            this.id_terminalDestino1_asientos.DataPropertyName = "id_terminalDestino";
            this.id_terminalDestino1_asientos.HeaderText = "id_terminalDestino";
            this.id_terminalDestino1_asientos.MinimumWidth = 6;
            this.id_terminalDestino1_asientos.Name = "id_terminalDestino1_asientos";
            this.id_terminalDestino1_asientos.ReadOnly = true;
            this.id_terminalDestino1_asientos.Visible = false;
            this.id_terminalDestino1_asientos.Width = 147;
            // 
            // dgvdatosviajenuevo
            // 
            this.dgvdatosviajenuevo.AllowUserToAddRows = false;
            this.dgvdatosviajenuevo.AllowUserToDeleteRows = false;
            this.dgvdatosviajenuevo.AllowUserToResizeColumns = false;
            this.dgvdatosviajenuevo.AllowUserToResizeRows = false;
            this.dgvdatosviajenuevo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosviajenuevo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvdatosviajenuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosviajenuevo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutas_origen2,
            this.rutas_destino2,
            this.num_rutas_boletos_ocup2});
            this.dgvdatosviajenuevo.Location = new System.Drawing.Point(504, 633);
            this.dgvdatosviajenuevo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdatosviajenuevo.MultiSelect = false;
            this.dgvdatosviajenuevo.Name = "dgvdatosviajenuevo";
            this.dgvdatosviajenuevo.ReadOnly = true;
            this.dgvdatosviajenuevo.RowHeadersWidth = 51;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosviajenuevo.RowsDefaultCellStyle = dataGridViewCellStyle52;
            this.dgvdatosviajenuevo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosviajenuevo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosviajenuevo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosviajenuevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosviajenuevo.Size = new System.Drawing.Size(421, 176);
            this.dgvdatosviajenuevo.TabIndex = 31;
            // 
            // rutas_origen2
            // 
            this.rutas_origen2.DataPropertyName = "terminalOrigen";
            this.rutas_origen2.HeaderText = "Origen";
            this.rutas_origen2.MinimumWidth = 6;
            this.rutas_origen2.Name = "rutas_origen2";
            this.rutas_origen2.ReadOnly = true;
            this.rutas_origen2.Width = 76;
            // 
            // rutas_destino2
            // 
            this.rutas_destino2.DataPropertyName = "terminalDestino";
            this.rutas_destino2.HeaderText = "Destino";
            this.rutas_destino2.MinimumWidth = 6;
            this.rutas_destino2.Name = "rutas_destino2";
            this.rutas_destino2.ReadOnly = true;
            this.rutas_destino2.Width = 82;
            // 
            // num_rutas_boletos_ocup2
            // 
            this.num_rutas_boletos_ocup2.DataPropertyName = "asientosOcupados";
            this.num_rutas_boletos_ocup2.HeaderText = "# Ocup";
            this.num_rutas_boletos_ocup2.MinimumWidth = 6;
            this.num_rutas_boletos_ocup2.Name = "num_rutas_boletos_ocup2";
            this.num_rutas_boletos_ocup2.ReadOnly = true;
            this.num_rutas_boletos_ocup2.Width = 78;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(811, 58);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(95, 76);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(674, 58);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(95, 76);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Cambiar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnComprobar
            // 
            this.btnComprobar.Image = ((System.Drawing.Image)(resources.GetObject("btnComprobar.Image")));
            this.btnComprobar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComprobar.Location = new System.Drawing.Point(538, 58);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnComprobar.Size = new System.Drawing.Size(95, 76);
            this.btnComprobar.TabIndex = 27;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // CmbViajeViejo
            // 
            this.CmbViajeViejo.AutoResize = false;
            this.CmbViajeViejo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbViajeViejo.Depth = 0;
            this.CmbViajeViejo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbViajeViejo.DropDownHeight = 174;
            this.CmbViajeViejo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbViajeViejo.DropDownWidth = 121;
            this.CmbViajeViejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbViajeViejo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbViajeViejo.FormattingEnabled = true;
            this.CmbViajeViejo.Hint = "Viaje antiguo";
            this.CmbViajeViejo.IntegralHeight = false;
            this.CmbViajeViejo.ItemHeight = 43;
            this.CmbViajeViejo.Location = new System.Drawing.Point(34, 166);
            this.CmbViajeViejo.MaxDropDownItems = 4;
            this.CmbViajeViejo.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbViajeViejo.Name = "CmbViajeViejo";
            this.CmbViajeViejo.Size = new System.Drawing.Size(418, 49);
            this.CmbViajeViejo.StartIndex = 0;
            this.CmbViajeViejo.TabIndex = 26;
            this.CmbViajeViejo.SelectedValueChanged += new System.EventHandler(this.CmbViajeViejo_SelectedValueChanged);
            // 
            // CmbViajeNuevo
            // 
            this.CmbViajeNuevo.AutoResize = false;
            this.CmbViajeNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbViajeNuevo.Depth = 0;
            this.CmbViajeNuevo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbViajeNuevo.DropDownHeight = 174;
            this.CmbViajeNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbViajeNuevo.DropDownWidth = 121;
            this.CmbViajeNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbViajeNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbViajeNuevo.FormattingEnabled = true;
            this.CmbViajeNuevo.Hint = "Viaje nuevo";
            this.CmbViajeNuevo.IntegralHeight = false;
            this.CmbViajeNuevo.ItemHeight = 43;
            this.CmbViajeNuevo.Location = new System.Drawing.Point(507, 167);
            this.CmbViajeNuevo.MaxDropDownItems = 4;
            this.CmbViajeNuevo.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbViajeNuevo.Name = "CmbViajeNuevo";
            this.CmbViajeNuevo.Size = new System.Drawing.Size(418, 49);
            this.CmbViajeNuevo.StartIndex = 0;
            this.CmbViajeNuevo.TabIndex = 25;
            this.CmbViajeNuevo.SelectedValueChanged += new System.EventHandler(this.CmbViajeNuevo_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(52, 824);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Asientos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(53, 606);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rutas";
            // 
            // Txt_AsientosOcupadosNuevo
            // 
            this.Txt_AsientosOcupadosNuevo.AnimateReadOnly = false;
            this.Txt_AsientosOcupadosNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_AsientosOcupadosNuevo.Depth = 0;
            this.Txt_AsientosOcupadosNuevo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_AsientosOcupadosNuevo.Hint = "Asientos ocupados";
            this.Txt_AsientosOcupadosNuevo.LeadingIcon = null;
            this.Txt_AsientosOcupadosNuevo.Location = new System.Drawing.Point(507, 530);
            this.Txt_AsientosOcupadosNuevo.MaxLength = 50;
            this.Txt_AsientosOcupadosNuevo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_AsientosOcupadosNuevo.Multiline = false;
            this.Txt_AsientosOcupadosNuevo.Name = "Txt_AsientosOcupadosNuevo";
            this.Txt_AsientosOcupadosNuevo.Size = new System.Drawing.Size(418, 50);
            this.Txt_AsientosOcupadosNuevo.TabIndex = 15;
            this.Txt_AsientosOcupadosNuevo.Text = "";
            this.Txt_AsientosOcupadosNuevo.TrailingIcon = null;
            // 
            // Txt_AsientosNuevo
            // 
            this.Txt_AsientosNuevo.AnimateReadOnly = false;
            this.Txt_AsientosNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_AsientosNuevo.Depth = 0;
            this.Txt_AsientosNuevo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_AsientosNuevo.Hint = "Asientos";
            this.Txt_AsientosNuevo.LeadingIcon = null;
            this.Txt_AsientosNuevo.Location = new System.Drawing.Point(507, 452);
            this.Txt_AsientosNuevo.MaxLength = 50;
            this.Txt_AsientosNuevo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_AsientosNuevo.Multiline = false;
            this.Txt_AsientosNuevo.Name = "Txt_AsientosNuevo";
            this.Txt_AsientosNuevo.Size = new System.Drawing.Size(418, 50);
            this.Txt_AsientosNuevo.TabIndex = 14;
            this.Txt_AsientosNuevo.Text = "";
            this.Txt_AsientosNuevo.TrailingIcon = null;
            // 
            // Txt_HoraNuevo
            // 
            this.Txt_HoraNuevo.AnimateReadOnly = false;
            this.Txt_HoraNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_HoraNuevo.Depth = 0;
            this.Txt_HoraNuevo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_HoraNuevo.Hint = "Hora";
            this.Txt_HoraNuevo.LeadingIcon = null;
            this.Txt_HoraNuevo.Location = new System.Drawing.Point(507, 376);
            this.Txt_HoraNuevo.MaxLength = 50;
            this.Txt_HoraNuevo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_HoraNuevo.Multiline = false;
            this.Txt_HoraNuevo.Name = "Txt_HoraNuevo";
            this.Txt_HoraNuevo.Size = new System.Drawing.Size(418, 50);
            this.Txt_HoraNuevo.TabIndex = 13;
            this.Txt_HoraNuevo.Text = "";
            this.Txt_HoraNuevo.TrailingIcon = null;
            // 
            // Txt_FechaNuevo
            // 
            this.Txt_FechaNuevo.AnimateReadOnly = false;
            this.Txt_FechaNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_FechaNuevo.Depth = 0;
            this.Txt_FechaNuevo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_FechaNuevo.Hint = "Fecha";
            this.Txt_FechaNuevo.LeadingIcon = null;
            this.Txt_FechaNuevo.Location = new System.Drawing.Point(507, 305);
            this.Txt_FechaNuevo.MaxLength = 50;
            this.Txt_FechaNuevo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_FechaNuevo.Multiline = false;
            this.Txt_FechaNuevo.Name = "Txt_FechaNuevo";
            this.Txt_FechaNuevo.Size = new System.Drawing.Size(418, 50);
            this.Txt_FechaNuevo.TabIndex = 12;
            this.Txt_FechaNuevo.Text = "";
            this.Txt_FechaNuevo.TrailingIcon = null;
            // 
            // Txt_LineaNuevo
            // 
            this.Txt_LineaNuevo.AnimateReadOnly = false;
            this.Txt_LineaNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_LineaNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_LineaNuevo.Depth = 0;
            this.Txt_LineaNuevo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_LineaNuevo.Hint = "Línea";
            this.Txt_LineaNuevo.LeadingIcon = null;
            this.Txt_LineaNuevo.Location = new System.Drawing.Point(507, 236);
            this.Txt_LineaNuevo.MaxLength = 50;
            this.Txt_LineaNuevo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_LineaNuevo.Multiline = false;
            this.Txt_LineaNuevo.Name = "Txt_LineaNuevo";
            this.Txt_LineaNuevo.Size = new System.Drawing.Size(418, 50);
            this.Txt_LineaNuevo.TabIndex = 11;
            this.Txt_LineaNuevo.Text = "";
            this.Txt_LineaNuevo.TrailingIcon = null;
            // 
            // Txt_AsientosOcupadosViejo
            // 
            this.Txt_AsientosOcupadosViejo.AnimateReadOnly = false;
            this.Txt_AsientosOcupadosViejo.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_AsientosOcupadosViejo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_AsientosOcupadosViejo.Depth = 0;
            this.Txt_AsientosOcupadosViejo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_AsientosOcupadosViejo.Hint = "Asientos ocupados";
            this.Txt_AsientosOcupadosViejo.LeadingIcon = null;
            this.Txt_AsientosOcupadosViejo.Location = new System.Drawing.Point(34, 530);
            this.Txt_AsientosOcupadosViejo.MaxLength = 50;
            this.Txt_AsientosOcupadosViejo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_AsientosOcupadosViejo.Multiline = false;
            this.Txt_AsientosOcupadosViejo.Name = "Txt_AsientosOcupadosViejo";
            this.Txt_AsientosOcupadosViejo.Size = new System.Drawing.Size(418, 50);
            this.Txt_AsientosOcupadosViejo.TabIndex = 9;
            this.Txt_AsientosOcupadosViejo.Text = "";
            this.Txt_AsientosOcupadosViejo.TrailingIcon = null;
            // 
            // Txt_AsientosViejo
            // 
            this.Txt_AsientosViejo.AnimateReadOnly = false;
            this.Txt_AsientosViejo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_AsientosViejo.Depth = 0;
            this.Txt_AsientosViejo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_AsientosViejo.Hint = "Asientos";
            this.Txt_AsientosViejo.LeadingIcon = null;
            this.Txt_AsientosViejo.Location = new System.Drawing.Point(34, 452);
            this.Txt_AsientosViejo.MaxLength = 50;
            this.Txt_AsientosViejo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_AsientosViejo.Multiline = false;
            this.Txt_AsientosViejo.Name = "Txt_AsientosViejo";
            this.Txt_AsientosViejo.Size = new System.Drawing.Size(418, 50);
            this.Txt_AsientosViejo.TabIndex = 8;
            this.Txt_AsientosViejo.Text = "";
            this.Txt_AsientosViejo.TrailingIcon = null;
            // 
            // Txt_HoraViejo
            // 
            this.Txt_HoraViejo.AnimateReadOnly = false;
            this.Txt_HoraViejo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_HoraViejo.Depth = 0;
            this.Txt_HoraViejo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_HoraViejo.Hint = "Hora";
            this.Txt_HoraViejo.LeadingIcon = null;
            this.Txt_HoraViejo.Location = new System.Drawing.Point(34, 376);
            this.Txt_HoraViejo.MaxLength = 50;
            this.Txt_HoraViejo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_HoraViejo.Multiline = false;
            this.Txt_HoraViejo.Name = "Txt_HoraViejo";
            this.Txt_HoraViejo.Size = new System.Drawing.Size(418, 50);
            this.Txt_HoraViejo.TabIndex = 7;
            this.Txt_HoraViejo.Text = "";
            this.Txt_HoraViejo.TrailingIcon = null;
            // 
            // Txt_FechaViejo
            // 
            this.Txt_FechaViejo.AnimateReadOnly = false;
            this.Txt_FechaViejo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_FechaViejo.Depth = 0;
            this.Txt_FechaViejo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_FechaViejo.Hint = "Fecha";
            this.Txt_FechaViejo.LeadingIcon = null;
            this.Txt_FechaViejo.Location = new System.Drawing.Point(34, 305);
            this.Txt_FechaViejo.MaxLength = 50;
            this.Txt_FechaViejo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_FechaViejo.Multiline = false;
            this.Txt_FechaViejo.Name = "Txt_FechaViejo";
            this.Txt_FechaViejo.Size = new System.Drawing.Size(418, 50);
            this.Txt_FechaViejo.TabIndex = 6;
            this.Txt_FechaViejo.Text = "";
            this.Txt_FechaViejo.TrailingIcon = null;
            // 
            // Txt_LineaViejo
            // 
            this.Txt_LineaViejo.AnimateReadOnly = false;
            this.Txt_LineaViejo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_LineaViejo.Depth = 0;
            this.Txt_LineaViejo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_LineaViejo.Hint = "Línea";
            this.Txt_LineaViejo.LeadingIcon = null;
            this.Txt_LineaViejo.Location = new System.Drawing.Point(34, 236);
            this.Txt_LineaViejo.MaxLength = 50;
            this.Txt_LineaViejo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_LineaViejo.Multiline = false;
            this.Txt_LineaViejo.Name = "Txt_LineaViejo";
            this.Txt_LineaViejo.Size = new System.Drawing.Size(418, 50);
            this.Txt_LineaViejo.TabIndex = 5;
            this.Txt_LineaViejo.Text = "";
            this.Txt_LineaViejo.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cambio Boletos Camion";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.DtmFechaSalida);
            this.materialCard1.Controls.Add(this.label10);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(34, 58);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(418, 76);
            this.materialCard1.TabIndex = 3;
            // 
            // DtmFechaSalida
            // 
            this.DtmFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtmFechaSalida.Location = new System.Drawing.Point(219, 15);
            this.DtmFechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.DtmFechaSalida.Name = "DtmFechaSalida";
            this.DtmFechaSalida.Size = new System.Drawing.Size(181, 32);
            this.DtmFechaSalida.TabIndex = 2;
            this.DtmFechaSalida.ValueChanged += new System.EventHandler(this.DtmFechaSalida_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(18, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fecha de salida";
            // 
            // dgvdatosviajeviejo
            // 
            this.dgvdatosviajeviejo.AllowUserToAddRows = false;
            this.dgvdatosviajeviejo.AllowUserToDeleteRows = false;
            this.dgvdatosviajeviejo.AllowUserToResizeColumns = false;
            this.dgvdatosviajeviejo.AllowUserToResizeRows = false;
            this.dgvdatosviajeviejo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosviajeviejo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvdatosviajeviejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosviajeviejo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvdatosviajeviejo.Location = new System.Drawing.Point(34, 634);
            this.dgvdatosviajeviejo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdatosviajeviejo.MultiSelect = false;
            this.dgvdatosviajeviejo.Name = "dgvdatosviajeviejo";
            this.dgvdatosviajeviejo.ReadOnly = true;
            this.dgvdatosviajeviejo.RowHeadersWidth = 51;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosviajeviejo.RowsDefaultCellStyle = dataGridViewCellStyle49;
            this.dgvdatosviajeviejo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosviajeviejo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosviajeviejo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosviajeviejo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosviajeviejo.Size = new System.Drawing.Size(421, 176);
            this.dgvdatosviajeviejo.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "terminalOrigen";
            this.dataGridViewTextBoxColumn1.HeaderText = "Origen";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "terminalDestino";
            this.dataGridViewTextBoxColumn2.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "asientosOcupados";
            this.dataGridViewTextBoxColumn3.HeaderText = "# Ocup";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // frmCambioBoletoViajeV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 1102);
            this.Controls.Add(this.panel1);
            this.Name = "frmCambioBoletoViajeV2";
            this.Text = "frmCambioBoletoViajeV2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboletosviajenuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboletosviajeviejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajenuevo)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajeviejo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DateTimePicker DtmFechaSalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox Txt_AsientosOcupadosNuevo;
        private MaterialSkin.Controls.MaterialTextBox Txt_AsientosNuevo;
        private MaterialSkin.Controls.MaterialTextBox Txt_HoraNuevo;
        private MaterialSkin.Controls.MaterialTextBox Txt_FechaNuevo;
        private MaterialSkin.Controls.MaterialTextBox Txt_LineaNuevo;
        private MaterialSkin.Controls.MaterialTextBox Txt_AsientosOcupadosViejo;
        private MaterialSkin.Controls.MaterialTextBox Txt_AsientosViejo;
        private MaterialSkin.Controls.MaterialTextBox Txt_HoraViejo;
        private MaterialSkin.Controls.MaterialTextBox Txt_FechaViejo;
        private MaterialSkin.Controls.MaterialTextBox Txt_LineaViejo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialComboBox CmbViajeViejo;
        private MaterialSkin.Controls.MaterialComboBox CmbViajeNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.DataGridView dgvdatosviajenuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutas_origen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutas_destino2;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_rutas_boletos_ocup2;
        private System.Windows.Forms.DataGridView dgvdatosboletosviajeviejo;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalXruta1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ruta1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalSalida1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalDestino1_asientos;
        private System.Windows.Forms.DataGridView dgvdatosboletosviajenuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalXruta2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ruta2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalSalida2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalDestino2_asientos;
        private System.Windows.Forms.DataGridView dgvdatosviajeviejo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}