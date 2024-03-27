using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Home
    {
/* *******************************************************   home   ****************************************************** */
        private string _IDBoleto;
        public string IDBoleto
        {
            get { return _IDBoleto; }
            set { _IDBoleto = value; }
        }

        string _NombreViaje;
        public string NombreViaje
        {
            get { return _NombreViaje; }
            set { _NombreViaje = value; }
        }
        string _IDViaje;
        public string IDViaje
        {
            get { return _IDViaje; }
            set { _IDViaje = value; }
        }

        private string _IDTarifa;
        public string IDTarifa
        {
            get { return _IDTarifa; }
            set { _IDTarifa = value; }
        }

        private int _IDTipoTarifa;
        public int IDTipoTarifa 
        {
            get { return _IDTipoTarifa; }
            set { _IDTipoTarifa = value; }
        }

        private string _NumCamion;
        public string NumCamion
        {
            get { return _NumCamion; }
            set { _NumCamion = value; }
        }

        private string _TipoLinea;
        public string TipoLinea
        {
            get { return _TipoLinea; }
            set { _TipoLinea = value; }
        }

        private int _Asiento;
        public int Asiento
        {
            get { return _Asiento; }
            set { _Asiento = value; }
        }

        private string _DescripcionIndice;
        public string DescripcionIndice
        {
            get { return _DescripcionIndice; }
            set { _DescripcionIndice = value; }
        }

        private string _IDCamionDiseño;
        public string IDCamionDiseño
        {
            get { return _IDCamionDiseño; }
            set { _IDCamionDiseño = value; }
        }

        private DateTime _FechaSalida;
        public DateTime FechaSalida
        {
            get { return _FechaSalida; }
            set { _FechaSalida = value; }
        }

        private string _HoraSalida;
        public string HoraSalida
        {
            get { return _HoraSalida; }
            set { _HoraSalida = value; }
        }

        private DateTime _FechaSalidaV;
        public DateTime FechaSalidaV
        {
            get { return _FechaSalidaV; }
            set { _FechaSalidaV = value; }
        }

        private string _HoraSalidaV;
        public string HoraSalidaV
        {
            get { return _HoraSalidaV; }
            set { _HoraSalidaV = value; }
        }

        private DateTime _FechaLLegadaV;
        public DateTime FechaLLegadaV
        {
            get { return _FechaLLegadaV; }
            set { _FechaLLegadaV = value; }
        }

        private string _HoraLlegadaV;
        public string HoraLlegadaV
        {
            get { return _HoraLlegadaV; }
            set { _HoraLlegadaV = value; }
        }

        private string _Origen;
        public string Origen
        {
            get { return _Origen; }
            set { _Origen = value; }
        }

        private string _Destino;
        public string Destino
        {
            get { return _Destino; }
            set { _Destino = value; }
        }

        private float _Precio;
        public float Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        private float _Descuentos;
        public float Descuentos
        {
            get { return _Descuentos; }
            set { _Descuentos = value; }
        }

        private int _TipoDescuento;
        public int TipoDescuento
        {
            get { return _TipoDescuento; }
            set { _TipoDescuento = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private float _precioNormal1;
        public float precioNormal1
        {
            get { return _precioNormal1; }
            set { _precioNormal1 = value; }
        }

        private float _precioInfantil1;
        public float precioInfantil1
        {
            get { return _precioInfantil1; }
            set { _precioInfantil1 = value; }
        }

        private float _precioTerceraEdad1;
        public float precioTerceraEdad1
        {
            get { return _precioTerceraEdad1; }
            set { _precioTerceraEdad1 = value; }
        }

        private float _precioEspecial1;
        public float precioEspecial1
        {
            get { return _precioEspecial1; }
            set { _precioEspecial1 = value; }
        }

        private float _precioNormal2;
        public float precioNormal2
        {
            get { return _precioNormal2; }
            set { _precioNormal2 = value; }
        }

        private float _precioInfantil2;
        public float precioInfantil2
        {
            get { return _precioInfantil2; }
            set { _precioInfantil2 = value; }
        }

        private float _precioTerceraEdad2;
        public float precioTerceraEdad2
        {
            get { return _precioTerceraEdad2; }
            set { _precioTerceraEdad2 = value; }
        }

        private float _precioEspecial2;
        public float precioEspecial2
        {
            get { return _precioEspecial2; }
            set { _precioEspecial2 = value; }
        }

        private int _TipoTerminal;
        public int TipoTerminal
        {
            get { return _TipoTerminal; }
            set { _TipoTerminal = value; }
        }

        private int _NumAsientos;
        public int NumAsientos
        {
            get { return _NumAsientos; }
            set { _NumAsientos = value; }
        }

        private int _NumAsientosDiponibles;
        public int NumAsientosDiponibles
        {
            get { return _NumAsientosDiponibles; }
            set { _NumAsientosDiponibles = value; }
        }

        private int _NumAsientosApartado;
        public int NumAsientosApartado
        {
            get { return _NumAsientosApartado; }
            set { _NumAsientosApartado = value; }
        }

        private string _Recorrido;
        public string Recorrido
        {
            get { return _Recorrido; }
            set { _Recorrido = value; }
        }

        private int _numPiso;
        public int numPiso
        {
            get { return _numPiso; }
            set { _numPiso = value; }
        }

        private int _IDStatus;
        public int IDStatus
        {
            get { return _IDStatus; }
            set { _IDStatus = value; }
        }

        private float _Anticipo;
        public float Anticipo
        {
            get { return _Anticipo; }
            set { _Anticipo = value; }
        }

        private string _IDBoletoTransferencia;
        public string IDBoletoTransferencia
        {
            get { return _IDBoletoTransferencia; }
            set { _IDBoletoTransferencia = value; }
        }


        private string _id_terminal;
        public string id_terminal
        {
            get { return _id_terminal; }
            set { _id_terminal = value; }
        }
        private string _terminal;
        public string terminal
        {
            get { return _terminal; }
            set { _terminal = value; }
        }

        private int _OrdenOrigen;
        public int OrdenOrigen
        {
            get { return _OrdenOrigen; }
            set { _OrdenOrigen = value; }
        }


        private int _OrdenDestino;
        public int OrdenDestino
        {
            get { return _OrdenDestino; }
            set { _OrdenDestino = value; }
        }

        private float _PagoExtra;
        public float PagoExtra
        {
            get { return _PagoExtra; }
            set { _PagoExtra = value; }
        }

        private string _id_tipoCamion;
        public string id_tipoCamion
        {
            get { return _id_tipoCamion; }
            set { _id_tipoCamion = value; }
        }

        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        private string _NumeroTelefono;
        public string NumeroTelefono
        {
            get { return _NumeroTelefono; }
            set { _NumeroTelefono = value; }
        }
        

 /*********************************************************  Fin  home *********************************************************/



/******************************************************  Inicio Lista Origen *********************************************************/

        private List<Home> _lista_Origen;
        public List<Home> lista_Origen
        {
            get { return _lista_Origen; }
            set { _lista_Origen = value; }
        }

 /******************************************************  Fin Lista Origen *********************************************************/


/******************************************************  Inicio Lista Destino *********************************************************/

        private List<Home> _lista_Destino;
        public List<Home> lista_Destino
        {
            get { return _lista_Destino; }
            set { _lista_Destino = value; }
        }

/******************************************************  Fin Lista Origen *********************************************************/

/******************************************************  Inicio Tabla Salidas *********************************************************/

        private DataTable _Salidas;
        public DataTable Salidas
        {
            get { return _Salidas; }
            set { _Salidas = value; }
        }

/******************************************************  Fin Tabla Salidas *********************************************************/

/******************************************************  Inicio Tabla DatosCamion *********************************************************/

        private DataTable _DatosCamion;
        public DataTable DatosCamion
        {
            get { return _DatosCamion; }
            set { _DatosCamion = value; }
        }

/******************************************************  Fin Tabla DatosCamion *********************************************************/



/******************************************************  Inicio Tabla Camion *********************************************************/

            private DataTable _Camiones;
            public DataTable Camiones
            {
                get { return _Camiones; }
                set { _Camiones = value; }
            }

/******************************************************  Fin Tabla Camion *********************************************************/

/******************************************************  Inicio Tabla VentaBoletos *********************************************************/

            private DataTable _VentaBoletos;
            public DataTable VentaBoletos
            {
                get { return _VentaBoletos; }
                set { _VentaBoletos = value; }
            }

        /******************************************************  Fin Tabla VentaBoletos *********************************************************/


        private string _codigoTarjeta;

        public string codigoTarjeta
        {
            get { return _codigoTarjeta; }
            set { _codigoTarjeta = value; }
        }


    }
}
