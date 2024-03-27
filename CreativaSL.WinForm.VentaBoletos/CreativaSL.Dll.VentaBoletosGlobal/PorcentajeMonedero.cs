using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class PorcentajeMonedero
    {
        private string _IDSucursal;
        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }

        private float _Porcentaje_Monedero;
        public float Porcentaje_Monedero
        {
            get { return _Porcentaje_Monedero; }
            set { _Porcentaje_Monedero = value; }
        }

        private float _MontoCancelacion;
        public float MontoCancelacion
        {
            get { return _MontoCancelacion; }
            set { _MontoCancelacion = value; }
        }

        private DataTable _PorcentajesMonedero;
        public DataTable PorcentajesMonedero
        {
            get { return _PorcentajesMonedero; }
            set { _PorcentajesMonedero = value; }
        }


    }
}
