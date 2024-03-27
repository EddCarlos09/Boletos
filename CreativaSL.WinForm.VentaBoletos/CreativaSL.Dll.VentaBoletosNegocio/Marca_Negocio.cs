using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    #region Marca_Negocio
    public class Marca_Negocio
    {
        #region constructor
        Marca_Datos Marca;
        public Marca_Negocio()
        {
            try
            {
                Marca = new Marca_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Métodos

        #region LlenarGrid
        public void LlenarGridMarca(string Conexion, ref Marca Marcas)
        {
            try
            {
                Marca.LlenarGridMarca(Conexion, ref Marcas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridMarca" + ex.Message);
            }
        }
        #endregion
        #region Insertar
        public void InsertarMarca(Marca marca, string Conexion, ref int Verificador)
        {
            try
            {
                Marca.InsertarMarca(marca, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarMarca" + ex.Message);
            }
        }
        #endregion
        #region Modificar
        public void ModificarMarca(Marca marca, string Conexion, ref int Verificador)
        {
            try
            {
                Marca.ModificarMarca(marca, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ModificarMarca" + ex.Message);
            }
        }
        #endregion
        #region Eliminar
        public void EliminarMarca(Marca marca, string Conexion, ref int Verificador)
        {
            try
            {
                Marca.EliminarMarca(marca, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error EliminarMarca" + ex.Message);
            }
        }
        #endregion

        #endregion
    }
    #endregion
}
