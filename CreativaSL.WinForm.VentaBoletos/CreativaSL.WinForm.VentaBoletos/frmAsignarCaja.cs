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
using System.Drawing.Printing;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmAsignarCaja : Form_Creativa
    {
        private Validaciones Val;
        private bool _Exception = true;
        private Caja caja = new Caja(Comun.Conexion);
        public bool Exception
        {
            get { return _Exception; }
            set { _Exception = value; }
        }

        public frmAsignarCaja()
        {
            try
            {
                InitializeComponent();
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Métodos
        private void GuardarMac()
        {
            try
            {
                Val = new Validaciones();
                int Verificador = 0;
                Caja_Negocio cajaNegocio = new Caja_Negocio();
                Caja caja = new Caja(Comun.Conexion);
                this.ObtenerDatos(caja);
                cajaNegocio.AsignarCaja(Comun.Conexion, caja, ref Verificador);
                this.VerifcarMensajeAccion(Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatos(Caja caja)
        {
            try
            {
                caja.id_cajaCat = this.CmbCaja.SelectedValue.ToString();
                caja.mac = this.TxtMac.Text;
                caja.descripcion = this.txtDescripcion.Text;
                caja.namePrinter = this.txtnameprinter.Text;
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
                this.TxtMac.Text = Comun.macAdress;
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
                this.caja.listaCaja = new List<Caja>();
                Caja_Negocio caja_Negocio = new Caja_Negocio();
                caja_Negocio.CargarComboCajas(Comun.Conexion, ref this.caja);
                this.CmbCaja.DataSource = this.caja.listaCaja;
                this.CmbCaja.ValueMember = "id_cajaCat";
                this.CmbCaja.DisplayMember = "cajaCat";
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
                if (Verificador == 0)
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
                if (Comun.macAdress == "")
                {
                    MessageBox.Show("Este equipo no cuenta con una conexion a internet ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtMac.Focus();
                    return false;
                }
                if (this.CmbCaja.SelectedIndex == 0)
                {
                    MessageBox.Show("Debes seleccionar una caja", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CmbCaja.Focus();
                    return false;
                }
                if (this.txtDescripcion.Text == "")
                {
                    MessageBox.Show("Debes ingresar una descripción", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CmbCaja.Focus();
                    return false;
                }
                if (this.txtnameprinter.Text == "")
                {
                    MessageBox.Show("Debes seleccionar una impresora", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CmbCaja.Focus();
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
                    this.GuardarMac();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        #endregion

        private void button_Creativa1_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.AllowCurrentPage = false;
                printDialog1.AllowPrintToFile = false;
                printDialog1.AllowSelection = false;
                printDialog1.AllowSomePages = false;
                printDialog1.ShowHelp = false;
                printDialog1.ShowNetwork = false;
                printDialog1.PrintToFile = false;
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PrinterSettings ps = printDialog1.PrinterSettings;
                    this.txtnameprinter.Text = ps.PrinterName;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
