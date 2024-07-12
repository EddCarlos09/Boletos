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
                        Rfc = "XAXX010101000",
                        Nombre = infoBoletos.Cliente.Nombre,
                        DomicilioFiscalReceptor = "29000",
                        RegimenFiscalReceptor = "616",  //  régimen sin obligaciones fiscales
                        UsoCFDI = "S01", // Sin efectos fiscales.
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
                        Facturas factura=  MapModelFactura(jsonFactura, apiResponse.Data.XML);

                        int verificador = 0;

                        Model.InsertarFactura(factura ,ref verificador);
                        // Procesar el  PDF
                        try
                        {
                            byte[] pdfBytes = Convert.FromBase64String(apiResponse.Data.PDF);
                            string filePath = "output.pdf";
                            File.WriteAllBytes(filePath, pdfBytes);
                          
                            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MostrarPDFEnFormulario(filePath);
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
        private Facturas MapModelFactura(JsonFactura jsonFactura , string xml)
        {
            return new Facturas
            {
                nombre_receptor = jsonFactura.Comprobante.Receptor.Nombre,
                rfc_receptor = jsonFactura.Comprobante.Receptor.Rfc,
                subtotal = jsonFactura.Comprobante.SubTotal,
                totalFactura = jsonFactura.Comprobante.Total,
                folio = jsonFactura.Comprobante.Folio,
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
                codigoBarra = "NA", 
                xmlFactura = xml,
                id_cliente = infoBoletos.Cliente.IDCliente
            };
        }

        private void MostrarPDFEnFormulario(string filePath)
        {
            webBrowser1.Navigate(filePath);
        }
        private bool ValidarCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"El campo {textBox.Name} no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

    }
}
