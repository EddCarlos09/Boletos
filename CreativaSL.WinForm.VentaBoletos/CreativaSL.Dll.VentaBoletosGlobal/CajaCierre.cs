using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class CajaCierre
    {
        private string _id_producto;
        private string _id_codigoEan;
        private string _nombre_producto;
        private int _cantidad;

        public string id_producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }
        public string id_codigoEan
        {
            get { return _id_codigoEan; }
            set { _id_codigoEan = value; }
        }
        public string nombre_producto
        {
            get { return _nombre_producto; }
            set { _nombre_producto = value; }
        }
        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
    }
}
