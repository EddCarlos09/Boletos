using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Tarifa_Datos
    {
        public Tarifa obtenerTarifas(Tarifa tarifas)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(tarifas.strcnx, "Obtener_TerminalesxRutaxViaje", 1, tarifas.id_viaje);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            tarifas.datatable_tarifas = ds.Tables[0];
                        }
                    }
                }
                return tarifas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarDatos(Tarifa tarifas)
        {
            try
            {
                object[] Valores;

                foreach (Tarifa tarifa in tarifas.listaTarifas)
                {
                    Valores = new object[] { 
                        string.IsNullOrEmpty(tarifa.id_tarifa) ? 1:2,
                        tarifa.id_tarifa,
                        tarifa.id_viaje,
                        tarifa.id_terminalXruta,
                        tarifa.precioNormal1piso,
                        tarifa.precioInfantil1piso,
                        tarifa.precioTerceraEdad1piso,
                        tarifa.precioEspecial1piso,
                        tarifa.precioNormal2piso,
                        tarifa.precioInfantil2piso,
                        tarifa.precioTerceraEdad2piso,
                        tarifa.precioEspecial2piso,
                        Comun.Id_U                        
                        };
                    SqlHelper.ExecuteNonQuery(tarifas.strcnx, "abc_CatViajeXTarifas", Valores);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Tarifa obtenerDataGridTarifas(Tarifa tarifas)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(tarifas.strcnx, "Obtener_tarifas");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            tarifas.datatable_tarifas = ds.Tables[0];
                        }
                    }
                }
                return tarifas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Tarifa obtenerTarifasSalidas(Tarifa tarifas)
        {
            SqlDataReader dr = null;
            dr = SqlHelper.ExecuteReader(tarifas.strcnx, "Obtener_TerminalesxRutaxViaje", 1, tarifas.id_viaje);
            Tarifa auxTarifas;
            while (dr.Read())
            {
                auxTarifas = new Tarifa(Comun.Conexion);
                auxTarifas.id_viaje = Convert.ToString(dr["id_viaje"].ToString());
                auxTarifas.id_tarifa = Convert.ToString(dr["id_tarifa"].ToString());
                auxTarifas.id_viaje = Convert.ToString(dr["id_identificador"].ToString());
                auxTarifas.id_terminalXruta = Convert.ToString(dr["id_terminalXruta"].ToString());
                auxTarifas.id_terminalOrigen = Convert.ToString(dr["id_terminalOrigen"].ToString());
                auxTarifas.id_terminalDestino = Convert.ToString(dr["id_terminalDestino"].ToString());
                auxTarifas.precioEspecial1piso = Convert.ToSingle(dr["precioEspecial1"].ToString());
                auxTarifas.precioEspecial2piso = Convert.ToSingle(dr["precioEspecial2"].ToString());
                auxTarifas.precioInfantil1piso = Convert.ToSingle(dr["precioInfantil1"].ToString());
                auxTarifas.precioInfantil2piso = Convert.ToSingle(dr["precioInfantil2"].ToString());
                auxTarifas.precioNormal1piso = Convert.ToSingle(dr["precioNormal1"].ToString());
                auxTarifas.precioNormal2piso = Convert.ToSingle(dr["precioNormal2"].ToString());
                auxTarifas.precioTerceraEdad1piso = Convert.ToSingle(dr["precioTerceraEdad1"].ToString());
                auxTarifas.precioTerceraEdad2piso = Convert.ToSingle(dr["precioTerceraEdad2"].ToString());
                auxTarifas.indice = Convert.ToInt32(dr["indice"].ToString());
                auxTarifas.id_tipoTerminal = Convert.ToInt32(dr["id_tipoTerminal"].ToString()); 
                tarifas.listaTarifas.Add(auxTarifas);
            }
            return tarifas;
        }
    }
}
