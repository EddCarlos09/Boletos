using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.LibControls.WinForms;
using CreativaSL.WinForm.VentaBoletos.Clientes;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;
namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmHomeV2 : MaterialForm
    {
        public frmHomeV2()
        {
            InitializeComponent();
            loadMaterial(this);
            //this.Inicializar();
        }

        private void frmHomeV2_Load(object sender, EventArgs e)
        {

        }
        Validaciones Val;

        DateTimePicker oDateTimePicker;
        int Columna_DataTimePicker = 1;
        BoletosGrupal boletoGrupal = new BoletosGrupal();


        public bool Salir
        {
            get { return _salir; }
            set { _salir = value; }
        }
        public bool Exception
        {
            get { return _Exception; }
            set { _Exception = value; }
        }

        #region Variables
        private string IDViajeDiseñoAux = "";
        private int numPisoActual = 1;
        private int numPisoAux = 0;
        private DataTable NuevaVenta;
        private bool _salir = false;
        private Home homes = new Home();
        private bool _Exception = true;
        private DateTime FechaHoraSistema = DateTime.Now;
        private int SegundosTiempoVenta = 0;
        private int SegundosTiempoLiberacionBoletos = 0;
        private DateTime TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
        private bool _stopTiempoVenta = false;


        V2Cliente ClienteActual;
        //Cliente ClienteActual;

        #endregion

        //private void Inicializar()
        //{
        //    try
        //    {
        //        ClienteActual = new V2Cliente();
        //        homes.IDBoleto = "";
        //        homes.IDViaje = "";
        //        homes.IDTarifa = "";
        //        homes.IDTipoTarifa = 0;
        //        homes.NumCamion = "";
        //        homes.TipoLinea = "";
        //        homes.Asiento = 0;
        //        homes.DescripcionIndice = "";
        //        homes.IDCamionDiseño = "";
        //        homes.FechaSalida = DateTime.Now;
        //        homes.HoraSalida = "";
        //        homes.FechaSalidaV = DateTime.Now;
        //        homes.HoraSalidaV = "";
        //        homes.FechaLLegadaV = DateTime.Now;
        //        homes.HoraLlegadaV = "";
        //        homes.Origen = "";
        //        homes.Destino = "";
        //        homes.Precio = 0F;
        //        homes.Descuentos = 0F;
        //        homes.TipoDescuento = 0;
        //        homes.Nombre = "";
        //        homes.precioNormal1 = 0F;
        //        homes.precioInfantil1 = 0F;
        //        homes.precioTerceraEdad1 = 0F;
        //        homes.precioEspecial1 = 0F;
        //        homes.precioNormal2 = 0F;
        //        homes.precioInfantil2 = 0F;
        //        homes.precioTerceraEdad2 = 0F;
        //        homes.precioEspecial2 = 0F;
        //        homes.IDStatus = 0;
        //        homes.Anticipo = 0F;
        //        homes.IDBoletoTransferencia = "";

        //        homes.TipoTerminal = 0;
        //        homes.NumAsientos = 0;
        //        homes.NumAsientosDiponibles = 0;
        //        homes.NumAsientosApartado = 0;
        //        homes.Recorrido = "";

        //        homes.OrdenOrigen = 0;
        //        homes.OrdenDestino = 0;

        //        homes.PagoExtra = 0F;

        //        homes.NumeroTelefono = "";

        //        this.EstablecerPropiedadesGridViewViajes();
        //        this.EstablecerPropiedadesGridViewVentaBoletos();
        //        this.CargarCombos();

        //        // this.Txt_NumAsientos.Text = this.homes.NumAsientos.ToString();
        //        this.Txt_NumAsientosDisponibles.Text = this.homes.NumAsientosDiponibles.ToString();
        //        this.Txt_NumAsientosApartados.Text = this.homes.NumAsientosApartado.ToString();
        //        this.Txt_Recorrido.Text = this.homes.Recorrido.ToString();

        //        this.NuevaVenta = new DataTable();
        //        this.NuevaVenta.Columns.Add("IDBoleto", typeof(string));
        //        this.NuevaVenta.Columns.Add("IDViaje", typeof(string));
        //        this.NuevaVenta.Columns.Add("FechaSalida", typeof(DateTime));
        //        this.NuevaVenta.Columns.Add("HoraSalida", typeof(string));
        //        this.NuevaVenta.Columns.Add("IDTarifa", typeof(string));
        //        this.NuevaVenta.Columns.Add("IDTipoTarifa", typeof(int));
        //        this.NuevaVenta.Columns.Add("NumCamion", typeof(string));
        //        this.NuevaVenta.Columns.Add("TipoLinea", typeof(string));
        //        this.NuevaVenta.Columns.Add("Asiento", typeof(int));
        //        this.NuevaVenta.Columns.Add("DescripcionIndice", typeof(string));
        //        this.NuevaVenta.Columns.Add("IDCamionDiseño", typeof(string));
        //        this.NuevaVenta.Columns.Add("FechaSalidaV", typeof(DateTime));
        //        this.NuevaVenta.Columns.Add("FechaSalidaV2", typeof(string));
        //        this.NuevaVenta.Columns.Add("HoraSalidaV", typeof(string));
        //        this.NuevaVenta.Columns.Add("FechaLLegadaV", typeof(DateTime));
        //        this.NuevaVenta.Columns.Add("FechaLLegadaV2", typeof(string));
        //        this.NuevaVenta.Columns.Add("HoraLLegadaV", typeof(string));
        //        this.NuevaVenta.Columns.Add("Origen", typeof(string));
        //        this.NuevaVenta.Columns.Add("Destino", typeof(string));
        //        this.NuevaVenta.Columns.Add("Precio", typeof(float));
        //        this.NuevaVenta.Columns.Add("Descuentos", typeof(float));
        //        this.NuevaVenta.Columns.Add("TipoDescuento", typeof(int));
        //        this.NuevaVenta.Columns.Add("Nombre", typeof(string));
        //        this.NuevaVenta.Columns.Add("FechaNacimiento", typeof(DateTime));
        //        this.NuevaVenta.Columns.Add("NumeroTelefono", typeof(string));
        //        this.NuevaVenta.Columns.Add("IDStatus", typeof(int));
        //        this.NuevaVenta.Columns.Add("Anticipo", typeof(float));
        //        this.NuevaVenta.Columns.Add("IDBoletoTransferencia", typeof(string));
        //        this.NuevaVenta.Columns.Add("PagoExtra", typeof(float));
        //        this.NuevaVenta.Columns.Add("IDTipoCamion", typeof(string));
        //        this.NuevaVenta.Columns.Add("codigoTarjeta", typeof(string));

        //        //SERGIO
        //        this.GridViewViajes.SelectionChanged -= new System.EventHandler(this.GridViewViajes_SelectionChanged);
        //        this.GridViewViajes.DataSource = homes.Salidas;
        //        this.GridViewViajes.SelectionChanged += new System.EventHandler(this.GridViewViajes_SelectionChanged);
        //        if (this.GridViewViajes.Rows.Count > 0)
        //        {
        //            this.GridViewViajes.CurrentCell = this.GridViewViajes.Rows[0].Cells[0];
        //            this.GridViewViajes.Rows[0].Selected = true;
        //        }
        //        GridViewViajes_SelectionChanged(this.GridViewViajes, new DataGridViewCellEventArgs(0, 0));


        //        this.GridViewVentaBoletos.DataSource = homes.VentaBoletos;


        //        if (Comun.Id_Tu == 1)
        //        {
        //            this.btnReportes.Enabled = false;
        //            this.btnAdministrador.Enabled = false;
        //        }
        //        else if (Comun.Id_Tu == 2)
        //        {
        //            this.btnAdministrador.Enabled = false;
        //            this.btnReportes.Enabled = false;
        //            this.btnConfiguracion.Enabled = false;
        //        }

        //        boletoGrupal.nombre = "";
        //        boletoGrupal.fechaNacimiento = DateTime.Now;
        //        boletoGrupal.numeroTelefono = "";
        //        boletoGrupal.ventaGrupal = false;
        //        boletoGrupal.id_viajeGrupal = "";
        //        boletoGrupal.fechaViajeGrupal = DateTime.Now.AddDays(-1.00);
        //        boletoGrupal.horaViajeGrupal = "";
        //        checkBoxVentaGrupal.Checked = false;
        //        dtmFechaSalida.Value = DateTime.Now;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSeleccionado = materialTabControl1.SelectedIndex;


            switch (indexSeleccionado)
            {
                case 1:
                    frmVentasV2 frmv1 = new frmVentasV2();
                    frmv1.ShowDialog();
                    frmv1.Dispose();
                    materialTabControl1.SelectedIndex = 0;
                    materialTabControl1.Refresh(); 



                    break;
                case 2:
                    frmVentasGrupalV2 frmvg2 = new frmVentasGrupalV2();
                    frmvg2.ShowDialog();
                    frmvg2.Dispose();
                    break;
                case 3:
                    frmApartadosV2 frma3 = new frmApartadosV2();
                    frma3.ShowDialog();
                    frma3.Dispose();
                    break;
                case 4:
                    frm_v3_Cliente frmcl4 = new frm_v3_Cliente();
                    frmcl4.ShowDialog();
                    frmcl4.Dispose();
                    break;
                case 5:
                    //Button_Creativa btn5 = (Button_Creativa)sender;
                    //MenuStripCaja.Show(btn5, btn5.Height, btn5.Location.Y + (btn5.Width / 4));
                    //MenuStripCaja.Focus();
                    break;
                case 6:
                    frmMaletasV2 frma6 = new frmMaletasV2();
                    frma6.ShowDialog();
                    frma6.Dispose();
                    break;
                case 7:
                    FormAdministrador frma7 = new FormAdministrador();
                    frma7.ShowDialog();
                    frma7.Dispose();
                    break;
                case 8:
                    if (Comun.Id_Tu == 4)
                    {
                        frmReportesV2 frmReportesVista8 = new frmReportesV2();
                        frmReportesVista8.ShowDialog();
                    }
                    else
                    {
                        frmReportesMenuV2 frmr8 = new frmReportesMenuV2();
                        frmr8.ShowDialog();
                    }
                    break;
                case 9:
                    frmConfiguracionV2 frmC9 = new frmConfiguracionV2();
                    frmC9.ShowDialog();
                    frmC9.Dispose();
                    break;
                case 10:
                    frmAsistenciaPasajerosV2 frmC10 = new frmAsistenciaPasajerosV2();
                    frmC10.ShowDialog();
                    frmC10.Dispose();
                    break;
                case 11:
                    this.Close();
                    break;
                default:
                    // Código a ejecutar si el índice no coincide con ninguno de los casos anteriores
                    break;
            }

        }

        private void dtmFechaSalida_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                //if (Convert.ToDateTime(dtmFechaSalida.Value.ToShortDateString()) > Convert.ToDateTime(DateTime.Now.AddDays(30).ToShortDateString()))
                //{
                //    MessageBox.Show("No puedes buscar a una fecha mayor a " + DateTime.Now.AddDays(30).ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    dtmFechaSalida.Value = DateTime.Now;
                //}
                if (Convert.ToDateTime(dtmFechaSalida.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    MessageBox.Show("No puedes buscar a una fecha menor a " + DateTime.Now.ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtmFechaSalida.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
