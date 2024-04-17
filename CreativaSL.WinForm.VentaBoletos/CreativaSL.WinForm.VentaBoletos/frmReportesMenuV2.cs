using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmReportesMenuV2 : MaterialForm
    {
        public frmReportesMenuV2()
        {
            InitializeComponent();
            loadMaterial(this);
            this.TopMost = true;
            this.IsMdiContainer = true;
            this.checkBox_Mensual.Checked = true;
        }
        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCaja_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportesV2 frmReportesVista = new frmReportesV2(1);
                frmReportesVista.Estadisticos = this.checkBox_Estadisticos.Checked;
                frmReportesVista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClienteFrecuente_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportesV2 frmReportesVista = new frmReportesV2(8);
                frmReportesVista.Estadisticos = this.checkBox_Estadisticos.Checked;
                frmReportesVista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClienteComprador_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportesV2 frmReportesVista = new frmReportesV2(7);
                frmReportesVista.Estadisticos = this.checkBox_Estadisticos.Checked;
                frmReportesVista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnViajes_Click(object sender, EventArgs e)
        {
            try
            {
                frmDatosViajes DatosViajes = new frmDatosViajes(this.checkBox_Estadisticos.Checked);
                DatosViajes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_TotalesCajaDia_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportesV2 frmReportesVista = new frmReportesV2(2);
                frmReportesVista.Estadisticos = this.checkBox_Estadisticos.Checked;
                frmReportesVista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMaletas_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportesV2 frmReportesVista = new frmReportesV2(6);
                frmReportesVista.Estadisticos = this.checkBox_Estadisticos.Checked;
                frmReportesVista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBoleto_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportesV2 frmReportesVista = new frmReportesV2(5);
                frmReportesVista.Estadisticos = this.checkBox_Estadisticos.Checked;
                frmReportesVista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnViajesPrecios_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportesV2 frmReportesVista = new frmReportesV2(6);
                frmReportesVista.Estadisticos = this.checkBox_Estadisticos.Checked;
                frmReportesVista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Vendedores_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportesV2 frmReportesVista = new frmReportesV2(4);
                frmReportesVista.Estadisticos = this.checkBox_Estadisticos.Checked;
                frmReportesVista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCajaXFechas_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportesV2 frmReportesVista = new frmReportesV2(3);
                frmReportesVista.Estadisticos = this.checkBox_Estadisticos.Checked;
                frmReportesVista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void checkBox_Mensual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_Mensual.Checked == true)
                    checkBox_Estadisticos.Checked = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void checkBox_Estadisticos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_Estadisticos.Checked == true)
                    checkBox_Mensual.Checked = false;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
