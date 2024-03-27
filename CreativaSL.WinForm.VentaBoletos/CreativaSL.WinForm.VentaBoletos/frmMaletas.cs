using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmMaletas : Form
    {
        private Maletas _Maletas = new Maletas();

        public frmMaletas()
        {
            try
            {
                InitializeComponent();
                this.Inicializar();
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
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Eventos
        private void btnSalir_Click(object sender, System.EventArgs e)
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
        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            try
            {
                BusquedaCambio_Negocio busqueda_negocio = new BusquedaCambio_Negocio();
                Busqueda datos = new Busqueda(Comun.Conexion);
                datos = busqueda_negocio.BuscarBoletos(Comun.Conexion, this.obtenerDatos());
                this.llenarGridBoletos(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkFecha_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkFolio_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkNombre_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosboleto.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGvdatosboleto())
                    {
                        this._Maletas.id_boleto = dgvdatosboleto.SelectedRows[0].Cells["id_boleto"].Value.ToString();
                        this._Maletas.folioBoleto = dgvdatosboleto.SelectedRows[0].Cells["CodigoBarra"].Value.ToString();
                        this._Maletas.lineaMarca = dgvdatosboleto.SelectedRows[0].Cells["viaje"].Value.ToString();
                        this._Maletas.origen = dgvdatosboleto.SelectedRows[0].Cells["Origen"].Value.ToString();
                        this._Maletas.destino = dgvdatosboleto.SelectedRows[0].Cells["Destino"].Value.ToString();
                        this._Maletas.fechaSalida = Convert.ToDateTime(dgvdatosboleto.SelectedRows[0].Cells["fecha_salidaV"].Value.ToString());
                        this._Maletas.horaSalida = dgvdatosboleto.SelectedRows[0].Cells["hora_salidaV"].Value.ToString();
                        this._Maletas.cliente = dgvdatosboleto.SelectedRows[0].Cells["NombrePersona"].Value.ToString();
                        this._Maletas.precioIva = Convert.ToSingle(dgvdatosboleto.SelectedRows[0].Cells["boletocosto"].Value.ToString());
                        this._Maletas.asiento = Convert.ToInt32(dgvdatosboleto.SelectedRows[0].Cells["asiento"].Value.ToString());
                    }
                    frmCatMaletas frmcm = new frmCatMaletas(_Maletas);
                    frmcm.ShowDialog();
                    frmcm.Dispose();
                }
                else
                    MessageBox.Show("No hay boletos seleccionados", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToDateTime(dtpFecha.Value.ToShortDateString()) > Convert.ToDateTime(DateTime.Now.AddDays(30).ToShortDateString()))
                {
                    MessageBox.Show("No puedes buscar a una fecha mayor a " + DateTime.Now.AddDays(30).ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFecha.Value = DateTime.Now;
                }
                if (Convert.ToDateTime(dtpFecha.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    MessageBox.Show("No puedes buscar a una fecha menor a " + DateTime.Now.ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFecha.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos Generales
        private void llenarGridBoletos(Busqueda datos)
        {
            try
            {
                this.dgvdatosboleto.AutoGenerateColumns = false;
                this.dgvdatosboleto.DataSource = datos.resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Busqueda obtenerDatos()
        {
            try
            {
                Busqueda datos = new Busqueda(Comun.Conexion);
                datos.fecha_boleto = dtpFecha.Value;
                datos.folio_boleto = this.txtFolioVenta.Text;
                datos.nombre_cliente = this.txtNombreCliente.Text;
                datos.band_fecha = chkFecha.Checked;
                datos.band_folio = chkFolio.Checked;
                datos.band_nombre = chkNombre.Checked;
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region GridBoletos
        private List<DataGridViewRow> ObtenerFilaSeleccionadaGvdatosboleto()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dgvdatosboleto.Rows)
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
    }
}
