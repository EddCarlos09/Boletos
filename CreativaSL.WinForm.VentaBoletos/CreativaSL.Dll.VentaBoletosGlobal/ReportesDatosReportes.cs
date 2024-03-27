using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class ReportesDatosReportes
    {
        private string _razonSocial;
        public string razonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }
        private string _rfc;
        public string rfc
        {
            get { return _rfc; }
            set { _rfc = value; }
        }
        private string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _path;
        public string path
        {
            get { return _path; }
            set { _path = value; }
        }
    }
}
