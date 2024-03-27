using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Reportes_Datos
    {
        public List<Caja> ConsultarCajasXFechaxSucursal(string conexion, DateTime fecha, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if(Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerCajasxFecha", fecha);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerCajasxFecha_Estadisticos", fecha);
                Caja caja;
                List<Caja> lista = new List<Caja>();                
                while (dr.Read())
                {
                    caja = new Caja(conexion);
                    if (!dr.IsDBNull(dr.GetOrdinal("id_cajaXSucursal")))
                        caja.id_caja = dr["id_cajaXSucursal"].ToString();
                    else
                        caja.id_caja = "";
                    if (!dr.IsDBNull(dr.GetOrdinal("U_Nombre")) && !dr.IsDBNull(dr.GetOrdinal("U_Apellidop")) && !dr.IsDBNull(dr.GetOrdinal("hora_inicio")))
                        caja.observaciones = dr["U_Nombre"].ToString() + " " + dr["U_Apellidop"].ToString() + " - " + dr["hora_inicio"].ToString();
                    else
                        caja.observaciones = "";
                    lista.Add(caja);                    
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
        public List<Depositos_Retiros> ConsultarRetDepXIDCajaXSucursal(string conexion, int opcion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerDepRetxIDCajaSucursal", opcion, id_cajaxsucursal, fecha);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerDepRetxIDCajaSucursal_Estadisticos", opcion, id_cajaxsucursal, fecha);
                Depositos_Retiros retiro;
                List<Depositos_Retiros> listaretiros = new List<Depositos_Retiros>();
                while (dr.Read())
                {
                    retiro = new Depositos_Retiros();
                    if (!dr.IsDBNull(dr.GetOrdinal("id_movimiento")))
                        retiro.id_movimiento = dr["id_movimiento"].ToString();
                    else
                        retiro.id_movimiento = string.Empty;

                    if (!dr.IsDBNull(dr.GetOrdinal("motivo")))
                        retiro.descripcion = dr["motivo"].ToString();
                    else
                        retiro.descripcion = string.Empty;
                    float monto = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("monto")).ToString()), out monto);
                    retiro.monto = monto;
                    if (!dr.IsDBNull(dr.GetOrdinal("motivo")))
                        retiro.vendedor = dr["vendedor"].ToString();
                    else
                        retiro.vendedor = string.Empty;
                    listaretiros.Add(retiro);
                }
                return listaretiros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarVentasXIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerVentasxIDCajaMod", id_cajaxsucursal, fecha);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerVentasxIDCajaMod_Estadisticos", id_cajaxsucursal, fecha);

                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();

                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2; 
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;

                    // **********  Para cambios del reporte 2017/10/20 ****************

                    if (!dr.IsDBNull(dr.GetOrdinal("FormaPago")))
                        venta.FormaPago = dr["FormaPago"].ToString();
                    else
                        venta.FormaPago = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("Transaccion")))
                        venta.DatosPago = dr["Transaccion"].ToString();
                    else
                        venta.DatosPago = string.Empty;

                    // **********  ****************  ***************** ****************

                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarReservacionesXIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerReservacionesxIDCaja", id_cajaxsucursal, fecha);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerReservacionesxIDCaja_Estadisticos", id_cajaxsucursal, fecha);

                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();

                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;
                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarAnticipo1XIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerAnticipo1xIDCajaMod", id_cajaxsucursal, fecha);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerAnticipo1xIDCajaMod_Estadisticos", id_cajaxsucursal, fecha);

                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();

                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;

                    // **********  Para cambios del reporte 2017/10/20 ****************

                    if (!dr.IsDBNull(dr.GetOrdinal("FormaPago")))
                        venta.FormaPago = dr["FormaPago"].ToString();
                    else
                        venta.FormaPago = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("Transaccion")))
                        venta.DatosPago = dr["Transaccion"].ToString();
                    else
                        venta.DatosPago = string.Empty;

                    // **********  ****************  ***************** ****************


                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<ReportesVentasCaja> ConsultarAnticipo2XIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerAnticipo2xIDCajaMod", id_cajaxsucursal, fecha);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerAnticipo2xIDCajaMod_Estadisticos", id_cajaxsucursal, fecha);

                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();

                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;

                    // **********  Para cambios del reporte 2017/10/20 ****************

                    if (!dr.IsDBNull(dr.GetOrdinal("FormaPago")))
                        venta.FormaPago = dr["FormaPago"].ToString();
                    else
                        venta.FormaPago = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("Transaccion")))
                        venta.DatosPago = dr["Transaccion"].ToString();
                    else
                        venta.DatosPago = string.Empty;

                    // **********  ****************  ***************** ****************



                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarTransferenciaXIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerTransferenciaxIDCajaMod", id_cajaxsucursal, fecha);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerTransferenciaxIDCajaMod_Estadisticos", id_cajaxsucursal, fecha);

                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();

                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarraTransferencia")))
                        venta.codigoTransferencia = dr["CodigoBarraTransferencia"].ToString();
                    else
                        venta.codigoTransferencia = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;

                    // **********  Para cambios del reporte 2017/10/20 ****************

                    if (!dr.IsDBNull(dr.GetOrdinal("FormaPago")))
                        venta.FormaPago = dr["FormaPago"].ToString();
                    else
                        venta.FormaPago = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("Transaccion")))
                        venta.DatosPago = dr["Transaccion"].ToString();
                    else
                        venta.DatosPago = string.Empty;

                    // **********  ****************  ***************** ****************

                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarCancelacionesXIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerCancelacionesxIDCaja", id_cajaxsucursal, fecha);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerCancelacionesxIDCaja_Estadisticos", id_cajaxsucursal, fecha);
                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();
                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    float cancelacion;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("cancelacion")).ToString()), out cancelacion);
                    venta.cancelacion = cancelacion;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;
                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Maletas> ConsultarMaletasXIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerMaletasxIDCaja", id_cajaxsucursal, fecha);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerMaletasxIDCaja_Estadisticos", id_cajaxsucursal, fecha);

                Maletas maletas;
                List<Maletas> listamaletas = new List<Maletas>();
                while (dr.Read())
                {
                    maletas = new Maletas();
                    if (!dr.IsDBNull(dr.GetOrdinal("id_maleta")))
                        maletas.idMaleta = dr["id_maleta"].ToString();
                    else
                        maletas.idMaleta = string.Empty;

                    if (!dr.IsDBNull(dr.GetOrdinal("id_boleto")))
                        maletas.id_boleto = dr["id_boleto"].ToString();
                    else
                        maletas.id_boleto = string.Empty;

                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        maletas.cliente = dr["NombrePersona"].ToString();
                    else
                        maletas.cliente = string.Empty;

                    if (!dr.IsDBNull(dr.GetOrdinal("folioMaleta")))
                        maletas.folioMaleta = dr["folioMaleta"].ToString();
                    else
                        maletas.folioMaleta = string.Empty;

                    if (!dr.IsDBNull(dr.GetOrdinal("descripcion")))
                        maletas.descripcion = dr["descripcion"].ToString();
                    else
                        maletas.descripcion = string.Empty;

                    /*
                    float KG = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("kg")).ToString()), out KG);
                    maletas.kg = KG;
                    */
                    int numero = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("numeroMaletas")).ToString()), out numero);
                    maletas.numeroMaletas = numero;


                    float precio = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("precio")).ToString()), out precio);
                    maletas.precioMaleta = precio;

                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        maletas.vendedor = dr["vendedor"].ToString();
                    else
                        maletas.vendedor = string.Empty;

                    listamaletas.Add(maletas);
                }
                return listamaletas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultaReporteInformeClienteComprador(string Conexion, ref List<ReportesClienteComprador> lstClienteComprador, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { DateTime.Today.Year, Comun.id_sucursal };
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(Conexion, "Obtener_Reporte_Clientes_Mas_Gasto", Valores);
                else
                    dr = SqlHelper.ExecuteReader(Conexion, "Obtener_Reporte_Clientes_Mas_Gasto_Estadisticos", Valores);
                ReportesClienteComprador ClienteComprador;
                while (dr.Read())
                {
                    ClienteComprador = new ReportesClienteComprador();
                    if (!dr.IsDBNull(dr.GetOrdinal("cliente")))
                        ClienteComprador.Nombre = dr["cliente"].ToString();
                    else
                        ClienteComprador.Nombre = "";
                    if (!dr.IsDBNull(dr.GetOrdinal("total")))
                        ClienteComprador.TotalComprado = Convert.ToSingle(dr["total"].ToString());
                    else
                        ClienteComprador.TotalComprado = 0;
                    lstClienteComprador.Add(ClienteComprador);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede obtener la información" + ex.Message);
            }
        }
        public void ConsultaReporteInformeClienteFrecuente(string Conexion, ref List<ReportesClienteFrecuente> lstClienteFrecuente, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { DateTime.Today.Year, Comun.id_sucursal };
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(Conexion, "Obtener_Reporte_Clientes_Mas_Llego", Valores);
                else
                    dr = SqlHelper.ExecuteReader(Conexion, "Obtener_Reporte_Clientes_Mas_Llego_Estadisticos", Valores);

                ReportesClienteFrecuente ClienteFrecuente;
                while (dr.Read())
                {
                    ClienteFrecuente = new ReportesClienteFrecuente();
                    if (!dr.IsDBNull(dr.GetOrdinal("cliente")))
                        ClienteFrecuente.Nombre = dr["cliente"].ToString();
                    else
                        ClienteFrecuente.Nombre = "";
                    if (!dr.IsDBNull(dr.GetOrdinal("veces")))
                        ClienteFrecuente.NVeces = Convert.ToInt32(dr["veces"].ToString());
                    else
                        ClienteFrecuente.NVeces = 0;
                    lstClienteFrecuente.Add(ClienteFrecuente);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede obtener la información" + ex.Message);
            }
        }
        public List<Viaje> ConsultarViajesXFecha(string Conexion, DateTime fecha)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { fecha };
                dr = SqlHelper.ExecuteReader(Conexion, "VistaCamionesT1-2_Combo_sp", Valores);
                Viaje Viaje;
                List<Viaje> lstViajes = new List<Viaje>();
                while (dr.Read())
                {
                    Viaje = new Viaje(Comun.Conexion);
                    Viaje.IDViaje = dr["IDViajeViejo"].ToString();
                    Viaje.NombreViaje = dr["NombreViaje"].ToString();
                    Viaje.FechaV = Convert.ToDateTime(dr["FechaV"].ToString());
                    Viaje.HoraV = dr["HoraV"].ToString();
                    lstViajes.Add(Viaje);
                }
                return lstViajes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Corrida> ConsultarCorridasViaje(string Conexion, Viaje cmbViaje)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { cmbViaje.IDViaje, cmbViaje.FechaV, cmbViaje.HoraV };
                dr = SqlHelper.ExecuteReader(Conexion, "VistaCorridasT1-2_Combo_sp", Valores);
                Corrida Corrida;
                List<Corrida> lstCorrida = new List<Corrida>();
                while (dr.Read())
                {
                    Corrida = new Corrida();
                    Corrida.IDCorrida = dr["IDCorrida"].ToString();
                    Corrida.OrdenOrigen = Convert.ToInt32(dr["OrdenOrigen"].ToString());
                    Corrida.OrdenDestino = Convert.ToInt32(dr["OrdenDestino"].ToString());
                    Corrida.NombreCorrida = dr["Corrida"].ToString();
                    lstCorrida.Add(Corrida);
                }
                return lstCorrida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultarReporteBoletosViaje(string Conexion, ref ReportesBoletosViaje reportesboletos, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { reportesboletos.IDViaje, reportesboletos.FechaV, reportesboletos.HoraV, Comun.id_sucursal };

                reportesboletos.lstBoletos = new List<Boleto>();
                dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(Conexion, "obtenerBoletosViaje", Valores);
                else
                    dr = SqlHelper.ExecuteReader(Conexion, "obtenerBoletosViaje_Estadisticos", Valores);

                Boleto boletos;
                while (dr.Read())
                {
                    boletos = new Boleto(Comun.Conexion);
                    boletos.folio = dr["folio"].ToString();
                    boletos.cliente_nombre = dr["cliente_nombre"].ToString();
                    boletos.asiento = Convert.ToInt32(dr["asiento"].ToString());
                    boletos.origen = dr["origen"].ToString();
                    boletos.destino = dr["destino"].ToString();
                    boletos.pago = Convert.ToSingle(dr["precio"].ToString());
                    boletos.tipo = dr["tipoVenta"].ToString();
                    if (boletos.cliente_nombre != "" && boletos.folio != "" && boletos.destino != "")
                        boletos.fechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"].ToString()).ToString("dd/MM/yyyy");
                    else
                        boletos.fechaNacimiento = "";
                    reportesboletos.lstBoletos.Add(boletos);
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultarReporteBoletosViaje2(string Conexion, ref ReportesBoletosViaje reportesboletos, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { reportesboletos.IDViaje, reportesboletos.FechaV, reportesboletos.HoraV, Comun.id_sucursal };

                reportesboletos.lstBoletos = new List<Boleto>();
                dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(Conexion, "obtenerBoletosViaje2", Valores);
                else
                    dr = SqlHelper.ExecuteReader(Conexion, "obtenerBoletosViaje_Estadisticos2", Valores);

                Boleto boletos;
                while (dr.Read())
                {
                    boletos = new Boleto(Comun.Conexion);
                    boletos.folio = dr["folio"].ToString();
                    boletos.cliente_nombre = dr["cliente_nombre"].ToString();
                    boletos.asiento = Convert.ToInt32(dr["asiento"].ToString());
                    boletos.origen = dr["origen"].ToString();
                    boletos.destino = dr["destino"].ToString();
                    boletos.pago = Convert.ToSingle(dr["precio"].ToString());
                    boletos.tipo = dr["tipoVenta"].ToString();
                    if (boletos.cliente_nombre != "" && boletos.folio != "" && boletos.destino != "")
                        boletos.fechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"].ToString()).ToString("dd/MM/yyyy");
                    else
                        boletos.fechaNacimiento = ""; 
                    reportesboletos.lstBoletos.Add(boletos);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RevisarDatos(string Conexion, ref int Verificador, ref ReportesBoletosViaje reportesboletos)
        {
            try
            {
                object[] Valores = { reportesboletos.IDViaje, reportesboletos.FechaV, reportesboletos.HoraV, reportesboletos.IDChofer, reportesboletos.observacion, Comun.Id_U , 0};
                object res = SqlHelper.ExecuteScalar(Conexion, "CatDatosViajes_Insertar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboChoferes(string Conexion, ref ReportesBoletosViajeHecotours reportesBoletosViaje)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(Comun.Conexion, "CatChoferes_Combo_sp");
                Chofer chofer;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        chofer = new Chofer();
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_chofer"))))
                            chofer.IDChofer = string.Empty;
                        else
                            chofer.IDChofer = SqlDr.GetString(SqlDr.GetOrdinal("id_chofer"));

                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("Descripcion"))))
                            chofer.Nombre = string.Empty;
                        else
                            chofer.Nombre = SqlDr.GetString(SqlDr.GetOrdinal("Descripcion"));
                        reportesBoletosViaje.lstChoferes1_prestacionServicios1.Add(chofer);
                        reportesBoletosViaje.lstChoferes1_prestacionServicios2.Add(chofer);
                        reportesBoletosViaje.lstChoferes2_prestacionServicios1.Add(chofer);
                        reportesBoletosViaje.lstChoferes2_prestacionServicios2.Add(chofer);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboViaje(string Conexion, ref ReportesBoletosViajeHecotours viaje, DateTime fechaSalida)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(Comun.Conexion, "VistaCamionesT1-2_Combo_sp_Rpt", fechaSalida);
                Viaje _viaje;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        _viaje = new Viaje(Conexion);
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("IDViajeNuevo"))))
                            _viaje.id_viaje = string.Empty;
                        else
                            _viaje.id_viaje = SqlDr.GetString(SqlDr.GetOrdinal("IDViajeNuevo"));

                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("NombreViaje"))))
                            _viaje.NombreViaje = string.Empty;
                        else
                            _viaje.NombreViaje = SqlDr.GetString(SqlDr.GetOrdinal("NombreViaje"));

                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("fechaOrigen"))))
                            _viaje.FechaV = DateTime.Now;
                        else
                            _viaje.FechaV = SqlDr.GetDateTime(SqlDr.GetOrdinal("fechaOrigen"));

                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("horaOrigen"))))
                            _viaje.HoraV = string.Empty;
                        else
                            _viaje.HoraV = SqlDr.GetString(SqlDr.GetOrdinal("horaOrigen"));
                        viaje.lista_Viaje.Add(_viaje);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void GuardarDatosViaje(string Conexion, ReportesBoletosViajeHecotours viaje, ref int Verificador)
        {
            try
            {
                object[] Valores = { 
                                        viaje.IDViaje,
                                        viaje.FechaV,
                                        viaje.HoraV,
                                        viaje.folio_prestacionServicios1,
                                        viaje.id_chofer1_prestacionServicios1,
                                        viaje.id_chofer2_prestacionServicios1,
                                        viaje.autobus_prestacionServicios1,
                                        viaje.fecha_salida_prestacionServicios1,
                                        viaje.hora_salida_prestacionServicios1,
                                        viaje.solicitado_por_prestacionServicios1,
                                        viaje.grupo_prestacionServicios1,
                                        viaje.servicio_prestacionServicios1,
                                        viaje.presentarse_en_prestacionServicios1,
                                        viaje.instrucciones_prestacionServicios1,
                                        viaje.observaciones_prestacionServicios1,
                                        viaje.folio_prestacionServicios2,
                                        viaje.solicitado_por_prestacionServicios2,
                                        viaje.poliza_prestacionServicios2,
                                        viaje.poliza_fecha1_prestacionServicios2,
                                        viaje.poliza_fecha2_prestacionServicios2,
                                        viaje.credencial_elector_prestacionServicios2,
                                        viaje.domicilio_prestacionServicios2,
                                        viaje.origen_prestacionServicios2,
                                        viaje.destino_prestacionServicios2,
                                        viaje.monto_servicio_prestacionServicios2,
                                        viaje.monto_servicio_texto_prestacionServicios2,
                                        viaje.lugar_salida_prestacionServicios2,
                                        viaje.fecha_salida_prestacionServicios2,
                                        viaje.hora_salida_prestacionServicios2,
                                        viaje.numero_personas_prestacionServicios2,
                                        viaje.id_chofer1_prestacionServicios2,
                                        viaje.id_chofer2_prestacionServicios2,
                                        viaje.numero_placa_prestacionServicios2,
                                        viaje.ruta_contratada_prestacionServicios2,
                                        viaje.dias_viaje_prestacionServicios2,
                                        viaje.dia_hora_salida_prestacionServicios2,
                                        viaje.folio_listapasajeros,
                                        viaje.oficina_listapasajeros,
                                        viaje.dia_listapasajeros,
                                        viaje.mes_listapasajeros,
                                        viaje.año_listapasajeros,
                                        viaje.carro_listapasajeros,
                                        viaje.oficinista_listapasajeros,
                                        viaje.hora_salida_listapasajeros,
                                        Comun.Id_U, 
                                        1 };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatDatosViajes_Insertar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultarReporteDatosReportes(string Conexion, ref ReportesDatosReportes reportesDatos)
        {
            SqlDataReader dr = null;
            dr = SqlHelper.ExecuteReader(Conexion, "obtenerDatosReportesDatos", Comun.id_sucursal);
            while (dr.Read())
            {
                reportesDatos.razonSocial = dr["razonSocial"].ToString();
                reportesDatos.direccion = dr["direccion"].ToString();
                reportesDatos.rfc = dr["rfc"].ToString();
                reportesDatos.path = dr["path"].ToString();
            }
        }
        public void ConsultaReporteInformeTotalesCajas(string conexion, ref List<Caja> lstCaja, DateTime fecha, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerTotalesCajasFecha", fecha);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerTotalesCajasFecha_Estadisticos", fecha);

                Caja caja;
                while (dr.Read())
                {
                    caja = new Caja(conexion);
                    if (!dr.IsDBNull(dr.GetOrdinal("caja")))
                        caja.cajaCat = dr["caja"].ToString();
                    else
                        caja.cajaCat = string.Empty;
                    float total = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("total")).ToString()), out total);
                    caja.Total = total;
                    lstCaja.Add(caja);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// reporte de Folios
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="lstFolio"></param>
        public void ConsultaReporteInformeFolios(string conexion, ref List<V2Tarjeta> lstFolio, int verTodo)
        {
            try
            {
                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(conexion, "Customer.ObtenerTotalTarjetas", verTodo);
                
                V2Tarjeta tarjeta;
                while (dr.Read())
                {
                    tarjeta = new V2Tarjeta();
                    tarjeta.Folio = dr["Folio"].ToString();
                    tarjeta.EstatusDes =  dr["Estatus"].ToString();
                    lstFolio.Add(tarjeta);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RevisarDatos2(string conexion, ref int Verificador, ref ReportesMaletasViaje reportesmaletas)
        {
            try
            {
                object[] Valores = { reportesmaletas.IDViaje, reportesmaletas.FechaV, reportesmaletas.HoraV, reportesmaletas.IDChofer, reportesmaletas.observacion, Comun.Id_U, 0 };
                object res = SqlHelper.ExecuteScalar(conexion, "CatDatosViajes_Insertar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultarReporteMaletasViaje(string conexion, ref ReportesMaletasViaje reportesmaletas, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { reportesmaletas.IDViaje, reportesmaletas.FechaV, reportesmaletas.HoraV, Comun.id_sucursal };
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerDatosBoletosViaje", Valores);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerDatosBoletosViaje_Estadisticos", Valores);

                while (dr.Read())
                {
                    reportesmaletas.folio = dr["folio"].ToString();
                    reportesmaletas.fechaReporte = Convert.ToDateTime(dr["fechaReporte"].ToString()).ToShortDateString();
                    reportesmaletas.chofer = dr["chofer"].ToString();
                    reportesmaletas.fechaSalida = Convert.ToDateTime(dr["fechaSalida"].ToString());
                    reportesmaletas.origen = dr["origen"].ToString();
                    reportesmaletas.destino = dr["destino"].ToString();
                    reportesmaletas.observacion = dr["observacion"].ToString();
                }

                reportesmaletas.lstMaletas = new List<Maletas>();
                dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerMaletasViaje", Valores);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerMaletasViaje_Estadisticos", Valores);

                Maletas maletas;
                while (dr.Read())
                {
                    maletas = new Maletas();
                    maletas.folioMaleta = dr["folioMaleta"].ToString();
                    maletas.cliente = dr["NombrePersona"].ToString();
                    maletas.descripcion = dr["descripcion"].ToString();
                    maletas.precioMaleta = Convert.ToSingle(dr["precio"].ToString());
                    maletas.numeroMaletas = Convert.ToInt32(dr["numeroMaletas"].ToString());
                    reportesmaletas.lstMaletas.Add(maletas);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void ConsultaReporteInformeDetalleBoletos(string conexion, ref List<Boleto> lstBoleto, string IDBoleto, bool Estadisticos)
        {
            try
            {
                SqlDataReader SqlDr = null;
                Boleto boleto = new Boleto(conexion);
                boleto.id_boleto = IDBoleto;
                if (Estadisticos == false)
                    SqlDr = SqlHelper.ExecuteReader(boleto.strcnx, "obtenerDatosBoletoDetalles", boleto.id_boleto);
                else
                    SqlDr = SqlHelper.ExecuteReader(boleto.strcnx, "obtenerDatosBoletoDetalles_Estadisticos", boleto.id_boleto);

                while (SqlDr.Read())
                {
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("folio"))))
                        boleto.folio = string.Empty;
                    else
                        boleto.folio = SqlDr.GetString(SqlDr.GetOrdinal("folio"));
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("nombreCliente"))))
                        boleto.cliente_nombre = string.Empty;
                    else
                        boleto.cliente_nombre = SqlDr.GetString(SqlDr.GetOrdinal("nombreCliente"));
                    boleto.asiento = SqlDr.GetInt32(SqlDr.GetOrdinal("asiento"));
                    boleto.fechaSalida = SqlDr.GetDateTime(SqlDr.GetOrdinal("fecha_salida"));
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("hora_salida"))))
                        boleto.horaSalida = string.Empty;
                    else
                        boleto.horaSalida = SqlDr.GetString(SqlDr.GetOrdinal("hora_salida"));

                    float aux = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("precioBoleto")).ToString(), out aux);
                    boleto.precioIva = aux;
                    aux = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("descuento")).ToString(), out aux);
                    boleto.descuento = aux;
                    aux = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("pago1")).ToString(), out aux);
                    boleto.pago1 = aux;
                    aux = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("pago2")).ToString(), out aux);
                    boleto.pago2 = aux;
                    aux = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("total")).ToString(), out aux);
                    boleto.total = aux;
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("terminalOrigen"))))
                        boleto.terminalSalida = string.Empty;
                    else
                        boleto.terminalSalida = SqlDr.GetString(SqlDr.GetOrdinal("terminalOrigen"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("terminalDestino"))))
                        boleto.terminalLlegada = string.Empty;
                    else
                        boleto.terminalLlegada = SqlDr.GetString(SqlDr.GetOrdinal("terminalDestino"));
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("marca"))))
                        boleto.lineaMarca = string.Empty;
                    else
                        boleto.lineaMarca = SqlDr.GetString(SqlDr.GetOrdinal("marca"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("numcamion"))))
                        boleto.corrida = string.Empty;
                    else
                        boleto.corrida = SqlDr.GetString(SqlDr.GetOrdinal("numcamion"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("estadoBoleto"))))
                        boleto.estadoBoleto = string.Empty;
                    else
                        boleto.estadoBoleto = SqlDr.GetString(SqlDr.GetOrdinal("estadoBoleto"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("VentaUsuario"))))
                        boleto.VentaUsuario = string.Empty;
                    else
                        boleto.VentaUsuario = SqlDr.GetString(SqlDr.GetOrdinal("VentaUsuario"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("VentaFechaHora"))))
                        boleto.VentaFechaHora = string.Empty;
                    else
                        boleto.VentaFechaHora = SqlDr.GetString(SqlDr.GetOrdinal("VentaFechaHora"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("ApartadoUsuario"))))
                        boleto.ApartadoUsuario = string.Empty;
                    else
                        boleto.ApartadoUsuario = SqlDr.GetString(SqlDr.GetOrdinal("ApartadoUsuario"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("ApartadoFechaHora"))))
                        boleto.ApartadoFechaHora = string.Empty;
                    else
                        boleto.ApartadoFechaHora = SqlDr.GetString(SqlDr.GetOrdinal("ApartadoFechaHora"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("AnticipoPaso1Usuario"))))
                        boleto.AnticipoPaso1Usuario = string.Empty;
                    else
                        boleto.AnticipoPaso1Usuario = SqlDr.GetString(SqlDr.GetOrdinal("AnticipoPaso1Usuario"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("AnticipoPaso1FechaHora"))))
                        boleto.AnticipoPaso1FechaHora = string.Empty;
                    else
                        boleto.AnticipoPaso1FechaHora = SqlDr.GetString(SqlDr.GetOrdinal("AnticipoPaso1FechaHora"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("AnticipoPaso2Usuario"))))
                        boleto.AnticipoPaso2Usuario = string.Empty;
                    else
                        boleto.AnticipoPaso2Usuario = SqlDr.GetString(SqlDr.GetOrdinal("AnticipoPaso2Usuario"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("AnticipoPaso2FechaHora"))))
                        boleto.AnticipoPaso2FechaHora = string.Empty;
                    else
                        boleto.AnticipoPaso2FechaHora = SqlDr.GetString(SqlDr.GetOrdinal("AnticipoPaso2FechaHora"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("TransferenciaUsuario"))))
                        boleto.TransferenciaUsuario = string.Empty;
                    else
                        boleto.TransferenciaUsuario = SqlDr.GetString(SqlDr.GetOrdinal("TransferenciaUsuario"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("TransferenciaFechaHora"))))
                        boleto.TransferenciaFechaHora = string.Empty;
                    else
                        boleto.TransferenciaFechaHora = SqlDr.GetString(SqlDr.GetOrdinal("TransferenciaFechaHora"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("CancelacionUsuario"))))
                        boleto.CancelacionUsuario = string.Empty;
                    else
                        boleto.CancelacionUsuario = SqlDr.GetString(SqlDr.GetOrdinal("CancelacionUsuario"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("CancelacionFechaHora"))))
                        boleto.CancelacionFechaHora = string.Empty;
                    else
                        boleto.CancelacionFechaHora = SqlDr.GetString(SqlDr.GetOrdinal("CancelacionFechaHora"));

                    boleto.fechahoraSalida = boleto.fechaSalida.ToShortDateString() + ' ' + boleto.horaSalida;

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("motivoCancelacion"))))
                        boleto.servicio = string.Empty;
                    else
                        boleto.servicio = SqlDr.GetString(SqlDr.GetOrdinal("motivoCancelacion"));

                    boleto.PagoEfectivo = SqlDr.GetDecimal(SqlDr.GetOrdinal("PagoEfectivo"));
                    boleto.PagoMonedero = SqlDr.GetDecimal(SqlDr.GetOrdinal("PagoMonedero"));
                    boleto.PagoTarjeta = SqlDr.GetDecimal(SqlDr.GetOrdinal("PagoTarjeta"));
                    boleto.PagoTransferencia = SqlDr.GetDecimal(SqlDr.GetOrdinal("PagoTransferencia"));
                }
                lstBoleto.Add(boleto);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void ConsultaReporteInformeVendedorXFecha(string conexion, ref List<ReporteUsuarios> lstReporteUsuarios, DateTime fechaInicio, DateTime fechaFinal, bool Estadisticos)
        {
            SqlDataReader dr = null;
            if (Estadisticos == false)
                dr = SqlHelper.ExecuteReader(conexion, "obtenerDatosVendedoresXFecha", fechaInicio, fechaFinal);
            else
                dr = SqlHelper.ExecuteReader(conexion, "obtenerDatosVendedoresXFecha_Estadisticos", fechaInicio, fechaFinal);
            ReporteUsuarios reporteusuario;
            while (dr.Read())
            {
                reporteusuario = new ReporteUsuarios();
                reporteusuario.Vendedor = dr["Vendedor"].ToString();
                reporteusuario.VentaDirecta = Convert.ToSingle(dr["VentaDirecta"].ToString());
                reporteusuario.NumeroVentaDirecta = Convert.ToInt32(dr["NumeroVentaDirecta"].ToString());
                reporteusuario.Reservaciones = Convert.ToSingle(dr["Reservaciones"].ToString());
                reporteusuario.NumeroReservaciones = Convert.ToInt32(dr["NumeroReservaciones"].ToString());
                reporteusuario.AnticipoPaso1 = Convert.ToSingle(dr["AnticipoPaso1"].ToString());
                reporteusuario.NumeroAnticipoPaso1 = Convert.ToInt32(dr["NumeroAnticipoPaso1"].ToString());
                reporteusuario.AnticipoPaso2 = Convert.ToSingle(dr["AnticipoPaso2"].ToString());
                reporteusuario.NumeroAnticipoPaso2 = Convert.ToInt32(dr["NumeroAnticipoPaso2"].ToString());
                reporteusuario.Transferencia = Convert.ToSingle(dr["AnticipoPaso2"].ToString());
                reporteusuario.NumeroTransferencia = Convert.ToInt32(dr["NumeroTransferencia"].ToString());
                reporteusuario.Cancelaciones = Convert.ToSingle(dr["Cancelaciones"].ToString());
                reporteusuario.NumeroCancelaciones = Convert.ToInt32(dr["NumeroCancelaciones"].ToString());
                reporteusuario.CancelacionesCobroExtra = Convert.ToSingle(dr["CancelacionesCobroExtra"].ToString());
                reporteusuario.Retiros = Convert.ToSingle(dr["Retiros"].ToString());
                reporteusuario.Depositos = Convert.ToSingle(dr["Depositos"].ToString());
                reporteusuario.Monedero = Convert.ToSingle(dr["Monedero"].ToString());
                lstReporteUsuarios.Add(reporteusuario);
            }
        }
        public List<Depositos_Retiros> ConsultarRetDepXIDCajaXSucursal2(string conexion, int opcion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerDepRetxIDCajaSucursal2", opcion, id_cajaxsucursal, fechaInicio, fechaFin);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerDepRetxIDCajaSucursal2_Estadisticos", opcion, id_cajaxsucursal, fechaInicio, fechaFin);
                Depositos_Retiros retiro;
                List<Depositos_Retiros> listaretiros = new List<Depositos_Retiros>();
                while (dr.Read())
                {
                    retiro = new Depositos_Retiros();
                    if (!dr.IsDBNull(dr.GetOrdinal("id_movimiento")))
                        retiro.id_movimiento = dr["id_movimiento"].ToString();
                    else
                        retiro.id_movimiento = string.Empty;

                    if (!dr.IsDBNull(dr.GetOrdinal("motivo")))
                        retiro.descripcion = dr["motivo"].ToString();
                    else
                        retiro.descripcion = string.Empty;
                    float monto = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("monto")).ToString()), out monto);
                    retiro.monto = monto;
                    if (!dr.IsDBNull(dr.GetOrdinal("motivo")))
                        retiro.vendedor = dr["vendedor"].ToString();
                    else
                        retiro.vendedor = string.Empty;
                    listaretiros.Add(retiro);
                }
                return listaretiros;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarVentasXIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerVentasxIDCajaMod2", id_cajaxsucursal, fechaInicio, fechaFin);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerVentasxIDCajaMod2_Estadisticos", id_cajaxsucursal, fechaInicio, fechaFin);

                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();

                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;

                    // **********  Para cambios del reporte 2017/10/20 ****************

                    if (!dr.IsDBNull(dr.GetOrdinal("FormaPago")))
                        venta.FormaPago = dr["FormaPago"].ToString();
                    else
                        venta.FormaPago = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("Transaccion")))
                        venta.DatosPago = dr["Transaccion"].ToString();
                    else
                        venta.DatosPago = string.Empty;

                    // **********  ****************  ***************** ****************

                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarReservacionesXIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerReservacionesxIDCaja2", id_cajaxsucursal, fechaInicio, fechaFin);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerReservacionesxIDCaja2_Estadisticos", id_cajaxsucursal, fechaInicio, fechaFin);
                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();

                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;
                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarAnticipo1XIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin,bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerAnticipo1xIDCaja2Mod", id_cajaxsucursal, fechaInicio, fechaFin);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerAnticipo1xIDCaja2Mod_Estadisticos", id_cajaxsucursal, fechaInicio, fechaFin);

                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();

                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;
                    // **********  Para cambios del reporte 2017/10/20 ****************

                    if (!dr.IsDBNull(dr.GetOrdinal("FormaPago")))
                        venta.FormaPago = dr["FormaPago"].ToString();
                    else
                        venta.FormaPago = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("Transaccion")))
                        venta.DatosPago = dr["Transaccion"].ToString();
                    else
                        venta.DatosPago = string.Empty;

                    // **********  ****************  ***************** ****************

                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<ReportesVentasCaja> ConsultarAnticipo2XIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerAnticipo2xIDCaja2Mod", id_cajaxsucursal, fechaInicio, fechaFin);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerAnticipo2xIDCaja2Mod_Estadisticos", id_cajaxsucursal, fechaInicio, fechaFin);

                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();

                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;

                    // **********  Para cambios del reporte 2017/10/20 ****************

                    if (!dr.IsDBNull(dr.GetOrdinal("FormaPago")))
                        venta.FormaPago = dr["FormaPago"].ToString();
                    else
                        venta.FormaPago = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("Transaccion")))
                        venta.DatosPago = dr["Transaccion"].ToString();
                    else
                        venta.DatosPago = string.Empty;

                    // **********  ****************  ***************** ****************


                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarTransferenciaXIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerTransferenciaxIDCajaMod2", id_cajaxsucursal, fechaInicio, fechaFin);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerTransferenciaxIDCajaMod2_Estadisticos", id_cajaxsucursal, fechaInicio, fechaFin);

                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();

                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarraTransferencia")))
                        venta.codigoTransferencia = dr["CodigoBarraTransferencia"].ToString();
                    else
                        venta.codigoTransferencia = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;

                    // **********  Para cambios del reporte 2017/10/20 ****************

                    if (!dr.IsDBNull(dr.GetOrdinal("FormaPago")))
                        venta.FormaPago = dr["FormaPago"].ToString();
                    else
                        venta.FormaPago = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("Transaccion")))
                        venta.DatosPago = dr["Transaccion"].ToString();
                    else
                        venta.DatosPago = string.Empty;

                    // **********  ****************  ***************** ****************


                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarCancelacionesXIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerCancelacionesxIDCaja2", id_cajaxsucursal, fechaInicio, fechaFin);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerCancelacionesxIDCaja2_Estadisticos", id_cajaxsucursal, fechaInicio, fechaFin);

                ReportesVentasCaja venta;
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                while (dr.Read())
                {
                    venta = new ReportesVentasCaja();
                    if (!dr.IsDBNull(dr.GetOrdinal("CodigoBarra")))
                        venta.codigo = dr["CodigoBarra"].ToString();
                    else
                        venta.codigo = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        venta.nombre = dr["NombrePersona"].ToString();
                    else
                        venta.nombre = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalDestino")))
                        venta.terminalDestino = dr["terminalDestino"].ToString();
                    else
                        venta.terminalDestino = string.Empty;
                    if (!dr.IsDBNull(dr.GetOrdinal("terminalOrigen")))
                        venta.terminalOrigen = dr["terminalOrigen"].ToString();
                    else
                        venta.terminalOrigen = string.Empty;
                    int asiento = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("asiento")).ToString()), out asiento);
                    venta.asiento = asiento;
                    float costo = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("costo")).ToString()), out costo);
                    venta.costo = costo;
                    float pago = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago1")).ToString()), out pago);
                    venta.pago = pago;
                    float pago2;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("pago2")).ToString()), out pago2);
                    venta.pago2 = pago2;
                    float cancelacion;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("cancelacion")).ToString()), out cancelacion);
                    venta.cancelacion = cancelacion;
                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        venta.vendedor = dr["vendedor"].ToString();
                    else
                        venta.vendedor = string.Empty;
                    listaventas.Add(venta);
                }
                return listaventas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Maletas> ConsultarMaletasXIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerMaletasxIDCaja2", id_cajaxsucursal, fechaInicio, fechaFin);
                else
                    dr = SqlHelper.ExecuteReader(conexion, "obtenerMaletasxIDCaja2_Estadisticos", id_cajaxsucursal, fechaInicio, fechaFin);
                Maletas maletas;
                List<Maletas> listamaletas = new List<Maletas>();
                while (dr.Read())
                {
                    maletas = new Maletas();
                    if (!dr.IsDBNull(dr.GetOrdinal("id_maleta")))
                        maletas.idMaleta = dr["id_maleta"].ToString();
                    else
                        maletas.idMaleta = string.Empty;

                    if (!dr.IsDBNull(dr.GetOrdinal("id_boleto")))
                        maletas.id_boleto = dr["id_boleto"].ToString();
                    else
                        maletas.id_boleto = string.Empty;

                    if (!dr.IsDBNull(dr.GetOrdinal("NombrePersona")))
                        maletas.cliente = dr["NombrePersona"].ToString();
                    else
                        maletas.cliente = string.Empty;

                    if (!dr.IsDBNull(dr.GetOrdinal("folioMaleta")))
                        maletas.folioMaleta = dr["folioMaleta"].ToString();
                    else
                        maletas.folioMaleta = string.Empty;

                    if (!dr.IsDBNull(dr.GetOrdinal("descripcion")))
                        maletas.descripcion = dr["descripcion"].ToString();
                    else
                        maletas.descripcion = string.Empty;

                    /*
                    float KG = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("kg")).ToString()), out KG);
                    maletas.kg = KG;
                    */
                    int numero = 0;
                    int.TryParse((dr.GetValue(dr.GetOrdinal("numeroMaletas")).ToString()), out numero);
                    maletas.numeroMaletas = numero;

                    float precio = 0;
                    float.TryParse((dr.GetValue(dr.GetOrdinal("precio")).ToString()), out precio);
                    maletas.precioMaleta = precio;

                    if (!dr.IsDBNull(dr.GetOrdinal("vendedor")))
                        maletas.vendedor = dr["vendedor"].ToString();
                    else
                        maletas.vendedor = string.Empty;

                    listamaletas.Add(maletas);
                }
                return listamaletas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void obtenerDatosBaseViajes(string Conexion, ref ReportesBoletosViajeHecotours viaje_aux, Viaje auxViaje)
        {
            try
            {
                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(Conexion, "obtenerDatosBaseViajeXID", auxViaje.id_viaje, auxViaje.FechaV, auxViaje.HoraV);
                while (dr.Read())
                {
                    viaje_aux = new ReportesBoletosViajeHecotours();
                    viaje_aux.folio_prestacionServicios1 = dr["folio_prestacionServicios1"].ToString();
                    viaje_aux.id_chofer1_prestacionServicios1 = "";
                    viaje_aux.id_chofer2_prestacionServicios1 = "";
                    viaje_aux.autobus_prestacionServicios1 = dr["autobus_prestacionServicios1"].ToString();
                    viaje_aux.fecha_salida_prestacionServicios1 = Convert.ToDateTime(dr["fecha_salida_prestacionServicios1"].ToString());
                    viaje_aux.hora_salida_prestacionServicios1 = dr["hora_salida_prestacionServicios1"].ToString();
                    viaje_aux.solicitado_por_prestacionServicios1 = "";
                    viaje_aux.grupo_prestacionServicios1 = Convert.ToInt32(dr["numero_personas_prestacionServicios2"].ToString());
                    viaje_aux.servicio_prestacionServicios1 = dr["servicio_prestacionServicios1"].ToString();
                    viaje_aux.presentarse_en_prestacionServicios1 = dr["origen_prestacionServicios2"].ToString();
                    viaje_aux.instrucciones_prestacionServicios1 = "";
                    viaje_aux.observaciones_prestacionServicios1 = "";

                    viaje_aux.folio_prestacionServicios2 = dr["folio_prestacionServicios2"].ToString();
                    viaje_aux.solicitado_por_prestacionServicios2 = "";
                    viaje_aux.poliza_prestacionServicios2 = "";
                    viaje_aux.poliza_fecha1_prestacionServicios2 = DateTime.Now;
                    viaje_aux.poliza_fecha2_prestacionServicios2 = DateTime.Now;
                    viaje_aux.credencial_elector_prestacionServicios2 = "";
                    viaje_aux.domicilio_prestacionServicios2 = "";
                    viaje_aux.origen_prestacionServicios2 = dr["origen_prestacionServicios2"].ToString();
                    viaje_aux.destino_prestacionServicios2 = dr["destino_prestacionServicios2"].ToString();
                    viaje_aux.monto_servicio_prestacionServicios2 = 0.0F;
                    viaje_aux.monto_servicio_texto_prestacionServicios2 = "CERO PESOS 00/100 M.N";
                    viaje_aux.lugar_salida_prestacionServicios2 = dr["lugar_salida_prestacionServicios2"].ToString();
                    viaje_aux.fecha_salida_prestacionServicios2 = Convert.ToDateTime(dr["fecha_salida_prestacionServicios2"].ToString());
                    viaje_aux.hora_salida_prestacionServicios2 = dr["hora_salida_prestacionServicios2"].ToString();
                    viaje_aux.numero_personas_prestacionServicios2 = Convert.ToInt32(dr["numero_personas_prestacionServicios2"].ToString());
                    viaje_aux.id_chofer1_prestacionServicios2 = "";
                    viaje_aux.id_chofer2_prestacionServicios2 = "";
                    viaje_aux.numero_placa_prestacionServicios2 = "";
                    viaje_aux.ruta_contratada_prestacionServicios2 = dr["ruta_contratada_prestacionServicios2"].ToString();
                    viaje_aux.dias_viaje_prestacionServicios2 = Convert.ToInt32(dr["dias_viaje_prestacionServicios2"].ToString());
                    viaje_aux.dia_hora_salida_prestacionServicios2 = dr["dia_hora_salida_prestacionServicios2"].ToString();

                    viaje_aux.folio_listapasajeros = dr["folio_listapasajeros"].ToString();
                    viaje_aux.oficina_listapasajeros = dr["origen_prestacionServicios2"].ToString();
                    viaje_aux.dia_listapasajeros = Convert.ToInt32(dr["dia_listapasajeros"].ToString());
                    viaje_aux.mes_listapasajeros = Convert.ToInt32(dr["mes_listapasajeros"].ToString());
                    viaje_aux.año_listapasajeros = Convert.ToInt32(dr["año_listapasajeros"].ToString());
                    viaje_aux.carro_listapasajeros = dr["carro_listapasajeros"].ToString();
                    viaje_aux.oficinista_listapasajeros = "";
                    viaje_aux.hora_salida_listapasajeros = dr["hora_salida_listapasajeros"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ReportesBoletosViajeHecotours obtenerDatosBase(string Conexion, DateTime fecha, bool _Estadisticos)
        {
            try
            {
                ReportesBoletosViajeHecotours auxReportesBoletosViajeHecotours = new ReportesBoletosViajeHecotours();
                DataSet ds;
                if(_Estadisticos == false)
                   ds = SqlHelper.ExecuteDataset(Conexion, "Consultar_ViajesRptEstadisticos_sp", fecha);
                else
                    ds = SqlHelper.ExecuteDataset(Conexion, "Consultar_ViajesRpt_sp", fecha);
                    
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            auxReportesBoletosViajeHecotours.resultado = ds.Tables[0];
                        }
                    }
                }
                return auxReportesBoletosViajeHecotours;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarRprViaje(string Conexion, ReportesBoletosViajeHecotours ViajeAux, ref int Verificador)
        {
            try
            {
                object[] Valores = { ViajeAux.id_datosViaje, ViajeAux.IDViaje, ViajeAux.FechaV, ViajeAux.HoraV , Comun.Id_U};
                object res = SqlHelper.ExecuteScalar(Conexion, "CatDatosViajes_Eliminar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void obtenerDatosReportesViaje(string Conexion, ref ReportesBoletosViajeHecotours viaje_aux, bool _Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                if(_Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(Conexion, "obtenerDatosViaje_EstadisticosXID", viaje_aux.IDViaje, viaje_aux.FechaV, viaje_aux.HoraV, viaje_aux.id_datosViaje);
                else
                    dr = SqlHelper.ExecuteReader(Conexion, "obtenerDatosViajeXID", viaje_aux.IDViaje, viaje_aux.FechaV, viaje_aux.HoraV, viaje_aux.id_datosViaje);

                while (dr.Read())
                {
                    viaje_aux.folio_prestacionServicios1 = dr["folio_prestacionServicios1"].ToString();
                    viaje_aux.id_chofer1_prestacionServicios1 = dr["id_chofer1_prestacionServicios1"].ToString();
                    viaje_aux.chofer1_prestacionServicios1 = dr["chofer1_prestacionServicios1"].ToString();
                    viaje_aux.id_chofer2_prestacionServicios1 = dr["id_chofer2_prestacionServicios1"].ToString();
                    viaje_aux.chofer2_prestacionServicios1 = dr["chofer2_prestacionServicios1"].ToString();
                    viaje_aux.autobus_prestacionServicios1 = dr["autobus_prestacionServicios1"].ToString();
                    viaje_aux.fecha_salida_prestacionServicios1 = Convert.ToDateTime(dr["fecha_salida_prestacionServicios1"].ToString());
                    viaje_aux.hora_salida_prestacionServicios1 = dr["hora_salida_prestacionServicios1"].ToString();
                    viaje_aux.solicitado_por_prestacionServicios1 = dr["solicitado_por_prestacionServicios1"].ToString();
                    viaje_aux.grupo_prestacionServicios1 = Convert.ToInt32(dr["grupo_prestacionServicios1"].ToString());
                    viaje_aux.servicio_prestacionServicios1 = dr["servicio_prestacionServicios1"].ToString();
                    viaje_aux.presentarse_en_prestacionServicios1 = dr["presentarse_en_prestacionServicios1"].ToString();
                    viaje_aux.instrucciones_prestacionServicios1 = dr["instrucciones_prestacionServicios1"].ToString();
                    viaje_aux.observaciones_prestacionServicios1 = dr["observaciones_prestacionServicios1"].ToString();

                    viaje_aux.folio_prestacionServicios2 = dr["folio_prestacionServicios2"].ToString();
                    viaje_aux.solicitado_por_prestacionServicios2 = dr["solicitado_por_prestacionServicios2"].ToString();
                    viaje_aux.poliza_prestacionServicios2 = dr["poliza_prestacionServicios2"].ToString();
                    viaje_aux.poliza_fecha1_prestacionServicios2 = Convert.ToDateTime(dr["poliza_fecha1_prestacionServicios2"].ToString());
                    viaje_aux.poliza_fecha2_prestacionServicios2 = Convert.ToDateTime(dr["poliza_fecha2_prestacionServicios2"].ToString());
                    viaje_aux.credencial_elector_prestacionServicios2 = dr["credencial_elector_prestacionServicios2"].ToString();
                    viaje_aux.domicilio_prestacionServicios2 = dr["domicilio_prestacionServicios2"].ToString();
                    viaje_aux.origen_prestacionServicios2 = dr["origen_prestacionServicios2"].ToString();
                    viaje_aux.destino_prestacionServicios2 = dr["destino_prestacionServicios2"].ToString();
                    viaje_aux.monto_servicio_prestacionServicios2 = Convert.ToSingle(dr["monto_servicio_prestacionServicios2"].ToString());
                    viaje_aux.monto_servicio_texto_prestacionServicios2 = dr["monto_servicio_texto_prestacionServicios2"].ToString();
                    viaje_aux.lugar_salida_prestacionServicios2 = dr["lugar_salida_prestacionServicios2"].ToString();
                    viaje_aux.fecha_salida_prestacionServicios2 = Convert.ToDateTime(dr["fecha_salida_prestacionServicios2"].ToString());
                    viaje_aux.hora_salida_prestacionServicios2 = dr["hora_salida_prestacionServicios2"].ToString();
                    viaje_aux.numero_personas_prestacionServicios2 = Convert.ToInt32(dr["numero_personas_prestacionServicios2"].ToString());
                    viaje_aux.id_chofer1_prestacionServicios2 = dr["id_chofer1_prestacionServicios2"].ToString();
                    viaje_aux.chofer1_prestacionServicios2 = dr["chofer1_prestacionServicios2"].ToString();
                    viaje_aux.id_chofer2_prestacionServicios2 = dr["id_chofer2_prestacionServicios2"].ToString();
                    viaje_aux.chofer2_prestacionServicios2 = dr["chofer2_prestacionServicios2"].ToString();
                    viaje_aux.numero_placa_prestacionServicios2 = dr["numero_placa_prestacionServicios2"].ToString();
                    viaje_aux.ruta_contratada_prestacionServicios2 = dr["ruta_contratada_prestacionServicios2"].ToString();
                    viaje_aux.dias_viaje_prestacionServicios2 = Convert.ToInt32(dr["dias_viaje_prestacionServicios2"].ToString());
                    viaje_aux.dia_hora_salida_prestacionServicios2 = dr["dia_hora_salida_prestacionServicios2"].ToString();

                    viaje_aux.folio_listapasajeros = dr["folio_listapasajeros"].ToString();
                    viaje_aux.oficina_listapasajeros = dr["oficina_listapasajeros"].ToString();
                    viaje_aux.dia_listapasajeros = Convert.ToInt32(dr["dia_listapasajeros"].ToString());
                    viaje_aux.mes_listapasajeros = Convert.ToInt32(dr["mes_listapasajeros"].ToString());
                    viaje_aux.año_listapasajeros = Convert.ToInt32(dr["año_listapasajeros"].ToString());
                    viaje_aux.carro_listapasajeros = dr["carro_listapasajeros"].ToString();
                    viaje_aux.oficinista_listapasajeros = dr["oficinista_listapasajeros"].ToString();
                    viaje_aux.hora_salida_listapasajeros = dr["hora_salida_listapasajeros"].ToString();

                    viaje_aux.id_prestacionServicios1 = dr["id_prestacionServicios1"].ToString();
                    viaje_aux.id_prestacionServicios2 = dr["id_prestacionServicios2"].ToString();
                    viaje_aux.id_listapasajeros = dr["id_listapasajeros"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  void CargarComboViajeModificar(string Conexion, ref ReportesBoletosViajeHecotours viaje, DateTime fechaSalida, string id_viaje)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(Comun.Conexion, "VistaCamionesT1-2_Combo_sp_Rpt_Mod", fechaSalida, id_viaje);
                Viaje _viaje;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        _viaje = new Viaje(Conexion);
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("IDViajeNuevo"))))
                            _viaje.id_viaje = string.Empty;
                        else
                            _viaje.id_viaje = SqlDr.GetString(SqlDr.GetOrdinal("IDViajeNuevo"));

                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("NombreViaje"))))
                            _viaje.NombreViaje = string.Empty;
                        else
                            _viaje.NombreViaje = SqlDr.GetString(SqlDr.GetOrdinal("NombreViaje"));

                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("fechaOrigen"))))
                            _viaje.FechaV = DateTime.Now;
                        else
                            _viaje.FechaV = SqlDr.GetDateTime(SqlDr.GetOrdinal("fechaOrigen"));

                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("horaOrigen"))))
                            _viaje.HoraV = string.Empty;
                        else
                            _viaje.HoraV = SqlDr.GetString(SqlDr.GetOrdinal("horaOrigen"));
                        viaje.lista_Viaje.Add(_viaje);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarDatosViaje(string Conexion,  ReportesBoletosViajeHecotours viaje, ref int Verificador)
        {
            try
            {
                object[] Valores = { 
                                        viaje.id_datosViaje,
                                        viaje.id_prestacionServicios1,
                                        viaje.id_prestacionServicios2,
                                        viaje.id_listapasajeros,
                                        viaje.IDViaje,
                                        viaje.FechaV,
                                        viaje.HoraV,
                                        viaje.folio_prestacionServicios1,
                                        viaje.id_chofer1_prestacionServicios1,
                                        viaje.id_chofer2_prestacionServicios1,
                                        viaje.autobus_prestacionServicios1,
                                        viaje.fecha_salida_prestacionServicios1,
                                        viaje.hora_salida_prestacionServicios1,
                                        viaje.solicitado_por_prestacionServicios1,
                                        viaje.grupo_prestacionServicios1,
                                        viaje.servicio_prestacionServicios1,
                                        viaje.presentarse_en_prestacionServicios1,
                                        viaje.instrucciones_prestacionServicios1,
                                        viaje.observaciones_prestacionServicios1,
                                        viaje.folio_prestacionServicios2,
                                        viaje.solicitado_por_prestacionServicios2,
                                        viaje.poliza_prestacionServicios2,
                                        viaje.poliza_fecha1_prestacionServicios2,
                                        viaje.poliza_fecha2_prestacionServicios2,
                                        viaje.credencial_elector_prestacionServicios2,
                                        viaje.domicilio_prestacionServicios2,
                                        viaje.origen_prestacionServicios2,
                                        viaje.destino_prestacionServicios2,
                                        viaje.monto_servicio_prestacionServicios2,
                                        viaje.monto_servicio_texto_prestacionServicios2,
                                        viaje.lugar_salida_prestacionServicios2,
                                        viaje.fecha_salida_prestacionServicios2,
                                        viaje.hora_salida_prestacionServicios2,
                                        viaje.numero_personas_prestacionServicios2,
                                        viaje.id_chofer1_prestacionServicios2,
                                        viaje.id_chofer2_prestacionServicios2,
                                        viaje.numero_placa_prestacionServicios2,
                                        viaje.ruta_contratada_prestacionServicios2,
                                        viaje.dias_viaje_prestacionServicios2,
                                        viaje.dia_hora_salida_prestacionServicios2,
                                        viaje.folio_listapasajeros,
                                        viaje.oficina_listapasajeros,
                                        viaje.dia_listapasajeros,
                                        viaje.mes_listapasajeros,
                                        viaje.año_listapasajeros,
                                        viaje.carro_listapasajeros,
                                        viaje.oficinista_listapasajeros,
                                        viaje.hora_salida_listapasajeros,
                                        Comun.Id_U, 
                                        1 };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatDatosViajes_Modificar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
