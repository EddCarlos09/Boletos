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
    public class Camion_Datos
    {

        public Camion obtener_tiposCamiones(Camion camion)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(camion.strcnx, "Obtener_TipoCamion", 1);
                List<Camion> lista = new List<Camion>();
                Camion tipo;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        tipo = new Camion(camion.strcnx);
                        tipo.id_Tipocamion = SqlDr.GetInt32(SqlDr.GetOrdinal("id_tipoCamion"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("tipoCamion"))))
                            tipo.tipoCamion = string.Empty;
                        else
                            tipo.tipoCamion = SqlDr.GetString(SqlDr.GetOrdinal("tipoCamion"));
                        lista.Add(tipo);
                    }
                }
                camion.lista_tipoCam = lista;
                return camion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Camion obtener_marcas(Camion camion)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(camion.strcnx, "Obtener_Marcas", 1);
                List<Camion> lista = new List<Camion>();
                Camion marca;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        marca = new Camion(camion.strcnx);
                        marca.id_marca = SqlDr.GetInt32(SqlDr.GetOrdinal("id_marca"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("marca"))))
                            marca.marca = string.Empty;
                        else
                            marca.marca = SqlDr.GetString(SqlDr.GetOrdinal("marca"));
                        lista.Add(marca);
                    }
                }
                camion.lista_marcas = lista;
                return camion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Camion obtener_submarcasxmarca(Camion camion)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(camion.strcnx, "Obtener_Submarcas", 1, camion.id_marca);
                List<Camion> lista = new List<Camion>();
                Camion submarca;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        submarca = new Camion(camion.strcnx);
                        submarca.id_submarca = SqlDr.GetInt32(SqlDr.GetOrdinal("id_submarca"));
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("submarca"))))
                            submarca.submarca = string.Empty;
                        else
                            submarca.submarca = SqlDr.GetString(SqlDr.GetOrdinal("submarca"));
                        submarca.id_marca = camion.id_marca;
                        lista.Add(submarca);
                    }
                }
                camion.lista_submarcas = lista;
                return camion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Camion obtener_diseniosCamiones(Camion camion)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(camion.strcnx, "Obtener_Disenios", 1);
                List<Camion> lista = new List<Camion>();
                Camion disenio;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        disenio = new Camion(camion.strcnx);
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_disenioCamion"))))
                            disenio.id_diseniocamion = string.Empty;
                        else
                            disenio.id_diseniocamion = SqlDr.GetString(SqlDr.GetOrdinal("id_disenioCamion"));

                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("nombre"))))
                            disenio.descripciondisenio = string.Empty;
                        else
                            disenio.descripciondisenio = SqlDr.GetString(SqlDr.GetOrdinal("nombre"));
                        lista.Add(disenio);
                    }
                }
                camion.lista_disenios = lista;
                return camion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void registrarCamion(Camion camion)
        {
            try
            {
                object[] Valores = {
                    1,
                    camion.id_camion,
                    camion.descripcion,
                    camion.id_marca,
                    camion.id_submarca,
                    camion.id_Tipocamion,
                    camion.num_camion,
                    camion.id_diseniocamion,
                    camion.caracteristicas,
                    Comun.Id_U
                };
                if (SqlHelper.ExecuteNonQuery(camion.strcnx, "abc_CatCamiones", Valores) <= 0)
                    throw new Exception("No se pudo agregar la información");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Camion obtenerCamiones(Camion camion)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(camion.strcnx, "Obtener_Camiones_Activos");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            camion.datatable_camiones = ds.Tables[0];
                        }
                    }
                }
                return camion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarCamion(ref int identificador, Camion camion)
        {
            try
            {
                object[] Valores = {
                    3,
                    camion.id_camion,
                    camion.descripcion,
                    camion.id_marca,
                    camion.id_submarca,
                    camion.id_Tipocamion,
                    camion.num_camion,
                    camion.id_diseniocamion,
                    camion.caracteristicas,
                    Comun.Id_U
                };
                if ((identificador = SqlHelper.ExecuteNonQuery(camion.strcnx, "abc_CatCamiones", Valores)) <= 0)
                    throw new Exception("No se pudo eliminar el camión");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarCamion(Camion camion)
        {
            try
            {
                object[] Valores = {
                    2,
                    camion.id_camion,
                    camion.descripcion,
                    camion.id_marca,
                    camion.id_submarca,
                    camion.id_Tipocamion,
                    camion.num_camion,
                    camion.id_diseniocamion,
                    camion.caracteristicas,
                    Comun.Id_U
                };
                if (SqlHelper.ExecuteNonQuery(camion.strcnx, "abc_CatCamiones", Valores) <= 0)
                    throw new Exception("No se pudo agregar la información");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Camion obtenerCamionesCombo(Camion camiones)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(camiones.strcnx, "CatCamiones_Combo_sp", 1);
                List<Camion> lista = new List<Camion>();
                Camion camion;
                if (SqlDr.HasRows == true)
                {
                    while (SqlDr.Read())
                    {
                        camion = new Camion(camiones.strcnx);
                        //Id camion
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("id_camion"))))
                            camion.id_camion = string.Empty;
                        else
                            camion.id_camion = SqlDr.GetString(SqlDr.GetOrdinal("id_camion"));
                        //Descripcion
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("descripcion"))))
                            camion.descripcion = string.Empty;
                        else
                            camion.descripcion = SqlDr.GetString(SqlDr.GetOrdinal("descripcion"));
                        //NumCamion
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("numcamion"))))
                            camion.num_camion = string.Empty;
                        else
                            camion.num_camion = SqlDr.GetString(SqlDr.GetOrdinal("numcamion"));
                        //tipoCamion
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("tipoCamion"))))
                            camion.tipoCamion = string.Empty;
                        else
                            camion.tipoCamion = SqlDr.GetString(SqlDr.GetOrdinal("tipoCamion"));
                        //Descripcion
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("nombre"))))
                            camion.descripciondisenio = string.Empty;
                        else
                            camion.descripciondisenio = SqlDr.GetString(SqlDr.GetOrdinal("nombre"));
                        lista.Add(camion);
                    }
                }
                camiones.comboCamiones = lista;
                return camiones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ObtenerDatosCamion(string Conexion, ref DataTable DatosCamion, string IDDiseñoDatos)
        {
            try
            {
                object[] Valores = { IDDiseñoDatos };
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "CatDisenioCamionDatosDiseñador_Consulta_sp", Valores);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                                DatosCamion = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
