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

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCatSubMarcasV2 : MaterialForm
    {
        private Validaciones Val;
        private SubMarca infoSubMarca;
        private bool _Exception = true;
        public bool Exception
        {
            get { return _Exception; }
            set { _Exception = value; }
        }

        public frmCatSubMarcasV2(SubMarca submarca)
        {
            try
            {
                InitializeComponent();
                this.infoSubMarca = submarca;
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Métodos
        private void GuardarSubMarca()
        {
            try
            {
                Val = new Validaciones();
                int Verificador = 0;
                SubMarca_Negocio submarcaNegocio = new SubMarca_Negocio();
                SubMarca submarca = new SubMarca();
                this.ObtenerDatos(submarca);
                if (infoSubMarca.id_submarca != 0)
                {
                    submarca.id_submarca = infoSubMarca.id_submarca;
                    submarcaNegocio.ModificarSubMarca(submarca, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
                else
                {
                    submarcaNegocio.InsertarSubMarca(submarca, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatos(SubMarca submarca)
        {
            try
            {
                submarca.nombreSubMarca = this.TxtNombreSubMarca.Text;
                submarca.id_marca = Convert.ToInt32(this.CmbMarca.SelectedValue);
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
                if (infoSubMarca.id_submarca != 0)
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
                this.TxtNombreSubMarca.Text = infoSubMarca.nombreSubMarca;
                this.CmbMarca.SelectedValue = infoSubMarca.id_marca;
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
                this.infoSubMarca.lista_Marcas = new List<SubMarca>();
                SubMarca_Negocio SubMarca_Negocio = new SubMarca_Negocio();
                SubMarca_Negocio.CargarComboMarcas(Comun.Conexion, ref this.infoSubMarca);
                this.CmbMarca.DataSource = this.infoSubMarca.lista_Marcas;
                this.CmbMarca.ValueMember = "id_marca";
                this.CmbMarca.DisplayMember = "nombreMarca";
                /*this.info.lista_Turno = new List<Usuario>();
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
                this.CmbSucursal.DisplayMember = "Nombre_Sucursal";*/
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
                    Val.Mensaje("Ya existe la submarca", this);
                    this.TxtNombreSubMarca.Focus();
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
                if (this.TxtNombreSubMarca.Text == string.Empty || this.TxtNombreSubMarca.Text == "")
                {
                    MessageBox.Show("Debes ingresar una submarca ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtNombreSubMarca.Focus();
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
                    this.GuardarSubMarca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void TxtNombreSubMarca_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
    }
}
