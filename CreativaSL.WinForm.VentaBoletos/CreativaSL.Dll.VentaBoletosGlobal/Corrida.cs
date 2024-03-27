using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Corrida
    {
        private string _IDCorrida;
        public string IDCorrida
        {
            get { return _IDCorrida; }
            set { _IDCorrida = value; }
        }
        private string _NombreCorrida;
        public string NombreCorrida
        {
            get { return _NombreCorrida; }
            set { _NombreCorrida = value; }
        }
        private int _OrdenOrigen;
        public int OrdenOrigen
        {
            get { return _OrdenOrigen; }
            set { _OrdenOrigen = value; }
        }
        private int _OrdenDestino;
        public int OrdenDestino
        {
            get { return _OrdenDestino; }
            set { _OrdenDestino = value; }
        }
    }
}
