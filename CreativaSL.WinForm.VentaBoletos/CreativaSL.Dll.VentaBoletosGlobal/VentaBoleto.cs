using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class VentaBoleto
    {

/******************************************************  Inicio Datos Generales VentaBoletos *********************************************************/

        private string _id_venta;
        private int _CantidadDatos;
        private float _PrecioDatos;
        private float _ImpuestosDatos;
        private float _SubtotalDatos;
        private float _DescuentosDatos;
        private float _TotalDatos;
        private float _AnticipoDatos;
        private float _CobroExtraDatos;

        
        public string id_venta
        {
            get { return _id_venta; }
            set { _id_venta = value; }
        }
        public int CantidadDatos
        {
            get { return _CantidadDatos; }
            set { _CantidadDatos = value; }
        }
        public float PrecioDatos
        {
            get { return _PrecioDatos; }
            set { _PrecioDatos = value; }
        }
        public float ImpuestosDatos
        {
            get { return _ImpuestosDatos; }
            set { _ImpuestosDatos = value; }
        }
        public float SubtotalDatos
        {
            get { return _SubtotalDatos; }
            set { _SubtotalDatos = value; }
        }
        public float DescuentosDatos
        {
            get { return _DescuentosDatos; }
            set { _DescuentosDatos = value; }
        }
        public float TotalDatos
        {
            get { return _TotalDatos; }
            set { _TotalDatos = value; }
        }
        public float AnticipoDatos
        {
            get { return _AnticipoDatos; }
            set { _AnticipoDatos = value; }
        }
        public float CobroExtraDatos
        {
            get { return _CobroExtraDatos; }
            set { _CobroExtraDatos = value; }
        }



/******************************************************  Fin Datos Generales VentaBoletos *********************************************************/

/******************************************************  Inicio Datos VentaBoletos *********************************************************/

        private string _id_sucursal;
        private int _id_tipoVenta;
        private string _id_cliente;
        private string _id_caja;
        private string _id_vendedor;
        private float _subtotal;
        private float _descuento;
        private float _iva;
        private float _total;
        private float _pago;
        private float _pagoEfectivo;
        private float _pagoMonedero;
        private float _pagoTarjeta;
        private float _pagoTransferencia;
        private float _cambio;
        private int _estatus;
        private float _pendiente;
        private float _pagototal;
        private float _id_statusboletosventa;
        private int _id_formaPago;
        private string _ObservacionPago;
        private float _Monedero;
        private float _NuevoMonedero;


        public string id_sucursal
        {
            get { return _id_sucursal; }
            set { _id_sucursal = value; }
        }
        public int id_tipoVenta
        {
            get { return _id_tipoVenta; }
            set { _id_tipoVenta = value; }
        }
        public string id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }
        public string id_caja
        {
            get { return _id_caja; }
            set { _id_caja = value; }
        }
        public string id_vendedor
        {
            get { return _id_vendedor; }
            set { _id_vendedor = value; }
        }
        public float subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }
        public float descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }
        public float iva
        {
            get { return _iva; }
            set { _iva = value; }
        }
        public float total
        {
            get { return _total; }
            set { _total = value; }
        }
        public float pago
        {
            get { return _pago; }
            set { _pago = value; }
        }
        public float pagoEfectivo
        {
            get { return _pagoEfectivo; }
            set { _pagoEfectivo = value; }
        }
        public float pagoMonedero
        {
            get { return _pagoMonedero; }
            set { _pagoMonedero = value; }
        }
        public float pagoTarjeta
        {
            get { return _pagoTarjeta; }
            set { _pagoTarjeta = value; }
        }
        public float PagoTransferencia
        {
            get { return _pagoTransferencia; }
            set { _pagoTransferencia = value; }
        }
        public float cambio
        {
            get { return _cambio; }
            set { _cambio = value; }
        }
        public int estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }
        public float pendiente
        {
            get { return _pendiente; }
            set { _pendiente = value; }
        }
        public float pagototal
        {
            get { return _pagototal; }
            set { _pagototal = value; }
        }
        public float id_statusboletosventa
        {
            get { return _id_statusboletosventa; }
            set { _id_statusboletosventa = value; }
        }
        public int id_formaPago
        {
            get { return _id_formaPago; }
            set { _id_formaPago = value; }
        }
        public string ObservacionPago
        {
            get { return _ObservacionPago; }
            set { _ObservacionPago = value; }
        }
        public float Monedero
        {
            get { return _Monedero; }
            set { _Monedero = value; }
        }
        public float NuevoMonedero
        {
            get { return _NuevoMonedero; }
            set { _NuevoMonedero = value; }
        }

        

/******************************************************  Fin Datos VentaBoletos *********************************************************/

/******************************************************  Inicio Tabla BoletosDetalle *********************************************************/

        private DataTable _BoletosDetalle;
        public DataTable BoletosDetalle
        {
            get { return _BoletosDetalle; }
            set { _BoletosDetalle = value; }
        }

/******************************************************  Fin Tabla BoletosDetalle *********************************************************/

/******************************************************  Inicio Tabla BoletosDetalle *********************************************************/

        private DataTable _BoletosTransferencia;
        public DataTable BoletosTransferencia
        {
            get { return _BoletosTransferencia; }
            set { _BoletosTransferencia = value; }
        }

/******************************************************  Fin Tabla BoletosDetalle *********************************************************/

        private bool _ventaGrupal;
        public bool ventaGrupal
        {
            get { return _ventaGrupal; }
            set { _ventaGrupal = value; }
        }
        
        private BoletosGrupal _boletoGrupal;
	    public BoletosGrupal boletosGrupal
	    {
		    get { return _boletoGrupal;}
		    set { _boletoGrupal = value;}
	    }

        private int _tipo_cancelacion;
        public int tipo_cancelacion
        {
            get { return _tipo_cancelacion; }
            set { _tipo_cancelacion = value; }
        }

        private int _bloqueoCancelacionMonedero;
        public int bloqueoCancelacionMonedero
        {
            get { return _bloqueoCancelacionMonedero; }
            set { _bloqueoCancelacionMonedero = value; }
        }

        private int _bloqueoCancelacionPorFormaDePago;
        public int bloqueoCancelacionPorFormaDePago
        {
            get { return _bloqueoCancelacionPorFormaDePago; }
            set { _bloqueoCancelacionPorFormaDePago = value; }
        }

        private int _id_status;
        public int id_status
        {
            get { return _id_status; }
            set { _id_status = value; }
        }

/******************************************************  Fin Tabla BoletosDetalle *********************************************************/

        private DataTable _DatosTarjeta;
        public DataTable DatosTarjeta
        {
            get { return _DatosTarjeta; }
            set { _DatosTarjeta = value; }
        }

        private DataTable _DatosTransferencia;
        public DataTable DatosTransferencia
        {
            get { return _DatosTransferencia; }
            set { _DatosTransferencia = value; }
        }
        
    }
}
