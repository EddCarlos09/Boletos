using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class Apartados_Datos
    {
        public Busqueda BuscarBoletos(string Conexion, Busqueda datos)
        {
            try
            {
                object[] valores = { datos.fecha_boleto, datos.nombre_cliente, datos.folio_boleto, datos.folio_venta, datos.band_fecha, datos.band_nombre, datos.band_folio, datos.band_folioVenta };
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "Consultar_BoletosApartados_sp", valores);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0] != null)
                        {
                            datos.resultado = ds.Tables[0];
                        }
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void PagarBoleto(string Conexion, ref Apartados apartados, ref int Verificador)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, CommandType.StoredProcedure, "Boleto_Pagar_sp_PruebaClientes",
                      new SqlParameter("@IDBOLETO", apartados.IDBoleto),
                      new SqlParameter("@IDVENTA", apartados.IDVenta),
                      new SqlParameter("@IDVENTADETALLE", apartados.IDVentaDetalle),
                      new SqlParameter("@TOTALPAGAR", apartados.TotalPagar),
                      new SqlParameter("@PAGOEFECTIVO", apartados.pagoEfectivo),
                      new SqlParameter("@PAGOMONEDERO", apartados.pagoMonedero),
                      new SqlParameter("@PAGOTARJETA", apartados.pagoTarjeta),
                      new SqlParameter("@PAGOTRANSFERENCIA", apartados.pagoTransferencia),
                      new SqlParameter("@IDFORMAPAGO", apartados.IDTipoPago),
                      new SqlParameter("@OBSERVACION", apartados.Observacion),
                      new SqlParameter("@IDVENDEDOR", apartados.IDVendedor),
                      new SqlParameter("@IDCAJA", apartados.IDCaja),
                      new SqlParameter("@IDSUCURSAL", apartados.IDSucursal),
                      new SqlParameter("@DATOSTARJETA", apartados.DatosTarjeta),
                      new SqlParameter("@DATOSTRANSFERENCIA", apartados.DatosTransferencia)
                      );
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void PagarBoleto2(string Conexion, ref Apartados apartados, ref int Verificador)
        {
            try
            {
                object res = SqlHelper.ExecuteScalar(Conexion, CommandType.StoredProcedure, "Boleto_PagarGrupal2_sp2_PruebaClientes",
                  new SqlParameter("@IDVENTA", apartados.IDVenta),
                  new SqlParameter("@IDFORMAPAGO", apartados.IDTipoPago),
                  new SqlParameter("@OBSERVACION", apartados.Observacion),
                  new SqlParameter("@IDVENDEDOR", apartados.IDVendedor),
                  new SqlParameter("@IDCAJA", apartados.IDCaja),
                  new SqlParameter("@IDSUCURSAL", apartados.IDSucursal),
                  new SqlParameter("@PAGOEFECTIVO", apartados.pagoEfectivo),
                  new SqlParameter("@PAGOMONEDERO", apartados.pagoMonedero),
                  new SqlParameter("@PAGOTARJETA", apartados.pagoTarjeta),
                  new SqlParameter("@PAGOTRANSFERENCIA", apartados.pagoTransferencia),
                  new SqlParameter("@DATOSTARJETA", apartados.DatosTarjeta),
                  new SqlParameter("@DATOSTRANSFERENCIA", apartados.DatosTransferencia)
                  );
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
