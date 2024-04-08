using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;
using System.Windows.Forms;
using CreativaSL.LibControls.WinForms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCatCamionesV2 : MaterialForm
    {
        private Camion cm;

        #region Constructor

        public frmCatCamionesV2()
        {
            try
            {
                InitializeComponent();
                this.inicializarCombos();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public frmCatCamionesV2(Camion cam)
        {
            try
            {
                InitializeComponent();
                this.inicializarCombos();
                cm = cam;
                this.llenarDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos

        private void llenarDatos()
        {
            try
            {
                this.cmbMarcas.SelectedValue = cm.id_marca;
                this.cmbSubmarcas.SelectedValue = cm.id_submarca;
                this.cmbTipoCamion.SelectedValue = cm.id_Tipocamion;
                this.cmbDisenio.SelectedValue = cm.id_diseniocamion;
                this.txtDescripcion.Text = cm.descripcion;
                this.txtCaracteristicas.Text = cm.caracteristicas;
                this.txtnumCamion.Text = cm.num_camion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void inicializarCombos()
        {
            try
            {
                this.llenarComboTipoCamion();
                this.llenarComboMarcas();
                //this.llenarComboSubMarcas();
                this.llenarComboDisenios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarComboTipoCamion()
        {
            try
            {
                Camion_Negocio cn = new Camion_Negocio();
                Camion tipos = new Camion(Comun.Conexion);
                tipos = cn.obtener_tiposCamiones(tipos);
                this.cmbTipoCamion.DataSource = tipos.lista_tipoCam;
                this.cmbTipoCamion.ValueMember = "id_Tipocamion";
                this.cmbTipoCamion.DisplayMember = "tipoCamion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarComboMarcas()
        {
            try
            {
                Camion_Negocio cn = new Camion_Negocio();
                Camion marcas = new Camion(Comun.Conexion);
                marcas = cn.obtener_marcas(marcas);
                this.cmbMarcas.DataSource = marcas.lista_marcas;
                this.cmbMarcas.ValueMember = "id_marca";
                this.cmbMarcas.DisplayMember = "marca";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarComboSubMarcas(Camion marca)
        {
            try
            {
                Camion_Negocio cn = new Camion_Negocio();
                Camion submarcas = new Camion(Comun.Conexion);
                submarcas.id_marca = marca.id_marca;
                submarcas = cn.obtener_submarcasxmarca(submarcas);
                this.cmbSubmarcas.DataSource = submarcas.lista_submarcas;
                this.cmbSubmarcas.ValueMember = "id_submarca";
                this.cmbSubmarcas.DisplayMember = "submarca";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarComboDisenios()
        {
            try
            {
                Camion_Negocio cn = new Camion_Negocio();
                Camion disenios = new Camion(Comun.Conexion);
                disenios = cn.obtener_diseniosCamiones(disenios);
                this.cmbDisenio.DataSource = disenios.lista_disenios;
                this.cmbDisenio.ValueMember = "id_diseniocamion";
                this.cmbDisenio.DisplayMember = "descripciondisenio";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Camion obtenerDatos()
        {
            try
            {
                Camion camion = new Camion(Comun.Conexion);
                Camion marca = (Camion)this.cmbMarcas.SelectedItem;
                Camion submarca = (Camion)this.cmbSubmarcas.SelectedItem;
                Camion tipo = (Camion)this.cmbTipoCamion.SelectedItem;
                Camion disenio = (Camion)this.cmbDisenio.SelectedItem;
                camion.id_marca = marca.id_marca;
                camion.id_submarca = submarca.id_submarca;
                camion.id_Tipocamion = tipo.id_Tipocamion;
                camion.descripcion = this.txtDescripcion.Text;
                camion.caracteristicas = this.txtCaracteristicas.Text;
                camion.num_camion = this.txtnumCamion.Text;
                camion.id_diseniocamion = disenio.id_diseniocamion;
                if (cm != null)
                    camion.id_camion = cm.id_camion;
                return camion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos

        private void frmCatCamiones_Load(object sender, EventArgs e)
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

        private void btnVerDiseñoCamion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbDisenio.SelectedIndex != 0)
                {
                    DisenioCamion Diseño = new DisenioCamion();
                    DataTable DatosCamion = new DataTable();
                    Camion_Negocio camion = new Camion_Negocio();
                    Camion disenio = (Camion)this.cmbDisenio.SelectedItem;
                    camion.ObtenerDatosCamion(Comun.Conexion, ref DatosCamion, this.cmbDisenio.SelectedValue.ToString());
                    Diseño.TablaObjetos = DatosCamion;
                    Diseño.Nombre = disenio.descripciondisenio.ToString();
                    Diseño.id_disenioCamion = this.cmbDisenio.SelectedValue.ToString();
                    Diseño.Descripcion = disenio.descripciondisenio.ToString();
                    frmCatDisenioV2 frmd = new frmCatDisenioV2(Diseño, 2);
                    frmd.ShowDialog();
                    frmd.Dispose();
                }
                else
                {
                    MessageBox.Show("Seleccione Un Diseño", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Camion_Negocio cn = new Camion_Negocio();
                if (cm != null)
                    cn.modificarCamion(this.obtenerDatos());
                else
                    cn.agregarCamion(this.obtenerDatos());
                MessageBox.Show("Los datos se registraron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                this.txt_mensaje.Visible = true;
                this.txt_mensaje.Text = ex.Message;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Camion marca = (Camion)this.cmbMarcas.SelectedItem;
                this.llenarComboSubMarcas(marca);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void txtnumCamion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones valida = new Validaciones();
                valida.SoloNumerico(e);
            }
            catch (Exception ex)
            {
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones valida = new Validaciones();
                valida.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
            }
        }

        private void txtCaracteristicas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones valida = new Validaciones();
                valida.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
            }
        }

        private void cmbTipoCamion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = true;
            }
            catch (Exception ex)
            {
            }

        }

        private void cmbMarcas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void cmbSubmarcas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void cmbDisenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = true;
            }
            catch (Exception ex)
            {
            }
        }

        #endregion
    }
}
