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
    public partial class frmCatTipoCamion : Form_Creativa
    {
        private CultureInfo provider = CultureInfo.CurrentCulture;
        private Validaciones Val;
        private TipoCamion infoTipoCamion;
        private bool _Exception = true;
        public bool Exception
        {
            get { return _Exception; }
            set { _Exception = value; }
        }
        public frmCatTipoCamion(TipoCamion tipocamion)
        {
            try
            {
                InitializeComponent();
                this.infoTipoCamion = tipocamion;
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Métodos
        private void GuardarTipoCamion()
        {
            try
            {
                Val = new Validaciones();
                int Verificador = 0;
                TipoCamion_Negocio tipocamionNegocio = new TipoCamion_Negocio();
                TipoCamion tipocamion = new TipoCamion();
                this.ObtenerDatos(tipocamion);
                if (infoTipoCamion.id_tipocamion != 0)
                {
                    tipocamion.id_tipocamion = infoTipoCamion.id_tipocamion;
                    tipocamionNegocio.ModificarTipoCamion(tipocamion, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
                else
                {
                    tipocamionNegocio.InsertarTipoCamion(tipocamion, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerDatos(TipoCamion tipocamion)
        {
            try
            {
                tipocamion.nombreTipoCamion = this.TxtNombreTipoCamion.Text;
                /*
                float aux = 0;
                if (float.TryParse(this.TxtMaximoDescuento.Text, NumberStyles.Currency, provider, out aux))
                    tipocamion.maximoDescuentoLinea = aux;
                else
                */
                tipocamion.maximoDescuentoLinea = 0.0f;
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
                if (infoTipoCamion.id_tipocamion != 0)
                    this.LlenarDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarDatos()
        {
            try
            {
                this.TxtNombreTipoCamion.Text = infoTipoCamion.nombreTipoCamion;
                //this.TxtMaximoDescuento.Text = infoTipoCamion.maximoDescuentoLinea.ToString();
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
                if (Verificador == 2)
                {
                    Val.Mensaje("Ya existe el tipo de camión", this);
                    this.TxtNombreTipoCamion.Focus();
                }
                else if (Verificador == 0)
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
                if (this.TxtNombreTipoCamion.Text == string.Empty || this.TxtNombreTipoCamion.Text == "")
                {
                    MessageBox.Show("Debes ingresar un tipo de camión ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtNombreTipoCamion.Focus();
                    return false;
                }
                /*
                if (this.TxtMaximoDescuento.Text == string.Empty || this.TxtMaximoDescuento.Text == "")
                {
                    MessageBox.Show("Debes ingresar un descuento maximo ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtMaximoDescuento.Focus();
                    return false;
                }
                */
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Eventos
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos())
                {
                    this.GuardarTipoCamion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void TxtNombreTipoCamion_KeyPress(object sender, KeyPressEventArgs e)
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
        
        private void TxtMaximoDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones val = new Validaciones();
                //val.PermitirSoloNumerosDecimales(e, this.TxtMaximoDescuento.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}
