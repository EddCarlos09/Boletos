using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class ReportesMaletasViaje
    {
        private string _razonSocial;
        public string razonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }
        private string _rfc;
        public string rfc
        {
            get { return _rfc; }
            set { _rfc = value; }
        }
        private string _folio;
        public string folio
        {
            get { return _folio; }
            set { _folio = value; }
        }
        private string _fechaReporte;
        public string fechaReporte
        {
            get { return _fechaReporte; }
            set { _fechaReporte = value; }
        }
        private string _chofer;
        public string chofer
        {
            get { return _chofer; }
            set { _chofer = value; }
        }
        private DateTime _fechaSalida;
        public DateTime fechaSalida
        {
            get { return _fechaSalida; }
            set { _fechaSalida = value; }
        }
        private string _origen;
        public string origen
        {
            get { return _origen; }
            set { _origen = value; }
        }
        private string _destino;
        public string destino
        {
            get { return _destino; }
            set { _destino = value; }
        }
        private string _observacion;
        public string observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }
        private string _IDChofer;
        public string IDChofer
        {
            get { return _IDChofer; }
            set { _IDChofer = value; }
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

        private List<Maletas> _lstMaletas;
        public List<Maletas> lstMaletas
        {
            get { return _lstMaletas; }
            set { _lstMaletas = value; }
        }

        private List<Chofer> _lstChoferes;
        public List<Chofer> lstChoferes
        {
            get { return _lstChoferes; }
            set { _lstChoferes = value; }
        }
        private string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _path;
        public string path
        {
            get { return _path; }
            set { _path = value; }
        }


    }
}
