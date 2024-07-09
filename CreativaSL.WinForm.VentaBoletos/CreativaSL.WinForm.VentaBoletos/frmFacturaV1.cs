using CreativaSL.Dll.VentaBoletosGlobal;
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
    public partial class frmFacturaV1 : MaterialForm
    {
        private V2Cliente infoBoletos;
        private Validaciones Val;
        public frmFacturaV1(V2Cliente cliente)
        {
            InitializeComponent();
            this.infoBoletos = cliente;
            loadMaterial(this);
            this.Inicializar();
        }
        #region Metodos Generales
        private void Inicializar()
        {
            try
            {
                if (infoBoletos.IDCliente != null)
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
                this.TxtNombre.Text = infoBoletos.Nombre.ToString();
                this.TxtTelefono.Text = infoBoletos.Telefono.ToString();
                this.TxtCP.Text = infoBoletos.CodigoPostal.ToString();
                this.TxtDomicilio.Text = infoBoletos.Domicilio.ToString();
                this.TxtEmail.Text = infoBoletos.Email.ToString();
                this.TxtRFC.Text = infoBoletos.RFC.ToString();
                this.TxtCelular.Text = infoBoletos.TelefonoCelular.ToString();
                this.TxtColonia.Text = infoBoletos.Colonia.ToString();
                this.txtEstado.Text = infoBoletos.EstadoDesc.ToString();
                this.TxtEmpresa.Text = infoBoletos.Empresa.ToString();
                this.txtCiudad.Text = infoBoletos.MunicipioDesc.ToString();


                this.DtmFechaNac.Value = infoBoletos.FechaNacimiento;
                //this.DtmFechaNac.Value = infoBoletos.fechaNacimientoV;
                //this.txt_C_numerotelefono.Text = infoBoletos.numeroTelefono.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
