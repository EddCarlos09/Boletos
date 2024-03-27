using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class TipoDocumento_Datos
    {
        public List<TipoDocumento> LlenarComboDocumentos(TipoDocumento datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<TipoDocumento> lista = new List<TipoDocumento>();
                TipoDocumento docto;
                dr = SqlHelper.ExecuteReader(datos.conexion, "getDatosComboDoctos_sp");
                while (dr.Read())
                {
                    docto = new TipoDocumento();
                    docto.id_tipoDocumento = dr.GetString(dr.GetOrdinal("id"));
                    docto.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));
                    lista.Add(docto);
                }
                dr.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
