using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class ClasificacionCliente_Datos
    {
        public void LlenarGridClasificacion(string Conexion, ref ClasificacionCliente Clasificacion)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "Customer.spCF_get_ClasificacionClientes");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            Clasificacion.dataTable_Clasificaciones = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ClasificacionCliente obtenerClasificaciones(ClasificacionCliente Clasificacion)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Clasificacion.strcnx, "Customer.spCF_get_ClasificacionClientes");                     
                return Clasificacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarClasificacion(ClasificacionCliente Clasificacion, string Conexion, ref int Verificador)
        {
            try
            {
                object[] Valores =
                {                    
                    Clasificacion.Descripcion,
                    Clasificacion.PorcentajeConver,
                    Comun.Id_U
                };
                object result = SqlHelper.ExecuteScalar(Conexion, "Customer.spCF_set_Clasificacion", Valores);                
                Verificador = Convert.ToInt32(result);                
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void modificarClasificacion(ClasificacionCliente Clasificacion, string Conexion, ref int Verificador)
        {
            try
            {                
                object[] Valores =
                {
                    Clasificacion.IDClasificacion,
                    Clasificacion.Descripcion,
                    Clasificacion.PorcentajeConver,
                    Comun.Id_U
                };                
                object res = SqlHelper.ExecuteScalar(Conexion, "Customer.spCF_set_ModificarClasificacionClientes", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
      
        public void EliminarClasificacion(ClasificacionCliente Clasificacion, string Conexion, ref int Verificador)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, "Customer.spCF_set_EliminarClasificacionCliente", Clasificacion.IDClasificacion);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }                   
    }
}
