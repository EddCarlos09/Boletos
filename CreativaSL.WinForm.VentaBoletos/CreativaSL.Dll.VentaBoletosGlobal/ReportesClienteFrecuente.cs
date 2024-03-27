using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class ReportesClienteFrecuente
    {
        private string _Nombre;
        private int _NVeces;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public int NVeces
        {
            get { return _NVeces; }
            set { _NVeces = value; }
        }
    }
}
