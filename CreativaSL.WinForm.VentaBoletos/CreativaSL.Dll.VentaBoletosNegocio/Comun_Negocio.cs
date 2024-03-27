using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Comun_Negocio
    {
        public void ObtenerSucursal(string conexion, string Cu_User, string Cu_Pass)
        {
            Comun_Datos cm = new Comun_Datos();
            cm.ObtenerConfiguracion(conexion, Cu_User, Cu_Pass);
        }
    }
}
