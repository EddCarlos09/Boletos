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
    public partial class frmCatChoferes : Form
    {
        private Chofer infoChofer;
        private Validaciones Val;
        public frmCatChoferes(Chofer chofer)
        {
            try
            {
                InitializeComponent();
                this.infoChofer = chofer;
                this.Inicializar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Eventos
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos())
                {
                    this.GuadarChofer();
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
        private void txt_C_nombre_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_C_aPat_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_C_aMat_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_C_curp_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_C_Observaciones_KeyPress(object sender, KeyPressEventArgs e)
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
        #region Metodos Generales
        private void Inicializar()
        {
            try
            {
                if (infoChofer.IDChofer != null)
                {
                    this.LLenarDatos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LLenarDatos()
        {
            try
            {
                this.txt_C_nombre.Text = infoChofer.Nombre.ToString();
                this.txt_C_aPat.Text = infoChofer.ApellidoPaterno.ToString();
                this.txt_C_aMat.Text = infoChofer.ApellidoMaterno.ToString();
                this.txt_C_curp.Text = infoChofer.Curp.ToString();
                this.DtmFechaNac.Value = infoChofer.FechaNacimiento.Value;
                this.txt_C_Observaciones.Text = infoChofer.Observaciones.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GuadarChofer()
        {
            try
            {
                int Verificador = 0;
                Chofer Chofer = new Chofer();
                Chofer_Negocio Chofer_Negocio = new Chofer_Negocio();
                this.ObtenerDatos(Chofer);
                if (Chofer.IDChofer != null)
                {
                    Chofer_Negocio.ModificarChofer(Comun.Conexion, Chofer, ref Verificador);
                }
                else
                {
                    Chofer_Negocio.InsertarChofer(Comun.Conexion, Chofer, ref Verificador);
                }
                this.VerifcarMensajeAccion(Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatos(Chofer Chofer)
        {
            try
            {
                Chofer.IDChofer = infoChofer.IDChofer;
                Chofer.Nombre = this.txt_C_nombre.Text.ToString();
                Chofer.ApellidoPaterno = this.txt_C_aPat.Text.ToString();
                Chofer.ApellidoMaterno = this.txt_C_aMat.Text.ToString();
                Chofer.Curp = this.txt_C_curp.Text.ToString();
                Chofer.FechaNacimiento = Convert.ToDateTime(this.DtmFechaNac.Value.ToString());
                Chofer.Observaciones = this.txt_C_Observaciones.Text.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarCampos()
        {
            Validaciones Val = new Validaciones();
            try
            {
                if (this.txt_C_nombre.Text.Length == 0)
                {
                    this.txt_C_nombre.Focus();
                    MessageBox.Show("Escriba el nombre ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.txt_C_aPat.Text.Length == 0)
                {
                    this.txt_C_aPat.Focus();
                    MessageBox.Show("Escriba el apellido paterno ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.txt_C_aPat.Text.Length == 0)
                {
                    this.txt_C_aPat.Focus();
                    MessageBox.Show("Escriba el apellido materno ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                    return true;
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
                    MessageBox.Show("Los datos se guardaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
