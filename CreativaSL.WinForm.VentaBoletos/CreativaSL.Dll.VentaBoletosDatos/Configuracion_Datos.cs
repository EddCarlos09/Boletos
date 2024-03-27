using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using CreativaSL.Dll.VentaBoletosGlobal;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Configuracion_Datos
    {
        public Configuracion agregarConfiguracion(Configuracion actual)
        {
            try
            {
                object[] Valores = {
                                       string.IsNullOrEmpty(actual.idConfiguracion) ? 1 : 2,
                                       actual.idConfiguracion,
                                       actual.razonSocial,
                                       actual.rfc,
                                       actual.direccion,
                                       actual.logourl,
                                       actual.mensaje1,
                                       actual.mensaje2, 
                                       actual.mensaje3,
                                       Comun.id_sucursal,
                                       actual.macAddress,
                                       actual.namePrinter,
                                       actual.idCaja,
                                       actual.descripcion
                                    };
                actual.idConfiguracion = SqlHelper.ExecuteScalar(actual.strcnx, "abc_Configuracion", Valores).ToString();
                return actual;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Configuracion obtenerConfiguracion(Configuracion actual)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(actual.strcnx, "obtenerDatosGenerales", Comun.id_sucursal, Comun.macAdress);
                while (SqlDr.Read())
                {
                    actual.idConfiguracion = SqlDr.GetString(SqlDr.GetOrdinal("id_configuracion"));
                    actual.razonSocial = SqlDr.GetString(SqlDr.GetOrdinal("razonsocial"));
                    actual.rfc = SqlDr.GetString(SqlDr.GetOrdinal("rfc"));
                    actual.direccion = SqlDr.GetString(SqlDr.GetOrdinal("direccion"));
                    actual.mensaje1 = SqlDr.GetString(SqlDr.GetOrdinal("mensaje1"));
                    actual.mensaje2 = SqlDr.GetString(SqlDr.GetOrdinal("mensaje2"));
                    actual.mensaje3 = SqlDr.GetString(SqlDr.GetOrdinal("mensaje3"));
                    actual.namePrinter = SqlDr.GetString(SqlDr.GetOrdinal("nameprinter"));
                    actual.logourl = SqlDr.GetString(SqlDr.GetOrdinal("url_logo"));
                    actual.caja_name = SqlDr.GetString(SqlDr.GetOrdinal("caja"));
                    actual.descripcion = SqlDr.GetString(SqlDr.GetOrdinal("descripcion"));
                    actual.namePrinter = SqlDr.GetString(SqlDr.GetOrdinal("namePrinter"));
                    actual.macAddress = SqlDr.GetString(SqlDr.GetOrdinal("macAddress"));
                    actual.idCaja = SqlDr.GetString(SqlDr.GetOrdinal("idCaja"));
                }
                return actual;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
