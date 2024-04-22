using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static CreativaSL.WinForm.VentaBoletos.MaterialUI;


namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmDatosCajaV2 : MaterialForm
    {

        private Caja caja;

        public frmDatosCajaV2()
        {
            InitializeComponent();
            loadMaterial(this);
            caja = new Caja(Comun.Conexion);
            caja.id_caja = Comun.id_caja;
            this.Inicializar();

        }

        #region Metodos
        private void Inicializar()
        {
            try
            {
                Caja_Negocio cajaneg = new Caja_Negocio();
                caja = cajaneg.ObtenerDatosCaja(caja, false);
                txtxMontoApertura.Text = string.Format("{0:c}", caja.Total);
                txtMontoVenta.Text = string.Format("{0:c}", caja.TotalVentas - caja.TotalVentasMaletas);
                txtMontoMaletas.Text = string.Format("{0:c}", caja.TotalVentasMaletas);
                txtDepositos.Text = string.Format("{0:c}", caja.TotalDepositos);


                float retiros = caja.TotalRetirosCajaLlena + caja.TotalRetirosPagos;
                txtRetiros.Text = string.Format("{0:c}", retiros);
                float totalgeneral = caja.TotalVentas + caja.Total + caja.TotalDepositos - retiros;
                float totalefectivo = caja.TotalEfectivo + caja.Total + caja.TotalDepositos - retiros;
                txtTotalGeneral.Text = string.Format("{0:c}", totalgeneral);
                txtTotalEfectivo.Text = string.Format("{0:c}", totalefectivo);
                txtTotalMonedero.Text = string.Format("{0:c}", caja.TotalMonedero);
                txtTotalTarjeta.Text = string.Format("{0:c}", caja.TotalTarjeta);
                txtTotalTransferencia.Text = string.Format("{0:c}", caja.TotalTransferencia);
                TxtFechaInicio.Text = caja.FechaIngreso;
                TxtHoraInicio.Text = caja.HoraIngreso;
                TxtCajero.Text = caja.Cajero;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Inicializar" + ex.Message);
            }
        }



        private void PermitirSoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en PermitirSoloNumeros" + ex.Message);
            }
        }


        #endregion



        private void BtnContinuar_Click(object sender, EventArgs e)
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

        private void btnCaja_Click(object sender, EventArgs e)
        {
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuariosDatosV2 frmud = new frmUsuariosDatosV2();
                frmud.ShowDialog();
                frmud.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
