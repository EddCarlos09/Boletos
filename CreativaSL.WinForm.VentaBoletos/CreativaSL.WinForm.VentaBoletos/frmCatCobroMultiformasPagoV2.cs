using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.LibControls.WinForms;
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
using MaterialSkin;
using MaterialSkin.Controls;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;


namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCatCobroMultiFormasPagoV2 : MaterialForm
    {
        #region Variables

        private Validaciones Val;
        private CultureInfo provider = CultureInfo.CurrentCulture;
        private bool banSalir = false;
        private float Total = 0F;
        private float TotalPagar = 0F;
        private float PagoEfectivo = 0F;
        private float PagoMonedero = 0F;
        private float PagoTarjeta = 0F;
        private float PagoTransferencia = 0F;
        private FormaPago DatosTarjeta = new FormaPago();
        private FormaPago DatosTransferencia = new FormaPago();
        private float Cambio = 0F;
        private float Pendiente = 0F;
        private float MonederoCliente = 0F;
        private float NuevoMontoMonedero = 0F;
        private string Cliente;
        private int SegundosTiempoVenta = 0;
        private DateTime TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
        private bool _stopTiempoVenta = false;
        private int TipoForm = 0;
        private V2Cliente clienteV2;

        #endregion
        #region Constructor
        public frmCatCobroMultiFormasPagoV2(float total, float pagar, float pendiente, float monederoCliente, string cliente, float nuevoMontoMonedero, V2Cliente clienteV2)
        {
            InitializeComponent();
            Total = total;
            TotalPagar = pagar;
            MonederoCliente = monederoCliente;
            Cliente = cliente;
            NuevoMontoMonedero = nuevoMontoMonedero;
            Pendiente = pendiente;
            this.clienteV2 = clienteV2;
            loadMaterial(this);
            Inicializar();
        }
        public frmCatCobroMultiFormasPagoV2(float total, float pagar, float pendiente, float monederoCliente, string cliente, float nuevoMontoMonedero)
        {
            InitializeComponent();
            Total = total;
            TotalPagar = pagar;
            MonederoCliente = monederoCliente;
            Cliente = cliente;
            NuevoMontoMonedero = nuevoMontoMonedero;
            Pendiente = pendiente;
            Inicializar();
            loadMaterial(this);
        }
        public frmCatCobroMultiFormasPagoV2(float total, float pagar, float pendiente, float monederoCliente, string cliente, float nuevoMontoMonedero, int tipo)
        {
            InitializeComponent();
            Total = total;
            TotalPagar = pagar;
            MonederoCliente = monederoCliente;
            Cliente = cliente;
            NuevoMontoMonedero = nuevoMontoMonedero;
            Pendiente = pendiente;
            TipoForm = tipo;
            Inicializar();
            loadMaterial(this);
        }
        public frmCatCobroMultiFormasPagoV2()
        {
            InitializeComponent();

            loadMaterial(this);
        }
        #endregion

        #region Métodos

        private void Inicializar()
        {
            try
            {
                this.Txt_Total.Text = string.Format("{0:c}", Total);
                this.Txt_Pagar.Text = string.Format("{0:c}", TotalPagar);
                this.Txt_Pendiente.Text = string.Format("{0:c}", Pendiente);
                this.Txt_PagoEfectivo.Text = string.Format("{0:c}", PagoEfectivo);
                this.txtPagoTarjeta.Text = string.Format("{0:c}", PagoEfectivo);
                this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                this.txtPagoTransferencia.Text = string.Format("{0:c}", PagoTransferencia);
                this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                this.TxtNombreCliente.Text = this.Cliente;
                this.Txt_NewMonedero.Text = string.Format("{0:c}", NuevoMontoMonedero);
                this.Txt_Monedero.Text = string.Format("{0:c}", MonederoCliente);
                if (MonederoCliente > 0.0)
                {
                    this.Txt_PagoMonedero.ReadOnly = false;
                }
                else
                {
                    this.Txt_PagoMonedero.ReadOnly = true;
                }
                this.DrawCambio();
                if (this.TipoForm == 1)
                {
                    //this.Txt_PagoEfectivo.Enabled = false;
                    this.Txt_PagoMonedero.Enabled = false;
                    this.txtPagoTarjeta.Enabled = false;
                    this.chkTarjeta.Enabled = false;
                }
                else
                {
                    this.ActiveControl = this.Txt_PagoEfectivo;
                    this.Txt_PagoEfectivo.Focus();
                    this.Txt_PagoEfectivo.SelectAll();
                }
                /*
                if (Pendiente > 0.0F)
                {
                    this.chkTarjeta.Enabled = false;
                    this.chkTransferencia.Enabled = false;
                }
                */
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private float ObtenerPagoEfectivo()
        {
            try
            {
                float pEfect = 0F;
                float.TryParse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency, provider, out pEfect);
                return pEfect;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private float ObtenerPagoMonedero()
        {
            try
            {
                float pMoned = 0F;
                float.TryParse(this.Txt_PagoMonedero.Text, NumberStyles.Currency, provider, out pMoned);
                return pMoned;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private float ObtenerPagoTarjeta()
        {
            try
            {
                float pTarjeta = 0F;
                float.TryParse(this.txtPagoTarjeta.Text, NumberStyles.Currency, provider, out pTarjeta);
                return pTarjeta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private float ObtenerPagoTotal()
        {
            try
            {
                return this.ObtenerPagoEfectivo()
                    + this.ObtenerPagoMonedero()
                    + this.ObtenerPagoTarjeta()
                    + this.ObtenerPagoTransferencia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private float ObtenerPagoTransferencia()
        {
            try
            {
                float pTransferencia = 0F;
                float.TryParse(this.txtPagoTransferencia.Text, NumberStyles.Currency, provider, out pTransferencia);
                return pTransferencia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private float ObtenerCambio()
        {
            try
            {
                return TotalPagar - this.GetTotalPago();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private float GetTotalPago()
        {
            try
            {
                return this.ObtenerPagoEfectivo() + this.ObtenerPagoMonedero() + this.ObtenerPagoTarjeta() + this.ObtenerPagoTransferencia();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarFormasDePago()
        {
            try
            {
                float PagoTotal = this.ObtenerPagoTotal();
                float PagoEfectivo = this.ObtenerPagoEfectivo();
                if ((PagoTotal - PagoEfectivo) > TotalPagar)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarPagoMonedero(float pagoMon)
        {
            try
            {
                bool resultado = false;
                if (pagoMon > MonederoCliente)
                    resultado = false;
                else
                    resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DrawCambio()
        {
            try
            {
                //float pMon = 0F, pTarj = 0F, pTransf = 0F, cambioPago = 0F;
                float cambioPago = 0F;
                //pMon = this.ObtenerPagoMonedero();
                //pTarj = this.ObtenerPagoTarjeta();
                //pTransf = this.ObtenerPagoTransferencia();
                //if (!this.ValidarPagoMonedero(pMon))
                //    this.Txt_PagoMonedero.Text = string.Format("{0:c}", 0);
                cambioPago = this.ObtenerCambio();
                if (cambioPago <= 0)
                {
                    this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                    this.Txt_Cambio.Text = string.Format("{0:c}", cambioPago * -1);
                    this.materialLabel14.Text = "Cambio:";
                }
                else
                {
                    this.Txt_Cambio.BackColor = Color.OrangeRed;
                    this.Txt_Cambio.Text = string.Format("{0:c}", cambioPago);
                    this.materialLabel14.Text = "  Debe:";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatos()
        {
            try
            {
                this.PagoEfectivo = this.ObtenerPagoEfectivo();
                this.PagoMonedero = this.ObtenerPagoMonedero();
                this.PagoTarjeta = this.ObtenerPagoTarjeta();
                this.PagoTransferencia = this.ObtenerPagoTransferencia();
                this.Cambio = this.ObtenerCambio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Métodos ObtenerPropiedades
        public float getPago()
        {
            return (PagoEfectivo + PagoMonedero + PagoTarjeta + PagoTransferencia);
        }
        public float getPagoMonedero()
        {
            return (PagoMonedero);
        }
        public float getPagoEfectivo()
        {
            return PagoEfectivo;
        }
        public float getPagoTarjeta()
        {
            return PagoTarjeta;
        }
        public float getPagoTransferencia()
        {
            return PagoTransferencia;
        }
        public float getCambio()
        {
            return Cambio;
        }
        public float getTotalPagar()
        {
            return TotalPagar;
        }
        public bool getbanSalir()
        {
            return banSalir;
        }
        public float getPendiente()
        {
            return Pendiente;
        }
        public FormaPago getDatosTarjeta()
        {
            return DatosTarjeta;
        }
        public FormaPago getDatosTransferencia()
        {
            return DatosTransferencia;
        }
        #endregion
        #region Control de Tiempo de venta
        private void backgroundWorkerVenta_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (this.SegundosTiempoVenta >= 180)
                {
                    TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
                }
                else if (_stopTiempoVenta == false)
                {
                    this.SegundosTiempoVenta = SegundosTiempoVenta + 1;
                    TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
                    TiempoVenta = TiempoVenta.AddSeconds(180);
                    TiempoVenta = TiempoVenta.AddSeconds(this.SegundosTiempoVenta * -1);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void backgroundWorkerVenta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.Txt_TiempoVenta.Text = this.TiempoVenta.ToString("mm:ss");
                if (this.SegundosTiempoVenta >= 180)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema tiene que Cerrarse, no se cuenta con internet", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }
        }
        private void timerVenta_Tick(object sender, EventArgs e)
        {
            try
            {

                if (!this.backgroundWorkerVenta.IsBusy)
                    this.backgroundWorkerVenta.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema tiene que Cerrarse, no se cuenta con internet", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }
        }
        #endregion  
        #endregion
        #region Eventos
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }
        }
        private void btn_Cobrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarFormasDePago())
                {
                    if (ValidarPagoMonedero(ObtenerPagoMonedero()))
                    {
                        if (this.GetTotalPago() >= TotalPagar)
                        {
                            this.ObtenerDatos();
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Debe Cubrir el monto a pagar", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un monto Monedero válido", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("La suma de pago Monedero, pago Tarjeta y pago Transferencia no debe ser mayor al total a pagar.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                Val = new Validaciones();
                Val.PermitirSoloNumerosDecimales(e, txt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Txt_Pago_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.DrawCambio();
                if (e.KeyCode == Keys.Enter)
                {
                    //if ((PagoEfectivo + PagoMonedero) >= TotalPagar)
                    //{
                    //    this.DialogResult = DialogResult.Cancel;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Debe Cubrir el monto a pagar", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkTarjeta.Checked)
                {
                    this.DatosTarjeta.monto = TotalPagar;
                    frmDatosTarjeta dt = new frmDatosTarjeta(DatosTarjeta, 0);
                    dt.ShowDialog();
                    dt.Dispose();
                    if (dt.DialogResult == DialogResult.OK)
                    {
                        this.DatosTarjeta = dt.datos;
                        this.PagoTarjeta = DatosTarjeta.monto;
                        this.txtPagoTarjeta.Text = string.Format("{0:c}", DatosTarjeta.monto);
                        this.DrawCambio();
                    }
                    else
                    {
                        this.txtPagoTarjeta.Text = string.Format("{0:c}", 0);
                        this.PagoTarjeta = 0F;
                        this.DatosTarjeta = new FormaPago();
                        this.DrawCambio();
                        this.chkTarjeta.Checked = false;
                    }
                }
                else
                {
                    this.txtPagoTarjeta.Text = string.Format("{0:c}", 0);
                    this.PagoTarjeta = 0F;
                    this.DatosTarjeta = new FormaPago();
                    this.DrawCambio();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void Txt_PagoEfectivo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                decimal aux = 0;
                decimal.TryParse(txt.Text, NumberStyles.Currency, provider, out aux);
                txt.Text = string.Format("{0:c}", aux);
                this.DrawCambio();
            }
            catch (Exception ex)
            {
            }
        }
        private void Txt_PagoEfectivo_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox aux = (TextBox)sender;
                this.ActiveControl = aux;
                aux.Focus();
                aux.SelectAll();
            }
            catch (Exception)
            {
            }
        }
        private void chkTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkTransferencia.Checked)
                {
                    this.DatosTransferencia.monto = TotalPagar;
                    frmDatosTransferencia dt = new frmDatosTransferencia(DatosTransferencia, 0);
                    dt.ShowDialog();
                    dt.Dispose();
                    if (dt.DialogResult == DialogResult.OK)
                    {
                        this.DatosTransferencia = dt.datos;
                        this.PagoTransferencia = DatosTransferencia.monto;
                        this.txtPagoTransferencia.Text = string.Format("{0:c}", DatosTransferencia.monto);
                        this.DrawCambio();
                    }
                    else
                    {
                        this.txtPagoTransferencia.Text = string.Format("{0:c}", 0);
                        this.PagoTransferencia = 0F;
                        this.DatosTransferencia = new FormaPago();
                        this.DrawCambio();
                        this.chkTransferencia.Checked = false;
                    }
                }
                else
                {
                    this.txtPagoTransferencia.Text = string.Format("{0:c}", 0);
                    this.PagoTransferencia = 0F;
                    this.DatosTransferencia = new FormaPago();
                    this.DrawCambio();
                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

 
    }
}
