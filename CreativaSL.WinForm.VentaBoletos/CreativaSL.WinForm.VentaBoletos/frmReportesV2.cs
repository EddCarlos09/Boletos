using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmReportesV2 : MaterialForm
    {


        public frmReportesV2()
        {
            InitializeComponent();
            loadMaterial(this);
        }
        private void frmReportesV2_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;
            this.EstablecerPropiedades();
            this.LlenarCombo(this.TxtFechaInicio.Value);
            this.CargarReporte();
            this.reportViewer1.RefreshReport();
        }
        bool _Estadisticos = false;
        int verTodo = 0;
        Validaciones Val;
        int infoTipoReporte = 0;
        ReportesBoletosViajeHecotours ViajeAux_HecoTours;
        Maletas maletas;

        public bool Estadisticos
        {
            get { return _Estadisticos; }
            set { _Estadisticos = value; }
        }

        public frmReportesV2(int opcion)
        {
            infoTipoReporte = opcion;
            InitializeComponent();
        }
        public frmReportesV2(int opcion, ReportesBoletosViajeHecotours ViajeAux)
        {
            infoTipoReporte = opcion;
            InitializeComponent();
            ViajeAux_HecoTours = ViajeAux;
        }
        public frmReportesV2(int opcion, Maletas _maletas)
        {
            infoTipoReporte = opcion;
            maletas = _maletas;
            InitializeComponent();
        }

        private void EstablecerPropiedades()
        {
            this.btn_VerTodos.Visible = false;
            if (infoTipoReporte == 0)
            {

            }
            else if (infoTipoReporte == 1)
            {
                this.LabelFechaInicio.Text = "Fecha";
                this.LabelFechaFin.Visible = false;
                this.LabelTurno.Visible = true;
                this.LabelTurno.Text = "Cajero/Caja";
                this.TxtFechaFin.Visible = false;
                this.cmbTurno.Visible = true;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
            }
            else if (infoTipoReporte == 2)
            {
                this.LabelFechaInicio.Text = "Fecha";
                this.LabelFechaFin.Visible = false;
                this.LabelTurno.Visible = false;
                this.TxtFechaFin.Visible = false;
                this.cmbTurno.Visible = false;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
            }
            else if (infoTipoReporte == 3)
            {
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
            }
            else if (infoTipoReporte == 4)
            {
                this.LabelTurno.Visible = false;
                this.cmbTurno.Visible = false;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
            }
            else if (infoTipoReporte == 5)
            {
                this.TxtFechaInicio.Visible = false;
                this.LabelFechaInicio.Visible = false;
                this.LabelFechaInicio.Text = "Fecha";
                this.LabelFechaFin.Visible = false;
                this.TxtFechaFin.Visible = false;
                this.LabelTurno.Visible = false;
                this.LabelTurno.Text = "Viajes";
                this.cmbTurno.Visible = false;
                this.LabelFechaFin.Text = "Fecha";
                this.LabelFechaFin.Visible = false;
                this.LabelFolio.Visible = true;
                this.TxtFechaFin.Visible = false;
            }
            else if (infoTipoReporte == 6)
            {
            }
            else if (infoTipoReporte == 7)
            {
                this.LabelFechaInicio.Visible = false;
                this.LabelFechaFin.Visible = false;
                this.LabelTurno.Visible = false;
                this.TxtFechaInicio.Visible = false;
                this.TxtFechaFin.Visible = false;
                this.cmbTurno.Visible = false;
                this.btn_Buscar.Visible = false;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
            }
            else if (infoTipoReporte == 8)
            {
                this.LabelFechaInicio.Visible = false;
                this.LabelFechaFin.Visible = false;
                this.LabelTurno.Visible = false;
                this.TxtFechaInicio.Visible = false;
                this.TxtFechaFin.Visible = false;
                this.cmbTurno.Visible = false;
                this.btn_Buscar.Visible = false;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
            }
            else if (infoTipoReporte == 9)
            {
                this.LabelFechaInicio.Visible = false;
                this.LabelFechaFin.Visible = false;
                this.LabelTurno.Visible = false;
                this.TxtFechaInicio.Visible = false;
                this.TxtFechaFin.Visible = false;
                this.cmbTurno.Visible = false;
                this.btn_Buscar.Visible = false;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
                this.label4.Visible = false;
            }
            else if (infoTipoReporte == 10)
            {
                this.LabelFechaInicio.Visible = false;
                this.LabelFechaFin.Visible = false;
                this.LabelTurno.Visible = false;
                this.TxtFechaInicio.Visible = false;
                this.TxtFechaFin.Visible = false;
                this.cmbTurno.Visible = false;
                this.btn_Buscar.Visible = false;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
                this.label4.Visible = false;
            }
            else if (infoTipoReporte == 11)
            {
                this.LabelFechaInicio.Visible = false;
                this.LabelFechaFin.Visible = false;
                this.LabelTurno.Visible = false;
                this.TxtFechaInicio.Visible = false;
                this.TxtFechaFin.Visible = false;
                this.cmbTurno.Visible = false;
                this.btn_Buscar.Visible = false;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
                this.label4.Visible = false;
            }
            else if (infoTipoReporte == 12)
            {
                this.LabelFechaInicio.Visible = false;
                this.LabelFechaFin.Visible = false;
                this.LabelTurno.Visible = false;
                this.TxtFechaInicio.Visible = false;
                this.TxtFechaFin.Visible = false;
                this.cmbTurno.Visible = false;
                this.btn_Buscar.Visible = false;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
                this.label4.Visible = false;
            }
            else if (infoTipoReporte == 13)
            {
                this.LabelFechaInicio.Visible = false;
                this.btn_Buscar.Visible = false;
                this.btn_VerTodos.Visible = true;
                this.LabelFechaFin.Visible = false;
                this.LabelTurno.Visible = false;
                this.TxtFechaFin.Visible = false;
                this.cmbTurno.Visible = false;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
            }
            else if (infoTipoReporte == 14)
            {
                this.LabelFechaInicio.Visible = false;
                this.LabelFechaFin.Visible = false;
                this.LabelTurno.Visible = false;
                this.TxtFechaInicio.Visible = false;
                this.TxtFechaFin.Visible = false;
                this.cmbTurno.Visible = false;
                this.btn_Buscar.Visible = false;
                this.LabelFolio.Visible = false;
                this.txtFolio.Visible = false;
            }
        }

        private void CargarReporte()
        {
            if (infoTipoReporte == 0)
            {

            }
            else if (infoTipoReporte == 1)
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 110;
                Caja caja = (Caja)this.cmbTurno.SelectedItem;
                reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_CajasMod.rdlc";
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                List<Depositos_Retiros> listaretiros = new List<Depositos_Retiros>();
                List<Depositos_Retiros> listadepositos = new List<Depositos_Retiros>();
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                List<ReportesVentasCaja> listareservaciones = new List<ReportesVentasCaja>();
                List<ReportesVentasCaja> listaanticipo1 = new List<ReportesVentasCaja>();
                List<ReportesVentasCaja> listaanticipo2 = new List<ReportesVentasCaja>();
                List<ReportesVentasCaja> listatransferencia = new List<ReportesVentasCaja>();
                List<ReportesVentasCaja> listacancelaciones = new List<ReportesVentasCaja>();
                List<Maletas> listamaletas = new List<Maletas>();
                listaretiros = Reportes_Negocio.ConsultarRetDepXIDCajaXSucursal(Comun.Conexion, 1, caja.id_caja, this.TxtFechaInicio.Value, Estadisticos);
                listadepositos = Reportes_Negocio.ConsultarRetDepXIDCajaXSucursal(Comun.Conexion, 2, caja.id_caja, this.TxtFechaInicio.Value, Estadisticos);
                listaventas = Reportes_Negocio.ConsultarVentasXIDCajaXSucursal(Comun.Conexion, caja.id_caja, this.TxtFechaInicio.Value, Estadisticos);
                listareservaciones = Reportes_Negocio.ConsultarReservacionesXIDCajaXSucursal(Comun.Conexion, caja.id_caja, this.TxtFechaInicio.Value, Estadisticos);
                listaanticipo1 = Reportes_Negocio.ConsultarAnticipo1XIDCajaXSucursal(Comun.Conexion, caja.id_caja, this.TxtFechaInicio.Value, Estadisticos);
                listaanticipo2 = Reportes_Negocio.ConsultarAnticipo2XIDCajaXSucursal(Comun.Conexion, caja.id_caja, this.TxtFechaInicio.Value, Estadisticos);
                listatransferencia = Reportes_Negocio.ConsultarTransferenciaXIDCajaXSucursal(Comun.Conexion, caja.id_caja, this.TxtFechaInicio.Value, Estadisticos);
                listacancelaciones = Reportes_Negocio.ConsultarCancelacionesXIDCajaXSucursal(Comun.Conexion, caja.id_caja, this.TxtFechaInicio.Value, Estadisticos);
                listamaletas = Reportes_Negocio.ConsultarMaletasXIDCajaXSucursal(Comun.Conexion, caja.id_caja, this.TxtFechaInicio.Value, Estadisticos);
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                parameters[2] = new ReportParameter("direccion", reportesDatos.direccion);
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                Caja_Negocio cn = new Caja_Negocio();
                caja = cn.ObtenerDatosCaja(caja, Estadisticos);
                List<Caja> listacajas = new List<Caja>();
                listacajas.Add(caja);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("depositos", listadepositos));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("retiros", listaretiros));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("cajadatos", listacajas));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ventasBoletos", listaventas));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("reservacionesBoletos", listareservaciones));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("anticiposBoletos1", listaanticipo1));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("anticiposBoletos2", listaanticipo2));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("transferenciasBoletos", listatransferencia));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("cancelacionesBoletos", listacancelaciones));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("maletas", listamaletas));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 2)
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();
                List<Caja> lstCaja = new List<Caja>();
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_TotalesCajas.rdlc";
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                ReportParameter[] parameters = new ReportParameter[5];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                parameters[2] = new ReportParameter("direccion", reportesDatos.direccion);
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                parameters[4] = new ReportParameter("fecha", this.TxtFechaInicio.Value.ToShortDateString());
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                Reportes_Negocio.ConsultaReporteInformeTotalesCajas(Comun.Conexion, ref lstCaja, this.TxtFechaInicio.Value, Estadisticos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Cajas", lstCaja));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 3)
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 110;
                Caja caja = (Caja)this.cmbTurno.SelectedItem;
                reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_CajasFechasMod.rdlc";
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                List<Depositos_Retiros> listaretiros = new List<Depositos_Retiros>();
                List<Depositos_Retiros> listadepositos = new List<Depositos_Retiros>();
                List<ReportesVentasCaja> listaventas = new List<ReportesVentasCaja>();
                List<ReportesVentasCaja> listareservaciones = new List<ReportesVentasCaja>();
                List<ReportesVentasCaja> listaanticipo1 = new List<ReportesVentasCaja>();
                List<ReportesVentasCaja> listaanticipo2 = new List<ReportesVentasCaja>();
                List<ReportesVentasCaja> listatransferencia = new List<ReportesVentasCaja>();
                List<ReportesVentasCaja> listacancelaciones = new List<ReportesVentasCaja>();
                List<Maletas> listamaletas = new List<Maletas>();
                listaretiros = Reportes_Negocio.ConsultarRetDepXIDCajaXSucursal2(Comun.Conexion, 1, caja.id_cajaCat, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                listadepositos = Reportes_Negocio.ConsultarRetDepXIDCajaXSucursal2(Comun.Conexion, 2, caja.id_cajaCat, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                listaventas = Reportes_Negocio.ConsultarVentasXIDCajaXSucursal2(Comun.Conexion, caja.id_cajaCat, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                listareservaciones = Reportes_Negocio.ConsultarReservacionesXIDCajaXSucursal2(Comun.Conexion, caja.id_cajaCat, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                listaanticipo1 = Reportes_Negocio.ConsultarAnticipo1XIDCajaXSucursal2(Comun.Conexion, caja.id_cajaCat, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                listaanticipo2 = Reportes_Negocio.ConsultarAnticipo2XIDCajaXSucursal2(Comun.Conexion, caja.id_cajaCat, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                listatransferencia = Reportes_Negocio.ConsultarTransferenciaXIDCajaXSucursal2(Comun.Conexion, caja.id_cajaCat, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                listacancelaciones = Reportes_Negocio.ConsultarCancelacionesXIDCajaXSucursal2(Comun.Conexion, caja.id_cajaCat, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                listamaletas = Reportes_Negocio.ConsultarMaletasXIDCajaXSucursal2(Comun.Conexion, caja.id_cajaCat, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                parameters[2] = new ReportParameter("direccion", reportesDatos.direccion);
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                Caja_Negocio cn = new Caja_Negocio();
                caja = cn.ObtenerDatosCaja2(caja, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                caja.FechaIngreso = TxtFechaInicio.Value.ToShortDateString();
                caja.HoraIngreso = TxtFechaFin.Value.ToShortDateString();
                List<Caja> listacajas = new List<Caja>();
                listacajas.Add(caja);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("depositos", listadepositos));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("retiros", listaretiros));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("cajadatos", listacajas));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ventasBoletos", listaventas));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("reservacionesBoletos", listareservaciones));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("anticiposBoletos1", listaanticipo1));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("anticiposBoletos2", listaanticipo2));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("transferenciasBoletos", listatransferencia));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("cancelacionesBoletos", listacancelaciones));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("maletas", listamaletas));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 4)
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();
                List<ReporteUsuarios> lstReporteUsuarios = new List<ReporteUsuarios>();
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_TotalesVendedorXFechas.rdlc";
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                ReportParameter[] parameters = new ReportParameter[6];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                parameters[2] = new ReportParameter("direccion", reportesDatos.direccion);
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                parameters[4] = new ReportParameter("fechaInicial", this.TxtFechaInicio.Value.ToShortDateString());
                parameters[5] = new ReportParameter("fechaFinal", this.TxtFechaFin.Value.ToShortDateString());

                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                Reportes_Negocio.ConsultaReporteInformeVendedorXFecha(Comun.Conexion, ref lstReporteUsuarios, this.TxtFechaInicio.Value, this.TxtFechaFin.Value, Estadisticos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Vendedores", lstReporteUsuarios));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 5)
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_DetalleBoleto.rdlc";
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                parameters[2] = new ReportParameter("direccion", reportesDatos.direccion);
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                List<Boleto> lstBoleto = new List<Boleto>();
                Reportes_Negocio.ConsultaReporteInformeDetalleBoletos(Comun.Conexion, ref lstBoleto, this.txtFolio.Text, Estadisticos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Boleto", lstBoleto));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 6)
            {
            }
            else if (infoTipoReporte == 7)
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();
                List<ReportesClienteComprador> lstClienteComprador = new List<ReportesClienteComprador>();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_ClienteComprador.rdlc";
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                parameters[2] = new ReportParameter("direccion", reportesDatos.direccion);
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                Reportes_Negocio.ConsultaReporteInformeClienteComprador(Comun.Conexion, ref lstClienteComprador, Estadisticos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ClienteComprador", lstClienteComprador));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 8)
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();
                List<ReportesClienteFrecuente> lstClienteFrecuente = new List<ReportesClienteFrecuente>();
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_ClienteFrecuente.rdlc";
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                parameters[2] = new ReportParameter("direccion", reportesDatos.direccion);
                parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                Reportes_Negocio.ConsultaReporteInformeClienteFrecuente(Comun.Conexion, ref lstClienteFrecuente, Estadisticos);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ClienteFrecuente", lstClienteFrecuente));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 9)
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_ContratoServicio_HecoTours.rdlc";
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                ReportParameter[] parameters = new ReportParameter[25];
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[0] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[0] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                parameters[1] = new ReportParameter("Folio", ViajeAux_HecoTours.folio_prestacionServicios2);
                parameters[2] = new ReportParameter("solicitadoPor", ViajeAux_HecoTours.solicitado_por_prestacionServicios2);
                parameters[3] = new ReportParameter("poliza", ViajeAux_HecoTours.poliza_prestacionServicios2);
                parameters[4] = new ReportParameter("poliza_fecha_inicio", ViajeAux_HecoTours.poliza_fecha1_prestacionServicios2.ToString("dd/MM/yyyy"));
                parameters[5] = new ReportParameter("poliza_fecha_fin", ViajeAux_HecoTours.poliza_fecha2_prestacionServicios2.ToString("dd/MM/yyyy"));
                parameters[6] = new ReportParameter("credencial_elector", ViajeAux_HecoTours.credencial_elector_prestacionServicios2);
                parameters[7] = new ReportParameter("domicilio", ViajeAux_HecoTours.domicilio_prestacionServicios2);
                parameters[8] = new ReportParameter("origen", ViajeAux_HecoTours.origen_prestacionServicios2);
                parameters[9] = new ReportParameter("destino", ViajeAux_HecoTours.destino_prestacionServicios2);
                parameters[10] = new ReportParameter("monto_servicio", String.Format(new CultureInfo("es-MX"), ViajeAux_HecoTours.monto_servicio_prestacionServicios2.ToString()));
                parameters[11] = new ReportParameter("monto_servicio_texto", "(" + ViajeAux_HecoTours.monto_servicio_texto_prestacionServicios2 + ")");
                parameters[12] = new ReportParameter("lugar_salida", ViajeAux_HecoTours.origen_prestacionServicios2);
                parameters[13] = new ReportParameter("fecha_salida", ViajeAux_HecoTours.fecha_salida_prestacionServicios2.ToString("dd/MM/yyyy"));
                parameters[14] = new ReportParameter("hora_salida", ViajeAux_HecoTours.hora_salida_prestacionServicios2);
                parameters[15] = new ReportParameter("numero_personas", ViajeAux_HecoTours.numero_personas_prestacionServicios2.ToString());
                parameters[16] = new ReportParameter("operador1", ViajeAux_HecoTours.chofer1_prestacionServicios2);
                parameters[17] = new ReportParameter("operador2", ViajeAux_HecoTours.chofer2_prestacionServicios2);
                parameters[18] = new ReportParameter("numero_placa", ViajeAux_HecoTours.numero_placa_prestacionServicios2);
                parameters[19] = new ReportParameter("ruta_contratada", ViajeAux_HecoTours.ruta_contratada_prestacionServicios2);
                parameters[20] = new ReportParameter("dias_viajes", ViajeAux_HecoTours.dias_viaje_prestacionServicios2.ToString());
                parameters[21] = new ReportParameter("dia_y_hora_salida", ViajeAux_HecoTours.dia_hora_salida_prestacionServicios2);
                parameters[22] = new ReportParameter("dia", ViajeAux_HecoTours.fecha_salida_prestacionServicios2.Day.ToString());
                CultureInfo culture = new CultureInfo("es-MX");
                parameters[23] = new ReportParameter("mes", ViajeAux_HecoTours.fecha_salida_prestacionServicios2.ToString("MMMM", culture));
                parameters[24] = new ReportParameter("año", ViajeAux_HecoTours.fecha_salida_prestacionServicios2.Year.ToString());
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 10)
            {
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                ReportesBoletosViaje reportesboletos = new ReportesBoletosViaje();
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                reportesboletos.IDViaje = ViajeAux_HecoTours.IDViaje;
                reportesboletos.FechaV = ViajeAux_HecoTours.FechaV;
                reportesboletos.HoraV = ViajeAux_HecoTours.HoraV;
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 110;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_Contrato_Servicio_HecoTours2.rdlc";
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                ReportParameter[] parameters = new ReportParameter[17];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[2] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[2] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                parameters[3] = new ReportParameter("direccion", reportesDatos.direccion);
                parameters[4] = new ReportParameter("operador1", ViajeAux_HecoTours.chofer1_prestacionServicios1);
                parameters[5] = new ReportParameter("operador2", ViajeAux_HecoTours.chofer2_prestacionServicios1);
                parameters[6] = new ReportParameter("autobus", ViajeAux_HecoTours.autobus_prestacionServicios1);
                parameters[7] = new ReportParameter("fecha", ViajeAux_HecoTours.fecha_salida_prestacionServicios1.ToString("dd/MM/yyyy"));
                parameters[8] = new ReportParameter("folio", ViajeAux_HecoTours.folio_prestacionServicios1);
                parameters[9] = new ReportParameter("solicitado_por", ViajeAux_HecoTours.solicitado_por_prestacionServicios1);
                parameters[10] = new ReportParameter("grupo", ViajeAux_HecoTours.grupo_prestacionServicios1.ToString());
                parameters[11] = new ReportParameter("servicios", ViajeAux_HecoTours.servicio_prestacionServicios1);
                parameters[12] = new ReportParameter("presentarse_en", ViajeAux_HecoTours.presentarse_en_prestacionServicios1);
                parameters[13] = new ReportParameter("hora", ViajeAux_HecoTours.hora_salida_prestacionServicios1);
                parameters[14] = new ReportParameter("instrucciones", ViajeAux_HecoTours.instrucciones_prestacionServicios1);
                parameters[15] = new ReportParameter("observaciones", ViajeAux_HecoTours.observaciones_prestacionServicios1);
                parameters[16] = new ReportParameter("contacto", ViajeAux_HecoTours.solicitado_por_prestacionServicios1);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                List<ReportesBoletosViaje> lst_Reporte = new List<ReportesBoletosViaje>();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Reporte", lst_Reporte));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 11)
            {
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                ReportesBoletosViaje reportesboletos = new ReportesBoletosViaje();
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                reportesboletos.IDViaje = ViajeAux_HecoTours.IDViaje;
                reportesboletos.FechaV = ViajeAux_HecoTours.FechaV;
                reportesboletos.HoraV = ViajeAux_HecoTours.HoraV;
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 110;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_Boletos_Viaje.rdlc";
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                Reportes_Negocio.ConsultarReporteBoletosViaje2(Comun.Conexion, ref reportesboletos, Estadisticos);
                ReportParameter[] parameters = new ReportParameter[12];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[2] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[2] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                parameters[3] = new ReportParameter("oficina", ViajeAux_HecoTours.oficina_listapasajeros);
                parameters[4] = new ReportParameter("dia", ViajeAux_HecoTours.dia_listapasajeros.ToString());
                parameters[5] = new ReportParameter("mes", ViajeAux_HecoTours.mes_listapasajeros.ToString());
                parameters[6] = new ReportParameter("año", ViajeAux_HecoTours.año_listapasajeros.ToString());
                parameters[7] = new ReportParameter("carro", ViajeAux_HecoTours.carro_listapasajeros);
                parameters[8] = new ReportParameter("nombre_oficinista", ViajeAux_HecoTours.oficinista_listapasajeros);
                parameters[9] = new ReportParameter("hora_salida", ViajeAux_HecoTours.hora_salida_listapasajeros);
                parameters[10] = new ReportParameter("folio", ViajeAux_HecoTours.folio_listapasajeros);
                parameters[11] = new ReportParameter("direccion", reportesDatos.direccion);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Boletos", reportesboletos.lstBoletos));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 12)
            {
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                ReportesBoletosViaje reportesboletos = new ReportesBoletosViaje();
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                reportesboletos.IDViaje = ViajeAux_HecoTours.IDViaje;
                reportesboletos.FechaV = ViajeAux_HecoTours.FechaV;
                reportesboletos.HoraV = ViajeAux_HecoTours.HoraV;
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 110;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_Boletos_Viaje.rdlc";
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                Reportes_Negocio.ConsultarReporteBoletosViaje(Comun.Conexion, ref reportesboletos, Estadisticos);
                ReportParameter[] parameters = new ReportParameter[12];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[2] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[2] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                parameters[3] = new ReportParameter("oficina", ViajeAux_HecoTours.oficina_listapasajeros);
                parameters[4] = new ReportParameter("dia", ViajeAux_HecoTours.dia_listapasajeros.ToString());
                parameters[5] = new ReportParameter("mes", ViajeAux_HecoTours.mes_listapasajeros.ToString());
                parameters[6] = new ReportParameter("año", ViajeAux_HecoTours.año_listapasajeros.ToString());
                parameters[7] = new ReportParameter("carro", ViajeAux_HecoTours.carro_listapasajeros);
                parameters[8] = new ReportParameter("nombre_oficinista", ViajeAux_HecoTours.oficinista_listapasajeros);
                parameters[9] = new ReportParameter("hora_salida", ViajeAux_HecoTours.hora_salida_listapasajeros);
                parameters[10] = new ReportParameter("folio", ViajeAux_HecoTours.folio_listapasajeros);
                parameters[11] = new ReportParameter("direccion", reportesDatos.direccion);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Boletos", reportesboletos.lstBoletos));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 13)
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();
                List<V2Tarjeta> lstFolio = new List<V2Tarjeta>();
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Clientes.Informe_FoliosDisponibles.rdlc";
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                ReportParameter[] parameters = new ReportParameter[4];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                parameters[2] = new ReportParameter("direccion", reportesDatos.direccion);
                if (File.Exists(@"Resources\documents\" + reportesDatos.path.ToLower()))
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                else
                    parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\aury.jpg")).AbsoluteUri);
                //parameters[4] = new ReportParameter("fecha", this.TxtFechaInicio.Value.ToShortDateString());
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                Reportes_Negocio.ConsultaReporteInformeFolios(Comun.Conexion, ref lstFolio, verTodo);
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Folio", lstFolio));
                this.reportViewer1.RefreshReport();
            }
            else if (infoTipoReporte == 14)
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.LocalReport.DataSources.Clear();
                Ticket_Negocio tn = new Ticket_Negocio();
                ReportesDatosReportes reportesDatos = new ReportesDatosReportes();
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "CreativaSL.WinForm.VentaBoletos.Informe_MaletaComanda.rdlc";
                Reportes_Negocio.ConsultarReporteDatosReportes(Comun.Conexion, ref reportesDatos);
                var datos = tn.obtenerDatosMaleta(Comun.Conexion, maletas.id_boleto, maletas.idMaleta);
                ReportParameter[] parameters = new ReportParameter[19];
                parameters[0] = new ReportParameter("razonSocial", reportesDatos.razonSocial);
                parameters[1] = new ReportParameter("rfc", reportesDatos.rfc);
                parameters[2] = new ReportParameter("direccion", reportesDatos.direccion);
                parameters[3] = new ReportParameter("path", new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + reportesDatos.path.ToLower())).AbsoluteUri);
                parameters[4] = new ReportParameter("fechaVenta", datos.fechaVenta.ToShortDateString());
                parameters[5] = new ReportParameter("folioBoleto", datos.folioBoleto);
                parameters[6] = new ReportParameter("horaVenta", datos.horaVenta);
                parameters[7] = new ReportParameter("cliente", datos.cliente);
                parameters[8] = new ReportParameter("fechaSalida", datos.fechaSalida.ToShortDateString());
                parameters[9] = new ReportParameter("horaSalida", datos.horaSalida);
                parameters[10] = new ReportParameter("folioMaleta", datos.folioMaleta);
                parameters[11] = new ReportParameter("descripcion", datos.descripcion);
                parameters[12] = new ReportParameter("cantidad", datos.numeroMaletas.ToString());
                parameters[13] = new ReportParameter("precio", string.Format("{0:C2}", datos.precioMaleta));
                parameters[14] = new ReportParameter("importe", string.Format("{0:C2}", datos.precioMaleta));
                parameters[15] = new ReportParameter("iva", string.Format("{0:C2}", (datos.precioIva - datos.precioMaleta)));
                parameters[16] = new ReportParameter("total", string.Format("{0:C2}", datos.precioIva));
                parameters[17] = new ReportParameter("vendedor", datos.cajero);
                parameters[18] = new ReportParameter("destino", datos.destino);
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
        }
        private void ObtenerDatosViaje(ref ReportesBoletosViaje reportesboletos)
        {
            try
            {
                Viaje AuxViaje = (Viaje)this.cmbTurno.SelectedItem;
                reportesboletos.IDViaje = AuxViaje.IDViaje;
                reportesboletos.FechaV = AuxViaje.FechaV;
                reportesboletos.HoraV = AuxViaje.HoraV;
                reportesboletos.IDChofer = "";
                reportesboletos.observacion = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosViaje2(ref ReportesMaletasViaje reportesmaletas)
        {
            try
            {
                Viaje AuxViaje = (Viaje)this.cmbTurno.SelectedItem;
                reportesmaletas.IDViaje = AuxViaje.IDViaje;
                reportesmaletas.FechaV = AuxViaje.FechaV;
                reportesmaletas.HoraV = AuxViaje.HoraV;
                reportesmaletas.IDChofer = "";
                reportesmaletas.observacion = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LlenarCombo(DateTime fecha)
        {
            try
            {
                if (this.infoTipoReporte == 1)
                {
                    Reportes_Negocio rn = new Reportes_Negocio();
                    this.cmbTurno.DisplayMember = "Observaciones";
                    this.cmbTurno.ValueMember = "id_caja";
                    this.cmbTurno.DataSource = rn.ConsultarCajasXFechaxSucursal(Comun.Conexion, fecha, Estadisticos);
                }
                else if (this.infoTipoReporte == 3)
                {
                    Caja caja = new Caja(Comun.Conexion);
                    caja.listaCaja = new List<Caja>();
                    Caja_Negocio caja_Negocio = new Caja_Negocio();
                    caja_Negocio.CargarComboCajasOcupadas(Comun.Conexion, ref caja);
                    this.cmbTurno.DataSource = caja.listaCaja;
                    this.cmbTurno.ValueMember = "id_cajaCat";
                    this.cmbTurno.DisplayMember = "cajaCatCompleto";

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void TxtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Estadisticos == false)
                {
                    if (Convert.ToDateTime(TxtFechaInicio.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.AddDays(-30).ToShortDateString()))
                    {
                        MessageBox.Show("No puedes buscar a una fecha menor a " + DateTime.Now.AddDays(30).ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtFechaInicio.Value = DateTime.Now;
                    }
                }
                this.LlenarCombo(this.TxtFechaInicio.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtFechaFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Estadisticos == false)
                {
                    if (Convert.ToDateTime(TxtFechaFin.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.AddDays(-30).ToShortDateString()))
                    {
                        MessageBox.Show("No puedes buscar a una fecha menor a " + DateTime.Now.AddDays(30).ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtFechaFin.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_VerTodos_Click(object sender, EventArgs e)
        {
            try
            {
                if (verTodo == 0)
                {
                    btn_VerTodos.Text = "Disponibles";
                    btn_VerTodos.Image = Properties.Resources.CardBron;
                    verTodo = 1;
                    CargarReporte();
                }
                else
                {
                    btn_VerTodos.Text = "Ver Todos";
                    btn_VerTodos.Image = Properties.Resources.CardGold;
                    verTodo = 0;
                    CargarReporte();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
