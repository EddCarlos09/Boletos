using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class VentaBoleto_Datos
    {
        public void VenderBoletos(string Conexion, VentaBoleto InfoVentaBoletosAux, ref int Verificador, ref DataTable DatosBoletos)
        {
            try
            {
              Verificador = 0;
              DataSet Datos_Boletos = new DataSet();
              Datos_Boletos = SqlHelper.ExecuteDataset(Conexion, CommandType.StoredProcedure, "VentaBoletos_Insertar_PruebaClientes", 
              new SqlParameter("@IDSUCURSAL", InfoVentaBoletosAux.id_sucursal), 
              new SqlParameter("@IDTIPOVENTA", InfoVentaBoletosAux.id_tipoVenta), 
              new SqlParameter("@IDCLIENTE", InfoVentaBoletosAux.id_cliente),
              new SqlParameter("@MONEDERO", InfoVentaBoletosAux.Monedero), 
              new SqlParameter("@IDCAJA", InfoVentaBoletosAux.id_caja), 
              new SqlParameter("@IDVENDEDOR", InfoVentaBoletosAux.id_vendedor), 
              new SqlParameter("@SUBTOTAL", InfoVentaBoletosAux.subtotal),
              new SqlParameter("@DESCUENTO", InfoVentaBoletosAux.descuento), 
              new SqlParameter("@IVA", InfoVentaBoletosAux.iva), 
              new SqlParameter("@TOTAL", InfoVentaBoletosAux.total), 
              new SqlParameter("@PAGO", InfoVentaBoletosAux.pago),
              new SqlParameter("@PAGOEFECTIVO", InfoVentaBoletosAux.pagoEfectivo),
              new SqlParameter("@PAGOMONEDERO", InfoVentaBoletosAux.pagoMonedero),
              new SqlParameter("@PAGOTARJETA", InfoVentaBoletosAux.pagoTarjeta),
              new SqlParameter("@PAGOTRANSFERENCIA", InfoVentaBoletosAux.PagoTransferencia),
              new SqlParameter("@CAMBIO", InfoVentaBoletosAux.cambio), 
              new SqlParameter("@ESTATUS", InfoVentaBoletosAux.estatus), 
              new SqlParameter("@PENDIENTE", InfoVentaBoletosAux.pendiente), 
              new SqlParameter("@IDFORMAPAGO", InfoVentaBoletosAux.id_formaPago),
              new SqlParameter("@OBSERVACION", InfoVentaBoletosAux.ObservacionPago),
              new SqlParameter("@DATOSBOLETOS", InfoVentaBoletosAux.BoletosDetalle),
              new SqlParameter("@DATOSBOLETOSTRANSFERIDOS", InfoVentaBoletosAux.BoletosTransferencia),
              new SqlParameter("@DATOSTARJETA", InfoVentaBoletosAux.DatosTarjeta),
              new SqlParameter("@DATOSTRANSFERENCIA", InfoVentaBoletosAux.DatosTransferencia),
              new SqlParameter("@MACADDRESS", Comun.macAdress),
              new SqlParameter("@VENTAGRUPAL", InfoVentaBoletosAux.ventaGrupal),
              new SqlParameter("@NOMBRE", InfoVentaBoletosAux.boletosGrupal.nombre),
              new SqlParameter("@NUMEROTELEFONO", InfoVentaBoletosAux.boletosGrupal.numeroTelefono),
              new SqlParameter("@FECHANACIMIENTO", InfoVentaBoletosAux.boletosGrupal.fechaNacimiento)

              );
              if (Convert.ToInt32(Datos_Boletos.Tables[0].Rows[0][0]) == 1)
              {
                  DatosBoletos = Datos_Boletos.Tables[1];
                  Verificador = 1;
              }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarNombreBoleto(string Conexion, Boleto Boleto, ref int Verificador)
        {
            try
            {
                object[] Valores = { Boleto.id_boleto, Boleto.id_caja, Boleto.cliente_nombre,Boleto.fechaNacimientoV, Boleto.numeroTelefono, Comun.Id_U };
                object res = SqlHelper.ExecuteScalar(Conexion, "CatBoletos_Modificar_sp", Valores);
                Verificador = Convert.ToInt32(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Busqueda BuscarVenta(string Conexion, Busqueda datos)
        {
            try
            {
                object[] valores = { datos.fecha_boleto, datos.nombre_cliente, datos.folio_boleto, datos.band_fecha, datos.band_nombre, datos.band_folio };
                DataSet ds = SqlHelper.ExecuteDataset(Conexion, "Consultar_Ventas_sp", valores);
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
    }
}
