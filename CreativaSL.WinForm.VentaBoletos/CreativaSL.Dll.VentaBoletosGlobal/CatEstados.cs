using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class CatEstados
    {
        private int _IDEstado;

        public int IDEstado
        {
            get { return _IDEstado; }
            set { _IDEstado = value; }
        }

        private string _EstadoDesc;

        public string EstadoDesc
        {
            get { return _EstadoDesc; }
            set { _EstadoDesc = value; }
        }

    }
}
