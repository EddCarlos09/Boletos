using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativaSL.LibControls.WinForms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using System.Globalization;
using CreativaSL.WinForm.VentaBoletos.Clientes;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmHome : Form_Creativa
    {
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
        private DateTime FechaHoraSistema =  DateTime.Now;
        private int SegundosTiempoVenta = 0;
        private int SegundosTiempoLiberacionBoletos = 0;
        private DateTime TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
        private bool _stopTiempoVenta = false;
       

        V2Cliente ClienteActual;
        //Cliente ClienteActual;

        #endregion
        #region Constuctor
        public frmHome()
        {
            try
            {
                InitializeComponent();
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Metodos Generales
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
                this.GridViewViajes.SelectionChanged -= new System.EventHandler(this.GridViewViajes_SelectionChanged);
                this.GridViewViajes.DataSource = homes.Salidas;
                this.GridViewViajes.SelectionChanged += new System.EventHandler(this.GridViewViajes_SelectionChanged);
                if (this.GridViewViajes.Rows.Count > 0)
                {
                    this.GridViewViajes.CurrentCell = this.GridViewViajes.Rows[0].Cells[0];
                    this.GridViewViajes.Rows[0].Selected = true;
                }
                GridViewViajes_SelectionChanged(this.GridViewViajes, new DataGridViewCellEventArgs(0, 0));


                this.GridViewVentaBoletos.DataSource = homes.VentaBoletos;


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

                    frmPrecio frmp = new frmPrecio(lst_precios, ClienteActual);
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
                            if(NuevaVenta.Rows.Count > 0)
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
                        this.toolTip.Active = true;
                        TextBox TextBoxAux = (TextBox)this.FindControl(this, "pasilloasiento" + PictureBoxAux.Name.Replace("asiento", ""));
                        int auxAsiento = Convert.ToInt32(TextBoxAux.Text.Replace(" TV", ""));

                        foreach (DataRow row in this.homes.DatosCamion.Rows)
                        {
                            if (Convert.ToInt32(row["indice"]) == auxAsiento)
                            {
                                if (Convert.ToInt32(row["idStatus"]) == 2)
                                {
                                    if (Convert.ToSingle(row["pago"]) == 0.0)
                                        toolTip.SetToolTip(PictureBoxAux, "Nombre: " + Convert.ToString(row["nombre"]) + "\n"
                                         + "Estado: Apartado" + "\n"
                                         + "Precio: " + Convert.ToSingle(row["costo"]) + "\n"
                                         + "Pago: " + Convert.ToSingle(row["pago"])                                            
                                         );
                                    else if (Convert.ToSingle(row["pago"]) > 0.0)
                                        toolTip.SetToolTip(PictureBoxAux, "Nombre: " + Convert.ToString(row["nombre"]) + "\n"
                                         + "Estado: Anticipo" + "\n"
                                         + "Precio: " + Convert.ToSingle(row["costo"]) + "\n"
                                         + "Pago: " + Convert.ToSingle(row["pago"])
                                         );
                                }
                                else if (Convert.ToInt32(row["idStatus"]) == 3)
                                {
                                    toolTip.SetToolTip(PictureBoxAux, "Nombre: " + Convert.ToString(row["nombre"]) + "\n"
                                     + "Estado: Vendido" + "\n"
                                     + "Precio: " + Convert.ToSingle(row["costo"]) + "\n"
                                     + "Pago: " + Convert.ToSingle(row["pago"])
                                     );
                                }
                            }
                        }
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
                if (GridViewVentaBoletos.RowCount > 0)
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
                    frmVentasV2 frmv = new frmVentasV2();
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
        private void btnCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Venta() == false)
                {
                    this.Inicializar();
                    Button_Creativa btn = (Button_Creativa)sender;
                    MenuStripCaja.Show(btn, btn.Height, btn.Location.Y + (btn.Width / 4));
                    MenuStripCaja.Focus();
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
                if (this.Venta() ==  true)
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
                        frmVentaBoleto frmvb = new frmVentaBoleto(VentaBoletosAux, ClienteActual);
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
                if (this.GridViewViajes.Rows.Count > 0)
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
                if (this.GridViewViajes.Rows.Count > 0)
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
                this.GridViewViajes.SelectionChanged -= new System.EventHandler(this.GridViewViajes_SelectionChanged);
                this.GridViewViajes.DataSource = null;
                this.GridViewViajes.SelectionChanged += new System.EventHandler(this.GridViewViajes_SelectionChanged);
                if (this.GridViewViajes.Rows.Count > 0)
                {
                    this.GridViewViajes.CurrentCell = this.GridViewViajes.Rows[0].Cells[0];
                    this.GridViewViajes.Rows[0].Selected = true;
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
                if (GridViewViajes.SelectedRows.Count > 0)
                {

                    homes.IDBoleto = "";
                    homes.NombreViaje = this.GridViewViajes.SelectedRows[0].Cells["camion"].Value.ToString();
                    homes.IDViaje = this.GridViewViajes.SelectedRows[0].Cells["id_viaje"].Value.ToString();
                    homes.FechaSalida = Convert.ToDateTime(this.GridViewViajes.SelectedRows[0].Cells["fechaOrigen"].Value.ToString());
                    homes.HoraSalida = this.GridViewViajes.SelectedRows[0].Cells["horaOrigen"].Value.ToString();
                    homes.IDTarifa = this.GridViewViajes.SelectedRows[0].Cells["id_tarifa"].Value.ToString();
                    homes.IDTipoTarifa = 0; //Se Vuelve A Pedir
                    homes.NumCamion = this.GridViewViajes.SelectedRows[0].Cells["numCamion"].Value.ToString();
                    homes.TipoLinea = this.GridViewViajes.SelectedRows[0].Cells["camion"].Value.ToString();
                    homes.Asiento = 0; //Se Vuelve A Pedir
                    homes.DescripcionIndice = ""; //Se Vuelve A Pedir
                    homes.IDCamionDiseño = this.GridViewViajes.SelectedRows[0].Cells["id_disenioCamion"].Value.ToString();
                    homes.FechaSalidaV = Convert.ToDateTime(this.GridViewViajes.SelectedRows[0].Cells["fechaOrigenV"].Value.ToString());
                    homes.HoraSalidaV = this.GridViewViajes.SelectedRows[0].Cells["horaOrigenV"].Value.ToString();
                    homes.FechaLLegadaV = Convert.ToDateTime(this.GridViewViajes.SelectedRows[0].Cells["fechaDestinoV"].Value.ToString());
                    homes.HoraLlegadaV = this.GridViewViajes.SelectedRows[0].Cells["horaDestinoV"].Value.ToString();
                    homes.Origen = this.GridViewViajes.SelectedRows[0].Cells["terminalOrigen"].Value.ToString(); ;
                    homes.Destino = this.GridViewViajes.SelectedRows[0].Cells["terminalDestino"].Value.ToString();
                    homes.Precio = 0F; //Se Vuelve A Pedir
                    homes.Descuentos = 0F; //Se Vuelve A Pedir
                    homes.TipoDescuento = 0; //Se Vuelve A Pedir
                    homes.Nombre = ""; //Se Vuelve A Pedir
                    homes.precioNormal1 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioNormal1"].Value.ToString(), NumberStyles.Currency);
                    homes.precioInfantil1 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioInfantil1"].Value.ToString(), NumberStyles.Currency);
                    homes.precioTerceraEdad1 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioTerceraEdad1"].Value.ToString(), NumberStyles.Currency);
                    homes.precioEspecial1 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioEspecial1"].Value.ToString(), NumberStyles.Currency);
                    homes.precioNormal2 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioNormal2"].Value.ToString(), NumberStyles.Currency);
                    homes.precioInfantil2 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioInfantil2"].Value.ToString(), NumberStyles.Currency);
                    homes.precioTerceraEdad2 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioTerceraEdad2"].Value.ToString(), NumberStyles.Currency);
                    homes.precioEspecial2 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioEspecial2"].Value.ToString(), NumberStyles.Currency);
                    homes.IDStatus = 0;
                    homes.Anticipo = 0F;

                    homes.TipoTerminal = Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["id_tipoTerminal"].Value.ToString());
                    homes.NumAsientos = Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["numAsientos"].Value.ToString());
                    homes.NumAsientosDiponibles = 0;
                    homes.NumAsientosApartado = 0;
                    homes.Recorrido = this.GridViewViajes.SelectedRows[0].Cells["recorridoViaje"].Value.ToString().Replace(",", Environment.NewLine); 
                    homes.IDBoletoTransferencia = "";
                    homes.OrdenOrigen = Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["ordenOrigen"].Value.ToString());
                    homes.OrdenDestino = Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["ordenDestino"].Value.ToString());
                    homes.PagoExtra = 0F;

                    this.numPisoActual = 1;
                    this.numPisoAux = 0;

                    homes.id_tipoCamion = this.GridViewViajes.SelectedRows[0].Cells["id_tipoCamion"].Value.ToString();

                    homes.numPiso = Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["numPiso"].Value.ToString());
                    if (Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["numPiso"].Value.ToString()) == 1)
                    {
                        this.btnPlantaBaja.Visible = true;
                        this.btnPlantaAlta.Visible = false;
                    }
                    else if (Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["numPiso"].Value.ToString()) == 2)
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

                    this.toolTip.Active = false;
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

                    this.toolTip.Active = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GridViewVentaBoletos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (e.ColumnIndex != 8)
                    {
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

                            DatosAux.Rows.Add(
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDBoleto"].Value.ToString(),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDViaje"].Value.ToString(),
                                Convert.ToDateTime(GridViewVentaBoletos.Rows[e.RowIndex].Cells["FechaSalida"].Value.ToString()),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["HoraSalida"].Value.ToString(),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDTarifa"].Value.ToString(),
                                Convert.ToInt32(GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDTipoTarifa"].Value.ToString()),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["NumCamion"].Value.ToString(),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["TipoLinea"].Value.ToString(),
                                Convert.ToInt32(GridViewVentaBoletos.Rows[e.RowIndex].Cells["Asiento"].Value.ToString()),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["DescripcionIndice"].Value.ToString(),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDCamionDiseño"].Value.ToString(),
                                Convert.ToDateTime(GridViewVentaBoletos.Rows[e.RowIndex].Cells["FechaSalidaV"].Value.ToString()),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["FechaSalidaV2"].Value.ToString(),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["HoraSalidaV"].Value.ToString(),
                                Convert.ToDateTime(GridViewVentaBoletos.Rows[e.RowIndex].Cells["FechaLLegadaV"].Value.ToString()),
                                Convert.ToDateTime(GridViewVentaBoletos.Rows[e.RowIndex].Cells["FechaLLegadaV"].Value.ToString()).ToShortDateString(),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["HoraLLegadaV"].Value.ToString(),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["Origen"].Value.ToString(),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["Destino"].Value.ToString(),
                                Convert.ToSingle(GridViewVentaBoletos.Rows[e.RowIndex].Cells["Precio"].Value.ToString()),
                                Convert.ToSingle(GridViewVentaBoletos.Rows[e.RowIndex].Cells["Descuentos"].Value.ToString()),
                                Convert.ToInt32(GridViewVentaBoletos.Rows[e.RowIndex].Cells["TipoDescuento"].Value.ToString()),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(),
                                Convert.ToDateTime(GridViewVentaBoletos.Rows[e.RowIndex].Cells["FechaNacimiento"].Value.ToString()),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["NumeroTelefono"].Value.ToString(),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDStatus"].Value.ToString(),
                                Convert.ToSingle(GridViewVentaBoletos.Rows[e.RowIndex].Cells["Anticipo"].Value.ToString()),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDBoletoTransferencia"].Value.ToString(),
                                Convert.ToSingle(GridViewVentaBoletos.Rows[e.RowIndex].Cells["PagoExtra"].Value.ToString()),
                                GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDTipoCamion"].Value.ToString()
                                );
                            home.EliminarAsientosApartados(Comun.Conexion, DatosAux, ref Verificador);
                            if (Verificador == 0)
                            {
                                PictureBox PictureBoxAux;
                                PictureBoxAux = (PictureBox)this.FindControl(this, GridViewVentaBoletos.Rows[e.RowIndex].Cells["DescripcionIndice"].Value.ToString());
                                PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.disponible;
                                PictureBoxAux.Tag = "1";
                                GridViewVentaBoletos.Rows.Remove(GridViewVentaBoletos.Rows[e.RowIndex]);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            GridViewVentaBoletos.CurrentCell.Value = oDateTimePicker.Text.ToString();
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
                    frmDatosCaja frmdc = new frmDatosCaja();
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
                    frmCaja_CierreCaja frmcajaCierre = new frmCaja_CierreCaja();
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
                catalogoNegocio.LlenarGridSalidas(Comun.Conexion, ref home, IDTerminalOrigen, IDTerminalDestino, FechaBusqueda);
                this.GridViewViajes.AutoGenerateColumns = false;
                //SERGIO
                this.GridViewViajes.SelectionChanged -= new System.EventHandler(this.GridViewViajes_SelectionChanged);
                this.GridViewViajes.DataSource = home.Salidas;
                this.GridViewViajes.SelectionChanged += new System.EventHandler(this.GridViewViajes_SelectionChanged);
                if (this.GridViewViajes.Rows.Count > 0)
                {
                    this.GridViewViajes.CurrentCell = this.GridViewViajes.Rows[0].Cells[0];
                    this.GridViewViajes.Rows[0].Selected = true;
                }
                GridViewViajes_SelectionChanged(this.GridViewViajes, new DataGridViewCellEventArgs(0, 0));
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
                var Headertexts = new List<string> {  "Tipo Línea", "Precio", "Origen", "Fecha", "Hr Salida", "Destino", "Fecha", "Hora", "Tipo Viaje"};
                var Names = new List<string> { "camion","precioNormal1", "terminalOrigen", "fechaOrigenV", "horaOrigenV", "terminalDestino", "fechaDestinoV", "horaDestinoV", "tipoTerminal", "numAsiento", "precioInfantil1", "precioTerceraEdad1", "precioEspecial1", "precioNormal2", "precioInfantil2", "precioTerceraEdad2", "precioEspecial2", "nombreViaje", "numCamion", "tiempoMinutos", "numPiso", "id_tipoViaje", "id_tipoTerminal", "id_viaje", "id_ruta", "id_camion", "id_disenioCamion", "id_terminalOrigen", "id_terminalDestino", "id_terminalXruta", "id_tarifa", "ordenOrigen", "ordenDestino", "fechaOrigen", "horaOrigen", "numAsientos", "recorridoViaje", "id_tipoCamion" };
                this.RecorrerForGridViewViajes(Headertexts, 1);
                this.RecorrerForGridViewViajes(Names, 2);
                this.RecorrerForGridViewViajes(Names, 3);

                this.GridViewViajes.Columns[0].Width = 200;
                this.GridViewViajes.Columns[1].Width = 100;
                this.GridViewViajes.Columns[1].DefaultCellStyle.Format = "c";
                this.GridViewViajes.Columns[2].Width = 105;
                this.GridViewViajes.Columns[3].Width = 90;
                this.GridViewViajes.Columns[4].Width = 95;
                this.GridViewViajes.Columns[5].Width = 105;
                this.GridViewViajes.Columns[6].Width = 90;
                this.GridViewViajes.Columns[7].Width = 95;
                this.GridViewViajes.Columns[8].Width = 100;
                this.GridViewViajes.Columns[9].Visible = false;
                this.GridViewViajes.Columns[10].Visible = false;
                this.GridViewViajes.Columns[11].Visible = false;
                this.GridViewViajes.Columns[12].Visible = false;
                this.GridViewViajes.Columns[13].Visible = false;
                this.GridViewViajes.Columns[14].Visible = false;
                this.GridViewViajes.Columns[15].Visible = false;
                this.GridViewViajes.Columns[16].Visible = false;
                this.GridViewViajes.Columns[17].Visible = false;
                this.GridViewViajes.Columns[18].Visible = false;
                this.GridViewViajes.Columns[19].Visible = false;
                this.GridViewViajes.Columns[20].Visible = false;
                this.GridViewViajes.Columns[21].Visible = false;
                this.GridViewViajes.Columns[22].Visible = false;
                this.GridViewViajes.Columns[23].Visible = false;
                this.GridViewViajes.Columns[24].Visible = false;
                this.GridViewViajes.Columns[25].Visible = false;
                this.GridViewViajes.Columns[26].Visible = false;
                this.GridViewViajes.Columns[27].Visible = false;
                this.GridViewViajes.Columns[28].Visible = false;
                this.GridViewViajes.Columns[29].Visible = false;
                this.GridViewViajes.Columns[30].Visible = false;
                this.GridViewViajes.Columns[31].Visible = false;
                this.GridViewViajes.Columns[32].Visible = false;
                this.GridViewViajes.Columns[33].Visible = false;
                this.GridViewViajes.Columns[34].Visible = false;
                this.GridViewViajes.Columns[35].Visible = false;

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
                    this.HeaderTextGridViewViajes(index, campos[index]);
                else if (opcion == 2)
                    this.NameGridViewViajes(index, campos[index]);
                else if (opcion == 3)
                    this.DataPropertyNameGridViewViajes(index, campos[index]);
            }
        }
        private void HeaderTextGridViewViajes(int numColum, string nombre)
        {
            try
            {
                this.GridViewViajes.Columns[numColum].HeaderText = nombre;
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
                this.GridViewViajes.Columns[numColum].DataPropertyName = nombre;
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
                foreach (DataGridViewRow row in GridViewViajes.Rows)
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
                this.GridViewVentaBoletos.AutoGenerateColumns = false;
                this.GridViewVentaBoletos.DataSource = NuevaVenta;
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
                var Headertexts = new List<string> { "Nombre_Cliente","Fecha Nac","Teléfono","#", "Tipo Línea", "Origen", "Fec Salida", "Hr Salida", "Destino", "Precio", "Desc" };
                var Names = new List<string> { "Nombre","FechaNacimiento", "NumeroTelefono","Asiento","TipoLinea", "Origen", "FechaSalidaV2", "HoraSalidaV", "Destino", "Precio", "Descuentos", "DescripcionIndice", "IDViaje", "IDCamionDiseño", "NumCamion", "TipoLinea", "FechaLLegadaV", "FechaLLegada2V", "HoraLLegadaV", "TipoDescuento", "IDBoleto", "FechaSalidaV", "IDTarifa", "IDTipoTarifa", "IDStatus", "Anticipo", "IDBoletoTransferencia", "FechaSalida", "HoraSalida", "PagoExtra", "IDTipoCamion" };
                this.RecorrerForGridViewVentaBoletos(Headertexts, 1);
                this.RecorrerForGridViewVentaBoletos(Names, 2);
                this.RecorrerForGridViewVentaBoletos(Names, 3);
                this.GridViewVentaBoletos.Columns[0].Width = 400;
                this.GridViewVentaBoletos.Columns[1].Width = 240;
                this.GridViewVentaBoletos.Columns[2].Width = 120;
                this.GridViewVentaBoletos.Columns[3].Width = 40;
                this.GridViewVentaBoletos.Columns[4].Width = 120;
                this.GridViewVentaBoletos.Columns[5].Width = 105;
                this.GridViewVentaBoletos.Columns[6].Width = 100;
                this.GridViewVentaBoletos.Columns[7].Width = 90;
                this.GridViewVentaBoletos.Columns[8].Width = 105;
                this.GridViewVentaBoletos.Columns[9].Width = 90;
                this.GridViewVentaBoletos.Columns[9].DefaultCellStyle.Format = "c";
                this.GridViewVentaBoletos.Columns[10].Width = 80;
                this.GridViewVentaBoletos.Columns[10].DefaultCellStyle.Format = "c";
                this.GridViewVentaBoletos.Columns[10].Visible = false; //Se desabilita porque esta columna en esta pantalla no sirve en las demas si               
                this.GridViewVentaBoletos.Columns[11].Visible = false;
                this.GridViewVentaBoletos.Columns[12].Visible = false;
                this.GridViewVentaBoletos.Columns[13].Visible = false;
                this.GridViewVentaBoletos.Columns[14].Visible = false;
                this.GridViewVentaBoletos.Columns[15].Visible = false;
                this.GridViewVentaBoletos.Columns[16].Visible = false;
                this.GridViewVentaBoletos.Columns[17].Visible = false;
                this.GridViewVentaBoletos.Columns[18].Visible = false;
                this.GridViewVentaBoletos.Columns[19].Visible = false;
                this.GridViewVentaBoletos.Columns[20].Visible = false;
                this.GridViewVentaBoletos.Columns[21].Visible = false;
                this.GridViewVentaBoletos.Columns[22].Visible = false;
                this.GridViewVentaBoletos.Columns[23].Visible = false;
                this.GridViewVentaBoletos.Columns[24].Visible = false;
                this.GridViewVentaBoletos.Columns[25].Visible = false;
                this.GridViewVentaBoletos.Columns[26].Visible = false;
                this.GridViewVentaBoletos.Columns[27].Visible = false;
                this.GridViewVentaBoletos.Columns[28].Visible = false;
                this.GridViewVentaBoletos.Columns[29].Visible = false;
                this.GridViewVentaBoletos.Columns[30].Visible = false;
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
                    this.HeaderTextGridViewVentaBoletos(index, campos[index]);
                else if (opcion == 2)
                    this.NameGridViewVentaBoletos(index, campos[index]);
                else if (opcion == 3)
                    this.DataPropertyNameGridViewVentaBoletos(index, campos[index]);
            }
        }
        private void HeaderTextGridViewVentaBoletos(int numColum, string nombre)
        {
            try
            {
                this.GridViewVentaBoletos.Columns[numColum].HeaderText = nombre;
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
                this.GridViewVentaBoletos.Columns[numColum].DataPropertyName = nombre;
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
                foreach (DataGridViewRow row in GridViewVentaBoletos.Rows)
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
                            if(Convert.ToSingle(row["pago"].ToString()) == 0.0)
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
                        PictureBoxAux.BackColor = Color.GreenYellow;
                        PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.wc;

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
                if (!this.backgroundWorkerDiseñoCamion.IsBusy)
                    this.backgroundWorkerDiseñoCamion.RunWorkerAsync();
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
                        TiempoVenta = TiempoVenta.AddSeconds(this.SegundosTiempoVenta * - 1);
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
        private void GridViewVentaBoletos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GridViewVentaBoletos.Columns[Columna_DataTimePicker].ReadOnly = true;
                oDateTimePicker_CloseUp(sender, e);
                if (e.ColumnIndex == Columna_DataTimePicker)
                {
                    if (e.RowIndex >= 0)
                    {
                        oDateTimePicker = new DateTimePicker();
                        GridViewVentaBoletos.Controls.Add(oDateTimePicker);
                        oDateTimePicker.Visible = false;
                        oDateTimePicker.Format = DateTimePickerFormat.Short;
                        oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);
                        oDateTimePicker.Visible = true;
                        Rectangle oRectangle = GridViewVentaBoletos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);
                        oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);
                        oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
