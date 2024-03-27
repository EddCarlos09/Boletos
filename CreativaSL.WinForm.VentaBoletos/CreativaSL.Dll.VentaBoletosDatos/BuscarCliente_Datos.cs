using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class BuscarCliente_Datos
    {
        public void BuscarGridCliente(string Conexion, int TipoBusq, ref Cliente Clientes, string BusquedaNombre)
        {
            try
            {
                object[] Valores = { TipoBusq, BusquedaNombre };
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "CatClienteBusqueda_Consulta_sp", Valores);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                                Clientes.Clientes = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
