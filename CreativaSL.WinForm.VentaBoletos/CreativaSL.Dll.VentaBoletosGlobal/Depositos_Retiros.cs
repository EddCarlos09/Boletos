using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Depositos_Retiros
    {
        private string _id_movimiento;

        public string id_movimiento
        {
            get { return _id_movimiento; }
            set { _id_movimiento = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private float _monto;

        public float monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        private string _vendedor;

        public string vendedor
        {
            get { return _vendedor; }
            set { _vendedor = value; }
        }
        
        

    }
}
