using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class LoginValidator_Negocio
    {
        private LoginValidator_Datos Login;
        public LoginValidator_Negocio()
        {
            try
            {
                Login = new LoginValidator_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ValidaLoginAdministrador(string Conexion, string Cu_User, string Cu_Pass)
        {
            try
            {
                 return Login.ValidaLoginAdministrador(Conexion, Cu_User, Cu_Pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
