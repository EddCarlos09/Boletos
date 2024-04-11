using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.Windows.Forms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using System.Globalization;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmPorentajeMonederoV2 : MaterialForm
    {
        private Validaciones Val;
        private PorcentajeMonedero infoPorcentajeMonedero;
        private bool _Exception = true;
        public bool Exception
        {
            get { return _Exception; }
            set { _Exception = value; }
        }

        public frmPorentajeMonederoV2(PorcentajeMonedero porcentajesMonedero)
        {
            try
            {
                InitializeComponent();
                this.infoPorcentajeMonedero = porcentajesMonedero;
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.GuardarPorcentajeMonedero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        #region MetodosGenerales
        private void GuardarPorcentajeMonedero()
        {
            try
            {

                Val = new Validaciones();
                int Verificador = 0;
                PorcentajeMonedero_Negocio porcentajeMonederoNegocio = new PorcentajeMonedero_Negocio();
                PorcentajeMonedero porcentajeMonedero = new PorcentajeMonedero();
                this.ObtenerDatos(porcentajeMonedero);
                if (infoPorcentajeMonedero.IDSucursal != "")
                {
                    porcentajeMonederoNegocio.ModificarPorcentajeMonedero(porcentajeMonedero, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatos(PorcentajeMonedero porcentajeMonedero)
        {
            try
            {
                porcentajeMonedero.Porcentaje_Monedero = float.Parse(this.TxtPorcentajeMonedero.Text, NumberStyles.Currency);
                porcentajeMonedero.MontoCancelacion = float.Parse(this.TxtMontoCancelacion.Text, NumberStyles.Currency);
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
                if (infoPorcentajeMonedero.IDSucursal != "")
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
                this.TxtPorcentajeMonedero.Text = infoPorcentajeMonedero.Porcentaje_Monedero.ToString();
                this.TxtMontoCancelacion.Text = string.Format("{0:c}", infoPorcentajeMonedero.MontoCancelacion);
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
                if (this.TxtPorcentajeMonedero.Text == string.Empty || this.TxtPorcentajeMonedero.Text == "")
                {
                    MessageBox.Show("Debes ingresar un porcentaje", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtPorcentajeMonedero.Focus();
                    return false;
                }
                if (this.TxtMontoCancelacion.Text == string.Empty || this.TxtMontoCancelacion.Text == "")
                {
                    MessageBox.Show("Debes ingresar un monto para la cancelación", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtPorcentajeMonedero.Focus();
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

        private void frmPorcentajeMonedero_Load(object sender, EventArgs e)
        {

        }
    }
}
