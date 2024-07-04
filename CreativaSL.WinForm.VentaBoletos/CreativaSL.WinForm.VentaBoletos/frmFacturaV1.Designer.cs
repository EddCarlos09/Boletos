namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmFacturaV1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaV1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TxtCelular = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DtmFechaNac = new System.Windows.Forms.DateTimePicker();
            this.TxtRFC = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.CmbMunicipio = new MaterialSkin.Controls.MaterialComboBox();
            this.TxtCP = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtColonia = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDomicilio = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtEmpresa = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.TxtCelular);
            this.panel1.Controls.Add(this.TxtTelefono);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.DtmFechaNac);
            this.panel1.Controls.Add(this.TxtRFC);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.CmbEstado);
            this.panel1.Controls.Add(this.CmbMunicipio);
            this.panel1.Controls.Add(this.TxtCP);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtColonia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtDomicilio);
            this.panel1.Controls.Add(this.TxtEmpresa);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 800);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(481, 773);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCancelar.Size = new System.Drawing.Size(148, 76);
            this.btnCancelar.TabIndex = 153;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(240, 774);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGuardar.Size = new System.Drawing.Size(154, 74);
            this.btnGuardar.TabIndex = 152;
            this.btnGuardar.Text = "Facturar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // TxtCelular
            // 
            this.TxtCelular.AnimateReadOnly = false;
            this.TxtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCelular.Depth = 0;
            this.TxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCelular.LeadingIcon = null;
            this.TxtCelular.Location = new System.Drawing.Point(321, 502);
            this.TxtCelular.MaxLength = 50;
            this.TxtCelular.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCelular.Multiline = false;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(254, 50);
            this.TxtCelular.TabIndex = 30;
            this.TxtCelular.Text = "";
            this.TxtCelular.TrailingIcon = null;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.AnimateReadOnly = false;
            this.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTelefono.Depth = 0;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtTelefono.LeadingIcon = null;
            this.TxtTelefono.Location = new System.Drawing.Point(43, 502);
            this.TxtTelefono.MaxLength = 50;
            this.TxtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtTelefono.Multiline = false;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(254, 50);
            this.TxtTelefono.TabIndex = 29;
            this.TxtTelefono.Text = "";
            this.TxtTelefono.TrailingIcon = null;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(320, 473);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 22);
            this.label14.TabIndex = 27;
            this.label14.Text = "Celular";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(40, 473);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 22);
            this.label13.TabIndex = 26;
            this.label13.Text = "Télefono";
            // 
            // DtmFechaNac
            // 
            this.DtmFechaNac.CalendarFont = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFechaNac.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtmFechaNac.Location = new System.Drawing.Point(602, 389);
            this.DtmFechaNac.Margin = new System.Windows.Forms.Padding(4);
            this.DtmFechaNac.Name = "DtmFechaNac";
            this.DtmFechaNac.Size = new System.Drawing.Size(250, 32);
            this.DtmFechaNac.TabIndex = 25;
            // 
            // TxtRFC
            // 
            this.TxtRFC.AnimateReadOnly = false;
            this.TxtRFC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRFC.Depth = 0;
            this.TxtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtRFC.LeadingIcon = null;
            this.TxtRFC.Location = new System.Drawing.Point(321, 391);
            this.TxtRFC.MaxLength = 50;
            this.TxtRFC.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtRFC.Multiline = false;
            this.TxtRFC.Name = "TxtRFC";
            this.TxtRFC.Size = new System.Drawing.Size(254, 50);
            this.TxtRFC.TabIndex = 24;
            this.TxtRFC.Text = "";
            this.TxtRFC.TrailingIcon = null;
            // 
            // TxtEmail
            // 
            this.TxtEmail.AnimateReadOnly = false;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Depth = 0;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEmail.LeadingIcon = null;
            this.TxtEmail.Location = new System.Drawing.Point(43, 389);
            this.TxtEmail.MaxLength = 50;
            this.TxtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmail.Multiline = false;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(254, 50);
            this.TxtEmail.TabIndex = 22;
            this.TxtEmail.Text = "";
            this.TxtEmail.TrailingIcon = null;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(597, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "Fecha de nacimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(320, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "RFC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(40, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email";
            // 
            // CmbEstado
            // 
            this.CmbEstado.AutoResize = false;
            this.CmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbEstado.Depth = 0;
            this.CmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbEstado.DropDownHeight = 174;
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.DropDownWidth = 121;
            this.CmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.IntegralHeight = false;
            this.CmbEstado.ItemHeight = 43;
            this.CmbEstado.Location = new System.Drawing.Point(323, 278);
            this.CmbEstado.MaxDropDownItems = 4;
            this.CmbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(252, 49);
            this.CmbEstado.StartIndex = 0;
            this.CmbEstado.TabIndex = 18;
            // 
            // CmbMunicipio
            // 
            this.CmbMunicipio.AutoResize = false;
            this.CmbMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbMunicipio.Depth = 0;
            this.CmbMunicipio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbMunicipio.DropDownHeight = 174;
            this.CmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMunicipio.DropDownWidth = 121;
            this.CmbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbMunicipio.FormattingEnabled = true;
            this.CmbMunicipio.IntegralHeight = false;
            this.CmbMunicipio.ItemHeight = 43;
            this.CmbMunicipio.Location = new System.Drawing.Point(600, 278);
            this.CmbMunicipio.MaxDropDownItems = 4;
            this.CmbMunicipio.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbMunicipio.Name = "CmbMunicipio";
            this.CmbMunicipio.Size = new System.Drawing.Size(252, 49);
            this.CmbMunicipio.StartIndex = 0;
            this.CmbMunicipio.TabIndex = 17;
            // 
            // TxtCP
            // 
            this.TxtCP.AnimateReadOnly = false;
            this.TxtCP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCP.Depth = 0;
            this.TxtCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCP.LeadingIcon = null;
            this.TxtCP.Location = new System.Drawing.Point(43, 279);
            this.TxtCP.MaxLength = 50;
            this.TxtCP.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCP.Multiline = false;
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.Size = new System.Drawing.Size(254, 50);
            this.TxtCP.TabIndex = 16;
            this.TxtCP.Text = "";
            this.TxtCP.TrailingIcon = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(597, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ciudad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(320, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(38, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "C.P.";
            // 
            // TxtColonia
            // 
            this.TxtColonia.AnimateReadOnly = false;
            this.TxtColonia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtColonia.Depth = 0;
            this.TxtColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtColonia.LeadingIcon = null;
            this.TxtColonia.Location = new System.Drawing.Point(615, 502);
            this.TxtColonia.MaxLength = 50;
            this.TxtColonia.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtColonia.Multiline = false;
            this.TxtColonia.Name = "TxtColonia";
            this.TxtColonia.Size = new System.Drawing.Size(250, 50);
            this.TxtColonia.TabIndex = 12;
            this.TxtColonia.Text = "";
            this.TxtColonia.TrailingIcon = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(610, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Colonia";
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.AnimateReadOnly = false;
            this.TxtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDomicilio.Depth = 0;
            this.TxtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDomicilio.LeadingIcon = null;
            this.TxtDomicilio.Location = new System.Drawing.Point(642, 165);
            this.TxtDomicilio.MaxLength = 50;
            this.TxtDomicilio.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDomicilio.Multiline = false;
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(254, 50);
            this.TxtDomicilio.TabIndex = 8;
            this.TxtDomicilio.Text = "";
            this.TxtDomicilio.TrailingIcon = null;
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.AnimateReadOnly = false;
            this.TxtEmpresa.BackColor = System.Drawing.Color.Honeydew;
            this.TxtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmpresa.Depth = 0;
            this.TxtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEmpresa.LeadingIcon = null;
            this.TxtEmpresa.Location = new System.Drawing.Point(335, 165);
            this.TxtEmpresa.MaxLength = 50;
            this.TxtEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmpresa.Multiline = false;
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(250, 50);
            this.TxtEmpresa.TabIndex = 7;
            this.TxtEmpresa.Text = "";
            this.TxtEmpresa.TrailingIcon = null;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AnimateReadOnly = false;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNombre.LeadingIcon = null;
            this.TxtNombre.Location = new System.Drawing.Point(39, 165);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(252, 50);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.Text = "";
            this.TxtNombre.TrailingIcon = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(637, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Domicilio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(330, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(32, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // frmFacturaV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 867);
            this.Controls.Add(this.panel1);
            this.Name = "frmFacturaV1";
            this.Text = "frmFacturaV1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox TxtCelular;
        private MaterialSkin.Controls.MaterialTextBox TxtTelefono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DtmFechaNac;
        private MaterialSkin.Controls.MaterialTextBox TxtRFC;
        private MaterialSkin.Controls.MaterialTextBox TxtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialComboBox CmbEstado;
        private MaterialSkin.Controls.MaterialComboBox CmbMunicipio;
        private MaterialSkin.Controls.MaterialTextBox TxtCP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox TxtColonia;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox TxtDomicilio;
        private MaterialSkin.Controls.MaterialTextBox TxtEmpresa;
        private MaterialSkin.Controls.MaterialTextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}