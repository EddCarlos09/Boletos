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
namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCatUsuarios : Form_Creativa
    {
        private Validaciones Val;
        private Usuario infoUsuario;
        private bool _Exception = true;
        public bool Exception
        {
            get { return _Exception; }
            set { _Exception = value; }
        }
        public frmCatUsuarios(Usuario usuario)
        {
            try
            {
                InitializeComponent();
                this.infoUsuario = usuario;
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void frmCatUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

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
                    this.GuardarUsuario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.NumeroTelefono(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.TextoNumerosPuntoGuionTilde(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Metodos Generales
        private void Inicializar()
        {
            try
            {
                this.CargarCombos();
                if (infoUsuario.Id_U != null)
                    this.LlenarDatos();
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
                this.infoUsuario.lista_TipoUsuarios = new List<Usuario>();
                this.infoUsuario.lista_Turno = new List<Usuario>();
                this.infoUsuario.lista_Sucursal = new List<Usuario>();
                Usuario_Negocio Usuario_Negocio = new Usuario_Negocio();
                Usuario_Negocio.CargarComboTurno(Comun.Conexion, ref this.infoUsuario);
                Usuario_Negocio.CargarComboSucursal(Comun.Conexion, ref this.infoUsuario);
                Usuario_Negocio.CargarComboTipoUsuario(Comun.Conexion, ref this.infoUsuario);
                this.CmbTipoUsuario.DataSource = this.infoUsuario.lista_TipoUsuarios;
                this.CmbTipoUsuario.ValueMember = "Id_Tu";
                this.CmbTipoUsuario.DisplayMember = "Tu_Descripcion";
                this.CmbTurno.DataSource = this.infoUsuario.lista_Turno;
                this.CmbTurno.ValueMember = "Id_Turno";
                this.CmbTurno.DisplayMember = "Turno";
                this.CmbSucursal.DataSource = this.infoUsuario.lista_Sucursal;
                this.CmbSucursal.ValueMember = "id_sucursal";
                this.CmbSucursal.DisplayMember = "Nombre_Sucursal";
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
                if (this.TxtNombre.Text == string.Empty || this.TxtNombre.Text == "")
                {
                    MessageBox.Show("Debes ingresar nombre del usuario ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtNombre.Focus();
                    return false;
                }
                if (this.TxtApellidoPaterno.Text == string.Empty || this.TxtApellidoPaterno.Text == "")
                {
                    MessageBox.Show("Debes ingresar apellido paterno ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtApellidoPaterno.Focus();
                    return false;
                }
                if (this.TxtApellidoMaterno.Text == string.Empty || this.TxtApellidoMaterno.Text == "")
                {
                    MessageBox.Show("Debes ingresar apellido materno ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtApellidoMaterno.Focus();
                    return false;
                }
                if (this.CmbTipoUsuario.SelectedIndex == 0)
                {
                    MessageBox.Show("Debes seleccionar tipo de usuario ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CmbTipoUsuario.Focus();
                    return false;
                }
                if (this.CmbSucursal.SelectedIndex == 0)
                {
                    MessageBox.Show("Debes seleccionar la sucursal ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CmbTipoUsuario.Focus();
                    return false;
                }
                if (this.TxtUsuario.Text == string.Empty || this.TxtUsuario.Text == "")
                {
                    MessageBox.Show("Debes ingresar un usuario ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtUsuario.Focus();
                    return false;
                }
                if (this.TxtContraseña.Text == string.Empty || this.TxtContraseña.Text == "")
                {
                    MessageBox.Show("Debes ingresar una contraseña ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtContraseña.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GuardarUsuario()
        {
            try
            {
                Val = new Validaciones();
                int Verificador = 0;
                Usuario_Negocio catalogoNegocio = new Usuario_Negocio();
                Usuario usuario = new Usuario();
                this.ObtenerDatos(usuario);
                if (infoUsuario.Id_U != null)
                {
                    usuario.Id_U = infoUsuario.Id_U;
                    catalogoNegocio.ModificarUsuario(usuario, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
                else
                {
                    usuario.Id_U = Comun.Id_U;
                    catalogoNegocio.InsertarUsuario(usuario, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatos(Usuario usuario)
        {
            try
            {
                usuario.U_Nombre = this.TxtNombre.Text;
                usuario.U_Apellidop = this.TxtApellidoPaterno.Text;
                usuario.U_Apellidom = this.TxtApellidoMaterno.Text;
                usuario.U_FechaNac = Convert.ToDateTime(this.DtmFechaNac.Text);
                usuario.U_DirCalle = this.TxtCalle.Text;
                usuario.U_DirColonia = this.TxtColonia.Text;
                usuario.U_DirNumero = this.TxtNumero.Text;
                usuario.Id_Tu = Convert.ToInt32(this.CmbTipoUsuario.SelectedValue);
                usuario.id_sucursal = this.CmbSucursal.SelectedValue.ToString();
                usuario.Cu_User = this.TxtUsuario.Text;
                if (infoUsuario.Cu_Pass != this.TxtContraseña.Text)
                {
                    usuario.BanPass = 1;
                    usuario.Cu_Pass = this.TxtContraseña.Text;
                }
                else
                {
                    usuario.BanPass = 0;
                    usuario.Cu_Pass = infoUsuario.Cu_Pass;
                }
                usuario.Id_UModifico = Comun.Id_U;
                usuario.Id_Turno = Convert.ToInt32(this.CmbTurno.SelectedValue);
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
                this.TxtNombre.Text = infoUsuario.U_Nombre;
                this.TxtApellidoPaterno.Text = infoUsuario.U_Apellidop;
                this.TxtApellidoMaterno.Text = infoUsuario.U_Apellidom;
                this.DtmFechaNac.Text = infoUsuario.U_FechaNac.ToShortDateString();
                this.TxtCalle.Text = infoUsuario.U_DirCalle;
                this.TxtColonia.Text = infoUsuario.U_DirColonia;
                this.TxtNumero.Text = infoUsuario.U_DirNumero;
                Comun.id_sucursal = infoUsuario.id_sucursal;
                this.CmbTipoUsuario.SelectedValue = infoUsuario.Id_Tu;
                this.CmbSucursal.SelectedValue = infoUsuario.id_sucursal.ToString();
                this.TxtUsuario.Text = infoUsuario.Cu_User;
                this.TxtContraseña.Text = infoUsuario.Cu_Pass;
                this.CmbTurno.SelectedValue = infoUsuario.Id_Turno;
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
                if (Verificador == 3)
                {
                    Val.Mensaje("Existe ese usuario", this);
                    this.TxtUsuario.Focus();
                }
                else if (Verificador == 2)
                {
                    Val.Mensaje("Existe una Usuario con el mismo nombre y apellidos", this);
                    this.TxtNombre.Focus();
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
        #endregion 
    }
}
