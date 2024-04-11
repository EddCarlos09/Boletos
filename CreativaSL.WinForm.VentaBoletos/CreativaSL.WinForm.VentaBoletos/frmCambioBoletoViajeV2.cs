using System;
using System.Collections.Generic;
using MaterialSkin.Controls;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCambioBoletoViajeV2 : MaterialForm
    {
  
        CambioCamion Cambio_Camion = new CambioCamion();
        Ruta inforuta = new Ruta(Comun.Conexion);

        public frmCambioBoletoViajeV2()
        {
            InitializeComponent();
            inicializar();

        }
        private void inicializar()
        {
            this.Txt_LineaViejo.Text = "";
            this.Txt_FechaViejo.Text = "";
            this.Txt_HoraViejo.Text = "";
            this.Txt_AsientosViejo.Text = "";
            this.Txt_AsientosOcupadosViejo.Text = "";
            this.Txt_LineaNuevo.Text = "";
            this.Txt_FechaNuevo.Text = "";
            this.Txt_HoraNuevo.Text = "";
            this.Txt_AsientosNuevo.Text = "";
            this.Txt_AsientosOcupadosNuevo.Text = "";

            CambioCamionBoletos_Negocio cambiocamiones_negocios = new CambioCamionBoletos_Negocio();
            Cambio_Camion.lista_ViajeViejo = new List<CambioCamion>();
            Cambio_Camion.lista_ViajeNuevo = new List<CambioCamion>();
            cambiocamiones_negocios.CargarCombos(Comun.Conexion, ref Cambio_Camion, DtmFechaSalida.Value);

            this.CmbViajeViejo.DataSource = Cambio_Camion.lista_ViajeViejo;
            this.CmbViajeViejo.ValueMember = "IDViajeViejo";
            this.CmbViajeViejo.DisplayMember = "Camion";

            this.CmbViajeNuevo.DataSource = Cambio_Camion.lista_ViajeNuevo;
            this.CmbViajeNuevo.ValueMember = "IDViajeNuevo";
            this.CmbViajeNuevo.DisplayMember = "Camion";

            this.btnGuardar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones() == true)
                {
                    this.CmbViajeViejo.Enabled = false;
                    this.CmbViajeNuevo.Enabled = false;
                    this.btnComprobar.Visible = false;
                    this.btnGuardar.Enabled = true;
                    MessageBox.Show("Para realizar los cambios debe dar click en boton Cambio", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VerifcarMensajeAccion(int Verificador)
        {

            try
            {
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ComprobarRutas(ref string RutasFaltantes)
        {
            RutasFaltantes = "Las siguientes subrutas tienen boletos vendidos y son necesarios para el cambio del viaje" + System.Environment.NewLine;
            bool banCmp = true;
            Ruta rutas = new Ruta(Comun.Conexion);
            rutas.rutas_viajes1 = (List<Ruta>)this.dgvdatosviajeviejo.DataSource;
            rutas.rutas_viajes2 = (List<Ruta>)this.dgvdatosviajenuevo.DataSource;

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
        private bool ComprobarBoletosViajeNumeracionNecesaria(ref string NumerosFaltantes)
        {
            NumerosFaltantes = "Los siguientes asientos no existen en el nuevo viaje y son necesarios para el cambio del viaje" + System.Environment.NewLine;

            bool banCmp = true;
            Boleto boleto = new Boleto(Comun.Conexion);
            boleto.lstBoletos_viajes1 = (List<Boleto>)this.dgvdatosboletosviajeviejo.DataSource;
            boleto.lstBoletos_viajes2 = (List<Boleto>)this.dgvdatosboletosviajenuevo.DataSource;

            foreach (Boleto aux in boleto.lstBoletos_viajes1)
            {
                if (aux.id_status == 2 || aux.id_status == 3)
                {
                    Boleto auxCmp = null;
                    List<Boleto> lstaux = boleto.lstBoletos_viajes2.Where(bol => bol.asiento.ToString().Contains(aux.asiento.ToString())).ToList();
                    if (lstaux != null)
                        if (lstaux.Count > 0)
                            auxCmp = lstaux[0];

                    if (auxCmp == null)
                    {
                        banCmp = false;
                        NumerosFaltantes += aux.asiento + ",";
                    }
                }
            }
            if (banCmp == false)
                NumerosFaltantes += "No se pueden realizar cambios de ruta.";
            return banCmp;
        }

        private bool ComprobarBoletosViajeNumeracionNecesariaLibre(ref string NumerosFaltantesOcupados)
        {
            NumerosFaltantesOcupados = "Los siguientes asientos existen en el nuevo viaje pero se encuentra ocupados y son necesarios para el cambio del viaje" + System.Environment.NewLine;

            bool banCmp = true;
            Boleto boleto = new Boleto(Comun.Conexion);
            boleto.lstBoletos_viajes1 = (List<Boleto>)this.dgvdatosboletosviajeviejo.DataSource;
            boleto.lstBoletos_viajes2 = (List<Boleto>)this.dgvdatosboletosviajenuevo.DataSource;

            foreach (Boleto aux in boleto.lstBoletos_viajes1)
            {
                if (aux.id_status == 2 || aux.id_status == 3)
                {
                    Boleto auxCmp = null;
                    List<Boleto> lstaux = boleto.lstBoletos_viajes2.Where(bol => bol.asiento.ToString().Contains(aux.asiento.ToString()) && bol.id_status.ToString().Contains("0")).ToList();
                    if (lstaux != null)
                        if (lstaux.Count > 0)
                            auxCmp = lstaux[0];

                    if (auxCmp == null)
                    {
                        banCmp = false;
                        NumerosFaltantesOcupados += aux.asiento + ",";
                    }
                }
            }
            if (banCmp == false)
                NumerosFaltantesOcupados += "No se pueden realizar cambios de ruta.";
            return banCmp;
        }
        private bool Validaciones()
        {
            try
            {
                string RutasFaltantes = "";
                string NumerosFaltantes = "";
                string NumerosFaltantesOcupados = "";
                CambioCamion aux_viaje_viejo = (CambioCamion)this.CmbViajeViejo.SelectedItem;
                CambioCamion aux_viaje_nuevo = (CambioCamion)this.CmbViajeNuevo.SelectedItem;

                if (Convert.ToInt32(CmbViajeViejo.SelectedIndex) == 0)
                {
                    this.CmbViajeViejo.Focus();
                    MessageBox.Show("Seleccione el viaje viejo ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (Convert.ToInt32(CmbViajeNuevo.SelectedIndex) == 0)
                {
                    this.CmbViajeNuevo.Focus();
                    MessageBox.Show("Seleccione el viaje nuevo ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (Convert.ToString(CmbViajeViejo.SelectedValue) == Convert.ToString(CmbViajeNuevo.SelectedValue))
                {
                    this.CmbViajeViejo.Focus();
                    MessageBox.Show("No puedes seleccionar el mismo viaje para hacer el cambio ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (Convert.ToInt32(aux_viaje_viejo.IDTipoCamion) != Convert.ToInt32(aux_viaje_nuevo.IDTipoCamion))
                {
                    this.CmbViajeViejo.Focus();
                    MessageBox.Show("Para poder realizar el cambio los dos viajes tienen que ser de la misma linea ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                /*
                if (Convert.ToInt32(this.Txt_AsientosOcupadosNuevo.Text) > 0)
                {
                    this.Txt_AsientosOcupadosNuevo.Focus();
                    MessageBox.Show("El viaje nuevo no puede tener boletos Ocupados ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                */
                if (ComprobarRutas(ref RutasFaltantes) == false)
                {
                    MessageBox.Show(RutasFaltantes, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (ComprobarBoletosViajeNumeracionNecesaria(ref NumerosFaltantes) == false)
                {
                    MessageBox.Show(NumerosFaltantes, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (ComprobarBoletosViajeNumeracionNecesariaLibre(ref NumerosFaltantesOcupados) == false)
                {
                    MessageBox.Show(NumerosFaltantesOcupados, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int Verificador = 0;
                Boleto boleto = new Boleto(Comun.Conexion);
                boleto.lstBoletos_viajes1 = (List<Boleto>)this.dgvdatosboletosviajeviejo.DataSource;
                boleto.lstBoletos_viajes2 = (List<Boleto>)this.dgvdatosboletosviajenuevo.DataSource;

                Ruta rutas = new Ruta(Comun.Conexion);
                rutas.rutas_viajes1 = (List<Ruta>)this.dgvdatosviajeviejo.DataSource;
                rutas.rutas_viajes2 = (List<Ruta>)this.dgvdatosviajenuevo.DataSource;

                CambioCamion aux_viaje_viejo = (CambioCamion)this.CmbViajeViejo.SelectedItem;
                CambioCamion aux_viaje_nuevo = (CambioCamion)this.CmbViajeNuevo.SelectedItem;

                Cambio_Camion.lista_BoletosCambio = new DataTable();
                Cambio_Camion.lista_BoletosCambio.Columns.Add("IDBoleto", typeof(string));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("IDViajeViejo", typeof(string));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("FechaSalidaViejo", typeof(DateTime));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("HoraSalidaViejo", typeof(string));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("AsientoViejo", typeof(int));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("IDDisenioDatosViejo", typeof(string));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("IDStatusViejo", typeof(int));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("OrdenOrigenTerminalViejo", typeof(int));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("OrdenDestinoTerminalViejo", typeof(int));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("IDTarifaViejo", typeof(string));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("IDViajeNuevo", typeof(string));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("FechaSalidaNuevo", typeof(DateTime));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("HoraSalidaNuevo", typeof(string));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("AsientoNuevo", typeof(int));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("IDDisenioDatosNuevo", typeof(string));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("IDStatusNuevo", typeof(int));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("OrdenOrigenTerminalNuevo", typeof(int));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("OrdenDestinoTerminalNuevo", typeof(int));
                Cambio_Camion.lista_BoletosCambio.Columns.Add("IDTarifaNuevo", typeof(string));

                foreach (Boleto aux in boleto.lstBoletos_viajes1)
                {
                    if (aux.id_status == 2 || aux.id_status == 3)
                    {

                        Ruta auxCmp1 = null;
                        List<Ruta> lstaux1 = rutas.rutas_viajes1.Where(rut => rut.id_terminalOrigen.Contains(aux.id_terminalSalida) && rut.id_terminalDestino.Contains(aux.id_terminalDestino)).ToList();
                        if (lstaux1 != null)
                            if (lstaux1.Count > 0)
                                auxCmp1 = lstaux1[0];

                        Ruta auxCmp2 = null;
                        List<Ruta> lstaux2 = rutas.rutas_viajes2.Where(rut => rut.id_terminalOrigen.Contains(aux.id_terminalSalida) && rut.id_terminalDestino.Contains(aux.id_terminalDestino)).ToList();
                        if (lstaux2 != null)
                            if (lstaux2.Count > 0)
                                auxCmp2 = lstaux2[0];

                        AgregarDataTableCambiosBoletosViaje(new Object[] {
                                aux.id_boleto,
                                aux_viaje_viejo.IDViajeViejo,
                                aux_viaje_viejo.FechaSalida,
                                aux_viaje_viejo.HoraSalida,
                                aux.asiento,
                                aux_viaje_viejo.IDDisenioCamion,
                                aux.id_status,
                                auxCmp1.ordenOrigen,
                                auxCmp1.ordenDestino,
                                aux_viaje_viejo.IDTarifa,
                                aux_viaje_nuevo.IDViajeNuevo,
                                aux_viaje_nuevo.FechaSalida,
                                aux_viaje_nuevo.HoraSalida,
                                aux.asiento,
                                aux_viaje_nuevo.IDDisenioCamion,
                                aux.id_status,
                                auxCmp2.ordenOrigen,
                                auxCmp2.ordenDestino,
                                aux_viaje_nuevo.IDTarifa
                            });
                    }
                }

                CambioCamionBoletos_Negocio cambiocamiones_negocios = new CambioCamionBoletos_Negocio();
                cambiocamiones_negocios.CambiarBoletos(Comun.Conexion, Cambio_Camion.lista_BoletosCambio, ref Verificador);
                VerifcarMensajeAccion(Verificador);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AgregarDataTableCambiosBoletosViaje(Object[] Datos)
        {
            try
            {
                Cambio_Camion.lista_BoletosCambio.Rows.Add(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CmbViajeViejo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CambioCamion aux = (CambioCamion)this.CmbViajeViejo.SelectedItem;
                if (aux.IDViajeViejo != "")
                {
                    this.Txt_LineaViejo.Text = aux.Camion.ToString();
                    this.Txt_FechaViejo.Text = aux.FechaSalida.ToShortDateString();
                    this.Txt_HoraViejo.Text = aux.HoraSalida.ToString();
                    this.Txt_AsientosViejo.Text = aux.Asientos.ToString();
                    this.Txt_AsientosOcupadosViejo.Text = aux.AsientosOcupados.ToString();

                    Ruta ruta = new Ruta(Comun.Conexion);
                    ruta.id_ruta = aux.IDRuta;
                    ruta.id_viaje = aux.IDViajeViejo;
                    ruta.fehcha_viaje = aux.FechaSalida;
                    ruta.hora_viaje = aux.HoraSalida;
                    CambioCamionBoletos_Negocio ccb = new CambioCamionBoletos_Negocio();
                    ruta = ccb.Obtener_RutasViajesxIDRutaxFecha(ruta);
                    this.dgvdatosviajeviejo.AutoGenerateColumns = false;
                    this.dgvdatosviajeviejo.DataSource = ruta.rutas_intermedias;

                    Boleto boleto_viejo = new Boleto(Comun.Conexion);
                    boleto_viejo.lstBoletos_viajes1 = new List<Boleto>();
                    ccb.ObtenerBoletosViajesXRutasByOneFecha(Comun.Conexion, ruta, boleto_viejo);

                    this.dgvdatosboletosviajeviejo.AutoGenerateColumns = false;
                    this.dgvdatosboletosviajeviejo.DataSource = boleto_viejo.lstBoletos_viajes1;
                }
                else
                {
                    this.Txt_FechaViejo.Text = "";
                    this.Txt_HoraViejo.Text = "";
                    this.Txt_AsientosViejo.Text = "";
                    this.Txt_AsientosOcupadosViejo.Text = "";

                    this.dgvdatosviajeviejo.AutoGenerateColumns = false;
                    this.dgvdatosviajeviejo.DataSource = null;

                    this.dgvdatosboletosviajeviejo.AutoGenerateColumns = false;
                    this.dgvdatosboletosviajeviejo.DataSource = null;
                }
                this.btnGuardar.Enabled = false;

            }
            catch (Exception ex)
            {
                this.Txt_FechaViejo.Text = "";
                this.Txt_HoraViejo.Text = "";
                this.Txt_AsientosViejo.Text = "";
                this.Txt_AsientosOcupadosViejo.Text = "";

                this.dgvdatosviajeviejo.AutoGenerateColumns = false;
                this.dgvdatosviajeviejo.DataSource = null;
                this.btnGuardar.Enabled = false;
            }
        }

        private void CmbViajeNuevo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CambioCamion aux = (CambioCamion)this.CmbViajeNuevo.SelectedItem;
                if (aux.IDViajeNuevo != "")
                {
                    this.Txt_LineaNuevo.Text = aux.Camion.ToString();
                    this.Txt_FechaNuevo.Text = aux.FechaSalida.ToShortDateString();
                    this.Txt_HoraNuevo.Text = aux.HoraSalida.ToString();
                    this.Txt_AsientosNuevo.Text = aux.Asientos.ToString();
                    this.Txt_AsientosOcupadosNuevo.Text = aux.AsientosOcupados.ToString();

                    Ruta ruta = new Ruta(Comun.Conexion);
                    ruta.id_ruta = aux.IDRuta;
                    ruta.id_viaje = aux.IDViajeViejo;
                    ruta.fehcha_viaje = aux.FechaSalida;
                    ruta.hora_viaje = aux.HoraSalida;

                    CambioCamionBoletos_Negocio ccb = new CambioCamionBoletos_Negocio();
                    ruta = ccb.Obtener_RutasViajesxIDRutaxFecha(ruta);
                    this.dgvdatosviajenuevo.AutoGenerateColumns = false;
                    this.dgvdatosviajenuevo.DataSource = ruta.rutas_intermedias;

                    Boleto boleto_nuevo = new Boleto(Comun.Conexion);
                    boleto_nuevo.lstBoletos_viajes1 = new List<Boleto>();
                    boleto_nuevo.lstBoletos_viajes2 = new List<Boleto>();
                    ccb.ObtenerBoletosViajesXRutasByOneFecha(Comun.Conexion, ruta, boleto_nuevo);
                    boleto_nuevo.lstBoletos_viajes2 = boleto_nuevo.lstBoletos_viajes1;

                    this.dgvdatosboletosviajenuevo.AutoGenerateColumns = false;
                    this.dgvdatosboletosviajenuevo.DataSource = boleto_nuevo.lstBoletos_viajes2;
                }
                else
                {
                    this.Txt_FechaNuevo.Text = "";
                    this.Txt_HoraNuevo.Text = "";
                    this.Txt_AsientosNuevo.Text = "";
                    this.Txt_AsientosOcupadosNuevo.Text = "";

                    this.dgvdatosviajenuevo.AutoGenerateColumns = false;
                    this.dgvdatosviajenuevo.DataSource = null;

                    this.dgvdatosboletosviajenuevo.AutoGenerateColumns = false;
                    this.dgvdatosboletosviajenuevo.DataSource = null;
                }
                this.btnGuardar.Enabled = false;
            }
            catch (Exception ex)
            {
                this.Txt_FechaNuevo.Text = "";
                this.Txt_HoraNuevo.Text = "";
                this.Txt_AsientosNuevo.Text = "";
                this.Txt_AsientosOcupadosNuevo.Text = "";

                this.dgvdatosviajenuevo.AutoGenerateColumns = false;
                this.dgvdatosviajenuevo.DataSource = null;
                this.btnGuardar.Enabled = false;
            }
        }

        #region Metodos Generales
        #endregion

        private void DtmFechaSalida_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(DtmFechaSalida.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
            {
                MessageBox.Show("No puedes mover los boletos a una salida menor que  " + DateTime.Now.ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DtmFechaSalida.Value = DateTime.Now;
            }
            inicializar();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

    }
}
