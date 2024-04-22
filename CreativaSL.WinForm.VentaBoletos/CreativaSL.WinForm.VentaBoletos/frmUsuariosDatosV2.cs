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

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmUsuariosDatosV2 : MaterialForm
    {
        public frmUsuariosDatosV2()
        {
            try
            {
                InitializeComponent();
                loadMaterial(this);
                this.Inicializar();
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
                this.TxtNombre.Text = Comun.U_Nombre;
                this.TxtApellidoPaterno.Text = Comun.U_Apellidop;
                this.TxtApellidoMaterno.Text = Comun.U_Apellidom;
                this.TxtTipoUsuario.Text = Comun.CTU_TipoUsuario;
                this.TxtUsuario.Text = Comun.Cu_User;
                this.TxtContraseña.Text = Comun.Cu_Pass;
                this.Txt_FechaHoraIngreso.Text = Comun.FechaIngreso.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                int Verificador = 0;
                Usuario_Negocio usuario_negocio = new Usuario_Negocio();
                usuario_negocio.CambiarContraseñaUsuario(Comun.Conexion, Comun.Cu_User, this.TxtContraseña.Text, ref Verificador);
                if (Verificador == 1)
                    MessageBox.Show("Cambio de contraseña guardada con exito", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
