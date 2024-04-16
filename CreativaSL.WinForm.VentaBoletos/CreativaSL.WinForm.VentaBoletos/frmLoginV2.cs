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
using System.Configuration;
using MaterialSkin;
using System.Drawing.Drawing2D;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmLoginV2 : MaterialForm
    {
        #region Variables Globales

        private Usuario usuario;

        #endregion

        #region Constructor

        public frmLoginV2()
        {
            InitializeComponent();
            //Create a material theme manager and add the form to manage(this)
             MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Blue700, TextShade.WHITE);
            txt_mensaje.BackColor = Color.Red;


            //this.txtUsuario.Focus();
            // Configurar el estilo de los labels
            this.label4.ForeColor = Color.Navy; // Cambiar el color del texto
            this.label4.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            this.label2.ForeColor = Color.DimGray; // Cambiar el color del texto
            this.label3.ForeColor = Color.DimGray; // Cambiar el color del texto
            this.label2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            this.label3.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            buttonRadius.SetButtonRoundBorder(this.btnCancelar, 15); 
            buttonRadius.SetButtonRoundBorder(this.btnAceptar, 15); 

        }
    

        #endregion

        #region Eventos

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.validarDatosEntrada())
                {
                    iniciarSistema(this.txtUsuario.Text, this.txtContraseña.Text);
                    usuario = new Usuario();
                    usuario.Validador = 1;
                    usuario.id_sucursal = Comun.SucursalCaja;
                    usuario = this.obtenerDatosUsuario(usuario);
                    usuario.Conexion = Comun.Conexion;
                    usuario = this.ingresar(usuario);
                    if (usuario.Validador == 1)
                    {
                        if (usuario.id_sucursal == Comun.SucursalCaja)
                        {
                            if (usuario.Id_Tu == 1 || usuario.Id_Tu == 2 || usuario.Id_Tu == 3 || usuario.Id_Tu == 4)
                            {
                                if (usuario.Crearid_caja == false)
                                {
                                    frmCaja_AperturaCaja aperturaCaja = new frmCaja_AperturaCaja();
                                    aperturaCaja.ShowDialog();
                                    aperturaCaja.Dispose();
                                }
                                this.Visible = false;
                                frmHomeV2 home = new frmHomeV2();
                                home.ShowDialog();
                                if (home.Salir)
                                {
                                    home.Dispose();
                                    this.Close();
                                }
                                else
                                {
                                    home.Dispose();
                                    this.Visible = true;
                                    this.txtUsuario.Focus();
                                    this.txtUsuario.Text = "";
                                    this.txtContraseña.Text = "";
                                    this.txt_mensaje.Text = "";
                                    this.txt_mensaje.Visible = false;
                                }
                            }
                        }
                        else
                            this.datosIncorrectos(4);
                    }
                    else
                    {
                        this.datosIncorrectos(usuario.Validador);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 27)
                {
                    if (MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        Application.Exit();
                }
            }
            catch (Exception ex)
            {
                this.mensaje(ex.Message);
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
                throw new Exception("Ocurrió un error en caja de texto Contraseña" + ex.Message);
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
                this.mensaje(ex.Message);
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
                throw new Exception("Ocurrió un error en caja de texto Usuario" + ex.Message);
            }
        }
        #endregion

        #region Metodos

        private void datosIncorrectos(int opcion)
        {
            try
            {
                switch (opcion)
                {
                    case 2:
                        this.mensaje("Su cuenta esta bloqueada. Póngase en contacto con el Administrador.");
                        break;
                    case 3:
                        this.mensaje("No existe la cuenta");
                        break;
                    case 4:
                        this.mensaje("El usuario no está registrado para esta sucursal");
                        break;
                    case 5:
                        this.mensaje("Contraseña incorrecta");
                        break;
                    case 6:
                        this.mensaje("Su cuenta fue bloqueada. Póngase en contacto con el Administrador");
                        break;
                    case 7:
                        this.mensaje("Existe un cajero en el sistema para esta sucursal");
                        break;
                    case 8:
                        this.mensaje("No fue Localizada la caja. asigne una caja");
                        frmAsignarCaja frmac = new frmAsignarCaja();
                        frmac.ShowDialog();
                        frmac.Dispose();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Datos incorrectos" + ex.Message);
            }
        }
        private void iniciarSistema(string Cu_User, string Cu_Pass)
        {
            try
            {
                Comun.Conexion = ConfigurationManager.AppSettings.Get("strConnection");
                Comun_Negocio cm = new Comun_Negocio();
                cm.ObtenerSucursal(Comun.Conexion, Cu_User, Cu_Pass);
            }
            catch (Exception ex)
            {
                this.mensaje("Ocurrio un error: " + ex.Message + " El sistema debe cerrarse");
            }
        }
        private Usuario ingresar(Usuario usuario)
        {
            try
            {
                Login_Negocio login_negocio = new Login_Negocio();
                return (login_negocio.validarUsuario(usuario));
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar" + ex.Message);
            }
        }
        private void mensaje(string msj)
        {
            try
            {
                this.txt_mensaje.Text = msj;
                this.txt_mensaje.Visible = true;
            }
            catch (Exception ex)
            {
                this.mensaje(ex.Message);
            }
        }
        private Usuario obtenerDatosUsuario(Usuario usuario)
        {
            try
            {
                usuario.Cu_User = this.txtUsuario.Text;
                usuario.Cu_Pass = this.txtContraseña.Text;
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos" + ex.Message);
            }
        }
        private bool validarDatosEntrada()
        {
            try
            {
                if (this.txtUsuario.Text == "" || this.txtContraseña.Text == "")
                {
                    if (this.txtUsuario.Text == "")
                    {
                        this.txtUsuario.Focus();
                        this.mensaje("Debes ingresar usuario");
                    }
                    else if (this.txtContraseña.Text == "")
                    {
                        this.txtContraseña.Focus();
                        this.mensaje("Debes ingresar contraseña");
                    }
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar los datos" + ex.Message);
            }
        }
        #endregion

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    this.txtUsuario.Text = "AdminTGZ";
                    this.txtContraseña.Text = "AdminTGZ";
                }
                this.txtUsuario.Text = "AdminTGZ";
                this.txtContraseña.Text = "AdminTGZ";
            }
            catch (Exception ex)
            {
                this.mensaje(ex.Message);
            }
        }
    }
}
