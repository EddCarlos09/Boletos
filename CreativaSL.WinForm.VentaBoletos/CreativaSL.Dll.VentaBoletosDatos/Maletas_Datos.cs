using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Maletas_Datos
    {
        public void AgregarMaletas(string Conexion, ref int Verificador, ref Maletas infoMaletas)
        {
            try
            {
                object[] Valores = { infoMaletas.id_boleto, infoMaletas.folioMaleta, infoMaletas.descripcion, infoMaletas.precioMaleta, infoMaletas.numeroMaletas , Comun.Id_U, Comun.id_caja };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatMaletas_Agregar_sp", Valores);
                infoMaletas.idMaleta = Convert.ToString(res);
                Verificador = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarMaletas(string Conexion, ref int Verificador, ref Maletas infoMaletas)
        {
            try
            {
                object[] Valores = { infoMaletas.idMaleta, Comun.Id_U, Comun.id_caja };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatMaletas_Eliminar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LlenarGridMaletas(string Conexion, ref DataTable _maletas, string id_boleto)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "CatMaletas_Consulta_sp", id_boleto);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            _maletas = ds.Tables[0];
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
