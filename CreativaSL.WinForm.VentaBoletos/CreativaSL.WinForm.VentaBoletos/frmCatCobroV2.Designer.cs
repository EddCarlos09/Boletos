namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmCatCobroV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatCobroV2));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Txt_Cambio = new MaterialSkin.Controls.MaterialTextBox2();
            this.Txt_PagoMonedero = new MaterialSkin.Controls.MaterialTextBox2();
            this.Txt_PagoEfectivo = new MaterialSkin.Controls.MaterialTextBox2();
            this.Txt_Pendiente = new MaterialSkin.Controls.MaterialTextBox2();
            this.Txt_Pagar = new MaterialSkin.Controls.MaterialTextBox2();
            this.Txt_Total = new MaterialSkin.Controls.MaterialTextBox2();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.Txt_TiempoVenta = new MaterialSkin.Controls.MaterialTextBox2();
            this.Txt_NewMonedero = new MaterialSkin.Controls.MaterialTextBox2();
            this.Txt_Monedero = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtNombreCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.label10 = new MaterialSkin.Controls.MaterialLabel();
            this.label15 = new MaterialSkin.Controls.MaterialLabel();
            this.label16 = new MaterialSkin.Controls.MaterialLabel();
            this.label14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Cobrar = new System.Windows.Forms.Button();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.Txt_Cambio);
            this.materialCard1.Controls.Add(this.Txt_PagoMonedero);
            this.materialCard1.Controls.Add(this.Txt_PagoEfectivo);
            this.materialCard1.Controls.Add(this.Txt_Pendiente);
            this.materialCard1.Controls.Add(this.Txt_Pagar);
            this.materialCard1.Controls.Add(this.Txt_Total);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.label11);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(87, 317);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1188, 390);
            this.materialCard1.TabIndex = 21;
            // 
            // Txt_Cambio
            // 
            this.Txt_Cambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Cambio.AnimateReadOnly = false;
            this.Txt_Cambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_Cambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_Cambio.Depth = 0;
            this.Txt_Cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Cambio.HideSelection = true;
            this.Txt_Cambio.LeadingIcon = null;
            this.Txt_Cambio.Location = new System.Drawing.Point(453, 296);
            this.Txt_Cambio.MaxLength = 32767;
            this.Txt_Cambio.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_Cambio.Name = "Txt_Cambio";
            this.Txt_Cambio.PasswordChar = '\0';
            this.Txt_Cambio.PrefixSuffixText = null;
            this.Txt_Cambio.ReadOnly = false;
            this.Txt_Cambio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Cambio.SelectedText = "";
            this.Txt_Cambio.SelectionLength = 0;
            this.Txt_Cambio.SelectionStart = 0;
            this.Txt_Cambio.ShortcutsEnabled = true;
            this.Txt_Cambio.Size = new System.Drawing.Size(250, 48);
            this.Txt_Cambio.TabIndex = 15;
            this.Txt_Cambio.TabStop = false;
            this.Txt_Cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Cambio.TrailingIcon = null;
            this.Txt_Cambio.UseSystemPasswordChar = false;
            this.Txt_Cambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cambio_KeyPress);
            this.Txt_Cambio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Cambio_KeyUp);
            // 
            // Txt_PagoMonedero
            // 
            this.Txt_PagoMonedero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_PagoMonedero.AnimateReadOnly = false;
            this.Txt_PagoMonedero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_PagoMonedero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_PagoMonedero.Depth = 0;
            this.Txt_PagoMonedero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_PagoMonedero.HideSelection = true;
            this.Txt_PagoMonedero.LeadingIcon = null;
            this.Txt_PagoMonedero.Location = new System.Drawing.Point(647, 186);
            this.Txt_PagoMonedero.MaxLength = 32767;
            this.Txt_PagoMonedero.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_PagoMonedero.Name = "Txt_PagoMonedero";
            this.Txt_PagoMonedero.PasswordChar = '\0';
            this.Txt_PagoMonedero.PrefixSuffixText = null;
            this.Txt_PagoMonedero.ReadOnly = false;
            this.Txt_PagoMonedero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_PagoMonedero.SelectedText = "";
            this.Txt_PagoMonedero.SelectionLength = 0;
            this.Txt_PagoMonedero.SelectionStart = 0;
            this.Txt_PagoMonedero.ShortcutsEnabled = true;
            this.Txt_PagoMonedero.Size = new System.Drawing.Size(250, 48);
            this.Txt_PagoMonedero.TabIndex = 12;
            this.Txt_PagoMonedero.TabStop = false;
            this.Txt_PagoMonedero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_PagoMonedero.TrailingIcon = null;
            this.Txt_PagoMonedero.UseSystemPasswordChar = false;
            this.Txt_PagoMonedero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_PagoMonedero_KeyDown);
            this.Txt_PagoMonedero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PagoMonedero_KeyPress);
            this.Txt_PagoMonedero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_PagoMonedero_KeyUp);
            // 
            // Txt_PagoEfectivo
            // 
            this.Txt_PagoEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_PagoEfectivo.AnimateReadOnly = false;
            this.Txt_PagoEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_PagoEfectivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_PagoEfectivo.Depth = 0;
            this.Txt_PagoEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_PagoEfectivo.HideSelection = true;
            this.Txt_PagoEfectivo.LeadingIcon = null;
            this.Txt_PagoEfectivo.Location = new System.Drawing.Point(248, 186);
            this.Txt_PagoEfectivo.MaxLength = 32767;
            this.Txt_PagoEfectivo.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_PagoEfectivo.Name = "Txt_PagoEfectivo";
            this.Txt_PagoEfectivo.PasswordChar = '\0';
            this.Txt_PagoEfectivo.PrefixSuffixText = null;
            this.Txt_PagoEfectivo.ReadOnly = false;
            this.Txt_PagoEfectivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_PagoEfectivo.SelectedText = "";
            this.Txt_PagoEfectivo.SelectionLength = 0;
            this.Txt_PagoEfectivo.SelectionStart = 0;
            this.Txt_PagoEfectivo.ShortcutsEnabled = true;
            this.Txt_PagoEfectivo.Size = new System.Drawing.Size(250, 48);
            this.Txt_PagoEfectivo.TabIndex = 11;
            this.Txt_PagoEfectivo.TabStop = false;
            this.Txt_PagoEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_PagoEfectivo.TrailingIcon = null;
            this.Txt_PagoEfectivo.UseSystemPasswordChar = false;
            this.Txt_PagoEfectivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Pago_KeyDown);
            this.Txt_PagoEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Pago_KeyPress);
            this.Txt_PagoEfectivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Pago_KeyUp);
            // 
            // Txt_Pendiente
            // 
            this.Txt_Pendiente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Pendiente.AnimateReadOnly = false;
            this.Txt_Pendiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_Pendiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_Pendiente.Depth = 0;
            this.Txt_Pendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Pendiente.HideSelection = true;
            this.Txt_Pendiente.LeadingIcon = null;
            this.Txt_Pendiente.Location = new System.Drawing.Point(853, 64);
            this.Txt_Pendiente.MaxLength = 32767;
            this.Txt_Pendiente.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_Pendiente.Name = "Txt_Pendiente";
            this.Txt_Pendiente.PasswordChar = '\0';
            this.Txt_Pendiente.PrefixSuffixText = null;
            this.Txt_Pendiente.ReadOnly = false;
            this.Txt_Pendiente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Pendiente.SelectedText = "";
            this.Txt_Pendiente.SelectionLength = 0;
            this.Txt_Pendiente.SelectionStart = 0;
            this.Txt_Pendiente.ShortcutsEnabled = true;
            this.Txt_Pendiente.Size = new System.Drawing.Size(250, 48);
            this.Txt_Pendiente.TabIndex = 10;
            this.Txt_Pendiente.TabStop = false;
            this.Txt_Pendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Pendiente.TrailingIcon = null;
            this.Txt_Pendiente.UseSystemPasswordChar = false;
            // 
            // Txt_Pagar
            // 
            this.Txt_Pagar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Pagar.AnimateReadOnly = false;
            this.Txt_Pagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_Pagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_Pagar.Depth = 0;
            this.Txt_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Pagar.HideSelection = true;
            this.Txt_Pagar.LeadingIcon = null;
            this.Txt_Pagar.Location = new System.Drawing.Point(426, 64);
            this.Txt_Pagar.MaxLength = 32767;
            this.Txt_Pagar.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_Pagar.Name = "Txt_Pagar";
            this.Txt_Pagar.PasswordChar = '\0';
            this.Txt_Pagar.PrefixSuffixText = null;
            this.Txt_Pagar.ReadOnly = false;
            this.Txt_Pagar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Pagar.SelectedText = "";
            this.Txt_Pagar.SelectionLength = 0;
            this.Txt_Pagar.SelectionStart = 0;
            this.Txt_Pagar.ShortcutsEnabled = true;
            this.Txt_Pagar.Size = new System.Drawing.Size(250, 48);
            this.Txt_Pagar.TabIndex = 9;
            this.Txt_Pagar.TabStop = false;
            this.Txt_Pagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Pagar.TrailingIcon = null;
            this.Txt_Pagar.UseSystemPasswordChar = false;
            // 
            // Txt_Total
            // 
            this.Txt_Total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Total.AnimateReadOnly = false;
            this.Txt_Total.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_Total.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_Total.Depth = 0;
            this.Txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Total.HideSelection = true;
            this.Txt_Total.LeadingIcon = null;
            this.Txt_Total.Location = new System.Drawing.Point(42, 64);
            this.Txt_Total.MaxLength = 32767;
            this.Txt_Total.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.PasswordChar = '\0';
            this.Txt_Total.PrefixSuffixText = null;
            this.Txt_Total.ReadOnly = false;
            this.Txt_Total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Total.SelectedText = "";
            this.Txt_Total.SelectionLength = 0;
            this.Txt_Total.SelectionStart = 0;
            this.Txt_Total.ShortcutsEnabled = true;
            this.Txt_Total.Size = new System.Drawing.Size(250, 48);
            this.Txt_Total.TabIndex = 8;
            this.Txt_Total.TabStop = false;
            this.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Total.TrailingIcon = null;
            this.Txt_Total.UseSystemPasswordChar = false;
            this.Txt_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Total_KeyPress);
            this.Txt_Total.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Total_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(545, 253);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cambio:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(710, 144);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pago Monedero:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(321, 144);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pago Efectivo:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(850, 29);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pendiente:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(439, 29);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pagar:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Depth = 0;
            this.label11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.Location = new System.Drawing.Point(39, 29);
            this.label11.MouseState = MaterialSkin.MouseState.HOVER;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(99, 284);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(92, 19);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Monto Pago:";
            // 
            // Txt_TiempoVenta
            // 
            this.Txt_TiempoVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_TiempoVenta.AnimateReadOnly = false;
            this.Txt_TiempoVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_TiempoVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_TiempoVenta.Depth = 0;
            this.Txt_TiempoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_TiempoVenta.HelperText = "00:0";
            this.Txt_TiempoVenta.HideSelection = true;
            this.Txt_TiempoVenta.Hint = "00:0";
            this.Txt_TiempoVenta.LeadingIcon = null;
            this.Txt_TiempoVenta.Location = new System.Drawing.Point(1154, 184);
            this.Txt_TiempoVenta.MaxLength = 32767;
            this.Txt_TiempoVenta.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_TiempoVenta.Name = "Txt_TiempoVenta";
            this.Txt_TiempoVenta.PasswordChar = '\0';
            this.Txt_TiempoVenta.PrefixSuffixText = null;
            this.Txt_TiempoVenta.ReadOnly = false;
            this.Txt_TiempoVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_TiempoVenta.SelectedText = "";
            this.Txt_TiempoVenta.SelectionLength = 0;
            this.Txt_TiempoVenta.SelectionStart = 0;
            this.Txt_TiempoVenta.ShortcutsEnabled = true;
            this.Txt_TiempoVenta.Size = new System.Drawing.Size(158, 48);
            this.Txt_TiempoVenta.TabIndex = 19;
            this.Txt_TiempoVenta.TabStop = false;
            this.Txt_TiempoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_TiempoVenta.TrailingIcon = null;
            this.Txt_TiempoVenta.UseSystemPasswordChar = false;
            // 
            // Txt_NewMonedero
            // 
            this.Txt_NewMonedero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_NewMonedero.AnimateReadOnly = false;
            this.Txt_NewMonedero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_NewMonedero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_NewMonedero.Depth = 0;
            this.Txt_NewMonedero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_NewMonedero.HideSelection = true;
            this.Txt_NewMonedero.LeadingIcon = null;
            this.Txt_NewMonedero.Location = new System.Drawing.Point(734, 184);
            this.Txt_NewMonedero.MaxLength = 32767;
            this.Txt_NewMonedero.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_NewMonedero.Name = "Txt_NewMonedero";
            this.Txt_NewMonedero.PasswordChar = '\0';
            this.Txt_NewMonedero.PrefixSuffixText = null;
            this.Txt_NewMonedero.ReadOnly = false;
            this.Txt_NewMonedero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_NewMonedero.SelectedText = "";
            this.Txt_NewMonedero.SelectionLength = 0;
            this.Txt_NewMonedero.SelectionStart = 0;
            this.Txt_NewMonedero.ShortcutsEnabled = true;
            this.Txt_NewMonedero.Size = new System.Drawing.Size(250, 48);
            this.Txt_NewMonedero.TabIndex = 18;
            this.Txt_NewMonedero.TabStop = false;
            this.Txt_NewMonedero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_NewMonedero.TrailingIcon = null;
            this.Txt_NewMonedero.UseSystemPasswordChar = false;
            // 
            // Txt_Monedero
            // 
            this.Txt_Monedero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Monedero.AnimateReadOnly = false;
            this.Txt_Monedero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Txt_Monedero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txt_Monedero.Depth = 0;
            this.Txt_Monedero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Monedero.HideSelection = true;
            this.Txt_Monedero.LeadingIcon = null;
            this.Txt_Monedero.Location = new System.Drawing.Point(411, 184);
            this.Txt_Monedero.MaxLength = 32767;
            this.Txt_Monedero.MouseState = MaterialSkin.MouseState.OUT;
            this.Txt_Monedero.Name = "Txt_Monedero";
            this.Txt_Monedero.PasswordChar = '\0';
            this.Txt_Monedero.PrefixSuffixText = null;
            this.Txt_Monedero.ReadOnly = false;
            this.Txt_Monedero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Monedero.SelectedText = "";
            this.Txt_Monedero.SelectionLength = 0;
            this.Txt_Monedero.SelectionStart = 0;
            this.Txt_Monedero.ShortcutsEnabled = true;
            this.Txt_Monedero.Size = new System.Drawing.Size(250, 48);
            this.Txt_Monedero.TabIndex = 17;
            this.Txt_Monedero.TabStop = false;
            this.Txt_Monedero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Monedero.TrailingIcon = null;
            this.Txt_Monedero.UseSystemPasswordChar = false;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNombreCliente.AnimateReadOnly = false;
            this.TxtNombreCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNombreCliente.Depth = 0;
            this.TxtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNombreCliente.HideSelection = true;
            this.TxtNombreCliente.LeadingIcon = null;
            this.TxtNombreCliente.Location = new System.Drawing.Point(87, 184);
            this.TxtNombreCliente.MaxLength = 32767;
            this.TxtNombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.PasswordChar = '\0';
            this.TxtNombreCliente.PrefixSuffixText = null;
            this.TxtNombreCliente.ReadOnly = false;
            this.TxtNombreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNombreCliente.SelectedText = "";
            this.TxtNombreCliente.SelectionLength = 0;
            this.TxtNombreCliente.SelectionStart = 0;
            this.TxtNombreCliente.ShortcutsEnabled = true;
            this.TxtNombreCliente.Size = new System.Drawing.Size(250, 48);
            this.TxtNombreCliente.TabIndex = 16;
            this.TxtNombreCliente.TabStop = false;
            this.TxtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNombreCliente.TrailingIcon = null;
            this.TxtNombreCliente.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Depth = 0;
            this.label10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(1175, 138);
            this.label10.MouseState = MaterialSkin.MouseState.HOVER;
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tiempo Venta";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Depth = 0;
            this.label15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.Location = new System.Drawing.Point(731, 138);
            this.label15.MouseState = MaterialSkin.MouseState.HOVER;
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 19);
            this.label15.TabIndex = 14;
            this.label15.Text = "$ Nuevo Monedero";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Depth = 0;
            this.label16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.Location = new System.Drawing.Point(408, 138);
            this.label16.MouseState = MaterialSkin.MouseState.HOVER;
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 19);
            this.label16.TabIndex = 13;
            this.label16.Text = "$ Monedero";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Depth = 0;
            this.label14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.Location = new System.Drawing.Point(84, 138);
            this.label14.MouseState = MaterialSkin.MouseState.HOVER;
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 19);
            this.label14.TabIndex = 12;
            this.label14.Text = "Cliente";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(99, 85);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(103, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Datos Clientes";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.Location = new System.Drawing.Point(786, 724);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Cancelar.Size = new System.Drawing.Size(250, 98);
            this.btn_Cancelar.TabIndex = 64;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Cobrar
            // 
            this.btn_Cobrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cobrar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cobrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cobrar.Image")));
            this.btn_Cobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cobrar.Location = new System.Drawing.Point(293, 724);
            this.btn_Cobrar.Name = "btn_Cobrar";
            this.btn_Cobrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.btn_Cobrar.Size = new System.Drawing.Size(250, 98);
            this.btn_Cobrar.TabIndex = 63;
            this.btn_Cobrar.Text = "Cobrar";
            this.btn_Cobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cobrar.UseVisualStyleBackColor = true;
            this.btn_Cobrar.Click += new System.EventHandler(this.btn_Cobrar_Click);
            // 
            // frmCatCobroV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 859);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cobrar);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.Txt_TiempoVenta);
            this.Controls.Add(this.Txt_NewMonedero);
            this.Controls.Add(this.Txt_Monedero);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmCatCobroV2";
            this.Text = "frmCatCobroV2";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_Cambio;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_PagoMonedero;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_PagoEfectivo;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_Pendiente;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_Pagar;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_Total;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialLabel label11;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_TiempoVenta;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_NewMonedero;
        private MaterialSkin.Controls.MaterialTextBox2 Txt_Monedero;
        private System.ComponentModel.BackgroundWorker backgroundWorkerVenta;
        private MaterialSkin.Controls.MaterialTextBox2 TxtNombreCliente;
        private MaterialSkin.Controls.MaterialLabel label10;
        private MaterialSkin.Controls.MaterialLabel label15;
        private MaterialSkin.Controls.MaterialLabel label16;
        private MaterialSkin.Controls.MaterialLabel label14;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Cobrar;
    }
}