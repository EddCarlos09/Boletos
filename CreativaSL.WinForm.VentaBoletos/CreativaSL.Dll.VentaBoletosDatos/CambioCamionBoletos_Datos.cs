using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using CreativaSL.Dll.VentaBoletosGlobal;
using System.Data.SqlClient;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class CambioCamionBoletos_Datos
    {
        public void CargarCombos(string Conexion, ref CambioCamion Cambio_Camion, DateTime FechaBusq)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { FechaBusq };
                dr = SqlHelper.ExecuteReader(Conexion, "VistaCamionesT1-2_Combo_sp", Valores);
                CambioCamion CambioCamion;
                while (dr.Read())
                {
                    CambioCamion = new CambioCamion();
                    CambioCamion.IDViajeViejo = dr["IDViajeViejo"].ToString();
                    CambioCamion.IDViajeNuevo = dr["IDViajeNuevo"].ToString();
                    CambioCamion.NombreViaje = dr["NombreViaje"].ToString();
                    CambioCamion.FechaSalida = Convert.ToDateTime(dr["FechaSalida"].ToString());
                    CambioCamion.HoraSalida = dr["HoraSalida"].ToString();
                    CambioCamion.FechaV = Convert.ToDateTime(dr["FechaV"].ToString());
                    CambioCamion.HoraV = dr["HoraV"].ToString();
                    CambioCamion.Asientos = Convert.ToInt32(dr["Asientos"].ToString());
                    CambioCamion.AsientosOcupados = Convert.ToInt32(dr["AsientosOcupados"].ToString());
                    CambioCamion.IDRuta = dr["IDRuta"].ToString();
                    CambioCamion.Ruta = dr["Ruta"].ToString();
                    CambioCamion.IDDisenioCamion = dr["IDDisenioCamion"].ToString();
                    CambioCamion.Camion = dr["Camion"].ToString();
                    CambioCamion.IDTipoCamion = Convert.ToInt32(dr["IDTipoCamion"].ToString());
                    CambioCamion.IDTarifa = dr["IDTarifa"].ToString();
                    Cambio_Camion.lista_ViajeViejo.Add(CambioCamion);
                    Cambio_Camion.lista_ViajeNuevo.Add(CambioCamion);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ruta Obtener_RutasViajesxIDRutaxFecha(Ruta ruta)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(ruta.strcnx, "Obtener_RutasViajesxIDRuta", ruta.id_ruta, ruta.id_viaje, ruta.fehcha_viaje);
                List<Ruta> lista = new List<Ruta>();
                Ruta subruta;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        subruta = new Ruta(ruta.strcnx);
                        //Id terminalXruta
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_terminalXruta"))))
                            subruta.id_ruta = string.Empty;
                        else
                            subruta.id_ruta = SqlDr.GetString(SqlDr.GetOrdinal("id_terminalXruta"));
                        //Id_rutaPadre
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_ruta"))))
                            subruta.id_rutaPadre = string.Empty;
                        else
                            subruta.id_rutaPadre = SqlDr.GetString(SqlDr.GetOrdinal("id_ruta"));
                        //Terminal Salida
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_terminalSalida"))))
                            subruta.id_terminalOrigen = string.Empty;
                        else
                            subruta.id_terminalOrigen = SqlDr.GetString(SqlDr.GetOrdinal("id_terminalSalida"));
                        //Terminal Destino
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_terminalDestino"))))
                            subruta.id_terminalDestino = string.Empty;
                        else
                            subruta.id_terminalDestino = SqlDr.GetString(SqlDr.GetOrdinal("id_terminalDestino"));
                        //id_tipoTerminal
                        subruta.id_tipoTerminal = SqlDr.GetInt32(SqlDr.GetOrdinal("id_tipoTerminal"));
                        //Terminal Origen
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("terminalOrigen"))))
                            subruta.terminalOrigen = string.Empty;
                        else
                            subruta.terminalOrigen = SqlDr.GetString(SqlDr.GetOrdinal("terminalOrigen"));
                        //Terminal Destino
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("terminalDestino"))))
                            subruta.terminalDestino = string.Empty;
                        else
                            subruta.terminalDestino = SqlDr.GetString(SqlDr.GetOrdinal("terminalDestino"));
                        //Tiempominutos
                        subruta.tiempo_minutos = SqlDr.GetInt32(SqlDr.GetOrdinal("tiempoMinutos"));

                        int hora = 0, minutos = 0;
                        hora = (int)(subruta.tiempo_minutos / 60);
                        minutos = subruta.tiempo_minutos % 60;
                        subruta.tiempo = ("00" + hora).Substring(hora.ToString().Length, 2) + ":" + ("00" + minutos).Substring(minutos.ToString().Length, 2);

                        subruta.nuevo = 2;

                        subruta.asientosOcupados = SqlDr.GetInt32(SqlDr.GetOrdinal("asientosOcupados"));
                        subruta.ordenOrigen = SqlDr.GetInt32(SqlDr.GetOrdinal("ordenOrigen"));
                        subruta.ordenDestino = SqlDr.GetInt32(SqlDr.GetOrdinal("ordenDestino"));

                        lista.Add(subruta);
                    }
                }
                ruta.rutas_intermedias = lista;
                return ruta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ruta Obtener_RutasViajesxIDRutaCompleto(Ruta ruta)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(ruta.strcnx, "Obtener_RutasViajesxIDRutaCompleto", ruta.id_ruta, ruta.id_viaje, ruta.fehcha_viaje);
                List<Ruta> lista = new List<Ruta>();
                Ruta subruta;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        subruta = new Ruta(ruta.strcnx);
                        //Id terminalXruta
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_terminalXruta"))))
                            subruta.id_ruta = string.Empty;
                        else
                            subruta.id_ruta = SqlDr.GetString(SqlDr.GetOrdinal("id_terminalXruta"));
                        //Id_rutaPadre
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_ruta"))))
                            subruta.id_rutaPadre = string.Empty;
                        else
                            subruta.id_rutaPadre = SqlDr.GetString(SqlDr.GetOrdinal("id_ruta"));
                        //Terminal Salida
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_terminalSalida"))))
                            subruta.id_terminalOrigen = string.Empty;
                        else
                            subruta.id_terminalOrigen = SqlDr.GetString(SqlDr.GetOrdinal("id_terminalSalida"));
                        //Terminal Destino
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_terminalDestino"))))
                            subruta.id_terminalDestino = string.Empty;
                        else
                            subruta.id_terminalDestino = SqlDr.GetString(SqlDr.GetOrdinal("id_terminalDestino"));
                        //id_tipoTerminal
                        subruta.id_tipoTerminal = SqlDr.GetInt32(SqlDr.GetOrdinal("id_tipoTerminal"));
                        //Terminal Origen
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("terminalOrigen"))))
                            subruta.terminalOrigen = string.Empty;
                        else
                            subruta.terminalOrigen = SqlDr.GetString(SqlDr.GetOrdinal("terminalOrigen"));
                        //Terminal Destino
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("terminalDestino"))))
                            subruta.terminalDestino = string.Empty;
                        else
                            subruta.terminalDestino = SqlDr.GetString(SqlDr.GetOrdinal("terminalDestino"));
                        //Tiempominutos
                        subruta.tiempo_minutos = SqlDr.GetInt32(SqlDr.GetOrdinal("tiempoMinutos"));

                        int hora = 0, minutos = 0;
                        hora = (int)(subruta.tiempo_minutos / 60);
                        minutos = subruta.tiempo_minutos % 60;
                        subruta.tiempo = ("00" + hora).Substring(hora.ToString().Length, 2) + ":" + ("00" + minutos).Substring(minutos.ToString().Length, 2);

                        subruta.nuevo = 2;

                        subruta.asientosOcupados = SqlDr.GetInt32(SqlDr.GetOrdinal("asientosOcupados"));
                        subruta.ordenOrigen = SqlDr.GetInt32(SqlDr.GetOrdinal("ordenOrigen"));
                        subruta.ordenDestino = SqlDr.GetInt32(SqlDr.GetOrdinal("ordenDestino"));

                        lista.Add(subruta);
                    }
                }
                ruta.rutas_intermedias = lista;
                return ruta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ObtenerBoletosViajesXRutasByOneFecha(string Conexion, Ruta ruta, Boleto boleto)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { ruta.id_ruta, ruta.id_viaje, ruta.fehcha_viaje, ruta.hora_viaje };
                dr = SqlHelper.ExecuteReader(Conexion, "Obtener_BoletosRutasViajesxIDRuta", Valores);
                Boleto auxBoletos;
                while (dr.Read())
                {
                    auxBoletos = new Boleto(Comun.Conexion);
                    auxBoletos.id_boleto = Convert.ToString(dr["id_boleto"].ToString());
                    auxBoletos.asiento = Convert.ToInt32(dr["asiento"].ToString());
                    auxBoletos.id_status = Convert.ToInt32(dr["id_status"].ToString());
                    auxBoletos.cliente_nombre = Convert.ToString(dr["cliente_nombre"].ToString());
                    auxBoletos.origen = Convert.ToString(dr["terminalOrigen"].ToString());
                    auxBoletos.destino = Convert.ToString(dr["terminalDestino"].ToString());
                    auxBoletos.id_terminalXruta = Convert.ToString(dr["id_terminalXruta"].ToString());
                    auxBoletos.id_ruta = Convert.ToString(dr["id_ruta"].ToString());
                    auxBoletos.id_terminalSalida = Convert.ToString(dr["id_terminalSalida"].ToString());
                    auxBoletos.id_terminalDestino = Convert.ToString(dr["id_terminalDestino"].ToString());
                    auxBoletos.id_disenioDatos = Convert.ToString(dr["id_disenioDatos"].ToString());
                    auxBoletos.id_tarfifa = Convert.ToString(dr["id_tarfifa"].ToString());
                    boleto.lstBoletos_viajes1.Add(auxBoletos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ObtenerBoletosViajesXRutasByFechas(string Conexion, Ruta ruta, Boleto boleto, DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { ruta.id_ruta, ruta.id_viaje, FechaInicio,FechaFin, ruta.hora_viaje };
                dr = SqlHelper.ExecuteReader(Conexion, "Obtener_BoletosRutasViajesxIDRutaXFechas", Valores);
                Boleto auxBoletos;
                while (dr.Read())
                {
                    auxBoletos = new Boleto(Comun.Conexion);
                    auxBoletos.id_boleto = Convert.ToString(dr["id_boleto"].ToString());
                    auxBoletos.fechaSalida = Convert.ToDateTime(dr["fecha_salida"].ToString());
                    auxBoletos.horaSalida = Convert.ToString(dr["hora"].ToString());
                    auxBoletos.asiento = Convert.ToInt32(dr["asiento"].ToString());
                    auxBoletos.id_status = Convert.ToInt32(dr["id_status"].ToString());
                    auxBoletos.cliente_nombre = Convert.ToString(dr["cliente_nombre"].ToString());
                    auxBoletos.origen = Convert.ToString(dr["terminalOrigen"].ToString());
                    auxBoletos.destino = Convert.ToString(dr["terminalDestino"].ToString());
                    auxBoletos.id_terminalXruta = Convert.ToString(dr["id_terminalXruta"].ToString());
                    auxBoletos.id_ruta = Convert.ToString(dr["id_ruta"].ToString());
                    auxBoletos.id_terminalSalida = Convert.ToString(dr["id_terminalSalida"].ToString());
                    auxBoletos.id_terminalDestino = Convert.ToString(dr["id_terminalDestino"].ToString());
                    auxBoletos.id_disenioDatos = Convert.ToString(dr["id_disenioDatos"].ToString());
                    auxBoletos.id_tarfifa = Convert.ToString(dr["id_tarfifa"].ToString());
                    boleto.lstBoletos_viajes1.Add(auxBoletos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CambiarBoletos(string Conexion, DataTable datosBoletos, ref int Verificador)
        {
            Verificador = 0;
            DataSet Datos_Boletos = new DataSet();
            Datos_Boletos = SqlHelper.ExecuteDataset(Conexion, CommandType.StoredProcedure, "CambioCamion_Modificar_sp",
            new SqlParameter("@BoletosCambioRutaViaje", datosBoletos));
            if (Convert.ToInt32(Datos_Boletos.Tables[0].Rows[0][0]) == 1)
            {
                Verificador = 1;
            }
        }
    }
}
