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

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmPagoExtra : Form
    {
        private bool _banPagoExtra = false;
        private Validaciones Val;
        private CultureInfo provider = CultureInfo.CurrentCulture;
        private float _pagoExtraGenerico = 0F;
        public bool getBanPagoExtra()
        {
            return _banPagoExtra;
        }
        public float getPagoExtra()
        {
            return _pagoExtraGenerico;
        }
        public frmPagoExtra()
        {
            try
            {
                InitializeComponent();
                this.Txt_PagoExtraGenerico.Text = string.Format("{0:c}", 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Txt_DescuentoGenerico_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void brn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                float aux = 0;
                if (float.TryParse(this.Txt_PagoExtraGenerico.Text, NumberStyles.Currency, provider, out aux))
                {
                    if (aux > 0)
                    {
                        _pagoExtraGenerico = aux;
                        this.Txt_PagoExtraGenerico.Text = string.Format("{0:c}", aux);
                        _banPagoExtra = true;
                        this.Close();
                    }
                    else
                    {
                        _pagoExtraGenerico = 0;
                        this.Txt_PagoExtraGenerico.Text = string.Format("{0:c}", 0);
                        MessageBox.Show("Escribe un monto", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    _pagoExtraGenerico = 0;
                    this.Txt_PagoExtraGenerico.Text = string.Format("{0:c}", 0);
                    MessageBox.Show("Escribe un monto", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_PagoExtraGenerico_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Txt_PagoExtraGenerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.PermitirSoloNumerosDecimales(e, this.Txt_PagoExtraGenerico.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
