using System;
using System.Collections.Generic;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using static System.Windows.Forms.Design.AxImporter;
using System.Collections;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmDatosTransferenciaV2 : MaterialForm
    {
        #region Variables
        private FormaPago _datos;
        public FormaPago datos
        {
            get { return _datos; }
            set { _datos = value; }
        }

        int opcion = 0;
        #endregion
        #region Constructor
        public frmDatosTransferenciaV2()
        {
            try
            {
                InitializeComponent();
                loadMaterial(this);

                this.label4.ForeColor = Color.Navy; // Cambiar el color del texto
                this.label4.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);

                this.label1.ForeColor = Color.DimGray;
                this.label1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label2.ForeColor = Color.DimGray;
                this.label2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label8.ForeColor = Color.DimGray;
                this.label8.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public frmDatosTransferenciaV2(FormaPago fp, int op)
        {
            try
            {
                InitializeComponent();
                datos = fp;
                opcion = op;
                this.CargarDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Eventos
        #region Evento Click
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Hashtable errores = new Hashtable();
                errores = this.ValidarDatos();
                if (errores.Count == 0)
                {
                    this.ObtenerDatos();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.MostrarMensajeError(errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.DialogResult = DialogResult.Abort;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
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
        #endregion
        #region Eventos KeyPress
        private void cmbBancos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)13)
                {
                    this.txtMonto.Focus();
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
        private void txtIFE_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)13)
                {
                    this.cmbBancos.Focus();
                }
                else
                {
                    Validaciones val = new Validaciones();
                    val.SoloTexto(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)13)
                {
                    this.btnAceptar_Click(null, null);
                }
                else
                {
                    Validaciones val = new Validaciones();
                    val.PermitirSoloNumerosDecimales(e, this.txtMonto.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtNumAutorizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)13)
                {
                    this.cmbBancos.Focus();
                }
                else
                {
                    Validaciones val = new Validaciones();
                    val.SoloNumerico(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Evento Load
        private void frmDatosCheque_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarComboBancos();
                this.ActiveControl = this.txtNumCheque;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }
        }
        #endregion
        #region Eventos Validating
        private void txtMonto_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal aux = 0;
                decimal.TryParse(this.txtMonto.Text, out aux);
                this.txtMonto.Text = string.Format("{0:F2}", aux);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void txtNumCheque_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //if (this.ValidarFolioTransaccion()) //Si el folio de transaccion ya existe, informar.
                //{
                //    this.txt_mensaje.Visible = true;
                //    this.txt_mensaje.Text = "El folio de transacción ya ha sido ingresado previamente. Verifique la información.";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error. Contacte a Soporte Técnico. Detalles del error: " + ex.Message,
                    "Sistema Venta de Boletos v1.2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #endregion
        #region Métodos
        private void CargarComboBancos()
        {
            try
            {
                Banco_Negocio bn = new Banco_Negocio();
                Banco datos = new Banco();
                datos.Conexion = Comun.Conexion;
                List<Banco> bancos = bn.llenarComboBancos(datos);
                this.cmbBancos.DisplayMember = "nombreBanco";
                this.cmbBancos.ValueMember = "idBanco";
                this.cmbBancos.DataSource = bancos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarDatos()
        {
            try
            {
                if (opcion == 1)
                {
                    if (datos != null)
                    {
                        this.txtNumCheque.Text = datos.numCheque;
                        this.cmbBancos.SelectedItem = datos.banco;
                        this.txtMonto.Text = string.Format("{0:F2}", datos.monto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Hashtable ValidarDatos()
        {
            try
            {
                Hashtable errores = new Hashtable();
                if (this.cmbBancos.SelectedIndex == -1)
                    errores.Add(1, "Seleccione una banco de la lista. ");
                else
                {
                    Banco banco = new Banco();
                    banco = (Banco)this.cmbBancos.SelectedItem;
                    if (banco.idBanco == 0)
                        errores.Add(1, "Seleccione una banco de la lista. ");
                }
                if (string.IsNullOrEmpty(this.txtNumCheque.Text))
                    errores.Add(2, "Ingrese el número de autorización. ");
                decimal monto = 0;
                decimal.TryParse(this.txtMonto.Text, out monto);
                if (monto <= 0)
                    errores.Add(4, "Ingrese un monto válido mayor a " + string.Format("{0:c}", 0) + ".");
                else
                    if (opcion == 0)
                {
                    if ((float)monto > datos.monto)
                    {
                        errores.Add(4, "Ingrese un monto menor a " + string.Format("{0:c}", datos.monto) + ".");
                    }
                }
                //if (this.ValidarFolioTransaccion())
                //    errores.Add(5, "El folio de transacción ya ha sido ingresado previamente. Verifique la información.");
                return errores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MostrarMensajeError(Hashtable errores)
        {
            try
            {
                string cadenaErrores = string.Empty;
                cadenaErrores = "No se pudo guardar la información. Se presentaron los siguientes errores: \r\n";
                int aux = 1;
                foreach (DictionaryEntry de in errores)
                {
                    Console.WriteLine("\t{0}:\t{1}", de.Key, de.Value);
                    cadenaErrores += aux + "\t" + de.Value + "\r\n"; ;
                    aux++;
                }
                this.txt_mensaje.Visible = true;
                this.txt_mensaje.Text = cadenaErrores;
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
                if (this.cmbBancos.SelectedIndex == -1)
                    datos.banco = new Banco();
                else
                {
                    Banco banco = new Banco();
                    banco = (Banco)this.cmbBancos.SelectedItem;
                    if (banco.idBanco == 0)
                        datos.banco = new Banco();
                    else
                        datos.banco = banco;
                }
                if (string.IsNullOrEmpty(this.txtNumCheque.Text))
                    datos.autorizacion = string.Empty;
                else
                    datos.autorizacion = this.txtNumCheque.Text;
                decimal monto = 0;
                decimal.TryParse(this.txtMonto.Text, out monto);
                datos.monto = (float)monto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarFolioTransaccion()
        {
            try
            {
                Busqueda datos = new Busqueda(Comun.Conexion);
                Busqueda_Negocio bn = new Busqueda_Negocio();
                datos = bn.ValidarFolioTransferencia(this.txtNumCheque.Text, datos.strcnx);
                return datos.Validador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
