namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCancelacionesTransferenciasV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelacionesTransferenciasV2));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_folio = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_destino = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_linea = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_origen = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_fecha = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_hora = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_asiento = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_precio = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_nombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_motivoCancelacionTransferencia = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txt_FechaCancelacionTransferencia = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_usuarioCancelacionTransferencia = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_horaCancelacionTransferencia = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_penalizacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.chkTransferenciaCompleta = new MaterialSkin.Controls.MaterialCheckbox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cmb_motivoCancelacionTransferencia = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(58, 102);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Datos Boletos";
            // 
            // txt_folio
            // 
            this.txt_folio.AnimateReadOnly = false;
            this.txt_folio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_folio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_folio.Depth = 0;
            this.txt_folio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_folio.HideSelection = true;
            this.txt_folio.LeadingIcon = null;
            this.txt_folio.Location = new System.Drawing.Point(30, 152);
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
            this.txt_folio.Size = new System.Drawing.Size(305, 48);
            this.txt_folio.TabIndex = 1;
            this.txt_folio.TabStop = false;
            this.txt_folio.Text = "Folio";
            this.txt_folio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_folio.TrailingIcon = null;
            this.txt_folio.UseSystemPasswordChar = false;
            // 
            // txt_destino
            // 
            this.txt_destino.AnimateReadOnly = false;
            this.txt_destino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_destino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_destino.Depth = 0;
            this.txt_destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_destino.HideSelection = true;
            this.txt_destino.LeadingIcon = null;
            this.txt_destino.Location = new System.Drawing.Point(30, 230);
            this.txt_destino.MaxLength = 32767;
            this.txt_destino.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.PasswordChar = '\0';
            this.txt_destino.PrefixSuffixText = null;
            this.txt_destino.ReadOnly = false;
            this.txt_destino.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_destino.SelectedText = "";
            this.txt_destino.SelectionLength = 0;
            this.txt_destino.SelectionStart = 0;
            this.txt_destino.ShortcutsEnabled = true;
            this.txt_destino.Size = new System.Drawing.Size(305, 48);
            this.txt_destino.TabIndex = 2;
            this.txt_destino.TabStop = false;
            this.txt_destino.Text = "Destino";
            this.txt_destino.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_destino.TrailingIcon = null;
            this.txt_destino.UseSystemPasswordChar = false;
            // 
            // txt_linea
            // 
            this.txt_linea.AnimateReadOnly = false;
            this.txt_linea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_linea.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_linea.Depth = 0;
            this.txt_linea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_linea.HideSelection = true;
            this.txt_linea.LeadingIcon = null;
            this.txt_linea.Location = new System.Drawing.Point(391, 152);
            this.txt_linea.MaxLength = 32767;
            this.txt_linea.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_linea.Name = "txt_linea";
            this.txt_linea.PasswordChar = '\0';
            this.txt_linea.PrefixSuffixText = null;
            this.txt_linea.ReadOnly = false;
            this.txt_linea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_linea.SelectedText = "";
            this.txt_linea.SelectionLength = 0;
            this.txt_linea.SelectionStart = 0;
            this.txt_linea.ShortcutsEnabled = true;
            this.txt_linea.Size = new System.Drawing.Size(305, 48);
            this.txt_linea.TabIndex = 2;
            this.txt_linea.TabStop = false;
            this.txt_linea.Text = "Linea";
            this.txt_linea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_linea.TrailingIcon = null;
            this.txt_linea.UseSystemPasswordChar = false;
            // 
            // txt_origen
            // 
            this.txt_origen.AnimateReadOnly = false;
            this.txt_origen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_origen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_origen.Depth = 0;
            this.txt_origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_origen.HideSelection = true;
            this.txt_origen.LeadingIcon = null;
            this.txt_origen.Location = new System.Drawing.Point(755, 152);
            this.txt_origen.MaxLength = 32767;
            this.txt_origen.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_origen.Name = "txt_origen";
            this.txt_origen.PasswordChar = '\0';
            this.txt_origen.PrefixSuffixText = null;
            this.txt_origen.ReadOnly = false;
            this.txt_origen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_origen.SelectedText = "";
            this.txt_origen.SelectionLength = 0;
            this.txt_origen.SelectionStart = 0;
            this.txt_origen.ShortcutsEnabled = true;
            this.txt_origen.Size = new System.Drawing.Size(305, 48);
            this.txt_origen.TabIndex = 3;
            this.txt_origen.TabStop = false;
            this.txt_origen.Text = "Origen";
            this.txt_origen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_origen.TrailingIcon = null;
            this.txt_origen.UseSystemPasswordChar = false;
            // 
            // txt_fecha
            // 
            this.txt_fecha.AnimateReadOnly = false;
            this.txt_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_fecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_fecha.Depth = 0;
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_fecha.HideSelection = true;
            this.txt_fecha.LeadingIcon = null;
            this.txt_fecha.Location = new System.Drawing.Point(391, 230);
            this.txt_fecha.MaxLength = 32767;
            this.txt_fecha.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.PasswordChar = '\0';
            this.txt_fecha.PrefixSuffixText = null;
            this.txt_fecha.ReadOnly = false;
            this.txt_fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_fecha.SelectedText = "";
            this.txt_fecha.SelectionLength = 0;
            this.txt_fecha.SelectionStart = 0;
            this.txt_fecha.ShortcutsEnabled = true;
            this.txt_fecha.Size = new System.Drawing.Size(305, 48);
            this.txt_fecha.TabIndex = 4;
            this.txt_fecha.TabStop = false;
            this.txt_fecha.Text = "Fecha";
            this.txt_fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_fecha.TrailingIcon = null;
            this.txt_fecha.UseSystemPasswordChar = false;
            // 
            // txt_hora
            // 
            this.txt_hora.AnimateReadOnly = false;
            this.txt_hora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_hora.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_hora.Depth = 0;
            this.txt_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_hora.HideSelection = true;
            this.txt_hora.LeadingIcon = null;
            this.txt_hora.Location = new System.Drawing.Point(755, 230);
            this.txt_hora.MaxLength = 32767;
            this.txt_hora.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.PasswordChar = '\0';
            this.txt_hora.PrefixSuffixText = null;
            this.txt_hora.ReadOnly = false;
            this.txt_hora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_hora.SelectedText = "";
            this.txt_hora.SelectionLength = 0;
            this.txt_hora.SelectionStart = 0;
            this.txt_hora.ShortcutsEnabled = true;
            this.txt_hora.Size = new System.Drawing.Size(305, 48);
            this.txt_hora.TabIndex = 5;
            this.txt_hora.TabStop = false;
            this.txt_hora.Text = "Hora";
            this.txt_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_hora.TrailingIcon = null;
            this.txt_hora.UseSystemPasswordChar = false;
            // 
            // txt_asiento
            // 
            this.txt_asiento.AnimateReadOnly = false;
            this.txt_asiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_asiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_asiento.Depth = 0;
            this.txt_asiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_asiento.HideSelection = true;
            this.txt_asiento.LeadingIcon = null;
            this.txt_asiento.Location = new System.Drawing.Point(755, 307);
            this.txt_asiento.MaxLength = 32767;
            this.txt_asiento.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_asiento.Name = "txt_asiento";
            this.txt_asiento.PasswordChar = '\0';
            this.txt_asiento.PrefixSuffixText = null;
            this.txt_asiento.ReadOnly = false;
            this.txt_asiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_asiento.SelectedText = "";
            this.txt_asiento.SelectionLength = 0;
            this.txt_asiento.SelectionStart = 0;
            this.txt_asiento.ShortcutsEnabled = true;
            this.txt_asiento.Size = new System.Drawing.Size(305, 48);
            this.txt_asiento.TabIndex = 6;
            this.txt_asiento.TabStop = false;
            this.txt_asiento.Text = "Asiento ";
            this.txt_asiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_asiento.TrailingIcon = null;
            this.txt_asiento.UseSystemPasswordChar = false;
            // 
            // txt_precio
            // 
            this.txt_precio.AnimateReadOnly = false;
            this.txt_precio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_precio.Depth = 0;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_precio.HideSelection = true;
            this.txt_precio.LeadingIcon = null;
            this.txt_precio.Location = new System.Drawing.Point(391, 307);
            this.txt_precio.MaxLength = 32767;
            this.txt_precio.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.PasswordChar = '\0';
            this.txt_precio.PrefixSuffixText = null;
            this.txt_precio.ReadOnly = false;
            this.txt_precio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_precio.SelectedText = "";
            this.txt_precio.SelectionLength = 0;
            this.txt_precio.SelectionStart = 0;
            this.txt_precio.ShortcutsEnabled = true;
            this.txt_precio.Size = new System.Drawing.Size(305, 48);
            this.txt_precio.TabIndex = 7;
            this.txt_precio.TabStop = false;
            this.txt_precio.Text = "Precio";
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_precio.TrailingIcon = null;
            this.txt_precio.UseSystemPasswordChar = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.AnimateReadOnly = false;
            this.txt_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.HideSelection = true;
            this.txt_nombre.LeadingIcon = null;
            this.txt_nombre.Location = new System.Drawing.Point(30, 307);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.PrefixSuffixText = null;
            this.txt_nombre.ReadOnly = false;
            this.txt_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(305, 48);
            this.txt_nombre.TabIndex = 8;
            this.txt_nombre.TabStop = false;
            this.txt_nombre.Text = "Nombre";
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nombre.TrailingIcon = null;
            this.txt_nombre.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(58, 382);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(246, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Motivo Cancelación/Transferencia";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(27, 436);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Motivo";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(27, 532);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(50, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Motivo";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(484, 436);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(44, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Fecha";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(484, 532);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(35, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Hora";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(484, 607);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(55, 19);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "Usuario";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(1217, 382);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(92, 19);
            this.materialLabel8.TabIndex = 15;
            this.materialLabel8.Text = "Penalizacion";
            // 
            // txt_motivoCancelacionTransferencia
            // 
            this.txt_motivoCancelacionTransferencia.AnimateReadOnly = false;
            this.txt_motivoCancelacionTransferencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_motivoCancelacionTransferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_motivoCancelacionTransferencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_motivoCancelacionTransferencia.Depth = 0;
            this.txt_motivoCancelacionTransferencia.HideSelection = true;
            this.txt_motivoCancelacionTransferencia.Location = new System.Drawing.Point(106, 532);
            this.txt_motivoCancelacionTransferencia.MaxLength = 32767;
            this.txt_motivoCancelacionTransferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_motivoCancelacionTransferencia.Name = "txt_motivoCancelacionTransferencia";
            this.txt_motivoCancelacionTransferencia.PasswordChar = '\0';
            this.txt_motivoCancelacionTransferencia.ReadOnly = false;
            this.txt_motivoCancelacionTransferencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_motivoCancelacionTransferencia.SelectedText = "";
            this.txt_motivoCancelacionTransferencia.SelectionLength = 0;
            this.txt_motivoCancelacionTransferencia.SelectionStart = 0;
            this.txt_motivoCancelacionTransferencia.ShortcutsEnabled = true;
            this.txt_motivoCancelacionTransferencia.Size = new System.Drawing.Size(305, 130);
            this.txt_motivoCancelacionTransferencia.TabIndex = 16;
            this.txt_motivoCancelacionTransferencia.TabStop = false;
            this.txt_motivoCancelacionTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_motivoCancelacionTransferencia.UseSystemPasswordChar = false;
            // 
            // txt_FechaCancelacionTransferencia
            // 
            this.txt_FechaCancelacionTransferencia.AnimateReadOnly = false;
            this.txt_FechaCancelacionTransferencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_FechaCancelacionTransferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_FechaCancelacionTransferencia.Depth = 0;
            this.txt_FechaCancelacionTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_FechaCancelacionTransferencia.HideSelection = true;
            this.txt_FechaCancelacionTransferencia.LeadingIcon = null;
            this.txt_FechaCancelacionTransferencia.Location = new System.Drawing.Point(553, 421);
            this.txt_FechaCancelacionTransferencia.MaxLength = 32767;
            this.txt_FechaCancelacionTransferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_FechaCancelacionTransferencia.Name = "txt_FechaCancelacionTransferencia";
            this.txt_FechaCancelacionTransferencia.PasswordChar = '\0';
            this.txt_FechaCancelacionTransferencia.PrefixSuffixText = null;
            this.txt_FechaCancelacionTransferencia.ReadOnly = false;
            this.txt_FechaCancelacionTransferencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_FechaCancelacionTransferencia.SelectedText = "";
            this.txt_FechaCancelacionTransferencia.SelectionLength = 0;
            this.txt_FechaCancelacionTransferencia.SelectionStart = 0;
            this.txt_FechaCancelacionTransferencia.ShortcutsEnabled = true;
            this.txt_FechaCancelacionTransferencia.Size = new System.Drawing.Size(250, 48);
            this.txt_FechaCancelacionTransferencia.TabIndex = 18;
            this.txt_FechaCancelacionTransferencia.TabStop = false;
            this.txt_FechaCancelacionTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_FechaCancelacionTransferencia.TrailingIcon = null;
            this.txt_FechaCancelacionTransferencia.UseSystemPasswordChar = false;
            // 
            // txt_usuarioCancelacionTransferencia
            // 
            this.txt_usuarioCancelacionTransferencia.AnimateReadOnly = false;
            this.txt_usuarioCancelacionTransferencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_usuarioCancelacionTransferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_usuarioCancelacionTransferencia.Depth = 0;
            this.txt_usuarioCancelacionTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_usuarioCancelacionTransferencia.HideSelection = true;
            this.txt_usuarioCancelacionTransferencia.LeadingIcon = null;
            this.txt_usuarioCancelacionTransferencia.Location = new System.Drawing.Point(553, 590);
            this.txt_usuarioCancelacionTransferencia.MaxLength = 32767;
            this.txt_usuarioCancelacionTransferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_usuarioCancelacionTransferencia.Name = "txt_usuarioCancelacionTransferencia";
            this.txt_usuarioCancelacionTransferencia.PasswordChar = '\0';
            this.txt_usuarioCancelacionTransferencia.PrefixSuffixText = null;
            this.txt_usuarioCancelacionTransferencia.ReadOnly = false;
            this.txt_usuarioCancelacionTransferencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_usuarioCancelacionTransferencia.SelectedText = "";
            this.txt_usuarioCancelacionTransferencia.SelectionLength = 0;
            this.txt_usuarioCancelacionTransferencia.SelectionStart = 0;
            this.txt_usuarioCancelacionTransferencia.ShortcutsEnabled = true;
            this.txt_usuarioCancelacionTransferencia.Size = new System.Drawing.Size(250, 48);
            this.txt_usuarioCancelacionTransferencia.TabIndex = 19;
            this.txt_usuarioCancelacionTransferencia.TabStop = false;
            this.txt_usuarioCancelacionTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_usuarioCancelacionTransferencia.TrailingIcon = null;
            this.txt_usuarioCancelacionTransferencia.UseSystemPasswordChar = false;
            // 
            // txt_horaCancelacionTransferencia
            // 
            this.txt_horaCancelacionTransferencia.AnimateReadOnly = false;
            this.txt_horaCancelacionTransferencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_horaCancelacionTransferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_horaCancelacionTransferencia.Depth = 0;
            this.txt_horaCancelacionTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_horaCancelacionTransferencia.HideSelection = true;
            this.txt_horaCancelacionTransferencia.LeadingIcon = null;
            this.txt_horaCancelacionTransferencia.Location = new System.Drawing.Point(553, 503);
            this.txt_horaCancelacionTransferencia.MaxLength = 32767;
            this.txt_horaCancelacionTransferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_horaCancelacionTransferencia.Name = "txt_horaCancelacionTransferencia";
            this.txt_horaCancelacionTransferencia.PasswordChar = '\0';
            this.txt_horaCancelacionTransferencia.PrefixSuffixText = null;
            this.txt_horaCancelacionTransferencia.ReadOnly = false;
            this.txt_horaCancelacionTransferencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_horaCancelacionTransferencia.SelectedText = "";
            this.txt_horaCancelacionTransferencia.SelectionLength = 0;
            this.txt_horaCancelacionTransferencia.SelectionStart = 0;
            this.txt_horaCancelacionTransferencia.ShortcutsEnabled = true;
            this.txt_horaCancelacionTransferencia.Size = new System.Drawing.Size(250, 48);
            this.txt_horaCancelacionTransferencia.TabIndex = 20;
            this.txt_horaCancelacionTransferencia.TabStop = false;
            this.txt_horaCancelacionTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_horaCancelacionTransferencia.TrailingIcon = null;
            this.txt_horaCancelacionTransferencia.UseSystemPasswordChar = false;
            // 
            // txt_penalizacion
            // 
            this.txt_penalizacion.AnimateReadOnly = false;
            this.txt_penalizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_penalizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_penalizacion.Depth = 0;
            this.txt_penalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_penalizacion.HideSelection = true;
            this.txt_penalizacion.LeadingIcon = null;
            this.txt_penalizacion.Location = new System.Drawing.Point(1135, 421);
            this.txt_penalizacion.MaxLength = 32767;
            this.txt_penalizacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_penalizacion.Name = "txt_penalizacion";
            this.txt_penalizacion.PasswordChar = '\0';
            this.txt_penalizacion.PrefixSuffixText = null;
            this.txt_penalizacion.ReadOnly = false;
            this.txt_penalizacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_penalizacion.SelectedText = "";
            this.txt_penalizacion.SelectionLength = 0;
            this.txt_penalizacion.SelectionStart = 0;
            this.txt_penalizacion.ShortcutsEnabled = true;
            this.txt_penalizacion.Size = new System.Drawing.Size(250, 48);
            this.txt_penalizacion.TabIndex = 21;
            this.txt_penalizacion.TabStop = false;
            this.txt_penalizacion.Text = "Monto";
            this.txt_penalizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_penalizacion.TrailingIcon = null;
            this.txt_penalizacion.UseSystemPasswordChar = false;
            // 
            // chkTransferenciaCompleta
            // 
            this.chkTransferenciaCompleta.AutoSize = true;
            this.chkTransferenciaCompleta.Depth = 0;
            this.chkTransferenciaCompleta.Location = new System.Drawing.Point(862, 503);
            this.chkTransferenciaCompleta.Margin = new System.Windows.Forms.Padding(0);
            this.chkTransferenciaCompleta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkTransferenciaCompleta.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkTransferenciaCompleta.Name = "chkTransferenciaCompleta";
            this.chkTransferenciaCompleta.ReadOnly = false;
            this.chkTransferenciaCompleta.Ripple = true;
            this.chkTransferenciaCompleta.Size = new System.Drawing.Size(205, 37);
            this.chkTransferenciaCompleta.TabIndex = 22;
            this.chkTransferenciaCompleta.Text = "Transferencia Completa";
            this.chkTransferenciaCompleta.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(1324, 171);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Cancelar.Size = new System.Drawing.Size(145, 98);
            this.btn_Cancelar.TabIndex = 62;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.Location = new System.Drawing.Point(1111, 171);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Guardar.Size = new System.Drawing.Size(145, 98);
            this.btn_Guardar.TabIndex = 61;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // cmb_motivoCancelacionTransferencia
            // 
            this.cmb_motivoCancelacionTransferencia.AutoResize = false;
            this.cmb_motivoCancelacionTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_motivoCancelacionTransferencia.Depth = 0;
            this.cmb_motivoCancelacionTransferencia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_motivoCancelacionTransferencia.DropDownHeight = 174;
            this.cmb_motivoCancelacionTransferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_motivoCancelacionTransferencia.DropDownWidth = 121;
            this.cmb_motivoCancelacionTransferencia.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_motivoCancelacionTransferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_motivoCancelacionTransferencia.FormattingEnabled = true;
            this.cmb_motivoCancelacionTransferencia.IntegralHeight = false;
            this.cmb_motivoCancelacionTransferencia.ItemHeight = 43;
            this.cmb_motivoCancelacionTransferencia.Location = new System.Drawing.Point(106, 421);
            this.cmb_motivoCancelacionTransferencia.MaxDropDownItems = 4;
            this.cmb_motivoCancelacionTransferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_motivoCancelacionTransferencia.Name = "cmb_motivoCancelacionTransferencia";
            this.cmb_motivoCancelacionTransferencia.Size = new System.Drawing.Size(305, 49);
            this.cmb_motivoCancelacionTransferencia.StartIndex = 0;
            this.cmb_motivoCancelacionTransferencia.TabIndex = 63;
            this.cmb_motivoCancelacionTransferencia.SelectedValueChanged += new System.EventHandler(this.cmb_motivoCancelacionTransferencia_SelectedValueChanged);
            // 
            // frmCancelacionesTransferenciasV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 705);
            this.Controls.Add(this.cmb_motivoCancelacionTransferencia);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.chkTransferenciaCompleta);
            this.Controls.Add(this.txt_penalizacion);
            this.Controls.Add(this.txt_horaCancelacionTransferencia);
            this.Controls.Add(this.txt_usuarioCancelacionTransferencia);
            this.Controls.Add(this.txt_FechaCancelacionTransferencia);
            this.Controls.Add(this.txt_motivoCancelacionTransferencia);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_asiento);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_origen);
            this.Controls.Add(this.txt_linea);
            this.Controls.Add(this.txt_destino);
            this.Controls.Add(this.txt_folio);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmCancelacionesTransferenciasV2";
            this.Text = "frmCancelacionesTransferenciasV2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_folio;
        private MaterialSkin.Controls.MaterialTextBox2 txt_destino;
        private MaterialSkin.Controls.MaterialTextBox2 txt_linea;
        private MaterialSkin.Controls.MaterialTextBox2 txt_origen;
        private MaterialSkin.Controls.MaterialTextBox2 txt_fecha;
        private MaterialSkin.Controls.MaterialTextBox2 txt_hora;
        private MaterialSkin.Controls.MaterialTextBox2 txt_asiento;
        private MaterialSkin.Controls.MaterialTextBox2 txt_precio;
        private MaterialSkin.Controls.MaterialTextBox2 txt_nombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_motivoCancelacionTransferencia;
        private MaterialSkin.Controls.MaterialTextBox2 txt_FechaCancelacionTransferencia;
        private MaterialSkin.Controls.MaterialTextBox2 txt_usuarioCancelacionTransferencia;
        private MaterialSkin.Controls.MaterialTextBox2 txt_horaCancelacionTransferencia;
        private MaterialSkin.Controls.MaterialTextBox2 txt_penalizacion;
        private MaterialSkin.Controls.MaterialCheckbox chkTransferenciaCompleta;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private MaterialSkin.Controls.MaterialComboBox cmb_motivoCancelacionTransferencia;
    }
}