using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Management;
using System.Configuration;
using System.Data;


namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Comun_Datos
    {
        public void ObtenerConfiguracion(string conexion, string Cu_User, string Cu_Pass)
        {
            try
            {
                object[] Valores0 = { Cu_User};
                object res = SqlHelper.ExecuteScalar(conexion, "obtenerSucursalUsuario", Valores0);
                Comun.id_sucursal = Convert.ToString(res);

                SqlDataReader SqlDr = null;
                object[] Valores = { Comun.id_sucursal };
                SqlDr = SqlHelper.ExecuteReader(conexion, "obtenerConfiguracionInicial", Valores);
                while (SqlDr.Read())
                {
                    Comun.SucursalCaja = SqlDr.GetString(SqlDr.GetOrdinal("id_sucursal"));
                    Comun.Id_empresa = SqlDr.GetInt32(SqlDr.GetOrdinal("id_empresa"));
                    Comun.Id_tipoSucursal = SqlDr.GetInt32(SqlDr.GetOrdinal("id_tipoSucursal"));
                    Comun.Nombre_Sucursal = SqlDr.GetString(SqlDr.GetOrdinal("Nombre_Sucursal"));
                    Comun.Direccion = SqlDr.GetString(SqlDr.GetOrdinal("direccion"));
                    Comun.Telefono = SqlDr.GetString(SqlDr.GetOrdinal("telefono"));
                    Comun.Id_municipio = SqlDr.GetInt32(SqlDr.GetOrdinal("id_municipio"));
                    Comun.Id_estado = SqlDr.GetInt32(SqlDr.GetOrdinal("id_estado"));
                    Comun.Id_pais = SqlDr.GetInt32(SqlDr.GetOrdinal("id_pais"));
                    Comun.Codigopostal = SqlDr.GetInt32(SqlDr.GetOrdinal("codigopostal"));
                    Comun.ConfigPuntosPlata = SqlDr.GetInt32(SqlDr.GetOrdinal("rg_puntosPlata"));
                    Comun.ConfigPuntosOro = SqlDr.GetInt32(SqlDr.GetOrdinal("rg_puntosOro"));
                    Comun.ConfigTiempoEspera = SqlDr.GetInt32(SqlDr.GetOrdinal("tiempo_espera"));
                    Comun.ConfigTiempoCobro = SqlDr.GetInt32(SqlDr.GetOrdinal("tiempo_cobro"));
                    Comun.ipservidor = SqlDr.GetOrdinal("ip_servidor").ToString();
                    Comun.porcentaje_puntos = (float)SqlDr.GetDecimal(SqlDr.GetOrdinal("porcentajeMonedero"));
                    Comun.monto_cancelacion = (float)SqlDr.GetDecimal(SqlDr.GetOrdinal("monto_cancelacion"));
                    Comun.ImpuestoBoletos = 0.16F;
                    Comun.macAdress = this.GetMACAddress();
                    Comun.anticipoMinimo = (float)SqlDr.GetDecimal(SqlDr.GetOrdinal("monto_cancelacion"));
                    Comun.razonsocial_ticket = SqlDr.GetString(SqlDr.GetOrdinal("razonsocial"));
                    Comun.rfc_ticket = SqlDr.GetString(SqlDr.GetOrdinal("rfc"));
                    Comun.mensaje1_ticket = SqlDr.GetString(SqlDr.GetOrdinal("mensaje1"));
                    Comun.mensaje2_ticket = SqlDr.GetString(SqlDr.GetOrdinal("mensaje2"));
                    Comun.mensaje3_ticket = SqlDr.GetString(SqlDr.GetOrdinal("mensaje3"));
                    Comun.nombresucursal_ticket = SqlDr.GetString(SqlDr.GetOrdinal("Nombre_Sucursal"));
                    Comun.direccion_ticket = SqlDr.GetString(SqlDr.GetOrdinal("direccion"));
                    Comun.municipio_ticket = SqlDr.GetString(SqlDr.GetOrdinal("municipio"));
                    Comun.estado_ticket = SqlDr.GetString(SqlDr.GetOrdinal("estado"));
                    Comun.codigopostal_ticket = SqlDr.GetInt32(SqlDr.GetOrdinal("codigopostal")).ToString();
                    Comun.namePrinter_ticket = SqlDr.GetString(SqlDr.GetOrdinal("nameprinter"));
                    Comun.url_logo_ticket = SqlDr.GetString(SqlDr.GetOrdinal("url_logo"));
                    
                    Comun.error_ticket = false;
                }

                DataSet ds = SqlHelper.ExecuteDataset(conexion, "obtenerMaximoDescuentoLinea");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                             Comun.MaximoDescuentoLinea = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetMACAddress()
        {
            try
            {
                ManagementObjectSearcher objMOS = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
                ManagementObjectCollection objMOC = objMOS.Get();
                string MACAddress = String.Empty;
                foreach (ManagementObject objMO in objMOC)
                {
                    if (MACAddress == String.Empty) 
                    {
                        MACAddress = objMO["MacAddress"].ToString();
                    }
                    objMO.Dispose();
                }
                if (Convert.ToBoolean(ConfigurationManager.AppSettings.Get("strBanMac")))
                {
                    MACAddress = ConfigurationManager.AppSettings.Get("strMac");
                }
                return MACAddress;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
