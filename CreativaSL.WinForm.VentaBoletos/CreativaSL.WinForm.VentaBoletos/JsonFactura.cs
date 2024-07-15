using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.WinForm.VentaBoletos
{
    public class JsonFactura
    {
        public Comprobante Comprobante { get; set; }
        public EnviarCFDI EnviarCFDI { get; set; }
        public CamposPDF CamposPDF { get; set; }
        public string Logo { get; set; }
    }
  
    public class Comprobante
    {
        public string Version { get; set; }
        public string Serie { get; set; } // opcional
        public string Folio { get; set; } // opcional
        public string Fecha { get; set; }
        public string FormaPago { get; set; } // opcional
        public string NoCertificado { get; set; }
        public string CondicionesDePago { get; set; } // opcional
        public float SubTotal { get; set; }
        public string Moneda { get; set; }
      //  public string TipoCambio { get; set; } // opcional
        public float Total { get; set; }
        public string TipoDeComprobante { get; set; }
        public string Exportacion { get; set; }
        public string MetodoPago { get; set; } // opcional
        public string LugarExpedicion { get; set; }
      //  public List<CfdiRelacionados> CfdiRelacionados { get; set; } //Nodo opcional
        public Emisor Emisor { get; set; }
        public Receptor Receptor { get; set; }
        public List<Concepto> Conceptos { get; set; }
        public Impuestos Impuestos { get; set; }
    }
    public class CfdiRelacionados
    {
        public string TipoRelacion { get; set; }
        public List<CfdiRelacionado> CfdiRelacionado { get; set; }
    }

    public class CfdiRelacionado
    {
        public string UUID { get; set; }
    }
    public class Emisor
    {
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string RegimenFiscal { get; set; }
    }

    public class Receptor
    {
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string DomicilioFiscalReceptor { get; set; }
        public string RegimenFiscalReceptor { get; set; }
        public string UsoCFDI { get; set; }
    }

    public class Concepto
    {
        public string ClaveProdServ { get; set; }
        public string NoIdentificacion { get; set; }
        public int Cantidad { get; set; }
        public string ClaveUnidad { get; set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public float ValorUnitario { get; set; }
        public float Importe { get; set; }
        public string ObjetoImp { get; set; }
        public ImpuestosConcepto Impuestos { get; set; }
    }
    public class ImpuestosConcepto
    {
        public List<Traslado> Traslados { get; set; }
        public List<Retencion> Retenciones { get; set; }
    }
    public class Impuestos
    {
        public float TotalImpuestosRetenidos { get; set; }
        public float TotalImpuestosTrasladados { get; set; }
        public List<Traslado> Traslados { get; set; }
        public List<Retencion> Retenciones { get; set; }
    }
    public class Traslado
    {
        public float Base { get; set; }
        public string Impuesto { get; set; }
        public string TipoFactor { get; set; }
        public float TasaOCuota { get; set; }
        public float Importe { get; set; }
    }
    public class Retencion
    {
        public float Base { get; set; }
        public string Impuesto { get; set; }
        public string TipoFactor { get; set; }
        public float TasaOCuota { get; set; }
        public float Importe { get; set; }
    }

    public class EnviarCFDI
    {
        public List<string> Correos { get; set; }
        public string NombreArchivos { get; set; }
        public string RemitenteNombre { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
    }

    public class CamposPDF
    {
        public string TipoComprobante { get; set; }
        public string Comentarios { get; set; }
        public string CalleEmisor { get; set; }
        public string NoExteriorEmisor { get; set; }
        public string NoInteriorEmisor { get; set; }
        public string ColoniaEmisor { get; set; }
        public string CodigoPostalEmisor { get; set; }
        public string LocalidadEmisor { get; set; }
        public string MunicipioEmisor { get; set; }
        public string EstadoEmisor { get; set; }
        public string PaisEmisor { get; set; }
        public string TelefonoEmisor { get; set; }
        public string EmailEmisor { get; set; }
        public string CalleReceptor { get; set; }
        public string NoExteriorReceptor { get; set; }
        public string NoInteriorReceptor { get; set; }
        public string ColoniaReceptor { get; set; }
        public string CodigoPostalReceptor { get; set; }
        public string LocalidadReceptor { get; set; }
        public string MunicipioReceptor { get; set; }
        public string EstadoReceptor { get; set; }
        public string PaisReceptor { get; set; }
        public List<Etiqueta> Etiquetas { get; set; }
    }
    public class Etiqueta
    {
        public string Nombre { get; set; }
        public string Valor { get; set; }
    }


}
