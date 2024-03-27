using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Ruta
    {
        public Ruta(string conexion)
        {
            this.strcnx = conexion;
            this.rutas_intermedias = new List<Ruta>();
            this.listasubrutas_eliminadas = new List<Ruta>();
        }

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

        private string _id_ruta;

        public string id_ruta
        {
            get { return _id_ruta; }
            set { _id_ruta = value; }
        }

        private string _id_terminalOrigen;

        public string id_terminalOrigen
        {
            get { return _id_terminalOrigen; }
            set { _id_terminalOrigen = value; }
        }

        private string _id_terminalDestino;

        public string id_terminalDestino
        {
            get { return _id_terminalDestino; }
            set { _id_terminalDestino = value; }
        }

        private List<Terminal> _lista_terminales;

        public List<Terminal> lista_terminales
        {
            get { return _lista_terminales; }
            set { _lista_terminales = value; }
        }

        private int _tiempo_minutos;

        public int tiempo_minutos
        {
            get { return _tiempo_minutos; }
            set { _tiempo_minutos = value; }
        }

        private string _tiempo;

        public string tiempo
        {
            get { return _tiempo; }
            set { _tiempo = value; }
        }

        private int _id_tipoTerminal;

        public int id_tipoTerminal
        {
            get { return _id_tipoTerminal; }
            set { _id_tipoTerminal = value; }
        }

        private DataTable _dataTable_terminalesintermedias;

        public DataTable dataTable_terminalesintermedias
        {
            get { return _dataTable_terminalesintermedias; }
            set { _dataTable_terminalesintermedias = value; }
        }

        private List<Ruta> _rutas_intermedias;

        public List<Ruta> rutas_intermedias
        {
            get { return _rutas_intermedias; }
            set { _rutas_intermedias = value; }
        }

        private string _id_terminalAux;

        public string id_terminalAux
        {
            get { return _id_terminalAux; }
            set { _id_terminalAux = value; }
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

        private int _nuevo;

        public int nuevo
        {
            get { return _nuevo; }
            set { _nuevo = value; }
        }

        private string _id_rutaPadre;

        public string id_rutaPadre
        {
            get { return _id_rutaPadre; }
            set { _id_rutaPadre = value; }
        }

        private List<Ruta> _listasubrutas_eliminadas;

        public List<Ruta> listasubrutas_eliminadas
        {
            get { return _listasubrutas_eliminadas; }
            set { _listasubrutas_eliminadas = value; }
        }

        private string _nombreRuta;

        public string nombreRuta
        {
            get { return _nombreRuta; }
            set { _nombreRuta = value; }
        }

        private List<Ruta> _comborutas;

        public List<Ruta> comborutas
        {
            get { return _comborutas; }
            set { _comborutas = value; }
        }
        private int _indice;

        public int indice
        {
            get { return _indice; }
            set { _indice = value; }
        }

        /// <summary>
        /// /////////////////////////Cambio Viaje
        /// </summary>
        private int _asientosOcupados;
        public int asientosOcupados
        {
            get { return _asientosOcupados; }
            set { _asientosOcupados = value; }
        }

        private string _id_viaje;
        public string id_viaje
        {
            get { return _id_viaje; }
            set { _id_viaje = value; }
        }

        private DateTime _fehcha_viaje;
        public DateTime fehcha_viaje
        {
            get { return _fehcha_viaje; }
            set { _fehcha_viaje = value; }
        }

        private string _hora_viaje;
        public string hora_viaje
        {
            get { return _hora_viaje; }
            set { _hora_viaje = value; }
        }

        private List<Ruta> _rutas_viajes1;
        public List<Ruta> rutas_viajes1
        {
            get { return _rutas_viajes1; }
            set { _rutas_viajes1 = value; }
        }

        private List<Ruta> _rutas_viajes2;
        public List<Ruta> rutas_viajes2
        {
            get { return _rutas_viajes2; }
            set { _rutas_viajes2 = value; }
        }

        private int _ordenOrigen;
        public int ordenOrigen
        {
            get { return _ordenOrigen; }
            set { _ordenOrigen = value; }
        }
        private int _ordenDestino;
        public int ordenDestino
        {
            get { return _ordenDestino; }
            set { _ordenDestino = value; }
        }
    }
}
