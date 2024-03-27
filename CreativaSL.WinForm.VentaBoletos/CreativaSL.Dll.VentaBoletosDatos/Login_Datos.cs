using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;


namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Login_Datos
    {
        public Usuario validarUsuario(Usuario usuario)
        {
            try
            {
                SqlDataReader SqlDr = null;
                string[] valores = { usuario.Cu_User, usuario.Cu_Pass, usuario.id_sucursal, Comun.macAdress };
              
                SqlDr = SqlHelper.ExecuteReader(usuario.Conexion, "Login_sp", valores);
                while (SqlDr.Read())
                {
                    usuario.Validador = SqlDr.GetInt32(0);
                    if (usuario.Validador == 1)
                    {
                        usuario.Id_U = SqlDr.GetString(SqlDr.GetOrdinal("Id_U"));
                        usuario.U_Nombre = SqlDr.GetString(SqlDr.GetOrdinal("U_Nombre"));
                        usuario.U_Apellidop = SqlDr.GetString(SqlDr.GetOrdinal("U_Apellidop"));
                        usuario.U_Apellidom = SqlDr.GetString(SqlDr.GetOrdinal("U_Apellidom"));
                        usuario.Id_Tu = SqlDr.GetInt32(SqlDr.GetOrdinal("Id_Tu"));
                        if (Convert.IsDBNull(SqlDr["Cu_Estatus"]))
                            usuario.Cu_Estatus = false;
                        else
                            usuario.Cu_Estatus = Convert.ToBoolean(SqlDr["Cu_Estatus"]);
                        if (Convert.IsDBNull(SqlDr.GetValue(SqlDr.GetOrdinal("CuentaCaducada"))))
                            usuario.CuentaCaducada = false;
                        else
                            usuario.CuentaCaducada = Convert.ToBoolean(SqlDr.GetValue(SqlDr.GetOrdinal("CuentaCaducada")));
                        usuario.id_sucursal = SqlDr.GetString(SqlDr.GetOrdinal("id_sucursal"));
                        usuario.Crearid_caja = Convert.ToBoolean(SqlDr["Crearid_caja"]);
                        usuario.idcaja = SqlDr.GetString(SqlDr.GetOrdinal("id_caja"));
                        //Llenamos datos necesarios para otras pantallas
                        Comun.Id_U = usuario.Id_U;
                        Comun.Id_Tu = usuario.Id_Tu;
                        Comun.U_Nombre = usuario.U_Nombre;
                        Comun.U_Apellidop = usuario.U_Apellidop;
                        Comun.U_Apellidom = usuario.U_Apellidom;
                        Comun.id_sucursal = usuario.id_sucursal;
                        Comun.id_caja = usuario.idcaja;
                        if (SqlDr.GetInt32(SqlDr.GetOrdinal("id_turno")) == 1)
                            Comun.turno = "Matutino";
                        else if (SqlDr.GetInt32(SqlDr.GetOrdinal("id_turno")) == 2)
                            Comun.turno = "Vespertino";
                        else if (SqlDr.GetInt32(SqlDr.GetOrdinal("id_turno")) == 3)
                            Comun.turno = "Mixto";
                        Comun.namePrinter = SqlDr.GetString(SqlDr.GetOrdinal("impresora"));
                        Comun.CTU_TipoUsuario = SqlDr.GetString(SqlDr.GetOrdinal("CTU_TipoUsuario"));
                        Comun.Cu_User = SqlDr.GetString(SqlDr.GetOrdinal("Cu_User"));
                        Comun.Cu_Pass = SqlDr.GetString(SqlDr.GetOrdinal("Cu_Pass"));
                        Comun.FechaIngreso = DateTime.Now;
                        Comun.idCajaCat = SqlDr.GetString(SqlDr.GetOrdinal("idCajaCat"));
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede obtener la información" + ex.Message);
            }
        }
    }
}
