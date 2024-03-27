﻿using CreativaSL.Dll.VentaBoletosGlobal;
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
    public class Usuario_Datos
    {
        #region Usuario
        public void InsertarUsuario(Usuario usuario, string Conexion, ref int Verificador)
        {
            try
            {
                object[] Valores = { usuario.Id_U, usuario.Id_Tu, usuario.id_sucursal, usuario.U_Nombre, 
                                     usuario.U_Apellidop, usuario.U_Apellidom, usuario.U_FechaNac, 
                                     usuario.U_DirCalle, usuario.U_DirColonia, usuario.U_DirNumero, 
                                     usuario.Cu_User, usuario.Cu_Pass,usuario.Id_Turno};
                object res = SqlHelper.ExecuteScalar(Conexion, "CatUsuario_Insertar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ModificarUsuario(Usuario usuario, string Conexion, ref int Verificador)
        {
            try
            {

                object[] Valores = { usuario.Id_U, usuario.Id_Tu, usuario.id_sucursal, usuario.U_Nombre, 
                                       usuario.U_Apellidop, usuario.U_Apellidom, usuario.U_FechaNac, 
                                       usuario.U_DirCalle, usuario.U_DirColonia, usuario.U_DirNumero, 
                                       usuario.Cu_User, usuario.Cu_Pass, usuario.Id_UModifico, usuario.Id_Turno , usuario.BanPass};
                object res = SqlHelper.ExecuteScalar(Conexion, "CatUsuario_Modificar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarUsuario(Usuario usuario, string Conexion, ref int Verificador)
        {
            try
            {
                object[] Valores = { usuario.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatUsuario_Eliminar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LlenarGridUsuario(string Conexion, ref Usuario Usuarios)
        {
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "CatUsuario_Consulta_sp");
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                                Usuarios.Usuarios = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CambiarContraseñaUsuario(string Conexion, string User, string Contraseña, ref int Verificador)
        {
            object[] Valores = { User, Contraseña};
            object res = SqlHelper.ExecuteScalar(Conexion, "CatUsuario_ModificarContraseña_sp", Valores);
            Comun.Cu_Pass = Convert.ToString(res);
            Verificador = 1;
        }
        #region CombosUsuario
        public void CargarComboSucursal(string Conexion, ref Usuario Usuarios)
        {
            try
            {
                SqlDataReader dr = null;
                Usuario usuario = new Usuario();
                dr = SqlHelper.ExecuteReader(Conexion, "CatSucursales_Combo_sp");
                while (dr.Read())
                {
                    usuario = new Usuario();
                    usuario.id_sucursal = dr["id_sucursal"].ToString();
                    usuario.Nombre_Sucursal = dr["Nombre_Sucursal"].ToString();
                    Usuarios.lista_Sucursal.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboTurno(string Conexion, ref Usuario Usuarios)
        {
            try
            {
                SqlDataReader dr = null;
                Usuario usuario;
                dr = SqlHelper.ExecuteReader(Conexion, "CatTurno_Combo_sp");
                usuario = new Usuario(); ;
                while (dr.Read())
                {
                    usuario = new Usuario();
                    usuario.Id_Turno = Convert.ToInt32(dr["Id_Turno"].ToString());
                    usuario.Turno = dr["Turno"].ToString();
                    Usuarios.lista_Turno.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboTipoUsuario(string Conexion, ref Usuario Usuarios)
        {
            try
            {
                SqlDataReader dr = null;
                Usuario usuario;
                dr = SqlHelper.ExecuteReader(Conexion, "CatTipoUsuario_Combo_sp");
                usuario = new Usuario();
                while (dr.Read())
                {
                    usuario = new Usuario();
                    usuario.Id_Tu = Convert.ToInt32(dr["Id_Tu"].ToString());
                    usuario.Tu_Descripcion = dr["Tu_Desccripcion"].ToString();
                    Usuarios.lista_TipoUsuarios.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #endregion



    }
}
