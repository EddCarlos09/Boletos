using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class TipoDocumento_Negocio
    {
        public List<TipoDocumento> LlenarComboDocumentos(TipoDocumento datos)
        {
            try
            {
                TipoDocumento_Datos td = new TipoDocumento_Datos();
                return td.LlenarComboDocumentos(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
