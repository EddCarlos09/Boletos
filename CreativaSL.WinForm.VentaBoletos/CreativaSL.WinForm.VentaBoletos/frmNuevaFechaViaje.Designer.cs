namespace CreativaSL.WinForm.VentaBoletos
{
    partial class frmNuevaFechaViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaFechaViaje));
            this.panel_Creativa1 = new CreativaSL.LibControls.WinForms.Panel_Creativa(this.components);
            this.btn_Guardar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.btn_Cancelar = new CreativaSL.LibControls.WinForms.Button_Creativa();
            this.panelTitle_Creativa1 = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.panelDias = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.panelFechas = new CreativaSL.LibControls.WinForms.PanelTitle_Creativa(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtViaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Creativa1.SuspendLayout();
            this.panelTitle_Creativa1.SuspendLayout();
            this.panelDias.SuspendLayout();
            this.panelFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Creativa1
            // 
            this.panel_Creativa1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Creativa1.BorderRound = true;
            this.panel_Creativa1.Controls.Add(this.btn_Guardar);
            this.panel_Creativa1.Controls.Add(this.btn_Cancelar);
            this.panel_Creativa1.DrawGradient = false;
            this.panel_Creativa1.GradientTop = true;
            this.panel_Creativa1.LinearGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panel_Creativa1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_Creativa1.Location = new System.Drawing.Point(-1, 315);
            this.panel_Creativa1.Name = "panel_Creativa1";
            this.panel_Creativa1.Size = new System.Drawing.Size(394, 85);
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
            this.btn_Guardar.Location = new System.Drawing.Point(210, 10);
            this.btn_Guardar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Guardar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.OffsetPressedContent = true;
            this.btn_Guardar.Size = new System.Drawing.Size(80, 65);
            this.btn_Guardar.TabIndex = 10;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(300, 10);
            this.btn_Cancelar.ModeGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Cancelar.MouseOverColor = System.Drawing.Color.YellowGreen;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.OffsetPressedContent = true;
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 65);
            this.btn_Cancelar.TabIndex = 11;
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
            this.panelTitle_Creativa1.Controls.Add(this.panelDias);
            this.panelTitle_Creativa1.Controls.Add(this.panelFechas);
            this.panelTitle_Creativa1.Controls.Add(this.label8);
            this.panelTitle_Creativa1.Controls.Add(this.panel_Creativa1);
            this.panelTitle_Creativa1.Controls.Add(this.TxtViaje);
            this.panelTitle_Creativa1.Controls.Add(this.label1);
            this.panelTitle_Creativa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle_Creativa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle_Creativa1.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelTitle_Creativa1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_Creativa1.Name = "panelTitle_Creativa1";
            this.panelTitle_Creativa1.Size = new System.Drawing.Size(393, 399);
            this.panelTitle_Creativa1.SizeLine = 3;
            this.panelTitle_Creativa1.SizeTitle = 20;
            this.panelTitle_Creativa1.TabIndex = 4;
            this.panelTitle_Creativa1.Title = "";
            this.panelTitle_Creativa1.TitleColor = System.Drawing.Color.Transparent;
            // 
            // panelDias
            // 
            this.panelDias.BackColor = System.Drawing.SystemColors.InactiveCaption;
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
            this.panelDias.Location = new System.Drawing.Point(36, 85);
            this.panelDias.Name = "panelDias";
            this.panelDias.Size = new System.Drawing.Size(333, 100);
            this.panelDias.SizeLine = 3;
            this.panelDias.SizeTitle = 20;
            this.panelDias.TabIndex = 131;
            this.panelDias.Title = "Días";
            this.panelDias.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.BackColor = System.Drawing.Color.Transparent;
            this.chkDomingo.Location = new System.Drawing.Point(272, 44);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(40, 24);
            this.chkDomingo.TabIndex = 7;
            this.chkDomingo.Text = "D";
            this.chkDomingo.UseVisualStyleBackColor = false;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.BackColor = System.Drawing.Color.Transparent;
            this.chkSabado.Location = new System.Drawing.Point(229, 43);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(39, 24);
            this.chkSabado.TabIndex = 6;
            this.chkSabado.Text = "S";
            this.chkSabado.UseVisualStyleBackColor = false;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.BackColor = System.Drawing.Color.Transparent;
            this.chkViernes.Location = new System.Drawing.Point(186, 44);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(39, 24);
            this.chkViernes.TabIndex = 5;
            this.chkViernes.Text = "V";
            this.chkViernes.UseVisualStyleBackColor = false;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.BackColor = System.Drawing.Color.Transparent;
            this.chkJueves.Location = new System.Drawing.Point(145, 44);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(36, 24);
            this.chkJueves.TabIndex = 4;
            this.chkJueves.Text = "J";
            this.chkJueves.UseVisualStyleBackColor = false;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.BackColor = System.Drawing.Color.Transparent;
            this.chkMiercoles.Location = new System.Drawing.Point(100, 44);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(41, 24);
            this.chkMiercoles.TabIndex = 3;
            this.chkMiercoles.Text = "M";
            this.chkMiercoles.UseVisualStyleBackColor = false;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.BackColor = System.Drawing.Color.Transparent;
            this.chkMartes.Location = new System.Drawing.Point(54, 44);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(41, 24);
            this.chkMartes.TabIndex = 3;
            this.chkMartes.Text = "M";
            this.chkMartes.UseVisualStyleBackColor = false;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.BackColor = System.Drawing.Color.Transparent;
            this.chkLunes.Location = new System.Drawing.Point(11, 44);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(37, 24);
            this.chkLunes.TabIndex = 1;
            this.chkLunes.Text = "L";
            this.chkLunes.UseVisualStyleBackColor = false;
            // 
            // panelFechas
            // 
            this.panelFechas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelFechas.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.panelFechas.Controls.Add(this.label3);
            this.panelFechas.Controls.Add(this.dtpFecInicio);
            this.panelFechas.Controls.Add(this.label2);
            this.panelFechas.Controls.Add(this.dtpFecFin);
            this.panelFechas.LinearGradientModeBgk = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelFechas.Location = new System.Drawing.Point(36, 193);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(333, 100);
            this.panelFechas.SizeLine = 3;
            this.panelFechas.SizeTitle = 20;
            this.panelFechas.TabIndex = 130;
            this.panelFechas.Title = "Fechas";
            this.panelFechas.TitleColor = System.Drawing.Color.LightBlue;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(40, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Inicio";
            // 
            // dtpFecInicio
            // 
            this.dtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecInicio.Location = new System.Drawing.Point(148, 33);
            this.dtpFecInicio.Name = "dtpFecInicio";
            this.dtpFecInicio.Size = new System.Drawing.Size(117, 26);
            this.dtpFecInicio.TabIndex = 8;
            this.dtpFecInicio.ValueChanged += new System.EventHandler(this.dtpFecInicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Final";
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(148, 60);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(117, 26);
            this.dtpFecFin.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(110, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nueva Fechas Viaje";
            // 
            // TxtViaje
            // 
            this.TxtViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtViaje.Location = new System.Drawing.Point(108, 43);
            this.TxtViaje.MaxLength = 250;
            this.TxtViaje.Name = "TxtViaje";
            this.TxtViaje.ReadOnly = true;
            this.TxtViaje.Size = new System.Drawing.Size(261, 27);
            this.TxtViaje.TabIndex = 0;
            this.TxtViaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreMarca_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Viaje";
            // 
            // frmNuevaFechaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 399);
            this.ControlBox = true;
            this.Controls.Add(this.panelTitle_Creativa1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevaFechaViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Fechas Viaje";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.panel_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.ResumeLayout(false);
            this.panelTitle_Creativa1.PerformLayout();
            this.panelDias.ResumeLayout(false);
            this.panelDias.PerformLayout();
            this.panelFechas.ResumeLayout(false);
            this.panelFechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LibControls.WinForms.Panel_Creativa panel_Creativa1;
        private LibControls.WinForms.Button_Creativa btn_Guardar;
        private LibControls.WinForms.Button_Creativa btn_Cancelar;
        private LibControls.WinForms.PanelTitle_Creativa panelTitle_Creativa1;
        private System.Windows.Forms.TextBox TxtViaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private LibControls.WinForms.PanelTitle_Creativa panelDias;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkLunes;
        private LibControls.WinForms.PanelTitle_Creativa panelFechas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
    }
}