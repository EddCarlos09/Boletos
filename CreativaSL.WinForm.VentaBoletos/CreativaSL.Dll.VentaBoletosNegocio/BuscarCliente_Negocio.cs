using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;
namespace CreativaSL.WinForm.VentaBoletos
{
    public class BuscarCliente_Negocio
    {
        private BuscarCliente_Datos buscarDatos;

        public void BuscarGridCliente(string Conexion, int TipoBusq, ref Cliente Cliente, string BusquedaNombre)
        {
            try
            {
                buscarDatos = new BuscarCliente_Datos();
                buscarDatos.BuscarGridCliente(Conexion, TipoBusq, ref Cliente, BusquedaNombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
