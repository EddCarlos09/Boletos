namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCambioBoletosViaje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioBoletosViaje));
            this.panel_login = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.Txt_LineaNuevo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Txt_LineaViejo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label10 = new System.Windows.Forms.Label();
            this.DtmFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dgvdatosviajenuevo = new System.Windows.Forms.DataGridView();
            this.rutas_origen2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutas_destino2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_rutas_boletos_ocup2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdatosviajeviejo = new System.Windows.Forms.DataGridView();
            this.rutas_origen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutas_destino1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_rutas_boletos_ocup1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_cmp_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_AsientosOcupadosNuevo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_HoraNuevo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_FechaNuevo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_AsientosNuevo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_AsientosOcupadosViejo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_AsientosViejo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_HoraViejo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_FechaViejo = new System.Windows.Forms.TextBox();
            this.CmbViajeNuevo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbViajeViejo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnComprobar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnGuardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btnSalir = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboletosviajenuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboletosviajeviejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajenuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajeviejo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_login.BorderColor = System.Drawing.Color.Transparent;
            this.panel_login.Controls.Add(this.label17);
            this.panel_login.Controls.Add(this.Txt_LineaNuevo);
            this.panel_login.Controls.Add(this.label16);
            this.panel_login.Controls.Add(this.Txt_LineaViejo);
            this.panel_login.Controls.Add(this.label15);
            this.panel_login.Controls.Add(this.label11);
            this.panel_login.Controls.Add(this.dgvdatosboletosviajenuevo);
            this.panel_login.Controls.Add(this.dgvdatosboletosviajeviejo);
            this.panel_login.Controls.Add(this.label10);
            this.panel_login.Controls.Add(this.DtmFechaSalida);
            this.panel_login.Controls.Add(this.dgvdatosviajenuevo);
            this.panel_login.Controls.Add(this.dgvdatosviajeviejo);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Controls.Add(this.Txt_AsientosOcupadosNuevo);
            this.panel_login.Controls.Add(this.label8);
            this.panel_login.Controls.Add(this.Txt_HoraNuevo);
            this.panel_login.Controls.Add(this.label9);
            this.panel_login.Controls.Add(this.Txt_FechaNuevo);
            this.panel_login.Controls.Add(this.label7);
            this.panel_login.Controls.Add(this.Txt_AsientosNuevo);
            this.panel_login.Controls.Add(this.label6);
            this.panel_login.Controls.Add(this.Txt_AsientosOcupadosViejo);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.Txt_AsientosViejo);
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.Txt_HoraViejo);
            this.panel_login.Controls.Add(this.label12);
            this.panel_login.Controls.Add(this.Txt_FechaViejo);
            this.panel_login.Controls.Add(this.CmbViajeNuevo);
            this.panel_login.Controls.Add(this.label13);
            this.panel_login.Controls.Add(this.CmbViajeViejo);
            this.panel_login.Controls.Add(this.label14);
            this.panel_login.Controls.Add(this.label5);
            this.panel_login.Controls.Add(this.btnComprobar);
            this.panel_login.Controls.Add(this.btnGuardar);
            this.panel_login.Controls.Add(this.btnSalir);
            this.panel_login.Controls.Add(this.label4);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.DrawGradient = false;
            this.panel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_login.Location = new System.Drawing.Point(0, 0);
            this.panel_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(1291, 897);
            this.panel_login.SizeLine = 3;
            this.panel_login.SizeTitle = 20;
            this.panel_login.TabIndex = 12;
            this.panel_login.Title = "";
            this.panel_login.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(700, 122);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 26);
            this.label17.TabIndex = 171;
            this.label17.Text = "Línea";
            // 
            // Txt_LineaNuevo
            // 
            this.Txt_LineaNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_LineaNuevo.Location = new System.Drawing.Point(789, 118);
            this.Txt_LineaNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_LineaNuevo.MaxLength = 30;
            this.Txt_LineaNuevo.Name = "Txt_LineaNuevo";
            this.Txt_LineaNuevo.ReadOnly = true;
            this.Txt_LineaNuevo.Size = new System.Drawing.Size(340, 32);
            this.Txt_LineaNuevo.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(112, 127);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 26);
            this.label16.TabIndex = 0;
            this.label16.Text = "Línea";
            // 
            // Txt_LineaViejo
            // 
            this.Txt_LineaViejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_LineaViejo.Location = new System.Drawing.Point(201, 123);
            this.Txt_LineaViejo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_LineaViejo.MaxLength = 30;
            this.Txt_LineaViejo.Name = "Txt_LineaViejo";
            this.Txt_LineaViejo.ReadOnly = true;
            this.Txt_LineaViejo.Size = new System.Drawing.Size(340, 32);
            this.Txt_LineaViejo.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(527, 610);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "Asientos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(543, 346);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Rutas";
            // 
            // dgvdatosboletosviajenuevo
            // 
            this.dgvdatosboletosviajenuevo.AllowUserToAddRows = false;
            this.dgvdatosboletosviajenuevo.AllowUserToDeleteRows = false;
            this.dgvdatosboletosviajenuevo.AllowUserToResizeColumns = false;
            this.dgvdatosboletosviajenuevo.AllowUserToResizeRows = false;
            this.dgvdatosboletosviajenuevo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dgvdatosboletosviajenuevo.Location = new System.Drawing.Point(593, 650);
            this.dgvdatosboletosviajenuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdatosboletosviajenuevo.MultiSelect = false;
            this.dgvdatosboletosviajenuevo.Name = "dgvdatosboletosviajenuevo";
            this.dgvdatosboletosviajenuevo.ReadOnly = true;
            this.dgvdatosboletosviajenuevo.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboletosviajenuevo.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatosboletosviajenuevo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboletosviajenuevo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboletosviajenuevo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboletosviajenuevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboletosviajenuevo.Size = new System.Drawing.Size(553, 213);
            this.dgvdatosboletosviajenuevo.TabIndex = 20;
            // 
            // num2_asientos
            // 
            this.num2_asientos.DataPropertyName = "asiento";
            this.num2_asientos.HeaderText = "#";
            this.num2_asientos.MinimumWidth = 6;
            this.num2_asientos.Name = "num2_asientos";
            this.num2_asientos.ReadOnly = true;
            this.num2_asientos.Width = 52;
            // 
            // origen2_asientos
            // 
            this.origen2_asientos.DataPropertyName = "origen";
            this.origen2_asientos.HeaderText = "Origen";
            this.origen2_asientos.MinimumWidth = 6;
            this.origen2_asientos.Name = "origen2_asientos";
            this.origen2_asientos.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "destino";
            this.Destino.HeaderText = "Destino";
            this.Destino.MinimumWidth = 6;
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            this.Destino.Width = 107;
            // 
            // nombre2_asientos
            // 
            this.nombre2_asientos.DataPropertyName = "cliente_nombre";
            this.nombre2_asientos.HeaderText = "Nombre";
            this.nombre2_asientos.MinimumWidth = 6;
            this.nombre2_asientos.Name = "nombre2_asientos";
            this.nombre2_asientos.ReadOnly = true;
            this.nombre2_asientos.Width = 110;
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
            this.dgvdatosboletosviajeviejo.Location = new System.Drawing.Point(16, 650);
            this.dgvdatosboletosviajeviejo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdatosboletosviajeviejo.MultiSelect = false;
            this.dgvdatosboletosviajeviejo.Name = "dgvdatosboletosviajeviejo";
            this.dgvdatosboletosviajeviejo.ReadOnly = true;
            this.dgvdatosboletosviajeviejo.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosboletosviajeviejo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatosboletosviajeviejo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosboletosviajeviejo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosboletosviajeviejo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosboletosviajeviejo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosboletosviajeviejo.Size = new System.Drawing.Size(551, 213);
            this.dgvdatosboletosviajeviejo.TabIndex = 19;
            // 
            // num1_asientos
            // 
            this.num1_asientos.DataPropertyName = "asiento";
            this.num1_asientos.HeaderText = "#";
            this.num1_asientos.MinimumWidth = 6;
            this.num1_asientos.Name = "num1_asientos";
            this.num1_asientos.ReadOnly = true;
            this.num1_asientos.Width = 52;
            // 
            // origen1_asientos
            // 
            this.origen1_asientos.DataPropertyName = "origen";
            this.origen1_asientos.HeaderText = "Origen";
            this.origen1_asientos.MinimumWidth = 6;
            this.origen1_asientos.Name = "origen1_asientos";
            this.origen1_asientos.ReadOnly = true;
            // 
            // destino1_asientos
            // 
            this.destino1_asientos.DataPropertyName = "destino";
            this.destino1_asientos.HeaderText = "Destino";
            this.destino1_asientos.MinimumWidth = 6;
            this.destino1_asientos.Name = "destino1_asientos";
            this.destino1_asientos.ReadOnly = true;
            this.destino1_asientos.Width = 107;
            // 
            // nombre1_asientos
            // 
            this.nombre1_asientos.DataPropertyName = "cliente_nombre";
            this.nombre1_asientos.HeaderText = "Nombre";
            this.nombre1_asientos.MinimumWidth = 6;
            this.nombre1_asientos.Name = "nombre1_asientos";
            this.nombre1_asientos.ReadOnly = true;
            this.nombre1_asientos.Width = 110;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fecha Salida";
            // 
            // DtmFechaSalida
            // 
            this.DtmFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtmFechaSalida.Location = new System.Drawing.Point(584, 39);
            this.DtmFechaSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtmFechaSalida.Name = "DtmFechaSalida";
            this.DtmFechaSalida.Size = new System.Drawing.Size(355, 32);
            this.DtmFechaSalida.TabIndex = 1;
            this.DtmFechaSalida.ValueChanged += new System.EventHandler(this.DtmFechaSalida_ValueChanged);
            // 
            // dgvdatosviajenuevo
            // 
            this.dgvdatosviajenuevo.AllowUserToAddRows = false;
            this.dgvdatosviajenuevo.AllowUserToDeleteRows = false;
            this.dgvdatosviajenuevo.AllowUserToResizeColumns = false;
            this.dgvdatosviajenuevo.AllowUserToResizeRows = false;
            this.dgvdatosviajenuevo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosviajenuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosviajenuevo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutas_origen2,
            this.rutas_destino2,
            this.num_rutas_boletos_ocup2});
            this.dgvdatosviajenuevo.Location = new System.Drawing.Point(593, 386);
            this.dgvdatosviajenuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdatosviajenuevo.MultiSelect = false;
            this.dgvdatosviajenuevo.Name = "dgvdatosviajenuevo";
            this.dgvdatosviajenuevo.ReadOnly = true;
            this.dgvdatosviajenuevo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosviajenuevo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdatosviajenuevo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosviajenuevo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosviajenuevo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosviajenuevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosviajenuevo.Size = new System.Drawing.Size(553, 213);
            this.dgvdatosviajenuevo.TabIndex = 16;
            // 
            // rutas_origen2
            // 
            this.rutas_origen2.DataPropertyName = "terminalOrigen";
            this.rutas_origen2.HeaderText = "Origen";
            this.rutas_origen2.MinimumWidth = 6;
            this.rutas_origen2.Name = "rutas_origen2";
            this.rutas_origen2.ReadOnly = true;
            // 
            // rutas_destino2
            // 
            this.rutas_destino2.DataPropertyName = "terminalDestino";
            this.rutas_destino2.HeaderText = "Destino";
            this.rutas_destino2.MinimumWidth = 6;
            this.rutas_destino2.Name = "rutas_destino2";
            this.rutas_destino2.ReadOnly = true;
            this.rutas_destino2.Width = 107;
            // 
            // num_rutas_boletos_ocup2
            // 
            this.num_rutas_boletos_ocup2.DataPropertyName = "asientosOcupados";
            this.num_rutas_boletos_ocup2.HeaderText = "# Ocup";
            this.num_rutas_boletos_ocup2.MinimumWidth = 6;
            this.num_rutas_boletos_ocup2.Name = "num_rutas_boletos_ocup2";
            this.num_rutas_boletos_ocup2.ReadOnly = true;
            this.num_rutas_boletos_ocup2.Width = 105;
            // 
            // dgvdatosviajeviejo
            // 
            this.dgvdatosviajeviejo.AllowUserToAddRows = false;
            this.dgvdatosviajeviejo.AllowUserToDeleteRows = false;
            this.dgvdatosviajeviejo.AllowUserToResizeColumns = false;
            this.dgvdatosviajeviejo.AllowUserToResizeRows = false;
            this.dgvdatosviajeviejo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvdatosviajeviejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatosviajeviejo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutas_origen1,
            this.rutas_destino1,
            this.num_rutas_boletos_ocup1,
            this.status_cmp_1});
            this.dgvdatosviajeviejo.Location = new System.Drawing.Point(16, 386);
            this.dgvdatosviajeviejo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdatosviajeviejo.MultiSelect = false;
            this.dgvdatosviajeviejo.Name = "dgvdatosviajeviejo";
            this.dgvdatosviajeviejo.ReadOnly = true;
            this.dgvdatosviajeviejo.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvdatosviajeviejo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdatosviajeviejo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvdatosviajeviejo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatosviajeviejo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdatosviajeviejo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdatosviajeviejo.Size = new System.Drawing.Size(551, 213);
            this.dgvdatosviajeviejo.TabIndex = 14;
            // 
            // rutas_origen1
            // 
            this.rutas_origen1.DataPropertyName = "terminalOrigen";
            this.rutas_origen1.HeaderText = "Origen";
            this.rutas_origen1.MinimumWidth = 6;
            this.rutas_origen1.Name = "rutas_origen1";
            this.rutas_origen1.ReadOnly = true;
            // 
            // rutas_destino1
            // 
            this.rutas_destino1.DataPropertyName = "terminalDestino";
            this.rutas_destino1.HeaderText = "Destino";
            this.rutas_destino1.MinimumWidth = 6;
            this.rutas_destino1.Name = "rutas_destino1";
            this.rutas_destino1.ReadOnly = true;
            this.rutas_destino1.Width = 107;
            // 
            // num_rutas_boletos_ocup1
            // 
            this.num_rutas_boletos_ocup1.DataPropertyName = "asientosOcupados";
            this.num_rutas_boletos_ocup1.HeaderText = "# Ocup";
            this.num_rutas_boletos_ocup1.MinimumWidth = 6;
            this.num_rutas_boletos_ocup1.Name = "num_rutas_boletos_ocup1";
            this.num_rutas_boletos_ocup1.ReadOnly = true;
            this.num_rutas_boletos_ocup1.Width = 105;
            // 
            // status_cmp_1
            // 
            this.status_cmp_1.DataPropertyName = "status_cmp_1";
            this.status_cmp_1.HeaderText = "status_cmp_1";
            this.status_cmp_1.MinimumWidth = 6;
            this.status_cmp_1.Name = "status_cmp_1";
            this.status_cmp_1.ReadOnly = true;
            this.status_cmp_1.Visible = false;
            this.status_cmp_1.Width = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 159;
            this.label1.Text = "Asientos Ocup";
            // 
            // Txt_AsientosOcupadosNuevo
            // 
            this.Txt_AsientosOcupadosNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AsientosOcupadosNuevo.Location = new System.Drawing.Point(789, 288);
            this.Txt_AsientosOcupadosNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_AsientosOcupadosNuevo.MaxLength = 30;
            this.Txt_AsientosOcupadosNuevo.Name = "Txt_AsientosOcupadosNuevo";
            this.Txt_AsientosOcupadosNuevo.ReadOnly = true;
            this.Txt_AsientosOcupadosNuevo.Size = new System.Drawing.Size(340, 32);
            this.Txt_AsientosOcupadosNuevo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(715, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 26);
            this.label8.TabIndex = 157;
            this.label8.Text = "Hora";
            // 
            // Txt_HoraNuevo
            // 
            this.Txt_HoraNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_HoraNuevo.Location = new System.Drawing.Point(789, 202);
            this.Txt_HoraNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_HoraNuevo.MaxLength = 30;
            this.Txt_HoraNuevo.Name = "Txt_HoraNuevo";
            this.Txt_HoraNuevo.ReadOnly = true;
            this.Txt_HoraNuevo.Size = new System.Drawing.Size(340, 32);
            this.Txt_HoraNuevo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(700, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 26);
            this.label9.TabIndex = 155;
            this.label9.Text = "Fecha";
            // 
            // Txt_FechaNuevo
            // 
            this.Txt_FechaNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaNuevo.Location = new System.Drawing.Point(789, 159);
            this.Txt_FechaNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_FechaNuevo.MaxLength = 30;
            this.Txt_FechaNuevo.Name = "Txt_FechaNuevo";
            this.Txt_FechaNuevo.ReadOnly = true;
            this.Txt_FechaNuevo.Size = new System.Drawing.Size(340, 32);
            this.Txt_FechaNuevo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(675, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 26);
            this.label7.TabIndex = 153;
            this.label7.Text = "Asientos";
            // 
            // Txt_AsientosNuevo
            // 
            this.Txt_AsientosNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AsientosNuevo.Location = new System.Drawing.Point(789, 245);
            this.Txt_AsientosNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_AsientosNuevo.MaxLength = 30;
            this.Txt_AsientosNuevo.Name = "Txt_AsientosNuevo";
            this.Txt_AsientosNuevo.ReadOnly = true;
            this.Txt_AsientosNuevo.Size = new System.Drawing.Size(340, 32);
            this.Txt_AsientosNuevo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Asientos Ocup";
            // 
            // Txt_AsientosOcupadosViejo
            // 
            this.Txt_AsientosOcupadosViejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AsientosOcupadosViejo.Location = new System.Drawing.Point(201, 286);
            this.Txt_AsientosOcupadosViejo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_AsientosOcupadosViejo.MaxLength = 30;
            this.Txt_AsientosOcupadosViejo.Name = "Txt_AsientosOcupadosViejo";
            this.Txt_AsientosOcupadosViejo.ReadOnly = true;
            this.Txt_AsientosOcupadosViejo.Size = new System.Drawing.Size(340, 32);
            this.Txt_AsientosOcupadosViejo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Asientos";
            // 
            // Txt_AsientosViejo
            // 
            this.Txt_AsientosViejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AsientosViejo.Location = new System.Drawing.Point(201, 246);
            this.Txt_AsientosViejo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_AsientosViejo.MaxLength = 30;
            this.Txt_AsientosViejo.Name = "Txt_AsientosViejo";
            this.Txt_AsientosViejo.ReadOnly = true;
            this.Txt_AsientosViejo.Size = new System.Drawing.Size(340, 32);
            this.Txt_AsientosViejo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hora";
            // 
            // Txt_HoraViejo
            // 
            this.Txt_HoraViejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_HoraViejo.Location = new System.Drawing.Point(201, 206);
            this.Txt_HoraViejo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_HoraViejo.MaxLength = 30;
            this.Txt_HoraViejo.Name = "Txt_HoraViejo";
            this.Txt_HoraViejo.ReadOnly = true;
            this.Txt_HoraViejo.Size = new System.Drawing.Size(340, 32);
            this.Txt_HoraViejo.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(112, 167);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Fecha";
            // 
            // Txt_FechaViejo
            // 
            this.Txt_FechaViejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FechaViejo.Location = new System.Drawing.Point(201, 164);
            this.Txt_FechaViejo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_FechaViejo.MaxLength = 30;
            this.Txt_FechaViejo.Name = "Txt_FechaViejo";
            this.Txt_FechaViejo.ReadOnly = true;
            this.Txt_FechaViejo.Size = new System.Drawing.Size(340, 32);
            this.Txt_FechaViejo.TabIndex = 4;
            // 
            // CmbViajeNuevo
            // 
            this.CmbViajeNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbViajeNuevo.FormattingEnabled = true;
            this.CmbViajeNuevo.ItemHeight = 26;
            this.CmbViajeNuevo.Location = new System.Drawing.Point(789, 80);
            this.CmbViajeNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbViajeNuevo.Name = "CmbViajeNuevo";
            this.CmbViajeNuevo.Size = new System.Drawing.Size(340, 34);
            this.CmbViajeNuevo.TabIndex = 8;
            this.CmbViajeNuevo.SelectedValueChanged += new System.EventHandler(this.CmbViajeNuevo_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(633, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 26);
            this.label13.TabIndex = 143;
            this.label13.Text = "Viaje Nuevo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbViajeViejo
            // 
            this.CmbViajeViejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbViajeViejo.FormattingEnabled = true;
            this.CmbViajeViejo.ItemHeight = 26;
            this.CmbViajeViejo.Location = new System.Drawing.Point(201, 84);
            this.CmbViajeViejo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbViajeViejo.Name = "CmbViajeViejo";
            this.CmbViajeViejo.Size = new System.Drawing.Size(340, 34);
            this.CmbViajeViejo.TabIndex = 2;
            this.CmbViajeViejo.SelectedValueChanged += new System.EventHandler(this.CmbViajeViejo_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(65, 84);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 26);
            this.label14.TabIndex = 0;
            this.label14.Text = "Viaje Viejo";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(1163, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Acciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(512, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cambio Boletos Camion";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnComprobar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnComprobar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnComprobar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnComprobar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnComprobar.FocusRectangle = true;
            this.btnComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobar.Image = null;
            this.btnComprobar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComprobar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnComprobar.ImageFocused = null;
            this.btnComprobar.ImageInactive = null;
            this.btnComprobar.ImageMouseOver = null;
            this.btnComprobar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._11salir;
            this.btnComprobar.ImagePressed = null;
            this.btnComprobar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnComprobar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnComprobar.KeyButtonView = false;
            this.btnComprobar.Location = new System.Drawing.Point(1168, 363);
            this.btnComprobar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprobar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnComprobar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.OffsetPressedContent = true;
            this.btnComprobar.Size = new System.Drawing.Size(107, 80);
            this.btnComprobar.TabIndex = 16;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComprobar.TextDropShadow = true;
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btnGuardar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.FocusRectangle = true;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnGuardar.ImageFocused = null;
            this.btnGuardar.ImageInactive = null;
            this.btnGuardar.ImageMouseOver = null;
            this.btnGuardar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._31modificar;
            this.btnGuardar.ImagePressed = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGuardar.KeyButton = System.Windows.Forms.Keys.None;
            this.btnGuardar.KeyButtonView = false;
            this.btnGuardar.Location = new System.Drawing.Point(1168, 443);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnGuardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OffsetPressedContent = true;
            this.btnGuardar.Size = new System.Drawing.Size(107, 80);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Cambiar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextDropShadow = true;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(1168, 523);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSalir.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OffsetPressedContent = true;
            this.btnSalir.Size = new System.Drawing.Size(107, 80);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextDropShadow = true;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCambioBoletosViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 897);
            this.Controls.Add(this.panel_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambioBoletosViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambios Viaje";
            this.TopMost = true;
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboletosviajenuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosboletosviajeviejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajenuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatosviajeviejo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.PanelTitle_Creativa panel_login;
        private System.Windows.Forms.Label label4;
        private LibControls.WinForms.Button_Creativa btnComprobar;
        private LibControls.WinForms.Button_Creativa btnGuardar;
        private LibControls.WinForms.Button_Creativa btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_AsientosOcupadosNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_HoraNuevo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_FechaNuevo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_AsientosNuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_AsientosOcupadosViejo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_AsientosViejo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_HoraViejo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_FechaViejo;
        private System.Windows.Forms.ComboBox CmbViajeNuevo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CmbViajeViejo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvdatosviajenuevo;
        private System.Windows.Forms.DataGridView dgvdatosviajeviejo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DtmFechaSalida;
        private System.Windows.Forms.DataGridView dgvdatosboletosviajenuevo;
        private System.Windows.Forms.DataGridView dgvdatosboletosviajeviejo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn num2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalXruta2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ruta2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalSalida2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalDestino2_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn num1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_status1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalXruta1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ruta1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalSalida1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_terminalDestino1_asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutas_origen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutas_destino2;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_rutas_boletos_ocup2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutas_origen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutas_destino1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_rutas_boletos_ocup1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_cmp_1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Txt_LineaNuevo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Txt_LineaViejo;
    }
}