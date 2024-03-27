using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Catalogo_Negocio
    {
        private Catalogo_Datos catalogoDatos;

        public Catalogo_Negocio()
        {
            catalogoDatos = new Catalogo_Datos();
        }
        #region Usuario
        public void InsertarUsuario(Usuario usuario, string Conexion, ref int Verificador)
        {
            try
            {
                catalogoDatos.InsertarUsuario(usuario, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarUsuario" + ex.Message);
            }
        }
        public void ModificarUsuario(Usuario usuario, string Conexion, ref int Verificador)
        {
            try
            {
                catalogoDatos.ModificarUsuario(usuario, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ModificarUsuario" + ex.Message);
            }
        }
        public void EliminarUsuario(Usuario usuario, string Conexion, ref int Verificador)
        {
            try
            {
                catalogoDatos.EliminarUsuario(usuario, Conexion, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error EliminarUsuario" + ex.Message);
            }
        }
        public void LlenarGridUsuario(string Conexion, ref Usuario Usuarios)
        {
            try
            {
                catalogoDatos.LlenarGridUsuario(Conexion, ref Usuarios);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridUsuario" + ex.Message);
            }
        }
        public void CargarCombosUsuarios(string Conexion, ref Usuario Usuarios)
        {
            try
            {
                catalogoDatos.CargarCombosUsuarios(Conexion, ref Usuarios);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboUsuario" + ex.Message);
            }
        }
        #endregion


    }
}
