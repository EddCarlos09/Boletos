using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class BusquedaCambio_Datos
    {
        public Busqueda BuscarBoletos(string Conexion, Busqueda datos)
        {
            try
            {
                object[] valores = { datos.fecha_boleto, datos.nombre_cliente, datos.folio_boleto, datos.band_fecha, datos.band_nombre, datos.band_folio };
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "Consultar_BoletosCambio_sp", valores);
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

    }
}
