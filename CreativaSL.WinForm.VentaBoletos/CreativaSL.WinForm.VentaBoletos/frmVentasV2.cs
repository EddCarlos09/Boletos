using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
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
    public partial class frmVentasV2 : MaterialForm
    {
        private MotivoCancelacionesTrasferencias _motivoCancelacionesTransferencias;
        public frmVentasV2()
        {
            InitializeComponent();
            loadMaterial(this);
        }
        private void frmVentasV2_Load(object sender, EventArgs e)
        {
            if (Comun.Id_Tu == 1 || Comun.Id_Tu == 3)
            {
                this.btnCancelarA.Enabled = true;
                this.btnCancelarB.Enabled = true;
            }
            else
            {
                this.btnCancelarA.Enabled = false;
                this.btnCancelarB.Enabled = false;
            }
        }

        #region Métodos

        private Busqueda obtenerDatos()
        {
            try
            {
                Busqueda datos = new Busqueda(Comun.Conexion);
                datos.fecha_boleto = dtpFecha.Value;
                datos.folio_boleto = this.txtFolioBoleto.Text;
                datos.nombre_cliente = this.txtNombreCliente.Text;
                datos.folio_venta = this.txt_folioVenta.Text;
                datos.band_fecha = chkFecha.Checked;
                datos.band_folio = chkFolio.Checked;
                datos.band_nombre = chkNombre.Checked;
                datos.band_folioVenta = chkFolioVenta.Checked;
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarGridBoletos(Busqueda datos)
        {
            try
            {
                this.dgvdatosboleto.AutoGenerateColumns = false;
                BindingSource binding = new BindingSource();
                binding.DataSource = datos.resultado;
                this.dgvdatosboleto.DataSource = binding;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Busqueda_Negocio bn = new Busqueda_Negocio();
                Busqueda datos = new Busqueda(Comun.Conexion);
                datos = bn.BuscarBoletos(this.obtenerDatos());
                this.llenarGridBoletos(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtNombreCliente.ReadOnly = !this.txtNombreCliente.ReadOnly;
                if (chkNombre.Checked)
                {
                    this.txtNombreCliente.Focus();
                    this.txtNombreCliente.SelectAll();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void chkFolio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtFolioBoleto.ReadOnly = !this.txtFolioBoleto.ReadOnly;
                if (chkFolio.Checked)
                {
                    this.txtFolioBoleto.Focus();
                    this.txtFolioBoleto.SelectAll();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.dtpFecha.Enabled = !this.dtpFecha.Enabled;
                if (chkFecha.Checked)
                {
                    this.dtpFecha.Focus();
                }
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

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
                    boleto.bloqueoCancelacionMonedero = Convert.ToInt32(dgvdatosboleto.SelectedRows[0].Cells["bloqueoCancelacionMonedero"].Value.ToString());
                    boleto.bloqueoCancelacionPorFormaDePago = Convert.ToInt32(dgvdatosboleto.SelectedRows[0].Cells["bloqueoCancelacionPorFormaDePago"].Value.ToString());
                    boleto.fechaNacimientoV = Convert.ToDateTime(dgvdatosboleto.SelectedRows[0].Cells["fechaNacimiento"].Value.ToString());
                    boleto.numeroTelefono = dgvdatosboleto.SelectedRows[0].Cells["numeroTelefono"].Value.ToString();
                }
                return boleto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnCancelarA_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosboleto.SelectedRows.Count > 0)
                {
                    Boleto boleto = this.obtenerDatosBoleto();
                    boleto.tipo_cancelacion = 1;
                    if (boleto.bloqueoCancelacionMonedero == 0)
                    {
                        if (boleto.bloqueoCancelacionPorFormaDePago == 0)
                        {

                            frmLoginValidator frmlv = new frmLoginValidator();
                            frmlv.ShowDialog();
                            if (frmlv.getbanAutorizacion() == true)
                            {
                                frmCancelacionesTransferenciasV2 cancelaciones = new frmCancelacionesTransferenciasV2(1, boleto.tipo_cancelacion, boleto);
                                cancelaciones.ShowDialog();
                                if (cancelaciones.CancelacionTrasfencia == true)
                                {
                                    _motivoCancelacionesTransferencias = cancelaciones.motivoCancelacionesTransferencias;
                                    Cancelacion_Negocio cn = new Cancelacion_Negocio();
                                    cn.CancelacionBoleto(boleto, _motivoCancelacionesTransferencias);
                                    MessageBox.Show("El boleto ha sido cancelado.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                btnBuscar_Click(null, null);
                            }
                        }
                        else
                            MessageBox.Show("El boleto no puede ser cancelado porque la venta fue realizada con multiples formas de pago ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("El boleto no puede ser cancelado porque fue pagado con monedero.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelarB_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosboleto.SelectedRows.Count > 0)
                {
                    Boleto boleto = this.obtenerDatosBoleto();
                    boleto.tipo_cancelacion = 2;
                    if (boleto.bloqueoCancelacionMonedero == 0)
                    {
                        if (boleto.bloqueoCancelacionPorFormaDePago == 0)
                        {
                            frmLoginValidator frmlv = new frmLoginValidator();
                            frmlv.ShowDialog();
                            if (frmlv.getbanAutorizacion() == true)
                            {
                                frmCancelacionesTransferenciasV2 cancelaciones = new frmCancelacionesTransferenciasV2(1, boleto.tipo_cancelacion, boleto);
                                cancelaciones.ShowDialog();
                                if (cancelaciones.CancelacionTrasfencia == true)
                                {
                                    _motivoCancelacionesTransferencias = cancelaciones.motivoCancelacionesTransferencias;
                                    Cancelacion_Negocio cn = new Cancelacion_Negocio();
                                    cn.CancelacionBoleto(boleto, _motivoCancelacionesTransferencias);
                                    MessageBox.Show("El boleto ha sido cancelado.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                btnBuscar_Click(null, null);

                            }
                        }
                        else
                            MessageBox.Show("El boleto no puede ser cancelado porque la venta fue realizada con multiples formas de pago ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosboleto.SelectedRows.Count > 0)
                {
                    Boleto boleto = new Boleto(Comun.Conexion);
                    Ticket_Negocio tn = new Ticket_Negocio();
                    boleto = this.obtenerDatosBoleto();
                    tn.obtenerDatosBoleto(boleto);

                    ImprimirTicket imptk = new ImprimirTicket();
                    imptk.imprimirboleto(boleto, 1);

                    imptk = new ImprimirTicket();
                    imptk.imprimirboleto(boleto, 1);
                }
                else
                {
                    MessageBox.Show("Seleccione una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvdatosboleto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvdatosboleto.SelectedRows.Count > 0)
                {
                    if (Convert.ToDateTime(this.dgvdatosboleto.SelectedRows[0].Cells["fecha_salidaV"].Value.ToString()).AddHours(23).AddMinutes(59) < DateTime.Now)
                    {
                        this.btnCancelarA.Visible = false;
                        this.btnCancelarB.Visible = false;
                    }
                    else
                    {
                        this.btnCancelarA.Visible = true;
                        this.btnCancelarB.Visible = true;
                    }
                }
                else
                {
                    this.btnCancelarA.Visible = true;
                    this.btnCancelarB.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_CambiarNombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosboleto.SelectedRows.Count > 0)
                {
                    Boleto boleto = this.obtenerDatosBoleto();
                    frmNombreBoletoV2 frmNombreBoleto = new frmNombreBoletoV2(boleto);
                    frmNombreBoleto.ShowDialog();
                    frmNombreBoleto.Dispose();
                    Busqueda_Negocio bn = new Busqueda_Negocio();
                    Busqueda datos = new Busqueda(Comun.Conexion);
                    datos = bn.BuscarBoletos(this.obtenerDatos());
                    this.llenarGridBoletos(datos);
                }
                else
                {
                    MessageBox.Show("Seleccione una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpFecha_ValueChanged_1(object sender, EventArgs e)
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

        private void Facturarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosboleto.SelectedRows.Count > 0)
                {
                    Boleto boleto = this.obtenerDatosBoleto();
                    frmFacturaV1 frmFactura = new frmFacturaV1(boleto);
                    frmFactura.ShowDialog();
                    frmFactura.Dispose();
                    Busqueda_Negocio bn = new Busqueda_Negocio();
                    Busqueda datos = new Busqueda(Comun.Conexion);
                    datos = bn.BuscarBoletos(this.obtenerDatos());
                    this.llenarGridBoletos(datos);
                }
                else
                {
                    MessageBox.Show("Seleccione una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
