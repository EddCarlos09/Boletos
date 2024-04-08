using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCatTerminalesV2 : MaterialForm
    {
        Terminal trm;

        #region Constructor

        public frmCatTerminalesV2()
        {
            try
            {
                InitializeComponent();
                this.llenarCombos();
                this.cmbPais.SelectedValue = 143;
                this.cmbPais.Enabled = false;
                
            }
            catch (Exception ex)
            {
                this.txt_mensaje.Visible = true;
                this.txt_mensaje.Text = ex.Message;
            }
        }

        public frmCatTerminalesV2(Terminal term)
        {
            try
            {
                InitializeComponent();
                this.llenarCombos();
                trm = term;
                this.llenarDatos();
                this.cmbPais.Enabled = false;
                
            }
            catch (Exception ex)
            {
                this.txt_mensaje.Visible = true;
                this.txt_mensaje.Text = ex.Message;
            }
        }

        #endregion

        #region Métodos

        private void llenarCombos()
        {
            try
            {
                this.llenarComboPaises();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarComboPaises()
        {
            try
            {
                Terminal paises = new Terminal(Comun.Conexion);
                Terminal_Negocio tn = new Terminal_Negocio();
                paises = tn.llenarGridPaises(paises);
                this.cmbPais.DataSource = paises.paises;
                this.cmbPais.DisplayMember = "pais";
                this.cmbPais.ValueMember = "id_pais";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarComboEstados(Terminal pais)
        {
            try
            {
                Terminal_Negocio tn = new Terminal_Negocio();
                pais = tn.llenarGridEstados(pais);
                this.cmbEstado.DataSource = pais.estados;
                this.cmbEstado.DisplayMember = "estado";
                this.cmbEstado.ValueMember = "id_estado";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarComboMunicipio(Terminal pais)
        {
            try
            {
                Terminal_Negocio tn = new Terminal_Negocio();
                pais = tn.llenarGridMunicipios(pais);
                this.cmbMunicipio.DataSource = pais.municipios;
                this.cmbMunicipio.DisplayMember = "municipio";
                this.cmbMunicipio.ValueMember = "id_municipio";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Terminal obtenerDatos()
        {
            try
            {
                Terminal pais = (Terminal)this.cmbPais.SelectedItem;
                Terminal estado = (Terminal)this.cmbEstado.SelectedItem;
                Terminal municipio = (Terminal)this.cmbMunicipio.SelectedItem;
                Terminal terminal = new Terminal(Comun.Conexion);
                terminal.id_usuario = Comun.Id_U;
                terminal.nombre = this.txtNombreSucursal.Text;
                terminal.telefonos = this.txtTelefono.Text;
                terminal.direccion = this.txtDireccion.Text;
                terminal.id_pais = pais.id_pais;
                terminal.id_estado = estado.id_estado;
                terminal.id_municipio = municipio.id_municipio;
                if (trm != null)
                    terminal.id_terminal = trm.id_terminal;
                return terminal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarDatos()
        {
            try
            {
                this.txtNombreSucursal.Text = trm.nombre;
                this.cmbPais.SelectedValue = trm.id_pais;
                this.cmbEstado.SelectedValue = trm.id_estado;
                this.cmbMunicipio.SelectedValue = trm.id_municipio;
                this.txtDireccion.Text = trm.direccion;
                this.txtTelefono.Text = trm.telefonos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                Terminal_Negocio tn = new Terminal_Negocio();
                if (trm != null)
                    tn.modificarTerminal(obtenerDatos());
                else
                    tn.registrarTerminal(obtenerDatos());
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

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Terminal pais = (Terminal)this.cmbPais.SelectedItem;
                this.llenarComboEstados(pais);
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Terminal pais = (Terminal)this.cmbPais.SelectedItem;
                Terminal estado = (Terminal)this.cmbEstado.SelectedItem;
                pais.id_estado = estado.id_estado;
                this.llenarComboMunicipio(pais);
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void txtNombreSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones validar = new Validaciones();
                validar.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones validar = new Validaciones();
                validar.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones validar = new Validaciones();
                validar.SoloNumerico(e);
            }
            catch (Exception ex)
            {
            }
        }

        private void frmCatTerminales_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
