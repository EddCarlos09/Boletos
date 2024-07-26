using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class DatosFacturaEmisor
    {
        public DatosFacturaEmisor(string cadena)
        {
            this.strcnx = cadena;
        }
        private string _strcnx;
        public string strcnx
        {
            get { return _strcnx; }
            set { _strcnx = value; }
        }

        private string _idDatosEmisor;
        public string idDatosEmisor
        {
            get { return _idDatosEmisor; }
            set { _idDatosEmisor = value; }
        }

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
        private string _cp;
        public string cp
        {
            get { return _cp; }
            set { _cp = value; }
        }
        private string _correo;
        public string correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        private string _noCertificado;
        public string noCertificado
        {
            get { return _noCertificado;}
            set { _noCertificado = value; }
        }

        private string _archivoCer;
        public string archivoCer
        {
            get { return _archivoCer; }
            set { _archivoCer = value; }
        }
        private string _archivoKey;
        public string archivoKey
        {
            get { return _archivoKey; }
            set { _archivoKey = value; }
        }

        private byte[] _passwordKey;
        public byte[] passwordKey
        {
            get { return _passwordKey; }
            set { _passwordKey = value; }
        }
        private byte[] _salt;
        public byte[] salt
        {
            get { return _salt; }
            set { _salt = value; }
        }
        private DateTime _fecins;
        public DateTime fecins
        {
            get { return _fecins; }
            set { _fecins = value; }
        }

        private string _usuins;
        public string usuins
        {
            get { return _usuins; }
            set { _usuins = value; }
        }
    }
}
