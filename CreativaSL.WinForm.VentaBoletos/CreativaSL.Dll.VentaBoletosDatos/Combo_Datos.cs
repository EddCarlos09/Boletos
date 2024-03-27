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
    public class Combo_Datos
    {
        public List<CatEstados> ObtenerComboEstados(string Conexion, bool IncluirSelect)
        {
            try
            {
                List<CatEstados> Lista = new List<CatEstados>();
                CatEstados Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, CommandType.StoredProcedure, "Combos.spCF_get_Estados", new SqlParameter("@IncluirSelect", IncluirSelect));
                while (Dr.Read())
                {
                    Item = new CatEstados();
                    Item.IDEstado = !Dr.IsDBNull(Dr.GetOrdinal("IDEstado")) ? Dr.GetInt32(Dr.GetOrdinal("IDEstado")) : 0;
                    Item.EstadoDesc = !Dr.IsDBNull(Dr.GetOrdinal("EstadoDesc")) ? Dr.GetString(Dr.GetOrdinal("EstadoDesc")) : string.Empty;
                    Lista.Add(Item);
                }
                Dr.Close();
                //Lista.Add(new CatEstados { IDEstado = 1, EstadoDesc = "Chiapas" });
                return Lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<CatMunicipio> ObtenerComboMunicipios(string Conexion, int IDEstado, bool IncluirSelect)
        {
            try
            {
                List<CatMunicipio> Lista = new List<CatMunicipio>();
                CatMunicipio Item;
                object[] Parametros = { IDEstado, IncluirSelect };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, "Combos.spCF_get_Municipios", Parametros);
                while (Dr.Read())
                {
                    Item = new CatMunicipio();
                    Item.IDMunicipio = !Dr.IsDBNull(Dr.GetOrdinal("IDMunicipio")) ? Dr.GetInt32(Dr.GetOrdinal("IDMunicipio")) : 0;
                    Item.MunicipioDesc = !Dr.IsDBNull(Dr.GetOrdinal("MunicipioDesc")) ? Dr.GetString(Dr.GetOrdinal("MunicipioDesc")) : string.Empty;
                    Lista.Add(Item);
                }
                Dr.Close();
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ClasificacionCliente> ObtenerComboClasificacion(string Conexion, bool IncluirSelect)
        {
            try
            {
                List<ClasificacionCliente> Lista = new List<ClasificacionCliente>();
                ClasificacionCliente Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, CommandType.StoredProcedure, "Combos.spCF_get_Clasificacion", new SqlParameter("@IncluirSelect", IncluirSelect));
                while (Dr.Read())
                {
                    Item = new ClasificacionCliente();
                    Item.IDClasificacion = !Dr.IsDBNull(Dr.GetOrdinal("IDClasificacion")) ? Dr.GetInt32(Dr.GetOrdinal("IDClasificacion")) : 0;
                    Item.Descripcion = !Dr.IsDBNull(Dr.GetOrdinal("Descripcion")) ? Dr.GetString(Dr.GetOrdinal("Descripcion")) : string.Empty;
                    Item.Porcentaje = !Dr.IsDBNull(Dr.GetOrdinal("Porcentaje")) ? Dr.GetDecimal(Dr.GetOrdinal("Porcentaje")) : 0;
                    if (Item.IDClasificacion != 0)
                    {
                        Item.Porcentaje = Decimal.Round(Item.Porcentaje * 100, 2);
                        Item.Descripcion += " " + Item.Porcentaje + "%";
                    }
                    Lista.Add(Item);
                }
                //Lista.Add(new V2ClasificacionCliente { IDClasificacion = 1, Descripcion = "Cliente frecuente" });
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
