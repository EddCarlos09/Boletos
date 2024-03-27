using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Tarifa_Negocio
    {
        public Tarifa obtenerTarifas(Tarifa tarifas)
        {
            try
            {
                Tarifa_Datos td = new Tarifa_Datos();
                return td.obtenerTarifas(tarifas);
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
                Tarifa_Datos td = new Tarifa_Datos();
                td.ActualizarDatos(tarifas);
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
                Tarifa_Datos td = new Tarifa_Datos();
                return td.obtenerDataGridTarifas(tarifas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Tarifa obtenerTarifasSalidas(Tarifa tarifas)
        {
            try
            {
                Tarifa_Datos td = new Tarifa_Datos();
                return td.obtenerTarifasSalidas(tarifas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
