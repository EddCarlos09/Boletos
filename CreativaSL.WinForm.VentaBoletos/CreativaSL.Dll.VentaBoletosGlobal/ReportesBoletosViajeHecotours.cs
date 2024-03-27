using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class ReportesBoletosViajeHecotours
    {
        private string _IDViaje;
        public string IDViaje
        {
            get { return _IDViaje; }
            set { _IDViaje = value; }
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

        private string _NombreViaje;
        public string NombreViaje
        {
            get { return _NombreViaje; }
            set { _NombreViaje = value; }
        }
        private string _id_datosViaje;
        public string id_datosViaje
        {
            get { return _id_datosViaje; }
            set { _id_datosViaje = value; }
        }
        
        #region PrestacionServicios1
        private string _id_prestacionServicios1;
        public string id_prestacionServicios1
        {
            get { return _id_prestacionServicios1; }
            set { _id_prestacionServicios1 = value; }
        }

        private string _folio_prestacionServicios1;
        public string folio_prestacionServicios1
        {
            get { return _folio_prestacionServicios1; }
            set { _folio_prestacionServicios1 = value; }
        }

        private string _id_chofer1_prestacionServicios1;
        public string id_chofer1_prestacionServicios1
        {
            get { return _id_chofer1_prestacionServicios1; }
            set { _id_chofer1_prestacionServicios1 = value; }
        }

        private string _chofer1_prestacionServicios1;
        public string chofer1_prestacionServicios1
        {
            get { return _chofer1_prestacionServicios1; }
            set { _chofer1_prestacionServicios1 = value; }
        }

        private string _id_chofer2_prestacionServicios1;
        public string id_chofer2_prestacionServicios1
        {
            get { return _id_chofer2_prestacionServicios1; }
            set { _id_chofer2_prestacionServicios1 = value; }
        }

        private string _chofer2_prestacionServicios1;
        public string chofer2_prestacionServicios1
        {
            get { return _chofer2_prestacionServicios1; }
            set { _chofer2_prestacionServicios1 = value; }
        }

        private string _autobus_prestacionServicios1;
        public string autobus_prestacionServicios1
        {
            get { return _autobus_prestacionServicios1; }
            set { _autobus_prestacionServicios1 = value; }
        }

        private DateTime _fecha_salida_prestacionServicios1;
        public DateTime fecha_salida_prestacionServicios1
        {
            get { return _fecha_salida_prestacionServicios1; }
            set { _fecha_salida_prestacionServicios1 = value; }
        }

        private string _hora_salida_prestacionServicios1;
        public string hora_salida_prestacionServicios1
        {
            get { return _hora_salida_prestacionServicios1; }
            set { _hora_salida_prestacionServicios1 = value; }
        }

        private string _solicitado_por_prestacionServicios1;
        public string solicitado_por_prestacionServicios1
        {
            get { return _solicitado_por_prestacionServicios1; }
            set { _solicitado_por_prestacionServicios1 = value; }
        }

        private int _grupo_prestacionServicios1;
        public int grupo_prestacionServicios1
        {
            get { return _grupo_prestacionServicios1; }
            set { _grupo_prestacionServicios1 = value; }
        }

        private string _servicio_prestacionServicios1;
        public string servicio_prestacionServicios1
        {
            get { return _servicio_prestacionServicios1; }
            set { _servicio_prestacionServicios1 = value; }
        }

        private string _presentarse_en_prestacionServicios1;
        public string presentarse_en_prestacionServicios1
        {
            get { return _presentarse_en_prestacionServicios1; }
            set { _presentarse_en_prestacionServicios1 = value; }
        }

        private string _instrucciones_prestacionServicios1;
        public string instrucciones_prestacionServicios1
        {
            get { return _instrucciones_prestacionServicios1; }
            set { _instrucciones_prestacionServicios1 = value; }
        }

        private string _observaciones_prestacionServicios1;
        public string observaciones_prestacionServicios1
        {
            get { return _observaciones_prestacionServicios1; }
            set { _observaciones_prestacionServicios1 = value; }
        }
        #endregion
        #region PrestacionServicios2
        private string _id_prestacionServicios2;
        public string id_prestacionServicios2
        {
            get { return _id_prestacionServicios2; }
            set { _id_prestacionServicios2 = value; }
        }

        private string _folio_prestacionServicios2;
        public string folio_prestacionServicios2
        {
            get { return _folio_prestacionServicios2; }
            set { _folio_prestacionServicios2 = value; }
        }

        private string _solicitado_por_prestacionServicios2;
        public string solicitado_por_prestacionServicios2
        {
            get { return _solicitado_por_prestacionServicios2; }
            set { _solicitado_por_prestacionServicios2 = value; }
        }

        private string _poliza_prestacionServicios2;
        public string poliza_prestacionServicios2
        {
            get { return _poliza_prestacionServicios2; }
            set { _poliza_prestacionServicios2 = value; }
        }

        private DateTime _poliza_fecha1_prestacionServicios2;
        public DateTime poliza_fecha1_prestacionServicios2
        {
            get { return _poliza_fecha1_prestacionServicios2; }
            set { _poliza_fecha1_prestacionServicios2 = value; }
        }

        private DateTime _poliza_fecha2_prestacionServicios2;
        public DateTime poliza_fecha2_prestacionServicios2
        {
            get { return _poliza_fecha2_prestacionServicios2; }
            set { _poliza_fecha2_prestacionServicios2 = value; }
        }

        private string _credencial_elector_prestacionServicios2;
        public string credencial_elector_prestacionServicios2
        {
            get { return _credencial_elector_prestacionServicios2; }
            set { _credencial_elector_prestacionServicios2 = value; }
        }

        private string _domicilio_prestacionServicios2;
        public string domicilio_prestacionServicios2
        {
            get { return _domicilio_prestacionServicios2; }
            set { _domicilio_prestacionServicios2 = value; }
        }

        private string _origen_prestacionServicios2;
        public string origen_prestacionServicios2
        {
            get { return _origen_prestacionServicios2; }
            set { _origen_prestacionServicios2 = value; }
        }

        private string _destino_prestacionServicios2;
        public string destino_prestacionServicios2
        {
            get { return _destino_prestacionServicios2; }
            set { _destino_prestacionServicios2 = value; }
        }

        private float _monto_servicio_prestacionServicios2;
        public float monto_servicio_prestacionServicios2
        {
            get { return _monto_servicio_prestacionServicios2; }
            set { _monto_servicio_prestacionServicios2 = value; }
        }

        private string _monto_servicio_texto_prestacionServicios2;
        public string monto_servicio_texto_prestacionServicios2
        {
            get { return _monto_servicio_texto_prestacionServicios2; }
            set { _monto_servicio_texto_prestacionServicios2 = value; }
        }

        private string _lugar_salida_prestacionServicios2;
        public string lugar_salida_prestacionServicios2
        {
            get { return _lugar_salida_prestacionServicios2; }
            set { _lugar_salida_prestacionServicios2 = value; }
        }

        private DateTime _fecha_salida_prestacionServicios2;
        public DateTime fecha_salida_prestacionServicios2
        {
            get { return _fecha_salida_prestacionServicios2; }
            set { _fecha_salida_prestacionServicios2 = value; }
        }

        private string _hora_salida_prestacionServicios2;
        public string hora_salida_prestacionServicios2
        {
            get { return _hora_salida_prestacionServicios2; }
            set { _hora_salida_prestacionServicios2 = value; }
        }

        private int _numero_personas_prestacionServicios2;
        public int numero_personas_prestacionServicios2
        {
            get { return _numero_personas_prestacionServicios2; }
            set { _numero_personas_prestacionServicios2 = value; }
        }

        private string _id_chofer1_prestacionServicios2;
        public string id_chofer1_prestacionServicios2
        {
            get { return _id_chofer1_prestacionServicios2; }
            set { _id_chofer1_prestacionServicios2 = value; }
        }

        private string _chofer1_prestacionServicios2;
        public string chofer1_prestacionServicios2
        {
            get { return _chofer1_prestacionServicios2; }
            set { _chofer1_prestacionServicios2 = value; }
        }

        private string _id_chofer2_prestacionServicios2;
        public string id_chofer2_prestacionServicios2
        {
            get { return _id_chofer2_prestacionServicios2; }
            set { _id_chofer2_prestacionServicios2 = value; }
        }

        private string _chofer2_prestacionServicios2;
        public string chofer2_prestacionServicios2
        {
            get { return _chofer2_prestacionServicios2; }
            set { _chofer2_prestacionServicios2 = value; }
        }

        private string _numero_placa_prestacionServicios2;
        public string numero_placa_prestacionServicios2
        {
            get { return _numero_placa_prestacionServicios2; }
            set { _numero_placa_prestacionServicios2 = value; }
        }

        private string _ruta_contratada_prestacionServicios2;
        public string ruta_contratada_prestacionServicios2
        {
            get { return _ruta_contratada_prestacionServicios2; }
            set { _ruta_contratada_prestacionServicios2 = value; }
        }

        private int _dias_viaje_prestacionServicios2;
        public int dias_viaje_prestacionServicios2
        {
            get { return _dias_viaje_prestacionServicios2; }
            set { _dias_viaje_prestacionServicios2 = value; }
        }

        private string _dia_hora_salida_prestacionServicios2;
        public string dia_hora_salida_prestacionServicios2
        {
            get { return _dia_hora_salida_prestacionServicios2; }
            set { _dia_hora_salida_prestacionServicios2 = value; }
        }
        #endregion
        #region ListaPasajeros
        private string _id_listapasajeros;
        public string id_listapasajeros
        {
            get { return _id_listapasajeros; }
            set { _id_listapasajeros = value; }
        }

        private string _folio_listapasajeros;
        public string folio_listapasajeros
        {
            get { return _folio_listapasajeros; }
            set { _folio_listapasajeros = value; }
        }

        private string _oficina_listapasajeros;
        public string oficina_listapasajeros
        {
            get { return _oficina_listapasajeros; }
            set { _oficina_listapasajeros = value; }
        }

        private int _dia_listapasajeros;
        public int dia_listapasajeros
        {
            get { return _dia_listapasajeros; }
            set { _dia_listapasajeros = value; }
        }

        private int _mes_listapasajeros;
        public int mes_listapasajeros
        {
            get { return _mes_listapasajeros; }
            set { _mes_listapasajeros = value; }
        }

        private int _año_listapasajeros;
        public int año_listapasajeros
        {
            get { return _año_listapasajeros; }
            set { _año_listapasajeros = value; }
        }

        private string _carro_listapasajeros;
        public string carro_listapasajeros
        {
            get { return _carro_listapasajeros; }
            set { _carro_listapasajeros = value; }
        }

        private string _oficinista_listapasajeros;
        public string oficinista_listapasajeros
        {
            get { return _oficinista_listapasajeros; }
            set { _oficinista_listapasajeros = value; }
        }

        private string _hora_salida_listapasajeros;
        public string hora_salida_listapasajeros
        {
            get { return _hora_salida_listapasajeros; }
            set { _hora_salida_listapasajeros = value; }
        }
        #endregion



        private List<Chofer> _lstChoferes1_prestacionServicios1;
        public List<Chofer> lstChoferes1_prestacionServicios1
        {
            get { return _lstChoferes1_prestacionServicios1; }
            set { _lstChoferes1_prestacionServicios1 = value; }
        }

        private List<Chofer> _lstChoferes1_prestacionServicios2;
        public List<Chofer> lstChoferes1_prestacionServicios2
        {
            get { return _lstChoferes1_prestacionServicios2; }
            set { _lstChoferes1_prestacionServicios2 = value; }
        }

        private List<Chofer> _lstChoferes2_prestacionServicios1;
        public List<Chofer> lstChoferes2_prestacionServicios1
        {
            get { return _lstChoferes2_prestacionServicios1; }
            set { _lstChoferes2_prestacionServicios1 = value; }
        }

        private List<Chofer> _lstChoferes2_prestacionServicios2;
        public List<Chofer> lstChoferes2_prestacionServicios2
        {
            get { return _lstChoferes2_prestacionServicios2; }
            set { _lstChoferes2_prestacionServicios2 = value; }
        }

        private List<Viaje> _lista_Viaje;
        public List<Viaje> lista_Viaje
        {
            get { return _lista_Viaje; }
            set { _lista_Viaje = value; }
        }

        private DataTable _resultado;
        public DataTable resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }
    }
}
