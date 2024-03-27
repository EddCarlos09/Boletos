using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class ReporteUsuarios
    {
        private string _Vendedor;
        private float _VentaDirecta;
        private int _NumeroVentaDirecta;
        private float _Reservaciones;
        private int _NumeroReservaciones;
        private float _AnticipoPaso1;
        private int _NumeroAnticipoPaso1;
        private float _AnticipoPaso2;
        private int _NumeroAnticipoPaso2;
        private float _Transferencia;
        private int _NumeroTransferencia;
        private float _Cancelaciones;
        private int _NumeroCancelaciones;
        private float _CancelacionesCobroExtra;
        private float _Retiros;
        private float _Depositos;
        private float _Monedero;

        public string Vendedor
        {
            get { return _Vendedor; }
            set { _Vendedor = value; }
        }

        public float VentaDirecta
        {
            get { return _VentaDirecta; }
            set { _VentaDirecta = value; }
        }
        public int NumeroVentaDirecta
        {
            get { return _NumeroVentaDirecta; }
            set { _NumeroVentaDirecta = value; }
        }

        public float Reservaciones
        {
            get { return _Reservaciones; }
            set { _Reservaciones = value; }
        }
        public int NumeroReservaciones
        {
            get { return _NumeroReservaciones; }
            set { _NumeroReservaciones = value; }
        }

        public float AnticipoPaso1
        {
            get { return _AnticipoPaso1; }
            set { _AnticipoPaso1 = value; }
        }
        public int NumeroAnticipoPaso1
        {
            get { return _NumeroAnticipoPaso1; }
            set { _NumeroAnticipoPaso1 = value; }
        }

        public float AnticipoPaso2
        {
            get { return _AnticipoPaso2; }
            set { _AnticipoPaso2 = value; }
        }
        public int NumeroAnticipoPaso2
        {
            get { return _NumeroAnticipoPaso2; }
            set { _NumeroAnticipoPaso2 = value; }
        }

        public float Transferencia
        {
            get { return _Transferencia; }
            set { _Transferencia = value; }
        }
        public int NumeroTransferencia
        {
            get { return _NumeroTransferencia; }
            set { _NumeroTransferencia = value; }
        }

        public float Cancelaciones
        {
            get { return _Cancelaciones; }
            set { _Cancelaciones = value; }
        }
        public int NumeroCancelaciones
        {
            get { return _NumeroCancelaciones; }
            set { _NumeroCancelaciones = value; }
        }

        public float CancelacionesCobroExtra
        {
            get { return _CancelacionesCobroExtra; }
            set { _CancelacionesCobroExtra = value; }
        }
        public float Retiros
        {
            get { return _Retiros; }
            set { _Retiros = value; }
        }
        public float Depositos
        {
            get { return _Depositos; }
            set { _Depositos = value; }
        }
        public float Monedero
        {
            get { return _Monedero; }
            set { _Monedero = value; }
        }

    }
}
