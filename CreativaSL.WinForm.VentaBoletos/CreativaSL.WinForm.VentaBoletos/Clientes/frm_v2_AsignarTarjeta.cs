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
    public partial class frm_v2_AsignarTarjeta : Form
    {

        #region Propiedades / Variables globales
        public String FolioCliente;
        private bool EsGenerar = false;
        private bool SinFolio = true;
        private Validaciones Val;
        V2TarejetaGrid_Negocio Model { get; set; }
        #endregion
        #region Constructor
        public frm_v2_AsignarTarjeta(String _Folio)
        {
            try
            {
                InitializeComponent();
                FolioCliente = _Folio;
                lblCantidad.Visible = false;
                lblCantidad2.Visible = false;
                txtCantidad.Visible = false;
                Model = new V2TarejetaGrid_Negocio(Comun.Conexion);
                IniciarForm();
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_Cliente ~ frm_v2_Cliente()");

                throw ex;
            }
        }
        public frm_v2_AsignarTarjeta(bool _EsGenrar)
        {
            try
            {
                InitializeComponent();
                EsGenerar = _EsGenrar;
                SinFolio = false;
                Model = new V2TarejetaGrid_Negocio(Comun.Conexion);
                button_Creativa1.Text = "Generar";
                button_Creativa1.ImageNormal = Properties.Resources._34busqueda;
                lblCantidad.Visible = true;
                lblCantidad2.Visible = true;
                txtCantidad.Visible = true;
                IniciarForm();
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_Cliente ~ frm_v2_Cliente()");

                throw ex;
            }
        }
        #endregion
        #region Metodos
        private void IniciarForm()
        {
            try
            {
                List<V2Tarjeta> tarjeta = Model.ObtenerDatosClientesXPagina();
                Model.LlenarLista(Model.ObtenerDatosClientesXPagina());
                BindearGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BindearGrid()
        {
            try
            {
                dgvTarjetas.AutoGenerateColumns = false;
                dgvTarjetas.DataSource = Model.ListaTarjetaBL;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Object ObtenerDatos()
        {
            Object Datos = new Object();
            this.ObtenerDatosGridTarjeta(ref Datos);
            return Datos;
        }

        private void ObtenerDatosGridTarjeta(ref Object Datos)
        {
            try
            {
                V2Tarjeta Tarjeta = new V2Tarjeta();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    Tarjeta.Folio = row.Cells["Folios"].Value.ToString();
                    Tarjeta.IDTarjeta = Convert.ToInt32(row.Cells["IDTarjetas"].Value.ToString());
                }
                Datos = Tarjeta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<DataGridViewRow> ObtenerFilaSeleccionada()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dgvTarjetas.Rows)
                {
                    if (row.Selected)
                    {
                        rowSelected.Add(row);
                    }
                }
                return rowSelected;
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
                    MessageBox.Show("Solo se pueden generar folios una vez al día", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (Verificador == 1)
                {
                    MessageBox.Show("Folios generados corectamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Model.LlenarLista(Model.ObtenerDatosClientesXPagina());
                }
                if (Verificador == 3)
                {
                    MessageBox.Show("Se alcanzo el limite de folios", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Model.LlenarLista(Model.ObtenerDatosClientesXPagina());
                }
                else if (Verificador == 0)
                {
                    MessageBox.Show("No se genero correctamente. ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Eventos
        private void dgvTarjetas_ScrollMax(object sender, EventArgs e)
        {
            try
            {
                Model.NextPage();
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_AsignarTarjeta ~ dgvTarjetas_ScrollMax");
                MessageBox.Show("Error al cargar los datos.", "Sistema Venta de Boletos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_Creativa1_Click(object sender, EventArgs e)
        {
            try
            {

                if (EsGenerar)
                {
                    if (ValidarCampos())
                    {
                        int Verificador = 0;
                        int cantidad = Convert.ToInt32(this.txtCantidad.Text);
                        Model.GenerarFolio(ref Verificador, cantidad);
                        this.VerifcarMensajeAccion(Verificador);
                        //IniciarForm();
                    }
                }
                else
                {
                    V2Tarjeta datos = (V2Tarjeta)this.ObtenerDatos();
                    if (datos.IDTarjeta != 0)
                    {
                        FolioCliente = datos.Folio;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un folio.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
             {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private bool ValidarCampos()
        {
            try
            {
                if (this.txtCantidad.Text.Length == 0)
                {
                    this.txtCantidad.Focus();
                    MessageBox.Show("Ingrese una cantidad ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (Convert.ToInt32(this.txtCantidad.Text) <= 0)
                {
                    this.txtCantidad.Focus();
                    MessageBox.Show("Ingrese otra cantidad ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtPorcentaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
