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
    public class DisenioCamion_Negocio
    {
        DisenioCamion_Datos Disenio_Camion;
        public DisenioCamion_Negocio()
        {
            try
            {
                Disenio_Camion = new DisenioCamion_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Disenio
        public void ModificarDisenio(string Conexion, DisenioCamion DisenioCamion, ref int Verificador)
        {
            try
            {
                Disenio_Camion.ModificarDisenio(Conexion, DisenioCamion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ModificarDisenio" + ex.Message);
            }
        }
        public void InsertarDisenio(string Conexion, DisenioCamion DisenioCamion, ref int Verificador)
        {
            try
            {
                Disenio_Camion.InsertarDisenio(Conexion, DisenioCamion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarDisenio" + ex.Message);
            }
        }
        public void LlenarGridDisenio(string Conexion, ref DisenioCamion DisenioCamion)
        {
            try
            {
                Disenio_Camion.LlenarGridDisenio(Conexion, ref DisenioCamion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridDisenio" + ex.Message);
            }
        }
        public void EliminarDisenio(DisenioCamion DisenioCamion, string Conexion, ref int Verificador)
        {
            try
            {
                Disenio_Camion.EliminarDisenio(Conexion, DisenioCamion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error EliminarDisenio" + ex.Message);
            }
        }
        public void ObtenerDatosCamion(string Conexion, ref DataTable DatosAuxObject, string IDDiseñoCamion)
        {
            try
            {
                Disenio_Camion.ObtenerDatosCamion(Conexion, ref DatosAuxObject, IDDiseñoCamion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ObtenerDatosCamion" + ex.Message);
            }
        }
        #endregion

    }
}
