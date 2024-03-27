using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Reportes_Negocio
    {
        private Reportes_Datos Reportes_Datos;
        public List<Caja> ConsultarCajasXFechaxSucursal(string conexion, DateTime fecha, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarCajasXFechaxSucursal(conexion, fecha, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Depositos_Retiros> ConsultarRetDepXIDCajaXSucursal(string conexion, int opcion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarRetDepXIDCajaXSucursal(conexion, opcion, id_cajaxsucursal, fecha, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarVentasXIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarVentasXIDCajaXSucursal(conexion, id_cajaxsucursal, fecha, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarReservacionesXIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarReservacionesXIDCajaXSucursal(conexion, id_cajaxsucursal, fecha, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarAnticipo1XIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarAnticipo1XIDCajaXSucursal(conexion, id_cajaxsucursal, fecha,  Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarAnticipo2XIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarAnticipo2XIDCajaXSucursal(conexion, id_cajaxsucursal, fecha, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarTransferenciaXIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarTransferenciaXIDCajaXSucursal(conexion, id_cajaxsucursal, fecha,  Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarCancelacionesXIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarCancelacionesXIDCajaXSucursal(conexion, id_cajaxsucursal, fecha,  Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Maletas> ConsultarMaletasXIDCajaXSucursal(string conexion, string id_cajaxsucursal, DateTime fecha, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarMaletasXIDCajaXSucursal(conexion, id_cajaxsucursal, fecha,  Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ConsultaReporteInformeClienteComprador(string Conexion, ref List<ReportesClienteComprador> lstClienteComprador, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ConsultaReporteInformeClienteComprador(Conexion, ref lstClienteComprador,Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultaReporteInformeClienteFrecuente(string Conexion, ref List<ReportesClienteFrecuente> lstClienteFrecuente, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ConsultaReporteInformeClienteFrecuente(Conexion, ref lstClienteFrecuente, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Viaje> ConsultarViajesXFecha(string Conexion, DateTime fecha)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarViajesXFecha(Conexion, fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Corrida> ConsultarCorridasViaje(string Conexion, Viaje cmbViaje)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarCorridasViaje(Conexion, cmbViaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultarReporteBoletosViaje(string Conexion, ref ReportesBoletosViaje reportesboletos, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ConsultarReporteBoletosViaje(Conexion, ref reportesboletos,  Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultarReporteBoletosViaje2(string Conexion, ref ReportesBoletosViaje reportesboletos, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ConsultarReporteBoletosViaje2(Conexion, ref reportesboletos, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RevisarDatos(string Conexion, ref int Verificador, ReportesBoletosViaje reportesboletos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.RevisarDatos(Conexion,ref Verificador, ref reportesboletos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void GuardarDatosViaje(string Conexion, ReportesBoletosViajeHecotours viaje, ref int Verificador)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.GuardarDatosViaje(Conexion, viaje, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboChoferes(string Conexion, ref ReportesBoletosViajeHecotours reportesBoletosViaje)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.CargarComboChoferes(Conexion, ref reportesBoletosViaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarComboViaje(string Conexion, ref ReportesBoletosViajeHecotours viaje, DateTime fechaSalida)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.CargarComboViaje(Conexion, ref viaje, fechaSalida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultarReporteDatosReportes(string Conexion, ref ReportesDatosReportes reportesDatos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ConsultarReporteDatosReportes(Conexion, ref reportesDatos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ConsultaReporteInformeTotalesCajas(string conexion, ref List<Caja> lstCaja, DateTime fecha, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ConsultaReporteInformeTotalesCajas(conexion, ref lstCaja, fecha, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// reporte de Folio de clientes
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="Verificador"></param>
        /// <param name="reportesmaletas"></param>
        public void ConsultaReporteInformeFolios(string conexion, ref List<V2Tarjeta> lstFolio, int verTodo)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ConsultaReporteInformeFolios(conexion, ref lstFolio, verTodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RevisarDatos2(string conexion, ref int Verificador, ReportesMaletasViaje reportesmaletas)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.RevisarDatos2(conexion, ref Verificador, ref reportesmaletas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ConsultarReporteMaletasViaje(string conexion, ref ReportesMaletasViaje reportesmaletas, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ConsultarReporteMaletasViaje(conexion, ref reportesmaletas, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultaReporteInformeDetalleBoletos(string conexion, ref List<Boleto> lstBoleto, string IDBoleto, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ConsultaReporteInformeDetalleBoletos(conexion, ref lstBoleto, IDBoleto, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ConsultaReporteInformeVendedorXFecha(string conexion, ref List<ReporteUsuarios> lstReporteUsuarios, DateTime fechaInicio, DateTime fechaFinal, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ConsultaReporteInformeVendedorXFecha(conexion, ref lstReporteUsuarios, fechaInicio, fechaFinal, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Depositos_Retiros> ConsultarRetDepXIDCajaXSucursal2(string conexion, int opcion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarRetDepXIDCajaXSucursal2(conexion, opcion, id_cajaxsucursal, fechaInicio, fechaFin, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarVentasXIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarVentasXIDCajaXSucursal2(conexion, id_cajaxsucursal, fechaInicio, fechaFin,  Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarReservacionesXIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarReservacionesXIDCajaXSucursal2(conexion, id_cajaxsucursal, fechaInicio, fechaFin, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarAnticipo1XIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarAnticipo1XIDCajaXSucursal2(conexion, id_cajaxsucursal, fechaInicio, fechaFin, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarAnticipo2XIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarAnticipo2XIDCajaXSucursal2(conexion, id_cajaxsucursal, fechaInicio, fechaFin, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarTransferenciaXIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarTransferenciaXIDCajaXSucursal2(conexion, id_cajaxsucursal, fechaInicio, fechaFin, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ReportesVentasCaja> ConsultarCancelacionesXIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarCancelacionesXIDCajaXSucursal2(conexion, id_cajaxsucursal, fechaInicio, fechaFin, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Maletas> ConsultarMaletasXIDCajaXSucursal2(string conexion, string id_cajaxsucursal, DateTime fechaInicio, DateTime fechaFin, bool Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.ConsultarMaletasXIDCajaXSucursal2(conexion, id_cajaxsucursal, fechaInicio, fechaFin, Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void obtenerDatosBaseViajes(string Conexion, ref ReportesBoletosViajeHecotours viaje_aux, Viaje auxViaje)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.obtenerDatosBaseViajes(Conexion, ref viaje_aux, auxViaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ReportesBoletosViajeHecotours RptViajesGenerados(string Conexion, DateTime fecha, bool _Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                return Reportes_Datos.obtenerDatosBase(Conexion, fecha, _Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarRprViaje(string Conexion, ReportesBoletosViajeHecotours ViajeAux, ref int Verificador)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.EliminarRprViaje(Conexion, ViajeAux, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void obtenerDatosReportesViaje(string Conexion, ref ReportesBoletosViajeHecotours ViajeAux, bool _Estadisticos)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.obtenerDatosReportesViaje(Conexion, ref ViajeAux, _Estadisticos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CargarComboViajeModificar(string Conexion, ref ReportesBoletosViajeHecotours viaje, DateTime fechaSalida, string id_viaje)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.CargarComboViajeModificar(Conexion, ref viaje, fechaSalida, id_viaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarDatosViaje(string Conexion , ReportesBoletosViajeHecotours viaje, ref int Verificador)
        {
            try
            {
                Reportes_Datos = new Reportes_Datos();
                Reportes_Datos.ModificarDatosViaje(Conexion, viaje, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
