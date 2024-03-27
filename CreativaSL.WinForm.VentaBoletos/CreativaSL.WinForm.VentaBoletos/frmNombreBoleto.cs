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
    public partial class frmNombreBoleto : Form
    {
        private Boleto infoBoletos;
        private Validaciones Val;
        public frmNombreBoleto(Boleto Boleto)
        {
            try
            {
                InitializeComponent();
                this.infoBoletos = Boleto;
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos())
                {
                    this.GuadarNombreBoletos();
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
        #region Metodos Generales
        private void Inicializar()
        {
            try
            {
                if (infoBoletos.id_boleto != null)
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
                this.txt_C_nombre.Text = infoBoletos.cliente_nombre.ToString();
                this.DtmFechaNac.Value = infoBoletos.fechaNacimientoV;
                this.txt_C_numerotelefono.Text = infoBoletos.numeroTelefono.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GuadarNombreBoletos()
        {
            try
            {
                int Verificador = 0;
                Boleto Boleto = new Boleto(Comun.Conexion);
                VentaBoleto_Negocio VentaBoleto_Negocio = new VentaBoleto_Negocio();
                this.ObtenerDatos(Boleto);
                if (Boleto.id_boleto != null)
                {
                    VentaBoleto_Negocio.ModificarNombreBoleto(Comun.Conexion, Boleto, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatos(Boleto Boleto)
        {
            try
            {
                Boleto.id_boleto = infoBoletos.id_boleto;
                Boleto.cliente_nombre = txt_C_nombre.Text.ToString();
                Boleto.fechaNacimientoV = this.DtmFechaNac.Value;
                Boleto.numeroTelefono = this.txt_C_numerotelefono.Text.ToString();
                Boleto.id_caja = Comun.id_caja;
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
                    MessageBox.Show("Escriba el nombre del boleto", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmNombreBoleto_Load(object sender, EventArgs e)
        {

        }
    }
}
