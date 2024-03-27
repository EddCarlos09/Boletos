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
    public class VentaBoleto_Negocio
    {
        private VentaBoleto_Datos VentaBoleto;
        public VentaBoleto_Negocio()
        {
            try
            {
                VentaBoleto = new VentaBoleto_Datos();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void VenderBoletos(string Conexion, ref VentaBoleto InfoVentaBoletosAux, ref int Verificador, ref DataTable DatosBoletos)
        {
            try
            {
                VentaBoleto.VenderBoletos(Conexion, InfoVentaBoletosAux, ref Verificador, ref DatosBoletos);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ModificarNombreBoleto(string Conexion, Boleto Boleto, ref int Verificador)
        {
            try
            {
                VentaBoleto.ModificarNombreBoleto(Conexion, Boleto, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Busqueda BuscarVenta(string Conexion, Busqueda busqueda)
        {
            try
            {
                return VentaBoleto.BuscarVenta(Conexion, busqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
