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
    public class Ruta_Datos
    {
        public Ruta llenarComboTerminales(Ruta ruta)
        {
            try
            {

                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(ruta.strcnx, "CatTerminales_Combo_sp", 1, ruta.id_terminalAux);
                List<Terminal> lista = new List<Terminal>();
                Terminal terminal;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        terminal = new Terminal(ruta.strcnx);
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_terminal"))))
                            terminal.id_terminal = string.Empty;
                        else
                            terminal.id_terminal = SqlDr.GetString(SqlDr.GetOrdinal("id_terminal"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("nombre"))))
                            terminal.nombre = string.Empty;
                        else
                            terminal.nombre = SqlDr.GetString(SqlDr.GetOrdinal("nombre"));
                        lista.Add(terminal);
                    }
                }
                ruta.lista_terminales = lista;
                return ruta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarRuta(Ruta ruta)
        {
            try
            {
                object[] Valores = 
                {
                    1,
                    ruta.id_ruta,
                    ruta.terminalOrigen + " - " + ruta.terminalDestino,
                    Comun.Id_U
                };
                object result = SqlHelper.ExecuteScalar(ruta.strcnx, "abc_CatRutas", Valores);
                ruta.id_ruta = result.ToString();

                //if (ruta.rutas_intermedias.Count > 0)
                //{
                //    for (int i = 0; i < ruta.rutas_intermedias.Count; i++)
                //    {
                //        Ruta interm = ruta.rutas_intermedias[i];
                //        SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_OrdenRuta", 1, ruta.id_ruta, interm.id_terminalOrigen, (i + 1), Comun.Id_U);
                //        if (i == (ruta.rutas_intermedias.Count - 1))
                //        {
                //            SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_OrdenRuta", 1, ruta.id_ruta, interm.id_terminalDestino, (i + 2), Comun.Id_U);
                //        }
                //    }
                //}
                //else
                //{
                //    SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_OrdenRuta", 1, ruta.id_ruta, ruta.id_terminalOrigen, 1, Comun.Id_U);
                //    SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_OrdenRuta", 1, ruta.id_ruta, ruta.id_terminalDestino, 2, Comun.Id_U);
                //}


                Ruta ruta_princ = new Ruta(ruta.strcnx);
                ruta_princ.id_tipoTerminal = 1;
                ruta_princ.nuevo = 1;
                ruta_princ.id_terminalOrigen = ruta.id_terminalOrigen;
                ruta_princ.id_terminalDestino = ruta.id_terminalDestino;
                ruta_princ.tiempo_minutos = ruta.tiempo_minutos;

                ruta.rutas_intermedias.Add(ruta_princ);

                foreach (Ruta subrutas in ruta.rutas_intermedias)
                {
                    Valores = new object[]
                        {
                            subrutas.nuevo,
                            subrutas.id_ruta,
                            ruta.id_ruta,
                            subrutas.id_terminalOrigen,
                            subrutas.id_terminalDestino,
                            subrutas.tiempo_minutos,
                            subrutas.id_tipoTerminal,
                            subrutas.indice,
                            Comun.Id_U
                        };
                    SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_CatTerminalesXRuta", Valores);
                }

                SqlHelper.ExecuteNonQuery(ruta.strcnx, "orden_rutas_sp", 1, ruta.id_ruta, Comun.Id_U);

                Valores = new object[]
                {
                    1,
                    ruta.id_ruta,
                    Comun.Id_U
                };
                SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_rutasindirectas_sp", Valores);

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void modifcarRuta(Ruta ruta)
        {
            try
            {

                object[] Valores = 
                {
                    2,
                    ruta.id_rutaPadre,
                    ruta.terminalOrigen + " - " + ruta.terminalDestino,
                    Comun.Id_U
                };
                SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_CatRutas", Valores);


                Valores = new object[]
                {
                    2,
                    ruta.id_ruta,
                    ruta.id_rutaPadre,
                    ruta.id_terminalOrigen,
                    ruta.id_terminalDestino,
                    ruta.tiempo_minutos,
                    ruta.id_tipoTerminal,
                    ruta.indice,
                    Comun.Id_U
                };
                SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_CatTerminalesXRuta", Valores);
                //ruta.id_ruta = result.ToString();

                foreach (Ruta subrutas in ruta.rutas_intermedias)
                {
                    Valores = new object[]
                        {
                            subrutas.nuevo,
                            subrutas.id_ruta,
                            ruta.id_rutaPadre,
                            subrutas.id_terminalOrigen,
                            subrutas.id_terminalDestino,
                            subrutas.tiempo_minutos,
                            subrutas.id_tipoTerminal,
                            subrutas.indice,
                            Comun.Id_U
                        };
                    SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_CatTerminalesXRuta", Valores);
                }

                //SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_OrdenRuta", 2, ruta.id_rutaPadre, ruta.id_terminalOrigen, 0, Comun.Id_U);
                //if (ruta.rutas_intermedias.Count > 0)
                //{
                //    for (int i = 0; i < ruta.rutas_intermedias.Count; i++)
                //    {
                //        Ruta interm = ruta.rutas_intermedias[i];
                //        SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_OrdenRuta", 1, interm.id_rutaPadre, interm.id_terminalOrigen, (i + 1), Comun.Id_U);
                //        if (i == (ruta.rutas_intermedias.Count - 1))
                //        {
                //            SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_OrdenRuta", 1, interm.id_rutaPadre, interm.id_terminalDestino, (i + 2), Comun.Id_U);
                //        }
                //    }
                //}
                //else
                //{
                //    SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_OrdenRuta", 1, ruta.id_rutaPadre, ruta.id_terminalOrigen, 1, Comun.Id_U);
                //    SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_OrdenRuta", 1, ruta.id_rutaPadre, ruta.id_terminalDestino, 2, Comun.Id_U);
                //}

                foreach (Ruta eliminar in ruta.listasubrutas_eliminadas)
                {
                    Valores = new object[]
                        {
                            3,
                            eliminar.id_ruta,
                            ruta.id_rutaPadre,
                            eliminar.id_terminalOrigen,
                            eliminar.id_terminalDestino,
                            eliminar.tiempo_minutos,
                            eliminar.id_tipoTerminal,
                            eliminar.indice,
                            Comun.Id_U
                        };
                    SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_CatTerminalesXRuta", Valores);
                }

                SqlHelper.ExecuteNonQuery(ruta.strcnx, "orden_rutas_sp", 1, ruta.id_rutaPadre, Comun.Id_U);

                Valores = new object[]
                {
                    2,
                    ruta.id_rutaPadre,
                    Comun.Id_U
                };
                SqlHelper.ExecuteNonQuery(ruta.strcnx, "abc_rutasindirectas_sp", Valores);

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void EliminarRuta(ref int identificador, Ruta ruta)
        {
            try
            {
                object[] Valores = 
                {
                    3,
                    ruta.id_rutaPadre,
                    ruta.terminalOrigen + " - " + ruta.terminalDestino,
                    Comun.Id_U
                };

                object result = SqlHelper.ExecuteScalar(ruta.strcnx, "abc_CatRutas", Valores);
                identificador = Convert.ToInt32(result.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ruta obtenerRutasPrincipales(Ruta ruta)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(ruta.strcnx, "Obtener_RutasPrincipales_Activas");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            ruta.dataTable_terminalesintermedias = ds.Tables[0];
                        }
                    }
                }

                int tiempo_minutos = 0;
                foreach (DataRow fila in ruta.dataTable_terminalesintermedias.Rows)
                {
                    tiempo_minutos = Convert.ToInt32(fila["tiempoMinutos"].ToString());
                    int hora = 0, minutos = 0;
                    hora = (int)(tiempo_minutos / 60);
                    minutos = tiempo_minutos % 60;
                    fila["tiempo"] = ("00" + hora).Substring(hora.ToString().Length, 2) + ":" + ("00" + minutos).Substring(minutos.ToString().Length, 2);
                }

                return ruta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ruta obtenerRutasIntermedias(Ruta ruta)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(ruta.strcnx, "Obtener_RutasIntermedias_Activas", ruta.id_rutaPadre);
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

                        subruta.indice = SqlDr.GetInt32(SqlDr.GetOrdinal("indice"));

                        int hora = 0, minutos = 0;
                        hora = (int)(subruta.tiempo_minutos / 60);
                        minutos = subruta.tiempo_minutos % 60;
                        subruta.tiempo = ("00" + hora).Substring(hora.ToString().Length, 2) + ":" + ("00" + minutos).Substring(minutos.ToString().Length, 2);

                        subruta.nuevo = 2;
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

        public Ruta obtenerRutas(Ruta ruta)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(ruta.strcnx, "Obtener_RutasPrincipales_Activas");
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
                        subruta.nombreRuta = subruta.terminalOrigen + " - " + subruta.terminalDestino;
                        lista.Add(subruta);
                    }
                }
                ruta.comborutas = lista;
                return ruta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //CatRutas_Combo_sp
        public Ruta obtenerComboRutas(Ruta ruta)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(ruta.strcnx, "CatRutas_Combo_sp", 1);
                List<Ruta> lista = new List<Ruta>();
                Ruta subruta;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        subruta = new Ruta(ruta.strcnx);
                        //Id terminalXruta
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_ruta"))))
                            subruta.id_ruta = string.Empty;
                        else
                            subruta.id_ruta = SqlDr.GetString(SqlDr.GetOrdinal("id_ruta"));
                        //Terminal Origen
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("nombre"))))
                            subruta.nombreRuta = string.Empty;
                        else
                            subruta.nombreRuta = SqlDr.GetString(SqlDr.GetOrdinal("nombre"));
                        subruta.id_rutaPadre = subruta.id_ruta;
                        lista.Add(subruta);
                    }
                }
                ruta.comborutas = lista;
                return ruta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ruta Obtener_RutasxIDRuta(Ruta ruta)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(ruta.strcnx, "Obtener_RutasxIDRuta", ruta.id_ruta);
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




        public Ruta Obtener_RutasxIDRutaTodas(Ruta rutanuevaviaje)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(rutanuevaviaje.strcnx, "Obtener_RutasxIDRutaTodas", rutanuevaviaje.id_ruta);
                List<Ruta> lista = new List<Ruta>();
                Ruta subruta;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        subruta = new Ruta(rutanuevaviaje.strcnx);
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

                        subruta.ordenOrigen = SqlDr.GetInt32(SqlDr.GetOrdinal("ordenOrigen"));
                        subruta.ordenDestino = SqlDr.GetInt32(SqlDr.GetOrdinal("ordenDestino"));

                        subruta.nuevo = 2;
                        lista.Add(subruta);
                    }
                }
                rutanuevaviaje.rutas_intermedias = lista;
                return rutanuevaviaje;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
