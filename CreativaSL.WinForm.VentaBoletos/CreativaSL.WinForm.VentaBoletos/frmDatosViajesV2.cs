using System;
using System.Collections.Generic;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativaSL.LibControls.WinForms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using System.Globalization;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmDatosViajesV2 : MaterialForm
    {
        bool _Estadisticos = false;
        public frmDatosViajesV2(bool Estadisticos)
        {
            try
            {
                _Estadisticos = Estadisticos;
                InitializeComponent();
                Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Inicializar()
        {
            try
            {
                dtpFecha.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
            }
        }

        #region GridViajesReportes
        private List<DataGridViewRow> ObtenerFilaSeleccionadaGvdatosboleto()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dgvdatosviajes.Rows)
                {
                    if (row.Selected)
                    {
                        rowSelected.Add(row);
                    }
                }
                return rowSelected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarFilaSeleccionadaGvdatosboleto(List<DataGridViewRow> rowSelected)
        {
            try
            {
                if (rowSelected.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Eventos
        #endregion
        #region Metodos Generales
        #endregion

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToDateTime(dtpFecha.Value.ToShortDateString()) > Convert.ToDateTime(DateTime.Now.AddDays(10).ToShortDateString()))
                {
                    MessageBox.Show("No puedes buscar a una fecha mayor a " + DateTime.Now.AddDays(10).ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFecha.Value = DateTime.Now;
                }
                if (_Estadisticos == false)
                {
                    if (Convert.ToDateTime(dtpFecha.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.AddDays(-30).ToShortDateString()))
                    {
                        MessageBox.Show("No puedes buscar a una fecha menor a " + DateTime.Now.AddDays(30).ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpFecha.Value = DateTime.Now;
                    }
                    else
                    {
                        ReportesBoletosViajeHecotours rptDatos = new ReportesBoletosViajeHecotours();
                        Reportes_Negocio rpt_negocio = new Reportes_Negocio();
                        rptDatos = rpt_negocio.RptViajesGenerados(Comun.Conexion, dtpFecha.Value, _Estadisticos);
                        this.dgvdatosviajes.AutoGenerateColumns = false;
                        this.dgvdatosviajes.DataSource = rptDatos.resultado;
                    }
                }
                else
                {
                    ReportesBoletosViajeHecotours rptDatos = new ReportesBoletosViajeHecotours();
                    Reportes_Negocio rpt_negocio = new Reportes_Negocio();
                    rptDatos = rpt_negocio.RptViajesGenerados(Comun.Conexion, dtpFecha.Value, _Estadisticos);
                    this.dgvdatosviajes.AutoGenerateColumns = false;
                    this.dgvdatosviajes.DataSource = rptDatos.resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public ReportesBoletosViajeHecotours obtenerDatosViaje()
        {
            try
            {
                ReportesBoletosViajeHecotours reporte = new ReportesBoletosViajeHecotours();
                if (this.dgvdatosviajes.SelectedRows.Count > 0)
                {
                    reporte.IDViaje = dgvdatosviajes.SelectedRows[0].Cells["id_viaje"].Value.ToString();
                    reporte.FechaV = Convert.ToDateTime(dgvdatosviajes.SelectedRows[0].Cells["fecha_salida"].Value.ToString());
                    reporte.HoraV = dgvdatosviajes.SelectedRows[0].Cells["hora_salida"].Value.ToString();
                    reporte.id_datosViaje = dgvdatosviajes.SelectedRows[0].Cells["id_datosViaje"].Value.ToString();
                    reporte.id_prestacionServicios1 = dgvdatosviajes.SelectedRows[0].Cells["id_prestacionServicios1"].Value.ToString();
                    reporte.id_prestacionServicios2 = dgvdatosviajes.SelectedRows[0].Cells["id_prestacionServicios2"].Value.ToString();
                    reporte.id_listapasajeros = dgvdatosviajes.SelectedRows[0].Cells["id_listapasajeros"].Value.ToString();
                }
                return reporte;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region Eventos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmDatosViajeV2 DatosViajes = new frmDatosViajeV2(new ReportesBoletosViajeHecotours(), dtpFecha.Value);
                DatosViajes.TopMost = true;
                DatosViajes.ShowDialog();
                DatosViajes.Dispose();
                ReportesBoletosViajeHecotours rptDatos = new ReportesBoletosViajeHecotours();
                Reportes_Negocio rpt_negocio = new Reportes_Negocio();
                rptDatos = rpt_negocio.RptViajesGenerados(Comun.Conexion, dtpFecha.Value, _Estadisticos);
                this.dgvdatosviajes.AutoGenerateColumns = false;
                this.dgvdatosviajes.DataSource = rptDatos.resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int Verficador = 0;

                if (this.dgvdatosviajes.Rows.Count > 0)
                {
                    ReportesBoletosViajeHecotours ViajeAux = this.obtenerDatosViaje();
                    Reportes_Negocio rpt_negocio = new Reportes_Negocio();
                    rpt_negocio.obtenerDatosReportesViaje(Comun.Conexion, ref ViajeAux, _Estadisticos);
                    frmDatosViajeV2 frmDatosViaje = new frmDatosViajeV2(ViajeAux);
                    frmDatosViaje.TopMost = true;
                    frmDatosViaje.ShowDialog();
                    ReportesBoletosViajeHecotours rptDatos = new ReportesBoletosViajeHecotours();
                    rptDatos = rpt_negocio.RptViajesGenerados(Comun.Conexion, dtpFecha.Value, _Estadisticos);
                    this.dgvdatosviajes.AutoGenerateColumns = false;
                    this.dgvdatosviajes.DataSource = rptDatos.resultado;
                }
                else
                    MessageBox.Show("No hay reportes seleccionados", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int Verficador = 0;
                if (this.dgvdatosviajes.Rows.Count > 0)
                {
                    ReportesBoletosViajeHecotours ViajeAux = this.obtenerDatosViaje();
                    Reportes_Negocio rpt_negocio = new Reportes_Negocio();
                    rpt_negocio.EliminarRprViaje(Comun.Conexion, ViajeAux, ref Verficador);
                    ReportesBoletosViajeHecotours rptDatos = new ReportesBoletosViajeHecotours();
                    rptDatos = rpt_negocio.RptViajesGenerados(Comun.Conexion, dtpFecha.Value, _Estadisticos);
                    this.dgvdatosviajes.AutoGenerateColumns = false;
                    this.dgvdatosviajes.DataSource = rptDatos.resultado;
                }
                else
                    MessageBox.Show("No hay reportes seleccionados", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRpt1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosviajes.Rows.Count > 0)
                {
                    ReportesBoletosViajeHecotours ViajeAux = this.obtenerDatosViaje();
                    Reportes_Negocio rpt_negocio = new Reportes_Negocio();
                    rpt_negocio.obtenerDatosReportesViaje(Comun.Conexion, ref ViajeAux, _Estadisticos);
                    frmReportes frmReportesVista = new frmReportes(9, ViajeAux);
                    frmReportesVista.Estadisticos = false;
                    frmReportesVista.ShowDialog();
                }
                else
                    MessageBox.Show("No hay reportes seleccionados", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRpt2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosviajes.Rows.Count > 0)
                {
                    ReportesBoletosViajeHecotours ViajeAux = this.obtenerDatosViaje();
                    Reportes_Negocio rpt_negocio = new Reportes_Negocio();
                    rpt_negocio.obtenerDatosReportesViaje(Comun.Conexion, ref ViajeAux, _Estadisticos);
                    frmReportes frmReportesVista = new frmReportes(10, ViajeAux);
                    frmReportesVista.Estadisticos = false;
                    frmReportesVista.ShowDialog();
                }
                else
                    MessageBox.Show("No hay reportes seleccionados", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRpt3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosviajes.Rows.Count > 0)
                {
                    ReportesBoletosViajeHecotours ViajeAux = this.obtenerDatosViaje();
                    Reportes_Negocio rpt_negocio = new Reportes_Negocio();
                    rpt_negocio.obtenerDatosReportesViaje(Comun.Conexion, ref ViajeAux, _Estadisticos);
                    frmReportes frmReportesVista = new frmReportes(11, ViajeAux);
                    frmReportesVista.Estadisticos = false;
                    frmReportesVista.ShowDialog();
                }
                else
                    MessageBox.Show("No hay reportes seleccionados", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRpt4_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosviajes.Rows.Count > 0)
                {
                    ReportesBoletosViajeHecotours ViajeAux = this.obtenerDatosViaje();
                    Reportes_Negocio rpt_negocio = new Reportes_Negocio();
                    rpt_negocio.obtenerDatosReportesViaje(Comun.Conexion, ref ViajeAux, _Estadisticos);
                    frmReportes frmReportesVista = new frmReportes(12, ViajeAux);
                    frmReportesVista.Estadisticos = false;
                    frmReportesVista.ShowDialog();
                }
                else
                    MessageBox.Show("No hay reportes seleccionados", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion




    }
}
