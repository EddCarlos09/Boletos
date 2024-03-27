using System;
using System.Collections.Generic;
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
    public partial class frmLoginValidator : Form
    {
        private bool _banAutorizacion = false;

        public bool getbanAutorizacion()
        {
            return _banAutorizacion;
        }
        public frmLoginValidator()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginValidator_Negocio Login = new LoginValidator_Negocio();
                if (Login.ValidaLoginAdministrador(Comun.Conexion, this.txtUsuario.Text, this.txtContraseña.Text))
                {
                    this._banAutorizacion = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Autorización no permitida", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
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
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            try
            {
                this.txtUsuario.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            try
            {
                this.txtContraseña.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    this.btnAceptar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    this.txtContraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLoginValidator_Load(object sender, EventArgs e)
        {
            try
            {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    this.txtUsuario.Text = "AdminTGZ";
                    this.txtContraseña.Text = "AdminTGZ";
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
