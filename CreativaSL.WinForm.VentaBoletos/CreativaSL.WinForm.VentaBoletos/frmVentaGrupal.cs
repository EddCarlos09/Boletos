using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmVentaGrupal : Form
    {
        public bool _banVentaGrupal = false;
        public BoletosGrupal infoBoletosGrupal;
        public frmVentaGrupal(BoletosGrupal boletosGrupal)
        {
            InitializeComponent();
            infoBoletosGrupal = boletosGrupal;
        }

        private void brn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                _banVentaGrupal = false;
                infoBoletosGrupal.nombre = "";
                infoBoletosGrupal.fechaNacimiento = DateTime.Now;
                infoBoletosGrupal.numeroTelefono = "";
                infoBoletosGrupal.ventaGrupal = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    _banVentaGrupal = true;
                    infoBoletosGrupal.nombre = this.txt_nombre.Text;
                    infoBoletosGrupal.fechaNacimiento = this.dtpFechaNacimiento.Value;
                    infoBoletosGrupal.numeroTelefono = this.txt_numeroTelefono.Text;
                    infoBoletosGrupal.ventaGrupal = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones val = new Validaciones();
                val.TextoNumerosPuntoGuionTilde(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_numeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones val = new Validaciones();
                val.TextoNumerosPuntoGuionTilde(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            try
            {
                Validaciones Val = new Validaciones();
                if (this.txt_nombre.Text == string.Empty || this.txt_nombre.Text == "")
                {
                    MessageBox.Show("Debes ingresar el nombre", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_nombre.Focus();
                    return false;
                }
                else if (this.txt_numeroTelefono.Text == string.Empty || this.txt_numeroTelefono.Text == "")
                {
                    MessageBox.Show("Debes ingresar el número de teléfono", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txt_numeroTelefono.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
