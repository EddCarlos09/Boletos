using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Maletas_Negocio
    {
        private Maletas_Datos maletas_datos;
        public Maletas_Negocio()
        {
            maletas_datos = new Maletas_Datos();
        }

        public void AgregarMaletas(string Conexion, ref int Verificador, ref Maletas infoMaletas)
        {
            try
            {
                maletas_datos.AgregarMaletas(Conexion, ref Verificador, ref infoMaletas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarMaletas(string Conexion, ref int Verificador, ref Maletas infoMaletas)
        {
            try
            {
                 maletas_datos.EliminarMaletas(Conexion, ref Verificador, ref infoMaletas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarGridMaletas(string Conexion, ref DataTable maletas, string id_boleto)
        {
            try
            {
                maletas_datos.LlenarGridMaletas(Conexion, ref maletas, id_boleto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
