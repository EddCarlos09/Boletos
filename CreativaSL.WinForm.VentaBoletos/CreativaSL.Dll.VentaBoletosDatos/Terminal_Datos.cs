using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Terminal_Datos
    {
        public Terminal llenarGridPaises(Terminal datos)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(datos.strcnx, "CatPaises_Combo_sp", 1);
                List<Terminal> lista = new List<Terminal>();
                Terminal pais;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        pais = new Terminal(datos.strcnx);
                        pais.id_pais = SqlDr.GetInt32(SqlDr.GetOrdinal("Id"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("Descripcion"))))
                            pais.pais = string.Empty;
                        else
                            pais.pais = SqlDr.GetString(SqlDr.GetOrdinal("Descripcion"));
                        lista.Add(pais);
                    }
                }
                datos.paises = lista;
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Terminal llenarGridEstados(Terminal datos)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(datos.strcnx, "CatEstados_Combo_sp", 1, datos.id_pais);
                List<Terminal> lista = new List<Terminal>();
                Terminal estado;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        estado = new Terminal(datos.strcnx);
                        estado.id_estado = SqlDr.GetInt32(SqlDr.GetOrdinal("Id"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("Descripcion"))))
                            estado.estado = string.Empty;
                        else
                            estado.estado = SqlDr.GetString(SqlDr.GetOrdinal("Descripcion"));
                        lista.Add(estado);
                    }
                }
                datos.estados = lista;
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Terminal llenarGridMunicipios(Terminal datos)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(datos.strcnx, "CatMunicipios_Combo_sp", 1, datos.id_estado, datos.id_pais);
                List<Terminal> lista = new List<Terminal>();
                Terminal municipio;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        municipio = new Terminal(datos.strcnx);
                        municipio.id_municipio = SqlDr.GetInt32(SqlDr.GetOrdinal("Id"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("Descripcion"))))
                            municipio.municipio = string.Empty;
                        else
                            municipio.municipio = SqlDr.GetString(SqlDr.GetOrdinal("Descripcion"));
                        lista.Add(municipio);
                    }
                }
                datos.municipios = lista;
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void registrarTerminal(Terminal terminal)
        {
            try
            {
                object[] Valores = {
                    1,
                    terminal.id_terminal,
                    terminal.nombre,
                    terminal.direccion,
                    terminal.telefonos,
                    terminal.id_pais,
                    terminal.id_estado,
                    terminal.id_municipio,
                    terminal.siglas,
                    Comun.Id_U
                };
                if (SqlHelper.ExecuteNonQuery(terminal.strcnx, "abc_CatTerminales", Valores) <= 0)
                    throw new Exception("No se pudo agregar la información");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Terminal obtenerTerminales(Terminal terminal)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(terminal.strcnx, "Obtener_Terminales_Activas");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            terminal.datatable_terminales = ds.Tables[0];
                        }
                    }
                }
                return terminal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarTerminal(ref int identificador, Terminal terminal)
        {
            try
            {
                object[] Valores = {
                    3,
                    terminal.id_terminal,
                    terminal.nombre,
                    terminal.direccion,
                    terminal.telefonos,
                    terminal.id_pais,
                    terminal.id_estado,
                    terminal.id_municipio,
                    terminal.siglas,
                    Comun.Id_U
                };
                if ((identificador = SqlHelper.ExecuteNonQuery(terminal.strcnx, "abc_CatTerminales", Valores)) <= 0)
                    throw new Exception("No se pudo eliminar el camión");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarTerminal(Terminal terminal)
        {
            try
            {
                object[] Valores = {
                    2,
                    terminal.id_terminal,
                    terminal.nombre,
                    terminal.direccion,
                    terminal.telefonos,
                    terminal.id_pais,
                    terminal.id_estado,
                    terminal.id_municipio,
                    terminal.siglas,
                    Comun.Id_U
                };
                if (SqlHelper.ExecuteNonQuery(terminal.strcnx, "abc_CatTerminales", Valores) <= 0)
                    throw new Exception("No se pudo agregar la información");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
