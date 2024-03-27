using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Login_Negocio
    {
        public Usuario validarUsuario(Usuario usuario)
        {
            try
            {
                Login_Datos login_datos = new Login_Datos();
                login_datos.validarUsuario(usuario);
                return usuario;
            }
            catch (Exception ex)
            {

                throw new Exception("Error en negocios ValidarUsuario" + ex.Message);
            }
        }
    }
}
