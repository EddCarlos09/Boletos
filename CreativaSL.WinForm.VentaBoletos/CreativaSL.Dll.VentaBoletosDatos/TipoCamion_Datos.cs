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
    #region TipoCamion
    public class TipoCamion_Datos
    {
        #region LlenarGrid
        public void LlenarGridTipoCamion(string Conexion, ref TipoCamion TipoCamiones)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "Obtener_TipoCamion", 2);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                           TipoCamiones.TipoCamiones = ds.Tables[0];
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
        public void InsertarTipoCamion(TipoCamion tipocamion, string Conexion, ref int Verificador)
        {
            try
            {
                object[] Valores = { tipocamion.nombreTipoCamion, tipocamion.maximoDescuentoLinea,Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatTipoCamion_Insertar", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Modificar
        public void ModificarTipoCamion(TipoCamion tipocamion, string Conexion, ref int Verificador)
        {
            try
            {

                object[] Valores = { tipocamion.id_tipocamion,tipocamion.nombreTipoCamion, tipocamion.maximoDescuentoLinea,Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatTipoCamion_Modificar", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Eliminar
        public void EliminarTipoCamion(TipoCamion tipocamion, string Conexion, ref int Verificador)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, "CatTipoCamion_Eliminar", tipocamion.id_tipocamion);
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
