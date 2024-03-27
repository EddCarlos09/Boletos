using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class CambioCamionBoletos_Negocio
    {
        private CambioCamionBoletos_Datos cambioCamionDatos;

        public CambioCamionBoletos_Negocio()
        {
            try
            {
                cambioCamionDatos = new CambioCamionBoletos_Datos();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Ruta Obtener_RutasViajesxIDRutaxFecha(Ruta ruta)
        {
            try
            {
                return cambioCamionDatos.Obtener_RutasViajesxIDRutaxFecha(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Ruta Obtener_RutasViajesxIDRutaCompleto(Ruta ruta)
        {
            try
            {
                return cambioCamionDatos.Obtener_RutasViajesxIDRutaCompleto(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarCombos(string Conexion, ref CambioCamion Cambio_Camion, DateTime FechaBusq)
        {
            try
            {
                cambioCamionDatos.CargarCombos(Conexion, ref Cambio_Camion, FechaBusq);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ObtenerBoletosViajesXRutasByFechas(string Conexion, Ruta ruta, Boleto boleto,DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                cambioCamionDatos.ObtenerBoletosViajesXRutasByFechas(Conexion, ruta, boleto, FechaInicio, FechaFin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ObtenerBoletosViajesXRutasByOneFecha(string Conexion, Ruta ruta, Boleto boleto)
        {
            try
            {
                cambioCamionDatos.ObtenerBoletosViajesXRutasByOneFecha(Conexion, ruta, boleto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CambiarBoletos(string Conexion, DataTable datosBoletos, ref int Verificador)
        {
            try
            {
                cambioCamionDatos.CambiarBoletos(Conexion, datosBoletos, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
