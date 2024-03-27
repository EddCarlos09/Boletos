using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Apartados_Negocio
    {
        private Apartados_Datos Apartado;
        public Apartados_Negocio()
        {
            try
            {
                Apartado = new Apartados_Datos();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public Busqueda BuscarBoletos(string Conexion, Busqueda datos)
        {
            try
            {
                return Apartado.BuscarBoletos(Conexion , datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void PagarBoleto(string Conexion, ref Apartados apartados, ref int Verificador)
        {
            try
            {
                Apartado.PagarBoleto(Conexion, ref apartados, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void PagarBoleto2(string Conexion, ref Apartados apartados, ref int Verificador)
        {
            try
            {
                Apartado.PagarBoleto2(Conexion, ref apartados, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
