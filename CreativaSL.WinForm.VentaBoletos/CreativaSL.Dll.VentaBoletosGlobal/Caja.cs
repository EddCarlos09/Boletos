using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Caja
    {

        private string _CadConexion;
        private int _M50C;
        private int _M1P;
        private int _M2P;
        private int _M5P;
        private int _M10P;
        private int _M20P;
        private int _M100P;
        private int _B20P;
        private int _B50P;
        private int _B100P;
        private int _B200P;
        private int _B500P;
        private int _B1000P;
        private float _Total;
        private string _FechaIngreso;
        private string _HoraIngreso;
        private string _Id_U;
        private string _id_caja;
        private int _tickets;
        private int _vales;
        private float _TotalVentas;
        private float _TotalVentasMaletas;
        private float _TotalEfectivo;
        private float _TotalMonedero;
        private float _TotalTarjeta;
        private float _TotalTransferencia;
        private float _TotalDepositos;
        private float _TotalRetiroCajaLlena;
        private float _TotalRetirosPagos;
        private string _id_producto;
        private string _observaciones;
        private string _id_sucursal;
        private string _id_cajaCat;
        private string _cajaCat;
        private string _cajaCatCompleto;
        private string _mac;
        private List<Caja> _listaCaja;
        private string _Cajero;
        private string _descripcion;
        private string _namePrinter;

        public string Cajero
        {
            get { return _Cajero; }
            set { _Cajero = value; }
        }
        public Caja(string cad)
        {
            _CadConexion = cad;
        }

        public string id_sucursal
        {
            get { return _id_sucursal; }
            set { _id_sucursal = value; }
        }

        public string CadConexion
        {
            get { return _CadConexion; }
        }

        public float TotalDepositos
        {
            get { return _TotalDepositos; }
            set { _TotalDepositos = value; }
        }

        public float TotalRetirosCajaLlena
        {
            get { return _TotalRetiroCajaLlena; }
            set { _TotalRetiroCajaLlena = value; }
        }

        public float TotalRetirosPagos
        {
            get { return _TotalRetirosPagos; }
            set { _TotalRetirosPagos = value; }
        }

        public float TotalVentas
        {
            get { return _TotalVentas; }
            set { _TotalVentas = value; }
        }
        public float TotalVentasMaletas
        {
            get { return _TotalVentasMaletas; }
            set { _TotalVentasMaletas = value; }
        }
        public float TotalEfectivo
        {
            get { return _TotalEfectivo; }
            set { _TotalEfectivo = value; }
        }
        public float TotalMonedero
        {
            get { return _TotalMonedero; }
            set { _TotalMonedero = value; }
        }
        public float TotalTarjeta
        {
            get { return _TotalTarjeta; }
            set { _TotalTarjeta = value; }
        }
        public float TotalTransferencia
        {
            get { return _TotalTransferencia; }
            set { _TotalTransferencia = value; }
        }
        public int M50C
        {
            get { return _M50C; }
            set { _M50C = value; }
        }

        public int M1P
        {
            get { return _M1P; }
            set { _M1P = value; }
        }

        public int M2P
        {
            get { return _M2P; }
            set { _M2P = value; }
        }

        public int M5P
        {
            get { return _M5P; }
            set { _M5P = value; }
        }

        public int M10P
        {
            get { return _M10P; }
            set { _M10P = value; }
        }

        public int M20P
        {
            get { return _M20P; }
            set { _M20P = value; }
        }

        public int M100P
        {
            get { return _M100P; }
            set { _M100P = value; }
        }

        public int B20P
        {
            get { return _B20P; }
            set { _B20P = value; }
        }

        public int B50P
        {
            get { return _B50P; }
            set { _B50P = value; }
        }

        public int B100P
        {
            get { return _B100P; }
            set { _B100P = value; }
        }

        public int B200P
        {
            get { return _B200P; }
            set { _B200P = value; }
        }

        public int B500P
        {
            get { return _B500P; }
            set { _B500P = value; }
        }

        public int B1000P
        {
            get { return _B1000P; }
            set { _B1000P = value; }
        }

        public float Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        public string FechaIngreso
        {
            get { return _FechaIngreso; }
            set { _FechaIngreso = value; }
        }

        public string HoraIngreso
        {
            get { return _HoraIngreso; }
            set { _HoraIngreso = value; }
        }

        public string Id_U
        {
            get { return _Id_U; }
            set { _Id_U = value; }
        }

        public string id_caja
        {
            get { return _id_caja; }
            set { _id_caja = value; }
        }

        public int tickets
        {
            get { return _tickets; }
            set { _tickets = value; }
        }

        public int vales
        {
            get { return _vales; }
            set { _vales = value; }
        }

        //Datos del inventario al momento de cerrar caja

        public string id_producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }

        public string observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
        public string id_cajaCat
        {
            get { return _id_cajaCat; }
            set { _id_cajaCat = value; }
        }
        public string cajaCat
        {
            get { return _cajaCat; }
            set { _cajaCat = value; }
        }
        public string cajaCatCompleto
        {
            get { return _cajaCatCompleto; }
            set { _cajaCatCompleto = value; }
        }
        public string mac
        {
            get { return _mac; }
            set { _mac = value; }
        }
        public List<Caja> listaCaja
        {
            get { return _listaCaja; }
            set { _listaCaja = value; }
        }
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public string namePrinter
        {
            get { return _namePrinter; }
            set { _namePrinter = value; }
        }
        private float _TotalBoletos;

        public float TotalBoletos
        {
            get { return _TotalBoletos; }
            set { _TotalBoletos = value; }
        }
    }
}
