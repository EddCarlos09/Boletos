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
    public partial class frmCatCobroV2 : MaterialForm
    {
        private Validaciones Val;
        private CultureInfo provider = CultureInfo.CurrentCulture;
        private bool banSalir = true;
        private float Total = 0F;
        private float TotalPagar = 0F;
        private float PagoEfectivo = 0F;
        private float PagoMonedero = 0F;
        private float Cambio = 0F;
        private float Pendiente = 0F;
        private float MonederoCliente = 0F;
        private float NuevoMontoMonedero = 0F;
        private string Cliente;
        private int SegundosTiempoVenta = 0;
        private DateTime TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
        private bool _stopTiempoVenta = false;
        public frmCatCobroV2(float total, float pagar, float pendiente, float monederoCliente, string cliente, float nuevoMontoMonedero)
        {
            InitializeComponent();
            loadMaterial(this);
            Total = total;
            TotalPagar = pagar;
            MonederoCliente = monederoCliente;
            Cliente = cliente;
            NuevoMontoMonedero = nuevoMontoMonedero;
            Pendiente = pendiente;
            Inicializar();
        }
        private void Inicializar()
        {
            try
            {
                this.Txt_Total.Text = string.Format("{0:c}", Total);
                this.Txt_Pagar.Text = string.Format("{0:c}", TotalPagar);
                this.Txt_Pendiente.Text = string.Format("{0:c}", Pendiente);
                this.Txt_PagoEfectivo.Text = string.Format("{0:c}", PagoEfectivo);
                this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                this.TxtNombreCliente.Text = this.Cliente;
                this.Txt_NewMonedero.Text = string.Format("{0:c}", NuevoMontoMonedero);
                this.Txt_Monedero.Text = string.Format("{0:c}", MonederoCliente);
                float aux = 0;
                float aux2 = 0;

                if (MonederoCliente > 0.0)
                {
                    this.Txt_PagoMonedero.ReadOnly = false;
                }
                else
                {
                    this.Txt_PagoMonedero.ReadOnly = true;
                }

                if (float.TryParse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency, provider, out aux) && float.TryParse(this.Txt_PagoMonedero.Text, NumberStyles.Currency, provider, out aux2))
                {
                    Cambio = 0;
                    PagoEfectivo = float.Parse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency);
                    PagoMonedero = float.Parse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency);
                    if (PagoMonedero > MonederoCliente)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    if (PagoMonedero > TotalPagar)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    Cambio = TotalPagar - (PagoEfectivo + PagoMonedero);
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio:";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "  Debe:";
                    }
                }
                else
                {
                    PagoEfectivo = 0;
                    PagoMonedero = 0;
                    if (PagoMonedero > MonederoCliente)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    if (PagoMonedero > TotalPagar)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    Cambio = TotalPagar - (PagoEfectivo + PagoMonedero);
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "Debe";
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public float getPago()
        {
            return (PagoEfectivo + PagoMonedero);
        }
        public float getPagoMonedero()
        {
            return (PagoMonedero);
        }
        public float getPagoEfectivo()
        {
            return (TotalPagar - PagoMonedero);
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
        #region Eventos
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                banSalir = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_Cobrar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((PagoEfectivo + PagoMonedero) >= TotalPagar)
                {
                    banSalir = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe Cubrir el monto a pagar", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Txt_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.PermitirSoloNumerosDecimales(e, this.Txt_Total.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Txt_Pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.PermitirSoloNumerosDecimales(e, this.Txt_PagoEfectivo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Txt_Cambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.PermitirSoloNumerosDecimales(e, this.Txt_Cambio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Txt_Total_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
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
                float aux = 0;
                float aux2 = 0;
                if (float.TryParse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency, provider, out aux) && float.TryParse(this.Txt_PagoMonedero.Text, NumberStyles.Currency, provider, out aux2))
                {
                    Cambio = 0;
                    PagoEfectivo = float.Parse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency);
                    PagoMonedero = float.Parse(this.Txt_PagoMonedero.Text, NumberStyles.Currency);
                    if (PagoMonedero > MonederoCliente)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    if (PagoMonedero > TotalPagar)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    Cambio = TotalPagar - (PagoEfectivo + PagoMonedero);
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio:";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "  Debe:";
                    }
                }
                else if (float.TryParse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency, provider, out aux))
                {
                    Cambio = 0;
                    PagoEfectivo = float.Parse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency);
                    PagoMonedero = 0.0F;
                    if (PagoMonedero > MonederoCliente)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    if (PagoMonedero > TotalPagar)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    Cambio = TotalPagar - (PagoEfectivo + PagoMonedero);
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio:";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "  Debe:";
                    }
                }
                else if (float.TryParse(this.Txt_PagoMonedero.Text, NumberStyles.Currency, provider, out aux2))
                {
                    Cambio = 0;
                    PagoEfectivo = 0.0F;
                    PagoMonedero = float.Parse(this.Txt_PagoMonedero.Text, NumberStyles.Currency);
                    if (PagoMonedero > MonederoCliente)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    if (PagoMonedero > TotalPagar)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    Cambio = TotalPagar - (PagoEfectivo + PagoMonedero);
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio:";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "  Debe:";
                    }
                }
                else
                {
                    PagoEfectivo = 0;
                    PagoMonedero = 0;
                    if (PagoMonedero > MonederoCliente)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    if (PagoMonedero > TotalPagar)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    Cambio = TotalPagar - (PagoEfectivo + PagoMonedero);
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "Debe";
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if ((PagoEfectivo + PagoMonedero) >= TotalPagar)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe Cubrir el monto a pagar", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Txt_Cambio_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Txt_Pago_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                /*
                if (e.KeyCode == Keys.Enter)
                {                    
                    Cambio = 0;
                    Pago = float.Parse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency);
                    this.Txt_PagoEfectivo.Text = string.Format("{0:c}", Pago);
                    Cambio = TotalPagar - Pago;
                    if(Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio";
                    }
                    else if(Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio );
                        this.label2.Text = "Debe";
                    }                   
                }
                else
                {
                    Pago = 0;
                    Cambio = TotalPagar - Pago;
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "Debe";
                    }
                }
             */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
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
                    banSalir = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema tiene que Cerrarse, no se cuenta con internet", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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
                this.Close();
            }
        }

        private void Txt_PagoMonedero_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Txt_PagoMonedero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.PermitirSoloNumerosDecimales(e, this.Txt_PagoEfectivo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Txt_PagoMonedero_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                float aux = 0;
                float aux2 = 0;
                if (float.TryParse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency, provider, out aux) && float.TryParse(this.Txt_PagoMonedero.Text, NumberStyles.Currency, provider, out aux2))
                {
                    Cambio = 0;
                    PagoEfectivo = float.Parse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency);
                    PagoMonedero = float.Parse(this.Txt_PagoMonedero.Text, NumberStyles.Currency);
                    if (PagoMonedero > MonederoCliente)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    if (PagoMonedero > TotalPagar)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    Cambio = TotalPagar - (PagoEfectivo + PagoMonedero);
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio:";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "  Debe:";
                    }
                }
                else if (float.TryParse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency, provider, out aux))
                {
                    Cambio = 0;
                    PagoEfectivo = float.Parse(this.Txt_PagoEfectivo.Text, NumberStyles.Currency);
                    PagoMonedero = 0.0F;
                    if (PagoMonedero > MonederoCliente)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    if (PagoMonedero > TotalPagar)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    Cambio = TotalPagar - (PagoEfectivo + PagoMonedero);
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio:";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "  Debe:";
                    }
                }
                else if (float.TryParse(this.Txt_PagoMonedero.Text, NumberStyles.Currency, provider, out aux2))
                {
                    Cambio = 0;
                    PagoEfectivo = 0.0F;
                    PagoMonedero = float.Parse(this.Txt_PagoMonedero.Text, NumberStyles.Currency);
                    if (PagoMonedero > MonederoCliente)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    if (PagoMonedero > TotalPagar)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    Cambio = TotalPagar - (PagoEfectivo + PagoMonedero);
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio:";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "  Debe:";
                    }
                }
                else
                {
                    PagoEfectivo = 0;
                    PagoMonedero = 0;
                    if (PagoMonedero > MonederoCliente)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    if (PagoMonedero > TotalPagar)
                    {
                        PagoMonedero = 0;
                        this.Txt_PagoMonedero.Text = string.Format("{0:c}", PagoMonedero);
                    }
                    Cambio = TotalPagar - (PagoEfectivo + PagoMonedero);
                    if (Cambio <= 0)
                    {
                        this.Txt_Cambio.BackColor = Color.MediumSpringGreen;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio * -1);
                        this.label2.Text = "Cambio";
                    }
                    else if (Cambio > 0)
                    {
                        this.Txt_Cambio.BackColor = Color.OrangeRed;
                        this.Txt_Cambio.Text = string.Format("{0:c}", Cambio);
                        this.label2.Text = "Debe";
                    }
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if ((PagoEfectivo + PagoMonedero) >= TotalPagar)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Debe Cubrir el monto a pagar", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
