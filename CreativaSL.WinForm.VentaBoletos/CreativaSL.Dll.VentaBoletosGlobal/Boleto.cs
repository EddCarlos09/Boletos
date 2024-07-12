using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Boleto
    {

        public Boleto(string cadena)
        {
            this.strcnx = cadena;
        }

        private string _strcnx;
        public string strcnx
        {
            get { return _strcnx; }
            set { _strcnx = value; }
        }

        private string _id_boleto;

        public string id_boleto
        {
            get { return _id_boleto; }
            set { _id_boleto = value; }
        }

        private int _tipo_cancelacion;

        public int tipo_cancelacion
        {
            get { return _tipo_cancelacion; }
            set { _tipo_cancelacion = value; }
        }

        private string _id_ventadetalle;

        public string id_ventadetalle
        {
            get { return _id_ventadetalle; }
            set { _id_ventadetalle = value; }
        }

        private int _id_status;

        public int id_status
        {
            get { return _id_status; }
            set { _id_status = value; }
        }


        private string _linea;

        public string lineaMarca
        {
            get { return _linea; }
            set { _linea = value; }
        }

        private string _servicio;

        public string servicio
        {
            get { return _servicio; }
            set { _servicio = value; }
        }

        private string _origen;

        public string origen
        {
            get { return _origen; }
            set { _origen = value; }
        }

        private string _terminalSalida;

        public string terminalSalida
        {
            get { return _terminalSalida; }
            set { _terminalSalida = value; }
        }

        private string _destino;

        public string destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        private string _terminalLlegada;

        public string terminalLlegada
        {
            get { return _terminalLlegada; }
            set { _terminalLlegada = value; }
        }

        private DateTime _fechaSalida;

        public DateTime fechaSalida
        {
            get { return _fechaSalida; }
            set { _fechaSalida = value; }
        }

        private string _corrida;

        public string corrida
        {
            get { return _corrida; }
            set { _corrida = value; }
        }

        private int _asiento;

        public int asiento
        {
            get { return _asiento; }
            set { _asiento = value; }
        }

        private int _cantidadVenta; 
        public int cantidadVenta
        {
            get { return _cantidadVenta; }
            set { _cantidadVenta = value; }
        }
        private string _horaSalida;

        public string horaSalida
        {
            get { return _horaSalida; }
            set { _horaSalida = value; }
        }

        private float _precioIva;

        public float precioIva
        {
            get { return _precioIva; }
            set { _precioIva = value; }
        }

        private float _iva;

        public float iva
        {
            get { return _iva; }
            set { _iva = value; }
        }

        private string _folio;

        public string folio
        {
            get { return _folio; }
            set { _folio = value; }
        }

        private string _tipo;

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private string _formaPago;

        public string formaPago
        {
            get { return _formaPago; }
            set { _formaPago = value; }
        }

        private string _cliente_nombre;

        public string cliente_nombre
        {
            get { return _cliente_nombre; }
            set { _cliente_nombre = value; }
        }

        private float _descuento;

        public float descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        private float _total;

        public float total
        {
            get { return _total; }
            set { _total = value; }
        }

        private float _pago;

        public float pago
        {
            get { return _pago; }
            set { _pago = value; }
        }

        private float _pago1;

        public float pago1
        {
            get { return _pago1; }
            set { _pago1 = value; }
        }

        private float _pago2;

        public float pago2
        {
            get { return _pago2; }
            set { _pago2 = value; }
        }

        private float _pendiente;

        public float pendiente
        {
            get { return _pendiente; }
            set { _pendiente = value; }
        }

        private string _hora_venta;

        public string hora_venta
        {
            get { return _hora_venta; }
            set { _hora_venta = value; }
        }

        private DateTime _fecha_venta;

        public DateTime fecha_venta
        {
            get { return _fecha_venta; }
            set { _fecha_venta = value; }
        }

        private string _cajero;

        public string cajero
        {
            get { return _cajero; }
            set { _cajero = value; }
        }

        private string _fechahoraSalida;
        public string fechahoraSalida
        {
            get { return _fechahoraSalida; }
            set { _fechahoraSalida = value; }
        }

        private string _estadoBoleto;
        public string estadoBoleto
        {
            get { return _estadoBoleto; }
            set { _estadoBoleto = value; }
        }

        private string _VentaUsuario;
        public string VentaUsuario
        {
            get { return _VentaUsuario; }
            set { _VentaUsuario = value; }
        }

        private string _VentaFechaHora;
        public string VentaFechaHora
        {
            get { return _VentaFechaHora; }
            set { _VentaFechaHora = value; }
        }

        private string _ApartadoUsuario;
        public string ApartadoUsuario
        {
            get { return _ApartadoUsuario; }
            set { _ApartadoUsuario = value; }
        }

        private string _ApartadoFechaHora;
        public string ApartadoFechaHora
        {
            get { return _ApartadoFechaHora; }
            set { _ApartadoFechaHora = value; }
        }

        private string _AnticipoPaso1Usuario;
        public string AnticipoPaso1Usuario
        {
            get { return _AnticipoPaso1Usuario; }
            set { _AnticipoPaso1Usuario = value; }
        }
        private string _AnticipoPaso1FechaHora;
        public string AnticipoPaso1FechaHora
        {
            get { return _AnticipoPaso1FechaHora; }
            set { _AnticipoPaso1FechaHora = value; }
        }

        private string _AnticipoPaso2Usuario;
        public string AnticipoPaso2Usuario
        {
            get { return _AnticipoPaso2Usuario; }
            set { _AnticipoPaso2Usuario = value; }
        }
        private string _AnticipoPaso2FechaHora;
        public string AnticipoPaso2FechaHora
        {
            get { return _AnticipoPaso2FechaHora; }
            set { _AnticipoPaso2FechaHora = value; }
        }

        private string _TransferenciaUsuario;
        public string TransferenciaUsuario
        {
            get { return _TransferenciaUsuario; }
            set { _TransferenciaUsuario = value; }
        }
        private string _TransferenciaFechaHora;
        public string TransferenciaFechaHora
        {
            get { return _TransferenciaFechaHora; }
            set { _TransferenciaFechaHora = value; }
        }

        private string _CancelacionUsuario;
        public string CancelacionUsuario
        {
            get { return _CancelacionUsuario; }
            set { _CancelacionUsuario = value; }
        }
        private string _CancelacionFechaHora;
        public string CancelacionFechaHora
        {
            get { return _CancelacionFechaHora; }
            set { _CancelacionFechaHora = value; }
        }

        private string _id_maleta;
        public string id_maleta
        {
            get { return _CancelacionFechaHora; }
            set { _CancelacionFechaHora = value; }
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

        private List<Boleto> _lstBoletos_viajes1;
        public List<Boleto> lstBoletos_viajes1
        {
            get { return _lstBoletos_viajes1; }
            set { _lstBoletos_viajes1 = value; }
        }

        private List<Boleto> _lstBoletos_viajes2;
        public List<Boleto> lstBoletos_viajes2
        {
            get { return _lstBoletos_viajes2; }
            set { _lstBoletos_viajes2 = value; }
        }
        ///////Cambio Camion
        private string _id_terminalXruta;
        public string id_terminalXruta
        {
            get { return _id_terminalXruta; }
            set { _id_terminalXruta = value; }
        }

        private string _id_ruta;
        public string id_ruta
        {
            get { return _id_ruta; }
            set { _id_ruta = value; }
        }

        private string _id_terminalSalida;
        public string id_terminalSalida
        {
            get { return _id_terminalSalida; }
            set { _id_terminalSalida = value; }
        }

        private string _id_terminalDestino;
        public string id_terminalDestino
        {
            get { return _id_terminalDestino; }
            set { _id_terminalDestino = value; }
        }

        private string _id_disenioDatos;
        public string id_disenioDatos
        {
            get { return _id_disenioDatos; }
            set { _id_disenioDatos = value; }
        }

        private string _id_tarfifa;
        public string id_tarfifa
        {
            get { return _id_tarfifa; }
            set { _id_tarfifa = value; }
        }
        private DateTime _fechaNacimientoV;
        public DateTime fechaNacimientoV
        {
            get { return _fechaNacimientoV; }
            set { _fechaNacimientoV = value; }
        }
        private string _numeroTelefono;
        public string numeroTelefono
        {
            get { return _numeroTelefono; }
            set { _numeroTelefono = value; }
        }
        private string _fechaNacimiento;
        public string fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private float _Subtotal;

        public float Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }

        private float _porcIva;

        public float porcIva
        {
            get { return _porcIva; }
            set { _porcIva = value; }
        }
        private decimal _PagoEfectivo;
        public decimal PagoEfectivo
        {
            get { return _PagoEfectivo; }
            set { _PagoEfectivo = value; }
        }
        private decimal _PagoMonedero;
        public decimal PagoMonedero
        {
            get { return _PagoMonedero; }
            set { _PagoMonedero = value; }
        }
        private decimal _PagoTarjeta;
        public decimal PagoTarjeta
        {
            get { return _PagoTarjeta; }
            set { _PagoTarjeta = value; }
        }
        private decimal _PagoTransferencia;
        public decimal PagoTransferencia
        {
            get { return _PagoTransferencia; }
            set { _PagoTransferencia = value; }
        }
        private string _id_caja;
        public string id_caja
        {
            get { return _id_caja; }
            set { _id_caja = value; }
        }

        private string _asientoText;
        public string asientoText
        {
            get { return _asientoText; }
            set { _asientoText = value; }
        }

        public int bloqueoTransferencia24Horas { get; set; }
    }
}
