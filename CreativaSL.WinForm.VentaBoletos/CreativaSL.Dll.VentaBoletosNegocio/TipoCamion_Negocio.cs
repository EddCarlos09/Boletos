using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    #region TipoCamion
    public class TipoCamion_Negocio
    {
        #region Constructor
        TipoCamion_Datos TipoCamion;
        public TipoCamion_Negocio()
        {
            try
            {
                TipoCamion = new TipoCamion_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Métodos
        #region LlenarGrid
        public void LlenarGridTipoCamion(string Conexion, ref TipoCamion TipoCamiones)
        {
            try
            {
                TipoCamion.LlenarGridTipoCamion(Conexion, ref TipoCamiones);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridTipoCamion" + ex.Message);
            }
        }
        #endregion
        #region Insertar
        public void InsertarTipoCamion(TipoCamion tipocamion, string Conexion, ref int Verificador)
        {
            try
            {
                TipoCamion.InsertarTipoCamion(tipocamion, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarTipoCamion" + ex.Message);
            }
        }
        #endregion
        #region Modificar
        public void ModificarTipoCamion(TipoCamion tipocamion, string Conexion, ref int Verificador)
        {
            try
            {
                TipoCamion.ModificarTipoCamion(tipocamion, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ModificarTipoCamion" + ex.Message);
            }
        }
        #endregion
        #region Eliminar
        public void EliminarTipoCamion(TipoCamion tipocamion, string Conexion, ref int Verificador)
        {
            try
            {
                TipoCamion.EliminarTipoCamion(tipocamion, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error EliminarTipoCamion" + ex.Message);
            }
        }
        #endregion
        #endregion
    }
    #endregion
}
