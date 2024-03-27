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
namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCatSalidas : Form_Creativa
    {

        Viaje viajeprincipal;
        int aux;
        Viaje viajePrincipalViejo;
        #region Constructor

        public frmCatSalidas()
        {
            InitializeComponent();
            this.llenarCombos();
            viajeprincipal = new Viaje(Comun.Conexion);
            aux = 0;
            this.chkLunes.Checked = true;
            this.chkMartes.Checked = true;
            this.chkMiercoles.Checked = true;
            this.chkJueves.Checked = true;
            this.chkViernes.Checked = true;
            this.chkSabado.Checked = true;
            this.chkDomingo.Checked = true;
            this.chkLunes.Enabled = true;
            this.chkMartes.Enabled = true;
            this.chkMiercoles.Enabled = true;
            this.chkJueves.Enabled = true;
            this.chkViernes.Enabled = true;
            this.chkSabado.Enabled = true;
            this.chkDomingo.Enabled = true;
        }

        public frmCatSalidas(Viaje viaje)
        {
            InitializeComponent();
            this.llenarCombos();
            viajeprincipal = viaje;
            aux = 0;
            this.chkLunes.Enabled = false;
            this.chkMartes.Enabled = false;
            this.chkMiercoles.Enabled = false;
            this.chkJueves.Enabled = false;
            this.chkViernes.Enabled = false;
            this.chkSabado.Enabled = false;
            this.chkDomingo.Enabled = false;
            this.dtpFecInicio.Enabled = false;
            this.dtpFecFin.Enabled = false;
            this.rdbtnEspecial.Enabled = false;
            this.rdbtnLineas.Enabled = false;
            //this.cmbRutas.Enabled = false;
            if (!string.IsNullOrEmpty(this.viajeprincipal.id_viaje))
                this.llenarDatos();

            viajePrincipalViejo = viaje;
        }

        #endregion

        #region Eventos

        private void frmCatTarifas_Load(object sender, EventArgs e)
        {

        }


        private void rdbtnLineas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnLineas.Checked)
            {
                panelDias.Visible = true;
                panelFechas.Visible = true;
                this.label1.Visible = true;
                this.dtpFecFin.Checked = true;
                if (string.IsNullOrEmpty(this.viajeprincipal.id_viaje))
                {
                    this.chkLunes.Checked = true;
                    this.chkMartes.Checked = true;
                    this.chkMiercoles.Checked = true;
                    this.chkJueves.Checked = true;
                    this.chkViernes.Checked = true;
                    this.chkSabado.Checked = true;
                    this.chkDomingo.Checked = true;
                    this.chkLunes.Enabled = true;
                    this.chkMartes.Enabled = true;
                    this.chkMiercoles.Enabled = true;
                    this.chkJueves.Enabled = true;
                    this.chkViernes.Enabled = true;
                    this.chkSabado.Enabled = true;
                    this.chkDomingo.Enabled = true;
                }
            }
        }

        private void rdbtnEspecial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnEspecial.Checked)
            {
                panelDias.Visible = true;
                panelFechas.Visible = true;
                this.label1.Visible = true;
                this.dtpFecFin.Visible = true;
                if (string.IsNullOrEmpty(this.viajeprincipal.id_viaje))
                {
                    this.chkLunes.Checked = false;
                    this.chkMartes.Checked = false;
                    this.chkMiercoles.Checked = false;
                    this.chkJueves.Checked = false;
                    this.chkViernes.Checked = false;
                    this.chkSabado.Checked = false;
                    this.chkDomingo.Checked = false;
                    this.chkLunes.Enabled = false;
                    this.chkMartes.Enabled = false;
                    this.chkMiercoles.Enabled = false;
                    this.chkJueves.Enabled = false;
                    this.chkViernes.Enabled = false;
                    this.chkSabado.Enabled = false;
                    this.chkDomingo.Enabled = false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbCamion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Camion camion = (Camion)this.cmbCamion.SelectedItem;
                this.txtNumCamion.Text = camion.num_camion;
                this.txtTipoCamion.Text = camion.tipoCamion;
                this.txtDisenioCamion.Text = camion.descripciondisenio;
            }
            catch (Exception ex)
            {
            }
        }

        private void cmbCamion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = true;
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        #region Métodos

        private void llenarCombos()
        {
            try
            {
                this.llenarComboRutas();
                this.llenarComboCamiones();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarComboRutas()
        {
            try
            {
                Ruta_Negocio rn = new Ruta_Negocio();
                Ruta rutas = new Ruta(Comun.Conexion);
                rutas = rn.obtenerComboRutas(rutas);
                this.cmbRutas.DataSource = rutas.comborutas;
                this.cmbRutas.DisplayMember = "nombreRuta";
                this.cmbRutas.ValueMember = "id_ruta";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarComboCamiones()
        {
            try
            {
                Camion_Negocio cn = new Camion_Negocio();
                Camion camiones = new Camion(Comun.Conexion);
                camiones = cn.obtenerCamionesCombo(camiones);
                this.cmbCamion.DataSource = camiones.comboCamiones;
                this.cmbCamion.DisplayMember = "descripcion";
                this.cmbCamion.ValueMember = "id_camion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Viaje obtenerDatos()
        {
            try
            {
                Viaje viaje = new Viaje(Comun.Conexion);
                viaje.id_usuario = Comun.Id_U;

                viaje.nombre = this.txtNombreViaje.Text;
                viaje.lunes = this.chkLunes.Checked;
                viaje.martes = this.chkMartes.Checked;
                viaje.miercoles = this.chkMiercoles.Checked;
                viaje.jueves = this.chkJueves.Checked;
                viaje.viernes = this.chkViernes.Checked;
                viaje.sabado = this.chkSabado.Checked;
                viaje.domingo = this.chkDomingo.Checked;

                viaje.fec_PeriodoIni = DateTime.Parse(this.dtpFecInicio.Value.ToShortDateString());
                viaje.fec_PeriodoFin = DateTime.Parse(this.dtpFecFin.Value.ToShortDateString());

                if (rdbtnLineas.Checked)
                {
                    viaje.id_tipoViaje = 1;
                }
                else if (rdbtnEspecial.Checked)
                {
                    viaje.id_tipoViaje = 2;
                }


                Ruta ruta = (Ruta)this.cmbRutas.SelectedItem;
                Camion camion = (Camion)this.cmbCamion.SelectedItem;
                viaje.id_ruta = ruta.id_ruta;
                viaje.id_camion = camion.id_camion;

                if (!string.IsNullOrEmpty(viajeprincipal.id_viaje))
                {
                    viaje.id_viaje = viajeprincipal.id_viaje;
                }
                viaje.horario = dtpHora.Value.ToString("HH:mm:ss");
                return viaje;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int Verificador = 0;
                string RutasFaltantes = "";
                this.txt_mensaje.Visible = false;
                Viaje_Negocio vn = new Viaje_Negocio();
                if (string.IsNullOrEmpty(this.viajeprincipal.id_viaje))
                {
                    vn.registrarViaje(this.obtenerDatos());
                    MessageBox.Show("Datos guardados correctamente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    viajeprincipal = this.obtenerDatos();
                    if (viajeprincipal.id_ruta == viajePrincipalViejo.id_ruta)
                    {
                        vn.modificarViaje(viajeprincipal);
                        MessageBox.Show("Datos guardados correctamente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        Ruta rutaviejoviaje = new Ruta(Comun.Conexion);
                        rutaviejoviaje.id_ruta = viajePrincipalViejo.id_ruta;
                        rutaviejoviaje.id_viaje = viajePrincipalViejo.id_viaje;
                        rutaviejoviaje.fehcha_viaje = DateTime.Now;
                        rutaviejoviaje.hora_viaje = viajeprincipal.horario;
                        CambioCamionBoletos_Negocio ccb = new CambioCamionBoletos_Negocio();
                        rutaviejoviaje = ccb.Obtener_RutasViajesxIDRutaCompleto(rutaviejoviaje);

                        Ruta rutanuevaviaje = new Ruta(Comun.Conexion);
                        rutanuevaviaje.id_ruta = viajeprincipal.id_ruta;
                        rutanuevaviaje.id_rutaPadre = viajeprincipal.id_ruta;
                        Ruta_Negocio rn = new Ruta_Negocio();
                        rn.Obtener_RutasxIDRutaTodas(rutanuevaviaje);

                        Boleto boleto_viejo = new Boleto(Comun.Conexion);
                        boleto_viejo.lstBoletos_viajes1 = new List<Boleto>();
                        ccb.ObtenerBoletosViajesXRutasByFechas(Comun.Conexion, rutaviejoviaje, boleto_viejo, Convert.ToDateTime(DateTime.Now.ToShortDateString()), Convert.ToDateTime(DateTime.Now.AddDays(30).ToShortDateString()));

                        Tarifa tarifas = new Tarifa(Comun.Conexion);
                        tarifas.listaTarifas = new List<Tarifa>();
                        tarifas.id_viaje = rutaviejoviaje.id_viaje;
                        Tarifa_Negocio tn = new Tarifa_Negocio();
                        tarifas = tn.obtenerTarifasSalidas(tarifas);


                        viajeprincipal.lista_BoletosCambio = new DataTable();
                        viajeprincipal.lista_BoletosCambio.Columns.Add("IDBoleto", typeof(string));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("IDViajeViejo", typeof(string));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("FechaSalidaViejo", typeof(DateTime));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("HoraSalidaViejo", typeof(string));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("AsientoViejo", typeof(int));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("IDDisenioDatosViejo", typeof(string));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("IDStatusViejo", typeof(int));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("OrdenOrigenTerminalViejo", typeof(int));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("OrdenDestinoTerminalViejo", typeof(int));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("IDTarifaViejo", typeof(string));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("IDViajeNuevo", typeof(string));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("FechaSalidaNuevo", typeof(DateTime));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("HoraSalidaNuevo", typeof(string));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("AsientoNuevo", typeof(int));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("IDDisenioDatosNuevo", typeof(string));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("IDStatusNuevo", typeof(int));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("OrdenOrigenTerminalNuevo", typeof(int));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("OrdenDestinoTerminalNuevo", typeof(int));
                        viajeprincipal.lista_BoletosCambio.Columns.Add("IDTarifaNuevo", typeof(string));

                        viajeprincipal.lista_tarifasViaje = new DataTable();
                        viajeprincipal.lista_tarifasViaje.Columns.Add("IDTarifaNuevo", typeof(string));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("IDViajeNuevo", typeof(string));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("IDTerminalXRutaNuevo", typeof(string));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("IDTarifaViejo", typeof(string));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("IDViajeViejo", typeof(string));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("IDTerminalXRutaViejo", typeof(string));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("PrecioNormal1", typeof(float));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("PrecioInfantil1", typeof(float));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("PrecioTerceraEdad1", typeof(float));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("PrecioEspecial1", typeof(float));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("PrecioNormal2", typeof(float));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("PrecioInfantil2", typeof(float));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("PrecioTerceraEdad2", typeof(float));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("PrecioEspecial2", typeof(float));
                        viajeprincipal.lista_tarifasViaje.Columns.Add("IDTipo", typeof(int));

                        if (ComprobarRutas(rutaviejoviaje.rutas_intermedias, rutanuevaviaje.rutas_intermedias, ref RutasFaltantes) == true)
                        {
                            foreach (Boleto aux in boleto_viejo.lstBoletos_viajes1)
                            {
                                if (aux.id_status == 2 || aux.id_status == 3)
                                {

                                    Ruta auxCmp1 = null;
                                    List<Ruta> lstaux1 = rutaviejoviaje.rutas_intermedias.Where(rut => rut.id_terminalOrigen.Contains(aux.id_terminalSalida) && rut.id_terminalDestino.Contains(aux.id_terminalDestino)).ToList();
                                    if (lstaux1 != null)
                                        if (lstaux1.Count > 0)
                                            auxCmp1 = lstaux1[0];

                                    Ruta auxCmp2 = null;
                                    List<Ruta> lstaux2 = rutanuevaviaje.rutas_intermedias.Where(rut => rut.id_terminalOrigen.Contains(aux.id_terminalSalida) && rut.id_terminalDestino.Contains(aux.id_terminalDestino)).ToList();
                                    if (lstaux2 != null)
                                        if (lstaux2.Count > 0)
                                            auxCmp2 = lstaux2[0];

                                    AgregarDataTableCambiosBoletosViaje(new Object[] { 
                                        aux.id_boleto,
                                        viajePrincipalViejo.id_viaje,
                                        aux.fechaSalida,
                                        aux.horaSalida,
                                        aux.asiento,
                                        aux.id_disenioDatos,
                                        aux.id_status,
                                        auxCmp1.ordenOrigen,
                                        auxCmp1.ordenDestino,
                                        aux.id_tarfifa,
                                        viajePrincipalViejo.id_viaje,
                                        aux.fechaSalida,
                                        aux.horaSalida,
                                        aux.asiento,
                                        aux.id_disenioDatos,
                                        aux.id_status,
                                        auxCmp2.ordenOrigen,
                                        auxCmp2.ordenDestino,
                                        aux.id_tarfifa
                                    });
                                }
                            }
                            Tarifa TarifaBase = new Tarifa(Comun.Conexion);
                            List<Tarifa> lstTarifaBase = tarifas.listaTarifas.Where(tar => tar.indice.ToString().Contains("0") && tar.id_tipoTerminal.ToString().Contains("1")).ToList();
                            if (lstTarifaBase != null)
                                if (lstTarifaBase.Count > 0)
                                    TarifaBase = lstTarifaBase[0];

                            foreach (Ruta aux in rutanuevaviaje.rutas_intermedias)
                            {
                                Ruta auxCmp1 = null;
                                Tarifa auxCmp2 = null;

                                List<Ruta> lstaux1 = rutaviejoviaje.rutas_intermedias.Where(rut => rut.id_terminalOrigen.Contains(aux.id_terminalOrigen) && rut.id_terminalDestino.Contains(aux.id_terminalDestino)).ToList();
                                if (lstaux1 != null)
                                    if (lstaux1.Count > 0)
                                    {
                                        auxCmp1 = lstaux1[0];
                                        List<Tarifa> lstaux2 = tarifas.listaTarifas.Where(tar => tar.id_terminalXruta.Contains(auxCmp1.id_ruta)).ToList();
                                        if (lstaux2 != null)
                                            if (lstaux2.Count > 0)
                                                auxCmp2 = lstaux2[0];
                                    }

                                if (auxCmp2 != null)
                                {
                                    AgregarDataTableTarifas(new Object[] {
                                      vn.NEWID(Comun.Conexion),
                                      "",
                                      aux.id_ruta,
                                      auxCmp2.id_tarifa,
                                      viajePrincipalViejo.id_viaje,
                                      auxCmp1.id_ruta,
                                      auxCmp2.precioNormal1piso,
                                      auxCmp2.precioInfantil1piso,
                                      auxCmp2.precioTerceraEdad1piso,
                                      auxCmp2.precioEspecial1piso,
                                      auxCmp2.precioNormal2piso,
                                      auxCmp2.precioInfantil2piso,
                                      auxCmp2.precioTerceraEdad2piso,
                                      auxCmp2.precioEspecial2piso,
                                      1
                                    });
                                }
                                else
                                {
                                    AgregarDataTableTarifas(new Object[] {
                                      vn.NEWID(Comun.Conexion),
                                      "",
                                      aux.id_ruta,
                                      vn.NEWID(Comun.Conexion),
                                      viajePrincipalViejo.id_viaje,
                                      "",
                                      TarifaBase.precioNormal1piso,
                                      TarifaBase.precioInfantil1piso,
                                      TarifaBase.precioTerceraEdad1piso,
                                      TarifaBase.precioEspecial1piso,
                                      TarifaBase.precioNormal2piso,
                                      TarifaBase.precioInfantil2piso,
                                      TarifaBase.precioTerceraEdad2piso,
                                      TarifaBase.precioEspecial2piso,
                                      2
                                    });
                                }
                            }
                            vn.modificarRutaViaje(viajePrincipalViejo, viajeprincipal, ref Verificador);
                            if (Verificador == 1)
                            {
                                MessageBox.Show("Datos guardados correctamente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show(RutasFaltantes, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.txt_mensaje.Visible = true;
                this.txt_mensaje.Text = ex.Message;
            }
        }
        private void AgregarDataTableTarifas(Object[] Datos)
        {
            try
            {
                viajeprincipal.lista_tarifasViaje.Rows.Add(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AgregarDataTableCambiosBoletosViaje(Object[] Datos)
        {
            try
            {
                viajeprincipal.lista_BoletosCambio.Rows.Add(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ComprobarRutas(List<Ruta> rutavieja, List<Ruta> rutanueva,ref string RutasFaltantes)
        {
            RutasFaltantes = "Las siguientes subrutas tienen boletos vendidos" + System.Environment.NewLine;
            bool banCmp = true;
            Ruta rutas = new Ruta(Comun.Conexion);
            rutas.rutas_viajes1 = rutavieja;
            rutas.rutas_viajes2 = rutanueva;

            foreach (Ruta aux in rutas.rutas_viajes1)
            {
                if (aux.asientosOcupados > 0)
                {
                    Ruta auxCmp = null;
                    List<Ruta> lstaux = rutas.rutas_viajes2.Where(rut => rut.id_terminalOrigen.Contains(aux.id_terminalOrigen) && rut.id_terminalDestino.Contains(aux.id_terminalDestino)).ToList();
                    if (lstaux != null)
                        if (lstaux.Count > 0)
                            auxCmp = lstaux[0];

                    if (auxCmp == null)
                    {
                        banCmp = false;
                        RutasFaltantes += aux.terminalOrigen + "-" + aux.terminalDestino + System.Environment.NewLine;
                    }
                }
            }
            if (banCmp == false)
                RutasFaltantes += "No se pueden realizar cambios de ruta.";
            return banCmp;
        }

        private void llenarDatos()
        {
            try
            {
                this.txtNombreViaje.Text = this.viajeprincipal.nombre;
                if (this.viajeprincipal.id_tipoViaje == 1)
                {
                    this.rdbtnLineas.Checked = true;
                }
                else if (this.viajeprincipal.id_tipoViaje == 2)
                {
                    this.rdbtnEspecial.Checked = true;
                }

                if (viajeprincipal.lunes)
                    this.chkLunes.Checked = true;
                else
                    this.chkLunes.Checked = false;

                if (viajeprincipal.martes)
                    this.chkMartes.Checked = true;
                else
                    this.chkMartes.Checked = false;

                if (viajeprincipal.miercoles)
                    this.chkMiercoles.Checked = true;
                else
                    this.chkMiercoles.Checked = false;

                if (viajeprincipal.jueves)
                    this.chkJueves.Checked = true;
                else
                    this.chkJueves.Checked = false;

                if (viajeprincipal.viernes)
                    this.chkViernes.Checked = true;
                else
                    this.chkViernes.Checked = false;

                if (viajeprincipal.sabado)
                    this.chkSabado.Checked = true;
                else
                    this.chkSabado.Checked = false;

                if (viajeprincipal.domingo)
                    this.chkDomingo.Checked = true;
                else
                    this.chkDomingo.Checked = false;


                this.dtpFecInicio.Value = this.viajeprincipal.fec_PeriodoIni;
                this.dtpFecFin.Value = this.viajeprincipal.fec_PeriodoFin;

                this.cmbRutas.SelectedValue = this.viajeprincipal.id_ruta;
                this.cmbCamion.SelectedValue = this.viajeprincipal.id_camion;
                this.dtpHora.Value = DateTime.Parse(DateTime.Today.ToShortDateString() + " " + this.viajeprincipal.horario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cmbRutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Ruta ruta = (Ruta)this.cmbRutas.SelectedItem;
                Ruta_Negocio rn = new Ruta_Negocio();
                ruta = rn.Obtener_RutasxIDRuta(ruta);
                this.llenarGridRutasIntermedias(ruta);
            }
            catch (Exception ex)
            {
            }
        }

        private void llenarGridRutasIntermedias(Ruta ruta)
        {
            try
            {
                this.dgvRutasInt.AutoGenerateColumns = false;
                BindingSource binding = new BindingSource();
                binding.DataSource = ruta.rutas_intermedias;
                this.dgvRutasInt.DataSource = binding;
            }
            catch (Exception ex)
            {
            }
        }

        private void cmbRutas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void dtpFecInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.viajeprincipal.id_viaje))
                {
                    if (Convert.ToDateTime(dtpFecInicio.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        MessageBox.Show("No puedes crear una salida menor a " + DateTime.Now.ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpFecInicio.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFecFin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.viajeprincipal.id_viaje))
                {
                    if (Convert.ToDateTime(dtpFecFin.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        MessageBox.Show("No puedes crear una salida menor a " + DateTime.Now.ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpFecFin.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
