namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatSalidasV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatSalidasV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRutas = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtDisenioCamion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTipoCamion = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumCamion = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCamion = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRutasInt = new MaterialSkin.Controls.MaterialListView();
            this.txtPiso = new System.Windows.Forms.Label();
            this.panelFechas = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.panelDias = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.rdbtnEspecial = new System.Windows.Forms.RadioButton();
            this.rdbtnLineas = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreViaje = new MaterialSkin.Controls.MaterialTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelFechas.SuspendLayout();
            this.panelDias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRutas);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txt_mensaje);
            this.panel1.Controls.Add(this.dtpHora);
            this.panel1.Controls.Add(this.txtDisenioCamion);
            this.panel1.Controls.Add(this.txtTipoCamion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNumCamion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbCamion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvRutasInt);
            this.panel1.Controls.Add(this.txtPiso);
            this.panel1.Controls.Add(this.panelFechas);
            this.panel1.Controls.Add(this.panelDias);
            this.panel1.Controls.Add(this.rdbtnEspecial);
            this.panel1.Controls.Add(this.rdbtnLineas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombreViaje);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 690);
            this.panel1.TabIndex = 0;
            // 
            // cmbRutas
            // 
            this.cmbRutas.AutoResize = false;
            this.cmbRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRutas.Depth = 0;
            this.cmbRutas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRutas.DropDownHeight = 174;
            this.cmbRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRutas.DropDownWidth = 121;
            this.cmbRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRutas.FormattingEnabled = true;
            this.cmbRutas.IntegralHeight = false;
            this.cmbRutas.ItemHeight = 43;
            this.cmbRutas.Location = new System.Drawing.Point(433, 95);
            this.cmbRutas.MaxDropDownItems = 4;
            this.cmbRutas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRutas.Name = "cmbRutas";
            this.cmbRutas.Size = new System.Drawing.Size(470, 49);
            this.cmbRutas.StartIndex = 0;
            this.cmbRutas.TabIndex = 59;
            this.cmbRutas.SelectedIndexChanged += new System.EventHandler(this.cmbRutas_SelectedIndexChanged);
            this.cmbRutas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRutas_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(497, 641);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCancelar.Size = new System.Drawing.Size(154, 52);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(305, 641);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGuardar.Size = new System.Drawing.Size(154, 52);
            this.btnGuardar.TabIndex = 57;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(203, 587);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(496, 32);
            this.txt_mensaje.TabIndex = 56;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mensaje.Visible = false;
            // 
            // dtpHora
            // 
            this.dtpHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpHora.CustomFormat = "HH:mm:ss";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(830, 533);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(187, 22);
            this.dtpHora.TabIndex = 19;
            // 
            // txtDisenioCamion
            // 
            this.txtDisenioCamion.AnimateReadOnly = false;
            this.txtDisenioCamion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisenioCamion.Depth = 0;
            this.txtDisenioCamion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDisenioCamion.LeadingIcon = null;
            this.txtDisenioCamion.Location = new System.Drawing.Point(627, 523);
            this.txtDisenioCamion.MaxLength = 50;
            this.txtDisenioCamion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDisenioCamion.Multiline = false;
            this.txtDisenioCamion.Name = "txtDisenioCamion";
            this.txtDisenioCamion.Size = new System.Drawing.Size(155, 50);
            this.txtDisenioCamion.TabIndex = 53;
            this.txtDisenioCamion.Text = "";
            this.txtDisenioCamion.TrailingIcon = null;
            // 
            // txtTipoCamion
            // 
            this.txtTipoCamion.AnimateReadOnly = false;
            this.txtTipoCamion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoCamion.Depth = 0;
            this.txtTipoCamion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipoCamion.LeadingIcon = null;
            this.txtTipoCamion.Location = new System.Drawing.Point(433, 524);
            this.txtTipoCamion.MaxLength = 50;
            this.txtTipoCamion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTipoCamion.Multiline = false;
            this.txtTipoCamion.Name = "txtTipoCamion";
            this.txtTipoCamion.Size = new System.Drawing.Size(154, 50);
            this.txtTipoCamion.TabIndex = 52;
            this.txtTipoCamion.Text = "";
            this.txtTipoCamion.TrailingIcon = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(826, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Horario de salida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(623, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Diseño Camión";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tipo Camión";
            // 
            // txtNumCamion
            // 
            this.txtNumCamion.AnimateReadOnly = false;
            this.txtNumCamion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumCamion.Depth = 0;
            this.txtNumCamion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumCamion.LeadingIcon = null;
            this.txtNumCamion.Location = new System.Drawing.Point(840, 434);
            this.txtNumCamion.MaxLength = 50;
            this.txtNumCamion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumCamion.Multiline = false;
            this.txtNumCamion.Name = "txtNumCamion";
            this.txtNumCamion.Size = new System.Drawing.Size(146, 50);
            this.txtNumCamion.TabIndex = 48;
            this.txtNumCamion.Text = "";
            this.txtNumCamion.TrailingIcon = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(836, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Núm. Camión";
            // 
            // cmbCamion
            // 
            this.cmbCamion.AutoResize = false;
            this.cmbCamion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCamion.Depth = 0;
            this.cmbCamion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCamion.DropDownHeight = 174;
            this.cmbCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamion.DropDownWidth = 121;
            this.cmbCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCamion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCamion.FormattingEnabled = true;
            this.cmbCamion.IntegralHeight = false;
            this.cmbCamion.ItemHeight = 43;
            this.cmbCamion.Location = new System.Drawing.Point(433, 435);
            this.cmbCamion.MaxDropDownItems = 4;
            this.cmbCamion.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCamion.Name = "cmbCamion";
            this.cmbCamion.Size = new System.Drawing.Size(349, 49);
            this.cmbCamion.StartIndex = 0;
            this.cmbCamion.TabIndex = 46;
            this.cmbCamion.SelectedIndexChanged += new System.EventHandler(this.cmbCamion_SelectedIndexChanged);
            this.cmbCamion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCamion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Camión";
            // 
            // dgvRutasInt
            // 
            this.dgvRutasInt.AutoSizeTable = false;
            this.dgvRutasInt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRutasInt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRutasInt.Depth = 0;
            this.dgvRutasInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRutasInt.FullRowSelect = true;
            this.dgvRutasInt.HideSelection = false;
            this.dgvRutasInt.Location = new System.Drawing.Point(433, 221);
            this.dgvRutasInt.MinimumSize = new System.Drawing.Size(200, 100);
            this.dgvRutasInt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dgvRutasInt.MouseState = MaterialSkin.MouseState.OUT;
            this.dgvRutasInt.Name = "dgvRutasInt";
            this.dgvRutasInt.OwnerDraw = true;
            this.dgvRutasInt.Size = new System.Drawing.Size(553, 165);
            this.dgvRutasInt.TabIndex = 44;
            this.dgvRutasInt.UseCompatibleStateImageBehavior = false;
            this.dgvRutasInt.View = System.Windows.Forms.View.Details;
            // 
            // txtPiso
            // 
            this.txtPiso.AutoSize = true;
            this.txtPiso.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiso.ForeColor = System.Drawing.Color.Navy;
            this.txtPiso.Location = new System.Drawing.Point(428, 180);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(158, 19);
            this.txtPiso.TabIndex = 43;
            this.txtPiso.Text = "Terminales Destino";
            // 
            // panelFechas
            // 
            this.panelFechas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelFechas.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelFechas.Controls.Add(this.label1);
            this.panelFechas.Controls.Add(this.label3);
            this.panelFechas.Controls.Add(this.dtpFecInicio);
            this.panelFechas.Controls.Add(this.dtpFecFin);
            this.panelFechas.DrawGradient = false;
            this.panelFechas.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelFechas.Location = new System.Drawing.Point(33, 429);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(358, 145);
            this.panelFechas.SizeLine = 3;
            this.panelFechas.SizeTitle = 20;
            this.panelFechas.TabIndex = 41;
            this.panelFechas.Title = "Fechas";
            this.panelFechas.TitleColor = System.Drawing.Color.GhostWhite;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Fecha Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Fecha Inicio";
            // 
            // dtpFecInicio
            // 
            this.dtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecInicio.Location = new System.Drawing.Point(145, 44);
            this.dtpFecInicio.Name = "dtpFecInicio";
            this.dtpFecInicio.Size = new System.Drawing.Size(117, 22);
            this.dtpFecInicio.TabIndex = 11;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(145, 92);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(117, 22);
            this.dtpFecFin.TabIndex = 12;
            // 
            // panelDias
            // 
            this.panelDias.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDias.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelDias.Controls.Add(this.chkDomingo);
            this.panelDias.Controls.Add(this.chkSabado);
            this.panelDias.Controls.Add(this.chkViernes);
            this.panelDias.Controls.Add(this.chkJueves);
            this.panelDias.Controls.Add(this.chkMiercoles);
            this.panelDias.Controls.Add(this.chkMartes);
            this.panelDias.Controls.Add(this.chkLunes);
            this.panelDias.DrawGradient = false;
            this.panelDias.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelDias.Location = new System.Drawing.Point(33, 221);
            this.panelDias.Name = "panelDias";
            this.panelDias.Size = new System.Drawing.Size(358, 127);
            this.panelDias.SizeLine = 3;
            this.panelDias.SizeTitle = 20;
            this.panelDias.TabIndex = 42;
            this.panelDias.Title = "Días";
            this.panelDias.TitleColor = System.Drawing.Color.GhostWhite;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkDomingo.Location = new System.Drawing.Point(272, 44);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(21, 37);
            this.chkDomingo.TabIndex = 10;
            this.chkDomingo.Text = "D";
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSabado.Location = new System.Drawing.Point(229, 43);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(20, 37);
            this.chkSabado.TabIndex = 9;
            this.chkSabado.Text = "S";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkViernes.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkViernes.Location = new System.Drawing.Point(186, 44);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(20, 37);
            this.chkViernes.TabIndex = 8;
            this.chkViernes.Text = "V";
            this.chkViernes.UseVisualStyleBackColor = false;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkJueves.Location = new System.Drawing.Point(145, 44);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(18, 37);
            this.chkJueves.TabIndex = 7;
            this.chkJueves.Text = "J";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMiercoles.Location = new System.Drawing.Point(100, 44);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(22, 37);
            this.chkMiercoles.TabIndex = 6;
            this.chkMiercoles.Text = "M";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMartes.Location = new System.Drawing.Point(54, 44);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(22, 37);
            this.chkMartes.TabIndex = 5;
            this.chkMartes.Text = "M";
            this.chkMartes.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkLunes.Location = new System.Drawing.Point(11, 44);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(18, 37);
            this.chkLunes.TabIndex = 4;
            this.chkLunes.Text = "L";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // rdbtnEspecial
            // 
            this.rdbtnEspecial.AutoSize = true;
            this.rdbtnEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnEspecial.Location = new System.Drawing.Point(221, 177);
            this.rdbtnEspecial.Name = "rdbtnEspecial";
            this.rdbtnEspecial.Size = new System.Drawing.Size(150, 24);
            this.rdbtnEspecial.TabIndex = 7;
            this.rdbtnEspecial.Text = "Viaje Especial";
            this.rdbtnEspecial.UseVisualStyleBackColor = true;
            this.rdbtnEspecial.CheckedChanged += new System.EventHandler(this.rdbtnEspecial_CheckedChanged);
            // 
            // rdbtnLineas
            // 
            this.rdbtnLineas.AutoSize = true;
            this.rdbtnLineas.Checked = true;
            this.rdbtnLineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnLineas.Location = new System.Drawing.Point(33, 177);
            this.rdbtnLineas.Name = "rdbtnLineas";
            this.rdbtnLineas.Size = new System.Drawing.Size(140, 24);
            this.rdbtnLineas.TabIndex = 6;
            this.rdbtnLineas.TabStop = true;
            this.rdbtnLineas.Text = "Viaje Líneas ";
            this.rdbtnLineas.UseVisualStyleBackColor = true;
            this.rdbtnLineas.CheckedChanged += new System.EventHandler(this.rdbtnLineas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ruta";
            // 
            // txtNombreViaje
            // 
            this.txtNombreViaje.AnimateReadOnly = false;
            this.txtNombreViaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreViaje.Depth = 0;
            this.txtNombreViaje.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreViaje.LeadingIcon = null;
            this.txtNombreViaje.Location = new System.Drawing.Point(33, 94);
            this.txtNombreViaje.MaxLength = 50;
            this.txtNombreViaje.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreViaje.Multiline = false;
            this.txtNombreViaje.Name = "txtNombreViaje";
            this.txtNombreViaje.Size = new System.Drawing.Size(358, 50);
            this.txtNombreViaje.TabIndex = 3;
            this.txtNombreViaje.Text = "";
            this.txtNombreViaje.TrailingIcon = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre Viaje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(28, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Viajes";
            // 
            // frmCatSalidasV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 757);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatSalidasV2";
            this.Text = "frmCatSalidasV2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFechas.ResumeLayout(false);
            this.panelFechas.PerformLayout();
            this.panelDias.ResumeLayout(false);
            this.panelDias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialTextBox txtNombreViaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbtnLineas;
        private System.Windows.Forms.RadioButton rdbtnEspecial;
        private LibControls.WinForms.PanelTitle_Creativa panelDias;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkLunes;
        private LibControls.WinForms.PanelTitle_Creativa panelFechas;
        private System.Windows.Forms.DateTimePicker dtpFecInicio;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Label txtPiso;
        private MaterialSkin.Controls.MaterialListView dgvRutasInt;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox cmbCamion;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtNumCamion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialTextBox txtDisenioCamion;
        private MaterialSkin.Controls.MaterialTextBox txtTipoCamion;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private MaterialSkin.Controls.MaterialComboBox cmbRutas;
    }
}