using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativaSL.WinForm.VentaBoletos.Clientes
{
    public partial class frm_v2_ClasificacionUsuario : Form
    {
        /*
        private ClasificacionClienteGrid_Negocio Model { get; set; }

        #region CONSTRUCTOR
        public frm_v2_ClasificacionUsuario()
        {
            try
            {
                InitializeComponent();
                Model = new ClasificacionClienteGrid_Negocio(Comun.Conexion);
                IniciarForm();
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_Cliente ~ frm_v2_Cliente()");
                throw ex;
            }
        }
        #endregion

        #region METODOS
        private void IniciarForm()
        {
            try
            {
                LlenarCombo();
                IniciarBinding();
                Model.Reset();
                Model.LlenarLista(Model.ObtenerDatosClasificacionClientesXPagina());
                BindearGrid();
                ActiveControl = TxtBusqueda;
                TxtBusqueda.Focus();
            }
            catch (Exception ex)
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
                //CmbTipoBusqueda.DataSource = Model.ObtenerMenuTipoBusqueda();
                List<TipoBusqueda> Lista = new List<TipoBusqueda>();
                Lista.Add(new TipoBusqueda { IDTipoBusqueda = 1, Descripcion = "Clasificación" });
                CmbTipoBusqueda.DataSource = Lista;
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

                List<ClasificacionCliente> Lista = new List<ClasificacionCliente>();
                //Lista.Add(new V2ClasificacionCliente { IDClasificacion = 1, Descripcion = "Cliente Frecuente", Porcentaje = 0.02m });
                //Lista.Add(new V2ClasificacionCliente { IDClasificacion = 2, Descripcion = "Cliente Preferente", Porcentaje = 0.025m });
                //Lista.Add(new V2ClasificacionCliente { IDClasificacion = 3, Descripcion = "Cliente Premium", Porcentaje = 0.03m });
                //Lista.Add(new V2ClasificacionCliente { IDClasificacion = 3, Descripcion = "Cliente VIP", Porcentaje = 0.04m });

                dgvClientes1.AutoGenerateColumns = false;
                dgvClientes1.DataSource = Lista;
                dgvClientes1.DataSource = Model.ListaClasificacionClienteBL;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DgvClientes_ScrollMax(object sender, EventArgs e)
        {
            try
            {
                //Model.NextPage();
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_Cliente ~ DgvClientes_ScrollMax");
                MessageBox.Show("Error al cargar los datos.", "Sistema Venta de Boletos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Object ObtenerDatosCc()
        {
            Object Datos = new Object();
            this.ObtenerDatosGridClasificacionCliente(ref Datos);
            return Datos;
        }

        private void ObtenerDatosGridClasificacionCliente(ref Object Datos)
        {
            try
            {
                ClasificacionCliente Clasificacion = new ClasificacionCliente();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    Clasificacion.IDClasificacion = Convert.ToInt32(row.Cells["dataGridViewIDClasificacionTextBoxColumn1"].Value.ToString());
                }
                Datos = Clasificacion;
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
                foreach (DataGridViewRow row in dgvClientes1.Rows)
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
                    Model.LlenarLista(Model.ObtenerDatosClasificacionClientesXPagina());
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

        #region EVENTOS
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.EsBusqueda = true;
                Model.Reset();
                Model.LlenarLista(Model.ObtenerDatosClasificacionClientesXPagina());
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_Cliente ~ btnBuscar_Click");
                MessageBox.Show("Error al cargar los datos.", "Sistema Venta de Boletos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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
            frm_v2_ClasificacionClienteAdd Add = new frm_v2_ClasificacionClienteAdd();
            if (!Add.IsDisposed)
            {
                if (Add.ShowDialog() == DialogResult.OK)
                {

                }
                Model.Reset();
                Model.LlenarLista(Model.ObtenerDatosClasificacionClientesXPagina());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ClasificacionCliente datos = (ClasificacionCliente)this.ObtenerDatosCc();
                if (datos.IDClasificacion != 0)
                {
                    if (MessageBox.Show("¿Desea eliminar este Registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int verificador = 0;
                        Clasificacion_Negocio neg = new Clasificacion_Negocio(Comun.Conexion, false, datos.IDClasificacion, Comun.Id_U);
                        neg.Eliminar(ref verificador);
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

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ClasificacionCliente datos = (ClasificacionCliente)this.ObtenerDatosCc();
                if (datos.IDClasificacion != 0)
                {
                    frm_v2_ClasificacionClienteAdd Add = new frm_v2_ClasificacionClienteAdd(datos.IDClasificacion);
                    if (!Add.IsDisposed)
                    {
                        if (Add.ShowDialog() == DialogResult.OK)
                        {

                        }
                        Model.Reset();
                        Model.LlenarLista(Model.ObtenerDatosClasificacionClientesXPagina());
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

        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private void dgvClientes1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_v2_ClasificacionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
        */
    }
}

