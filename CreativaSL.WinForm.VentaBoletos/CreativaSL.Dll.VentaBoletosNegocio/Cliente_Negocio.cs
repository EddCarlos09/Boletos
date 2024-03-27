using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Cliente_Negocio
    {
        Cliente_Datos Cliente_Datos;
        public Cliente_Negocio()
        {
            try
            {
                Cliente_Datos = new Cliente_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Clientes
        public void LlenarGridCliente(string Conexion, ref Cliente Clientes)
        {
            try
            {
                Cliente_Datos.LlenarGridCliente(Conexion, Clientes);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridCliente" + ex.Message);
            }
        }
        public void EliminarCliente(string Conexion, Cliente Cliente, int Verificador)
        {
            try
            {
                Cliente_Datos.EliminarCliente(Conexion, Cliente, Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridCliente" + ex.Message);
            }
        }
        public int ConsultarCorreo(string Conexion, string Correo)
        {
            try
            {
                return Cliente_Datos.ConsultarCorreo(Conexion, Correo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ConsultarCorreo" + ex.Message);
            }
        }
        public int ConsultarCodigoCliente(string Conexion, string CodigoCliente)
        {
            try
            {
                return Cliente_Datos.ConsultarCodigoCliente(Conexion, CodigoCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ConsultarCodigoCliente" + ex.Message);
            }
        }
        public void ModificarCliente(string Conexion, Cliente Cliente, ref int Verificador)
        {
            try
            {
                Cliente_Datos.ModificarCliente(Conexion, Cliente, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ModificarCliente" + ex.Message);
            }
        }
        public void InsertarCliente(string Conexion, Cliente Cliente, ref int Verificador)
        {
            try
            {
                Cliente_Datos.InsertarCliente(Conexion, Cliente, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarCliente" + ex.Message);
            }
        }
        #region CombosClientes
        public void CargarComboGenero(string Conexion, ref Cliente Clientes)
        {
            try
            {
                Cliente_Datos.CargarComboGenero(Conexion, ref Clientes);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboGenero" + ex.Message);
            }
        }
        public void CargarComboOcupacion(string Conexion, ref Cliente Clientes)
        {
            try
            {
                Cliente_Datos.CargarComboOcupacion(Conexion, ref Clientes);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboOcupacion" + ex.Message);
            }
        }
        public void CargarComboEstadoCivil(string Conexion, ref Cliente Clientes)
        {
            try
            {
                Cliente_Datos.CargarComboEstadoCivil(Conexion, ref Clientes);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboOcupacion" + ex.Message);
            }
        }
        public void CargarComboPais(string Conexion, ref Cliente Clientes)
        {
            try
            {
                Cliente_Datos.CargarComboPais(Conexion, ref Clientes);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboPais" + ex.Message);
            }
        }
        public void CargarComboEstado(string Conexion, ref Cliente Clientes, int IDPais)
        {
            try
            {
                Cliente_Datos.CargarComboEstado(Conexion, ref Clientes, IDPais);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboEstado" + ex.Message);
            }
        }
        public void CargarComboMunicipios(string Conexion, ref Cliente Clientes, int IDPais, int IDEstado)
        {
            try
            {
                Cliente_Datos.CargarComboMunicipios(Conexion, ref Clientes, IDPais, IDEstado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboMunicipios" + ex.Message);
            }
        }
        #endregion

        public void ObtenerClienteXCodigo(string _Conexion, V2Cliente datos)
        {
            try
            {
                Cliente_Datos cd = new Cliente_Datos();
                cd.ObtenerClienteXCodigo(_Conexion, datos);

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
                Cliente_Datos cd = new Cliente_Datos();
                cd.ObtenerClienteXIdBoleto(_Conexion, id_boleto, datos);

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
                Cliente_Datos cd = new Cliente_Datos();
                cd.ObtenerClienteXIdVenta(_Conexion, id_venta, datos);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

    }
}
