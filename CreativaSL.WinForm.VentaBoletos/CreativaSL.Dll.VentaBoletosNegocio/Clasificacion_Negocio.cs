
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Clasificacion_Negocio
    {
        #region constructor
        ClasificacionCliente_Datos clasificacion;
        public Clasificacion_Negocio()
        {
            try
            {
                clasificacion = new ClasificacionCliente_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region METODOS

        public void LlenarGridClasificacion(string Conexion, ref ClasificacionCliente Clasificacion)
        {
            try
            {
                clasificacion.LlenarGridClasificacion(Conexion, ref Clasificacion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridMarca" + ex.Message);
            }
        }

        public ClasificacionCliente obtenerClasificaciones(ClasificacionCliente Clasificacion)
        {
            try
            {
                ClasificacionCliente_Datos ccd = new ClasificacionCliente_Datos();
                return ccd.obtenerClasificaciones(Clasificacion);
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
                clasificacion.agregarClasificacion(Clasificacion, Conexion, ref Verificador);                
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
                clasificacion.modificarClasificacion(Clasificacion, Conexion, ref Verificador);                
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void EliminarClasificacion( ClasificacionCliente Clasificacion, string Conexion, ref int Verificador)
        {
            try
            {
                clasificacion.EliminarClasificacion(Clasificacion, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error EliminarClasificacion" + ex.Message);
            }
        }
        #endregion
    }
}

