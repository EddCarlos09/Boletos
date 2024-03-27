using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class PorcentajeMonedero_Negocio
    {
        private PorcentajeMonedero_Datos porcentajeMonedero_Datos;
        public PorcentajeMonedero_Negocio()
        {
            try
            {
                porcentajeMonedero_Datos = new PorcentajeMonedero_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ModificarPorcentajeMonedero(PorcentajeMonedero porcentajeMonedero, string Conexion, ref int Verificador)
        {
            try
            {
               porcentajeMonedero_Datos.ModificarPorcentajeMonedero(porcentajeMonedero, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarGridPorcentajeMonedero(string Conexion, ref PorcentajeMonedero PorcentajeMonedero)
        {
            try
            {
                porcentajeMonedero_Datos.LlenarGridPorcentajeMonedero(Conexion, ref PorcentajeMonedero);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarPorcentajeMonedero(PorcentajeMonedero PorcentajeMonedero, string Conexion, ref int Verificador)
        {
        }
    }
}
