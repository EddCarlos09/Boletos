using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Apartados
    {
        private float _Total;
        public float Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        private float _TotalPagar;
        public float TotalPagar
        {
            get { return _TotalPagar; }
            set { _TotalPagar = value; }
        }

        private float _Pendiente;
        public float Pendiente
        {
            get { return _Pendiente; }
            set { _Pendiente = value; }
        }

        private string _IDBoleto;
        public string IDBoleto
        {
            get { return _IDBoleto; }
            set { _IDBoleto = value; }
        }

        private string _IDVenta;
        public string IDVenta
        {
            get { return _IDVenta; }
            set { _IDVenta = value; }
        }

        private string _IDVentaDetalle;
        public string IDVentaDetalle
        {
            get { return _IDVentaDetalle; }
            set { _IDVentaDetalle = value; }
        }

        private string _IDVendedor;
        public string IDVendedor
        {
            get { return _IDVendedor; }
            set { _IDVendedor = value; }
        }

        private string _Observacion;
        public string Observacion
        {
            get { return _Observacion; }
            set { _Observacion = value; }
        }

        private string _IDCaja;
        public string IDCaja
        {
            get { return _IDCaja; }
            set { _IDCaja = value; }
        }

        private string _IDSucursal;
        public string IDSucursal
        {
            get { return _IDSucursal; }
            set { _IDSucursal = value; }
        }

        private int _IDTipoPago;
        public int IDTipoPago
        {
            get { return _IDTipoPago; }
            set { _IDTipoPago = value; }
        }

        private int _IDStatusCobro;
        public int IDStatusCobro
        {
            get { return _IDStatusCobro; }
            set { _IDStatusCobro = value; }
        }

        private float _pagoEfectivo;
        public float pagoEfectivo
        {
            get { return _pagoEfectivo; }
            set { _pagoEfectivo = value; }
        }

        private float _pagoMonedero;
        public float pagoMonedero
        {
            get { return _pagoMonedero; }
            set { _pagoMonedero = value; }
        }

        private float _pagoTarjeta;
        public float pagoTarjeta
        {
            get { return _pagoTarjeta; }
            set { _pagoTarjeta = value; }
        }

        private DataTable _DatosTarjeta;
        public DataTable DatosTarjeta
        {
            get { return _DatosTarjeta; }
            set { _DatosTarjeta = value; }
        }

        private float _pagoTransferencia;
        public float pagoTransferencia
        {
            get { return _pagoTransferencia; }
            set { _pagoTransferencia = value; }
        }

        private DataTable _DatosTransferencia;
        public DataTable DatosTransferencia
        {
            get { return _DatosTransferencia; }
            set { _DatosTransferencia = value; }
        }
    }
}
