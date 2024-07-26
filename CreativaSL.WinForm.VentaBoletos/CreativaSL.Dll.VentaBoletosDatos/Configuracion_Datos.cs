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
                    actual.calle = SqlDr.GetString(SqlDr.GetOrdinal("calle"));
                    actual.noExterior = SqlDr.GetString(SqlDr.GetOrdinal("no_exterior"));
                    actual.noInterior = SqlDr.GetString(SqlDr.GetOrdinal("no_interior"));
                    actual.colonia = SqlDr.GetString(SqlDr.GetOrdinal("colonia"));
                    actual.localidad = SqlDr.GetString(SqlDr.GetOrdinal("localidad"));
                    actual.municipio = SqlDr.GetString(SqlDr.GetOrdinal("municipio"));
                    actual.estado = SqlDr.GetString(SqlDr.GetOrdinal("estado"));
                    actual.pais = SqlDr.GetString(SqlDr.GetOrdinal("pais"));
                    actual.telefono = SqlDr.GetString(SqlDr.GetOrdinal("telefono"));

                }
                return actual;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DatosFacturaEmisor obtenerConfiguracionFactura(DatosFacturaEmisor emisor)
        {
            try
            {
                SqlDataReader SqlDr = null;
                SqlDr = SqlHelper.ExecuteReader(emisor.strcnx, "obtenerDatosFacturaEmisor");
                if (SqlDr.HasRows) // Verificar si hay filas en el resultado
                {
                    while (SqlDr.Read())
                    {
                        emisor.idDatosEmisor = SqlDr.GetString(SqlDr.GetOrdinal("id_cfdiDatosEmisor"));
                        emisor.razonSocial = SqlDr.GetString(SqlDr.GetOrdinal("razonSocial"));
                        emisor.rfc = SqlDr.GetString(SqlDr.GetOrdinal("rfc"));
                        emisor.cp = SqlDr.GetString(SqlDr.GetOrdinal("codigoPostal"));
                        emisor.correo = SqlDr.GetString(SqlDr.GetOrdinal("correo"));
                        emisor.noCertificado = SqlDr.GetString(SqlDr.GetOrdinal("noCertificado"));
                        int passwordKeyOrdinal = SqlDr.GetOrdinal("passwordArchivoKEY");
                        if (!SqlDr.IsDBNull(passwordKeyOrdinal))
                        {
                            long length = SqlDr.GetBytes(passwordKeyOrdinal, 0, null, 0, 0); // Get the length of data
                            byte[] buffer = new byte[length];
                            SqlDr.GetBytes(passwordKeyOrdinal, 0, buffer, 0, (int)length); // Read the data into buffer
                            emisor.passwordKey = buffer;
                        }
                        emisor.archivoCer = SqlDr.GetString(SqlDr.GetOrdinal("ArchivoCER"));
                        emisor.archivoKey = SqlDr.GetString(SqlDr.GetOrdinal("ArchivoKEY"));
                    }
                }
                else
                {
                    
                    emisor.idDatosEmisor = null;
                    emisor.razonSocial = null;
                    emisor.rfc = null;
                    emisor.cp = null;
                    emisor.correo = null;
                    emisor.passwordKey = null;
                    emisor.archivoCer = null;
                    emisor.archivoKey = null;
                    emisor.noCertificado = null;
                }
                return emisor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DatosFacturaEmisor agregarConfiguracionEmisor(DatosFacturaEmisor actual)
        {
            try
            {
                object[] Valores = {
                                       actual.idDatosEmisor ?? (object)DBNull.Value,
                                       actual.razonSocial,
                                       actual.rfc,
                                       actual.cp,
                                       actual.correo,
                                       actual.passwordKey,
                                       actual.salt,
                                       actual.archivoCer,
                                       actual.archivoKey,
                                       actual.noCertificado,
                                       Comun.Id_U,
                                    };
                actual.idDatosEmisor = SqlHelper.ExecuteScalar(actual.strcnx, "insertar_configuracion_emisor_sp", Valores).ToString();
                return actual;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
