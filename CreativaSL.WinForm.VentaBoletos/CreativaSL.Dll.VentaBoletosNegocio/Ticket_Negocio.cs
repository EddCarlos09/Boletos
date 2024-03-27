using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Ticket_Negocio
    {
        public Boleto obtenerDatosBoleto(Boleto boleto)
        {
            try
            {
                Ticket_Datos td = new Ticket_Datos();
                return td.obtenerDatosBoleto(boleto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Maletas obtenerDatosMaleta(string Conexion,string id_boleto, string id_maleta)
        {
            try
            {
                Ticket_Datos td = new Ticket_Datos();
                return td.obtenerDatosMaleta(Conexion, id_boleto, id_maleta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
