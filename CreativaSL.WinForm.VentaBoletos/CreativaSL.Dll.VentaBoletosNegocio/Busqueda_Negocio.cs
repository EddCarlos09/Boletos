using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;
using System.Data.SqlClient;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Busqueda_Negocio
    {
        public Busqueda BuscarBoletos(Busqueda datos)
        {
            try
            {
                Busqueda_Datos bd = new Busqueda_Datos();
                return bd.BuscarBoletos(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Busqueda ValidarFolioTransferencia(string Folio, string Conexion)
        {
            try
            {
                Busqueda_Datos bd = new Busqueda_Datos();
                return bd.ValidarFolioTransferencia(Folio, Conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public V2Cliente ObtenerDatosCliente(int idCliente)
        {
            try
            {
                V2Cliente cliente = new V2Cliente();
                using (SqlConnection connection = new SqlConnection(Comun.Conexion))
                {
                    SqlCommand command = new SqlCommand("ObtenerClientePorId", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_cliente", idCliente);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        cliente.IDCliente = (int)reader["id_cliente"];
                        cliente.Nombre = reader["nombre"].ToString();
                        cliente.Domicilio = reader["domicilio"].ToString();
                        cliente.Colonia = reader["colonia"].ToString();
                        cliente.CodigoPostal = reader["codigoPostal"].ToString();
                        cliente.Email = reader["email"].ToString();
                        cliente.RFC = reader["rfc"].ToString();
                        cliente.TelefonoCelular = reader["telefono1"].ToString();
                        cliente.Telefono = reader["telefono2"].ToString();
                        cliente.MunicipioDesc = reader["municipio"].ToString();
                        cliente.EstadoDesc = reader["estado"].ToString();
                        cliente.PaisDesc = reader["pais"].ToString();
                        cliente.Empresa = reader["empresa"].ToString();
                        cliente.FechaNacimiento = (DateTime)reader["fechaNacimiento"];
       
                        // Continúa con el resto de los campos necesarios
                    }
                    reader.Close();
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos del cliente: " + ex.Message);
            }
        }
    }
}
