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
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using MaterialSkin;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmBusquedaCambioV2 : MaterialForm
    {

        private MotivoCancelacionesTrasferencias _motivoCancelacionesTransferencias;
        public MotivoCancelacionesTrasferencias motivoCancelacionesTransferencias
        {
            get { return _motivoCancelacionesTransferencias; }
            set { _motivoCancelacionesTransferencias = value; }
        }
        private bool _banCambio = false;
        private float _Precio = 0F;
        private string _IDBoleto = "";
        private int _bloqueoTransferencia24Hrs = 0;
        public float getPrecio()
        {
            return _Precio;
        }
        public string getIDBoleto()
        {
            return _IDBoleto;
        }
        public bool getBanCambio()
        {
            return _banCambio;
        }
        public int getBloqueoTransferencia24Hrs()
        {
            return _bloqueoTransferencia24Hrs;
        }
        public frmBusquedaCambioV2()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Blue700, TextShade.WHITE);

            this.label3.ForeColor = Color.Navy; // Cambiar el color del texto
            this.label3.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            this.label4.ForeColor = Color.Navy; // Cambiar el color del texto
            this.label4.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            this.label5.ForeColor = Color.Navy; // Cambiar el color del texto
            this.label5.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            this.label2.ForeColor = Color.DimGray; // Cambiar el color del texto
            this.label1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            this.label1.ForeColor = Color.DimGray; // Cambiar el color del texto
            this.label2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            this.label6.ForeColor = Color.DimGray; // Cambiar el color del texto
            this.label6.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        }

        #region EventosV2
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
                    Boleto boleto = this.obtenerDatosBoleto();
                    boleto.tipo_cancelacion = 2;
                    frmCancelacionesTransferencias cancelaciones = new frmCancelacionesTransferencias(2, boleto.tipo_cancelacion, boleto);
                    cancelaciones.ShowDialog();
                    if (cancelaciones.CancelacionTrasfencia == true)
                    {
                        _motivoCancelacionesTransferencias = cancelaciones.motivoCancelacionesTransferencias;
                        _IDBoleto = boleto.id_boleto;
                        _bloqueoTransferencia24Hrs = boleto.bloqueoTransferencia24Horas;
                        _Precio = boleto.precioIva;
                        this._banCambio = true;
                        this.Close();
                    }
                    else
                    {
                        this._banCambio = false;
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("No hay boletos seleccionados", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Boleto obtenerDatosBoleto()
        {
            try
            {
                Boleto boleto = new Boleto(Comun.Conexion);
                if (this.dgvdatosboleto.SelectedRows.Count > 0)
                {
                    boleto.id_ventadetalle = dgvdatosboleto.SelectedRows[0].Cells["id_ventadetalle"].Value.ToString();
                    boleto.id_boleto = dgvdatosboleto.SelectedRows[0].Cells["id_boleto"].Value.ToString();
                    boleto.folio = dgvdatosboleto.SelectedRows[0].Cells["CodigoBarra"].Value.ToString();
                    boleto.lineaMarca = dgvdatosboleto.SelectedRows[0].Cells["Viaje"].Value.ToString();
                    boleto.origen = dgvdatosboleto.SelectedRows[0].Cells["Origen"].Value.ToString();
                    boleto.destino = dgvdatosboleto.SelectedRows[0].Cells["Destino"].Value.ToString();
                    boleto.fechaSalida = Convert.ToDateTime(dgvdatosboleto.SelectedRows[0].Cells["fecha_salidaV"].Value.ToString());
                    boleto.horaSalida = dgvdatosboleto.SelectedRows[0].Cells["hora_salidaV"].Value.ToString();
                    boleto.cliente_nombre = dgvdatosboleto.SelectedRows[0].Cells["NombrePersona"].Value.ToString();
                    boleto.precioIva = Convert.ToSingle(dgvdatosboleto.SelectedRows[0].Cells["boletocosto"].Value.ToString());
                    boleto.asiento = Convert.ToInt32(dgvdatosboleto.SelectedRows[0].Cells["asiento"].Value.ToString());
                    boleto.id_status = 0;
                    boleto.bloqueoTransferencia24Horas = Convert.ToInt32(dgvdatosboleto.SelectedRows[0].Cells["bloqueoTransferencia24Horas"].Value.ToString());
                }
                return boleto;
            }
            catch (Exception ex)
            {
                throw ex;
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
