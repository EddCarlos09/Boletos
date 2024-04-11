namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatRutasV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatRutasV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mensaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Rutasinter = new MaterialSkin.Controls.MaterialListView();
            this.cmbDestino = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbOrigen = new MaterialSkin.Controls.MaterialComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempo2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnAddTerminal = new System.Windows.Forms.Button();
            this.btnUpdTerminal = new System.Windows.Forms.Button();
            this.btnDelTerminal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelTerminal);
            this.panel1.Controls.Add(this.btnUpdTerminal);
            this.panel1.Controls.Add(this.btnAddTerminal);
            this.panel1.Controls.Add(this.txtTiempo2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_mensaje);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgv_Rutasinter);
            this.panel1.Controls.Add(this.cmbDestino);
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 625);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(400, 529);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCancelar.Size = new System.Drawing.Size(148, 76);
            this.btnCancelar.TabIndex = 62;
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
            this.btnGuardar.Location = new System.Drawing.Point(206, 529);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnGuardar.Size = new System.Drawing.Size(154, 74);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(53, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Terminales intermedias";
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensaje.Location = new System.Drawing.Point(149, 491);
            this.txt_mensaje.Multiline = true;
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(496, 32);
            this.txt_mensaje.TabIndex = 13;
            this.txt_mensaje.Text = "Ocurrió un Error";
            this.txt_mensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_mensaje.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(654, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tiempo Viaje";
            // 
            // dgv_Rutasinter
            // 
            this.dgv_Rutasinter.AutoSizeTable = false;
            this.dgv_Rutasinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Rutasinter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Rutasinter.Depth = 0;
            this.dgv_Rutasinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Rutasinter.FullRowSelect = true;
            this.dgv_Rutasinter.HideSelection = false;
            this.dgv_Rutasinter.Location = new System.Drawing.Point(57, 280);
            this.dgv_Rutasinter.MinimumSize = new System.Drawing.Size(200, 100);
            this.dgv_Rutasinter.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dgv_Rutasinter.MouseState = MaterialSkin.MouseState.OUT;
            this.dgv_Rutasinter.Name = "dgv_Rutasinter";
            this.dgv_Rutasinter.OwnerDraw = true;
            this.dgv_Rutasinter.Size = new System.Drawing.Size(736, 193);
            this.dgv_Rutasinter.TabIndex = 7;
            this.dgv_Rutasinter.UseCompatibleStateImageBehavior = false;
            this.dgv_Rutasinter.View = System.Windows.Forms.View.Details;
            // 
            // cmbDestino
            // 
            this.cmbDestino.AutoResize = false;
            this.cmbDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDestino.Depth = 0;
            this.cmbDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDestino.DropDownHeight = 174;
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.DropDownWidth = 121;
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.IntegralHeight = false;
            this.cmbDestino.ItemHeight = 43;
            this.cmbDestino.Location = new System.Drawing.Point(357, 121);
            this.cmbDestino.MaxDropDownItems = 4;
            this.cmbDestino.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(264, 49);
            this.cmbDestino.StartIndex = 0;
            this.cmbDestino.TabIndex = 5;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.AutoResize = false;
            this.cmbOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbOrigen.Depth = 0;
            this.cmbOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbOrigen.DropDownHeight = 174;
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.DropDownWidth = 121;
            this.cmbOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.IntegralHeight = false;
            this.cmbOrigen.ItemHeight = 43;
            this.cmbOrigen.Location = new System.Drawing.Point(57, 121);
            this.cmbOrigen.MaxDropDownItems = 4;
            this.cmbOrigen.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(264, 49);
            this.cmbOrigen.StartIndex = 0;
            this.cmbOrigen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(352, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Terminal Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(52, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Rutas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(52, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Terminal Origen";
            // 
            // txtTiempo2
            // 
            this.txtTiempo2.AllowPromptAsInput = true;
            this.txtTiempo2.AnimateReadOnly = false;
            this.txtTiempo2.AsciiOnly = false;
            this.txtTiempo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTiempo2.BeepOnError = false;
            this.txtTiempo2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTiempo2.Depth = 0;
            this.txtTiempo2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTiempo2.HidePromptOnLeave = false;
            this.txtTiempo2.HideSelection = true;
            this.txtTiempo2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTiempo2.LeadingIcon = null;
            this.txtTiempo2.Location = new System.Drawing.Point(659, 122);
            this.txtTiempo2.Mask = "00:00";
            this.txtTiempo2.MaxLength = 32767;
            this.txtTiempo2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTiempo2.Name = "txtTiempo2";
            this.txtTiempo2.PasswordChar = '\0';
            this.txtTiempo2.PrefixSuffixText = null;
            this.txtTiempo2.PromptChar = '_';
            this.txtTiempo2.ReadOnly = false;
            this.txtTiempo2.RejectInputOnFirstFailure = false;
            this.txtTiempo2.ResetOnPrompt = true;
            this.txtTiempo2.ResetOnSpace = true;
            this.txtTiempo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTiempo2.SelectedText = "";
            this.txtTiempo2.SelectionLength = 0;
            this.txtTiempo2.SelectionStart = 0;
            this.txtTiempo2.ShortcutsEnabled = true;
            this.txtTiempo2.Size = new System.Drawing.Size(134, 48);
            this.txtTiempo2.SkipLiterals = true;
            this.txtTiempo2.TabIndex = 63;
            this.txtTiempo2.TabStop = false;
            this.txtTiempo2.Text = "__:__";
            this.txtTiempo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTiempo2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtTiempo2.TrailingIcon = null;
            this.txtTiempo2.UseSystemPasswordChar = false;
            this.txtTiempo2.ValidatingType = null;
            // 
            // btnAddTerminal
            // 
            this.btnAddTerminal.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTerminal.Image")));
            this.btnAddTerminal.Location = new System.Drawing.Point(552, 225);
            this.btnAddTerminal.Name = "btnAddTerminal";
            this.btnAddTerminal.Size = new System.Drawing.Size(69, 49);
            this.btnAddTerminal.TabIndex = 64;
            this.btnAddTerminal.UseVisualStyleBackColor = true;
            this.btnAddTerminal.Click += new System.EventHandler(this.btnAddTerminal_Click);
            // 
            // btnUpdTerminal
            // 
            this.btnUpdTerminal.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdTerminal.Image")));
            this.btnUpdTerminal.Location = new System.Drawing.Point(636, 225);
            this.btnUpdTerminal.Name = "btnUpdTerminal";
            this.btnUpdTerminal.Size = new System.Drawing.Size(69, 49);
            this.btnUpdTerminal.TabIndex = 65;
            this.btnUpdTerminal.UseVisualStyleBackColor = true;
            this.btnUpdTerminal.Click += new System.EventHandler(this.btnUpdTerminal_Click);
            // 
            // btnDelTerminal
            // 
            this.btnDelTerminal.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTerminal.Image")));
            this.btnDelTerminal.Location = new System.Drawing.Point(724, 224);
            this.btnDelTerminal.Name = "btnDelTerminal";
            this.btnDelTerminal.Size = new System.Drawing.Size(69, 49);
            this.btnDelTerminal.TabIndex = 66;
            this.btnDelTerminal.UseVisualStyleBackColor = true;
            this.btnDelTerminal.Click += new System.EventHandler(this.btnDelTerminal_Click);
            // 
            // frmCatRutasV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 692);
            this.Controls.Add(this.panel1);
            this.Name = "frmCatRutasV2";
            this.Text = "fmrCatRutasV2";
            this.Load += new System.EventHandler(this.frmRutas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox cmbDestino;
        private MaterialSkin.Controls.MaterialComboBox cmbOrigen;
        private MaterialSkin.Controls.MaterialListView dgv_Rutasinter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mensaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTiempo2;
        private System.Windows.Forms.Button btnDelTerminal;
        private System.Windows.Forms.Button btnUpdTerminal;
        private System.Windows.Forms.Button btnAddTerminal;
    }
}