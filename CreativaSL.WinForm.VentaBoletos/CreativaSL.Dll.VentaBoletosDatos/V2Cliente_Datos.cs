using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class V2Cliente_Datos
    {
        public List<V2Cliente> ObtenerClientesXPagina(string Conexion, int Page, int MaxRows, bool EsBusqueda, int TipoBusqueda, string Busqueda )
        {
            try
            {
                List<V2Cliente> Lista = new List<V2Cliente>();
                V2Cliente Item;
                object[] Parametros = { Page, MaxRows, EsBusqueda, Busqueda, TipoBusqueda };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, "Customer.spCF_get_ClientesXPagina", Parametros);
                while (Dr.Read())
                {
                    Item = new V2Cliente
                    {
                        IDCliente = !Dr.IsDBNull(Dr.GetOrdinal("IDCliente")) ? Dr.GetInt32(Dr.GetOrdinal("IDCliente")) : 0,
                        Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty,
                        CodigoTarjeta = !Dr.IsDBNull(Dr.GetOrdinal("Codigo")) ? Dr.GetString(Dr.GetOrdinal("Codigo")) : string.Empty,
                        Domicilio = !Dr.IsDBNull(Dr.GetOrdinal("Domicilio")) ? Dr.GetString(Dr.GetOrdinal("Domicilio")) : string.Empty,
                        Email = !Dr.IsDBNull(Dr.GetOrdinal("Email")) ? Dr.GetString(Dr.GetOrdinal("Email")) : string.Empty,
                        RFC = !Dr.IsDBNull(Dr.GetOrdinal("RFC")) ? Dr.GetString(Dr.GetOrdinal("RFC")) : string.Empty,
                        TelefonoCelular = !Dr.IsDBNull(Dr.GetOrdinal("Celular")) ? Dr.GetString(Dr.GetOrdinal("Celular")) : string.Empty,
                        Telefono = !Dr.IsDBNull(Dr.GetOrdinal("Telefono")) ? Dr.GetString(Dr.GetOrdinal("Telefono")) : string.Empty,
                        ClasificacionDesc = !Dr.IsDBNull(Dr.GetOrdinal("ClasificacionDesc")) ? Dr.GetString(Dr.GetOrdinal("ClasificacionDesc")) : string.Empty,
                        FechaNacimiento = !Dr.IsDBNull(Dr.GetOrdinal("FechaNacimiento")) ? Dr.GetDateTime(Dr.GetOrdinal("FechaNacimiento")) : DateTime.MinValue,
                        FechaAlta = !Dr.IsDBNull(Dr.GetOrdinal("FechaAlta")) ? Dr.GetDateTime(Dr.GetOrdinal("FechaAlta")) : DateTime.MinValue
                    };
                    Lista.Add(Item);
                }
                Dr.Close();
                return Lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obtener el los datos del cliente JM/02/12
        /// </summary>
        /// <param name="Conexion"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public V2Cliente ObtenerClientesXID(string Conexion, int ID)
        {
            V2Cliente Item = new V2Cliente();
            SqlDataReader Dr = SqlHelper.ExecuteReader(Conexion, "Customer.spCF_get_ClientesXID", ID);
            while (Dr.Read())
            {
                    Item.Empresa = !Dr.IsDBNull(Dr.GetOrdinal("Empresa")) ? Dr.GetString(Dr.GetOrdinal("Empresa")) : string.Empty;
                    Item.Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty;
                    Item.Domicilio = !Dr.IsDBNull(Dr.GetOrdinal("Domicilio")) ? Dr.GetString(Dr.GetOrdinal("Domicilio")) : string.Empty;
                    Item.Cruces = !Dr.IsDBNull(Dr.GetOrdinal("Cruces")) ? Dr.GetString(Dr.GetOrdinal("Cruces")) : string.Empty;
                    Item.Colonia = !Dr.IsDBNull(Dr.GetOrdinal("Colonia")) ? Dr.GetString(Dr.GetOrdinal("Colonia")) : string.Empty;
                    Item.CodigoPostal = !Dr.IsDBNull(Dr.GetOrdinal("CodigoPostal")) ? Dr.GetString(Dr.GetOrdinal("CodigoPostal")) : string.Empty;
                    Item.IDEstado = !Dr.IsDBNull(Dr.GetOrdinal("IDEstado")) ? Dr.GetInt32(Dr.GetOrdinal("IDEstado")) : 0;
                    Item.IDMunicipio = !Dr.IsDBNull(Dr.GetOrdinal("IDMunicipio")) ? Dr.GetInt32(Dr.GetOrdinal("IDMunicipio")) : 0;
                    Item.Email = !Dr.IsDBNull(Dr.GetOrdinal("Email")) ? Dr.GetString(Dr.GetOrdinal("Email")) : string.Empty;
                    Item.RFC = !Dr.IsDBNull(Dr.GetOrdinal("RFC")) ? Dr.GetString(Dr.GetOrdinal("RFC")) : string.Empty;
                    Item.FechaNacimiento = !Dr.IsDBNull(Dr.GetOrdinal("FechaNacimiento")) ? Dr.GetDateTime(Dr.GetOrdinal("FechaNacimiento")) : DateTime.MinValue;
                    Item.TelefonoCelular = !Dr.IsDBNull(Dr.GetOrdinal("Celular")) ? Dr.GetString(Dr.GetOrdinal("Celular")) : string.Empty;
                    Item.Telefono = !Dr.IsDBNull(Dr.GetOrdinal("Telefono")) ? Dr.GetString(Dr.GetOrdinal("Telefono")) : string.Empty;
                    Item.CodigoTarjeta = !Dr.IsDBNull(Dr.GetOrdinal("Codigo")) ? Dr.GetString(Dr.GetOrdinal("Codigo")) : string.Empty;
                    Item.Clasificacion = !Dr.IsDBNull(Dr.GetOrdinal("Clasificacion")) ? Dr.GetInt32(Dr.GetOrdinal("Clasificacion")) : 0;
                    Item.ReferidoPor = !Dr.IsDBNull(Dr.GetOrdinal("Referido")) ? Dr.GetString(Dr.GetOrdinal("Referido")) : string.Empty;
                    Item._ImagenBase64 = !Dr.IsDBNull(Dr.GetOrdinal("Imagen")) ? Dr.GetString(Dr.GetOrdinal("Imagen")) : string.Empty;
            }
            Dr.Close();

            return Item;
        }

        public int ObtenerTotalRecordsQuery(string Conexion, bool EsBusqueda, int TipoBusqueda, string Busqueda)
        {
            try
            {
                int TotalRecords = 0;
                object[] Parametros = { EsBusqueda, Busqueda, TipoBusqueda };
                object Result = SqlHelper.ExecuteScalar(Conexion, "Customer.spCF_get_TotalRecordsClientesXPagina", Parametros);
                if(Result !=null)
                {
                    int.TryParse(Result.ToString(), out TotalRecords);
                }
                return TotalRecords;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo para guardar clientes JM
        /// </summary>
        public void GuardarCliente(string Conexion, V2Cliente Cliente, ref int Verificador)
        {
            try{
                 object[] Valores = {Cliente.Nombre, Cliente.Empresa, Cliente.Domicilio,
                                    Cliente.Cruces, Cliente.Colonia, Cliente.CodigoPostal, Cliente.IDEstado,
                                    Cliente.IDMunicipio, Cliente.Email, Cliente.RFC, Cliente.FechaNacimiento,
                                    Cliente.Telefono, Cliente.TelefonoCelular, Cliente.CodigoTarjeta, Cliente.Clasificacion,
                                    Cliente.ReferidoPor, Cliente._ImagenBase64, Comun.Id_U};
                object res = SqlHelper.ExecuteScalar(Conexion, "Customer.spCF_set_Clientes", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarCliente(string Conexion, V2Cliente Cliente, ref int Verificador)
        {
            try
            {
                object[] Valores = {Cliente.IDCliente, Cliente.Nombre, Cliente.Empresa, Cliente.Domicilio,
                                    Cliente.Cruces, Cliente.Colonia, Cliente.CodigoPostal, Cliente.IDEstado,
                                    Cliente.IDMunicipio, Cliente.Email, Cliente.RFC, Cliente.FechaNacimiento,
                                    Cliente.Telefono, Cliente.TelefonoCelular, Cliente.Clasificacion,
                                    Cliente._ImagenBase64, Comun.Id_U};
                object res = SqlHelper.ExecuteScalar(Conexion, "Customer.spCF_set_ModificarClientes", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(string Conexion, V2Cliente Cliente, ref int verificador)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, "Customer.spCF_set_EliminarCliente", Cliente.IDCliente);
                verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setTarjetaCliente(V2Cliente datos, ref int Verificador)
        {
            try
            {
                object[] valores = {datos.IDCliente, datos.CodigoTarjeta, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Comun.Conexion, "Customer.spCF_setTarjetaCliente", valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
