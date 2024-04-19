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
    public partial class frmCaja_AperturaCajaV2 : MaterialForm
    {
        private Caja caja;
        private bool _Exception = true;
        public bool Exception
        {
            get { return _Exception; }
            set { _Exception = value; }
        }
        #region Constructor
        public frmCaja_AperturaCajaV2()
        {
            try
            {
                InitializeComponent();
                this.inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eventos

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                this.guardarAperturaCaja();
                this.Exception = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TxtM50C_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM1P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM2P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM5P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM10P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM20P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM100P_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtB20P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB50P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB100P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB200P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB500P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB1000P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //*** Eventos para ir calculando el total al presionar una tecla ****

        private void TxtB1000P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB500P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB200P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB100P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB50P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB20P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM100P_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TxtM20P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM10P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM5P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM2P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM1P_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM50C_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.calcularTotalOnPressKey(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Metodos

        private void inicializar()
        {
            try
            {
                this.inicializarTextbox();
                this.TxtNomCajero.Text = Comun.U_Nombre + " " + Comun.U_Apellidop + " " + Comun.U_Apellidom;
                this.TxtFecha.Text = DateTime.Now.ToShortDateString();
                this.TxtHora.Text = DateTime.Now.ToString("HH:mm:ss"); //HH FORMAT 24 HOURS
                this.TxtB1000P.Focus();
                // hh:mm:ss tt FORMAT THE AM/PM                                               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void guardarAperturaCaja()
        {
            try
            {
                caja = new Caja(Comun.Conexion);
                int verificador = 0;
                this.obtenerDatos(caja);
                Caja_Negocio caja_negocio = new Caja_Negocio();
                caja_negocio.GuardarAperturaCaja(caja, Comun.Conexion, ref verificador);
                if (verificador != 0)
                    this.mensaje("Error a la hora de insertar datos en caja");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void obtenerDatos(Caja caja)
        {
            try
            {
                this.inicializarTextbox();
                caja.id_caja = Comun.id_caja;
                caja.M50C = Convert.ToInt32(this.TxtM50C.Text);
                caja.M1P = Convert.ToInt32(this.TxtM1P.Text);
                caja.M2P = Convert.ToInt32(this.TxtM2P.Text);
                caja.M5P = Convert.ToInt32(this.TxtM5P.Text);
                caja.M10P = Convert.ToInt32(this.TxtM10P.Text);
                caja.M20P = Convert.ToInt32(this.TxtM20P.Text);
                caja.M100P = Convert.ToInt32(this.TxtM100P.Text);
                caja.B20P = Convert.ToInt32(this.TxtB20P.Text);
                caja.B50P = Convert.ToInt32(this.TxtB50P.Text);
                caja.B100P = Convert.ToInt32(this.TxtB100P.Text);
                caja.B200P = Convert.ToInt32(this.TxtB200P.Text);
                caja.B500P = Convert.ToInt32(this.TxtB500P.Text);
                caja.B1000P = Convert.ToInt32(this.TxtB1000P.Text);
                caja.Total = this.calcularTotal();
                caja.Id_U = Comun.Id_U;
                caja.FechaIngreso = this.TxtFecha.Text;
                caja.HoraIngreso = this.TxtHora.Text;
                caja.id_sucursal = Comun.SucursalCaja;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private float calcularTotal()
        {
            try
            {
                float centavos = 0;
                int m1p, m2p, m5p, m10p, m20p, m100p, b20p, b50p, b100p, b200p, b500p, b1000p;
                m1p = m2p = m5p = m10p = m20p = m100p = b20p = b50p = b100p = b200p = b500p = b1000p = 0;
                if (this.TxtM1P.Text != "")
                    m1p = Convert.ToInt32(this.TxtM1P.Text);
                if (this.TxtM2P.Text != "")
                    m2p = Convert.ToInt32(this.TxtM2P.Text);
                if (this.TxtM5P.Text != "")
                    m5p = Convert.ToInt32(this.TxtM5P.Text);
                if (this.TxtM10P.Text != "")
                    m10p = Convert.ToInt32(this.TxtM10P.Text);
                if (this.TxtM20P.Text != "")
                    m20p = Convert.ToInt32(this.TxtM20P.Text);
                if (this.TxtM100P.Text != "")
                    m100p = Convert.ToInt32(this.TxtM100P.Text);
                if (this.TxtB20P.Text != "")
                    b20p = Convert.ToInt32(this.TxtB20P.Text);
                if (this.TxtB50P.Text != "")
                    b50p = Convert.ToInt32(this.TxtB50P.Text);
                if (this.TxtB100P.Text != "")
                    b100p = Convert.ToInt32(this.TxtB100P.Text);
                if (this.TxtB200P.Text != "")
                    b200p = Convert.ToInt32(this.TxtB200P.Text);
                if (this.TxtB500P.Text != "")
                    b500p = Convert.ToInt32(this.TxtB500P.Text);
                if (this.TxtB1000P.Text != "")
                    b1000p = Convert.ToInt32(this.TxtB1000P.Text);
                if (this.TxtM50C.Text != "")
                    if (Convert.ToInt32(this.TxtM50C.Text) != 0)
                    {
                        centavos = Convert.ToInt32(this.TxtM50C.Text) % 2 == 0 ? Convert.ToInt32(this.TxtM50C.Text) / 2 : (float).5 + (Convert.ToInt32(this.TxtM50C.Text) == 1 ? 0 : (Convert.ToInt32(this.TxtM50C.Text) / 2));
                    }

                float total = centavos + m1p + (m2p * 2) +
                    (m5p * 5) + (m10p * 10) +
                    ((m20p + b20p) * 20) +
                    ((m100p + b100p) * 100) +
                    (b50p * 50) + (b200p * 200) +
                    (b500p * 500) + (b1000p * 1000);

                return total;
            }
            catch (Exception ex)
            {

                throw ex;
                //return 0.0f;
            }
        }

        private void inicializarTextbox()
        {
            try
            {
                if (this.TxtM50C.Text == "" || this.TxtM50C.Text == string.Empty)
                    this.TxtM50C.Text = "0";
                if (this.TxtM1P.Text == "" || this.TxtM1P.Text == string.Empty)
                    this.TxtM1P.Text = "0";
                if (this.TxtM2P.Text == "" || this.TxtM2P.Text == string.Empty)
                    this.TxtM2P.Text = "0";
                if (this.TxtM5P.Text == "" || this.TxtM5P.Text == string.Empty)
                    this.TxtM5P.Text = "0";
                if (this.TxtM10P.Text == "" || this.TxtM10P.Text == string.Empty)
                    this.TxtM10P.Text = "0";
                if (this.TxtM20P.Text == "" || this.TxtM20P.Text == string.Empty)
                    this.TxtM20P.Text = "0";
                if (this.TxtM100P.Text == "" || this.TxtM100P.Text == string.Empty)
                    this.TxtM100P.Text = "0";
                if (this.TxtB20P.Text == "" || this.TxtB20P.Text == string.Empty)
                    this.TxtB20P.Text = "0";
                if (this.TxtB50P.Text == "" || this.TxtB50P.Text == string.Empty)
                    this.TxtB50P.Text = "0";
                if (this.TxtB100P.Text == "" || this.TxtB100P.Text == string.Empty)
                    this.TxtB100P.Text = "0";
                if (this.TxtB200P.Text == "" || this.TxtB200P.Text == string.Empty)
                    this.TxtB200P.Text = "0";
                if (this.TxtB500P.Text == "" || this.TxtB500P.Text == string.Empty)
                    this.TxtB500P.Text = "0";
                if (this.TxtB1000P.Text == "" || this.TxtB1000P.Text == string.Empty)
                    this.TxtB1000P.Text = "0";
                if (this.txtTotal.Text == "" || this.txtTotal.Text == string.Empty)
                    this.txtTotal.Text = "0";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void permitirSoloNumeros(KeyPressEventArgs e)
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
                throw ex;
            }
        }

        private bool esNumero(KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == (Char)Keys.NumPad0
                    || e.KeyValue == (Char)Keys.NumPad1
                    || e.KeyValue == (Char)Keys.NumPad2
                    || e.KeyValue == (Char)Keys.NumPad3
                    || e.KeyValue == (Char)Keys.NumPad4
                    || e.KeyValue == (Char)Keys.NumPad5
                    || e.KeyValue == (Char)Keys.NumPad6
                    || e.KeyValue == (Char)Keys.NumPad7
                    || e.KeyValue == (Char)Keys.NumPad8
                    || e.KeyValue == (Char)Keys.NumPad9)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void calcularTotalOnPressKey(KeyEventArgs e)
        {
            try
            {
                if (Char.IsDigit((Char)e.KeyCode) || esNumero(e))
                {
                    this.txtTotal.Text = this.calcularTotal().ToString();
                }
                else
                    if (Char.IsControl((Char)e.KeyCode))
                {
                    this.txtTotal.Text = this.calcularTotal().ToString();
                }
                else
                        if (e.KeyValue == (char)Keys.Delete)
                {
                    this.txtTotal.Text = this.calcularTotal().ToString();
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mensaje(string msj)
        {
            try
            {
                DialogResult ds;
                ds = MessageBox.Show(this, msj, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region evento validating

        private void txtNotNull_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text == "")
                {
                    txt.Text = "0";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
