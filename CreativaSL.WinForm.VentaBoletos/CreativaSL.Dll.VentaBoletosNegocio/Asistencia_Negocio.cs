using CreativaSL.Dll.VentaBoletosDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Asistencia_Negocio
    {
        public void CargarComboViaje(string Conexion, ref Asistencia asistencia)
        {
            try
            {
                Asistencia_Datos asistencia_datos = new Asistencia_Datos();
                asistencia_datos.CargarComboViaje(Conexion, ref asistencia);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void CargarListaPasajeros(string Conexion, ref Asistencia asistencia)
        {
            try
            {
                Asistencia_Datos asistencia_datos = new Asistencia_Datos();
                asistencia_datos.CargarListaPasajeros(Conexion, ref asistencia);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AsistenciaPasjero(string Conexion, ref Asistencia asistencia, ref int Verificador)
        {
            try
            {
                Asistencia_Datos asistencia_datos = new Asistencia_Datos();
                asistencia_datos.AsistenciaPasjero(Conexion, ref asistencia, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
