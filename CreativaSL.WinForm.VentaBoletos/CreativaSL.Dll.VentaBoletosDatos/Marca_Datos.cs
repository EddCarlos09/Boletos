using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    #region Marca
    public class Marca_Datos
    {
        #region LlenarGrid
        public void LlenarGridMarca(string Conexion, ref Marca Marcas)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "Obtener_Marcas", 2);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                                Marcas.Marcas = ds.Tables[0];
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
        #region Insertar
        public void InsertarMarca(Marca marca, string Conexion, ref int Verificador)
        {
            try
            {
                object[] Valores = { marca.nombreMarca, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatMarca_Insertar", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Modificar
        public void ModificarMarca(Marca marca, string Conexion, ref int Verificador)
        {
            try
            {

                object[] Valores = { marca.id_marca, marca.nombreMarca, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatMarca_Modificar", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Eliminar
        public void EliminarMarca(Marca marca, string Conexion, ref int Verificador)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, "CatMarca_Eliminar", marca.id_marca);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
    #endregion
}
