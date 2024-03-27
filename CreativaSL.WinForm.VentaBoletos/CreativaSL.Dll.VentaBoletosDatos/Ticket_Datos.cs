using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Ticket_Datos
    {
        public Boleto obtenerDatosBoleto(Boleto boleto)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(boleto.strcnx, "obtenerDatosBoleto", boleto.id_boleto);

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

                    //IVA
                    float aux = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("iva")).ToString(), out aux);
                    boleto.iva = aux;
                    //DESCUENTO
                    aux = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("descuento")).ToString(), out aux);
                    boleto.descuento = aux;
                    //PRECIOIVA
                    aux = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("total")).ToString(), out aux);
                    boleto.precioIva = aux;

                    boleto.total = boleto.precioIva + boleto.descuento;
                    boleto.Subtotal = boleto.precioIva - boleto.iva;

                    float porciva = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("porciva")).ToString(), out porciva);
                    boleto.porcIva = porciva;
                    //float aux_total = 0, iva = 0;
                    //aux_total = (100 + porciva);
                    //boleto.iva = (boleto.total * porciva) / aux_total;

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("formaPago"))))
                        boleto.formaPago = string.Empty;
                    else
                        boleto.formaPago = SqlDr.GetString(SqlDr.GetOrdinal("formaPago"));
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("tipoBoleto"))))
                        boleto.tipo = string.Empty;
                    else
                        boleto.tipo = SqlDr.GetString(SqlDr.GetOrdinal("tipoBoleto"));
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("terminalOrigen"))))
                        boleto.terminalSalida = string.Empty;
                    else
                        boleto.terminalSalida = SqlDr.GetString(SqlDr.GetOrdinal("terminalOrigen"));
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("origen"))))
                        boleto.origen = string.Empty;
                    else
                        boleto.origen = SqlDr.GetString(SqlDr.GetOrdinal("origen"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("terminalDestino"))))
                        boleto.terminalLlegada = string.Empty;
                    else
                        boleto.terminalLlegada = SqlDr.GetString(SqlDr.GetOrdinal("terminalDestino"));
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("destino"))))
                        boleto.destino = string.Empty;
                    else
                        boleto.destino = SqlDr.GetString(SqlDr.GetOrdinal("destino"));
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("marca"))))
                        boleto.lineaMarca = string.Empty;
                    else
                        boleto.lineaMarca = SqlDr.GetString(SqlDr.GetOrdinal("marca"));
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("servicio"))))
                        boleto.servicio = string.Empty;
                    else
                        boleto.servicio = SqlDr.GetString(SqlDr.GetOrdinal("servicio"));
                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("numcamion"))))
                        boleto.corrida = string.Empty;
                    else
                        boleto.corrida = SqlDr.GetString(SqlDr.GetOrdinal("numcamion"));

                    aux = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("pago")).ToString(), out aux);
                    boleto.pago = aux;

                    aux = 0;
                    float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("pendiente")).ToString(), out aux);
                    boleto.pendiente = aux;

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("cajero"))))
                        boleto.cajero = string.Empty;
                    else
                        boleto.cajero = SqlDr.GetString(SqlDr.GetOrdinal("cajero"));

                    boleto.fecha_venta = SqlDr.GetDateTime(SqlDr.GetOrdinal("fechaventa"));

                    if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("horaventa"))))
                        boleto.hora_venta = string.Empty;
                    else
                        boleto.hora_venta = SqlDr.GetString(SqlDr.GetOrdinal("horaventa"));
                }

                return boleto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Maletas obtenerDatosMaleta(string Conexion, string id_boleto, string id_maleta)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(Conexion, "Obtener_Maletas", id_boleto, id_maleta);
                List<Maletas> listaMaletas = new List<Maletas>();
                Maletas maleta = new Maletas();
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("folio"))))
                            maleta.folioBoleto = string.Empty;
                        else
                            maleta.folioBoleto = SqlDr.GetString(SqlDr.GetOrdinal("folio"));

                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("nombreCliente"))))
                            maleta.cliente = string.Empty;
                        else
                            maleta.cliente = SqlDr.GetString(SqlDr.GetOrdinal("nombreCliente"));

                        maleta.fechaSalida = SqlDr.GetDateTime(SqlDr.GetOrdinal("fecha_salida"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("hora_salida"))))
                            maleta.horaSalida = string.Empty;
                        else
                            maleta.horaSalida = SqlDr.GetString(SqlDr.GetOrdinal("hora_salida"));

                        maleta.fechaVenta = SqlDr.GetDateTime(SqlDr.GetOrdinal("fecha_venta"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("hora_venta"))))
                            maleta.horaVenta = string.Empty;
                        else
                            maleta.horaVenta = SqlDr.GetString(SqlDr.GetOrdinal("hora_venta"));

                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("cajero"))))
                            maleta.cajero = string.Empty;
                        else
                            maleta.cajero = SqlDr.GetString(SqlDr.GetOrdinal("cajero"));
                        maleta.idMaleta = SqlDr.GetString(SqlDr.GetOrdinal("id_maleta"));
                        maleta.folioMaleta = SqlDr.GetString(SqlDr.GetOrdinal("folioMaleta"));
                        maleta.descripcion = SqlDr.GetString(SqlDr.GetOrdinal("descripcion"));
                        float aux = 0;
                        float.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("precio")).ToString(), out aux);
                        maleta.precioMaleta = aux;
                        int aux2 = 0;
                        int.TryParse(SqlDr.GetValue(SqlDr.GetOrdinal("numeroMaletas")).ToString(), out aux2);
                        maleta.numeroMaletas = aux2;
                        maleta.precioMaletaTotal = maleta.precioMaleta;
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("origen"))))
                            maleta.origen = string.Empty;
                        else
                            maleta.origen = SqlDr.GetString(SqlDr.GetOrdinal("origen"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("destino"))))
                            maleta.destino = string.Empty;
                        else
                            maleta.destino = SqlDr.GetString(SqlDr.GetOrdinal("destino"));
                        listaMaletas.Add(maleta);
                    }
                }
                return maleta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
