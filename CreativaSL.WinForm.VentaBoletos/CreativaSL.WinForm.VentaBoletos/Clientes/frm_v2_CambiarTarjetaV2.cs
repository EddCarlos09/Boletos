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


namespace CreativaSL.WinForm.VentaBoletos.Clientes
{
    public partial class frm_v2_CambiarTarjetaV2 : MaterialForm
    {
        public frm_v2_CambiarTarjetaV2(V2Cliente datos)
        {
            try
            {
                InitializeComponent();
                loadMaterial(this);
                Model = new V2Cliente_Negocio(Comun.Conexion, false, 0, Comun.Id_U);
                Model.Model.CodigoTarjeta = datos.CodigoTarjeta;
                Model.Model.Nombre = datos.Nombre;
                Model.Model.IDCliente = datos.IDCliente;
                IniciarBinding();
                IniciarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error. Contacte a soporte Técnico.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Comun.AddExcFileTxt(ex, "frmAsignarTarjeta");
                this.Close();
            }
        }
    
        #region Propiedades / Variables globales
        private V2Cliente _cliente;
        public V2Cliente_Negocio Model { get; set; }
        public bool completo = false;
        #endregion
        #region Constructor

        #endregion
        #region Metodos
        private void IniciarBinding()
        {
            try
            {
                txtCliente.DataBindings.Add("Text", Model.Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                txtNumTarjeta.DataBindings.Add("Text", Model.Model, "CodigoTarjeta", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void IniciarForm()
        {
            try
            {
                this.txtCliente.Text = Model.Model.CodigoTarjeta;
                this.txtNumTarjeta.Text = Model.Model.Nombre;
                this.txtNumTarjeta.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarMensajeError(int error)
        {
            try
            {
                this.txt_mensaje.Visible = true;
                switch (error)
                {
                    case 1:
                        this.txt_mensaje.Text = "Ingrese un número de tarjeta válido.";
                        this.ActiveControl = this.txtNumTarjeta;
                        this.txtNumTarjeta.Focus();
                        break;
                    case 10:
                        this.txt_mensaje.Text = "El número de tarjeta ingresado No está disponible.";
                        this.ActiveControl = this.txtNumTarjeta;
                        this.txtNumTarjeta.Focus();
                        break;
                }
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
                this._cliente.CodigoTarjeta = this.txtNumTarjeta.Text;
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
                    this.txt_mensaje.Visible = true;
                    txt_mensaje.Text = "Ingrese un número de tarjeta válido.";
                }
                else if (Verificador == 1)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    completo = true;
                    this.Close();
                }
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
                this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                int Verificador = 0;
                Model.setTarjetaCliente(ref Verificador);
                VerifcarMensajeAccion(Verificador);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error. Contacte a soporte Técnico.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtNumTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)Keys.Enter)
                {
                    this.btn_Guardar_Click(this.btn_Guardar, new EventArgs());
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void frmAsignarTarjetaV2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)Keys.Escape)
                    this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frm_v2_AsignarTarjeta Add = new frm_v2_AsignarTarjeta(Model.Model.CodigoTarjeta);
                Add.ShowDialog();
                Add.Dispose();
                this.txtNumTarjeta.Text = Add.FolioCliente;
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_ClienteAdd ~ btnBuscar_Click");
            }
        }
        #endregion
    }
}
