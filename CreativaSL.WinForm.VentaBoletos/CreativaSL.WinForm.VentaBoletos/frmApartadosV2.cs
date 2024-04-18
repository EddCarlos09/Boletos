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
    public partial class frmApartadosV2 : MaterialForm
    {
        private MotivoCancelacionesTrasferencias _motivoCancelacionesTransferencias;
        public frmApartadosV2()
        {
            InitializeComponent();
            loadMaterial(this);
        }

        private void frmApartadosV2_Load(object sender, EventArgs e)
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
                Apartados_Negocio apartados_negocio = new Apartados_Negocio();
                Busqueda datos = new Busqueda(Comun.Conexion);
                datos = apartados_negocio.BuscarBoletos(Comun.Conexion, this.obtenerDatos());
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
        private void btnPagoEfectivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosboleto.SelectedRows.Count > 0)
                {
                    Apartados apartados = new Apartados();
                    int Verificador = 0;
                    apartados.Total = 0F;
                    apartados.TotalPagar = 0F;
                    apartados.Pendiente = 0F;
                    apartados.IDBoleto = "";
                    apartados.IDVenta = "";
                    apartados.IDVentaDetalle = "";
                    apartados.IDVendedor = "";
                    apartados.Observacion = "";
                    apartados.IDCaja = "";
                    apartados.IDSucursal = "";
                    apartados.IDTipoPago = 0;



                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGvdatosboleto())
                    {
                        apartados.IDBoleto = row.Cells["id_boleto"].Value.ToString();
                        apartados.IDVenta = row.Cells["id_venta"].Value.ToString();
                        apartados.IDVentaDetalle = row.Cells["id_ventadetalle"].Value.ToString();
                        apartados.Total = Convert.ToSingle(row.Cells["pendiente"].Value.ToString());
                        apartados.TotalPagar = Convert.ToSingle(row.Cells["pendiente"].Value.ToString());
                        apartados.IDTipoPago = 1;
                        apartados.IDVendedor = Comun.Id_U;
                        apartados.Observacion = "Pago Efectivo";
                        apartados.IDCaja = Comun.id_caja;
                        apartados.IDSucursal = Comun.id_sucursal;
                    }

                    V2Cliente cliente = new V2Cliente();
                    Cliente_Negocio cliente_Negocio = new Cliente_Negocio();
                    cliente_Negocio.ObtenerClienteXIdBoleto(Comun.Conexion, apartados.IDBoleto, cliente);

                    frmCatCobroMultiFormasPagoV2 frmC = new frmCatCobroMultiFormasPagoV2(apartados.Total, apartados.TotalPagar, apartados.Pendiente, (float)cliente.SaldoDisponible, cliente.Nombre, ((float)cliente.PorentajePuntos * (float)apartados.Total), cliente);
                    frmC.ShowDialog();
                    if (frmC.DialogResult == DialogResult.OK)
                    {
                        apartados.DatosTarjeta = new DataTable();
                        apartados.DatosTarjeta.Columns.Add("autorizacion", typeof(string));
                        apartados.DatosTarjeta.Columns.Add("tipoDocumento", typeof(string));
                        apartados.DatosTarjeta.Columns.Add("folioDNI", typeof(string));
                        apartados.DatosTarjeta.Columns.Add("numTarjeta", typeof(string));
                        apartados.DatosTarjeta.Columns.Add("id_banco", typeof(int));
                        apartados.DatosTarjeta.Columns.Add("monto", typeof(float));
                        apartados.pagoEfectivo = frmC.getPagoEfectivo() - (frmC.getCambio() * -1);
                        apartados.pagoMonedero = frmC.getPagoMonedero();
                        apartados.pagoTarjeta = frmC.getPagoTarjeta();
                        apartados.pagoTransferencia = frmC.getPagoTransferencia();
                        if (apartados.pagoTarjeta > 0)
                        {
                            if (frmC.getDatosTarjeta() != null)
                            {
                                FormaPago DatosPagoTarjeta = frmC.getDatosTarjeta();
                                apartados.DatosTarjeta.Rows.Add(
                                    new Object[] {
                                        DatosPagoTarjeta.autorizacion,
                                        DatosPagoTarjeta.tipoDocumento != null ? DatosPagoTarjeta.tipoDocumento.id_tipoDocumento : string.Empty,
                                        DatosPagoTarjeta.folioIFE,
                                        DatosPagoTarjeta.numtarjeta,
                                        DatosPagoTarjeta.banco != null ? DatosPagoTarjeta.banco.idBanco : 0,
                                        DatosPagoTarjeta.monto});
                            }
                        }

                        apartados.DatosTransferencia = new DataTable();
                        apartados.DatosTransferencia.Columns.Add("autorizacion", typeof(string));
                        apartados.DatosTransferencia.Columns.Add("id_banco", typeof(int));
                        apartados.DatosTransferencia.Columns.Add("monto", typeof(float));

                        if (apartados.pagoTransferencia > 0)
                        {
                            if (frmC.getDatosTransferencia() != null)
                            {
                                FormaPago DatosPagoTransferencia = frmC.getDatosTransferencia();
                                apartados.DatosTransferencia.Rows.Add(
                                    new Object[] {
                                        DatosPagoTransferencia.autorizacion,
                                        DatosPagoTransferencia.banco != null ? DatosPagoTransferencia.banco.idBanco : 0,
                                        DatosPagoTransferencia.monto});
                            }
                        }

                        Apartados_Negocio apartados_negocio = new Apartados_Negocio();
                        apartados_negocio.PagarBoleto(Comun.Conexion, ref apartados, ref Verificador);
                        if (Verificador == 1)
                        {
                            Boleto boleto = new Boleto(Comun.Conexion);
                            Ticket_Negocio tn = new Ticket_Negocio();
                            boleto = this.obtenerDatosBoleto();
                            tn.obtenerDatosBoleto(boleto);

                            ImprimirTicket imptk = new ImprimirTicket();
                            imptk.imprimirboleto(boleto, 1);

                            imptk = new ImprimirTicket();
                            imptk.imprimirboleto(boleto, 1);

                            Busqueda datos = new Busqueda(Comun.Conexion);
                            datos = apartados_negocio.BuscarBoletos(Comun.Conexion, this.obtenerDatos());
                            this.llenarGridBoletos(datos);
                            MessageBox.Show("Venta de boleto efectuada correctamentamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error con el pago del boletos, esto se puede debe a que el servidor esta Ocupado. INTENTA VENDER DE NUEVO!!!.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        frmC.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPagoOnline_Click(object sender, EventArgs e)
        {
            try
            {
                Apartados apartados = new Apartados();
                int Verificador = 0;
                apartados.Total = 0F;
                apartados.TotalPagar = 0F;
                apartados.Pendiente = 0F;
                apartados.IDBoleto = "";
                apartados.IDVenta = "";
                apartados.IDVentaDetalle = "";
                apartados.IDVendedor = "";
                apartados.Observacion = "";
                apartados.IDCaja = "";
                apartados.IDSucursal = "";
                apartados.IDTipoPago = 0;

                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGvdatosboleto())
                {
                    apartados.IDBoleto = row.Cells["id_boleto"].Value.ToString();
                    apartados.IDVenta = row.Cells["id_venta"].Value.ToString();
                    apartados.IDVentaDetalle = row.Cells["id_ventadetalle"].Value.ToString();
                    apartados.Total = Convert.ToSingle(row.Cells["pendiente"].Value.ToString());
                    apartados.TotalPagar = Convert.ToSingle(row.Cells["pendiente"].Value.ToString());
                    apartados.IDTipoPago = 2;
                    apartados.IDVendedor = Comun.Id_U;
                    apartados.Observacion = "Pago Online";
                    apartados.IDCaja = Comun.id_caja;
                    apartados.IDSucursal = Comun.id_sucursal;
                }
                frmCatCobroV2 frmC = new frmCatCobroV2(apartados.Total, apartados.TotalPagar, apartados.Pendiente, 0.0F, "", 0.0F);
                frmC.ShowDialog();
                if (frmC.getbanSalir() == false)
                {
                    Apartados_Negocio apartados_negocio = new Apartados_Negocio();
                    apartados_negocio.PagarBoleto(Comun.Conexion, ref apartados, ref Verificador);
                    if (Verificador == 1)
                    {
                        Boleto boleto = new Boleto(Comun.Conexion);
                        ImprimirTicket imptk = new ImprimirTicket();
                        boleto.id_boleto = apartados.IDBoleto;
                        imptk.imprimirboleto(boleto, 1);

                        boleto = new Boleto(Comun.Conexion);
                        imptk = new ImprimirTicket();
                        boleto.id_boleto = apartados.IDBoleto;
                        imptk.imprimirboleto(boleto, 1);


                        Busqueda datos = new Busqueda(Comun.Conexion);
                        datos = apartados_negocio.BuscarBoletos(Comun.Conexion, this.obtenerDatos());
                        this.llenarGridBoletos(datos);
                        MessageBox.Show("Venta de boleto efectuada correctamentamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error con el pago del boletos, esto se puede debe a que el servidor esta Ocupado. INTENTA VENDER DE NUEVO!!!.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    frmC.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelarA_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvdatosboleto.SelectedRows.Count > 0)
                {
                    Boleto boleto = this.obtenerDatosBoleto();
                    if (boleto.pago == 0.0F)
                        boleto.tipo_cancelacion = 2;
                    else
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
                    boleto.pago = Convert.ToSingle(dgvdatosboleto.SelectedRows[0].Cells["pago"].Value.ToString());
                    boleto.bloqueoCancelacionPorFormaDePago = Convert.ToInt32(dgvdatosboleto.SelectedRows[0].Cells["bloqueoCancelacionPorFormaDePago"].Value.ToString());
                }
                return boleto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
