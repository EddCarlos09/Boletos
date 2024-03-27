using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Configuracion_Negocio
    {
        public Configuracion agregarConfiguracion(Configuracion actual)
        {
            try
            {
                Configuracion_Datos cd = new Configuracion_Datos();
                return cd.agregarConfiguracion(actual);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Configuracion obtenerConfiguracion(Configuracion actual)
        {
            try
            {
                Configuracion_Datos cd = new Configuracion_Datos();
                return cd.obtenerConfiguracion(actual);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
