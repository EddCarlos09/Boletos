using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class LoginValidator_Datos
    {
        public bool ValidaLoginAdministrador(string Conexion, string Cu_User, string Cu_Pass)
        {
            try
            {
                object[] Valores = {Cu_User, Cu_Pass};
                object res = SqlHelper.ExecuteScalar(Conexion, "CatUsuarioAdministrador_Consultar_sp", Valores);
                return Convert.ToBoolean(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
