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
    public partial class frmCatClientes : Form
    {
        private Cliente infoClientes;
        private Validaciones Val;
        public frmCatClientes(Cliente Clientes)
        {
            try
            {
                InitializeComponent();
                this.infoClientes = Clientes;
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Metodos Generales
        private void Inicializar()
        {          
            try
            {
                if (infoClientes.IDCliente != null)
                {
                    this.CargarCombos();
                    this.LLenarDatos();
                }
                else
                {
                    this.CargarCombos();
                    this.combo_C_pais.SelectedValue = 143;
                    this.combo_C_pais.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
             
        }
        private void CargarCombos()
        {
            try
            {
                this.infoClientes.lista_Genero = new List<Cliente>();
                this.infoClientes.lista_Ocupacion = new List<Cliente>();
                this.infoClientes.lista_EstadoCivil = new List<Cliente>();
                this.infoClientes.lista_Pais = new List<Cliente>();
                this.infoClientes.lista_Estado = new List<Cliente>();
                this.infoClientes.lista_Municipio = new List<Cliente>();
                Cliente_Negocio Cliente_Negocio = new Cliente_Negocio();
                Cliente_Negocio.CargarComboGenero(Comun.Conexion, ref this.infoClientes);
                Cliente_Negocio.CargarComboOcupacion(Comun.Conexion, ref this.infoClientes);
                Cliente_Negocio.CargarComboEstadoCivil(Comun.Conexion, ref this.infoClientes);
                Cliente_Negocio.CargarComboPais(Comun.Conexion, ref this.infoClientes);
                Cliente_Negocio.CargarComboEstado(Comun.Conexion, ref this.infoClientes,143);
                Cliente_Negocio.CargarComboMunicipios(Comun.Conexion, ref this.infoClientes,143,7);

                this.combo_C_sexo.DataSource = this.infoClientes.lista_Genero;
                this.combo_C_sexo.DisplayMember = "Genero";
                this.combo_C_sexo.ValueMember = "IDGenero";

                this.combo_C_ocupacion.DataSource = this.infoClientes.lista_Ocupacion;
                this.combo_C_ocupacion.DisplayMember = "Ocupacion";
                this.combo_C_ocupacion.ValueMember = "IDOcupacion";

                this.combo_C_EstadoCivil.DataSource = this.infoClientes.lista_EstadoCivil;
                this.combo_C_EstadoCivil.DisplayMember = "EstadoCivil";
                this.combo_C_EstadoCivil.ValueMember = "IDEstadoCivil";

                this.combo_C_pais.DataSource = this.infoClientes.lista_Pais;
                this.combo_C_pais.DisplayMember = "Pais";
                this.combo_C_pais.ValueMember = "IDPais";

                this.combo_C_estados.DataSource = this.infoClientes.lista_Estado;
                this.combo_C_estados.DisplayMember = "Estado";
                this.combo_C_estados.ValueMember = "IDEstado";

                this.combo_C_municipio.DataSource = this.infoClientes.lista_Municipio;
                this.combo_C_municipio.DisplayMember = "Municipio";
                this.combo_C_municipio.ValueMember = "IDMunicipio";

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
                this.txt_C_nombre.Text = infoClientes.Nombre.ToString();
                this.txt_C_aPat.Text = infoClientes.ApePat.ToString();
                this.txt_C_aMat.Text = infoClientes.ApeMat.ToString();
                this.DtmFechaNac.Value = infoClientes.FechaNacimiento.Value;
                this.combo_C_sexo.SelectedValue = infoClientes.IDGenero;
                this.txt_C_correo.Text = infoClientes.CorreoElectronico.ToString();
                this.combo_C_ocupacion.SelectedValue = infoClientes.IDOcupacion;
                this.combo_C_EstadoCivil.SelectedValue = infoClientes.IDEstadoCivil;
                this.txt_C_curp.Text = infoClientes.Curp.ToString();
                this.combo_C_pais.SelectedValue = infoClientes.IDPais;
                this.combo_C_estados.SelectedValue = infoClientes.IDEstado;
                this.combo_C_municipio.SelectedValue = infoClientes.IDMunicipio;
                this.txt_C_colonia.Text = infoClientes.Colonia.ToString();
                this.txt_C_codigocliente.Text = infoClientes.IDCodigoEab.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GuadarCliente()
        {
            try
            {
                int Verificador = 0;
                Cliente Cliente = new Cliente();
                Cliente_Negocio Cliente_Negocio = new Cliente_Negocio();
                this.ObtenerDatos(Cliente);
                if (Cliente.IDCliente != null)
                {
                    Cliente_Negocio.ModificarCliente(Comun.Conexion,Cliente, ref Verificador);
                }
                else
                {
                   Cliente_Negocio.InsertarCliente(Comun.Conexion,Cliente,ref Verificador);
                }
                this.VerifcarMensajeAccion(Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatos(Cliente Cliente)
        {
            try
            {
                Cliente.IDCliente = infoClientes.IDCliente;
                Cliente.Nombre = this.txt_C_nombre.Text.ToString();
                Cliente.ApePat = this.txt_C_aPat.Text.ToString();
                Cliente.ApeMat = this.txt_C_aMat.Text.ToString();
                Cliente.FechaNacimiento = Convert.ToDateTime(this.DtmFechaNac.Value.ToString());
                Cliente.IDGenero = Convert.ToInt32(this.combo_C_sexo.SelectedValue.ToString());
                Cliente.CorreoElectronico = this.txt_C_correo.Text.ToString();
                Cliente.IDOcupacion = Convert.ToInt32(this.combo_C_ocupacion.SelectedValue.ToString());
                Cliente.IDEstadoCivil = Convert.ToInt32(this.combo_C_EstadoCivil.SelectedValue.ToString());
                Cliente.Curp = this.txt_C_curp.Text.ToString();
                Cliente.IDPais = Convert.ToInt32(this.combo_C_pais.SelectedValue.ToString());
                Cliente.IDEstado = Convert.ToInt32(this.combo_C_estados.SelectedValue.ToString());
                Cliente.IDMunicipio = Convert.ToInt32(this.combo_C_municipio.SelectedValue.ToString());
                Cliente.Colonia = this.txt_C_colonia.Text.ToString();
                Cliente.IDCodigoEab = this.txt_C_codigocliente.Text.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarCampos()
        {
            Validaciones Val = new Validaciones();
            Cliente_Negocio Cliente_Negocio = new Cliente_Negocio();
            try
            {
                if (this.txt_C_nombre.Text.Length == 0)
                {
                    this.txt_C_nombre.Focus();
                    MessageBox.Show("Escriba el nombre ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.txt_C_aPat.Text.Length == 0)
                {
                    this.txt_C_aPat.Focus();
                    MessageBox.Show("Escriba el apellido paterno ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.txt_C_aPat.Text.Length == 0)
                {
                    this.txt_C_aPat.Focus();
                    MessageBox.Show("Escriba el apellido materno ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.combo_C_sexo.SelectedIndex == 0)
                {
                    this.combo_C_sexo.Focus();
                    MessageBox.Show("Seleccione el sexo ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.combo_C_EstadoCivil.SelectedIndex == 0)
                {
                    this.combo_C_EstadoCivil.Focus();
                    MessageBox.Show("Seleccione el estado civil ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (!Val.IsValidEmails(this.txt_C_correo.Text))
                {
                    this.txt_C_correo.Focus();
                    MessageBox.Show("Escriba el correo electrónico", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (Cliente_Negocio.ConsultarCorreo(Comun.Conexion,this.txt_C_correo.Text) == 1 && this.infoClientes.IDCliente == null)
                {
                    this.txt_C_correo.Focus();
                    MessageBox.Show("Este correo electrónico ya esta registrado", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.combo_C_ocupacion.SelectedIndex == 0)
                {
                    this.combo_C_ocupacion.Focus();
                    MessageBox.Show("Seleccione la ocupacion ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.combo_C_pais.SelectedIndex == 0)
                {
                    this.combo_C_pais.Focus();
                    MessageBox.Show("Seleccione el pais ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.combo_C_estados.SelectedIndex == 0)
                {
                    this.combo_C_estados.Focus();
                    MessageBox.Show("Seleccione el estado ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.combo_C_municipio.SelectedIndex == 0)
                {
                    this.combo_C_municipio.Focus();
                    MessageBox.Show("Seleccione el municipio ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.txt_C_colonia.Text.Length == 0)
                {
                    this.txt_C_colonia.Focus();
                    MessageBox.Show("Escriba la colonia ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.txt_C_codigocliente.Text.Length == 0)
                {
                    this.txt_C_codigocliente.Focus();
                    MessageBox.Show("Este el codigo cliente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (Cliente_Negocio.ConsultarCodigoCliente(Comun.Conexion, this.txt_C_codigocliente.Text) == 1 && this.infoClientes.IDCliente == null)
                {
                    this.txt_C_codigocliente.Focus();
                    MessageBox.Show("Este codigo ya esta registrado", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                else
                    return true;
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
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Eventos
        private void btn_Guardar_Click(object sender, EventArgs e)
        {           
            try
            {
                if (this.ValidarCampos())
                {
                    this.GuadarCliente();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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
        private void txt_C_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_C_aPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_C_aMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_C_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_C_curp_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_C_colonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_C_codigocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void combo_C_pais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this.infoClientes.lista_Estado = new List<Cliente>();
                this.infoClientes.lista_Municipio = new List<Cliente>();
                Cliente_Negocio Cliente_Negocio = new Cliente_Negocio();
                Cliente_Negocio.CargarComboEstado(Comun.Conexion, ref this.infoClientes, Convert.ToInt32(this.combo_C_pais.SelectedValue.ToString()));
                Cliente_Negocio.CargarComboMunicipios(Comun.Conexion, ref this.infoClientes, Convert.ToInt32(this.combo_C_pais.SelectedValue.ToString()), Convert.ToInt32(this.combo_C_estados.SelectedValue.ToString()));

                this.combo_C_estados.DataSource = this.infoClientes.lista_Estado;
                this.combo_C_estados.DisplayMember = "Estado";
                this.combo_C_estados.ValueMember = "IDEstado";

                this.combo_C_municipio.DataSource = this.infoClientes.lista_Municipio;
                this.combo_C_municipio.DisplayMember = "Municipio";
                this.combo_C_municipio.ValueMember = "IDMunicipio";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void combo_C_estados_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this.infoClientes.lista_Municipio = new List<Cliente>();
                Cliente_Negocio Cliente_Negocio = new Cliente_Negocio();
                Cliente_Negocio.CargarComboMunicipios(Comun.Conexion, ref this.infoClientes, Convert.ToInt32(this.combo_C_pais.SelectedValue.ToString()), Convert.ToInt32(this.combo_C_estados.SelectedValue.ToString()));

                this.combo_C_municipio.DataSource = this.infoClientes.lista_Municipio;
                this.combo_C_municipio.DisplayMember = "Municipio";
                this.combo_C_municipio.ValueMember = "IDMunicipio";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void frmCatClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
