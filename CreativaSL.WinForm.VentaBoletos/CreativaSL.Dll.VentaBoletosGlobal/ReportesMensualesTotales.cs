using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class ReportesMensualesTotales
    {
        private string _FechaMes;
        private float _Total;
        private int _i;

        public int i
        {
            get { return _i; }
            set { _i = value; }
        }

        public string FechaMes
        {
            get { return _FechaMes; }
            set { _FechaMes = value; }
        }
        public float Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
    }
}
