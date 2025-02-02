﻿using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Banco_Datos
    {
        public List<Banco> llenarComboBancos(Banco datos)
        {
            try
            {
                SqlDataReader dr = null;
                List<Banco> bancos = new List<Banco>();
                dr = SqlHelper.ExecuteReader(datos.Conexion, "CatBancos_Combo_sp");
                while (dr.Read())
                {
                    Banco banco = new Banco();
                    banco.idBanco = dr.GetInt32(dr.GetOrdinal("id_banco"));
                    if (Convert.IsDBNull(dr.GetValue(dr.GetOrdinal("razonsocial"))))
                    {
                        banco.nombreBanco = string.Empty;
                    }
                    else
                    {
                        banco.nombreBanco = dr.GetString(dr.GetOrdinal("razonsocial"));
                    }
                    bancos.Add(banco);
                }
                return bancos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
