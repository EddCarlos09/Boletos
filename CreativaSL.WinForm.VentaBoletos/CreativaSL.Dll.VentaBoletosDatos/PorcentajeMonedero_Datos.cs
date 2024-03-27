using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class PorcentajeMonedero_Datos
    {
        public void ModificarPorcentajeMonedero(PorcentajeMonedero porcentajeMonedero, string Conexion,ref int Verificador)
        {
            try
            {
                object[] Valores = { porcentajeMonedero.Porcentaje_Monedero, porcentajeMonedero.MontoCancelacion, Comun.Id_U};
                object res = SqlHelper.ExecuteScalar(Conexion, "PorcentajeMonedeor_Actualizar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarGridPorcentajeMonedero(string Conexion, ref PorcentajeMonedero PorcentajeMonedero)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "Obtener_PorcentajeMonedero");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                             PorcentajeMonedero.PorcentajesMonedero = ds.Tables[0];
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
