using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Busqueda
    {

        public Busqueda(String conexion)
        {
            this.strcnx = conexion;
        }

        private string _strcnx;
        public string strcnx
        {
            get { return _strcnx; }
            set { _strcnx = value; }
        }

        private DateTime _fecha_boleto;
        public DateTime fecha_boleto
        {
            get { return _fecha_boleto; }
            set { _fecha_boleto = value; }
        }

        private string _folio_boleto;
        public string folio_boleto
        {
            get { return _folio_boleto; }
            set { _folio_boleto = value; }
        }

        private string _nombre_cliente;
        public string nombre_cliente
        {
            get { return _nombre_cliente; }
            set { _nombre_cliente = value; }
        }

        private string _folio_venta;
        public string folio_venta
        {
            get { return _folio_venta; }
            set { _folio_venta = value; }
        }
        
        private bool _band_nombre;
        public bool band_nombre
        {
            get { return _band_nombre; }
            set { _band_nombre = value; }
        }

        private bool _band_fecha;
        public bool band_fecha
        {
            get { return _band_fecha; }
            set { _band_fecha = value; }
        }

        private bool _band_folio;
        public bool band_folio
        {
            get { return _band_folio; }
            set { _band_folio = value; }
        }

        private bool _band_folioVenta;
        public bool band_folioVenta
        {
            get { return _band_folioVenta; }
            set { _band_folioVenta = value; }
        }
        
        private DataTable _resultado;
        public DataTable resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }

        private bool _Validador;
        public bool Validador
        {
            get { return _Validador; }
            set { _Validador = value; }
        }
        
    }
}
