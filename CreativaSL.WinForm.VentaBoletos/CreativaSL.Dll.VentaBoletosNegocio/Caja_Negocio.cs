using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Caja_Negocio
    {
        private Caja_Datos caja_datos;

        public Caja_Negocio()
        {
            caja_datos = new Caja_Datos();
        }

        public void GuardarAperturaCaja(Caja caja, string Conexion, ref int verificador)
        {
            try
            {
                caja_datos.GuardarAperturaCaja(caja, Conexion, ref verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error GuardarAperturaCaja" + ex.Message);
            }
        }
        public void AgregarDeposito(decimal monto, string cocepto)
        {
            try
            {
                Caja_Datos datos = new Caja_Datos();
                datos.AgregarDeposito(Comun.Conexion, Comun.id_caja, Comun.Id_U, monto, cocepto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AgregarRetiro(decimal monto, string cocepto, int tipo)
        {
            try
            {
                Caja_Datos datos = new Caja_Datos();
                datos.AgregarRetiro(Comun.Conexion, Comun.id_caja, Comun.Id_U, monto, cocepto, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void EliminarDeposito(string iddeposito)
        {
            try
            {
                Caja_Datos datos = new Caja_Datos();
                datos.EliminarDeposito(Comun.Conexion, iddeposito, Comun.id_caja, Comun.Id_U, 0, "");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void EliminarRetiro(string idretiro)
        {
            try
            {
                Caja_Datos datos = new Caja_Datos();
                datos.EliminarRetiro(Comun.Conexion, idretiro, Comun.id_caja, Comun.Id_U, 0, "", 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void GuardarCierreCaja(Caja caja, string Conexion, ref int verificador)
        {
            try
            {
                caja_datos.GuardarCierreCaja(caja, Conexion, ref verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error GuardarCierreCaja" + ex.Message);
            }
        }
        public Caja ObtenerDatosCaja(Caja caja,bool Estadisticos)
        {
            try
            {
               return caja_datos.ObtenerDatosCaja(caja,Estadisticos);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ObtenerDatosCaja" + ex.Message);
            }
        }
        public Caja ObtenerDatosCaja2(Caja caja, DateTime FechaInicio, DateTime FechaFin, bool Estadisticos)
        {
            try
            {
                return caja_datos.ObtenerDatosCaja2(caja , FechaInicio, FechaFin, Estadisticos);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ObtenerDatosCaja" + ex.Message);
            }
        }
        public void AsignarCaja(string Conexion, Caja caja, ref int Verificador)
        {
            try
            {
                caja_datos.AsignarCaja(Conexion,caja, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboCajas(string Conexion, ref Caja caja)
        {
            try
            {
                caja_datos.CargarComboCaja(Conexion, caja);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CargarComboCajasOcupadas(string Conexion, ref Caja caja)
        {
            try
            {
                caja_datos.CargarComboCajasOcupadas(Conexion, caja);
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
                return caja_datos.ObtenerDatosCajaSai(caja, Estadisticos);
            }
            catch (Exception ex)
            {
                throw new Exception("Error ObtenerDatosCajaSai" + ex.Message);
            }
        }
    }
}
