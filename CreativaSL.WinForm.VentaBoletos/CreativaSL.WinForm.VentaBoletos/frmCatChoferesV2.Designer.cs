namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatChoferesV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatChoferesV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtmFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txt_C_curp = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_C_Observaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txt_C_aMat = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_C_aPat = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_C_nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DtmFechaNac);
            this.panel1.Controls.Add(this.txt_C_curp);
            this.panel1.Controls.Add(this.txt_C_Observaciones);
            this.panel1.Controls.Add(this.txt_C_aMat);
            this.panel1.Controls.Add(this.txt_C_aPat);
            this.panel1.Controls.Add(this.txt_C_nombre);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(3, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 568);
            this.panel1.TabIndex = 0;
            // 
            // DtmFechaNac
            // 
            this.DtmFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtmFechaNac.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtmFechaNac.Location = new System.Drawing.Point(712, 171);
            this.DtmFechaNac.Name = "DtmFechaNac";
            this.DtmFechaNac.Size = new System.Drawing.Size(245, 38);
            this.DtmFechaNac.TabIndex = 144;
            // 
            // txt_C_curp
            // 
            this.txt_C_curp.AnimateReadOnly = false;
            this.txt_C_curp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_C_curp.Depth = 0;
            this.txt_C_curp.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_C_curp.LeadingIcon = null;
            this.txt_C_curp.Location = new System.Drawing.Point(712, 75);
            this.txt_C_curp.MaxLength = 50;
            this.txt_C_curp.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_C_curp.Multiline = false;
            this.txt_C_curp.Name = "txt_C_curp";
            this.txt_C_curp.Size = new System.Drawing.Size(251, 50);
            this.txt_C_curp.TabIndex = 142;
            this.txt_C_curp.Text = "";
            this.txt_C_curp.TrailingIcon = null;
            this.txt_C_curp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_curp_KeyPress);
            // 
            // txt_C_Observaciones
            // 
            this.txt_C_Observaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_C_Observaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_C_Observaciones.Depth = 0;
            this.txt_C_Observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_C_Observaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_C_Observaciones.Location = new System.Drawing.Point(48, 383);
            this.txt_C_Observaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_C_Observaciones.Name = "txt_C_Observaciones";
            this.txt_C_Observaciones.Size = new System.Drawing.Size(406, 150);
            this.txt_C_Observaciones.TabIndex = 141;
            this.txt_C_Observaciones.Text = "";
            this.txt_C_Observaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_Observaciones_KeyPress);
            // 
            // txt_C_aMat
            // 
            this.txt_C_aMat.AnimateReadOnly = false;
            this.txt_C_aMat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_C_aMat.Depth = 0;
            this.txt_C_aMat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_C_aMat.LeadingIcon = null;
            this.txt_C_aMat.Location = new System.Drawing.Point(205, 258);
            this.txt_C_aMat.MaxLength = 50;
            this.txt_C_aMat.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_C_aMat.Multiline = false;
            this.txt_C_aMat.Name = "txt_C_aMat";
            this.txt_C_aMat.Size = new System.Drawing.Size(251, 50);
            this.txt_C_aMat.TabIndex = 140;
            this.txt_C_aMat.Text = "";
            this.txt_C_aMat.TrailingIcon = null;
            this.txt_C_aMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_aMat_KeyPress);
            // 
            // txt_C_aPat
            // 
            this.txt_C_aPat.AnimateReadOnly = false;
            this.txt_C_aPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_C_aPat.Depth = 0;
            this.txt_C_aPat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_C_aPat.LeadingIcon = null;
            this.txt_C_aPat.Location = new System.Drawing.Point(203, 161);
            this.txt_C_aPat.MaxLength = 50;
            this.txt_C_aPat.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_C_aPat.Multiline = false;
            this.txt_C_aPat.Name = "txt_C_aPat";
            this.txt_C_aPat.Size = new System.Drawing.Size(251, 50);
            this.txt_C_aPat.TabIndex = 139;
            this.txt_C_aPat.Text = "";
            this.txt_C_aPat.TrailingIcon = null;
            this.txt_C_aPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_aPat_KeyPress);
            // 
            // txt_C_nombre
            // 
            this.txt_C_nombre.AnimateReadOnly = false;
            this.txt_C_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_C_nombre.Depth = 0;
            this.txt_C_nombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_C_nombre.LeadingIcon = null;
            this.txt_C_nombre.Location = new System.Drawing.Point(205, 75);
            this.txt_C_nombre.MaxLength = 50;
            this.txt_C_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_C_nombre.Multiline = false;
            this.txt_C_nombre.Name = "txt_C_nombre";
            this.txt_C_nombre.Size = new System.Drawing.Size(251, 50);
            this.txt_C_nombre.TabIndex = 138;
            this.txt_C_nombre.Text = "";
            this.txt_C_nombre.TrailingIcon = null;
            this.txt_C_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_nombre_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(739, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCancelar.Size = new System.Drawing.Size(148, 76);
            this.btnCancelar.TabIndex = 137;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(535, 425);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGuardar.Size = new System.Drawing.Size(154, 74);
            this.btnGuardar.TabIndex = 136;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(43, 355);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 135;
            this.label5.Text = "Observaciones";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(530, 171);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 25);
            this.label14.TabIndex = 134;
            this.label14.Text = "Fecha nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(530, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 133;
            this.label4.Text = "Curp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(43, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 132;
            this.label3.Text = "Apellido materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(43, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 131;
            this.label2.Text = "Apellido paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(43, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 130;
            this.label1.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(65, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 26);
            this.label8.TabIndex = 129;
            this.label8.Text = "Choferes";
            // 
            // frmCatChoferesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 651);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatChoferesV2";
            this.Text = "Choferes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private MaterialSkin.Controls.MaterialTextBox txt_C_aMat;
        private MaterialSkin.Controls.MaterialTextBox txt_C_aPat;
        private MaterialSkin.Controls.MaterialTextBox txt_C_nombre;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_C_Observaciones;
        private MaterialSkin.Controls.MaterialTextBox txt_C_curp;
        private System.Windows.Forms.DateTimePicker DtmFechaNac;
    }
}