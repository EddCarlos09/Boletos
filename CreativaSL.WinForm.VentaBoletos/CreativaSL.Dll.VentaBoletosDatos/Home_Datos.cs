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
    public class Home_Datos
    {
        public void ObtenerDatosCamion(string Conexion, ref Home homes)
        {
            try
            {
                int NUMASIENTOSVENDIDOS = 0, NUMASIENTOSAPARTADOS = 0, NUMASIENTOSDISPONIBLES = 0, NUMASIENTOS = homes.NumAsientos;
                if (homes.IDViaje.Length != 0)
                {
                    object[] Valores = { homes.IDViaje, homes.FechaSalida, homes.HoraSalida, homes.OrdenOrigen, homes.OrdenDestino };
                    DataSet ds = SqlHelper.ExecuteDataset(Conexion, "CatDisenioCamionDatos_Consulta_sp", Valores);
     
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            if (ds.Tables[0] != null)
                            {
                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    homes.DatosCamion = ds.Tables[0];
                                }
                            }
                        }
                    }


                    foreach (DataRow row in homes.DatosCamion.Rows)
                    {
                        if (!row["idStatus"].ToString().Equals(""))
                        {
                            if (Convert.ToInt32(row["idStatus"].ToString()) == 3)
                                NUMASIENTOSVENDIDOS = NUMASIENTOSVENDIDOS + 1;
                            else if (Convert.ToInt32(row["idStatus"].ToString()) == 2)
                                NUMASIENTOSAPARTADOS = NUMASIENTOSAPARTADOS + 1;     
                        }
                    }
                    NUMASIENTOSDISPONIBLES = NUMASIENTOS - NUMASIENTOSVENDIDOS - NUMASIENTOSAPARTADOS;
                    homes.NumAsientosDiponibles = NUMASIENTOSDISPONIBLES;
                    homes.NumAsientosApartado = NUMASIENTOSAPARTADOS;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ApartarAsiento(string Conexion, string IDViaje ,int Asiento, string IDCamionDiseño , DateTime FechaSalida, string HoraSalida, int OrdenOrigen, int OrdenDestino, ref string Verificador)
        {
            try
            {
                object[] Valores = { IDViaje, Asiento, IDCamionDiseño, FechaSalida, HoraSalida, OrdenOrigen, OrdenDestino, Comun.Id_U, Comun.macAdress };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatBoletosApartar_Insertar_sp", Valores);
                Verificador = res.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarAsientosApartados(string Conexion, DataTable NuevaVenta, ref int Verificador)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, CommandType.StoredProcedure, "CatBoletosApartadosLiberar_Modificar_sp", new SqlParameter("@DatosBoletos", NuevaVenta), new SqlParameter("@Id_U", Comun.Id_U));
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboTerminales(string Conexion, ref Home homes)
        {
            try
            {

                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(Conexion, "CatTerminales_Combo_sp", 1, "");
                List<Terminal> lista = new List<Terminal>();
                Home home;
                homes.lista_Origen = new List<Home>();
                homes.lista_Destino = new List<Home>();
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        home = new Home();
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_terminal"))))
                            home.id_terminal = string.Empty;
                        else
                            home.id_terminal = SqlDr.GetString(SqlDr.GetOrdinal("id_terminal"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("nombre"))))
                            home.terminal = string.Empty;
                        else
                            home.terminal = SqlDr.GetString(SqlDr.GetOrdinal("nombre"));
                        homes.lista_Origen.Add(home);
                        homes.lista_Destino.Add(home);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LlenarGridSalidas(string Conexion, ref Home homes , string IDTerminalOrigen , string IDTerminalDestino, DateTime FechaBusqueda)
        {
            try
            {
                object[] Valores = { IDTerminalOrigen , IDTerminalDestino , FechaBusqueda };
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "Salidas_Consulta_sp", Valores);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            homes.Salidas = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LiberarAsientoApartadosPorTiempoSistema(string Conexion)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Conexion, "Boletos_LiberarSistema_sp1");
                SqlHelper.ExecuteNonQuery(Conexion, "Boletos_LiberarSistema_sp2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
