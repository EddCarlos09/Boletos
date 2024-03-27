namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatClientes));
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btn_Guardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.txt_C_codigocliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.combo_C_EstadoCivil = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_C_colonia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_C_municipio = new System.Windows.Forms.ComboBox();
            this.combo_C_estados = new System.Windows.Forms.ComboBox();
            this.combo_C_pais = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DtmFechaNac = new System.Windows.Forms.DateTimePicker();
            this.combo_C_sexo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_C_ocupacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_C_curp = new System.Windows.Forms.TextBox();
            this.txt_C_correo = new System.Windows.Forms.TextBox();
            this.txt_C_aMat = new System.Windows.Forms.TextBox();
            this.txt_C_aPat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_C_nombre = new System.Windows.Forms.TextBox();
            this.panel_Creativa1.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.btn_Guardar);
            this.panel_Creativa1.Controls.Add(this.btn_Cancelar);
            this.panel_Creativa1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(0, 648);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(479, 85);
            this.panel_Creativa1.TabIndex = 5;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Guardar.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Guardar.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Guardar.BorderMouseOverColor = System.Drawing.Color.Gold;
            this.btn_Guardar.BorderNoFocusColor = System.Drawing.Color.SkyBlue;
            this.btn_Guardar.FocusRectangle = true;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Image = null;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btn_Guardar.ImageFocused = null;
            this.btn_Guardar.ImageInactive = null;
            this.btn_Guardar.ImageMouseOver = null;
            this.btn_Guardar.ImageNormal = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources._19guardar;
            this.btn_Guardar.ImagePressed = null;
            this.btn_Guardar.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Guardar.KeyButton = System.Windows.Forms.Keys.None;
            this.btn_Guardar.KeyButtonView = false;
            this.btn_Guardar.Location = new System.Drawing.Point(289, 10);
            this.btn_Guardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Guardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.OffsetPressedContent = true;
            this.btn_Guardar.Size = new System.Drawing.Size(80, 65);
            this.btn_Guardar.TabIndex = 15;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.TextDropShadow = true;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(382, 10);
            this.btn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.OffsetPressedContent = true;
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 65);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.TextDropShadow = true;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // panelTitle_Creativa1
            // 
            this.panelTitle_Creativa1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTitle_Creativa1.BorderColor = System.Drawing.Color.Transparent;
            this.panelTitle_Creativa1.Controls.Add(this.label15);
            this.panelTitle_Creativa1.Controls.Add(this.txt_C_codigocliente);
            this.panelTitle_Creativa1.Controls.Add(this.label13);
            this.panelTitle_Creativa1.Controls.Add(this.combo_C_EstadoCivil);
            this.panelTitle_Creativa1.Controls.Add(this.label12);
            this.panelTitle_Creativa1.Controls.Add(this.txt_C_colonia);
            this.panelTitle_Creativa1.Controls.Add(this.label11);
            this.panelTitle_Creativa1.Controls.Add(this.combo_C_municipio);
            this.panelTitle_Creativa1.Controls.Add(this.combo_C_estados);
            this.panelTitle_Creativa1.Controls.Add(this.combo_C_pais);
            this.panelTitle_Creativa1.Controls.Add(this.label7);
            this.panelTitle_Creativa1.Controls.Add(this.label8);
            this.panelTitle_Creativa1.Controls.Add(this.label9);
            this.panelTitle_Creativa1.Controls.Add(this.label14);
            this.panelTitle_Creativa1.Controls.Add(this.DtmFechaNac);
            this.panelTitle_Creativa1.Controls.Add(this.combo_C_sexo);
            this.panelTitle_Creativa1.Controls.Add(this.label10);
            this.panelTitle_Creativa1.Controls.Add(this.label3);
            this.panelTitle_Creativa1.Controls.Add(this.label2);
            this.panelTitle_Creativa1.Controls.Add(this.label1);
            this.panelTitle_Creativa1.Controls.Add(this.combo_C_ocupacion);
            this.panelTitle_Creativa1.Controls.Add(this.label6);
            this.panelTitle_Creativa1.Controls.Add(this.txt_C_curp);
            this.panelTitle_Creativa1.Controls.Add(this.txt_C_correo);
            this.panelTitle_Creativa1.Controls.Add(this.txt_C_aMat);
            this.panelTitle_Creativa1.Controls.Add(this.txt_C_aPat);
            this.panelTitle_Creativa1.Controls.Add(this.label5);
            this.panelTitle_Creativa1.Controls.Add(this.label4);
            this.panelTitle_Creativa1.Controls.Add(this.txt_C_nombre);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.DrawGradient = false;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(479, 733);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 4;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(188, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Clientes";
            // 
            // txt_C_codigocliente
            // 
            this.txt_C_codigocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C_codigocliente.Location = new System.Drawing.Point(173, 616);
            this.txt_C_codigocliente.MaxLength = 15;
            this.txt_C_codigocliente.Name = "txt_C_codigocliente";
            this.txt_C_codigocliente.Size = new System.Drawing.Size(267, 27);
            this.txt_C_codigocliente.TabIndex = 14;
            this.txt_C_codigocliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_codigocliente_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(45, 619);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Código Cliente";
            // 
            // combo_C_EstadoCivil
            // 
            this.combo_C_EstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_C_EstadoCivil.FormattingEnabled = true;
            this.combo_C_EstadoCivil.ItemHeight = 20;
            this.combo_C_EstadoCivil.Location = new System.Drawing.Point(175, 318);
            this.combo_C_EstadoCivil.Name = "combo_C_EstadoCivil";
            this.combo_C_EstadoCivil.Size = new System.Drawing.Size(267, 28);
            this.combo_C_EstadoCivil.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Estado Civil";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_C_colonia
            // 
            this.txt_C_colonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C_colonia.Location = new System.Drawing.Point(173, 572);
            this.txt_C_colonia.MaxLength = 50;
            this.txt_C_colonia.Name = "txt_C_colonia";
            this.txt_C_colonia.Size = new System.Drawing.Size(267, 27);
            this.txt_C_colonia.TabIndex = 13;
            this.txt_C_colonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_colonia_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(101, 574);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Colonia";
            // 
            // combo_C_municipio
            // 
            this.combo_C_municipio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_C_municipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_C_municipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_C_municipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_C_municipio.FormattingEnabled = true;
            this.combo_C_municipio.Location = new System.Drawing.Point(173, 523);
            this.combo_C_municipio.Name = "combo_C_municipio";
            this.combo_C_municipio.Size = new System.Drawing.Size(267, 28);
            this.combo_C_municipio.TabIndex = 12;
            // 
            // combo_C_estados
            // 
            this.combo_C_estados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_C_estados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_C_estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_C_estados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_C_estados.FormattingEnabled = true;
            this.combo_C_estados.Location = new System.Drawing.Point(173, 468);
            this.combo_C_estados.Name = "combo_C_estados";
            this.combo_C_estados.Size = new System.Drawing.Size(267, 28);
            this.combo_C_estados.TabIndex = 11;
            this.combo_C_estados.SelectionChangeCommitted += new System.EventHandler(this.combo_C_estados_SelectionChangeCommitted);
            // 
            // combo_C_pais
            // 
            this.combo_C_pais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_C_pais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_C_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_C_pais.Enabled = false;
            this.combo_C_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_C_pais.FormattingEnabled = true;
            this.combo_C_pais.Location = new System.Drawing.Point(173, 415);
            this.combo_C_pais.Name = "combo_C_pais";
            this.combo_C_pais.Size = new System.Drawing.Size(269, 28);
            this.combo_C_pais.TabIndex = 10;
            this.combo_C_pais.SelectionChangeCommitted += new System.EventHandler(this.combo_C_pais_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Municipio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Estados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "País";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Fecha nacimiento";
            // 
            // DtmFechaNac
            // 
            this.DtmFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtmFechaNac.Location = new System.Drawing.Point(175, 147);
            this.DtmFechaNac.Name = "DtmFechaNac";
            this.DtmFechaNac.Size = new System.Drawing.Size(267, 27);
            this.DtmFechaNac.TabIndex = 4;
            // 
            // combo_C_sexo
            // 
            this.combo_C_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_C_sexo.FormattingEnabled = true;
            this.combo_C_sexo.ItemHeight = 20;
            this.combo_C_sexo.Location = new System.Drawing.Point(173, 185);
            this.combo_C_sexo.Name = "combo_C_sexo";
            this.combo_C_sexo.Size = new System.Drawing.Size(267, 28);
            this.combo_C_sexo.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(119, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sexo";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // combo_C_ocupacion
            // 
            this.combo_C_ocupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_C_ocupacion.FormattingEnabled = true;
            this.combo_C_ocupacion.ItemHeight = 20;
            this.combo_C_ocupacion.Location = new System.Drawing.Point(175, 273);
            this.combo_C_ocupacion.Name = "combo_C_ocupacion";
            this.combo_C_ocupacion.Size = new System.Drawing.Size(267, 28);
            this.combo_C_ocupacion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ocupación";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_C_curp
            // 
            this.txt_C_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C_curp.Location = new System.Drawing.Point(174, 364);
            this.txt_C_curp.MaxLength = 18;
            this.txt_C_curp.Name = "txt_C_curp";
            this.txt_C_curp.Size = new System.Drawing.Size(267, 27);
            this.txt_C_curp.TabIndex = 9;
            this.txt_C_curp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_curp_KeyPress);
            // 
            // txt_C_correo
            // 
            this.txt_C_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C_correo.Location = new System.Drawing.Point(174, 229);
            this.txt_C_correo.MaxLength = 150;
            this.txt_C_correo.Name = "txt_C_correo";
            this.txt_C_correo.Size = new System.Drawing.Size(267, 27);
            this.txt_C_correo.TabIndex = 6;
            this.txt_C_correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_correo_KeyPress);
            // 
            // txt_C_aMat
            // 
            this.txt_C_aMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C_aMat.Location = new System.Drawing.Point(173, 107);
            this.txt_C_aMat.MaxLength = 30;
            this.txt_C_aMat.Name = "txt_C_aMat";
            this.txt_C_aMat.Size = new System.Drawing.Size(267, 27);
            this.txt_C_aMat.TabIndex = 3;
            this.txt_C_aMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_aMat_KeyPress);
            // 
            // txt_C_aPat
            // 
            this.txt_C_aPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C_aPat.Location = new System.Drawing.Point(174, 69);
            this.txt_C_aPat.MaxLength = 30;
            this.txt_C_aPat.Name = "txt_C_aPat";
            this.txt_C_aPat.Size = new System.Drawing.Size(267, 27);
            this.txt_C_aPat.TabIndex = 2;
            this.txt_C_aPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_aPat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Curp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Correo Electrónico";
            // 
            // txt_C_nombre
            // 
            this.txt_C_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C_nombre.Location = new System.Drawing.Point(173, 32);
            this.txt_C_nombre.MaxLength = 30;
            this.txt_C_nombre.Name = "txt_C_nombre";
            this.txt_C_nombre.Size = new System.Drawing.Size(267, 27);
            this.txt_C_nombre.TabIndex = 1;
            this.txt_C_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_nombre_KeyPress);
            // 
            // frmCatClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 733);
            this.Controls.Add(this.panel_Creativa1);
            this.Controls.Add(this.panelTitle_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCatClientes_Load);
            this.panel_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btn_Guardar;
        private LibControls.WinForms.Button_Creativa btn_Cancelar;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.TextBox txt_C_colonia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_C_municipio;
        private System.Windows.Forms.ComboBox combo_C_estados;
        private System.Windows.Forms.ComboBox combo_C_pais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DtmFechaNac;
        private System.Windows.Forms.ComboBox combo_C_sexo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_C_ocupacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_C_curp;
        private System.Windows.Forms.TextBox txt_C_correo;
        private System.Windows.Forms.TextBox txt_C_aMat;
        private System.Windows.Forms.TextBox txt_C_aPat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_C_nombre;
        private System.Windows.Forms.ComboBox combo_C_EstadoCivil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_C_codigocliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}