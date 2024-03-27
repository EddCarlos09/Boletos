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
    public class Viaje_Datos
    {

        public void registrarViaje(Viaje viaje)
        {
            try
            {
                object[] Valores = {
                    1,
                    viaje.id_viaje,
                    viaje.id_ruta,
                    viaje.id_camion,
                    viaje.id_tipoViaje,
                    viaje.fec_PeriodoIni,
                    viaje.fec_PeriodoFin,
                    viaje.lunes,
                    viaje.martes,
                    viaje.miercoles,
                    viaje.jueves,
                    viaje.viernes,
                    viaje.sabado,
                    viaje.domingo,
                    viaje.nombre,
                    viaje.horario,
                    Comun.Id_U
                };
                object result = SqlHelper.ExecuteScalar(viaje.strcnx, "abc_CatViajes", Valores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void registrarNuevaFechasViaje(Viaje viaje, ref int Verificador)
        {
            try
            {
                object[] Valores = {
                    4,
                    viaje.id_viaje,
                    viaje.id_ruta,
                    viaje.id_camion,
                    viaje.id_tipoViaje,
                    viaje.fec_PeriodoIni,
                    viaje.fec_PeriodoFin,
                    viaje.lunes,
                    viaje.martes,
                    viaje.miercoles,
                    viaje.jueves,
                    viaje.viernes,
                    viaje.sabado,
                    viaje.domingo,
                    viaje.nombre,
                    viaje.horario,
                    Comun.Id_U
                };
                object result = SqlHelper.ExecuteScalar(viaje.strcnx, "abc_CatViajes", Valores);
                Verificador = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }      
        }
        public Viaje obtenerViajes(Viaje viaje)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(viaje.strcnx, "Obtener_Viajes_Activos");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            viaje.datatable_viajes = ds.Tables[0];
                        }
                    }
                }
                return viaje;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarViaje(ref int identificador, Viaje viaje)
        {
            try
            {
                object[] Valores = {
                    3,
                    viaje.id_viaje,
                    viaje.id_ruta,
                    viaje.id_camion,
                    viaje.id_tipoViaje,
                    viaje.fec_PeriodoIni,
                    viaje.fec_PeriodoFin,
                    viaje.lunes,
                    viaje.martes,
                    viaje.miercoles,
                    viaje.jueves,
                    viaje.viernes,
                    viaje.sabado,
                    viaje.domingo,
                    viaje.nombre,
                    viaje.horario,
                    Comun.Id_U
                };
                if ((identificador = SqlHelper.ExecuteNonQuery(viaje.strcnx, "abc_CatViajes", Valores)) <= 0)
                    throw new Exception("No se pudo eliminar el camión");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarViaje(Viaje viaje)
        {
            try
            {
                object[] Valores = {
                    2,
                    viaje.id_viaje,
                    viaje.id_ruta,
                    viaje.id_camion,
                    viaje.id_tipoViaje,
                    viaje.fec_PeriodoIni,
                    viaje.fec_PeriodoFin,
                    viaje.lunes,
                    viaje.martes,
                    viaje.miercoles,
                    viaje.jueves,
                    viaje.viernes,
                    viaje.sabado,
                    viaje.domingo,
                    viaje.nombre,
                    viaje.horario,
                    Comun.Id_U
                };
                if (SqlHelper.ExecuteNonQuery(viaje.strcnx, "abc_CatViajes", Valores) <= 0)
                    throw new Exception("No se pudo agregar la información");


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Viaje llenarComboViajes(Viaje viajes)
        {
            try
            {

                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(viajes.strcnx, "CatViajes_Combo_sp", 1);
                List<Viaje> lista = new List<Viaje>();
                Viaje viaje;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        viaje = new Viaje(viajes.strcnx);
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_identificador"))))
                            viaje.id_viaje = string.Empty;
                        else
                            viaje.id_viaje = SqlDr.GetString(SqlDr.GetOrdinal("id_identificador"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("nombre"))))
                            viaje.nombre = string.Empty;
                        else
                            viaje.nombre = SqlDr.GetString(SqlDr.GetOrdinal("nombre"));
                        lista.Add(viaje);
                    }
                }
                viajes.comboViajes = lista;
                return viajes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Viaje obtenerHorarios(Viaje horarios)
        {
            try
            {

                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(horarios.strcnx, "Obtener_HorariosxViaje", horarios.id_viaje);
                List<Viaje> lista = new List<Viaje>();
                Viaje viaje;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        viaje = new Viaje(horarios.strcnx);
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_horario"))))
                            viaje.id_horario = string.Empty;
                        else
                            viaje.id_horario = SqlDr.GetString(SqlDr.GetOrdinal("id_horario"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("horario"))))
                            viaje.horario = string.Empty;
                        else
                            viaje.horario = SqlDr.GetString(SqlDr.GetOrdinal("horario"));
                        viaje.nuevo = 2;
                        lista.Add(viaje);
                    }
                }
                horarios.listaHorarios = lista;
                return horarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarFechasViaje(Viaje viaje, ref int Verificador)
        {
            try
            {
                object[] Valores = {
                    5,
                    viaje.id_viaje,
                    viaje.id_ruta,
                    viaje.id_camion,
                    viaje.id_tipoViaje,
                    viaje.fec_PeriodoIni,
                    viaje.fec_PeriodoFin,
                    viaje.lunes,
                    viaje.martes,
                    viaje.miercoles,
                    viaje.jueves,
                    viaje.viernes,
                    viaje.sabado,
                    viaje.domingo,
                    viaje.nombre,
                    viaje.horario,
                    Comun.Id_U
                };
                object result = SqlHelper.ExecuteScalar(viaje.strcnx, "abc_CatViajes", Valores);
                Verificador = Convert.ToInt32(result.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Viaje obtenerViajesXFechas(Viaje viaje,DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(viaje.strcnx, "Obtener_ViajesXFechas_Activos", viaje.id_viaje, Fecha_Inicio, Fecha_Fin);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            viaje.datatable_viajes = ds.Tables[0];
                        }
                    }
                }
                return viaje;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarRutaViaje(Viaje viajePrincipalViejo, Viaje viajeprincipal, ref int Verificador)
        {
            object result = SqlHelper.ExecuteScalar(viajeprincipal.strcnx,CommandType.StoredProcedure, "abc_CatViajesModificacionRuta",
                    new SqlParameter("@id_viaje_viejo", viajePrincipalViejo.id_viaje),
                    new SqlParameter("@id_ruta_nuevo", viajeprincipal.id_ruta),
                    new SqlParameter("@id_camion_nuevo", viajeprincipal.id_camion),
                    new SqlParameter("@id_tipoViaje_nuevo", viajeprincipal.id_tipoViaje),
                    new SqlParameter("@fec_PeriodoIni_nuevo", viajeprincipal.fec_PeriodoIni),
                    new SqlParameter("@fec_PeriodoFin_nuevo", viajeprincipal.fec_PeriodoFin),
                    new SqlParameter("@lunes_nuevo", viajeprincipal.lunes),
                    new SqlParameter("@martes_nuevo", viajeprincipal.martes),
                    new SqlParameter("@miercoles_nuevo", viajeprincipal.miercoles),
                    new SqlParameter("@jueves_nuevo", viajeprincipal.jueves),
                    new SqlParameter("@viernes_nuevo", viajeprincipal.viernes),
                    new SqlParameter("@sabado_nuevo", viajeprincipal.sabado),
                    new SqlParameter("@domingo_nuevo", viajeprincipal.domingo),
                    new SqlParameter("@nombre_nuevo", viajeprincipal.nombre),
                    new SqlParameter("@horario_nuevo", viajeprincipal.horario),
                    new SqlParameter("@usuario_nuevo", Comun.Id_U),
                    new SqlParameter("@BoletosCambioRutaViajeNuevo", viajeprincipal.lista_BoletosCambio),
                    new SqlParameter("@TarifasViajeNuevo", viajeprincipal.lista_tarifasViaje)        
                );

            Verificador = Convert.ToInt32(result.ToString());
        }

        public string NEWID(string Conexion)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(Conexion, "Obtener_NEWID");
                return result.ToString().ToUpper();
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString();
            }
        }

    }
}
