using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class ReportesAnualesTotales
    {
        private string _FechaAño;
        private float _Total;

        public string FechaAño
        {
            get { return _FechaAño; }
            set { _FechaAño = value; }
        }
        public float Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
    }
}
