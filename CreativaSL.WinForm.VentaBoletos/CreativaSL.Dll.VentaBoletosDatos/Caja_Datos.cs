using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;


namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Caja_Datos
    {
        public void AgregarDeposito(string conexion, string idcaja, string user, decimal monto, string cocepto)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(conexion, "sp_abcDepositos", 1, "", idcaja, user, monto, cocepto, Comun.id_sucursal) <= 0)
                {
                    throw new Exception("No se pudo realizar el Deposito");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AgregarRetiro(string conexion, string idcaja, string user, decimal monto, string cocepto, int tipo)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(conexion, "sp_abcRetiros", 1, "", idcaja, user, tipo, monto, cocepto, Comun.id_sucursal) <= 0)
                {
                    throw new Exception("No se pudo realizar el Retiro");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void EliminarDeposito(string conexion, string iddeposito, string idcaja, string user, decimal monto, string cocepto)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(conexion, "sp_abcDepositos", 3, iddeposito, idcaja, user, monto, cocepto, Comun.id_sucursal) <= 0)
                {
                    throw new Exception("No se pudo modificar el Deposito");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void EliminarRetiro(string conexion, string idretiro, string idcaja, string user, decimal monto, string cocepto, int tipo)
        {
            try
            {
                if (SqlHelper.ExecuteNonQuery(conexion, "sp_abcRetiros", 3, idretiro, idcaja, user, monto, cocepto, tipo, Comun.id_sucursal) <= 0)
                {
                    throw new Exception("No se pudo modificar el Retiro");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void GuardarAperturaCaja(Caja caja, string Conexion, ref int verificador)
        {
            try
            {
                object[] valores = { caja.id_caja, Comun.idCajaCat, caja.id_sucursal,caja.M50C, caja.M1P, caja.M2P, caja.M5P, caja.M10P, caja.M20P,
                                   caja.M100P, caja.B20P, caja.B50P, caja.B100P, caja.B200P, caja.B500P,
                                   caja.B1000P, caja.Total, caja.Id_U, caja.FechaIngreso, caja.HoraIngreso};
                SqlHelper.ExecuteScalar(Conexion, "AperturaCaja_Insertar_sp", valores);
            }
            catch (Exception ex)
            {
                throw new Exception("Error GuardarAperturaCaja Datos" + ex.Message);
            }
        }
        public void GuardarCierreCaja(Caja caja, string Conexion, ref int verificador)
        {
            try
            {
                object[] valores = { caja.id_caja, caja.id_sucursal,caja.M50C, caja.M1P, caja.M2P, caja.M5P, caja.M10P, caja.M20P,
                                   caja.M100P, caja.B20P, caja.B50P, caja.B100P, caja.B200P, caja.B500P,
                                   caja.B1000P, caja.Total, caja.Id_U, caja.FechaIngreso, caja.HoraIngreso};
                SqlHelper.ExecuteScalar(Conexion, "CierreCaja_Modificar_sp", valores);
            }
            catch (Exception ex)
            {
                throw new Exception("Error GuardarCierreCaja Datos" + ex.Message);
            }
        }
        public Caja ObtenerDatosCaja(Caja caja,bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { caja.id_caja};
                if(Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(caja.CadConexion, "Obtener_DatosCaja", Valores);
                else
                    dr = SqlHelper.ExecuteReader(caja.CadConexion, "Obtener_DatosCaja_Estadisticos", Valores);
                while (dr.Read())
                {
                    caja.Total = Convert.ToSingle(dr["Apertura"].ToString());
                    caja.TotalVentas = Convert.ToSingle(dr["TotalVta"].ToString());
                    caja.TotalVentasMaletas = Convert.ToSingle(dr["TotalVtaMaletas"].ToString());
                    caja.TotalEfectivo = Convert.ToSingle(dr["TotalEfectivo"].ToString());
                    caja.TotalMonedero = Convert.ToSingle(dr["TotalMonedero"].ToString());
                    caja.TotalTarjeta = Convert.ToSingle(dr["TotalTarjeta"].ToString());
                    caja.TotalTransferencia = Convert.ToSingle(dr["TotalTransferencia"].ToString());
                    caja.FechaIngreso = Convert.ToDateTime(dr["fechainicio"].ToString()).ToShortDateString();
                    caja.HoraIngreso = dr["horainicio"].ToString();
                    caja.TotalRetirosPagos = Convert.ToSingle(dr["RetirosP"].ToString());
                    caja.TotalRetirosCajaLlena = Convert.ToSingle(dr["RetirosC"].ToString());
                    caja.TotalDepositos = Convert.ToSingle(dr["Depositos"].ToString());
                    caja.TotalBoletos = Convert.ToSingle(dr["TotalBoletos"].ToString());
                    caja.Cajero = dr["Cajero"].ToString();
                }
                return caja;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Caja ObtenerDatosCaja2(Caja caja, DateTime FechaInicio, DateTime FechaFin, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { caja.id_cajaCat, FechaInicio, FechaFin};
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(caja.CadConexion, "Obtener_DatosCaja2", Valores);
                else
                    dr = SqlHelper.ExecuteReader(caja.CadConexion, "Obtener_DatosCaja2_Estadisticos", Valores);

                while (dr.Read())
                {
                    caja.Total = Convert.ToSingle(dr["Apertura"].ToString());
                    caja.TotalVentas = Convert.ToSingle(dr["TotalVta"].ToString());
                    caja.TotalVentasMaletas = Convert.ToSingle(dr["TotalVtaMaletas"].ToString());
                    caja.TotalEfectivo = Convert.ToSingle(dr["TotalEfectivo"].ToString());
                    caja.TotalMonedero = Convert.ToSingle(dr["TotalMonedero"].ToString());
                    caja.TotalTransferencia = Convert.ToSingle(dr["TotalTransferencia"].ToString());
                    caja.TotalTarjeta = Convert.ToSingle(dr["TotalTarjeta"].ToString());
                    caja.FechaIngreso = Convert.ToDateTime(dr["fechainicio"].ToString()).ToShortDateString();
                    caja.HoraIngreso = Convert.ToDateTime(dr["horainicio"].ToString()).ToShortDateString();
                    caja.TotalRetirosPagos = Convert.ToSingle(dr["RetirosP"].ToString());
                    caja.TotalRetirosCajaLlena = Convert.ToSingle(dr["RetirosC"].ToString());
                    caja.TotalDepositos = Convert.ToSingle(dr["Depositos"].ToString());
                    caja.Cajero = dr["Cajero"].ToString();
                }
                return caja;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AsignarCaja(string Conexion, Caja caja, ref int Verificador)
        {
            object[] valores = { caja.id_cajaCat, caja.mac, caja.descripcion, caja.namePrinter};
            object aux = SqlHelper.ExecuteScalar(Conexion, "CajaMac_Asignar_sp", valores);
            Verificador = Convert.ToInt32(aux);

        }
        public void CargarComboCaja(string Conexion, Caja caja)
        {
            try
            {
                SqlDataReader dr = null;
                Caja _caja = new Caja(Comun.Conexion);
                dr = SqlHelper.ExecuteReader(Conexion, "CatCaja_Combo_sp");
                while (dr.Read())
                {
                    _caja = new Caja(Comun.Conexion);
                    _caja.id_cajaCat = dr["id_cajaCat"].ToString();
                    _caja.cajaCat = dr["cajaCat"].ToString();
                    caja.listaCaja.Add(_caja);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CargarComboCajasOcupadas(string Conexion, Caja caja)
        {
            try
            {
                SqlDataReader dr = null;
                Caja _caja = new Caja(Comun.Conexion);
                dr = SqlHelper.ExecuteReader(Conexion, "CatCajaOcupadas_Combo_sp");
                while (dr.Read())
                {
                    _caja = new Caja(Comun.Conexion);
                    _caja.id_cajaCat = dr["id_cajaCat"].ToString();
                    _caja.cajaCat = dr["cajaCat"].ToString();
                    _caja.cajaCatCompleto = dr["cajaCatCompleto"].ToString();
                    caja.listaCaja.Add(_caja);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Caja ObtenerDatosCajaSai(Caja caja, bool Estadisticos)
        {
            try
            {
                SqlDataReader dr = null;
                object[] Valores = { caja.id_caja };
                if (Estadisticos == false)
                    dr = SqlHelper.ExecuteReader(caja.CadConexion, "Obtener_DatosCajaSai", Valores);
                else
                    dr = SqlHelper.ExecuteReader(caja.CadConexion, "Obtener_DatosCajaSai_Estadisticos", Valores);

                while (dr.Read())
                {
                    caja.Total = Convert.ToSingle(dr["Apertura"].ToString());
                    caja.TotalVentas = Convert.ToSingle(dr["TotalVta"].ToString());
                    caja.TotalVentasMaletas = Convert.ToSingle(dr["TotalVtaMaletas"].ToString());
                    caja.TotalEfectivo = Convert.ToSingle(dr["TotalEfectivo"].ToString());
                    caja.TotalMonedero = Convert.ToSingle(dr["TotalMonedero"].ToString());
                    caja.FechaIngreso = Convert.ToDateTime(dr["fechainicio"].ToString()).ToShortDateString();
                    caja.HoraIngreso = dr["horainicio"].ToString();
                    caja.TotalRetirosPagos = Convert.ToSingle(dr["RetirosP"].ToString());
                    caja.TotalRetirosCajaLlena = Convert.ToSingle(dr["RetirosC"].ToString());
                    caja.TotalDepositos = Convert.ToSingle(dr["Depositos"].ToString());
                    caja.Cajero = dr["Cajero"].ToString();
                }
                return caja;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
