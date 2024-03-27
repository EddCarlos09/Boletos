using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class CatMunicipio
    {
        private int _IDMunicipio;

        public int IDMunicipio
        {
            get { return _IDMunicipio; }
            set { _IDMunicipio = value; }
        }

        private string _MunicipioDesc;

        public string MunicipioDesc
        {
            get { return _MunicipioDesc; }
            set { _MunicipioDesc = value; }
        }

    }
}
