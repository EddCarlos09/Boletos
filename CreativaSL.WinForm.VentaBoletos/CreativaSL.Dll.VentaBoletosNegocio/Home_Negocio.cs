using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Home_Negocio
    {
        Home_Datos home;
        public Home_Negocio()
        {
            try
            {
                home = new Home_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LlenarGridSalidas(string Conexion, ref Home homes , string IDTerminalOrigen , string IDTerminalDestino, DateTime FechaBusqueda)
        {
            try
            {
                home.LlenarGridSalidas(Conexion, ref homes, IDTerminalOrigen, IDTerminalDestino, FechaBusqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ObtenerDatosCamion(string Conexion, ref Home homes)
        {
            try
            {
                home.ObtenerDatosCamion(Conexion, ref homes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ApartarAsiento(string Conexion, string IDViaje , int Asiento, string IDCamionDiseño,  DateTime FechaSalida, string HoraSalida, int OrdenOrigen, int OrdenDestino, ref string Verificador)
        {
            try
            {
                home.ApartarAsiento(Conexion, IDViaje ,Asiento, IDCamionDiseño, FechaSalida, HoraSalida, OrdenOrigen, OrdenDestino, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarAsientosApartados(string Conexion, DataTable NuevaVenta, ref int Verificador)
        {
            try
            {
                home.EliminarAsientosApartados(Conexion, NuevaVenta, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboTerminales(string Conexion, ref Home homes)
        {
            try
            {
                home.CargarComboTerminales(Conexion, ref homes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LiberarAsientoApartadosPorTiempoSistema(string Conexion)
        {
            try
            {
                home.LiberarAsientoApartadosPorTiempoSistema(Conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
