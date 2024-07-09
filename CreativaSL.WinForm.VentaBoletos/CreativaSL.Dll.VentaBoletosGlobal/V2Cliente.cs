using System;
using System.ComponentModel;
using System.Drawing;
namespace CreativaSL.Dll.VentaBoletosGlobal
{ 
    public class V2Cliente : INotifyPropertyChanged
    {

        public decimal PorentajePuntos { get; set; }
        public decimal SaldoRetenido { get; set; }
        public decimal SaldoDisponible { get; set; }
        public decimal Saldo { get; set; }

        public V2Cliente()
        {          
            
        }
        public bool _TieneCliente = false;
        private int _IDCliente;
        public int IDCliente
        {
            get { return _IDCliente; }
            set
            {
                if (_IDCliente == value) return;
                _IDCliente = value;
                OnPropertyChanged("IDCliente");
            }
        }
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (_Nombre == value) return;
                _Nombre = value;
                OnPropertyChanged("Nombre");
            }
        }
        private string _Domicilio;
        public string Domicilio
        {
            get { return _Domicilio; }
            set { _Domicilio = value; }
        }
        private string _Cruces;
        public string Cruces
        {
            get { return _Cruces; }
            set { _Cruces = value; }
        }
        private string _Colonia;
        public string Colonia
        {
            get { return _Colonia; }
            set { _Colonia = value; }
        }
        private string _CodigoPostal;
        public string CodigoPostal
        {
            get { return _CodigoPostal; }
            set { _CodigoPostal = value; }
        }
        private int _IDMunicipio;
        public int IDMunicipio
        {
            get { return _IDMunicipio; }
            set
            {
                if (_IDMunicipio == value) return;
                _IDMunicipio = value;
                OnPropertyChanged("IDMunicipio");
            }
        }
        private string _MunicipioDesc;
        public string MunicipioDesc
        {
            get { return _MunicipioDesc; }
            set { _MunicipioDesc = value; }
        }
        private int _IDEstado;
        public int IDEstado
        {
            get { return _IDEstado; }
            set
            {
                if (_IDEstado == value) return;
                _IDEstado = value;
                _IDMunicipio = 0;
                OnPropertyChanged("IDEstado");
            }
        }
        private string _EstadoDesc;
        public string EstadoDesc
        {
            get { return _EstadoDesc; }
            set { _EstadoDesc = value; }
        }
        private int _IDPais;
        public int IDPais
        {
            get { return _IDPais; }
            set { _IDPais = value; }
        }
        private string _PaisDesc;
        public string PaisDesc
        {
            get { return _PaisDesc; }
            set { _PaisDesc = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _RFC;
        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }
        private string _TelefonoCelular;
        public string TelefonoCelular
        {
            get { return _TelefonoCelular; }
            set { _TelefonoCelular = value; }
        }
        private string _Telefono;
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }
        public string FechaNacimientoS
        {
            get { return _FechaNacimiento != DateTime.MinValue ? _FechaNacimiento.ToString("dd/MM/yyyy") : string.Empty; }
        }
        private int _Clasificacion;
        public int Clasificacion
        {
            get { return _Clasificacion; }
            set { _Clasificacion = value; }
        }
        private string _ClasificacionDesc;
        public string ClasificacionDesc
        {
            get { return _ClasificacionDesc; }
            set { _ClasificacionDesc = value; }
            
        }
        private DateTime _FechaAlta;
        public DateTime FechaAlta
        {
            get { return _FechaAlta; }
            set { _FechaAlta = value; }
        }
        public string FechaAltaS
        {
            get { return _FechaAlta != DateTime.MinValue ? _FechaAlta.ToString("dd/MM/yyyy") : string.Empty; }
        }
        private string _CodigoTarjeta;
        public string CodigoTarjeta
        {
            get { return _CodigoTarjeta; }
            set { _CodigoTarjeta = value; }
        }
        private string _Empresa;
        public string Empresa
        {
            get { return _Empresa; }
            set { _Empresa = value; }
        }
        private string _ReferidoPor;
        public string ReferidoPor
        {
            get { return _ReferidoPor; }
            set { _ReferidoPor = value; }
        }

        private Image _FotoCliente;
        public Image FotoCliente
        {
            get { return Comun.Base64ToBitmap(ImagenBase64); }
            set
            {
                if (_FotoCliente == value) return;
                _FotoCliente = value;
                ImagenBase64 = Comun.BitmapToBase64String((Bitmap)_FotoCliente, Comun.GetImageFormat(_FotoCliente));
                OnPropertyChanged("FotoCliente");
            }
        }

        //Falta mandar a notificar al cliente
        private string ImagenBase64 { get; set; }
        //
        public string _ImagenBase64
        {
            get { return ImagenBase64; }
            set { ImagenBase64 = value; }
        }

        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
