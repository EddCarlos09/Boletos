using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Maletas
    {
        private string _id_boleto;
        public string id_boleto
        {
            get { return _id_boleto; }
            set { _id_boleto = value; }
        }

        private string _origen;
        public string origen
        {
            get { return _origen; }
            set { _origen = value; }
        }

        private string _destino;
        public string destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        private DateTime _fechaSalida;
        public DateTime fechaSalida
        {
            get { return _fechaSalida; }
            set { _fechaSalida = value; }
        }

        private string _horaSalida;
        public string horaSalida
        {
            get { return _horaSalida; }
            set { _horaSalida = value; }
        }

        private DateTime _fechaVenta;
        public DateTime fechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }

        private string _horaVenta;
        public string horaVenta
        {
            get { return _horaVenta; }
            set { _horaVenta = value; }
        }
        private int _asiento;
        public int asiento
        {
            get { return _asiento; }
            set { _asiento = value; }
        }

        private float _precioIva;
        public float precioIva
        {
            get { return _precioIva; }
            set { _precioIva = value; }
        }

        private string _folioBoleto;
        public string folioBoleto
        {
            get { return _folioBoleto; }
            set { _folioBoleto = value; }
        }

        private string _folioMaleta;
        public string folioMaleta
        {
            get { return _folioMaleta; }
            set { _folioMaleta = value; }
        }

        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }


        private DataTable _Maleta;
        public DataTable Maleta
        {
            get { return _Maleta; }
            set { _Maleta = value; }
        }

        private string _cliente;
        public string cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        private int _numeroMaletas;
        public int numeroMaletas
        {
            get { return _numeroMaletas; }
            set { _numeroMaletas = value; }
        }

        private float _precioMaletaTotal;
        public float precioMaletaTotal
        {
            get { return _precioMaletaTotal; }
            set { _precioMaletaTotal = value; }
        }

        private float _precioMaleta;
        public float precioMaleta
        {
            get { return _precioMaleta; }
            set { _precioMaleta = value; }
        }

        private string _idMaleta;
        public string idMaleta
        {
            get { return _idMaleta; }
            set { _idMaleta = value; }
        }

        private string _cajero;
        public string cajero
        {
            get { return _cajero; }
            set { _cajero = value; }
        }

        private List<Maletas> _lstMaletas;
        public List<Maletas> lstMaletas
        {
            get { return _lstMaletas; }
            set { _lstMaletas = value; }
        }

        private string _vendedor;
        public string vendedor
        {
            get { return _vendedor; }
            set { _vendedor = value; }
        }

        private string _lineaMarca;
        public string lineaMarca
        {
            get { return _lineaMarca; }
            set { _lineaMarca = value; }
        }
    }
}
