using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class CambioCamion
    {
/******************************************************  Inicio Propiedades CambioCamion *********************************************************/
        private string _IDViajeViejo;
        public string IDViajeViejo
        {
            get { return _IDViajeViejo; }
            set { _IDViajeViejo = value; }
        }
        private string _IDViajeNuevo;
        public string IDViajeNuevo
        {
            get { return _IDViajeNuevo; }
            set { _IDViajeNuevo = value; }
        }
        private string _NombreViaje;
        public string NombreViaje
        {
            get { return _NombreViaje; }
            set { _NombreViaje = value; }
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
        private int _Asientos;
        public int Asientos
        {
            get { return _Asientos; }
            set { _Asientos = value; }
        }
        private int _AsientosOcupados;
        public int AsientosOcupados
        {
            get { return _AsientosOcupados; }
            set { _AsientosOcupados = value; }
        }
        private string _IDDisenioCamion;
        public string IDDisenioCamion
        {
            get { return _IDDisenioCamion; }
            set { _IDDisenioCamion = value; }
        }
        private string _IDRuta;
        public string IDRuta
        {
            get { return _IDRuta; }
            set { _IDRuta = value; }
        }
        private string _Ruta;
        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }
        private string _Camion;
        public string Camion
        {
            get { return _Camion; }
            set { _Camion = value; }
        }
        private int _IDTipoCamion;
        public int IDTipoCamion
        {
            get { return _IDTipoCamion; }
            set { _IDTipoCamion = value; }
        }

/******************************************************  Fin Propiedades CambioCamion *********************************************************/


/******************************************************  Inicio Lista Viaje Viejo*********************************************************/

        private List<CambioCamion> _lista_ViajeViejo;
        public List<CambioCamion> lista_ViajeViejo
        {
            get { return _lista_ViajeViejo; }
            set { _lista_ViajeViejo = value; }
        }
/******************************************************  Fin Lista Viaje Viejo *********************************************************/


/******************************************************  Inicio Lista Viaje Nuevo*********************************************************/

        private List<CambioCamion> _lista_ViajeNuevo;
        public List<CambioCamion> lista_ViajeNuevo
        {
            get { return _lista_ViajeNuevo; }
            set { _lista_ViajeNuevo = value; }
        }
/******************************************************  Fin Lista Viaje Nuevo *********************************************************/

        private DataTable _lista_BoletosCambio;
        public DataTable lista_BoletosCambio
        {
            get { return _lista_BoletosCambio; }
            set { _lista_BoletosCambio = value; }
        }

        private string _IDTarifa;
        public string IDTarifa
        {
            get { return _IDTarifa; }
            set { _IDTarifa = value; }
        }

    }
}
