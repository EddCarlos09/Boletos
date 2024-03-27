using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Cancelacion_Negocio
    {
        public void CancelacionVenta(VentaBoleto venta, MotivoCancelacionesTrasferencias motivo)
        {
            try
            {
                Cancelacion_Datos cd = new Cancelacion_Datos();
                cd.CancelacionVenta(venta, motivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelacionBoleto(Boleto boleto, MotivoCancelacionesTrasferencias motivo)
        {
            try
            {
                Cancelacion_Datos cd = new Cancelacion_Datos();
                cd.CancelacionBoleto(boleto,motivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarMotivoCancelacionesTrasferencias(string Conexion, ref List<MotivoCancelacionesTrasferencias> lstMotivoCancelacionesTrasferencias, int tipo)
        {
            try
            {
                Cancelacion_Datos cd = new Cancelacion_Datos();
                cd.CargarMotivoCancelacionesTrasferencias(Conexion, ref lstMotivoCancelacionesTrasferencias, tipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
