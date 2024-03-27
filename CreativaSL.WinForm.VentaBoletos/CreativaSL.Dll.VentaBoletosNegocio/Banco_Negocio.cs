using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Banco_Negocio
    {
        public List<Banco> llenarComboBancos(Banco datos)
        {
            try
            {
                Banco_Datos bd = new Banco_Datos();
                return bd.llenarComboBancos(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
