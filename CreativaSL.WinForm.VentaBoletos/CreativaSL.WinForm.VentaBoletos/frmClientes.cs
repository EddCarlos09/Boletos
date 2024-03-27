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
    public partial class frmClientes : Form
    {

        int tipoCatalogo = 7;
        Cliente Clientes = new Cliente();

        public frmClientes()
        {
            try
            {
                InitializeComponent();
                this.CargarGridPropiedades();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarGridPropiedades();
                this.CargarGridCatalogos(1, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        #region MetodosGenerales
        private void Eliminar(Object obj)
        {
            try
            {
                if (this.tipoCatalogo == 7)
                {
                    this.EliminarCliente(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarGridPropiedades()
        {
            try
            {
                this.btnNuevo.Visible = true;
                this.btnEliminar.Visible = true;
                if (this.tipoCatalogo == 7)
                {
                    this.EstablecerPropiedadesGridClientes();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void CargarGridCatalogos(int TipoBusq, string BusquedaNombre)
        {
            try
            {
                if (this.tipoCatalogo == 7)
                {
                    this.CargarGridClientes(TipoBusq, BusquedaNombre);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarCatCatalogosNuevos()
        {
            try
            {
                if (this.tipoCatalogo == 7)
                {
                    frmCatClientes frmc = new frmCatClientes(new Cliente());
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos(1,"");
                    frmc.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarCatCatalogosModificar(Object obj)
        {
            try
            {
                if (this.tipoCatalogo == 7)
                {
                    frmCatClientes frmc = new frmCatClientes((Cliente)obj);
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos(1,"");
                    frmc.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Object ObtenerDatos()
        {
            Object Datos = new Object();
            if (this.tipoCatalogo == 7)
            {
                this.ObtenerDatosGridCliente(ref Datos);
            }
            return Datos;
        }
        #endregion
        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarCatCatalogosNuevos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarCatCatalogosModificar(this.ObtenerDatos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar este Registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Eliminar(this.ObtenerDatos());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion
        #region Grid

        #region GridCatClientes
        private void CargarGridClientes(int TipoBusq, string BusquedaNombre)
        {
            try
            {
                BuscarCliente_Negocio Buscar = new BuscarCliente_Negocio();
                Cliente Cliente = new Cliente();
                Buscar.BuscarGridCliente(Comun.Conexion, TipoBusq, ref Cliente, BusquedaNombre);
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = Cliente.Clientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridClientes()
        {
            try
            {
                var Headertexts = new List<string> { "Código Cliente", "Nombre", "Fecha Nacimiento", "Género", "Correo Electrónico", "Ocupación", "Estado Civil", "Curp", "País", "Estado", "Municipio", "Colonia","Monedero" };
                var Names = new List<string> { "IDCodigoEab", "NombreCompleto", "FechaNacimiento", "Genero", "CorreoElectronico", "Ocupacion", "EstadoCivil", "Curp", "Pais", "Estado", "Municipio", "Colonia","Monedero","IDCliente", "Nombre", "ApePat", "ApeMat", "IDGenero", "IDOcupacion", "IDPais", "IDEstado", "IDMunicipio", "IDEstadoCivil" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);
                this.GridViewGeneral.Columns[0].Visible = true;
                this.GridViewGeneral.Columns[1].Visible = true;
                this.GridViewGeneral.Columns[2].Visible = true;
                this.GridViewGeneral.Columns[3].Visible = true;
                this.GridViewGeneral.Columns[4].Visible = true;
                this.GridViewGeneral.Columns[5].Visible = true;
                this.GridViewGeneral.Columns[6].Visible = true;
                this.GridViewGeneral.Columns[7].Visible = true;
                this.GridViewGeneral.Columns[8].Visible = true;
                this.GridViewGeneral.Columns[9].Visible = true;
                this.GridViewGeneral.Columns[10].Visible = true;
                this.GridViewGeneral.Columns[11].Visible = true;
                this.GridViewGeneral.Columns[12].Visible = true;
                this.GridViewGeneral.Columns[13].Visible = false;
                this.GridViewGeneral.Columns[14].Visible = false;
                this.GridViewGeneral.Columns[15].Visible = false;
                this.GridViewGeneral.Columns[16].Visible = false;
                this.GridViewGeneral.Columns[17].Visible = false;
                this.GridViewGeneral.Columns[18].Visible = false;
                this.GridViewGeneral.Columns[19].Visible = false;
                this.GridViewGeneral.Columns[20].Visible = false;
                this.GridViewGeneral.Columns[21].Visible = false;
                this.GridViewGeneral.Columns[22].Visible = false;
                this.GridViewGeneral.Columns[23].Visible = false;
                this.GridViewGeneral.Columns[24].Visible = false;

                this.GridViewGeneral.Columns[0].Width = 150;
                this.GridViewGeneral.Columns[1].Width = 250;
                this.GridViewGeneral.Columns[2].Width = 150;
                this.GridViewGeneral.Columns[3].Width = 100;
                this.GridViewGeneral.Columns[4].Width = 200;
                this.GridViewGeneral.Columns[5].Width = 120;
                this.GridViewGeneral.Columns[6].Width = 120;
                this.GridViewGeneral.Columns[7].Width = 120;
                this.GridViewGeneral.Columns[8].Width = 120;
                this.GridViewGeneral.Columns[9].Width = 120;
                this.GridViewGeneral.Columns[10].Width = 120;
                this.GridViewGeneral.Columns[11].Width = 120;
                this.GridViewGeneral.Columns[12].Width = 120;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridCliente(ref Object Datos)
        {
            try
            {
                Cliente Cliente = new Cliente();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    Cliente.Nombre = row.Cells["Nombre"].Value.ToString();
                    Cliente.ApePat = row.Cells["ApePat"].Value.ToString();
                    Cliente.ApeMat = row.Cells["ApeMat"].Value.ToString();
                    Cliente.FechaNacimiento = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value.ToString());
                    Cliente.IDGenero = Convert.ToInt32(row.Cells["IDGenero"].Value.ToString());
                    Cliente.CorreoElectronico = row.Cells["CorreoElectronico"].Value.ToString();
                    Cliente.IDOcupacion = Convert.ToInt32(row.Cells["IDOcupacion"].Value.ToString());
                    Cliente.IDEstadoCivil = Convert.ToInt32(row.Cells["IDEstadoCivil"].Value.ToString());
                    Cliente.Curp = row.Cells["Curp"].Value.ToString();
                    Cliente.IDPais = Convert.ToInt32(row.Cells["IDPais"].Value.ToString());
                    Cliente.IDEstado = Convert.ToInt32(row.Cells["IDEstado"].Value.ToString());
                    Cliente.IDMunicipio = Convert.ToInt32(row.Cells["IDMunicipio"].Value.ToString());
                    Cliente.Colonia = row.Cells["Colonia"].Value.ToString();
                    Cliente.IDCodigoEab = row.Cells["IDCodigoEab"].Value.ToString();
                    Cliente.IDCliente = row.Cells["IDCliente"].Value.ToString();
                }
                Datos = Cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarCliente(Object Datos)
        {
            try
            {
                Cliente Cliente = (Cliente)Datos;
                int Verificador = 0;
                Cliente_Negocio Cliente_Negocio = new Cliente_Negocio();
                Cliente_Negocio.EliminarCliente(Comun.Conexion, Cliente, Verificador);
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridClientes(1,"");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion
        #region MetodosGeneralesGrid
        private void RecorrerFor(List<string> campos, int opcion)
        {
            for (var index = 0; index < campos.Count; index++)
            {
                if (opcion == 1)
                    this.HeaderTextGridGeneral(index, campos[index]);
                else if (opcion == 2)
                    this.NameGridGeneral(index, campos[index]);
                else if (opcion == 3)
                    this.DataPropertyNameGridGeneral(index, campos[index]);
            }
        }
        private void HeaderTextGridGeneral(int numColum, string nombre)
        {
            try
            {
                this.GridViewGeneral.Columns[numColum].HeaderText = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void NameGridGeneral(int numColum, string nombre)
        {
            try
            {
                this.GridViewGeneral.Columns[numColum].Name = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DataPropertyNameGridGeneral(int numColum, string nombre)
        {
            try
            {
                this.GridViewGeneral.Columns[numColum].DataPropertyName = nombre;
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
                foreach (DataGridViewRow row in GridViewGeneral.Rows)
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
        private bool ValidarFilaSeleccionada(List<DataGridViewRow> rowSelected)
        {
            try
            {
                if (rowSelected.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_Busqueda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.CargarGridCatalogos(1, this.Txt_Busqueda.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Txt_Folio_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                this.CargarGridCatalogos(2, this.Txt_Folio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Txt_Folio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarGridCatalogos(1, this.Txt_Busqueda.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


    }
}
