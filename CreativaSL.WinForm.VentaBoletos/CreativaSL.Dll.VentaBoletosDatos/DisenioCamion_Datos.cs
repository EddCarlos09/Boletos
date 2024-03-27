using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class DisenioCamion_Datos
    {
        #region Diseño Camion
        public void LlenarGridDisenio(string Conexion, ref DisenioCamion DisenioCamion)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "CatDisenioCamion_Consulta_sp");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            DisenioCamion.DisenioCamiones = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ModificarDisenio(string Conexion, DisenioCamion DisenioCamion, ref int Verificador)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, CommandType.StoredProcedure, "CatDisenioCamion_Modificar_sp", new SqlParameter("@IDDisenioCamion", DisenioCamion.id_disenioCamion), new SqlParameter("@Nombre", DisenioCamion.Nombre), new SqlParameter("@Descripcion", DisenioCamion.Descripcion), new SqlParameter("@NumAsientos", DisenioCamion.NumAsientos), new SqlParameter("@NumTV", DisenioCamion.NumTvs), new SqlParameter("@NumWC", DisenioCamion.NumBaños), new SqlParameter("@NumBares", DisenioCamion.NumBares), new SqlParameter("@NumPisos", DisenioCamion.NumPisos), new SqlParameter("@NumPuerta", DisenioCamion.NumPuertas), new SqlParameter("@DisenioCamion", DisenioCamion.TablaObjetos), new SqlParameter("@ID_U", Comun.Id_U));
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertarDisenio(string Conexion, DisenioCamion DisenioCamion, ref int Verificador)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, CommandType.StoredProcedure, "CatDisenioCamion_Insertar_sp", new SqlParameter("@Nombre", DisenioCamion.Nombre), new SqlParameter("@Descripcion", DisenioCamion.Descripcion), new SqlParameter("@NumAsientos", DisenioCamion.NumAsientos), new SqlParameter("@NumTV", DisenioCamion.NumTvs), new SqlParameter("@NumWC", DisenioCamion.NumBaños), new SqlParameter("@NumBares", DisenioCamion.NumBares), new SqlParameter("@NumPisos", DisenioCamion.NumPisos), new SqlParameter("@NumPuerta", DisenioCamion.NumPuertas), new SqlParameter("@DisenioCamion", DisenioCamion.TablaObjetos), new SqlParameter("@ID_U", Comun.Id_U));
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarDisenio(string Conexion, DisenioCamion DisenioCamion, ref int Verificador)
        {
            try
            {
                object[] Valores = { DisenioCamion.id_disenioCamion };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatDisenioCamion_Eliminar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ObtenerDatosCamion(string Conexion, ref DataTable DatosAuxObject, string IDDiseñoCamion)
        {
            try
            {
                object[] Valores = { IDDiseñoCamion };
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "CatDisenioCamionDatosDiseñador_Consulta_sp", Valores);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                                DatosAuxObject = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
