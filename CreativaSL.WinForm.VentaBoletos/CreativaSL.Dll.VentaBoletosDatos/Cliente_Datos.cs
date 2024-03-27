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
    public class Cliente_Datos
    {
        #region Clientes
        public int ConsultarCorreo(string Conexion, string Correo)
        {
            try
            {
                int Verificador = 0;
                object[] Valores = { Correo };
                object res = SqlHelper.ExecuteScalar(Conexion, "Correo_Verficar_sp", Valores);
                Verificador = Convert.ToInt32(res);
                return Verificador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ConsultarCodigoCliente(string Conexion, string CodigoCliente)
        {
            try
            {
                int Verificador = 0;
                object[] Valores = { CodigoCliente };
                object res = SqlHelper.ExecuteScalar(Conexion, "CodigoCliente_Verficar_sp", Valores);
                Verificador = Convert.ToInt32(res);
                return Verificador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LlenarGridCliente(string Conexion, Cliente Clientes)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "CID_CatCliente_Consulta_sp");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            Clientes.Clientes = ds.Tables[0];
                        }
                    }
                }
                //DataSet ds = SqlHelper.ExecuteDataset(Conexion, "CatCliente_Consulta_sp");
                //if (ds != null)
                //{
                //    if (ds.Tables.Count > 0)
                //    {
                //        if (ds.Tables[0] != null)
                //        {
                //                Clientes.Clientes = ds.Tables[0];
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarCliente(string Conexion, Cliente Cliente, int Verificador)
        {
            try
            {
                object[] Valores = { Cliente.IDCliente };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatCliente_Eliminar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ModificarCliente(string Conexion, Cliente Cliente, ref int Verificador)
        {
            try
            {
                object[] Valores = { Cliente.IDCliente, Cliente.Nombre, Cliente.ApePat, Cliente.ApeMat, Cliente.CorreoElectronico, Cliente.IDMunicipio, Cliente.IDEstado, Cliente.IDPais, Cliente.Colonia, Cliente.FechaNacimiento, Cliente.IDOcupacion, Cliente.IDEstadoCivil, Cliente.IDGenero, Cliente.Curp, Cliente.IDCodigoEab, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatCliente_Modificar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertarCliente(string Conexion, Cliente Cliente, ref int Verificador)
        {
            try
            {
                object[] Valores = { Cliente.Nombre, Cliente.ApePat, Cliente.ApeMat, Cliente.CorreoElectronico, Cliente.IDMunicipio, Cliente.IDEstado, Cliente.IDPais, Cliente.Colonia, Cliente.FechaNacimiento, Cliente.IDOcupacion, Cliente.IDEstadoCivil, Cliente.IDGenero, Cliente.Curp, Cliente.IDCodigoEab, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatCliente_Insertar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region CombosClientes
        public void CargarComboGenero(string Conexion, ref Cliente Clientes)
        {
            try
            {
                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(Conexion, "CatGenero_Combo_sp");
                Cliente cliente;
                while (dr.Read())
                {

                    cliente = new Cliente();
                    cliente.IDGenero = Convert.ToInt32(dr["id_genero"].ToString());
                    cliente.Genero = dr["genero"].ToString();
                    Clientes.lista_Genero.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboOcupacion(string Conexion, ref Cliente Clientes)
        {
            try
            {
                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(Conexion, "CatOcupaciones_Combo_sp");
                Cliente cliente;
                while (dr.Read())
                {

                    cliente = new Cliente();
                    cliente.IDOcupacion = Convert.ToInt32(dr["id_ocupacion"].ToString());
                    cliente.Ocupacion = dr["ocupacion"].ToString();
                    Clientes.lista_Ocupacion.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboEstadoCivil(string Conexion, ref Cliente Clientes)
        {
            try
            {
                SqlDataReader dr = null;
                dr = SqlHelper.ExecuteReader(Conexion, "CatEstadoCivil_Combo_sp");
                Cliente cliente;
                while (dr.Read())
                {

                    cliente = new Cliente();
                    cliente.IDEstadoCivil = Convert.ToInt32(dr["id_estadoCivil"].ToString());
                    cliente.EstadoCivil = dr["estadoCivil"].ToString();
                    Clientes.lista_EstadoCivil.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboPais(string Conexion, ref Cliente Clientes)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { 1 };
                dr = SqlHelper.ExecuteReader(Conexion, "CatPaises_Combo_sp",Valores);
                Cliente cliente;
                while (dr.Read())
                {

                    cliente = new Cliente();
                    cliente.IDPais = Convert.ToInt32(dr["Id"].ToString());
                    cliente.Pais = dr["Descripcion"].ToString();
                    Clientes.lista_Pais.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboEstado(string Conexion, ref Cliente Clientes, int IDPais)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { 1,IDPais };
                dr = SqlHelper.ExecuteReader(Conexion, "CatEstados_Combo_sp", Valores);
                Cliente cliente;
                while (dr.Read())
                {

                    cliente = new Cliente();
                    cliente.IDEstado = Convert.ToInt32(dr["Id"].ToString());
                    cliente.Estado = dr["Descripcion"].ToString();
                    Clientes.lista_Estado.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboMunicipios(string Conexion, ref Cliente Clientes, int IDPais, int IDEstado)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { 1, IDEstado, IDPais };
                dr = SqlHelper.ExecuteReader(Conexion, "CatMunicipios_Combo_sp", Valores);
                Cliente cliente;
                while (dr.Read())
                {

                    cliente = new Cliente();
                    cliente.IDMunicipio = Convert.ToInt32(dr["Id"].ToString());
                    cliente.Municipio = dr["Descripcion"].ToString();
                    Clientes.lista_Municipio.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #endregion

        public void ObtenerClienteXCodigo(string _Conexion, V2Cliente datos)
        {
            try
            {
                SqlDataReader Dr = null;
                Dr = SqlHelper.ExecuteReader(_Conexion, "Customer.spCSLDB_get_CustomerByCodeCard", datos.CodigoTarjeta);
                while (Dr.Read())
                {
                    datos.IDCliente = !Dr.IsDBNull(Dr.GetOrdinal("IDCliente")) ? Dr.GetInt32(Dr.GetOrdinal("IDCliente")) : 0;
                    datos.Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty;
                    datos.PorentajePuntos = !Dr.IsDBNull(Dr.GetOrdinal("PorcentajePuntos")) ? Dr.GetDecimal(Dr.GetOrdinal("PorcentajePuntos")) : 0;
                    datos.SaldoRetenido = !Dr.IsDBNull(Dr.GetOrdinal("SaldoRetenido")) ? Dr.GetDecimal(Dr.GetOrdinal("SaldoRetenido")) : 0;
                    datos.SaldoDisponible = !Dr.IsDBNull(Dr.GetOrdinal("SaldoDisponible")) ? Dr.GetDecimal(Dr.GetOrdinal("SaldoDisponible")) : 0;
                    datos.Saldo = !Dr.IsDBNull(Dr.GetOrdinal("Saldo")) ? Dr.GetDecimal(Dr.GetOrdinal("Saldo")) : 0;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ObtenerClienteXIdBoleto(string _Conexion, string id_boleto, V2Cliente datos)
        {
            try
            {
                SqlDataReader Dr = null;
                object[] parametro = { id_boleto };
                Dr = SqlHelper.ExecuteReader(_Conexion, "Customer.spCSLDB_get_CustomerByIdBoleto", parametro);
                while (Dr.Read())
                {
                    datos.IDCliente = !Dr.IsDBNull(Dr.GetOrdinal("IDCliente")) ? Dr.GetInt32(Dr.GetOrdinal("IDCliente")) : 0;
                    datos.Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty;
                    datos.PorentajePuntos = !Dr.IsDBNull(Dr.GetOrdinal("PorcentajePuntos")) ? Dr.GetDecimal(Dr.GetOrdinal("PorcentajePuntos")) : 0;
                    datos.SaldoRetenido = !Dr.IsDBNull(Dr.GetOrdinal("SaldoRetenido")) ? Dr.GetDecimal(Dr.GetOrdinal("SaldoRetenido")) : 0;
                    datos.SaldoDisponible = !Dr.IsDBNull(Dr.GetOrdinal("SaldoDisponible")) ? Dr.GetDecimal(Dr.GetOrdinal("SaldoDisponible")) : 0;
                    datos.Saldo = !Dr.IsDBNull(Dr.GetOrdinal("Saldo")) ? Dr.GetDecimal(Dr.GetOrdinal("Saldo")) : 0;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ObtenerClienteXIdVenta(string _Conexion, string id_venta, V2Cliente datos)
        {
            try
            {
                SqlDataReader Dr = null;
                object[] parametro = { id_venta };
                Dr = SqlHelper.ExecuteReader(_Conexion, "Customer.spCSLDB_get_CustomerByIdVenta", parametro);
                while (Dr.Read())
                {
                    datos.IDCliente = !Dr.IsDBNull(Dr.GetOrdinal("IDCliente")) ? Dr.GetInt32(Dr.GetOrdinal("IDCliente")) : 0;
                    datos.Nombre = !Dr.IsDBNull(Dr.GetOrdinal("Nombre")) ? Dr.GetString(Dr.GetOrdinal("Nombre")) : string.Empty;
                    datos.PorentajePuntos = !Dr.IsDBNull(Dr.GetOrdinal("PorcentajePuntos")) ? Dr.GetDecimal(Dr.GetOrdinal("PorcentajePuntos")) : 0;
                    datos.SaldoRetenido = !Dr.IsDBNull(Dr.GetOrdinal("SaldoRetenido")) ? Dr.GetDecimal(Dr.GetOrdinal("SaldoRetenido")) : 0;
                    datos.SaldoDisponible = !Dr.IsDBNull(Dr.GetOrdinal("SaldoDisponible")) ? Dr.GetDecimal(Dr.GetOrdinal("SaldoDisponible")) : 0;
                    datos.Saldo = !Dr.IsDBNull(Dr.GetOrdinal("Saldo")) ? Dr.GetDecimal(Dr.GetOrdinal("Saldo")) : 0;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
