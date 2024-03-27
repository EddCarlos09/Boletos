using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    #region SubMarca
    public class SubMarca_Datos
    {
        #region LlenarGrid
        public void LlenarGridSubMarca(string Conexion, ref SubMarca SubMarcas)
        {
            try
            {
                object[] Valores = { 3, 0 };
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "Obtener_Submarcas", Valores);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                                SubMarcas.SubMarcas = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Insertar
        public void InsertarSubMarca(SubMarca submarca, string Conexion, ref int Verificador)
        {
            try
            {
                object[] Valores = { submarca.nombreSubMarca, submarca.id_marca, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatSubMarca_Insertar", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Modificar
        public void ModificarSubMarca(SubMarca submarca, string Conexion, ref int Verificador)
        {
            try
            {

                object[] Valores = { submarca.id_submarca, submarca.nombreSubMarca, submarca.id_marca, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatSubMarca_Modificar", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Eliminar
        public void EliminarSubMarca(SubMarca submarca, string Conexion, ref int Verificador)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, "CatSubMarca_Eliminar", submarca.id_submarca);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region CargarCombo
        public void CargarComboMarcas(string Conexion, ref SubMarca SubMarcas)
        {
            try
            {
                SqlDataReader dr = null;
                SubMarca submarca;
                dr = SqlHelper.ExecuteReader(Conexion, "CatMarcas_Combo");
                submarca = new SubMarca();
                while (dr.Read())
                {
                    submarca = new SubMarca();
                    submarca.id_marca = Convert.ToInt32(dr["id_marca"].ToString());
                    submarca.nombreMarca = dr["marca"].ToString();
                    SubMarcas.lista_Marcas.Add(submarca);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
    #endregion
}
