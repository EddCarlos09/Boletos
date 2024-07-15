using CreativaSL.Dll.VentaBoletosGlobal;
using MaterialSkin.Controls;
using System.Net.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;
using CreativaSL.Dll.VentaBoletosNegocio;
using System.IO;
using Syncfusion.Windows.Forms.Diagram;
using System.Xml.Linq;
namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmFacturaV1 : MaterialForm
    {
        public Factura_Negocio Model { get; set; }
        private FacturaDatos infoBoletos;
        private Validaciones Val;
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "https://dev.facturaloplus.com/api/rest/servicio/timbrarJSON2";
        private string apiKey = "6e20f7e7b8c645c79103696cc375ac2c";
        private FormUrlEncodedContent httpContent;
        public JsonFactura jsonFactura { get; set; }
        public frmFacturaV1(FacturaDatos cliente)
        {
            InitializeComponent();
            
            this.infoBoletos = cliente;
            Model = new Factura_Negocio(Comun.Conexion, false, 0, infoBoletos.Cliente.IDCliente, Comun.Id_U);
            loadMaterial(this);
            this.Inicializar();
        }
        #region Metodos Generales
        private void Inicializar()
        {
            try
            {
                if (infoBoletos.Cliente.IDCliente != null)
                {
                    this.LLenarDatos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LLenarDatos()
        {
            try
            {
                this.TxtNombre.Text = infoBoletos.Cliente.Nombre.ToString();
                this.TxtTelefono.Text = infoBoletos.Cliente.Telefono.ToString();
                this.TxtCP.Text = infoBoletos.Cliente.CodigoPostal.ToString();
                this.TxtDomicilio.Text = infoBoletos.Cliente.Domicilio.ToString();
                this.TxtEmail.Text = infoBoletos.Cliente.Email.ToString();
                this.TxtRFC.Text = infoBoletos.Cliente.RFC.ToString();
                this.TxtCelular.Text = infoBoletos.Cliente.TelefonoCelular.ToString();
                this.TxtColonia.Text = infoBoletos.Cliente.Colonia.ToString();
                this.txtEstado.Text = infoBoletos.Cliente.EstadoDesc.ToString();
                this.TxtEmpresa.Text = infoBoletos.Cliente.Empresa.ToString();
                this.txtCiudad.Text = infoBoletos.Cliente.MunicipioDesc.ToString();
                this.txtPais.Text = infoBoletos.Cliente.PaisDesc.ToString();
                this.txtFolioBoleto.Text = infoBoletos.Cliente.FolioBoleto.ToString();
                this.DtmFechaNac.Value = infoBoletos.Cliente.FechaNacimiento;
                this.txtOrigen.Text = infoBoletos.Cliente.Origen.ToString();
                this.txtDestino.Text = infoBoletos.Cliente.Destino.ToString();

         
                /* DATOS PARA MANDAR A CREAR LA FACTURA TIMBRADA*/

                float subtotal = infoBoletos.Importe;
                float importeTraslado = subtotal * 0.16f;
                float importeRetencion = subtotal * 0.04f;
                float total = subtotal + importeTraslado - importeRetencion;
                float importe = infoBoletos.Cantidad * infoBoletos.ValorUnitario;     // Importe total del concepto (CANTIDAD * VALOR UNITARIO)
               
                // Crear la lista deL nodo Conceptos
                List<Concepto> conceptos = new List<Concepto>();

  
                Concepto concepto1 = new Concepto
                {
                    ClaveProdServ = infoBoletos.ClaveProdServ, // Aquí va la clave del producto o servicio según el catálogo del SAT
                    NoIdentificacion = infoBoletos.NoIdentificacion,   // aqui va el folio del boleto
                    Cantidad = infoBoletos.Cantidad,
                    ClaveUnidad = infoBoletos.ClaveUnidad, // Clave de la unidad según el catálogo del SAT
                    Unidad = infoBoletos.Unidad,
                    Descripcion = infoBoletos.Descripcion,
                    ValorUnitario = infoBoletos.ValorUnitario,
                    Importe = importe, // Importe total del concepto (CANTIDAD * VALOR UNITARIO)
                    ObjetoImp = "02", //02 Objeto del impuesto, si aplica , 03 Sí objeto del impuesto y no obligado al desglose) no se desglosan impuestos a nivel Concepto
                    Impuestos = new ImpuestosConcepto
                    {
                        Traslados = new List<Traslado>
                        {
                            new Traslado
                            {
                                Base = subtotal,
                                Impuesto = "002", //IVA
                                TipoFactor = "Tasa",
                                TasaOCuota = 0.160000f,
                                Importe = importeTraslado
                            }
                        },
                        Retenciones = new List<Retencion>
                        {
                            new Retencion
                            {
                                Base = subtotal,
                                Impuesto = "002", //IVA
                                TipoFactor = "Tasa",
                                TasaOCuota = 0.040000f,
                                Importe = importeRetencion
                            }
                        }
                    }
                };

                // Agregar el concepto a la lista
                conceptos.Add(concepto1);

                //NODO DE COMPROBANTE

                var comprobante = new Comprobante
                {
                    Version = "4.0",
                    Serie = "BL-EX",
                    Folio = infoBoletos.NoIdentificacion,
                    Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                    FormaPago = "01", //EFECTIVO
                    NoCertificado = "30001000000500003416",
                    CondicionesDePago = "NA",
                    SubTotal = subtotal,
                    Moneda = "MXN",
                    Total = total,
                    TipoDeComprobante = "I", //INGRESO
                    Exportacion = "01",     // No aplica 
                    MetodoPago = "PUE",  // PAG EN UNA SOLA EXIBCION 
                    LugarExpedicion = "29000",
                    Emisor = new Emisor
                    {
                        Rfc = "EKU9003173C9",
                        Nombre = "ESCUELA KEMPER URGATE",
                        RegimenFiscal = "601" // 601  régimen General de Ley Personas Morales, 605 Sueldos y Salarios e Ingresos Asimilados a Salarios

                    },
                    Receptor = new Receptor
                    {
                        Rfc = "XAXX010101000", //infoBoletos.Cliente.RFC,
                        Nombre = "SAUL SANCHEZ", // infoBoletos.Cliente.Nombre,
                        DomicilioFiscalReceptor = "29000",
                        RegimenFiscalReceptor = "616",  // 616 régimen sin obligaciones fiscales,,605 Sueldos y Salarios e Ingresos Asimilados a Salarios
                        UsoCFDI = "S01", // SO1 Sin efectos fiscales. ,D01 Honorarios médicos, dentales y gastos hospitalarios.,
                    },
                    Conceptos = conceptos,
                    Impuestos = new Impuestos
                    {
                        TotalImpuestosRetenidos = importeRetencion,
                        TotalImpuestosTrasladados = importeTraslado,

                        Traslados = new List<Traslado>
                        {
                            new Traslado
                            {
                                Base = subtotal,
                                Impuesto = "002", //IVA
                                TipoFactor = "Tasa",
                                TasaOCuota = 0.160000f,
                                Importe = importeTraslado
                            }
                        },

                        Retenciones = new List<Retencion>
                        {
                            new Retencion
                            {
                                Base = subtotal,
                                Impuesto = "002", //IVA
                                TipoFactor = "Tasa",
                                Importe = importeRetencion
                            }
                        }

                    }
                };

                //NODO DE ENVIARCFDI
                var enviarCFDI = new EnviarCFDI
                {
                    Correos = new List<string> { infoBoletos.Cliente.Email},
                    NombreArchivos = "Factura",
                    RemitenteNombre = "Heco 1 Tours  S.A DE C.V.",
                    Asunto = "Envío de CFDI",
                    Mensaje = "Estimado cliente, por medio del presente le hago llegar como dato adjunto el Comprobante Fiscal Digital XML y PDF."
                };

                //NODO DE CAMPOS PARA EL PDF
                var camposPDF = new CamposPDF
                {
                    TipoComprobante = "Factura",
                    Comentarios = "Factura electronica",
                    CalleEmisor = "Calle Torrez",
                    NoExteriorEmisor = "35",
                    NoInteriorEmisor = "34-B",
                    ColoniaEmisor = "San isidro",
                    CodigoPostalEmisor = "29661",
                    LocalidadEmisor = "Chiapas",
                    MunicipioEmisor = "Pantepec",
                    EstadoEmisor = "Chiapas",
                    PaisEmisor = "Mexico",
                    TelefonoEmisor = "9191711136",
                    EmailEmisor = "rafahh531@gmail.com",
                    CalleReceptor = "S/N",
                    NoExteriorReceptor ="S/N",
                    NoInteriorReceptor = "S/N",
                    ColoniaReceptor = infoBoletos.Cliente.Colonia,
                    CodigoPostalReceptor = infoBoletos.Cliente.CodigoPostal,
                    LocalidadReceptor = infoBoletos.Cliente.EstadoDesc,
                    MunicipioReceptor = infoBoletos.Cliente.MunicipioDesc,
                    EstadoReceptor = infoBoletos.Cliente.EstadoDesc,
                    PaisReceptor = infoBoletos.Cliente.PaisDesc
                };

                //SE CREA EL JSON COMPLETO PARA LA FACTURA
                jsonFactura = new JsonFactura
                {
                    Comprobante = comprobante,
                    EnviarCFDI = enviarCFDI,
                    CamposPDF = camposPDF,
                };

                string json = JsonConvert.SerializeObject(jsonFactura);

                // JSON a Base64
                string jsonBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));

                var keyPEM = @"-----BEGIN PRIVATE KEY-----
MIIEvwIBADANBgkqhkiG9w0BAQEFAASCBKkwggSlAgEAAoIBAQC2Z5w7qfYZLTMv
TbmBscZBXHOc8MgKhfNHa5SeDPgOrFVQL/D1wToXFKJebZqnwZyODvCZxl+bzkQF
rELH/Qna7kKqeHMigYJ2EE+6FZCciHlMuCP9fq42q7BmQoKFs171p4WKtT8lvI3s
SCJr2gof0plSyh2Iz+lYAfTQ8K2gon04FxIcyrxGprcoqgFx+SDVmuC559/BEvCz
3I5xFYtvTawM4/MYib+MQWJxVi3YfDWp1ETnGZNnsAYbRQez66eQaOkJV4n4EQGf
Qk8tZW8ModkBAyPqzkGS7fn538zIBOSk4+wZP9VOeyi7F6QN+KQkPV/sDVmkluoO
mQmeyze9AgMBAAECggEAM8vEL6UZvxh4umwFy3Bh7dmE8wHkrChRZuyDrUXdgr0p
FLYoZIDUMA2p9cqF6jEudaCEbgZIzAOMiVfbNtMB42tY/vNpLlk8ZK5JFXxeLjUK
zOBVR/ybF+c1FjS4v6KpynQhlbvWDK84Veo97AZkbZjt9PZz4I+5oUYc8OAHTd+b
NgL6r7SnudH/2p7rI9kMFp3h9oov+H91IguFn4SF0aVMPiLMUVUYA3QpvIA03c7A
cY8tloFArpPkpa1yyZ7ToFx3mPsYNxyn4Ud3lx0PHJ0ulUjPBVoi+ewFLHG0Z8HS
2CdBe+7ptS0u1e58+RsX5tlf61xGwlHzMbfqyrBrQQKBgQDp/VO5GmFSzvIlrCJg
X3R6f+YWraYqqL4uND56Y5q+MaPE2lAEzYKkGdHotiYu3Ta6picBo8BamMQBC93r
miwJYBHZWih56Xb/lSdV1GGHUbNCCqhR78EabVgbNj8vWYaCRezXFjMdnG5dTYsn
NsMtvV6/dBXxoLpJWi7YCM6QlQKBgQDHkBNQ1DNUvpSMeICd7OgUTiQKSGViMRKE
BoARNGE5f6ZbCACY69gSDs/OdZUqq6gboCu4VNWrl0/mOZrhkVJEicDKcahDuM6R
5q3EPcv/XhonAlvAXueDCVEaNh7iPyt0XTsDsMFsAi4xs9n6DcOvp8DLDBa9rfWW
gJghwhJ4iQKBgQCdZR5QQQJ+ZV5VIPjuwsbjL+1iC+TehSuIgPQV97I7hcCXxhJV
aLgcEpI0a3I7y+nom6NZYwEc7+3Ilmbs+IPuuoTHI/JeL0EwovAWuAnysG5YWjrn
AtNuJ2dAxrix7RKhxs+Nzw0LOhKzCFo2Qov/1IZLWpb4NhmZBeTExQfOEQKBgQCp
mkbwQQhHE5mIMLmOflNXPnney1xusSn9TtD0zkF67oPhhdGMJZSC9FekLcZSd4Tt
xZiilmbp6DUdgwOghTMX0MMqyqGovJ3C3fv8dlCzfbRYRubXfVDgysBEuI5S1kEG
Kl4HaudX9hpwX1v36k7PMJDngCSrm/bGrA+fUSMFkQKBgQDnHnYRit6FIr1IgLoA
uWEYY/R1cVv5tWtDbHqa/I4+oS+qDA8HNNKVvm8HO8JLRU5f+ZhBQfJVhWbEybOj
KpTeg0L+wtXEw8Qfb2we1GFJ/LaiXTzeJVttnARJXce+G0U/Ei8EthOCh4PTNawU
YTt70e4jJwOsG6DZFT8EnM7O7Q==
-----END PRIVATE KEY-----";

                var cerPEM = @"-----BEGIN CERTIFICATE-----
MIIFsDCCA5igAwIBAgIUMzAwMDEwMDAwMDA1MDAwMDM0MTYwDQYJKoZIhvcNAQEL
BQAwggErMQ8wDQYDVQQDDAZBQyBVQVQxLjAsBgNVBAoMJVNFUlZJQ0lPIERFIEFE
TUlOSVNUUkFDSU9OIFRSSUJVVEFSSUExGjAYBgNVBAsMEVNBVC1JRVMgQXV0aG9y
aXR5MSgwJgYJKoZIhvcNAQkBFhlvc2Nhci5tYXJ0aW5lekBzYXQuZ29iLm14MR0w
GwYDVQQJDBQzcmEgY2VycmFkYSBkZSBjYWxpejEOMAwGA1UEEQwFMDYzNzAxCzAJ
BgNVBAYTAk1YMRkwFwYDVQQIDBBDSVVEQUQgREUgTUVYSUNPMREwDwYDVQQHDAhD
T1lPQUNBTjERMA8GA1UELRMIMi41LjQuNDUxJTAjBgkqhkiG9w0BCQITFnJlc3Bv
bnNhYmxlOiBBQ0RNQS1TQVQwHhcNMjMwNTE4MTE0MzUxWhcNMjcwNTE4MTE0MzUx
WjCB1zEnMCUGA1UEAxMeRVNDVUVMQSBLRU1QRVIgVVJHQVRFIFNBIERFIENWMScw
JQYDVQQpEx5FU0NVRUxBIEtFTVBFUiBVUkdBVEUgU0EgREUgQ1YxJzAlBgNVBAoT
HkVTQ1VFTEEgS0VNUEVSIFVSR0FURSBTQSBERSBDVjElMCMGA1UELRMcRUtVOTAw
MzE3M0M5IC8gVkFEQTgwMDkyN0RKMzEeMBwGA1UEBRMVIC8gVkFEQTgwMDkyN0hT
UlNSTDA1MRMwEQYDVQQLEwpTdWN1cnNhbCAxMIIBIjANBgkqhkiG9w0BAQEFAAOC
AQ8AMIIBCgKCAQEAtmecO6n2GS0zL025gbHGQVxznPDICoXzR2uUngz4DqxVUC/w
9cE6FxSiXm2ap8Gcjg7wmcZfm85EBaxCx/0J2u5CqnhzIoGCdhBPuhWQnIh5TLgj
/X6uNquwZkKChbNe9aeFirU/JbyN7Egia9oKH9KZUsodiM/pWAH00PCtoKJ9OBcS
HMq8Rqa3KKoBcfkg1ZrgueffwRLws9yOcRWLb02sDOPzGIm/jEFicVYt2Hw1qdRE
5xmTZ7AGG0UHs+unkGjpCVeJ+BEBn0JPLWVvDKHZAQMj6s5Bku35+d/MyATkpOPs
GT/VTnsouxekDfikJD1f7A1ZpJbqDpkJnss3vQIDAQABox0wGzAMBgNVHRMBAf8E
AjAAMAsGA1UdDwQEAwIGwDANBgkqhkiG9w0BAQsFAAOCAgEAFaUgj5PqgvJigNMg
trdXZnbPfVBbukAbW4OGnUhNrA7SRAAfv2BSGk16PI0nBOr7qF2mItmBnjgEwk+D
Tv8Zr7w5qp7vleC6dIsZFNJoa6ZndrE/f7KO1CYruLXr5gwEkIyGfJ9NwyIagvHH
MszzyHiSZIA850fWtbqtythpAliJ2jF35M5pNS+YTkRB+T6L/c6m00ymN3q9lT1r
B03YywxrLreRSFZOSrbwWfg34EJbHfbFXpCSVYdJRfiVdvHnewN0r5fUlPtR9stQ
Hyuqewzdkyb5jTTw02D2cUfL57vlPStBj7SEi3uOWvLrsiDnnCIxRMYJ2UA2ktDK
Hk+zWnsDmaeleSzonv2CHW42yXYPCvWi88oE1DJNYLNkIjua7MxAnkNZbScNw01A
6zbLsZ3y8G6eEYnxSTRfwjd8EP4kdiHNJftm7Z4iRU7HOVh79/lRWB+gd171s3d/
mI9kte3MRy6V8MMEMCAnMboGpaooYwgAmwclI2XZCczNWXfhaWe0ZS5PmytD/GDp
XzkX0oEgY9K/uYo5V77NdZbGAjmyi8cE2B2ogvyaN2XfIInrZPgEffJ4AB7kFA2m
wesdLOCh0BLD9itmCve3A1FGR4+stO2ANUoiI3w3Tv2yQSg4bjeDlJ08lXaaFCLW
2peEXMXjQUk7fmpb5MNuOUTW6BE=
-----END CERTIFICATE-----";
                
                var values = new Dictionary<string, string>
                {
                    { "apikey", apiKey },
                    { "jsonB64", jsonBase64 },
                    { "keyPEM", keyPEM },
                    { "cerPEM", cerPEM },
                    { "plantilla", "1" }
                };

                httpContent = new FormUrlEncodedContent(values);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                await TimbrarFactura();
            }
        }

        private async Task TimbrarFactura()
        {
            try
            {
                //string uuid = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><cfdi:Comprobante xmlns:cfdi=\"http://www.sat.gob.mx/cfd/4\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" Certificado=\"MIIFsDCCA5igAwIBAgIUMzAwMDEwMDAwMDA1MDAwMDM0MTYwDQYJKoZIhvcNAQELBQAwggErMQ8wDQYDVQQDDAZBQyBVQVQxLjAsBgNVBAoMJVNFUlZJQ0lPIERFIEFETUlOSVNUUkFDSU9OIFRSSUJVVEFSSUExGjAYBgNVBAsMEVNBVC1JRVMgQXV0aG9yaXR5MSgwJgYJKoZIhvcNAQkBFhlvc2Nhci5tYXJ0aW5lekBzYXQuZ29iLm14MR0wGwYDVQQJDBQzcmEgY2VycmFkYSBkZSBjYWxpejEOMAwGA1UEEQwFMDYzNzAxCzAJBgNVBAYTAk1YMRkwFwYDVQQIDBBDSVVEQUQgREUgTUVYSUNPMREwDwYDVQQHDAhDT1lPQUNBTjERMA8GA1UELRMIMi41LjQuNDUxJTAjBgkqhkiG9w0BCQITFnJlc3BvbnNhYmxlOiBBQ0RNQS1TQVQwHhcNMjMwNTE4MTE0MzUxWhcNMjcwNTE4MTE0MzUxWjCB1zEnMCUGA1UEAxMeRVNDVUVMQSBLRU1QRVIgVVJHQVRFIFNBIERFIENWMScwJQYDVQQpEx5FU0NVRUxBIEtFTVBFUiBVUkdBVEUgU0EgREUgQ1YxJzAlBgNVBAoTHkVTQ1VFTEEgS0VNUEVSIFVSR0FURSBTQSBERSBDVjElMCMGA1UELRMcRUtVOTAwMzE3M0M5IC8gVkFEQTgwMDkyN0RKMzEeMBwGA1UEBRMVIC8gVkFEQTgwMDkyN0hTUlNSTDA1MRMwEQYDVQQLEwpTdWN1cnNhbCAxMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAtmecO6n2GS0zL025gbHGQVxznPDICoXzR2uUngz4DqxVUC/w9cE6FxSiXm2ap8Gcjg7wmcZfm85EBaxCx/0J2u5CqnhzIoGCdhBPuhWQnIh5TLgj/X6uNquwZkKChbNe9aeFirU/JbyN7Egia9oKH9KZUsodiM/pWAH00PCtoKJ9OBcSHMq8Rqa3KKoBcfkg1ZrgueffwRLws9yOcRWLb02sDOPzGIm/jEFicVYt2Hw1qdRE5xmTZ7AGG0UHs+unkGjpCVeJ+BEBn0JPLWVvDKHZAQMj6s5Bku35+d/MyATkpOPsGT/VTnsouxekDfikJD1f7A1ZpJbqDpkJnss3vQIDAQABox0wGzAMBgNVHRMBAf8EAjAAMAsGA1UdDwQEAwIGwDANBgkqhkiG9w0BAQsFAAOCAgEAFaUgj5PqgvJigNMgtrdXZnbPfVBbukAbW4OGnUhNrA7SRAAfv2BSGk16PI0nBOr7qF2mItmBnjgEwk+DTv8Zr7w5qp7vleC6dIsZFNJoa6ZndrE/f7KO1CYruLXr5gwEkIyGfJ9NwyIagvHHMszzyHiSZIA850fWtbqtythpAliJ2jF35M5pNS+YTkRB+T6L/c6m00ymN3q9lT1rB03YywxrLreRSFZOSrbwWfg34EJbHfbFXpCSVYdJRfiVdvHnewN0r5fUlPtR9stQHyuqewzdkyb5jTTw02D2cUfL57vlPStBj7SEi3uOWvLrsiDnnCIxRMYJ2UA2ktDKHk+zWnsDmaeleSzonv2CHW42yXYPCvWi88oE1DJNYLNkIjua7MxAnkNZbScNw01A6zbLsZ3y8G6eEYnxSTRfwjd8EP4kdiHNJftm7Z4iRU7HOVh79/lRWB+gd171s3d/mI9kte3MRy6V8MMEMCAnMboGpaooYwgAmwclI2XZCczNWXfhaWe0ZS5PmytD/GDpXzkX0oEgY9K/uYo5V77NdZbGAjmyi8cE2B2ogvyaN2XfIInrZPgEffJ4AB7kFA2mwesdLOCh0BLD9itmCve3A1FGR4+stO2ANUoiI3w3Tv2yQSg4bjeDlJ08lXaaFCLW2peEXMXjQUk7fmpb5MNuOUTW6BE=\" CondicionesDePago=\"NA\" Exportacion=\"01\" Fecha=\"2024-07-11T23:59:00\" Folio=\"20240420000017\" FormaPago=\"01\" LugarExpedicion=\"29000\" MetodoPago=\"PUE\" Moneda=\"MXN\" NoCertificado=\"30001000000500003416\" Sello=\"aXizbxCUipbCF/u0lYg4IbhmhzYqvwumYLUE/UmcrKrz8yXgd3Xu6jLIQBlg8rLD/A+Cc9ab07u3bGyyRUpUVBlHgwTV0tun3PRHNwAz3PKaIPboWZBF4xnPLX0+FJH9ZrfO7xuMxUuQPMz6GF04Y6osaf4WPo85/ndXUQwHbOts7SFEj8YIJWHnxwDL6NWREFfiVd7KvrlTLXg1fh77onagqgHtvHilhmy3eYFLPWjSlFR6Q5ClKiIk9KULDKnAzkq99RUAuHDeqBCAVFa/3vKojoeM1vI+dMF9RUU6Lq5liWhi0b6/W1GEDprXA05ko8QBCEX65NVPgeG3pWg2Pw==\" Serie=\"BL-EX\" SubTotal=\"2000\" TipoDeComprobante=\"I\" Total=\"2240\" Version=\"4.0\" xsi:schemaLocation=\"http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd\"><cfdi:Emisor Nombre=\"ESCUELA KEMPER URGATE\" RegimenFiscal=\"601\" Rfc=\"EKU9003173C9\"/><cfdi:Receptor DomicilioFiscalReceptor=\"29000\" Nombre=\"Rafa\" RegimenFiscalReceptor=\"616\" Rfc=\"XAXX010101000\" UsoCFDI=\"S01\"/><cfdi:Conceptos><cfdi:Concepto Cantidad=\"1\" ClaveProdServ=\"78111802\" ClaveUnidad=\"EA\" Descripcion=\"Venta de boletos\" Importe=\"2000\" NoIdentificacion=\"20240420000017\" ObjetoImp=\"02\" Unidad=\"Elemento\" ValorUnitario=\"2000\"><cfdi:Impuestos><cfdi:Traslados><cfdi:Traslado Base=\"2000\" Importe=\"320\" Impuesto=\"002\" TasaOCuota=\"0.16\" TipoFactor=\"Tasa\"/></cfdi:Traslados><cfdi:Retenciones><cfdi:Retencion Base=\"2000\" Importe=\"80\" Impuesto=\"002\" TasaOCuota=\"0.04\" TipoFactor=\"Tasa\"/></cfdi:Retenciones></cfdi:Impuestos></cfdi:Concepto></cfdi:Conceptos><cfdi:Impuestos TotalImpuestosRetenidos=\"80\" TotalImpuestosTrasladados=\"320\"><cfdi:Retenciones><cfdi:Retencion Importe=\"80\" Impuesto=\"002\"/></cfdi:Retenciones><cfdi:Traslados><cfdi:Traslado Base=\"2000\" Importe=\"320\" Impuesto=\"002\" TasaOCuota=\"0.16\" TipoFactor=\"Tasa\"/></cfdi:Traslados></cfdi:Impuestos><cfdi:Complemento><tfd:TimbreFiscalDigital FechaTimbrado=\"2024-07-11T23:59:01\" NoCertificadoSAT=\"30001000000500003456\" RfcProvCertif=\"SPR190613I52\" SelloCFD=\"aXizbxCUipbCF/u0lYg4IbhmhzYqvwumYLUE/UmcrKrz8yXgd3Xu6jLIQBlg8rLD/A+Cc9ab07u3bGyyRUpUVBlHgwTV0tun3PRHNwAz3PKaIPboWZBF4xnPLX0+FJH9ZrfO7xuMxUuQPMz6GF04Y6osaf4WPo85/ndXUQwHbOts7SFEj8YIJWHnxwDL6NWREFfiVd7KvrlTLXg1fh77onagqgHtvHilhmy3eYFLPWjSlFR6Q5ClKiIk9KULDKnAzkq99RUAuHDeqBCAVFa/3vKojoeM1vI+dMF9RUU6Lq5liWhi0b6/W1GEDprXA05ko8QBCEX65NVPgeG3pWg2Pw==\" SelloSAT=\"LkYwxhgrReWicwJpZRKQXVmk/lewGCq7lXgKqxtQzL6myNs9AJhSTVvb4Mlspnljxj9zfFK6Nl8Bt+oPrSPB26SnDyfm2aXO7i1efOGfwGTsWuQauuhbHyGYzRj3EWhwWIrnaXMlRMEwpRBFDtVfxh0ubfItLssdZNVP/YklEm1ubI/iem6B8MT18c9ofgkKVdcxPGTv5MQE7fU4Qhsb7JRbnIP8GI8y+57oD5uC0rrjcG53HJrbsSocJobvIDDjwN3gNZwIhbud6RnX3xBNWsV9ATXSqNMVSEOzp2QvIFxvC4TW8JIEOQBJOC5J8DE1E/RHPSdhaySFMWAc/AZSQQ==\" UUID=\"99169D2C-7456-4C1C-9862-D1DEC119990C\" Version=\"1.1\" xsi:schemaLocation=\"http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/sitio_internet/cfd/TimbreFiscalDigital/TimbreFiscalDigitalv11.xsd\" xmlns:tfd=\"http://www.sat.gob.mx/TimbreFiscalDigital\"/></cfdi:Complemento></cfdi:Comprobante>";
                //string pdfbase = "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dGljYS1Cb2xkL0VuY29kaW5nL1dpbkFuc2lFbmNvZGluZz4+CmVuZG9iago3IDAgb2JqCjw8L0tpZHNbMSAwIFJdL1R5cGUvUGFnZXMvQ291bnQgMS9JVFhUKDIuMS43KT4+CmVuZG9iago5IDAgb2JqCjw8L05hbWVzWyhKUl9QQUdFX0FOQ0hPUl8wXzEpIDggMCBSXT4+CmVuZG9iagoxMCAwIG9iago8PC9EZXN0cyA5IDAgUj4+CmVuZG9iagoxMSAwIG9iago8PC9OYW1lcyAxMCAwIFIvVHlwZS9DYXRhbG9nL1BhZ2VzIDcgMCBSL1ZpZXdlclByZWZlcmVuY2VzPDwvUHJpbnRTY2FsaW5nL0FwcERlZmF1bHQ+Pj4+CmVuZG9iagoxMiAwIG9iago8PC9Nb2REYXRlKEQ6MjAyNDA3MTEyMTAwMTEtMDYnMDAnKS9DcmVhdG9yKEphc3BlclJlcG9ydHMgTGlicmFyeSB2ZXJzaW9uIG51bGwpL0NyZWF0aW9uRGF0ZShEOjIwMjQwNzExMjEwMDExLTA2JzAwJykvUHJvZHVjZXIoaVRleHQgMi4xLjcgYnkgMVQzWFQpPj4KZW5kb2JqCnhyZWYKMCAxMwowMDAwMDAwMDAwIDY1NTM1IGYgCjAwMDAwMDY3NDQgMDAwMDAgbiAKMDAwMDAwNzA2MyAwMDAwMCBuIAowMDAwMDA3MTUxIDAwMDAwIG4gCjAwMDAwMDAwMTUgMDAwMDAgbiAKMDAwMDAwMDI0MCAwMDAwMCBuIAowMDAwMDAzMzU5IDAwMDAwIG4gCjAwMDAwMDcyNDQgMDAwMDAgbiAKMDAwMDAwNzAyOCAwMDAwMCBuIAowMDAwMDA3MzA3IDAwMDAwIG4gCjAwMDAwMDczNjEgMDAwMDAgbiAKMDAwMDAwNzM5NCAwMDAwMCBuIAowMDAwMDA3NDk5IDAwMDAwIG4gCnRyYWlsZXIKPDwvSW5mbyAxMiAwIFIvSUQgWzwzMTQ1Zjk0OTA2ZTZiMDMzNzk1ZGE0OTNjZTEzMGQ1Yz48NGRiMDVjOTNkNzBkMzk3ZWJmNjQ5YTljNWExNzVlYjQ+XS9Sb290IDExIDAgUi9TaXplIDEzPj4Kc3RhcnR4cmVmCjc2NjYKJSVFT0YK";

                //string uuidxml = ExtraerUUID(uuid);
                //Facturas factura = MapModelFactura(jsonFactura, uuid, uuidxml);

                //int verificador = 0;
                //Model.InsertarFactura(factura, ref verificador);



                // Envía la solicitud a la api factura
                HttpResponseMessage response = await client.PostAsync(apiUrl, httpContent);

                string responseBody = await response.Content.ReadAsStringAsync();
                // Verifica la respuesta
                if (response.IsSuccessStatusCode)
                {
                    // Deserializar la respuesta
                    ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseBody);

                    if (apiResponse.Code == "200")
                    {
                        string uuid = ExtraerUUID(apiResponse.Data.XML);

                        Facturas factura = MapModelFactura(jsonFactura, apiResponse.Data.XML, uuid);

                        int verificador = 0;

                        Model.InsertarFactura(factura, ref verificador);
                        // Procesar el  PDF
                        try
                        {
                            byte[] pdfBytes = Convert.FromBase64String(apiResponse.Data.PDF);
                            string tempFilePath = Path.Combine(Path.GetTempPath(), "Factura-" + jsonFactura.Comprobante.Receptor.Rfc + ".pdf");
                            File.WriteAllBytes(tempFilePath, pdfBytes);

                            MessageBox.Show("Datos guardados correctamente y pdf generado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MostrarPDFEnFormulario(tempFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al procesar PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Respuesta del servidor: " + responseBody);
                    }

                }
                else
                {
                    MessageBox.Show("Error en la solicitud: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private Facturas MapModelFactura(JsonFactura jsonFactura , string xml,string uuid)
        {
            return new Facturas
            {
                nombre_receptor = jsonFactura.Comprobante.Receptor.Nombre,
                rfc_receptor = jsonFactura.Comprobante.Receptor.Rfc,
                subtotal = jsonFactura.Comprobante.SubTotal,
                totalFactura = jsonFactura.Comprobante.Total,
                folio = jsonFactura.Comprobante.Folio,
                uuid_factura = uuid,
                fecha_emision = DateTime.Parse(jsonFactura.Comprobante.Fecha),
                serie = jsonFactura.Comprobante.Serie, 
                no_certificado = jsonFactura.Comprobante.NoCertificado, 
                forma_pago = jsonFactura.Comprobante.FormaPago, 
                condiciones_pago = jsonFactura.Comprobante.CondicionesDePago, 
                moneda = jsonFactura.Comprobante.Moneda, 
                tipo_cambio = "NA", 
                tipo_comprobante = jsonFactura.Comprobante.TipoDeComprobante, 
                exportacion = jsonFactura.Comprobante.Exportacion, 
                metodo_pago = jsonFactura.Comprobante.MetodoPago, 
                lugar_expedicion = jsonFactura.Comprobante.LugarExpedicion, 
                rfc_emisor = jsonFactura.Comprobante.Emisor.Rfc, 
                nombre_emisor = jsonFactura.Comprobante.Emisor.Nombre, 
                regimen_fiscal_emisor = jsonFactura.Comprobante.Emisor.RegimenFiscal, 
                domicilio_fiscal_receptor = jsonFactura.Comprobante.Receptor.DomicilioFiscalReceptor, 
                RegimenFiscalReceptor = jsonFactura.Comprobante.Receptor.RegimenFiscalReceptor,
                uso_cfdi = jsonFactura.Comprobante.Receptor.UsoCFDI, 
                xmlFactura = xml,
                id_cliente = infoBoletos.Cliente.IDCliente
            };
        }
        private string ExtraerUUID(string xmlContent)
        {
            try
            {
                XDocument xdoc = XDocument.Parse(xmlContent);
                XNamespace tfd = "http://www.sat.gob.mx/TimbreFiscalDigital";
                var uuidElement = xdoc.Descendants(tfd + "TimbreFiscalDigital").FirstOrDefault();
                if (uuidElement != null)
                {
                    return uuidElement.Attribute("UUID")?.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void MostrarPDFEnFormulario(string filePath)
        {
            webBrowser1.Navigate(filePath);
            //System.Diagnostics.Process.Start(filePath);
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El campo Nombre está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtTelefono.Text))
            {
                MessageBox.Show("El campo Teléfono está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtCP.Text))
            {
                MessageBox.Show("El campo Código Postal está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtDomicilio.Text))
            {
                MessageBox.Show("El campo Domicilio está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("El campo Email está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtRFC.Text))
            {
                MessageBox.Show("El campo RFC está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtCelular.Text))
            {
                MessageBox.Show("El campo Celular está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtColonia.Text))
            {
                MessageBox.Show("El campo Colonia está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show("El campo Estado está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtEmpresa.Text))
            {
                MessageBox.Show("El campo Empresa está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCiudad.Text))
            {
                MessageBox.Show("El campo Ciudad está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("El campo País está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFolioBoleto.Text))
            {
                MessageBox.Show("El campo Folio del Boleto está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOrigen.Text))
            {
                MessageBox.Show("El campo Origen está vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                MessageBox.Show("El campo Destino está vacío.");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
