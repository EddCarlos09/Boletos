using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class BusquedaCambio_Negocio
    {
        private BusquedaCambio_Datos busquedaCambio;
        public BusquedaCambio_Negocio()
        {
            try
            {
                busquedaCambio = new BusquedaCambio_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Busqueda BuscarBoletos(string Conexion, Busqueda busqueda)
        {
            try
            {
                return busquedaCambio.BuscarBoletos(Conexion,busqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
