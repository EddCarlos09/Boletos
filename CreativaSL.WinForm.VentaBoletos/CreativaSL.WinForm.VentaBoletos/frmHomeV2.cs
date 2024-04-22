using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
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
        #region Constructor
        public frmHomeV2()
        {
            try
            {
                InitializeComponent();
                this.Inicializar();
                loadMaterial(this);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion


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
        //Nuevo
        private DateTimePicker currentDateTimePicker;

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

        DataTable lstAuxDatosViajes = new DataTable();
        List<string> dbFieldList = new List<string>();

        DataTable lstAuxDatosVentaBoletos = new DataTable();
        List<string> dbFieldList2 = new List<string>();


        V2Cliente ClienteActual;
        //Cliente ClienteActual;

        #endregion

        #region Metodos Generales

        //TABS 
        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSeleccionado = materialTabControl1.SelectedIndex;


            switch (indexSeleccionado)
            {
                case 1:
                    try
                    {
                        if (this.Venta() == false)
                        {
                            this.Inicializar();
                            frmVentasV2 frmv = new frmVentasV2();
                            TabPage tabPage = materialTabControl1.TabPages[1]; // Supongamos que el tab deseado está en la posición 0
                            frmv.TopLevel = false;
                            tabPage.Controls.Add(frmv);
                            frmv.FormBorderStyle = FormBorderStyle.None;
                            frmv.Dock = DockStyle.Fill;
                            frmv.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    break;
                case 2:
                    try
                    {
                        if (this.Venta() == false)
                        {

                            this.Inicializar();
                            frmVentasGrupalV2 frmvg = new frmVentasGrupalV2();
                            TabPage tabPage = materialTabControl1.TabPages[2]; // Supongamos que el tab deseado está en la posición 0
                            frmvg.TopLevel = false;
                            tabPage.Controls.Add(frmvg);
                            frmvg.FormBorderStyle = FormBorderStyle.None;
                            frmvg.Dock = DockStyle.Fill;
                            frmvg.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 3:
                    if (this.Venta() == false)
                    { 

                        this.Inicializar();
                        frmApartadosV2 frma = new frmApartadosV2();
                        TabPage tabPage = materialTabControl1.TabPages[3]; // Supongamos que el tab deseado está en la posición 0
                        frma.TopLevel = false;
                        tabPage.Controls.Add(frma);
                        frma.FormBorderStyle = FormBorderStyle.None;
                        frma.Dock = DockStyle.Fill;
                        frma.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 4:
                    try
                    {
                        if (this.Venta() == false)
                        {
                            this.Inicializar();
                            frm_v3_Cliente frmcl = new frm_v3_Cliente();
                            TabPage tabPage = materialTabControl1.TabPages[4]; // Supongamos que el tab deseado está en la posición 0
                            frmcl.TopLevel = false;
                            tabPage.Controls.Add(frmcl);
                            frmcl.FormBorderStyle = FormBorderStyle.None;
                            frmcl.Dock = DockStyle.Fill;
                            frmcl.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 5:
                    try
                    {
                        if (this.Venta() == false)
                        {
                            //this.Inicializar();
                            //Button_Creativa btn = (Button_Creativa)sender;
                            //MenuStripCaja.Show(btn, btn.Height, btn.Location.Y + (btn.Width / 4));
                            //MenuStripCaja.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 6:
                    try
                    {
                        if (this.Venta() == false)
                        {
                            this.Inicializar();
                            frmMaletasV2 frma = new frmMaletasV2();
                            TabPage tabPage = materialTabControl1.TabPages[6]; // Supongamos que el tab deseado está en la posición 0
                            frma.TopLevel = false;
                            tabPage.Controls.Add(frma);
                            frma.FormBorderStyle = FormBorderStyle.None;
                            frma.Dock = DockStyle.Fill;
                            frma.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 7:
                     try
                     {
                        if (this.Venta() == false)
                        {
                            this.Inicializar();
                            //frmAdministrador frma = new frmAdministrador();
                            FormAdministrador frma = new FormAdministrador();
                            frma.ShowDialog();
                            frma.Dispose();
                            this.Inicializar();
                        }
                        else
                        {
                            MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                     }
                     catch (Exception ex)
                     {
                        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                    break;
                case 8:
                    try
                    {
                        if (this.Venta() == false)
                        {
                            this.Inicializar();
                            if (Comun.Id_Tu == 4)
                            {
                                frmReportesV2 frmReportesVista = new frmReportesV2(15);
                                TabPage tabPage = materialTabControl1.TabPages[8]; // Supongamos que el tab deseado está en la posición 0
                                frmReportesVista.TopLevel = false;
                                tabPage.Controls.Add(frmReportesVista);
                                frmReportesVista.FormBorderStyle = FormBorderStyle.None;
                                frmReportesVista.Dock = DockStyle.Fill;
                                frmReportesVista.Show();
                            }
                            else
                            {
                                frmReportesMenuV2 frmReportesMenuV2 = new frmReportesMenuV2();
                                TabPage tabPage = materialTabControl1.TabPages[8]; // Supongamos que el tab deseado está en la posición 0
                                frmReportesMenuV2.TopLevel = false;
                                tabPage.Controls.Add(frmReportesMenuV2);
                                frmReportesMenuV2.FormBorderStyle = FormBorderStyle.None;
                                frmReportesMenuV2.Dock = DockStyle.Fill;
                                frmReportesMenuV2.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 9:
                    try
                    {
                        if (this.Venta() == false)
                        {
                            frmConfiguracionV2 frmC = new frmConfiguracionV2();
                            TabPage tabPage = materialTabControl1.TabPages[9]; // Supongamos que el tab deseado está en la posición 0
                            frmC.TopLevel = false;
                            tabPage.Controls.Add(frmC);
                            frmC.FormBorderStyle = FormBorderStyle.None;
                            frmC.Dock = DockStyle.Fill;
                            frmC.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 10:
                    try
                    {
                        if (this.Venta() == false)
                        {
                            this.Inicializar();
                            frmAsistenciaPasajerosV2 frmC = new frmAsistenciaPasajerosV2();
                            TabPage tabPage = materialTabControl1.TabPages[10]; // Supongamos que el tab deseado está en la posición 0
                            frmC.TopLevel = false;
                            tabPage.Controls.Add(frmC);
                            frmC.FormBorderStyle = FormBorderStyle.None;
                            frmC.Dock = DockStyle.Fill;
                            frmC.Show();
                            this.Inicializar();
                        }
                        else
                        {
                            MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 11:
                    try
                    {
                        if (this.Venta() == false)
                        {
                            this.Exception = false;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    break;
                default:
                    // Código a ejecutar si el índice no coincide con ninguno de los casos anteriores
                    break;
            }

        }

        private void CargarCombos()
        {
            Home_Negocio home_negocio = new Home_Negocio();
            home_negocio.CargarComboTerminales(Comun.Conexion, ref homes);

            this.cmbComboOrigen.DataSource = this.homes.lista_Origen;
            this.cmbComboOrigen.DisplayMember = "terminal";
            this.cmbComboOrigen.ValueMember = "id_terminal";

            this.cmbComboDestino.DataSource = this.homes.lista_Destino;
            this.cmbComboDestino.DisplayMember = "terminal";
            this.cmbComboDestino.ValueMember = "id_terminal";

        }

        private void Inicializar()
        {
            try
            {
                ClienteActual = new V2Cliente();
                homes.IDBoleto = "";
                homes.IDViaje = "";
                homes.IDTarifa = "";
                homes.IDTipoTarifa = 0;
                homes.NumCamion = "";
                homes.TipoLinea = "";
                homes.Asiento = 0;
                homes.DescripcionIndice = "";
                homes.IDCamionDiseño = "";
                homes.FechaSalida = DateTime.Now;
                homes.HoraSalida = "";
                homes.FechaSalidaV = DateTime.Now;
                homes.HoraSalidaV = "";
                homes.FechaLLegadaV = DateTime.Now;
                homes.HoraLlegadaV = "";
                homes.Origen = "";
                homes.Destino = "";
                homes.Precio = 0F;
                homes.Descuentos = 0F;
                homes.TipoDescuento = 0;
                homes.Nombre = "";
                homes.precioNormal1 = 0F;
                homes.precioInfantil1 = 0F;
                homes.precioTerceraEdad1 = 0F;
                homes.precioEspecial1 = 0F;
                homes.precioNormal2 = 0F;
                homes.precioInfantil2 = 0F;
                homes.precioTerceraEdad2 = 0F;
                homes.precioEspecial2 = 0F;
                homes.IDStatus = 0;
                homes.Anticipo = 0F;
                homes.IDBoletoTransferencia = "";

                homes.TipoTerminal = 0;
                homes.NumAsientos = 0;
                homes.NumAsientosDiponibles = 0;
                homes.NumAsientosApartado = 0;
                homes.Recorrido = "";

                homes.OrdenOrigen = 0;
                homes.OrdenDestino = 0;

                homes.PagoExtra = 0F;

                homes.NumeroTelefono = "";

                this.EstablecerPropiedadesGridViewViajes();
                this.EstablecerPropiedadesGridViewVentaBoletos();
                this.CargarCombos();

                // this.Txt_NumAsientos.Text = this.homes.NumAsientos.ToString();
                this.Txt_NumAsientosDisponibles.Text = this.homes.NumAsientosDiponibles.ToString();
                this.Txt_NumAsientosApartados.Text = this.homes.NumAsientosApartado.ToString();
                this.Txt_Recorrido.Text = this.homes.Recorrido.ToString();

                this.NuevaVenta = new DataTable();
                this.NuevaVenta.Columns.Add("IDBoleto", typeof(string));
                this.NuevaVenta.Columns.Add("IDViaje", typeof(string));
                this.NuevaVenta.Columns.Add("FechaSalida", typeof(DateTime));
                this.NuevaVenta.Columns.Add("HoraSalida", typeof(string));
                this.NuevaVenta.Columns.Add("IDTarifa", typeof(string));
                this.NuevaVenta.Columns.Add("IDTipoTarifa", typeof(int));
                this.NuevaVenta.Columns.Add("NumCamion", typeof(string));
                this.NuevaVenta.Columns.Add("TipoLinea", typeof(string));
                this.NuevaVenta.Columns.Add("Asiento", typeof(int));
                this.NuevaVenta.Columns.Add("DescripcionIndice", typeof(string));
                this.NuevaVenta.Columns.Add("IDCamionDiseño", typeof(string));
                this.NuevaVenta.Columns.Add("FechaSalidaV", typeof(DateTime));
                this.NuevaVenta.Columns.Add("FechaSalidaV2", typeof(string));
                this.NuevaVenta.Columns.Add("HoraSalidaV", typeof(string));
                this.NuevaVenta.Columns.Add("FechaLLegadaV", typeof(DateTime));
                this.NuevaVenta.Columns.Add("FechaLLegadaV2", typeof(string));
                this.NuevaVenta.Columns.Add("HoraLLegadaV", typeof(string));
                this.NuevaVenta.Columns.Add("Origen", typeof(string));
                this.NuevaVenta.Columns.Add("Destino", typeof(string));
                this.NuevaVenta.Columns.Add("Precio", typeof(float));
                this.NuevaVenta.Columns.Add("Descuentos", typeof(float));
                this.NuevaVenta.Columns.Add("TipoDescuento", typeof(int));
                this.NuevaVenta.Columns.Add("Nombre", typeof(string));
                this.NuevaVenta.Columns.Add("FechaNacimiento", typeof(DateTime));
                this.NuevaVenta.Columns.Add("NumeroTelefono", typeof(string));
                this.NuevaVenta.Columns.Add("IDStatus", typeof(int));
                this.NuevaVenta.Columns.Add("Anticipo", typeof(float));
                this.NuevaVenta.Columns.Add("IDBoletoTransferencia", typeof(string));
                this.NuevaVenta.Columns.Add("PagoExtra", typeof(float));
                this.NuevaVenta.Columns.Add("IDTipoCamion", typeof(string));
                this.NuevaVenta.Columns.Add("codigoTarjeta", typeof(string));

                //SERGIO
                this.GridViewViajes.SelectedIndexChanged -= new System.EventHandler(this.GridViewViajes_SelectionChanged);
                //this.GridViewViajes.SelectionChanged -= new System.EventHandler(this.GridViewViajes_SelectionChanged);
                //this.GridViewViajes.DataSource = homes.Salidas;
                this.GridViewViajes.SelectedIndexChanged += new System.EventHandler(this.GridViewViajes_SelectionChanged);
                //this.GridViewViajes.SelectionChanged += new System.EventHandler(this.GridViewViajes_SelectionChanged);
                if (this.GridViewViajes.Items.Count > 0)
                //if (this.GridViewViajes.Rows.Count > 0)
                {
                    this.GridViewViajes.Items[0].Selected = true; // Selecciona el primer elemento
                    this.GridViewViajes.Select();
                    //this.GridViewViajes.CurrentCell = this.GridViewViajes.Items[0].SubItems[0];
                    //this.GridViewViajes.CurrentCell = this.GridViewViajes.Rows[0].Cells[0];
                    //this.GridViewViajes.Items[0].Selected = true;
                    //this.GridViewViajes.Rows[0].Selected = true;
                }
                GridViewViajes_SelectionChanged(this.GridViewViajes, new DataGridViewCellEventArgs(0, 0));


                //this.GridViewVentaBoletos.DataSource = homes.VentaBoletos;


                if (Comun.Id_Tu == 1)
                {
                    this.btnReportes.Enabled = false;
                    this.btnAdministrador.Enabled = false;
                }
                else if (Comun.Id_Tu == 2)
                {
                    this.btnAdministrador.Enabled = false;
                    this.btnReportes.Enabled = false;
                    this.btnConfiguracion.Enabled = false;
                }

                boletoGrupal.nombre = "";
                boletoGrupal.fechaNacimiento = DateTime.Now;
                boletoGrupal.numeroTelefono = "";
                boletoGrupal.ventaGrupal = false;
                boletoGrupal.id_viajeGrupal = "";
                boletoGrupal.fechaViajeGrupal = DateTime.Now.AddDays(-1.00);
                boletoGrupal.horaViajeGrupal = "";
                checkBoxVentaGrupal.Checked = false;
                dtmFechaSalida.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarDatosBusqueda()
        {
            try
            {

                //if (dtmFechaSalida.Value > DateTime.Now.AddDays(30))
                //{
                //    MessageBox.Show("No puedes buscar a una fecha mayor a " + DateTime.Now.AddDays(30).ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    dtmFechaSalida.Value = DateTime.Now;
                //    return false;
                //}
                if (this.cmbComboOrigen.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione un Origen", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (this.cmbComboDestino.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione un Destino", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region VentaBoletos
        private void AgregarBoletos(PictureBox PictureBoxAux)
        {
            try
            {
                if (PictureBoxAux.Tag.Equals("1"))
                {
                    List<Item> lst_precios = new List<Item>();
                    if (numPisoActual == 1)
                    {
                        lst_precios.Add(new Item(this.homes.precioNormal1.ToString(), 1));
                        //lst_precios.Add(new Item(this.homes.precioInfantil1.ToString(), 2));
                        //lst_precios.Add(new Item(this.homes.precioTerceraEdad1.ToString(), 3));
                        //lst_precios.Add(new Item(this.homes.precioEspecial1.ToString(), 4));
                    }
                    else if (numPisoActual == 2)
                    {
                        lst_precios.Add(new Item(this.homes.precioNormal2.ToString(), 1));
                        //lst_precios.Add(new Item(this.homes.precioInfantil2.ToString(), 2));
                        //lst_precios.Add(new Item(this.homes.precioTerceraEdad2.ToString(), 3));
                        //lst_precios.Add(new Item(this.homes.precioEspecial2.ToString(), 4));
                    }

                    frmPrecioV2 frmp = new frmPrecioV2(lst_precios, ClienteActual);
                    frmp.ShowDialog();
                    if (frmp.getBanVenta())
                    {
                        homes.Asiento = 0;
                        string Verificador = "";
                        homes.DescripcionIndice = PictureBoxAux.Name;
                        TextBox TextBoxAux = (TextBox)this.FindControl(this, "pasilloasiento" + homes.DescripcionIndice.Replace("asiento", ""));
                        homes.Asiento = Convert.ToInt32(TextBoxAux.Text.Replace(" TV", ""));
                        if (checkBoxVentaGrupal.Checked == true)
                        {
                            if (boletoGrupal.id_viajeGrupal == "")
                            {
                                boletoGrupal.id_viajeGrupal = homes.IDViaje;
                                boletoGrupal.fechaViajeGrupal = homes.FechaSalida;
                                boletoGrupal.horaViajeGrupal = homes.HoraSalida;
                            }
                            if (NuevaVenta.Rows.Count > 0)
                                if ((boletoGrupal.id_viajeGrupal != "") && (boletoGrupal.fechaViajeGrupal != new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(-1.00)) && (boletoGrupal.horaViajeGrupal != ""))
                                    if ((boletoGrupal.id_viajeGrupal != homes.IDViaje) || (boletoGrupal.fechaViajeGrupal.ToShortDateString() != homes.FechaSalida.ToShortDateString()) || (boletoGrupal.horaViajeGrupal != homes.HoraSalida))
                                    {
                                        MessageBox.Show("En la venta grupal no se pueden vender boletos de diferentes camiones", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        return;
                                    }
                        }
                        else
                        {
                            boletoGrupal.id_viajeGrupal = "";
                            boletoGrupal.fechaViajeGrupal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(-1.00);
                            boletoGrupal.horaViajeGrupal = "";
                        }


                        Home_Negocio home = new Home_Negocio();
                        //if (ClienteActual == null)
                        ClienteActual = frmp.DatosCliente;
                        home.ApartarAsiento(Comun.Conexion, homes.IDViaje, homes.Asiento, homes.IDCamionDiseño, homes.FechaSalida, homes.HoraSalida, homes.OrdenOrigen, homes.OrdenDestino, ref Verificador);

                        if (!Verificador.Equals("1"))
                        {
                            PictureBoxAux.Tag = "0";
                            PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.espera;
                            homes.IDBoleto = Verificador;
                            homes.IDTipoTarifa = frmp.getTipoTarifa();
                            homes.Precio = frmp.getPrecio();
                            homes.IDStatus = 1;
                            homes.Descuentos = frmp.getDescuento();
                            homes.FechaNacimiento = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            if (homes.Descuentos > 0)
                                homes.TipoDescuento = 1;
                            else
                                homes.TipoDescuento = 0;

                            homes.Nombre = ClienteActual != null ? ClienteActual.Nombre : string.Empty;
                            homes.codigoTarjeta = ClienteActual != null ? ClienteActual.CodigoTarjeta : string.Empty;

                            this.AgregarDataTableNuevaVenta(new Object[] {
                                homes.IDBoleto,
                                homes.IDViaje,
                                homes.FechaSalida,
                                homes.HoraSalida,
                                homes.IDTarifa,
                                homes.IDTipoTarifa,
                                homes.NumCamion,
                                homes.TipoLinea,
                                homes.Asiento,
                                homes.DescripcionIndice,
                                homes.IDCamionDiseño,
                                homes.FechaSalidaV,
                                homes.FechaSalidaV.ToShortDateString(),
                                homes.HoraSalidaV,
                                homes.FechaLLegadaV,
                                homes.FechaLLegadaV.ToShortDateString(),
                                homes.HoraLlegadaV,
                                homes.Origen,
                                homes.Destino,
                                homes.Precio,
                                homes.Descuentos,
                                homes.TipoDescuento,
                                homes.Nombre,
                                homes.FechaNacimiento,
                                homes.NumeroTelefono,
                                homes.IDStatus,
                                homes.Anticipo,
                                homes.IDBoletoTransferencia,
                                homes.PagoExtra,
                                homes.id_tipoCamion,
                                homes.codigoTarjeta
                            });

                            if (checkBoxVentaGrupal.Checked == true)
                            {
                                foreach (DataRow aux in this.NuevaVenta.Rows)
                                {
                                    aux["Nombre"] = boletoGrupal.nombre;
                                    aux["NumeroTelefono"] = boletoGrupal.numeroTelefono;
                                    aux["FechaNacimiento"] = boletoGrupal.fechaNacimiento.ToString("dd/MM/yyyy");
                                }
                            }
                            this.CargarGridViewVentaBoletos();
                            homes.IDStatus = 0;
                        }
                        else
                        {
                            PictureBoxAux.Tag = "0";
                            PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.espera;
                            MessageBox.Show("No Puedes Apartar Este Boleto, Boleto Apartado", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    frmp.Dispose();
                }
                else
                {
                    if (homes.IDViaje.Length != 0)
                    {
                        //this.toolTip.Active = true;
                        //TextBox TextBoxAux = (TextBox)this.FindControl(this, "pasilloasiento" + PictureBoxAux.Name.Replace("asiento", ""));
                        //int auxAsiento = Convert.ToInt32(TextBoxAux.Text.Replace(" TV", ""));

                        //foreach (DataRow row in this.homes.DatosCamion.Rows)
                        //{
                        //    if (Convert.ToInt32(row["indice"]) == auxAsiento)
                        //    {
                        //        if (Convert.ToInt32(row["idStatus"]) == 2)
                        //        {
                        //            if (Convert.ToSingle(row["pago"]) == 0.0)
                        //                toolTip.SetToolTip(PictureBoxAux, "Nombre: " + Convert.ToString(row["nombre"]) + "\n"
                        //                 + "Estado: Apartado" + "\n"
                        //                 + "Precio: " + Convert.ToSingle(row["costo"]) + "\n"
                        //                 + "Pago: " + Convert.ToSingle(row["pago"])
                        //                 );
                        //            else if (Convert.ToSingle(row["pago"]) > 0.0)
                        //                toolTip.SetToolTip(PictureBoxAux, "Nombre: " + Convert.ToString(row["nombre"]) + "\n"
                        //                 + "Estado: Anticipo" + "\n"
                        //                 + "Precio: " + Convert.ToSingle(row["costo"]) + "\n"
                        //                 + "Pago: " + Convert.ToSingle(row["pago"])
                        //                 );
                        //        }
                        //        else if (Convert.ToInt32(row["idStatus"]) == 3)
                        //        {
                        //            toolTip.SetToolTip(PictureBoxAux, "Nombre: " + Convert.ToString(row["nombre"]) + "\n"
                        //             + "Estado: Vendido" + "\n"
                        //             + "Precio: " + Convert.ToSingle(row["costo"]) + "\n"
                        //             + "Pago: " + Convert.ToSingle(row["pago"])
                        //             );
                        //        }
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CheckViajeVentaGrupal()
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
        }
        private void CalcularTotales(VentaBoleto VentaBoletosAux)
        {
            try
            {
                VentaBoletosAux.CantidadDatos = 0;
                VentaBoletosAux.PrecioDatos = 0.0F;
                VentaBoletosAux.ImpuestosDatos = 0.0F;
                VentaBoletosAux.SubtotalDatos = 0.0F;
                VentaBoletosAux.DescuentosDatos = 0.0F;
                VentaBoletosAux.AnticipoDatos = 0.0F;
                VentaBoletosAux.TotalDatos = 0.0F;
                VentaBoletosAux.CobroExtraDatos = 0.0F;


                VentaBoletosAux.CantidadDatos = 0;
                VentaBoletosAux.PrecioDatos = 0.0F;
                VentaBoletosAux.ImpuestosDatos = 0.0F;
                VentaBoletosAux.SubtotalDatos = 0.0F;
                VentaBoletosAux.DescuentosDatos = 0.0F;
                VentaBoletosAux.AnticipoDatos = 0.0F;
                VentaBoletosAux.TotalDatos = 0.0F;
                VentaBoletosAux.CobroExtraDatos = 0.0F;
                VentaBoletosAux.NuevoMonedero = 0.0F;

                foreach (DataRow row in this.NuevaVenta.Rows)
                {
                    VentaBoletosAux.CantidadDatos = VentaBoletosAux.CantidadDatos + 1;
                    VentaBoletosAux.PrecioDatos = Convert.ToSingle(row["Precio"]) + VentaBoletosAux.PrecioDatos;
                    VentaBoletosAux.ImpuestosDatos = 0 + VentaBoletosAux.ImpuestosDatos;
                    VentaBoletosAux.SubtotalDatos = Convert.ToSingle(row["Precio"]) + VentaBoletosAux.SubtotalDatos;
                    VentaBoletosAux.DescuentosDatos = Convert.ToSingle(row["Descuentos"]) + VentaBoletosAux.DescuentosDatos;
                    VentaBoletosAux.AnticipoDatos = Convert.ToSingle(row["Anticipo"]) + VentaBoletosAux.AnticipoDatos;
                    VentaBoletosAux.CobroExtraDatos = Convert.ToSingle(row["PagoExtra"]) + VentaBoletosAux.CobroExtraDatos;
                    VentaBoletosAux.NuevoMonedero = VentaBoletosAux.NuevoMonedero + (((Convert.ToSingle(row["Precio"]) - Convert.ToSingle(row["Descuentos"])) + (Convert.ToSingle(row["PagoExtra"]))) * Comun.porcentaje_puntos);
                }
                VentaBoletosAux.TotalDatos = VentaBoletosAux.SubtotalDatos - VentaBoletosAux.DescuentosDatos + VentaBoletosAux.CobroExtraDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarNombreBoletos()
        {
            try
            {
                bool Ban = true;
                foreach (DataRow row in this.NuevaVenta.Rows)
                {
                    if (row["Nombre"].ToString().Length == 0)
                        Ban = false;
                }
                return Ban;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AgregarDataTableNuevaVenta(Object[] Datos)
        {
            try
            {
                this.NuevaVenta.Rows.Add(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarDataTableNuevaVenta(string descripcion)
        {
            try
            {
                foreach (DataRow row in NuevaVenta.Rows)
                {
                    if (row["descripcion"].ToString().Equals(descripcion))
                    {
                        this.NuevaVenta.Rows.Remove(row);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool Venta()
        {
            try
            {
                if (GridViewVentaBoletos.Items.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion



        #region Eventos
        #region Botones
        private void Boleto_Click(object sender, EventArgs e)
        {
            try
            {
                this.AgregarBoletos((PictureBox)sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Maletas_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    frmMaletas frma = new frmMaletas();
                    frma.ShowDialog();
                    frma.Dispose();
                    this.Inicializar();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    //frmAdministrador frma = new frmAdministrador();
                    FormAdministrador frma = new FormAdministrador();
                    frma.ShowDialog();
                    frma.Dispose();
                    this.Inicializar();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Exception = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    frmVentas frmv = new frmVentas();
                    frmv.ShowDialog();
                    frmv.Dispose();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVentasGrupal_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    frmVentasGrupal frmvg = new frmVentasGrupal();
                    frmvg.ShowDialog();
                    frmvg.Dispose();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnApartados_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    frmApartados frma = new frmApartados();
                    frma.ShowDialog();
                    frma.Dispose();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    frm_v2_Cliente frmcl = new frm_v2_Cliente();
                    frmcl.ShowDialog();
                    frmcl.Dispose();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void btnReportes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    if (Comun.Id_Tu == 4)
                    {
                        frmReportes frmReportesVista = new frmReportes(15);
                        frmReportesVista.ShowDialog();
                    }
                    else
                    {
                        frmReportesMenu frmr = new frmReportesMenu();
                        frmr.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Vender_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == true)
                {
                    if (checkBoxVentaGrupal.Checked == true)
                    {
                        foreach (DataRow aux in this.NuevaVenta.Rows)
                        {
                            aux["Nombre"] = boletoGrupal.nombre;
                            aux["NumeroTelefono"] = boletoGrupal.numeroTelefono;
                            aux["FechaNacimiento"] = boletoGrupal.fechaNacimiento.ToString("dd/MM/yyyy");
                        }
                        this.CargarGridViewVentaBoletos();
                    }
                    if (ValidarNombreBoletos())
                    {
                        this._stopTiempoVenta = true;
                        VentaBoleto VentaBoletosAux = new VentaBoleto();
                        this.CalcularTotales(VentaBoletosAux);
                        VentaBoletosAux.ventaGrupal = checkBoxVentaGrupal.Checked;
                        VentaBoletosAux.BoletosDetalle = NuevaVenta;
                        VentaBoletosAux.boletosGrupal = boletoGrupal;
                        frmVentaBoletoV2 frmvb = new frmVentaBoletoV2(VentaBoletosAux, ClienteActual);
                        frmvb.ShowDialog();
                        if (frmvb.getBanventa())
                        {
                            this.Inicializar();
                            MessageBox.Show("Venta de boletos efectuada correctamentamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            int Verificador = 1;
                            PictureBox PictureBoxAux;
                            this.SegundosTiempoVenta = 0;
                            Home_Negocio home = new Home_Negocio();
                            home.EliminarAsientosApartados(Comun.Conexion, NuevaVenta, ref Verificador);
                            if (Verificador == 0)
                            {
                                if (this.homes.IDViaje != "")
                                {
                                    foreach (DataRow row in this.NuevaVenta.Rows)
                                    {
                                        PictureBoxAux = (PictureBox)this.FindControl(this, row["DescripcionIndice"].ToString());
                                        PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.disponible;
                                        PictureBoxAux.Tag = "1";
                                    }
                                }
                                this.Inicializar();
                                MessageBox.Show("Boletos liberados por click en cancelacion correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        frmvb.Dispose();
                        this._stopTiempoVenta = false;
                    }
                    else
                    {
                        MessageBox.Show("Escriba el nombre de todos los boletos", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No hay boletos para vender", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {

                int Verificador = 1;
                PictureBox PictureBoxAux;
                if (this.Venta() == false)
                {
                    MessageBox.Show("No hay boletos para liberar", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Home_Negocio home = new Home_Negocio();
                    home.EliminarAsientosApartados(Comun.Conexion, NuevaVenta, ref Verificador);
                    if (Verificador == 0)
                    {
                        this.Inicializar();
                        MessageBox.Show("Boletos liberados correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClienteActual = new V2Cliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_BuscarViajes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarDatosBusqueda())
                {
                    this.CargarGridViewViajes(Convert.ToString(this.cmbComboOrigen.SelectedValue), Convert.ToString(this.cmbComboDestino.SelectedValue), Convert.ToDateTime(this.dtmFechaSalida.Value));
                    this.numPisoActual = 1;
                    this.numPisoAux = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPlantaBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GridViewViajes.Items.Count > 0)
                //if (this.GridViewViajes.Rows.Count > 0)
                {
                    numPisoActual = 1;
                    LlenarDatosCamion(this.homes.DatosCamion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPlantaAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GridViewViajes.Items.Count > 0)
                //if (this.GridViewViajes.Rows.Count > 0)
                {
                    numPisoActual = 2;
                    LlenarDatosCamion(this.homes.DatosCamion);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    frmConfiguracion frmC = new frmConfiguracion();
                    frmC.ShowDialog();
                    frmC.Dispose();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    frmAsistenciaPasajeros frmC = new frmAsistenciaPasajeros();
                    frmC.ShowDialog();
                    frmC.Dispose();
                    this.Inicializar();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_CancelarBuscarViajes_Click(object sender, EventArgs e)
        {
            try
            {
                //SERGIO
                this.GridViewViajes.SelectedIndexChanged -= new System.EventHandler(this.GridViewViajes_SelectionChanged);
                this.GridViewViajes.Items.Clear();
                this.GridViewViajes.SelectedIndexChanged += new System.EventHandler(this.GridViewViajes_SelectionChanged);
                if (this.GridViewViajes.Items.Count > 0)
                {
                    this.GridViewViajes.Items[0].Selected = true; // Selecciona el primer elemento
                    this.GridViewViajes.Select();
                    //this.GridViewViajes.CurrentCell = this.GridViewViajes.Items[0].SubItems[0];
                    //this.GridViewViajes.Items[0].Selected = true;
                }
                GridViewViajes_SelectionChanged(this.GridViewViajes, new DataGridViewCellEventArgs(0, 0));

                this.cmbComboOrigen.SelectedIndex = 0;
                this.cmbComboDestino.SelectedIndex = 0;
                dtmFechaSalida.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void GridViewVentaBoletos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
                tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
                e.Control.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.TextoNumerosPuntoGuionTilde(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GridViewVentaBoletos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void GridViewViajes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // SelectedRows por SelectedItems, Cells por SubItems y Value por Text **************
                if (GridViewViajes.SelectedItems.Count > 0)
                {
                    homes.IDBoleto = "";
                    homes.NombreViaje = this.GridViewViajes.SelectedItems[0].SubItems[17].Text.ToString();
                    homes.IDViaje = this.GridViewViajes.SelectedItems[0].SubItems[23].Text.ToString();
                    homes.FechaSalida = Convert.ToDateTime(this.GridViewViajes.SelectedItems[0].SubItems[33].Text.ToString());
                    homes.HoraSalida = this.GridViewViajes.SelectedItems[0].SubItems[34].Text.ToString();
                    homes.IDTarifa = this.GridViewViajes.SelectedItems[0].SubItems[30].Text.ToString();
                    homes.IDTipoTarifa = 0; //Se Vuelve A Pedir
                    homes.NumCamion = this.GridViewViajes.SelectedItems[0].SubItems[18].Text.ToString();
                    homes.TipoLinea = this.GridViewViajes.SelectedItems[0].SubItems[0].Text.ToString();
                    homes.Asiento = 0; //Se Vuelve A Pedir
                    homes.DescripcionIndice = ""; //Se Vuelve A Pedir
                    homes.IDCamionDiseño = this.GridViewViajes.SelectedItems[0].SubItems[26].Text.ToString();
                    homes.FechaSalidaV = Convert.ToDateTime(this.GridViewViajes.SelectedItems[0].SubItems[3].Text.ToString());
                    homes.HoraSalidaV = this.GridViewViajes.SelectedItems[0].SubItems[4].Text.ToString();
                    homes.FechaLLegadaV = Convert.ToDateTime(this.GridViewViajes.SelectedItems[0].SubItems[6].Text.ToString());
                    homes.HoraLlegadaV = this.GridViewViajes.SelectedItems[0].SubItems[7].Text.ToString();
                    homes.Origen = this.GridViewViajes.SelectedItems[0].SubItems[2].Text.ToString(); ;
                    homes.Destino = this.GridViewViajes.SelectedItems[0].SubItems[5].Text.ToString();
                    homes.Precio = 0F; //Se Vuelve A Pedir
                    homes.Descuentos = 0F; //Se Vuelve A Pedir
                    homes.TipoDescuento = 0; //Se Vuelve A Pedir
                    homes.Nombre = ""; //Se Vuelve A Pedir
                    homes.precioNormal1 = float.Parse(this.GridViewViajes.SelectedItems[0].SubItems[1].Text.ToString(), NumberStyles.Currency);
                    homes.precioInfantil1 = float.Parse(this.GridViewViajes.SelectedItems[0].SubItems[10].Text.ToString(), NumberStyles.Currency);
                    homes.precioTerceraEdad1 = float.Parse(this.GridViewViajes.SelectedItems[0].SubItems[11].Text.ToString(), NumberStyles.Currency);
                    homes.precioEspecial1 = float.Parse(this.GridViewViajes.SelectedItems[0].SubItems[12].Text.ToString(), NumberStyles.Currency);
                    homes.precioNormal2 = float.Parse(this.GridViewViajes.SelectedItems[0].SubItems[13].Text.ToString(), NumberStyles.Currency);
                    homes.precioInfantil2 = float.Parse(this.GridViewViajes.SelectedItems[0].SubItems[14].Text.ToString(), NumberStyles.Currency);
                    homes.precioTerceraEdad2 = float.Parse(this.GridViewViajes.SelectedItems[0].SubItems[15].Text.ToString(), NumberStyles.Currency);
                    homes.precioEspecial2 = float.Parse(this.GridViewViajes.SelectedItems[0].SubItems[16].Text.ToString(), NumberStyles.Currency);
                    homes.IDStatus = 0;
                    homes.Anticipo = 0F;

                    homes.TipoTerminal = Convert.ToInt32(this.GridViewViajes.SelectedItems[0].SubItems[22].Text.ToString());
                    homes.NumAsientos = Convert.ToInt32(this.GridViewViajes.SelectedItems[0].SubItems[35].Text.ToString());
                    homes.NumAsientosDiponibles = 0;
                    homes.NumAsientosApartado = 0;
                    homes.Recorrido = this.GridViewViajes.SelectedItems[0].SubItems[36].Text.ToString().Replace(",", Environment.NewLine);
                    homes.IDBoletoTransferencia = "";
                    homes.OrdenOrigen = Convert.ToInt32(this.GridViewViajes.SelectedItems[0].SubItems[31].Text.ToString());
                    homes.OrdenDestino = Convert.ToInt32(this.GridViewViajes.SelectedItems[0].SubItems[32].Text.ToString());
                    homes.PagoExtra = 0F;

                    this.numPisoActual = 1;
                    this.numPisoAux = 0;

                    homes.id_tipoCamion = this.GridViewViajes.SelectedItems[0].SubItems[37].Text.ToString();

                    homes.numPiso = Convert.ToInt32(this.GridViewViajes.SelectedItems[0].SubItems[20].Text.ToString());
                    if (Convert.ToInt32(this.GridViewViajes.SelectedItems[0].SubItems[20].Text.ToString()) == 1)
                    {
                        this.btnPlantaBaja.Visible = true;
                        this.btnPlantaAlta.Visible = false;
                    }
                    else if (Convert.ToInt32(this.GridViewViajes.SelectedItems[0].SubItems[20].Text.ToString()) == 2)
                    {
                        this.btnPlantaBaja.Visible = true;
                        this.btnPlantaAlta.Visible = true;
                    }

                    Home_Negocio home_negocio = new Home_Negocio();
                    home_negocio.ObtenerDatosCamion(Comun.Conexion, ref homes);
                    LlenarDatosCamion(homes.DatosCamion);

                    //this.Txt_NumAsientos.Text = this.homes.NumAsientos.ToString();
                    this.Txt_NumAsientosDisponibles.Text = this.homes.NumAsientosDiponibles.ToString();
                    this.Txt_NumAsientosApartados.Text = this.homes.NumAsientosApartado.ToString();
                    this.Txt_Recorrido.Text = this.homes.Recorrido.ToString();

                    //this.toolTip.Active = false;
                }
                else
                {
                    homes.IDBoleto = "";
                    homes.IDViaje = "";
                    homes.IDTarifa = "";
                    homes.IDTipoTarifa = 0;
                    homes.NumCamion = "";
                    homes.TipoLinea = "";
                    homes.Asiento = 0;
                    homes.DescripcionIndice = "";
                    homes.IDCamionDiseño = "";
                    homes.FechaSalida = DateTime.Now;
                    homes.HoraSalida = "";
                    homes.FechaSalidaV = DateTime.Now;
                    homes.HoraSalidaV = "";
                    homes.FechaLLegadaV = DateTime.Now;
                    homes.HoraLlegadaV = "";
                    homes.Origen = "";
                    homes.Destino = "";
                    homes.Precio = 0F;
                    homes.Descuentos = 0F;
                    homes.TipoDescuento = 0;
                    homes.Nombre = "";
                    homes.precioNormal1 = 0F;
                    homes.precioInfantil1 = 0F;
                    homes.precioTerceraEdad1 = 0F;
                    homes.precioEspecial1 = 0F;
                    homes.precioNormal2 = 0F;
                    homes.precioInfantil2 = 0F;
                    homes.precioTerceraEdad2 = 0F;
                    homes.precioEspecial2 = 0F;
                    homes.numPiso = 0;
                    homes.IDStatus = 0;
                    homes.Anticipo = 0F;


                    homes.TipoTerminal = 0;
                    homes.NumAsientos = 0;
                    homes.NumAsientosDiponibles = 0;
                    homes.NumAsientosApartado = 0;
                    homes.Recorrido = "";
                    homes.IDBoletoTransferencia = "";
                    homes.OrdenOrigen = 0;
                    homes.OrdenDestino = 0;
                    homes.PagoExtra = 0F;


                    this.numPisoActual = 1;
                    this.numPisoAux = 0;

                    homes.id_tipoCamion = "";

                    homes.PagoExtra = 0F;

                    PictureBox PictureBoxAux;
                    TextBox TextBoxAux;
                    for (int j = 1; j < 66; j++)
                    {
                        TextBoxAux = (TextBox)this.FindControl(this, "pasilloasiento" + j);
                        TextBoxAux.Text = "";
                        TextBoxAux.BackColor = Color.White;
                        PictureBoxAux = (PictureBox)this.FindControl(this, "asiento" + j);
                        PictureBoxAux.Tag = "0";
                        PictureBoxAux.Image = null;
                        PictureBoxAux.BackColor = Color.White;
                    }
                    for (int l = 1; l < 14; l++)
                    {
                        PictureBoxAux = (PictureBox)this.FindControl(this, "puerta" + l);
                        PictureBoxAux.Tag = "0";
                        PictureBoxAux.Image = null;
                        PictureBoxAux.BackColor = Color.White;
                        PictureBoxAux.Visible = false;
                    }

                    homes.NumAsientos = 0;
                    homes.NumAsientosDiponibles = 0;
                    homes.NumAsientosApartado = 0;
                    homes.Recorrido = "";

                    //this.Txt_NumAsientos.Text = this.homes.NumAsientos.ToString();
                    this.Txt_NumAsientosDisponibles.Text = this.homes.NumAsientosDiponibles.ToString();
                    this.Txt_NumAsientosApartados.Text = this.homes.NumAsientosApartado.ToString();
                    this.Txt_Recorrido.Text = this.homes.Recorrido.ToString();

                    //this.toolTip.Active = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GridViewVentaBoletos_CellDoubleClick(object sender, EventArgs e)
        {
            try
            {

                foreach (ListViewItem item in GridViewVentaBoletos.SelectedItems)
                {
                    var ffffffff = item;

                    //if (e.RowIndex != -1)
                    //{
                    //    if (e.ColumnIndex != 8)
                    //    {
                    int Verificador = 1;
                    if (MessageBox.Show("¿Desea eliminar este boleto? ", "Eliminar boleto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Home_Negocio home = new Home_Negocio();
                        DataTable DatosAux = new DataTable();

                        DatosAux.Columns.Add("IDBoleto", typeof(string));
                        DatosAux.Columns.Add("IDViaje", typeof(string));
                        DatosAux.Columns.Add("FechaSalida", typeof(DateTime));
                        DatosAux.Columns.Add("HoraSalida", typeof(string));
                        DatosAux.Columns.Add("IDTarifa", typeof(string));
                        DatosAux.Columns.Add("IDTipoTarifa", typeof(int));
                        DatosAux.Columns.Add("NumCamion", typeof(string));
                        DatosAux.Columns.Add("TipoLinea", typeof(string));
                        DatosAux.Columns.Add("Asiento", typeof(int));
                        DatosAux.Columns.Add("DescripcionIndice", typeof(string));
                        DatosAux.Columns.Add("IDCamionDiseño", typeof(string));
                        DatosAux.Columns.Add("FechaSalidaV", typeof(DateTime));
                        DatosAux.Columns.Add("FechaSalidaV2", typeof(string));
                        DatosAux.Columns.Add("HoraSalidaV", typeof(string));
                        DatosAux.Columns.Add("FechaLLegadaV", typeof(DateTime));
                        DatosAux.Columns.Add("FechaLLegadaV2", typeof(string));
                        DatosAux.Columns.Add("HoraLLegadaV", typeof(string));
                        DatosAux.Columns.Add("Origen", typeof(string));
                        DatosAux.Columns.Add("Destino", typeof(string));
                        DatosAux.Columns.Add("Precio", typeof(float));
                        DatosAux.Columns.Add("Descuentos", typeof(float));
                        DatosAux.Columns.Add("TipoDescuento", typeof(int));
                        DatosAux.Columns.Add("Nombre", typeof(string));
                        DatosAux.Columns.Add("FechaNacimiento", typeof(DateTime));
                        DatosAux.Columns.Add("NumeroTelefono", typeof(string));
                        DatosAux.Columns.Add("IDStatus", typeof(int));
                        DatosAux.Columns.Add("Anticipo", typeof(float));
                        DatosAux.Columns.Add("IDBoletoTransferencia", typeof(string));
                        DatosAux.Columns.Add("PagoExtra", typeof(float));
                        DatosAux.Columns.Add("IDTipoCamion", typeof(string));
                        DatosAux.Columns.Add("codigoTarjeta", typeof(string));

                        var Names = new List<string> { "Nombre 0", "FechaNacimiento 1", "NumeroTelefono 2", "Asiento 3", "TipoLinea 4", "Origen 5", "FechaSalidaV2 6", "HoraSalidaV 7", "Destino 8", "Precio 9", "Descuentos 10",
                            "DescripcionIndice 11", "IDViaje 12", "IDCamionDiseño 13", "NumCamion 14", "TipoLinea 15", "FechaLLegadaV 16", "FechaLLegadaV2 17", "HoraLLegadaV 18", "TipoDescuento 19", "IDBoleto 20",
                            "FechaSalidaV 21", "IDTarifa 22", "IDTipoTarifa 23", "IDStatus 24", "Anticipo 25", "IDBoletoTransferencia 26", "FechaSalida 27", "HoraSalida 28", "PagoExtra 29", "IDTipoCamion 30" };

                        //Rows por Items, Cells por SubItems y Value por Text ***********
                        DatosAux.Rows.Add(

                            item.SubItems[20].Text.ToString(),
                            item.SubItems[12].Text.ToString(),
                            Convert.ToDateTime(item.SubItems[27].Text.ToString()),
                            item.SubItems[28].Text.ToString(),
                            item.SubItems[22].Text.ToString(),
                            Convert.ToInt32(item.SubItems[23].Text.ToString()),
                            item.SubItems[14].Text.ToString(),
                            item.SubItems[4].Text.ToString(),
                            Convert.ToInt32(item.SubItems[3].Text.ToString()),
                            item.SubItems[11].Text.ToString(),
                            item.SubItems[13].Text.ToString(),
                            Convert.ToDateTime(item.SubItems[21].Text.ToString()),
                            item.SubItems[6].Text.ToString(),
                            item.SubItems[7].Text.ToString(),
                            Convert.ToDateTime(item.SubItems[16].Text.ToString()),
                            Convert.ToDateTime(item.SubItems[16].Text.ToString()).ToShortDateString(),
                            item.SubItems[18].Text.ToString(),
                            item.SubItems[5].Text.ToString(),
                            item.SubItems[8].Text.ToString(),
                            Convert.ToSingle(item.SubItems[9].Text.ToString()),
                            Convert.ToSingle(item.SubItems[10].Text.ToString()),
                            Convert.ToInt32(item.SubItems[19].Text.ToString()),
                            item.SubItems[0].Text.ToString(),
                            Convert.ToDateTime(item.SubItems[1].Text.ToString()),
                            item.SubItems[2].Text.ToString(),
                            item.SubItems[24].Text.ToString(),
                            Convert.ToSingle(item.SubItems[25].Text.ToString()),
                            item.SubItems[16].Text.ToString(),
                            Convert.ToSingle(item.SubItems[29].Text.ToString()),
                            item.SubItems[30].Text.ToString()

                            //GridViewVentaBoletos.Items[GridViewVentaBoletos.SelectedItems].SubItems["IDBoleto"].Text.ToString(),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["IDViaje"].Text.ToString(),
                            //Convert.ToDateTime(GridViewVentaBoletos.Items[e.RowIndex].SubItems["FechaSalida"].Text.ToString()),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["HoraSalida"].Text.ToString(),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["IDTarifa"].Text.ToString(),
                            //Convert.ToInt32(GridViewVentaBoletos.Items[e.RowIndex].SubItems["IDTipoTarifa"].Text.ToString()),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["NumCamion"].Text.ToString(),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["TipoLinea"].Text.ToString(),
                            //Convert.ToInt32(GridViewVentaBoletos.Items[e.RowIndex].SubItems["Asiento"].Text.ToString()),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["DescripcionIndice"].Text.ToString(),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["IDCamionDiseño"].Text.ToString(),
                            //Convert.ToDateTime(GridViewVentaBoletos.Items[e.RowIndex].SubItems["FechaSalidaV"].Text.ToString()),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["FechaSalidaV2"].Text.ToString(),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["HoraSalidaV"].Text.ToString(),
                            //Convert.ToDateTime(GridViewVentaBoletos.Items[e.RowIndex].SubItems["FechaLLegadaV"].Text.ToString()),
                            //Convert.ToDateTime(GridViewVentaBoletos.Items[e.RowIndex].SubItems["FechaLLegadaV"].Text.ToString()).ToShortDateString(),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["HoraLLegadaV"].Text.ToString(),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["Origen"].Text.ToString(),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["Destino"].Text.ToString(),
                            //Convert.ToSingle(GridViewVentaBoletos.Items[e.RowIndex].SubItems["Precio"].Text.ToString()),
                            //Convert.ToSingle(GridViewVentaBoletos.Items[e.RowIndex].SubItems["Descuentos"].Text.ToString()),
                            //Convert.ToInt32(GridViewVentaBoletos.Items[e.RowIndex].SubItems["TipoDescuento"].Text.ToString()),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["Nombre"].Text.ToString(),
                            //Convert.ToDateTime(GridViewVentaBoletos.Items[e.RowIndex].SubItems["FechaNacimiento"].Text.ToString()),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["NumeroTelefono"].Text.ToString(),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["IDStatus"].Text.ToString(),
                            //Convert.ToSingle(GridViewVentaBoletos.Items[e.RowIndex].SubItems["Anticipo"].Text.ToString()),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["IDBoletoTransferencia"].Text.ToString(),
                            //Convert.ToSingle(GridViewVentaBoletos.Items[e.RowIndex].SubItems["PagoExtra"].Text.ToString()),
                            //GridViewVentaBoletos.Items[e.RowIndex].SubItems["IDTipoCamion"].Text.ToString()
                            );
                        home.EliminarAsientosApartados(Comun.Conexion, DatosAux, ref Verificador);
                        if (Verificador == 0)
                        {
                            PictureBox PictureBoxAux;
                            PictureBoxAux = (PictureBox)this.FindControl(this, item.SubItems[11].Text.ToString());
                            //PictureBoxAux = (PictureBox)this.FindControl(this, GridViewVentaBoletos.Rows[e.RowIndex].Cells["DescripcionIndice"].Value.ToString());
                            PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.disponible;
                            PictureBoxAux.Tag = "1";
                            GridViewVentaBoletos.Items.Remove(GridViewVentaBoletos.SelectedItems[0]);
                            //GridViewVentaBoletos.Rows.Remove(GridViewVentaBoletos.Rows[e.RowIndex]);
                        }

                    }
                }
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            foreach (ListViewItem item in GridViewVentaBoletos.SelectedItems)
            {
                item.SubItems[1].Text = oDateTimePicker.Text.ToString();
            }
            //GridViewVentaBoletos.CurrentCell.Value = oDateTimePicker.Text.ToString();
        }

        void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            if (oDateTimePicker != null)
                oDateTimePicker.Visible = false;
        }
        private void toolStripMenuItemDepositos_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    frmDepositosRetiros deposito = new frmDepositosRetiros(1);
                    deposito.ShowDialog();
                    deposito.Dispose();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripMenuItemRetirosCajaLLena_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    frmDepositosRetiros retiro = new frmDepositosRetiros(2);
                    retiro.ShowDialog();
                    retiro.Dispose();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripMenuItemRetirosPagos_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    frmDepositosRetiros retiro = new frmDepositosRetiros(3);
                    retiro.ShowDialog();
                    retiro.Dispose();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripMenuItemInformacionDeCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    frmDatosCajaV2 frmdc = new frmDatosCajaV2();
                    frmdc.ShowDialog();
                    frmdc.Dispose();
                }
                else
                {
                    MessageBox.Show("Tienes que liberar los boletos para continuar con otro proceso", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripMenuItemCerrarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    frmCaja_CierreCajaV2 frmcajaCierre = new frmCaja_CierreCajaV2();
                    frmcajaCierre.ShowDialog();
                    frmcajaCierre.Dispose();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion       
        #region GridViewViajes
        private void CargarGridViewViajes(string IDTerminalOrigen, string IDTerminalDestino, DateTime FechaBusqueda)
        {
            try
            {
                Home_Negocio catalogoNegocio = new Home_Negocio();
                Home home = new Home();


                this.GridViewViajes.Items.Clear();

                catalogoNegocio.LlenarGridSalidas(Comun.Conexion, ref home, IDTerminalOrigen, IDTerminalDestino, FechaBusqueda);

                lstAuxDatosViajes = home.Salidas;

                foreach (DataRow fila in lstAuxDatosViajes.Rows)
                {

                    List<string> dataList = new List<string>();
                    for (var i = 0; i < this.dbFieldList.Count; i++)
                    {
                        var field = this.dbFieldList[i];

                        string nombre = fila[field].ToString();
                        dataList.Add(nombre);
                    }

                    string[] valores = dataList.ToArray();

                    ListViewItem item = new ListViewItem(valores);
                    this.GridViewViajes.Items.Add(item);

                }


                //this.GridViewViajes.AutoGenerateColumns = false;
                ////SERGIO
                //this.GridViewViajes.SelectionChanged -= new System.EventHandler(this.GridViewViajes_SelectionChanged);
                //this.GridViewViajes.DataSource = home.Salidas;
                //this.GridViewViajes.SelectionChanged += new System.EventHandler(this.GridViewViajes_SelectionChanged);
                //if (this.GridViewViajes.Items.Count > 0)
                //{
                //    this.GridViewViajes.CurrentCell = this.GridViewViajes.Items[0].Cells[0];
                //    this.GridViewViajes.Items[0].Selected = true;
                //}
                //GridViewViajes_SelectionChanged(this.GridViewViajes, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridViewViajes()
        {
            try
            {

                this.GridViewViajes.Items.Clear();
                this.GridViewViajes.Columns.Clear();
                
                var Headertexts = new List<string> { "Tipo Línea", "Precio", "Origen", "Fecha", "Hr Salida", "Destino", "Fecha", "Hora", "Tipo Viaje" };
                var Names = new List<string> { "camion", "precioNormal1", "terminalOrigen", "fechaOrigenV", "horaOrigenV", "terminalDestino", "fechaDestinoV", "horaDestinoV", "tipoTerminal", "numAsiento", "precioInfantil1", "precioTerceraEdad1", "precioEspecial1", "precioNormal2", "precioInfantil2", "precioTerceraEdad2", "precioEspecial2", "nombreViaje", "numCamion", "tiempoMinutos", "numPiso", "id_tipoViaje", "id_tipoTerminal", "id_viaje", "id_ruta", "id_camion", "id_disenioCamion", "id_terminalOrigen", "id_terminalDestino", "id_terminalXruta", "id_tarifa", "ordenOrigen", "ordenDestino", "fechaOrigen", "horaOrigen", "numAsientos", "recorridoViaje", "id_tipoCamion" };
                this.dbFieldList = Names;

                this.RecorrerForGridViewViajes(Headertexts, 1);
                //this.RecorrerForGridViewViajes(Names, 2);
                //this.RecorrerForGridViewViajes(Names, 3);

                this.GridViewViajes.Columns[0].Width = 100;
                this.GridViewViajes.Columns[1].Width = 80;
                //this.GridViewViajes.Columns[1].DefaultCellStyle.Format = "c";
                this.GridViewViajes.Columns[2].Width = 80;
                this.GridViewViajes.Columns[3].Width = 110;
                this.GridViewViajes.Columns[4].Width = 100;
                this.GridViewViajes.Columns[5].Width = 140;
                this.GridViewViajes.Columns[6].Width = 110;
                this.GridViewViajes.Columns[7].Width = 90;
                this.GridViewViajes.Columns[8].Width = 100;
                //this.GridViewViajes.Columns[9].Visible = false;
                //this.GridViewViajes.Columns[10].Visible = false;
                //this.GridViewViajes.Columns[11].Visible = false;
                //this.GridViewViajes.Columns[12].Visible = false;
                //this.GridViewViajes.Columns[13].Visible = false;
                //this.GridViewViajes.Columns[14].Visible = false;
                //this.GridViewViajes.Columns[15].Visible = false;
                //this.GridViewViajes.Columns[16].Visible = false;
                //this.GridViewViajes.Columns[17].Visible = false;
                //this.GridViewViajes.Columns[18].Visible = false;
                //this.GridViewViajes.Columns[19].Visible = false;
                //this.GridViewViajes.Columns[20].Visible = false;
                //this.GridViewViajes.Columns[21].Visible = false;
                //this.GridViewViajes.Columns[22].Visible = false;
                //this.GridViewViajes.Columns[23].Visible = false;
                //this.GridViewViajes.Columns[24].Visible = false;
                //this.GridViewViajes.Columns[25].Visible = false;
                //this.GridViewViajes.Columns[26].Visible = false;
                //this.GridViewViajes.Columns[27].Visible = false;
                //this.GridViewViajes.Columns[28].Visible = false;
                //this.GridViewViajes.Columns[29].Visible = false;
                //this.GridViewViajes.Columns[30].Visible = false;
                //this.GridViewViajes.Columns[31].Visible = false;
                //this.GridViewViajes.Columns[32].Visible = false;
                //this.GridViewViajes.Columns[33].Visible = false;
                //this.GridViewViajes.Columns[34].Visible = false;
                //this.GridViewViajes.Columns[35].Visible = false;

                //for (int i = 35; i >= 9; i--)
                //{
                //    this.GridViewViajes.Columns.RemoveAt(i);
                //}

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void RecorrerForGridViewViajes(List<string> campos, int opcion)
        {
            for (var index = 0; index < campos.Count; index++)
            {
                if (opcion == 1)
                    this.GridViewViajes.Columns.Add(campos[index]);
                    //this.HeaderTextGridViewViajes(index, campos[index]);
                //else if (opcion == 2)
                //    this.NameGridViewViajes(index, campos[index]);
                //else if (opcion == 3)
                //    this.DataPropertyNameGridViewViajes(index, campos[index]);
            }
        }
        private void HeaderTextGridViewViajes(int numColum, string nombre)
        {
            try
            {
                this.GridViewViajes.Columns[numColum].Text = nombre;
                //this.GridViewViajes.Columns[numColum].HeaderText = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void NameGridViewViajes(int numColum, string nombre)
        {
            try
            {
                this.GridViewViajes.Columns[numColum].Name = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DataPropertyNameGridViewViajes(int numColum, string nombre)
        {
            try
            {
                this.GridViewViajes.Columns[numColum].Name = nombre;
                //this.GridViewViajes.Columns[numColum].DataPropertyName = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<DataGridViewRow> ObtenerFilaSeleccionadaGridViewViajes()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in GridViewViajes.Items)
                //foreach (DataGridViewRow row in GridViewViajes.Rows)
                {
                    if (row.Selected)
                    {
                        rowSelected.Add(row);
                    }
                }
                return rowSelected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarFilaSeleccionadaGridViewViajes(List<DataGridViewRow> rowSelected)
        {
            try
            {
                if (rowSelected.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion     
        #region GridViewVentaBoletos
        private void CargarGridViewVentaBoletos()
        {
            try
            {
                this.GridViewVentaBoletos.Items.Clear();

                foreach (DataRow fila in NuevaVenta.Rows)
                {

                    List<string> dataList = new List<string>();
                    for (var i = 0; i < this.dbFieldList2.Count; i++)
                    {
                        var field = this.dbFieldList2[i];

                        string nombre = fila[field].ToString();
                        dataList.Add(nombre);
                    }

                    string[] valores = dataList.ToArray();

                    ListViewItem item = new ListViewItem(valores);
                    this.GridViewVentaBoletos.Items.Add(item);

                }

                this.GridViewVentaBoletos.Items[0].Selected = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridViewVentaBoletos()
        {
            try
            {
                this.GridViewVentaBoletos.Items.Clear();
                this.GridViewVentaBoletos.Columns.Clear();

                var Headertexts = new List<string> { "Nombre_Cliente", "Fecha Nac", "Teléfono", "#", "Tipo Línea", "Origen", "Fec Salida", "Hr Salida", "Destino", "Precio", "Desc" };
                var Names = new List<string> { "Nombre", "FechaNacimiento", "NumeroTelefono", "Asiento", "TipoLinea", "Origen", "FechaSalidaV2", "HoraSalidaV", "Destino", "Precio", "Descuentos", "DescripcionIndice", "IDViaje", "IDCamionDiseño", "NumCamion", "TipoLinea", "FechaLLegadaV", "FechaLLegadaV2", "HoraLLegadaV", "TipoDescuento", "IDBoleto", "FechaSalidaV", "IDTarifa", "IDTipoTarifa", "IDStatus", "Anticipo", "IDBoletoTransferencia", "FechaSalida", "HoraSalida", "PagoExtra", "IDTipoCamion" };
                this.dbFieldList2 = Names;
                this.RecorrerForGridViewVentaBoletos(Headertexts, 1);
                //this.RecorrerForGridViewVentaBoletos(Names, 2);
                //this.RecorrerForGridViewVentaBoletos(Names, 3);
                this.GridViewVentaBoletos.Columns[0].Width = 150;
                this.GridViewVentaBoletos.Columns[1].Width = 110;
                this.GridViewVentaBoletos.Columns[2].Width = 100;
                this.GridViewVentaBoletos.Columns[3].Width = 60;
                this.GridViewVentaBoletos.Columns[4].Width = 100;
                this.GridViewVentaBoletos.Columns[5].Width = 80;
                this.GridViewVentaBoletos.Columns[6].Width = 110;
                this.GridViewVentaBoletos.Columns[7].Width = 100;
                this.GridViewVentaBoletos.Columns[8].Width = 140;
                this.GridViewVentaBoletos.Columns[9].Width = 80;
                //this.GridViewVentaBoletos.Columns[9].DefaultCellStyle.Format = "c";
                this.GridViewVentaBoletos.Columns[10].Width = 80;
                //this.GridViewVentaBoletos.Columns[10].DefaultCellStyle.Format = "c";
                //this.GridViewVentaBoletos.Columns[10].Visible = false; //Se desabilita porque esta columna en esta pantalla no sirve en las demas si               
                //this.GridViewVentaBoletos.Columns[11].Visible = false;
                //this.GridViewVentaBoletos.Columns[12].Visible = false;
                //this.GridViewVentaBoletos.Columns[13].Visible = false;
                //this.GridViewVentaBoletos.Columns[14].Visible = false;
                //this.GridViewVentaBoletos.Columns[15].Visible = false;
                //this.GridViewVentaBoletos.Columns[16].Visible = false;
                //this.GridViewVentaBoletos.Columns[17].Visible = false;
                //this.GridViewVentaBoletos.Columns[18].Visible = false;
                //this.GridViewVentaBoletos.Columns[19].Visible = false;
                //this.GridViewVentaBoletos.Columns[20].Visible = false;
                //this.GridViewVentaBoletos.Columns[21].Visible = false;
                //this.GridViewVentaBoletos.Columns[22].Visible = false;
                //this.GridViewVentaBoletos.Columns[23].Visible = false;
                //this.GridViewVentaBoletos.Columns[24].Visible = false;
                //this.GridViewVentaBoletos.Columns[25].Visible = false;
                //this.GridViewVentaBoletos.Columns[26].Visible = false;
                //this.GridViewVentaBoletos.Columns[27].Visible = false;
                //this.GridViewVentaBoletos.Columns[28].Visible = false;
                //this.GridViewVentaBoletos.Columns[29].Visible = false;
                //this.GridViewVentaBoletos.Columns[30].Visible = false;

                //for (int i = 30; i >= 10; i--)
                //{
                //    this.GridViewVentaBoletos.Columns.RemoveAt(i);
                //}

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void RecorrerForGridViewVentaBoletos(List<string> campos, int opcion)
        {
            for (var index = 0; index < campos.Count; index++)
            {
                if (opcion == 1)
                    this.GridViewVentaBoletos.Columns.Add(campos[index]);
                    //this.HeaderTextGridViewVentaBoletos(index, campos[index]);
                //else if (opcion == 2)
                //    this.NameGridViewVentaBoletos(index, campos[index]);
                //else if (opcion == 3)
                //    this.DataPropertyNameGridViewVentaBoletos(index, campos[index]);
            }
        }
        private void HeaderTextGridViewVentaBoletos(int numColum, string nombre)
        {
            try
            {
                this.GridViewVentaBoletos.Columns[numColum].Text = nombre;
                //this.GridViewVentaBoletos.Columns[numColum].HeaderText = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void NameGridViewVentaBoletos(int numColum, string nombre)
        {
            try
            {
                this.GridViewVentaBoletos.Columns[numColum].Name = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DataPropertyNameGridViewVentaBoletos(int numColum, string nombre)
        {
            try
            {
                this.GridViewVentaBoletos.Columns[numColum].Name = nombre;
                //this.GridViewVentaBoletos.Columns[numColum].DataPropertyName = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<DataGridViewRow> ObtenerFilaSeleccionadaGridViewVentaBoletos()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in GridViewVentaBoletos.Items)
                //foreach (DataGridViewRow row in GridViewVentaBoletos.Rows)
                {
                    if (row.Selected)
                    {
                        rowSelected.Add(row);
                    }
                }
                return rowSelected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarFilaSeleccionadaGridViewVentaBoletos(List<DataGridViewRow> rowSelected)
        {
            try
            {
                if (rowSelected.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region DatosCamion
        private void LlenarDatosCamion(DataTable DatosCamion)
        {
            try
            {
                string Numero;
                PictureBox PictureBoxAux;
                TextBox TextBoxAux;

                if (IDViajeDiseñoAux != homes.IDViaje || numPisoAux != numPisoActual)
                {
                    for (int j = 1; j < 66; j++)
                    {
                        TextBoxAux = (TextBox)this.FindControl(this, "pasilloasiento" + j);
                        TextBoxAux.Text = "";
                        TextBoxAux.BackColor = Color.White;
                        PictureBoxAux = (PictureBox)this.FindControl(this, "asiento" + j);
                        PictureBoxAux.Tag = "0";
                        PictureBoxAux.Image = null;
                        PictureBoxAux.BackColor = Color.White;
                    }

                    for (int l = 1; l < 14; l++)
                    {
                        PictureBoxAux = (PictureBox)this.FindControl(this, "puerta" + l);
                        PictureBoxAux.Tag = "0";
                        PictureBoxAux.Image = null;
                        PictureBoxAux.BackColor = Color.White;
                        PictureBoxAux.Visible = false;
                    }
                }

                foreach (DataRow row in DatosCamion.Rows)
                {
                    if (Convert.ToInt32(row["idTipoObj"]) == 1 && Convert.ToInt32(row["numPiso"]) == numPisoActual)
                    {
                        PictureBoxAux = (PictureBox)this.FindControl(this, row["descripcion"].ToString());
                        Numero = PictureBoxAux.Name.Replace("asiento", "");
                        PictureBoxAux.BackColor = Color.Gainsboro;
                        if (Convert.ToInt32(row["idStatus"].ToString()) == 0)
                        {
                            PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.disponible;
                            PictureBoxAux.Tag = "1";
                        }
                        else if (Convert.ToInt32(row["idStatus"].ToString()) == 1)
                        {
                            PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.espera;
                            PictureBoxAux.Tag = "0";
                        }
                        else if (Convert.ToInt32(row["idStatus"].ToString()) == 2)
                        {
                            if (Convert.ToSingle(row["pago"].ToString()) == 0.0)
                                PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.asiento_apartado;
                            else if (Convert.ToSingle(row["pago"].ToString()) > 0.0)
                                PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.apartadoAnticipo;
                            PictureBoxAux.Tag = "0";
                        }
                        else if (Convert.ToInt32(row["idStatus"].ToString()) == 3)
                        {
                            if (Convert.ToBoolean(row["asistencia"]) == false)
                            {
                                PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.ocupado;
                                PictureBoxAux.Tag = "0";
                            }
                            else if (Convert.ToBoolean(row["asistencia"]) == true)
                            {
                                PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.ocupado__asistencia;
                                PictureBoxAux.Tag = "0";
                            }
                        }

                        if (IDViajeDiseñoAux != homes.IDViaje || numPisoAux != numPisoActual)
                        {
                            TextBox TextAux = (TextBox)this.FindControl(this, "pasilloasiento" + Numero);
                            if (TextAux.Text.ToString().Equals("TV"))
                            {
                                TextAux.Text = " " + "TV";
                            }
                            TextAux.Text = row["indice"].ToString();
                        }
                    }
                    else if (Convert.ToInt32(row["idTipoObj"]) == 3 && Convert.ToInt32(row["numPiso"]) == numPisoActual)
                    {
                        PictureBoxAux = (PictureBox)this.FindControl(this, row["descripcion"].ToString());
                        Numero = PictureBoxAux.Name.Replace("asiento", "");
                        //PictureBoxAux.BackColor = Color.LightGray;
                        PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.sanitarioOutline;
                       
                        if (IDViajeDiseñoAux != homes.IDViaje || numPisoAux != numPisoActual)
                        {
                            TextBox TextAux = (TextBox)this.FindControl(this, "pasilloasiento" + Numero);
                            if (TextAux.Text.ToString().Equals("TV"))
                            {
                                TextAux.Text = " " + "TV";
                            }
                            TextAux.Text = row["tipoObj"].ToString() + TextAux.Text;
                        }
                    }
                    else if (Convert.ToInt32(row["idTipoObj"]) == 4 && Convert.ToInt32(row["numPiso"]) == numPisoActual)
                    {
                        PictureBoxAux = (PictureBox)this.FindControl(this, row["descripcion"].ToString());
                        Numero = PictureBoxAux.Name.Replace("asiento", "");
                        PictureBoxAux.BackColor = Color.Plum;
                        PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.bar;
                        if (IDViajeDiseñoAux != homes.IDViaje || numPisoAux != numPisoActual)
                        {
                            TextBox TextAux = (TextBox)this.FindControl(this, "pasilloasiento" + Numero);
                            if (TextAux.Text.ToString().Equals("TV"))
                            {
                                TextAux.Text = " " + "TV";
                            }
                            TextAux.Text = row["tipoObj"].ToString() + TextAux.Text;
                        }
                    }
                    else if (Convert.ToInt32(row["idTipoObj"]) == 2 && Convert.ToInt32(row["numPiso"]) == numPisoActual)
                    {
                        if (IDViajeDiseñoAux != homes.IDViaje || numPisoAux != numPisoActual)
                        {
                            TextBoxAux = (TextBox)this.FindControl(this, "pasilloasiento" + row["indice"].ToString());
                            TextBoxAux.Text = TextBoxAux.Text + " " + row["tipoObj"].ToString();
                            TextBoxAux.BackColor = Color.Silver;
                        }
                    }
                    else if (Convert.ToInt32(row["idTipoObj"]) == 5 && Convert.ToInt32(row["numPiso"]) == numPisoActual)
                    {
                        PictureBoxAux = (PictureBox)this.FindControl(this, row["descripcion"].ToString());
                        PictureBoxAux.BackColor = Color.Gainsboro;
                        PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.puerta;
                        PictureBoxAux.Visible = true;
                    }
                }
                IDViajeDiseñoAux = homes.IDViaje;
                numPisoAux = numPisoActual;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Control FindControl(Control root, string target)
        {
            if (root.Name.Equals(target))
                return root;
            for (var i = 0; i < root.Controls.Count; ++i)
            {
                if (root.Controls[i].Name.Equals(target))
                    return root.Controls[i];
            }
            for (var i = 0; i < root.Controls.Count; ++i)
            {
                Control result;
                for (var k = 0; k < root.Controls[i].Controls.Count; ++k)
                {
                    result = FindControl(root.Controls[i].Controls[k], target);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }
        private void backgroundWorkerDiseñoCamion_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (this.homes.IDViaje != "")
                {
                    homes.NumAsientosDiponibles = 0;
                    homes.NumAsientosApartado = 0;

                    Home_Negocio home_negocio = new Home_Negocio();
                    home_negocio.ObtenerDatosCamion(Comun.Conexion, ref homes);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void timerCamion_Tick(object sender, EventArgs e)
        {
            try
            {
                //if (!this.backgroundWorkerDiseñoCamion.IsBusy)
                //    this.backgroundWorkerDiseñoCamion.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema tiene que Cerrarse, no se cuenta con internet", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void backgroundWorkerDiseñoCamion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (this.homes.IDViaje != "")
                {
                    LlenarDatosCamion(homes.DatosCamion);

                    //this.Txt_NumAsientos.Text = this.homes.NumAsientos.ToString();
                    this.Txt_NumAsientosDisponibles.Text = this.homes.NumAsientosDiponibles.ToString();
                    this.Txt_NumAsientosApartados.Text = this.homes.NumAsientosApartado.ToString();
                    this.Txt_Recorrido.Text = this.homes.Recorrido.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema tiene que Cerrarse, no se cuenta con internet", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion
        #region Timer
        private void backgroundWorkerFechaHora_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.FechaHoraSistema = DateTime.Now;
                if (this.Venta())
                {
                    if (this.SegundosTiempoVenta >= 300)
                    {
                        TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
                    }
                    else if (_stopTiempoVenta == false)
                    {
                        this.SegundosTiempoVenta = SegundosTiempoVenta + 1;
                        TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
                        TiempoVenta = TiempoVenta.AddSeconds(300);
                        TiempoVenta = TiempoVenta.AddSeconds(this.SegundosTiempoVenta * -1);
                    }
                }
                else
                {
                    this.SegundosTiempoVenta = 0;
                    TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
                }
                this.SegundosTiempoLiberacionBoletos = SegundosTiempoLiberacionBoletos + 1;
            }
            catch (Exception ex)
            {
            }
        }
        private void backgroundWorkerFechaHora_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.Txt_FechaHoraSistema.Text = this.FechaHoraSistema.ToString("d") + " " + this.FechaHoraSistema.ToString("HH:mm:ss");
                this.Txt_TiempoVenta.Text = this.TiempoVenta.ToString("mm:ss");
                if (this.Venta())
                {
                    if (this.SegundosTiempoVenta >= 300)
                    {
                        int Verificador = 1;
                        PictureBox PictureBoxAux;
                        this.SegundosTiempoVenta = 0;
                        Home_Negocio home = new Home_Negocio();
                        home.EliminarAsientosApartados(Comun.Conexion, NuevaVenta, ref Verificador);
                        if (Verificador == 0)
                        {
                            if (this.homes.IDViaje != "")
                            {
                                foreach (DataRow row in this.NuevaVenta.Rows)
                                {
                                    PictureBoxAux = (PictureBox)this.FindControl(this, row["DescripcionIndice"].ToString());
                                    PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.disponible;
                                    PictureBoxAux.Tag = "1";
                                }
                            }
                            this.Inicializar();
                            MessageBox.Show("Boletos liberados por tiempo correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                /*
                if (this.SegundosTiempoLiberacionBoletos >= 300)
                {
                    this.SegundosTiempoLiberacionBoletos = 0;
                    Home_Negocio home = new Home_Negocio();
                    home.LiberarAsientoApartadosPorTiempoSistema(Comun.Conexion);
                }
                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema tiene que Cerrarse, no se cuenta con internet", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.backgroundWorkerFechaHora.IsBusy)
                    this.backgroundWorkerFechaHora.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema tiene que Cerrarse, no se cuenta con internet", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        private void GridViewVentaBoletos_CellClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                //GridViewVentaBoletos.Columns[Columna_DataTimePicker].ReadOnly = true;
                //oDateTimePicker_CloseUp(sender, e);
                //if (e.ColumnIndex == Columna_DataTimePicker)
                //{
                //    if (e.RowIndex >= 0)
                //    {
                //        oDateTimePicker = new DateTimePicker();
                //        GridViewVentaBoletos.Controls.Add(oDateTimePicker);
                //        oDateTimePicker.Visible = false;
                //        oDateTimePicker.Format = DateTimePickerFormat.Short;
                //        oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);
                //        oDateTimePicker.Visible = true;
                //        Rectangle oRectangle = GridViewVentaBoletos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                //        oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);
                //        oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);
                //        oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridViewVentaBoletos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentDateTimePicker != null)
            {
                currentDateTimePicker.Visible = false;
                currentDateTimePicker = null;
            }

            foreach (ListViewItem item in GridViewVentaBoletos.SelectedItems)
            {
                int columnaSubitem = Columna_DataTimePicker;

                if (item.SubItems[columnaSubitem].Bounds.Contains(GridViewVentaBoletos.PointToClient(Cursor.Position)))
                {
                    ListViewItem.ListViewSubItem subItem = item.SubItems[columnaSubitem];

                    Rectangle subItemBounds = new Rectangle(subItem.Bounds.Left - item.Bounds.Left, subItem.Bounds.Top - item.Bounds.Top, subItem.Bounds.Width, subItem.Bounds.Height);
                    oDateTimePicker = new DateTimePicker();
                    oDateTimePicker.Format = DateTimePickerFormat.Short;
                    oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);
                    oDateTimePicker.Size = subItemBounds.Size;
                    oDateTimePicker.Location = new Point(item.Bounds.Left + subItemBounds.Left, item.Bounds.Top + subItemBounds.Top);
                    GridViewVentaBoletos.Controls.Add(oDateTimePicker);
                    oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
                    currentDateTimePicker = oDateTimePicker;
                }
            }
        }

        private void checkBoxVentaGrupal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxVentaGrupal.Checked == true)
                {
                    if (NuevaVenta.Rows.Count > 0)
                    {
                        boletoGrupal.id_viajeGrupal = NuevaVenta.Rows[0]["IDViaje"].ToString();
                        boletoGrupal.fechaViajeGrupal = Convert.ToDateTime(NuevaVenta.Rows[0]["FechaSalida"].ToString());
                        boletoGrupal.horaViajeGrupal = NuevaVenta.Rows[0]["HoraSalida"].ToString();
                        foreach (DataRow boleto in NuevaVenta.Rows)
                            if ((boletoGrupal.id_viajeGrupal != boleto["IDViaje"].ToString()) || (boletoGrupal.fechaViajeGrupal.ToShortDateString() != Convert.ToDateTime(boleto["FechaSalida"].ToString()).ToShortDateString()) || (boletoGrupal.horaViajeGrupal != boleto["HoraSalida"].ToString()))
                            {
                                MessageBox.Show("En la venta grupal no se pueden vender boletos de diferentes camiones", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                boletoGrupal.nombre = "";
                                boletoGrupal.fechaNacimiento = DateTime.Now;
                                boletoGrupal.numeroTelefono = "";
                                boletoGrupal.ventaGrupal = false;
                                checkBoxVentaGrupal.Checked = false;
                                boletoGrupal.id_viajeGrupal = "";
                                boletoGrupal.fechaViajeGrupal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddDays(-1.00);
                                boletoGrupal.horaViajeGrupal = "";
                                return;
                            }
                    }
                    frmVentaGrupal fvg = new frmVentaGrupal(boletoGrupal);
                    fvg.ShowDialog();
                    if (fvg._banVentaGrupal == true)
                    {
                        boletoGrupal = fvg.infoBoletosGrupal;
                        foreach (DataRow aux in this.NuevaVenta.Rows)
                        {
                            aux["Nombre"] = boletoGrupal.nombre;
                            aux["NumeroTelefono"] = boletoGrupal.numeroTelefono;
                            aux["FechaNacimiento"] = boletoGrupal.fechaNacimiento.ToString("dd/MM/yyyy");
                        }
                        this.CargarGridViewVentaBoletos();
                    }
                    else
                    {
                        boletoGrupal.nombre = "";
                        boletoGrupal.fechaNacimiento = DateTime.Now;
                        boletoGrupal.numeroTelefono = "";
                        boletoGrupal.ventaGrupal = false;
                        checkBoxVentaGrupal.Checked = false;
                    }
                }
                else
                {
                    boletoGrupal.nombre = "";
                    boletoGrupal.fechaNacimiento = DateTime.Now;
                    boletoGrupal.numeroTelefono = "";
                    boletoGrupal.ventaGrupal = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void materialTabControl1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del control MenuStrip
            MenuStrip menuStrip1 = new MenuStrip();

            // Agregar elementos de menú al control MenuStrip si es necesario
            // menuStrip1.Items.Add("Archivo");
            // menuStrip1.Items.Add("Editar");
            // ...

            // Mover el control MenuStrip al tab deseado del MaterialTabControl
            TabPage tabPage = materialTabControl1.TabPages[0]; // Supongamos que el tab deseado está en la posición 0
            menuStrip1.Parent = tabPage;
            menuStrip1.Dock = DockStyle.Top;
        }





        //private void dtmFechaSalida_ValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        //if (Convert.ToDateTime(dtmFechaSalida.Value.ToShortDateString()) > Convert.ToDateTime(DateTime.Now.AddDays(30).ToShortDateString()))
        //        //{
        //        //    MessageBox.Show("No puedes buscar a una fecha mayor a " + DateTime.Now.AddDays(30).ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        //    dtmFechaSalida.Value = DateTime.Now;
        //        //}
        //        if (Convert.ToDateTime(dtmFechaSalida.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
        //        {
        //            MessageBox.Show("No puedes buscar a una fecha menor a " + DateTime.Now.ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            dtmFechaSalida.Value = DateTime.Now;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
    
}
