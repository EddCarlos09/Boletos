using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Busqueda_Datos
    {

        public Busqueda BuscarBoletos(Busqueda datos)
        {
            try
            {
                object[] valores = { 
                    datos.fecha_boleto,
                    datos.nombre_cliente,
                    datos.folio_boleto,
                    datos.folio_venta,
                    datos.band_fecha,
                    datos.band_nombre,
                    datos.band_folio,
                    datos.band_folioVenta
                };
                DataSet ds = SqlHelper.ExecuteDataset(datos.strcnx, "Consultar_Boletos_sp", valores);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            datos.resultado = ds.Tables[0];
                        }
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Busqueda ValidarFolioTransferencia(string Folio, string Conexion)
        {
            try
            {
                Busqueda datos = new Busqueda(Conexion);
                object result = SqlHelper.ExecuteScalar(Conexion, "ValidarFolioTransaccionTransferencia", Folio);
                if (result != null)
                {
                    datos.Validador = Convert.ToBoolean(result.ToString());
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

