using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Chofer_Negocio
    {
        Chofer_Datos Chofer_Datos;
        public Chofer_Negocio()
        {
            try
            {
               Chofer_Datos = new Chofer_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Choferes
        public void ModificarChofer(string Conexion, Chofer Chofer, ref int Verificador)
        {
            try
            {
                Chofer_Datos.ModificarChofer(Conexion, Chofer, Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ModificarChofer" + ex.Message);
            }
        }
        public void InsertarChofer(string Conexion, Chofer Chofer, ref int Verificador)
        {
            try
            {
                Chofer_Datos.InsertarChofer(Conexion, Chofer, Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarChofer" + ex.Message);
            }
        }
        public void LlenarGridChofer(string Conexion, ref Chofer Choferes)
        {
            try
            {
                Chofer_Datos.LlenarGridChofer(Conexion, ref Choferes);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridChofer" + ex.Message);
            }
        }
        public void EliminarChofer(Chofer chofer, string Conexion, ref int Verificador)
        {
            try
            {
                Chofer_Datos.EliminarChofer(chofer, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error EliminarChofer" + ex.Message);
            }
        }
        #endregion

    }
}
