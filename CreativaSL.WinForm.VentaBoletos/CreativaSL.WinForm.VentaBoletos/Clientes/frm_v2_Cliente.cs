using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CreativaSL.WinForm.VentaBoletos.Clientes
{
    public partial class frm_v2_Cliente : Form
    {
        #region Propiedades / Variables globales
        private V2ClienteGrid_Negocio Model { get; set; }
        private bool EsGenerar = true;
        #endregion
        #region Constructor
        public frm_v2_Cliente()
        {
            try
            {
                InitializeComponent();
                Model = new V2ClienteGrid_Negocio(Comun.Conexion);
                IniciarForm();
            }
            catch(Exception ex)
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
                LlenarCombo();
                IniciarBinding();
                Model.Reset();
                Model.LlenarLista(Model.ObtenerDatosClientesXPagina());
                BindearGrid();
                ActiveControl = TxtBusqueda;
                TxtBusqueda.Focus();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void LlenarCombo()
        {
            try
            {
                //CmbTipoBusqueda.DrawMode = DrawMode.OwnerDrawFixed;
                //CmbTipoBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbTipoBusqueda.DataSource = Model.ObtenerMenuTipoBusqueda();
                CmbTipoBusqueda.ValueMember = "IDTipoBusqueda";
                CmbTipoBusqueda.DisplayMember = "Descripcion";
                if (CmbTipoBusqueda.Items.Count > 0)
                {
                    Model.ItemTipoBusqueda = CmbTipoBusqueda.Items[0] as TipoBusqueda;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarBinding()
        {
            try
            {
                TxtBusqueda.DataBindings.Add("Text", Model, "TextoBusqueda", true, DataSourceUpdateMode.OnPropertyChanged);
                CmbTipoBusqueda.DataBindings.Add("SelectedItem", Model, "ItemTipoBusqueda", true, DataSourceUpdateMode.OnPropertyChanged);
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
                dgvClientes.AutoGenerateColumns = false;
                dgvClientes.DataSource = Model.ListaClientesBL;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Object ObtenerDatos()
        {
            Object Datos = new Object();
            this.ObtenerDatosGridCliente(ref Datos);
            return Datos;
        }
        private void ObtenerDatosGridCliente(ref Object Datos)
        {
            try
            {
                V2Cliente Cliente = new V2Cliente();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    Cliente.IDCliente = Convert.ToInt32(row.Cells["IDCliente"].Value.ToString());
                    Cliente.CodigoTarjeta = row.Cells["Codigo"].Value.ToString();
                    Cliente.Nombre = row.Cells["Nombre"].Value.ToString();
                }
                Datos = Cliente;
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
                foreach (DataGridViewRow row in dgvClientes.Rows)
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
        public void VerificarMensajeAccion(int verificador)
        {
            try
            {
                if (verificador == 1)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Model.Reset();
                    Model.LlenarLista(Model.ObtenerDatosClientesXPagina());
                    //Hacer que se vuelva generar el GRID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion
        #region Eventos
        private void DgvClientes_ScrollMax(object sender, EventArgs e)
        {
            try
            {
                Model.NextPage();
            }
            catch(Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_Cliente ~ DgvClientes_ScrollMax");
                MessageBox.Show("Error al cargar los datos.", "Sistema Venta de Boletos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.EsBusqueda = true;
                Model.Reset();
                Model.LlenarLista(Model.ObtenerDatosClientesXPagina());
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_Cliente ~ btnBuscar_Click");
                MessageBox.Show("Error al cargar los datos.", "Sistema Venta de Boletos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_Cliente ~ btnSalir_Click");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frm_v2_ClienteAdd Add = new frm_v2_ClienteAdd();
            Add.ShowDialog();
            Add.Dispose();
            Model.Reset();
            Model.LlenarLista(Model.ObtenerDatosClientesXPagina());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                V2Cliente datos = (V2Cliente)this.ObtenerDatos();
                if (datos.IDCliente != 0)
                {
                    frm_v2_ClienteAdd Add = new frm_v2_ClienteAdd(datos.IDCliente);
                    Add.ShowDialog();
                    Add.Dispose();
                    Model.Reset();
                    Model.LlenarLista(Model.ObtenerDatosClientesXPagina());
                    //if(Add.Completo)
                    //{
                    //    Model.Reset();
                    //    Model.LlenarLista(Model.ObtenerDatosClientesXPagina());
                    //}
                }
                else
                {
                    MessageBox.Show("Seleccione un Cliente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                frm_v2_AsignarTarjeta generar = new frm_v2_AsignarTarjeta(EsGenerar);
                generar.ShowDialog();
                generar.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                V2Cliente datos = (V2Cliente)this.ObtenerDatos();
                if (datos.IDCliente != 0)
                {
                    if (MessageBox.Show("¿Desea eliminar este Registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int verificador = 0;
                        V2Cliente_Negocio negocio = new V2Cliente_Negocio(Comun.Conexion, false, datos.IDCliente, Comun.Id_U);
                        negocio.Eliminar(ref verificador);
                        VerificarMensajeAccion(verificador);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Cliente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        
        private void btnAsignarTarjeta_Click(object sender, EventArgs e)
        {
            try
            {
                V2Cliente datos = (V2Cliente)this.ObtenerDatos();
                if (datos.IDCliente != 0)
                {
                    frm_v2_CambiarTarjeta Add = new frm_v2_CambiarTarjeta(datos);
                    Add.ShowDialog();
                    Add.Dispose();
                    if(Add.completo)
                    {
                        Model.Reset();
                        Model.LlenarLista(Model.ObtenerDatosClientesXPagina());
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Cliente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion
    }
}
