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
        private Boleto infoBoletos;
        private Validaciones Val;
        public frmFacturaV1(Boleto Boleto)
        {
            InitializeComponent();
            this.infoBoletos = Boleto;
            loadMaterial(this);
            this.Inicializar();
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
                this.TxtNombre.Text = infoBoletos.cliente_nombre.ToString();
                this.TxtTelefono.Text = infoBoletos.numeroTelefono.ToString();
                this.DtmFechaNac.Value = infoBoletos.fechaNacimientoV;
                //this.DtmFechaNac.Value = infoBoletos.fechaNacimientoV;
                //this.txt_C_numerotelefono.Text = infoBoletos.numeroTelefono.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
