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
    public partial class frmDescuentoGenericoV2 : MaterialForm
    {
        private bool _banDescuento = false;
        private CultureInfo provider = CultureInfo.CurrentCulture;
        private float _descuentoGenerico = 0F;
        public bool getBanDescuento()
        {
            return _banDescuento;
        }
        public float getDescuentoGenerico()
        {
            return _descuentoGenerico;
        }
        public frmDescuentoGenericoV2()
        {
            try
            {
                InitializeComponent();
                loadMaterial(this);
                this.Txt_DescuentoGenerico.Text = string.Format("{0:c}", 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void Txt_DescuentoGenerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones val = new Validaciones();
                val.PermitirSoloNumerosDecimales(e, this.Txt_DescuentoGenerico.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (float.TryParse(this.Txt_DescuentoGenerico.Text, NumberStyles.Currency, provider, out aux))
                {
                    if (aux > 0)
                    {
                        _descuentoGenerico = aux;
                        this.Txt_DescuentoGenerico.Text = string.Format("{0:c}", aux);
                        _banDescuento = true;
                        this.Close();
                    }
                    else
                    {
                        _descuentoGenerico = 0;
                        this.Txt_DescuentoGenerico.Text = string.Format("{0:c}", 0);
                        MessageBox.Show("Escribe un monto", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    _descuentoGenerico = 0;
                    this.Txt_DescuentoGenerico.Text = string.Format("{0:c}", 0);
                    MessageBox.Show("Escribe un monto", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_DescuentoGenerico_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                float aux;
                if (float.TryParse(this.Txt_DescuentoGenerico.Text, NumberStyles.Currency, provider, out aux))
                {
                    if (aux > 0)
                    {
                        _descuentoGenerico = aux;
                    }
                    else
                    {
                        _descuentoGenerico = 0;
                    }
                }
                else
                {
                    _descuentoGenerico = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
