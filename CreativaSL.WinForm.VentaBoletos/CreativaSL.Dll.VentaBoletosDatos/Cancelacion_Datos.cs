using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Cancelacion_Datos
    {
        public void CancelacionVenta(VentaBoleto venta, MotivoCancelacionesTrasferencias motivo)
        {
            try
            {
                object[] valores = { 
                    venta.tipo_cancelacion,
                    venta.id_venta,
                    venta.id_status,
                    Comun.id_caja,
                    Comun.Id_U,
                    motivo.id_motivoCancelacionTransferencia,
                    motivo.id_tipo,
                    motivo.descripcion
                };
                if (SqlHelper.ExecuteNonQuery(Comun.Conexion, "CancelacionGrupal2_Boletos_sp", valores) <= 0)
                {
                    throw new Exception("Ocurrió un error al cancelar el boleto.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CancelacionBoleto(Boleto boleto, MotivoCancelacionesTrasferencias motivo)
        {
            try
            {
                object[] valores = { 
                    boleto.tipo_cancelacion,
                    boleto.id_boleto,
                    boleto.id_ventadetalle,
                    boleto.id_status,
                    Comun.id_caja,
                    Comun.Id_U,
                    motivo.id_motivoCancelacionTransferencia,
                    motivo.id_tipo,
                    motivo.descripcion};

                if (SqlHelper.ExecuteNonQuery(Comun.Conexion, "Cancelacion_Boletos_sp", valores) <= 0)
                {
                    throw new Exception("Ocurrió un error al cancelar el boleto.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarMotivoCancelacionesTrasferencias(string Conexion, ref List<MotivoCancelacionesTrasferencias> lstMotivoCancelacionesTrasferencias, int tipo)
        {
            try
            {
                SqlDataReader dr = null;
                MotivoCancelacionesTrasferencias _motivo = new MotivoCancelacionesTrasferencias();
                dr = SqlHelper.ExecuteReader(Conexion, "CatMotivoCancelaciones_Combo_sp", tipo);
                while (dr.Read())
                {
                    _motivo = new MotivoCancelacionesTrasferencias();
                    _motivo.id_motivoCancelacionTransferencia = Convert.ToInt32(dr["id_motivoCancelacionTransferencia"].ToString());
                    _motivo.descripcion = dr["descripcion"].ToString();
                    lstMotivoCancelacionesTrasferencias.Add(_motivo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
