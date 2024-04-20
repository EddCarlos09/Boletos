using System;
using System.Collections.Generic;
using System.ComponentModel;
using MaterialSkin.Controls;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using CreativaSL.Dll.VentaBoletosGlobal;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmBuscarClienteV2 : MaterialForm

    {
        private Cliente clientes;

        private bool banDatos = false;

        public frmBuscarClienteV2()
        {
            try
            {
                InitializeComponent();
                this.EstablecerPropiedadesGridCliente();

                // Create a material theme manager and add the form to manage (this)
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                // Configure color schema
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Blue700, TextShade.WHITE);
                this.label3.ForeColor = Color.Navy; // Cambiar el color del texto
                this.label3.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
                this.label4.ForeColor = Color.Navy; // Cambiar el color del texto
                this.label4.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
                this.label5.ForeColor = Color.Navy; // Cambiar el color del texto
                this.label5.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
                this.label2.ForeColor = Color.DimGray; // Cambiar el color del texto
                this.label1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label1.ForeColor = Color.DimGray; // Cambiar el color del texto
                this.label2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
           

        }
        private void frmBuscar_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.CargarGridCliente(1, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region GridClientes
        private void CargarGridCliente(int TipoBusq, string BusquedaNombre)
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
        private void EstablecerPropiedadesGridCliente()
        {
            try
            {
                var Headertexts = new List<string> { "Codigo Cliente", "Nombre", "Fecha Nacimiento", "Correo Electronico", "Pais", "Estado", "Municipio", "Monedero" };
                var Names = new List<string> { "IDCodigoEab", "NombreCompleto", "FechaNacimiento", "CorreoElectronico", "Pais", "Estado", "Municipio", "Monedero", "IDCliente", "IDPais", "IDEstado", "IDMunicipio" };

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
                this.GridViewGeneral.Columns[8].Visible = false;
                this.GridViewGeneral.Columns[9].Visible = false;
                this.GridViewGeneral.Columns[10].Visible = false;
                this.GridViewGeneral.Columns[11].Visible = false;
                this.GridViewGeneral.Columns[12].Visible = false;
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
        private void ObtenerCliente(List<DataGridViewRow> lst)
        {
            try
            {
                clientes = new Cliente();
                foreach (DataGridViewRow row in lst)
                {
                    clientes.IDCodigoEab = row.Cells["IDCodigoEab"].Value.ToString();
                    clientes.NombreCompleto = row.Cells["NombreCompleto"].Value.ToString();
                    clientes.IDCliente = row.Cells["IDCliente"].Value.ToString();
                    clientes.Monedero = Convert.ToSingle(row.Cells["Monedero"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion



        #region MetodosGenerales
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
                throw new Exception("Error en HeaderTextGridGeneral" + ex.Message);
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
                throw new Exception("Error en HeaderTextGridGeneral" + ex.Message);
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
                throw new Exception("Error en DataPropertyNameGridGeneral" + ex.Message);
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
                throw new Exception("Error en ObtenerFilaSeleccionada" + ex.Message);
            }
        }
        private bool ValidarFilaSeleccionada(List<DataGridViewRow> rowSelected)
        {
            try
            {
                if (rowSelected.Count == 0)
                {
                    Validaciones val = new Validaciones();
                    val.Mensaje("Debe seleccionar una fila del grid", this);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ValidarFilaSeleccionada" + ex.Message);
            }
        }
        public Cliente getCliente()
        {
            return clientes;
        }
        public bool getBanDatos()
        {
            return this.banDatos;
        }
        #endregion

        #region Eventos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataGridViewRow> FilaSeleccionada;
                FilaSeleccionada = this.ObtenerFilaSeleccionada();
                if (this.ValidarFilaSeleccionada(FilaSeleccionada))
                {
                    this.ObtenerCliente(FilaSeleccionada);
                    this.Visible = false;
                    this.banDatos = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void Txt_C_Uno_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_C_Uno_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (this.Txt_C_Dos.Text.ToString().Length > 0)
                    this.Txt_C_Dos.Text = "";
                if (e.KeyCode == Keys.Enter)
                    this.CargarGridCliente(1, this.Txt_C_Uno.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_C_Dos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (this.Txt_C_Uno.Text.ToString().Length > 0)
                    this.Txt_C_Uno.Text = "";
                if (e.KeyCode == Keys.Enter)
                    this.CargarGridCliente(2, this.Txt_C_Dos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_C_Dos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Txt_C_Uno.Text.ToString().Length > 0)
                    this.CargarGridCliente(1, this.Txt_C_Uno.Text);
                else
                    this.CargarGridCliente(2, this.Txt_C_Dos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
