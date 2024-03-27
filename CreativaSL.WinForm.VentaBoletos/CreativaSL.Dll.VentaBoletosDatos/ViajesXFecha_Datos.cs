using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class ViajesXFecha_Datos
    {
        public void EliminarFechaViaje(string Conexion, Home homes, ref int Verificador)
        {
            try
            {
                object[] Valores = { homes.IDViaje, homes.FechaSalidaV, Comun.Id_U};
                object res = SqlHelper.ExecuteScalar(Conexion, "CatViajeFecha_Eliminar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
