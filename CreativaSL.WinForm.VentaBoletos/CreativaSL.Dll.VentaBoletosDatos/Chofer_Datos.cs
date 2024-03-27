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
    public class Chofer_Datos
    {
        #region Choferes
        public void InsertarChofer(string Conexion, Chofer Chofer, int Verificador)
        {
            try
            {
                object[] Valores = { Chofer.Nombre, Chofer.ApellidoPaterno, Chofer.ApellidoMaterno, Chofer.Curp, Chofer.FechaNacimiento, Chofer.Observaciones, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatChofer_Insertar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ModificarChofer(string Conexion, Chofer Chofer, int Verificador)
        {
            try
            {
                object[] Valores = { Chofer.IDChofer, Chofer.Nombre, Chofer.ApellidoPaterno, Chofer.ApellidoMaterno, Chofer.Curp, Chofer.FechaNacimiento, Chofer.Observaciones, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatChofer_Modificar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarChofer(Chofer Chofer, string Conexion, ref int Verificador)
        {
            try
            {
                object[] Valores = { Chofer.IDChofer };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatChofer_Eliminar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LlenarGridChofer(string Conexion, ref Chofer Choferes)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "CatChofer_Consulta_sp");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                                Choferes.Choferes = ds.Tables[0];
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
