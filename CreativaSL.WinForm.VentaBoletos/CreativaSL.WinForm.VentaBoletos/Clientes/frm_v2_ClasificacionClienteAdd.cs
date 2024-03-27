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
using CreativaSL.LibControls.WinForms;

namespace CreativaSL.WinForm.VentaBoletos.Clientes
{
    public partial class frm_v2_ClasificacionClienteAdd : Form_Creativa
    {
        #region VARIABLES/PROPIEDADES
        private Validaciones Val;
        bool esModificar = false;
        private ClasificacionCliente infoClas;
        private int aux = 0;
        public Clasificacion_Negocio Model { get; set; }

        private ClasificacionCliente _clas_Cliente;
        public ClasificacionCliente clas_Cliente
        {
            get { return _clas_Cliente; }
            set { _clas_Cliente = value; }
        }
        #endregion

        #region CONSTRUCTOR
        //public frm_v2_ClasificacionClienteAdd()
        //{
        //    try
        //    {
        //        InitializeComponent();
        //        Model = new Clasificacion_Negocio(Comun.Conexion, false, 0, Comun.Id_U);
        //        IniciarBinding();
        //        IniciarForm();
        //    }
        //    catch (Exception ex)
        //    {
        //        Comun.AddExcFileTxt(ex, "frm_v2_ClasificacionClienteAdd ~ frm_v2_ClasificacionClienteAdd()");
        //        MessageBox.Show("Ocurrió un error al cargar la información. ", "Sistema Venta de Boletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Close();
        //    }

        //}

        public frm_v2_ClasificacionClienteAdd(ClasificacionCliente Clasificacion)
        {
            try
            {
                InitializeComponent();
                this.infoClas = Clasificacion;
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        //public frm_v2_ClasificacionClienteAdd(int ID)
        //{
        //    //    try
        //    //    {
        //    //        InitializeComponent();
        //    //        Model = new Clasificacion_Negocio(Comun.Conexion, false, ID, Comun.Id_U);
        //    //        IniciarBinding();
        //    //        LlenarDatos(BuscarCliente());
        //    //        IniciarForm();
        //    //        esModificar = true;
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        Comun.AddExcFileTxt(ex, "frm_v2_ClasificacionClienteAdd ~ frm_v2_ClasificacionClienteAdd(int ID)");
        //    //        MessageBox.Show("Ocurrió un error al cargar la información. ", "Sistema Venta de Boletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //        Close();
        //    //    }
        //}
        #endregion

        #region METODOS

        private void GuardarClasificacion()
        {
            try
            {
                Val = new Validaciones();
                int Verificador = 0;
                Clasificacion_Negocio clasificacion_negocio = new Clasificacion_Negocio();
                ClasificacionCliente Clasificacion = new ClasificacionCliente();
                this.ObtenerDatos(Clasificacion);
                if (infoClas.IDClasificacion != 0)
                {
                    Clasificacion.IDClasificacion = infoClas.IDClasificacion;
                    clasificacion_negocio.modificarClasificacion(Clasificacion, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
                else
                {
                    clasificacion_negocio.agregarClasificacion(Clasificacion, Comun.Conexion, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerDatos(ClasificacionCliente Clasificacion)
        {
            try
            {
                Clasificacion.Descripcion = this.txtClasificacion.Text;
                Clasificacion.Porcentaje = Convert.ToDecimal(txtPorcentaje.Text);               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //private void llenarGridClasificacionsInt()
        //{
        //    try
        //    {
        //        //this.dgv_Rutasinter.AutoGenerateColumns = false;
        //        //BindingSource binding = new BindingSource();
        //        //binding.DataSource = this.ruta_principal.rutas_intermedias;
        //        //this.dgv_Rutasinter.DataSource = binding;
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
        //public ClasificacionCliente BuscarCliente()
        //{

        //    ClasificacionCliente clasificacion = new ClasificacionCliente();
        //    clasificacion = Model.ObtenerDatosXIDClasificacion();
        //    return clasificacion;
        //}

        //public void LlenarDatos(ClasificacionCliente clasificacion)
        //{
        //    Model.Model.Descripcion = clasificacion.Descripcion.ToString();
        //    Model.Model.Porcentaje = clasificacion.Porcentaje;
        //}

        //private void IniciarBinding()
        //{
        //    //try
        //    //{
        //    //    txtClasificacion.DataBindings.Add("Text", Model.Model, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
        //    //    txtPorcentaje.DataBindings.Add("Text", Model.Model, "Porcentaje", true, DataSourceUpdateMode.OnPropertyChanged);
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    throw ex;
        //    //}
        //}

        private void IniciarForm()
        {
            try
            {
                this.ControlBox = false;
                this.BringToFront();
                ActiveControl = txtClasificacion;
                txtClasificacion.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Inicializar()
        {
            try
            {
                if (infoClas.IDClasificacion!= 0)
                    this.LlenarDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LlenarDatos()
        {
            try
            {
                this.txtClasificacion.Text = infoClas.Descripcion;
                //this.txtPorcentaje.Text = infoClas.Porcentaje.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarCampos()
        {
            Validaciones Val = new Validaciones();
            try
            {
                //if (this.txtPorcentaje.Text.Length == 0)
                //{
                //    this.txtPorcentaje.Focus();
                //    MessageBox.Show("Ingrese una Clasificación", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return false;
                //}                
                //else
                if (this.txtClasificacion.Text.Length <= 0 | this.txtClasificacion.Text.Length > 30)
                {
                    this.txtClasificacion.Focus();
                    MessageBox.Show("Ingrese una Clasificación", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.txtPorcentaje.Text.Length == 0)
                {
                    this.txtPorcentaje.Focus();
                    MessageBox.Show("Porcentaje inválido", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                //float Por = float.Parse(txtPorcentaje.Text);                
                else if (float.Parse(txtPorcentaje.Text) <= 0 | float.Parse(txtPorcentaje.Text) >= 100)
                {
                    this.txtPorcentaje.Focus();
                    MessageBox.Show("Porcentaje inválido", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        private void mensaje(string msj)
        {
            try
            {
                this.txt_mensaje.Text = msj;
                this.txt_mensaje.Visible = true;
            }
            catch (Exception ex)
            {
                this.mensaje(ex.Message);
            }
        }

        private void VerifcarMensajeAccion(int Verificador)
        {

            try
            {
                if (Verificador == 2)
                {
                    MessageBox.Show("Clasificacion ingresada ya existe", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (Verificador == 1)
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

        #region EVENTOS
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos())
                {
                    this.GuardarClasificacion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }            
        }                              

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_ClasificacionClienteAdd ~ btn_Cancelar_Click");
            }
        }

        private void txtClasificacion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones v = new Validaciones();
                v.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void txtPorcentaje_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones v = new Validaciones();
                v.SoloNumerico(e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtPorcentaje_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtPorcentaje.Text == string.Empty)
            {
                this.txtPorcentaje.Text = "";
            }
        }
    }
    #endregion
}

