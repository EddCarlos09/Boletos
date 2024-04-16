namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmNuevaFechaViajeV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaFechaViajeV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtViaje = new MaterialSkin.Controls.MaterialTextBox();
            this.panelFechas = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelFechas.SuspendLayout();
            this.panelDias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.TxtViaje);
            this.panel1.Controls.Add(this.panelFechas);
            this.panel1.Controls.Add(this.panelDias);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 532);
            this.panel1.TabIndex = 0;
            // 
            // TxtViaje
            // 
            this.TxtViaje.AnimateReadOnly = false;
            this.TxtViaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtViaje.Depth = 0;
            this.TxtViaje.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtViaje.LeadingIcon = null;
            this.TxtViaje.Location = new System.Drawing.Point(119, 67);
            this.TxtViaje.MaxLength = 50;
            this.TxtViaje.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtViaje.Multiline = false;
            this.TxtViaje.Name = "TxtViaje";
            this.TxtViaje.Size = new System.Drawing.Size(388, 50);
            this.TxtViaje.TabIndex = 44;
            this.TxtViaje.Text = "";
            this.TxtViaje.TrailingIcon = null;
            this.TxtViaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreMarca_KeyPress);
            // 
            // panelFechas
            // 
            this.panelFechas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelFechas.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelFechas.Controls.Add(this.label2);
            this.panelFechas.Controls.Add(this.label3);
            this.panelFechas.Controls.Add(this.dtpFecInicio);
            this.panelFechas.Controls.Add(this.dtpFecFin);
            this.panelFechas.DrawGradient = false;
            this.panelFechas.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelFechas.Location = new System.Drawing.Point(439, 149);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(358, 127);
            this.panelFechas.SizeLine = 3;
            this.panelFechas.SizeTitle = 20;
            this.panelFechas.TabIndex = 42;
            this.panelFechas.Title = "Fechas";
            this.panelFechas.TitleColor = System.Drawing.Color.GhostWhite;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Fecha Final";
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
            this.panelDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDias.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelDias.Location = new System.Drawing.Point(40, 140);
            this.panelDias.Name = "panelDias";
            this.panelDias.Size = new System.Drawing.Size(358, 136);
            this.panelDias.SizeLine = 3;
            this.panelDias.SizeTitle = 20;
            this.panelDias.TabIndex = 43;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(35, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Viaje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(35, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nueva Fechas Viaje";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.Location = new System.Drawing.Point(269, 333);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_Guardar.Size = new System.Drawing.Size(129, 113);
            this.btn_Guardar.TabIndex = 61;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(439, 333);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_Cancelar.Size = new System.Drawing.Size(129, 113);
            this.btn_Cancelar.TabIndex = 62;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frmNuevaFechaViajeV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 599);
            this.Controls.Add(this.panel1);
            this.Name = "frmNuevaFechaViajeV2";
            this.Text = "frmNuevaFechaViajeV2";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private LibControls.WinForms.PanelTitle_Creativa panelDias;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkLunes;
        private MaterialSkin.Controls.MaterialTextBox TxtViaje;
        private LibControls.WinForms.PanelTitle_Creativa panelFechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecInicio;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}