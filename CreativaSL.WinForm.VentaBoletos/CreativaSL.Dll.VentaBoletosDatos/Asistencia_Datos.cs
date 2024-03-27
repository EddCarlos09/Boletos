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
    public class Asistencia_Datos
    {
        public void CargarComboViaje(string Conexion, ref Asistencia asistencia)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Comun.Conexion, "VistaCamionesT1-2_Combo_sp_Asistencia", asistencia.fechaViaje);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            asistencia.datosViajes = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarListaPasajeros(string Conexion, ref Asistencia asistencia)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Comun.Conexion, "ObtenerBoletosViaje_Asistencia", asistencia.id_viaje, asistencia.fechaViaje, asistencia.horaViaje);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            asistencia.datosPasajeros = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AsistenciaPasjero(string Conexion, ref Asistencia asistencia, ref int Verificador)
        {
            try
            {
                object[] Valores = { asistencia.folioBoleto, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "asistenciaPasajero", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
