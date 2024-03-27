using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Usuario_Negocio
    {
        Usuario_Datos Usuario;
        public Usuario_Negocio()
        {
            try
            {
                Usuario = new Usuario_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Usuario
        public void InsertarUsuario(Usuario usuario, string Conexion, ref int Verificador)
        {
            try
            {
                Usuario.InsertarUsuario(usuario, Conexion, ref Verificador);
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
                Usuario.ModificarUsuario(usuario, Conexion, ref Verificador);
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
                Usuario.EliminarUsuario(usuario, Conexion, ref Verificador);
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
                Usuario.LlenarGridUsuario(Conexion, ref Usuarios);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridUsuario" + ex.Message);
            }
        }
        public void CambiarContraseñaUsuario(string Conexion, string User, string Contraseña, ref int Verificador)
        {
            try
            {
                Usuario.CambiarContraseñaUsuario(Conexion, User, Contraseña, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarUsuario" + ex.Message);
            }
        }
        #region CombosUsuarios
        public void CargarComboTipoUsuario(string Conexion, ref Usuario Usuarios)
        {
            try
            {
                Usuario.CargarComboTipoUsuario(Conexion, ref Usuarios);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboTipoUsuario" + ex.Message);
            }
        }
        public void CargarComboTurno(string Conexion, ref Usuario Usuarios)
        {
            try
            {
                Usuario.CargarComboTurno(Conexion, ref Usuarios);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboTurno" + ex.Message);
            }
        }
        public void CargarComboSucursal(string Conexion, ref Usuario Usuarios)
        {
            try
            {
                Usuario.CargarComboSucursal(Conexion, ref Usuarios);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarComboSucursal" + ex.Message);
            }
        }
        #endregion
        #endregion


    }
}
