using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class ReportesClienteComprador
    {
        private string _Nombre;
        private float _TotalComprado;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public float TotalComprado
        {
            get { return _TotalComprado; }
            set { _TotalComprado = value; }
        }
    }
}
