using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Factura_Datos
    {
        public void GuardarFactura(string Conexion, Facturas Factura, ref int Verificador)
        {
            try
            {
                object[] Valores = {Factura.id_cliente, Factura.serie, Factura.folio, Factura.uuid_factura,
                                    Factura.fecha_emision,Factura.no_certificado,Factura.forma_pago,
                                    Factura.condiciones_pago,Factura.subtotal,Factura.moneda,Factura.tipo_cambio,Factura.totalFactura,
                                    Factura.tipo_comprobante,Factura.exportacion,Factura.metodo_pago,Factura.lugar_expedicion,
                                    Factura.rfc_emisor, Factura.nombre_emisor,Factura.regimen_fiscal_emisor,Factura.rfc_receptor,
                                    Factura.nombre_receptor,Factura.domicilio_fiscal_receptor,Factura.RegimenFiscalReceptor,Factura.uso_cfdi,
                                    Factura.xmlFactura,Comun.Id_U};
                object res = SqlHelper.ExecuteScalar(Conexion, "factura_insertar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
