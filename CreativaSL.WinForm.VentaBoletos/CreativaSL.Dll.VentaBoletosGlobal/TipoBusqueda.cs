using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class TipoBusqueda
    {
        public TipoBusqueda()
        {
            IDTipoBusqueda = 0;
            Descripcion = string.Empty;
        }
        public int IDTipoBusqueda { get; set; }
        public string Descripcion { get; set; }
    }
}
