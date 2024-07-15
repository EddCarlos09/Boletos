using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Facturas
    {
        #region propiedades factura
        public int _id;
        public int _id_cliente;
        public string _serie;
        public string _folio;
        public string _uuid_factura;
        public DateTime _fecha_emision;
        public string _no_certificado;
        public string _forma_pago;
        public string _condiciones_pago;
        public float _subtotal;
        public string _moneda;
        public string _tipo_cambio;
        public float _totalFactura;
        public string _tipo_comprobante;
        public string _exportacion;
        public string _metodo_pago;
        public string _lugar_expedicion;
        public string _rfc_emisor;
        public string _nombre_emisor;
        public string _regimen_fiscal_emisor;
        public string _rfc_receptor;
        public string _nombre_receptor;
        public string _domicilio_fiscal_receptor;
        public string _RegimenFiscalReceptor;
        public string _uso_cfdi;
        public string _codigoBarra;
        public string _xmlFactura; 
        private DateTime _fecins;
        private string _usuins;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }
        public string serie
        {
            get { return _serie; }
            set { _serie = value; }
        }

        public string folio
        {
            get { return _folio; }
            set { _folio = value; }
        }
        public string uuid_factura
        {
            get { return _uuid_factura; }
            set { _uuid_factura = value;}
        }
        public DateTime fecha_emision
        {
            get { return _fecha_emision; }
            set { _fecha_emision = value; }
        }
        public string no_certificado
        {
            get { return _no_certificado; }
            set { _no_certificado = value; }
        }
        public string forma_pago
        {
            get { return _forma_pago; }
            set { _forma_pago = value; }
        }
        public string condiciones_pago
        {
            get { return _condiciones_pago; }
            set { _condiciones_pago = value; }
        }
        public float subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }
        public string moneda
        {
            get { return _moneda; }
            set { _moneda = value; }
        }
        public string tipo_cambio
        {
            get { return _tipo_cambio; }
            set { _tipo_cambio = value; }
        }
        public float totalFactura
        {
            get { return _totalFactura; }
            set { _totalFactura = value; }
        }
        public string tipo_comprobante
        {
            get { return _tipo_comprobante; }
            set { _tipo_comprobante = value; }
        }
        public string exportacion
        {
            get { return _exportacion; }
            set { _exportacion = value; }
        }
        public string metodo_pago
        {
            get { return _metodo_pago; }
            set { _metodo_pago = value; }
        }
        public string lugar_expedicion
        {
            get { return _lugar_expedicion; }
            set { _lugar_expedicion = value; }
        }
        public string rfc_emisor
        {
            get { return _rfc_emisor; }
            set { _rfc_emisor = value; }
        }
        public string nombre_emisor
        {
            get { return _nombre_emisor; }
            set { _nombre_emisor = value; }
        }
        public string regimen_fiscal_emisor
        {
            get { return _regimen_fiscal_emisor; }
            set { _regimen_fiscal_emisor = value; }
        }
        public string rfc_receptor
        {
            get { return _rfc_receptor; }
            set { _rfc_receptor = value; }
        }
        public string nombre_receptor
        {
            get { return _nombre_receptor; }
            set { _nombre_receptor = value; }
        }
        public string domicilio_fiscal_receptor
        {
            get { return _domicilio_fiscal_receptor; }
            set { _domicilio_fiscal_receptor = value; }
        }
        public string RegimenFiscalReceptor
        {
            get { return _RegimenFiscalReceptor; }
            set { _RegimenFiscalReceptor = value; }
        }
        public string uso_cfdi
        {
            get { return _uso_cfdi; }
            set { _uso_cfdi = value; }
        }
        public string codigoBarra
        {
            get { return _codigoBarra; }
            set { _codigoBarra = value; }
        }
        public string xmlFactura
        {
            get { return _xmlFactura; }
            set { _xmlFactura = value; }
        }
        public DateTime fecins
        {
            get { return _fecins; }
            set { _fecins = value; }
        }

        public string usuins
        {
            get { return _usuins; }
            set { _usuins = value; }
        }

        #endregion
        #region TablaFactura
        private DataTable _Factura;
        public DataTable Factura
        {
            get { return _Factura; }
            set { _Factura = value; }
        }
        #endregion
    }
}
