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
    public partial class frmCatMarcas : Form_Creativa
    {
        private Validaciones Val;
        private Marca infoMarca;
        private bool _Exception = true;
        public bool Exception
        {
            get { return _Exception; }
            set { _Exception = value; }
        }
        public frmCatMarcas(Marca marca)
        {
            try
            {
                InitializeComponent();
                this.infoMarca = marca;
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Métodos
        private void GuardarMarca()
        {
            try
            {
                Val = new Validaciones();
                int Verificador = 0;
                Marca_Negocio marcaNegocio = new Marca_Negocio();
                Marca marca = new Marca();
                this.ObtenerDatos(marca);
                if (infoMarca.id_marca != 0)
                {
                    marca.id_marca = infoMarca.id_marca;
                    marcaNegocio.ModificarMarca(marca, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
                else
                {
                    marcaNegocio.InsertarMarca(marca, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerDatos(Marca marca)
        {
            try
            {
                marca.nombreMarca = this.TxtNombreMarca.Text;
                //marca.Id_UModifico = Comun.Id_U;
                //marca.Id_Turno = Convert.ToInt32(this.CmbTurno.SelectedValue);
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
                if (infoMarca.id_marca != 0)
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
                this.TxtNombreMarca.Text = infoMarca.nombreMarca;
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
                    Val.Mensaje("Ya existe la marca", this);
                    this.TxtNombreMarca.Focus();
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
                if (this.TxtNombreMarca.Text == string.Empty || this.TxtNombreMarca.Text == "")
                {
                    MessageBox.Show("Debes ingresar una marca", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtNombreMarca.Focus();
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
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos())
                {
                    this.GuardarMarca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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

        private void TxtNombreMarca_KeyPress(object sender, KeyPressEventArgs e)
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
