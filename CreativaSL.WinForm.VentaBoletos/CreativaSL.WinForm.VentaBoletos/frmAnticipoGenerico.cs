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
    public partial class frmAnticipoGenerico : Form
    {
        private bool _banAnticipo = false;
        private CultureInfo provider = CultureInfo.CurrentCulture;
        private float _anticipoGenerico = 0F;
        public bool getBanAnticipo()
        {
            return _banAnticipo;
        }
        public float getAnticipoGenerico()
        {
            return _anticipoGenerico;
        }
        
        public frmAnticipoGenerico()
        {
            try
            {
                InitializeComponent();
                this.Txt_Anticipo.Text = string.Format("{0:c}", 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Txt_Anticipo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                float aux;
                if (float.TryParse(this.Txt_Anticipo.Text, NumberStyles.Currency, provider, out aux))
                {
                    if (aux > 0)
                    {
                        _anticipoGenerico = aux;
                    }
                    else
                    {
                        _anticipoGenerico = 0;
                    }
                }
                else
                {
                    _anticipoGenerico = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void Txt_Anticipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones val = new Validaciones();
                val.PermitirSoloNumerosDecimales(e, this.Txt_Anticipo.Text);
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
                if (float.TryParse(this.Txt_Anticipo.Text, NumberStyles.Currency, provider, out aux))
                {
                    if (aux > 0)
                    {
                        _anticipoGenerico = aux;
                        this.Txt_Anticipo.Text = string.Format("{0:c}", aux);
                        _banAnticipo= true;
                        this.Close();
                    }
                    else
                    {
                        _anticipoGenerico = 0;
                        this.Txt_Anticipo.Text = string.Format("{0:c}", 0);
                        MessageBox.Show("Escribe un monto", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    _anticipoGenerico = 0;
                    this.Txt_Anticipo.Text = string.Format("{0:c}", 0);
                    MessageBox.Show("Escribe un monto", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
