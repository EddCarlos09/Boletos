using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Busqueda_Negocio
    {
        public Busqueda BuscarBoletos(Busqueda datos)
        {
            try
            {
                Busqueda_Datos bd = new Busqueda_Datos();
                return bd.BuscarBoletos(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Busqueda ValidarFolioTransferencia(string Folio, string Conexion)
        {
            try
            {
                Busqueda_Datos bd = new Busqueda_Datos();
                return bd.ValidarFolioTransferencia(Folio, Conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
