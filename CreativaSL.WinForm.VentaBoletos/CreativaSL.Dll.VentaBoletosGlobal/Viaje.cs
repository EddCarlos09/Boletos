using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Viaje
    {

        public Viaje(string conexion)
        {
            this.strcnx = conexion;
            this.listaHorarios = new List<Viaje>();
            this.listaHorariosElim = new List<Viaje>();
        }

        //****************** Datos generales ********************
        private string _strcnx;

        public string strcnx
        {
            get { return _strcnx; }
            set { _strcnx = value; }
        }

        private string _id_usuario;

        public string id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        private DataTable _datatable_viajes;

        public DataTable datatable_viajes
        {
            get { return _datatable_viajes; }
            set { _datatable_viajes = value; }
        }


        //****************** tbl_CatViajes ********************
        private string _id_viaje;

        public string id_viaje
        {
            get { return _id_viaje; }
            set { _id_viaje = value; }
        }

        private string _id_ruta;

        public string id_ruta
        {
            get { return _id_ruta; }
            set { _id_ruta = value; }
        }

        private string _id_camion;

        public string id_camion
        {
            get { return _id_camion; }
            set { _id_camion = value; }
        }

        private int _id_tipoViaje;

        public int id_tipoViaje
        {
            get { return _id_tipoViaje; }
            set { _id_tipoViaje = value; }
        }

        private DateTime _fec_PeriodoIni;

        public DateTime fec_PeriodoIni
        {
            get { return _fec_PeriodoIni; }
            set { _fec_PeriodoIni = value; }
        }

        private DateTime _fec_PeriodoFin;

        public DateTime fec_PeriodoFin
        {
            get { return _fec_PeriodoFin; }
            set { _fec_PeriodoFin = value; }
        }

        private bool _lunes;

        public bool lunes
        {
            get { return _lunes; }
            set { _lunes = value; }
        }

        private bool _martes;

        public bool martes
        {
            get { return _martes; }
            set { _martes = value; }
        }

        private bool _miercoles;

        public bool miercoles
        {
            get { return _miercoles; }
            set { _miercoles = value; }
        }

        private bool _jueves;

        public bool jueves
        {
            get { return _jueves; }
            set { _jueves = value; }
        }

        private bool _viernes;

        public bool viernes
        {
            get { return _viernes; }
            set { _viernes = value; }
        }

        private bool _sabado;

        public bool sabado
        {
            get { return _sabado; }
            set { _sabado = value; }
        }

        private bool _domingo;

        public bool domingo
        {
            get { return _domingo; }
            set { _domingo = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private List<Viaje> _comboViajes;

        public List<Viaje> comboViajes
        {
            get { return _comboViajes; }
            set { _comboViajes = value; }
        }

        //*********************   Horarios   *********************

        private string _id_horario;

        public string id_horario
        {
            get { return _id_horario; }
            set { _id_horario = value; }
        }

        private string _horario;

        public string horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

        private List<Viaje> _listaHorarios;

        public List<Viaje> listaHorarios
        {
            get { return _listaHorarios; }
            set { _listaHorarios = value; }
        }

        private List<Viaje> _listaHorariosElim;

        public List<Viaje> listaHorariosElim
        {
            get { return _listaHorariosElim; }
            set { _listaHorariosElim = value; }
        }

        private int _nuevo;

        public int nuevo
        {
            get { return _nuevo; }
            set { _nuevo = value; }
        }


        private string _IDViaje;
        public string IDViaje
        {
            get { return _IDViaje; }
            set { _IDViaje = value; }
        }
        private string _NombreViaje;
        public string NombreViaje
        {
            get { return _NombreViaje; }
            set { _NombreViaje = value; }
        }
        private DateTime _FechaV;
        public DateTime FechaV
        {
            get { return _FechaV; }
            set { _FechaV = value; }
        }
        private string _HoraV;
        public string HoraV
        {
            get { return _HoraV; }
            set { _HoraV = value; }
        }

        private DataTable _lista_BoletosCambio;
        public DataTable lista_BoletosCambio
        {
            get { return _lista_BoletosCambio; }
            set { _lista_BoletosCambio = value; }
        }

        private DataTable _lista_tarifasViaje;
        public DataTable lista_tarifasViaje
        {
            get { return _lista_tarifasViaje; }
            set { _lista_tarifasViaje = value; }
        }
    }
}
