using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    #region SubMarca_Negocio
    public class SubMarca_Negocio
    {
        #region Constructor
        SubMarca_Datos SubMarca;
        public SubMarca_Negocio()
        {
            try
            {
                SubMarca = new SubMarca_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Métodos
        #region LlenarGrid
        public void LlenarGridSubMarca(string Conexion, ref SubMarca SubMarcas)
        {
            try
            {
                SubMarca.LlenarGridSubMarca(Conexion, ref SubMarcas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridsubMarca" + ex.Message);
            }
        }
        #endregion
        #region Insertar
        public void InsertarSubMarca(SubMarca submarca, string Conexion, ref int Verificador)
        {
            try
            {
                SubMarca.InsertarSubMarca(submarca, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarSubMarca" + ex.Message);
            }
        }
        #endregion
        #region Modificar
        public void ModificarSubMarca(SubMarca submarca, string Conexion, ref int Verificador)
        {
            try
            {
                SubMarca.ModificarSubMarca(submarca, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ModificarSubMarca" + ex.Message);
            }
        }
        #endregion
        #region Eliminar
        public void EliminarSubMarca(SubMarca submarca, string Conexion, ref int Verificador)
        {
            try
            {
                SubMarca.EliminarSubMarca(submarca, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error EliminarSubMarca" + ex.Message);
            }
        }
        #endregion
        #region CargarComboMarcas
        public void CargarComboMarcas(string Conexion, ref SubMarca SubMarcas)
        {
            try
            {
                SubMarca.CargarComboMarcas(Conexion, ref SubMarcas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboMarcas" + ex.Message);
            }
        }
        #endregion

        #endregion
    }
    #endregion
}
