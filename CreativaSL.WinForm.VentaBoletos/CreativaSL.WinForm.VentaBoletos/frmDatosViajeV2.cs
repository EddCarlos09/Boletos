using System;
using System.Collections.Generic;
using MaterialSkin.Controls;
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
    public partial class frmDatosViajeV2 : MaterialForm
    {
        private Validaciones Val;
        private bool _Exception = true;
        private bool Mod = false;
        private ReportesBoletosViajeHecotours viaje = new ReportesBoletosViajeHecotours();
        public DateTime fechaSalida = DateTime.Now;
        public bool Exception
        {
            get { return _Exception; }
            set { _Exception = value; }
        }

        public frmDatosViajeV2(ReportesBoletosViajeHecotours Datos, DateTime _fechaSalida)
        {
            try
            {
                InitializeComponent();
                viaje = Datos;
                fechaSalida = _fechaSalida;
                Mod = false;
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public frmDatosViajeV2(ReportesBoletosViajeHecotours Datos)
        {
            try
            {
                InitializeComponent();
                viaje = Datos;
                fechaSalida = Datos.FechaV;
                Mod = true;
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Métodos
        private void GuardarDatosViaje()
        {
            try
            {
                int Verificador = 0;
                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                this.ObtenerDatosViaje();
                if (viaje.id_datosViaje != null)
                {
                    Reportes_Negocio.ModificarDatosViaje(Comun.Conexion, viaje, ref Verificador);
                }
                else
                {
                    Reportes_Negocio.GuardarDatosViaje(Comun.Conexion, viaje, ref Verificador);
                }
                this.VerifcarMensajeAccion(Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosViaje()
        {
            try
            {
                Viaje auxViaje = (Viaje)CmbViaje.SelectedItem;
                viaje.IDViaje = auxViaje.id_viaje;
                viaje.FechaV = auxViaje.FechaV;
                viaje.HoraV = auxViaje.HoraV;

                viaje.folio_prestacionServicios1 = txt_folio_prestacion_servicio1.Text;
                viaje.id_chofer1_prestacionServicios1 = CmbChoferes1_prestacion_servicio1.SelectedValue.ToString();
                viaje.id_chofer2_prestacionServicios1 = CmbChoferes2_prestacion_servicio1.SelectedValue.ToString();
                viaje.autobus_prestacionServicios1 = txt_autobus_prestacion_servicio1.Text.ToString();
                viaje.fecha_salida_prestacionServicios1 = Convert.ToDateTime(txt_fechasalida_prestacion_servicio1.Value);
                viaje.hora_salida_prestacionServicios1 = txt_horasalida_prestacion_servicio1.Text;
                viaje.solicitado_por_prestacionServicios1 = txt_solicitadopor_prestacion_servicio1.Text;
                viaje.grupo_prestacionServicios1 = Convert.ToInt32(txt_grupo_prestacion_servicio1.Text);
                viaje.servicio_prestacionServicios1 = txt_servicio_prestacion_servicio1.Text;
                viaje.presentarse_en_prestacionServicios1 = txt_presentarseen_prestacion_servicio1.Text;
                viaje.instrucciones_prestacionServicios1 = txt_instrucciones_prestacion_servicio1.Text;
                viaje.observaciones_prestacionServicios1 = txt_observaciones_prestacion_servicio1.Text;

                viaje.folio_prestacionServicios2 = txt_folio_prestacion_servicio2.Text;
                viaje.solicitado_por_prestacionServicios2 = txt_solicitadopor_prestacion_servicio2.Text;
                viaje.poliza_prestacionServicios2 = txt_poliza_prestacion_servicio2.Text;
                viaje.poliza_fecha1_prestacionServicios2 = Convert.ToDateTime(txt_polizafechainicio_prestacion_servicio2.Value);
                viaje.poliza_fecha2_prestacionServicios2 = Convert.ToDateTime(txt_polizafechafin_prestacion_servicio2.Value);
                viaje.credencial_elector_prestacionServicios2 = txt_credencialelector_prestacion_servicio2.Text;
                viaje.domicilio_prestacionServicios2 = txt_domicilio_prestacion_servicio2.Text;
                viaje.origen_prestacionServicios2 = txt_origen_prestacion_servicio2.Text;
                viaje.destino_prestacionServicios2 = txt_destino_prestacion_servicio2.Text;
                viaje.monto_servicio_prestacionServicios2 = Convert.ToSingle(txt_montoservicio_prestacion_servicio2.Text);
                viaje.monto_servicio_texto_prestacionServicios2 = txt_montoservicioletras_prestacion_servicio2.Text;
                viaje.lugar_salida_prestacionServicios2 = txt_lugarsalida_prestacion_servicio2.Text;
                viaje.fecha_salida_prestacionServicios2 = Convert.ToDateTime(txt_fechasalida_prestacion_servicio2.Value);
                viaje.hora_salida_prestacionServicios2 = txt_horasalida_prestacion_servicio2.Text;
                viaje.numero_personas_prestacionServicios2 = Convert.ToInt32(txt_numeropersonas_prestacion_servicio2.Text);
                viaje.id_chofer1_prestacionServicios2 = CmbChoferes1_prestacion_servicio2.SelectedValue.ToString();
                viaje.id_chofer2_prestacionServicios2 = CmbChoferes2_prestacion_servicio2.SelectedValue.ToString();
                viaje.numero_placa_prestacionServicios2 = txt_numeroplaca_prestacion_servicio2.Text;
                viaje.ruta_contratada_prestacionServicios2 = txt_rutacontrada_prestacion_servicio2.Text;
                viaje.dias_viaje_prestacionServicios2 = Convert.ToInt32(txt_diasviaje_prestacion_servicio2.Text);
                viaje.dia_hora_salida_prestacionServicios2 = txt_diahorasalida_prestacion_servicio2.Text;

                viaje.folio_listapasajeros = txt_folio_listapasajeros.Text;
                viaje.oficina_listapasajeros = txt_oficina_listapasajeros.Text;
                viaje.dia_listapasajeros = Convert.ToInt32(txt_dia_listapasajeros.Text);
                viaje.mes_listapasajeros = Convert.ToInt32(txt_mes_listapasajeros.Text);
                viaje.año_listapasajeros = Convert.ToInt32(txt_año_listapasajeros.Text);
                viaje.carro_listapasajeros = txt_carro_listapasajeros.Text;
                viaje.oficinista_listapasajeros = txt_oficinista_listapasajeros.Text;
                viaje.hora_salida_listapasajeros = txt_horaSalida_listapasajeros.Text;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Inicializar()
        {
            try
            {
                this.CargarCombos();

                if (viaje.IDViaje != null)
                {

                    CmbViaje.SelectedValue = viaje.IDViaje;
                    CmbViaje.Enabled = false;
                    txt_folio_prestacion_servicio1.Enabled = false;
                    txt_folio_prestacion_servicio2.Enabled = false;
                    txt_folio_listapasajeros.Enabled = false;


                    txt_folio_prestacion_servicio1.Text = viaje.folio_prestacionServicios1;
                    CmbChoferes1_prestacion_servicio1.SelectedValue = viaje.id_chofer1_prestacionServicios1;
                    CmbChoferes2_prestacion_servicio1.SelectedValue = viaje.id_chofer2_prestacionServicios1;
                    txt_autobus_prestacion_servicio1.Text = viaje.autobus_prestacionServicios1;
                    txt_fechasalida_prestacion_servicio1.Value = viaje.fecha_salida_prestacionServicios1;
                    txt_horasalida_prestacion_servicio1.Text = viaje.hora_salida_prestacionServicios1;
                    txt_solicitadopor_prestacion_servicio1.Text = viaje.solicitado_por_prestacionServicios1;
                    txt_grupo_prestacion_servicio1.Text = viaje.grupo_prestacionServicios1.ToString();
                    txt_servicio_prestacion_servicio1.Text = viaje.servicio_prestacionServicios1;
                    txt_presentarseen_prestacion_servicio1.Text = viaje.presentarse_en_prestacionServicios1;
                    txt_instrucciones_prestacion_servicio1.Text = viaje.instrucciones_prestacionServicios1;
                    txt_observaciones_prestacion_servicio1.Text = viaje.observaciones_prestacionServicios1;

                    txt_folio_prestacion_servicio2.Text = viaje.folio_prestacionServicios2;
                    txt_solicitadopor_prestacion_servicio2.Text = viaje.solicitado_por_prestacionServicios2;
                    txt_poliza_prestacion_servicio2.Text = viaje.poliza_prestacionServicios2;
                    txt_polizafechainicio_prestacion_servicio2.Value = viaje.poliza_fecha1_prestacionServicios2;
                    txt_polizafechafin_prestacion_servicio2.Value = viaje.poliza_fecha2_prestacionServicios2;
                    txt_credencialelector_prestacion_servicio2.Text = viaje.credencial_elector_prestacionServicios2;
                    txt_domicilio_prestacion_servicio2.Text = viaje.domicilio_prestacionServicios2;
                    txt_origen_prestacion_servicio2.Text = viaje.origen_prestacionServicios2;
                    txt_destino_prestacion_servicio2.Text = viaje.destino_prestacionServicios2;
                    txt_montoservicio_prestacion_servicio2.Text = viaje.monto_servicio_prestacionServicios2.ToString();
                    txt_montoservicioletras_prestacion_servicio2.Text = viaje.monto_servicio_texto_prestacionServicios2;
                    txt_lugarsalida_prestacion_servicio2.Text = viaje.lugar_salida_prestacionServicios2;
                    txt_fechasalida_prestacion_servicio2.Value = viaje.fecha_salida_prestacionServicios2;
                    txt_horasalida_prestacion_servicio2.Text = viaje.hora_salida_prestacionServicios2;
                    txt_numeropersonas_prestacion_servicio2.Text = viaje.numero_personas_prestacionServicios2.ToString();
                    CmbChoferes1_prestacion_servicio2.SelectedValue = viaje.id_chofer1_prestacionServicios2;
                    CmbChoferes2_prestacion_servicio2.SelectedValue = viaje.id_chofer2_prestacionServicios2;
                    txt_numeroplaca_prestacion_servicio2.Text = viaje.numero_placa_prestacionServicios2;
                    txt_rutacontrada_prestacion_servicio2.Text = viaje.ruta_contratada_prestacionServicios2;
                    txt_diasviaje_prestacion_servicio2.Text = viaje.dias_viaje_prestacionServicios2.ToString();
                    txt_diahorasalida_prestacion_servicio2.Text = viaje.dia_hora_salida_prestacionServicios2;

                    txt_folio_listapasajeros.Text = viaje.folio_listapasajeros;
                    txt_oficina_listapasajeros.Text = viaje.oficina_listapasajeros;
                    txt_dia_listapasajeros.Text = viaje.dia_listapasajeros.ToString();
                    txt_mes_listapasajeros.Text = viaje.mes_listapasajeros.ToString();
                    txt_año_listapasajeros.Text = viaje.año_listapasajeros.ToString();
                    txt_carro_listapasajeros.Text = viaje.carro_listapasajeros;
                    txt_oficinista_listapasajeros.Text = viaje.oficinista_listapasajeros;
                    txt_horaSalida_listapasajeros.Text = viaje.hora_salida_listapasajeros;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarCombos()
        {
            try
            {
                this.viaje.lista_Viaje = new List<Viaje>();

                this.viaje.lstChoferes1_prestacionServicios1 = new List<Chofer>();
                this.viaje.lstChoferes1_prestacionServicios2 = new List<Chofer>();
                this.viaje.lstChoferes2_prestacionServicios1 = new List<Chofer>();
                this.viaje.lstChoferes2_prestacionServicios2 = new List<Chofer>();

                Reportes_Negocio Reportes_Negocio = new Reportes_Negocio();
                Reportes_Negocio.CargarComboChoferes(Comun.Conexion, ref this.viaje);
                if (Mod == false)
                    Reportes_Negocio.CargarComboViaje(Comun.Conexion, ref viaje, fechaSalida);
                else
                    Reportes_Negocio.CargarComboViajeModificar(Comun.Conexion, ref viaje, fechaSalida, viaje.IDViaje);

                this.CmbChoferes1_prestacion_servicio1.DataSource = this.viaje.lstChoferes1_prestacionServicios1;
                this.CmbChoferes1_prestacion_servicio1.ValueMember = "IDChofer";
                this.CmbChoferes1_prestacion_servicio1.DisplayMember = "Nombre";

                this.CmbChoferes1_prestacion_servicio2.DataSource = this.viaje.lstChoferes1_prestacionServicios2;
                this.CmbChoferes1_prestacion_servicio2.ValueMember = "IDChofer";
                this.CmbChoferes1_prestacion_servicio2.DisplayMember = "Nombre";

                this.CmbChoferes2_prestacion_servicio1.DataSource = this.viaje.lstChoferes2_prestacionServicios1;
                this.CmbChoferes2_prestacion_servicio1.ValueMember = "IDChofer";
                this.CmbChoferes2_prestacion_servicio1.DisplayMember = "Nombre";

                this.CmbChoferes2_prestacion_servicio2.DataSource = this.viaje.lstChoferes2_prestacionServicios2;
                this.CmbChoferes2_prestacion_servicio2.ValueMember = "IDChofer";
                this.CmbChoferes2_prestacion_servicio2.DisplayMember = "Nombre";

                this.CmbViaje.DataSource = this.viaje.lista_Viaje;
                this.CmbViaje.ValueMember = "id_viaje";
                this.CmbViaje.DisplayMember = "NombreViaje";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void VerifcarMensajeAccion(int Verificador)
        {
            try
            {
                if (Verificador == 1)
                {
                    Val.Mensaje("Los datos se guardaron correctamente", this);
                    this.Exception = false;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarCampos()
        {
            try
            {
                Val = new Validaciones();
                if (this.CmbViaje.SelectedIndex == 0)
                {
                    MessageBox.Show("Debes seleccionar el viaje", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (this.txt_folio_prestacion_servicio1.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir un folio de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_folio_prestacion_servicio1.Focus();
                    return false;
                }
                if (this.CmbChoferes1_prestacion_servicio1.SelectedIndex == 0)
                {
                    MessageBox.Show("Debes seleccionar el chofer1 de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CmbChoferes1_prestacion_servicio1.Focus();
                    return false;
                }
                if (this.CmbChoferes2_prestacion_servicio1.SelectedIndex == 0)
                {
                    MessageBox.Show("Debes seleccionar el chofer2 de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CmbChoferes2_prestacion_servicio1.Focus();
                    return false;
                }
                if (this.txt_autobus_prestacion_servicio1.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el autobus de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_autobus_prestacion_servicio1.Focus();
                    return false;
                }
                if (this.txt_horasalida_prestacion_servicio1.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir la hora salida de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_horasalida_prestacion_servicio1.Focus();
                    return false;
                }
                if (this.txt_solicitadopor_prestacion_servicio1.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir la solicitador por de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_solicitadopor_prestacion_servicio1.Focus();
                    return false;
                }
                if (this.txt_grupo_prestacion_servicio1.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el numero del grupo de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_grupo_prestacion_servicio1.Focus();
                    return false;
                }
                if (this.txt_servicio_prestacion_servicio1.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el servicio de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_servicio_prestacion_servicio1.Focus();
                    return false;
                }
                if (this.txt_presentarseen_prestacion_servicio1.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el presentarse en de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_presentarseen_prestacion_servicio1.Focus();
                    return false;
                }
                if (this.txt_instrucciones_prestacion_servicio1.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir las instrucciones de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_instrucciones_prestacion_servicio1.Focus();
                    return false;
                }
                if (this.txt_observaciones_prestacion_servicio1.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir la observaciones de la prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_observaciones_prestacion_servicio1.Focus();
                    return false;
                }




                if (this.txt_folio_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir un folio del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_folio_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_solicitadopor_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el solicitado por del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_solicitadopor_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_poliza_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir la poliza del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_poliza_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_credencialelector_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir la credencial elector del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_credencialelector_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_domicilio_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el domicilio del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_domicilio_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_origen_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el origen del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_origen_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_destino_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el destino del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_destino_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_montoservicio_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el monto del servicio del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_montoservicio_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_montoservicioletras_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el monto del servicio letras del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_montoservicioletras_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_lugarsalida_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el lugar de salida del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_lugarsalida_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_horasalida_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir la hora de salida del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_horasalida_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_numeropersonas_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el numero de personas del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_horasalida_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.CmbChoferes1_prestacion_servicio2.SelectedIndex == 0)
                {
                    MessageBox.Show("Debes seleccionar el chofer1 del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CmbChoferes1_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.CmbChoferes2_prestacion_servicio2.SelectedIndex == 0)
                {
                    MessageBox.Show("Debes seleccionar el chofer2 del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CmbChoferes2_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_numeroplaca_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el numero de placa del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_numeroplaca_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_rutacontrada_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir la ruta contratada del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_rutacontrada_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_diasviaje_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir los dias del viaje del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_diasviaje_prestacion_servicio2.Focus();
                    return false;
                }
                if (this.txt_diahorasalida_prestacion_servicio2.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el dia y hora de salida del contrato de prestación de servicios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_diahorasalida_prestacion_servicio2.Focus();
                    return false;
                }


                if (this.txt_folio_listapasajeros.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir un folio de la lista de pasajeros", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_folio_listapasajeros.Focus();
                    return false;
                }
                if (this.txt_oficina_listapasajeros.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir la oficina de la lista de pasajeros", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_oficina_listapasajeros.Focus();
                    return false;
                }
                if (this.txt_dia_listapasajeros.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el dia de la lista de pasajeros", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_dia_listapasajeros.Focus();
                    return false;
                }
                if (this.txt_mes_listapasajeros.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el mes de la lista de pasajeros", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_mes_listapasajeros.Focus();
                    return false;
                }
                if (this.txt_año_listapasajeros.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el año de la lista de pasajeros", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_año_listapasajeros.Focus();
                    return false;
                }
                if (this.txt_carro_listapasajeros.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el carro de la lista de pasajeros", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_carro_listapasajeros.Focus();
                    return false;
                }
                if (this.txt_oficinista_listapasajeros.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir el oficinista de la lista de pasajeros", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_oficinista_listapasajeros.Focus();
                    return false;
                }
                if (this.txt_horaSalida_listapasajeros.Text.Equals(""))
                {
                    MessageBox.Show("Debes escribir la hora salida de la lista de pasajeros", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_horaSalida_listapasajeros.Focus();
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

        #region Eventos
        private void txt_folio_prestacion_servicio1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_autobus_prestacion_servicio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_horasalida_prestacion_servicio1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_solicitadopor_prestacion_servicio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_grupo_prestacion_servicio1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_servicio_prestacion_servicio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                //Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_presentarseen_prestacion_servicio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_instrucciones_prestacion_servicio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_observaciones_prestacion_servicio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_folio_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_solicitadopor_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_poliza_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_credencialelector_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_domicilio_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                //Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_origen_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_destino_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_montoservicio_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.PermitirSoloNumerosDecimales(e, txt_montoservicio_prestacion_servicio2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_montoservicioletras_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_lugarsalida_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_horasalida_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_numeropersonas_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_numeroplaca_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_rutacontrada_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                //Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_diasviaje_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_diahorasalida_prestacion_servicio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txt_folio_listapasajeros_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_oficina_listapasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_dia_listapasajeros_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_mes_listapasajeros_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_año_listapasajeros_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_carro_listapasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_oficinista_listapasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_horaSalida_listapasajeros_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos())
                {
                    this.GuardarDatosViaje();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        private void CmbViaje_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!CmbViaje.SelectedValue.ToString().Equals(""))
                {
                    Viaje auxViaje = (Viaje)CmbViaje.SelectedItem;
                    ReportesBoletosViajeHecotours viaje_aux = new ReportesBoletosViajeHecotours();
                    Reportes_Negocio ReportesNegocio = new Reportes_Negocio();
                    ReportesNegocio.obtenerDatosBaseViajes(Comun.Conexion, ref viaje_aux, auxViaje);
                    txt_folio_prestacion_servicio1.Text = viaje_aux.folio_prestacionServicios1;
                    CmbChoferes1_prestacion_servicio1.SelectedValue = viaje_aux.id_chofer1_prestacionServicios1;
                    CmbChoferes2_prestacion_servicio1.SelectedValue = viaje_aux.id_chofer2_prestacionServicios1;
                    txt_autobus_prestacion_servicio1.Text = viaje_aux.autobus_prestacionServicios1;
                    txt_fechasalida_prestacion_servicio1.Value = viaje_aux.fecha_salida_prestacionServicios1;
                    txt_horasalida_prestacion_servicio1.Text = viaje_aux.hora_salida_prestacionServicios1;
                    txt_solicitadopor_prestacion_servicio1.Text = viaje_aux.solicitado_por_prestacionServicios1;
                    txt_grupo_prestacion_servicio1.Text = viaje_aux.grupo_prestacionServicios1.ToString();
                    txt_servicio_prestacion_servicio1.Text = viaje_aux.servicio_prestacionServicios1;
                    txt_presentarseen_prestacion_servicio1.Text = viaje_aux.presentarse_en_prestacionServicios1;
                    txt_instrucciones_prestacion_servicio1.Text = viaje_aux.instrucciones_prestacionServicios1;
                    txt_observaciones_prestacion_servicio1.Text = viaje_aux.observaciones_prestacionServicios1;

                    txt_folio_prestacion_servicio2.Text = viaje_aux.folio_prestacionServicios2;
                    txt_solicitadopor_prestacion_servicio2.Text = viaje_aux.solicitado_por_prestacionServicios2;
                    txt_poliza_prestacion_servicio2.Text = viaje_aux.poliza_prestacionServicios2;
                    txt_polizafechainicio_prestacion_servicio2.Value = viaje_aux.poliza_fecha1_prestacionServicios2;
                    txt_polizafechafin_prestacion_servicio2.Value = viaje_aux.poliza_fecha2_prestacionServicios2;
                    txt_credencialelector_prestacion_servicio2.Text = viaje_aux.credencial_elector_prestacionServicios2;
                    txt_domicilio_prestacion_servicio2.Text = viaje_aux.domicilio_prestacionServicios2;
                    txt_origen_prestacion_servicio2.Text = viaje_aux.origen_prestacionServicios2;
                    txt_destino_prestacion_servicio2.Text = viaje_aux.destino_prestacionServicios2;
                    txt_montoservicio_prestacion_servicio2.Text = viaje_aux.monto_servicio_prestacionServicios2.ToString();
                    txt_montoservicioletras_prestacion_servicio2.Text = viaje_aux.monto_servicio_texto_prestacionServicios2;
                    txt_lugarsalida_prestacion_servicio2.Text = viaje_aux.lugar_salida_prestacionServicios2;
                    txt_fechasalida_prestacion_servicio2.Value = viaje_aux.fecha_salida_prestacionServicios2;
                    txt_horasalida_prestacion_servicio2.Text = viaje_aux.hora_salida_prestacionServicios2;
                    txt_numeropersonas_prestacion_servicio2.Text = viaje_aux.numero_personas_prestacionServicios2.ToString();
                    CmbChoferes1_prestacion_servicio2.SelectedValue = viaje_aux.id_chofer1_prestacionServicios2;
                    CmbChoferes2_prestacion_servicio2.SelectedValue = viaje_aux.id_chofer2_prestacionServicios2;
                    txt_numeroplaca_prestacion_servicio2.Text = viaje_aux.numero_placa_prestacionServicios2;
                    txt_rutacontrada_prestacion_servicio2.Text = viaje_aux.ruta_contratada_prestacionServicios2;
                    txt_diasviaje_prestacion_servicio2.Text = viaje_aux.dias_viaje_prestacionServicios2.ToString();
                    txt_diahorasalida_prestacion_servicio2.Text = viaje_aux.dia_hora_salida_prestacionServicios2;

                    txt_folio_listapasajeros.Text = viaje_aux.folio_listapasajeros;
                    txt_oficina_listapasajeros.Text = viaje_aux.oficina_listapasajeros;
                    txt_dia_listapasajeros.Text = viaje_aux.dia_listapasajeros.ToString();
                    txt_mes_listapasajeros.Text = viaje_aux.mes_listapasajeros.ToString();
                    txt_año_listapasajeros.Text = viaje_aux.año_listapasajeros.ToString();
                    txt_carro_listapasajeros.Text = viaje_aux.carro_listapasajeros;
                    txt_oficinista_listapasajeros.Text = viaje_aux.oficinista_listapasajeros;
                    txt_horaSalida_listapasajeros.Text = viaje_aux.hora_salida_listapasajeros;
                }
                else
                {
                    txt_folio_prestacion_servicio1.Text = "";
                    CmbChoferes1_prestacion_servicio1.SelectedValue = "";
                    CmbChoferes2_prestacion_servicio1.SelectedValue = "";
                    txt_autobus_prestacion_servicio1.Text = "";
                    txt_fechasalida_prestacion_servicio1.Value = DateTime.Now;
                    txt_horasalida_prestacion_servicio1.Text = "";
                    txt_solicitadopor_prestacion_servicio1.Text = "";
                    txt_grupo_prestacion_servicio1.Text = "0";
                    txt_servicio_prestacion_servicio1.Text = "";
                    txt_presentarseen_prestacion_servicio1.Text = "";
                    txt_instrucciones_prestacion_servicio1.Text = "";
                    txt_observaciones_prestacion_servicio1.Text = "";

                    txt_folio_prestacion_servicio2.Text = "";
                    txt_solicitadopor_prestacion_servicio2.Text = "";
                    txt_poliza_prestacion_servicio2.Text = "";
                    txt_polizafechainicio_prestacion_servicio2.Value = DateTime.Now;
                    txt_polizafechafin_prestacion_servicio2.Value = DateTime.Now;
                    txt_credencialelector_prestacion_servicio2.Text = "";
                    txt_domicilio_prestacion_servicio2.Text = "";
                    txt_origen_prestacion_servicio2.Text = "";
                    txt_destino_prestacion_servicio2.Text = "";
                    txt_montoservicio_prestacion_servicio2.Text = "0.0";
                    txt_montoservicioletras_prestacion_servicio2.Text = "";
                    txt_lugarsalida_prestacion_servicio2.Text = "";
                    txt_fechasalida_prestacion_servicio2.Value = DateTime.Now;
                    txt_horasalida_prestacion_servicio2.Text = "";
                    txt_numeropersonas_prestacion_servicio2.Text = "0";
                    CmbChoferes1_prestacion_servicio2.SelectedValue = "";
                    CmbChoferes2_prestacion_servicio2.SelectedValue = "";
                    txt_numeroplaca_prestacion_servicio2.Text = "";
                    txt_rutacontrada_prestacion_servicio2.Text = "";
                    txt_diasviaje_prestacion_servicio2.Text = "0";
                    txt_diahorasalida_prestacion_servicio2.Text = "";

                    txt_folio_listapasajeros.Text = "";
                    txt_oficina_listapasajeros.Text = "";
                    txt_dia_listapasajeros.Text = "0";
                    txt_mes_listapasajeros.Text = "0";
                    txt_año_listapasajeros.Text = "0";
                    txt_carro_listapasajeros.Text = "";
                    txt_oficinista_listapasajeros.Text = "";
                    txt_horaSalida_listapasajeros.Text = "";
                }
            }
            catch (Exception ex)
            {
                txt_folio_prestacion_servicio1.Text = "";
                CmbChoferes1_prestacion_servicio1.SelectedValue = "";
                CmbChoferes2_prestacion_servicio1.SelectedValue = "";
                txt_autobus_prestacion_servicio1.Text = "";
                txt_fechasalida_prestacion_servicio1.Value = DateTime.Now;
                txt_horasalida_prestacion_servicio1.Text = "";
                txt_solicitadopor_prestacion_servicio1.Text = "";
                txt_grupo_prestacion_servicio1.Text = "0";
                txt_servicio_prestacion_servicio1.Text = "";
                txt_presentarseen_prestacion_servicio1.Text = "";
                txt_instrucciones_prestacion_servicio1.Text = "";
                txt_observaciones_prestacion_servicio1.Text = "";

                txt_folio_prestacion_servicio2.Text = "";
                txt_solicitadopor_prestacion_servicio2.Text = "";
                txt_poliza_prestacion_servicio2.Text = "";
                txt_polizafechainicio_prestacion_servicio2.Value = DateTime.Now;
                txt_polizafechafin_prestacion_servicio2.Value = DateTime.Now;
                txt_credencialelector_prestacion_servicio2.Text = "";
                txt_domicilio_prestacion_servicio2.Text = "";
                txt_origen_prestacion_servicio2.Text = "";
                txt_destino_prestacion_servicio2.Text = "";
                txt_montoservicio_prestacion_servicio2.Text = "0.0";
                txt_montoservicioletras_prestacion_servicio2.Text = "";
                txt_lugarsalida_prestacion_servicio2.Text = "";
                txt_fechasalida_prestacion_servicio2.Value = DateTime.Now;
                txt_horasalida_prestacion_servicio2.Text = ""; ;
                txt_numeropersonas_prestacion_servicio2.Text = "";
                CmbChoferes1_prestacion_servicio2.SelectedValue = "";
                CmbChoferes2_prestacion_servicio2.SelectedValue = "";
                txt_numeroplaca_prestacion_servicio2.Text = "";
                txt_rutacontrada_prestacion_servicio2.Text = "";
                txt_diasviaje_prestacion_servicio2.Text = "0";
                txt_diahorasalida_prestacion_servicio2.Text = "";

                txt_folio_listapasajeros.Text = "";
                txt_oficina_listapasajeros.Text = "";
                txt_dia_listapasajeros.Text = "0";
                txt_mes_listapasajeros.Text = "0";
                txt_año_listapasajeros.Text = "0";
                txt_carro_listapasajeros.Text = "";
                txt_oficinista_listapasajeros.Text = "";
                txt_horaSalida_listapasajeros.Text = "";

            }
        }

        private void frmDatosViaje_Load(object sender, EventArgs e)
        {

        }

    }
}
