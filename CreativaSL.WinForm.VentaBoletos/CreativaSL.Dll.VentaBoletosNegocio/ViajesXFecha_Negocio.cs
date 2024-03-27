using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;
namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class ViajesXFecha_Negocio
    {
        private ViajesXFecha_Datos ViajesXFecha;
        public ViajesXFecha_Negocio()
        {
            try
            {
                ViajesXFecha = new ViajesXFecha_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarFechaViaje(string Conexion, Home homes, ref int Verificador)
        {
            try
            {
                ViajesXFecha.EliminarFechaViaje(Conexion, homes, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
