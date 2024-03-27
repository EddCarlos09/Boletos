using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Asistencia
    {
        private string _id_viaje;
        public string id_viaje
        {
            get { return _id_viaje; }
            set { _id_viaje = value; }
        }

        private string _nombreViaje;
        public string nombreViaje
        {
            get { return _nombreViaje; }
            set { _nombreViaje = value; }
        }

        private DateTime _fechaViaje;
        public DateTime fechaViaje
        {
            get { return _fechaViaje; }
            set { _fechaViaje = value; }
        }

        private string _horaViaje;
        public string horaViaje
        {
            get { return _horaViaje; }
            set { _horaViaje = value; }
        }

        private string _folioBoleto;
        public string folioBoleto
        {
            get { return _folioBoleto; }
            set { _folioBoleto = value; }
        }
        
        private DataTable _datosViajes;
        public DataTable datosViajes
        {
            get { return _datosViajes; }
            set { _datosViajes = value; }
        }

        private DataTable _datosPasajeros;
        public DataTable datosPasajeros
        {
            get { return _datosPasajeros; }
            set { _datosPasajeros = value; }
        }
        
        
    }
}
