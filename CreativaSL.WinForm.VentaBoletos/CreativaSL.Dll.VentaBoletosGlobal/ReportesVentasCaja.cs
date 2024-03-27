using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class ReportesVentasCaja
    {
        private string _codigo;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _codigoTransferencia;

        public string codigoTransferencia
        {
          get { return _codigoTransferencia;}
          set { _codigoTransferencia = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _asiento;

        public int asiento
        {
            get { return _asiento; }
            set { _asiento = value; }
        }

        private string _terminalOrigen;

        public string terminalOrigen
        {
            get { return _terminalOrigen; }
            set { _terminalOrigen = value; }
        }

        private string _terminalDestino;

        public string terminalDestino
        {
            get { return _terminalDestino; }
            set { _terminalDestino = value; }
        }

        private float _costo;

        public float costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        private float _pago;

        public float pago
        {
            get { return _pago; }
            set { _pago = value; }
        }

        private float _pago2;

        public float pago2
        {
            get { return _pago2; }
            set { _pago2 = value; }
        }

        private string _vendedor;

        public string vendedor
        {
            get { return _vendedor; }
            set { _vendedor = value; }
        }

        private float _cancelacion;

        public float cancelacion
        {
            get { return _cancelacion; }
            set { _cancelacion = value; }
        }


        private string _FormaPago;
        /// <summary>
        /// Texto para mostrar la forma de pago (principal)
        /// </summary>
        public string FormaPago
        {
            get { return _FormaPago; }
            set { _FormaPago = value; }
        }


        private string _DatosPago;
        /// <summary>
        /// Texto para mostrar los datos adicionales del pago
        /// </summary>
        public string DatosPago
        {
            get { return _DatosPago; }
            set { _DatosPago = value; }
        }

        private string _FormaPago2;
        /// <summary>
        /// Texto para mostrar la forma de pago (principal)
        /// </summary>
        public string FormaPago2
        {
            get { return _FormaPago2; }
            set { _FormaPago2 = value; }
        }


        private string _DatosPago2;
        /// <summary>
        /// Texto para mostrar los datos adicionales del pago
        /// </summary>
        public string DatosPago2
        {
            get { return _DatosPago2; }
            set { _DatosPago2 = value; }
        }

    }
}
