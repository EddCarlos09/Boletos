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
    public class V2Tarjeta_Datos
    {
        public List<V2Tarjeta> ObtenerClientesXPagina(string Conexion, int Page, int MaxRows)
        {
            try
            {
                List<V2Tarjeta> Lista = new List<V2Tarjeta>();
                V2Tarjeta Item;
                object[] Parametros = { Page, MaxRows };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, "Customer.spCF_get_TarejetasXPagina", Parametros);
                while (Dr.Read())
                {
                    Item = new V2Tarjeta
                    {
                        IDTarjeta = !Dr.IsDBNull(Dr.GetOrdinal("IDTarjeta")) ? Dr.GetInt32(Dr.GetOrdinal("IDTarjeta")) : 0,
                        Folio = !Dr.IsDBNull(Dr.GetOrdinal("Folio")) ? Dr.GetString(Dr.GetOrdinal("Folio")) : string.Empty,
                    };
                    Lista.Add(Item);
                }
                Dr.Close();
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<V2Tarjeta> ObtenerTarjetasXPagina(string Conexion)
        {
            try
            {
                List<V2Tarjeta> Lista = new List<V2Tarjeta>();
                V2Tarjeta Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, "Customer.spCF_get_TarejetasTotalXPagina");
                while (Dr.Read())
                {
                    Item = new V2Tarjeta
                    {
                        IDTarjeta = !Dr.IsDBNull(Dr.GetOrdinal("IDTarjeta")) ? Dr.GetInt32(Dr.GetOrdinal("IDTarjeta")) : 0,
                        Folio = !Dr.IsDBNull(Dr.GetOrdinal("Folio")) ? Dr.GetString(Dr.GetOrdinal("Folio")) : string.Empty,
                        Estatus = !Dr.IsDBNull(Dr.GetOrdinal("Estatus")) ? Dr.GetInt32(Dr.GetOrdinal("Estatus")) : 0,
                    };
                    Lista.Add(Item);
                }
                Dr.Close();
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarGridTarjeta(string Conexion, ref V2Tarjeta Tarjeta)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "Customer.spCF_get_TarejetasTotalXPagina");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            Tarjeta.FolioTarjeta = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerarFolio(String Conexion, ref int Verificador, int cantidad)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, "Customer.spCF_GenerarFolio", Comun.Id_U, cantidad);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
