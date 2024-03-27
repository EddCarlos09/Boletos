using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using CreativaSL.WinForm.VentaBoletos.Controls;
using System;
using System.Windows.Forms;

namespace CreativaSL.WinForm.VentaBoletos.Clientes
{
    public partial class frm_v2_ClienteAdd : Form
    {
        #region Propiedades / Variables globales
        //private WebCamCapture WebCamCapture;
        bool esModificar = false;
        bool estadoAux = true;
        public bool Completo = false;
        private Validaciones Val;
        public V2Cliente_Negocio Model { get; set; }
        #endregion
        #region Constructor
        public frm_v2_ClienteAdd()
        {
            try
            {
                InitializeComponent();
                Model = new V2Cliente_Negocio(Comun.Conexion, false, 0, Comun.Id_U);
                IniciarBinding();
                IniciarDatosNuevo();
                LlenarCombos();
                IniciarForm();
                //WebCamCapture = new WebCamCapture();

                //this.WebCamCapture.CaptureHeight = this.pictureBox1.Height;
                //this.WebCamCapture.CaptureWidth = this.pictureBox1.Width;


                //this.WebCamCapture.CaptureHeight = 240;
                //this.WebCamCapture.CaptureWidth = 320;
                //// TODO: Code generation for 'this.WebCamCapture.FrameNumber' failed because of Exception 'Invalid Primitive Type: System.UInt64. Only CLS compliant primitive types can be used. Consider using CodeObjectCreateExpression.'.
                //this.WebCamCapture.Location = new System.Drawing.Point(17, 17);
                //this.WebCamCapture.Name = "WebCamCapture";
                //this.WebCamCapture.Size = new System.Drawing.Size(342, 252);
                //this.WebCamCapture.TabIndex = 0;
                //this.WebCamCapture.TimeToCapture_milliseconds = 100;
                //this.WebCamCapture.ImageCaptured += new WebCamCapture.WebCamEventHandler(this.WebCamCapture_ImageCaptured);


            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_ClienteAdd ~ frm_v2_ClienteAdd()");
                MessageBox.Show("Ocurrió un error al cargar la información. ", "Sistema Venta de Boletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

        }

        public frm_v2_ClienteAdd(int ID)
        {
            try
            {
                InitializeComponent();
                Model = new V2Cliente_Negocio(Comun.Conexion, false, ID, Comun.Id_U);
                IniciarBinding();
                LlenarCombos();
                LlenarDatos(BuscarCliente());
                IniciarForm();
                this.TxtTarjeta.Enabled = false;
                this.TxtReferidoPor.Enabled = false;
                this.btnBuscar.Enabled=false;
                estadoAux = false;
                esModificar = true;
                
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_ClienteAdd ~ frm_v2_ClienteAdd(int _ID)");
                MessageBox.Show("Ocurrió un error al cargar la información. ", "Sistema Venta de Boletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        #endregion
        #region Metodos
        //Buscar un cliente y que me retorne un valor de tipo V2Cliente
        public V2Cliente BuscarCliente()
        {

            V2Cliente cliente = new V2Cliente();
            cliente = Model.ObtenerDatosXIDCliente();
            return cliente;
        }
        //LLenar Datos del frm
        public void LlenarDatos(V2Cliente cliente)
        {
            Model.Model.Nombre = cliente.Nombre.ToString();
            Model.Model.Empresa = cliente.Empresa.ToString();
            Model.Model.Domicilio = cliente.Domicilio.ToString();
            Model.Model.Cruces = cliente.Cruces.ToString();
            Model.Model.Colonia = cliente.Colonia.ToString();
            Model.Model.CodigoPostal = cliente.CodigoPostal.ToString();
            Model.Model.IDEstado = cliente.IDEstado;
            LlenarComboMunicipios(cliente.IDEstado);
            Model.Model.IDMunicipio = cliente.IDMunicipio;
            Model.Model.Email = cliente.Email.ToString();
            Model.Model.RFC = cliente.RFC.ToString();
            if (cliente.FechaNacimiento != DateTime.MinValue)
                Model.Model.FechaNacimiento = cliente.FechaNacimiento;
            Model.Model.Telefono = cliente.Telefono.ToString();
            Model.Model.TelefonoCelular = cliente.TelefonoCelular.ToString();
            Model.Model.CodigoTarjeta = cliente.CodigoTarjeta.ToString();
            Model.Model.Clasificacion = cliente.Clasificacion;
            Model.Model.ReferidoPor = cliente.ReferidoPor.ToString();
            Model.Model._ImagenBase64 = cliente._ImagenBase64.ToString();
            pictureBox1.Image = cliente.FotoCliente;
        }
        private void IniciarDatosNuevo()
        {
            try
            {                
                Model.Model.FotoCliente = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.ImagenDefault;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void LlenarCombos()
        {
            try
            {
                LlenarComboEstados();
                LlenarComboMunicipios(0);
                LlenarComboClasificacion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarComboEstados()
        {
            try
            {
                CmbEstado.DataSource = Model.ListaEstados;
                CmbEstado.DisplayMember = "EstadoDesc";
                CmbEstado.ValueMember = "IDEstado";
                this.CmbEstado.SelectedValueChanged += new System.EventHandler(this.CmbEstado_SelectedValueChanged);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarComboMunicipios(int IDEstado)
        {
            try
            {
                Model.LlenarListaMunicipios(IDEstado);
                CmbMunicipio.DataSource = Model.ListaMunicipios;
                CmbMunicipio.DisplayMember = "MunicipioDesc";
                CmbMunicipio.ValueMember = "IDMunicipio";
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarComboClasificacion()
        {
            try
            {
                CmbClasificacion.DataSource = Model.ListaClasificacion;
                CmbClasificacion.DisplayMember = "Descripcion";
                CmbClasificacion.ValueMember = "IDClasificacion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inicializa el bindeo de los datos del modelo
        /// </summary>
        private void IniciarBinding()
        {
            try
            {
                TxtNombre.DataBindings.Add("Text", Model.Model, "Nombre", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtEmpresa.DataBindings.Add("Text", Model.Model, "Empresa", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtDomicilio.DataBindings.Add("Text", Model.Model, "Domicilio", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtCruces.DataBindings.Add("Text", Model.Model, "Cruces", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtColonia.DataBindings.Add("Text", Model.Model, "Colonia", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtCP.DataBindings.Add("Text", Model.Model, "CodigoPostal", true, DataSourceUpdateMode.OnPropertyChanged);
                pictureBox1.DataBindings.Add("Image", Model.Model, "FotoCliente", true, DataSourceUpdateMode.OnPropertyChanged);
                CmbEstado.DataBindings.Add("SelectedValue", Model.Model, "IDEstado", true, DataSourceUpdateMode.OnPropertyChanged);
                CmbMunicipio.DataBindings.Add("SelectedValue", Model.Model, "IDMunicipio", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtEmail.DataBindings.Add("Text", Model.Model, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtRFC.DataBindings.Add("Text", Model.Model, "RFC", true, DataSourceUpdateMode.OnPropertyChanged);
                DtmFechaNac.DataBindings.Add("Value", Model.Model, "FechaNacimiento", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtTelefono.DataBindings.Add("Text", Model.Model, "Telefono", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtCelular.DataBindings.Add("Text", Model.Model, "TelefonoCelular", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtTarjeta.DataBindings.Add("Text", Model.Model, "CodigoTarjeta", true, DataSourceUpdateMode.OnPropertyChanged);
                CmbClasificacion.DataBindings.Add("SelectedValue", Model.Model, "Clasificacion", true, DataSourceUpdateMode.OnPropertyChanged);
                TxtReferidoPor.DataBindings.Add("Text", Model.Model, "ReferidoPor", true, DataSourceUpdateMode.OnPropertyChanged);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inicializa la presentación del formulario
        /// </summary>
        private void IniciarForm()
        {
            try
            {
                this.ControlBox = false;
                //this.WindowState = FormWindowState.Maximized;
                this.BringToFront();
                ActiveControl = TxtNombre;
                TxtNombre.Focus();
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
                    MessageBox.Show("Error en la referencia al cliente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(Verificador == 1)
                {
                    MessageBox.Show("Los datos se guardaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Completo = true;
                    this.Close();
                }
                else if (Verificador == 0)
                {
                    MessageBox.Show("El correo ingresado ya existe. ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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
                if (this.TxtNombre.Text.Length == 0)
                {
                    this.TxtNombre.Focus();
                    MessageBox.Show("Escriba el nombre ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                else if (this.TxtDomicilio.Text.Length == 0)
                {
                    this.TxtDomicilio.Focus();
                    MessageBox.Show("Escriba un domicilio ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.TxtCruces.Text.Length == 0)
                {
                    this.TxtCruces.Focus();
                    MessageBox.Show("Escriba entre que calles se localiza el domicilio ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.TxtColonia.Text.Length == 0)
                {
                    this.TxtColonia.Focus();
                    MessageBox.Show("Escriba una colonia", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.TxtCP.Text.Length == 0)
                {
                    this.TxtCP.Focus();
                    MessageBox.Show("Escriba un codigo postal", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.CmbEstado.SelectedIndex == 0)
                {
                    this.CmbEstado.Focus();
                    MessageBox.Show("Seleccione el estado ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.CmbMunicipio.SelectedIndex == 0)
                {
                    this.CmbMunicipio.Focus();
                    MessageBox.Show("Seleccione el municipio ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (!Val.IsValidEmails(this.TxtEmail.Text))
                {
                    this.TxtEmail.Focus();
                    MessageBox.Show("Escriba el correo electrónico", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.TxtRFC.Text.Length == 0) //validar si son 13 digitos ?
                {
                    this.TxtRFC.Focus();
                    MessageBox.Show("Escriba un RFC ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (Model.Model.FechaNacimiento == DateTime.MinValue)
                {
                    this.DtmFechaNac.Focus();
                    MessageBox.Show("Seleccione una fecha de nacimiento ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.TxtTarjeta.Text.Length == 0)
                {
                    this.btnBuscar.Focus();
                    MessageBox.Show("Seleccione una tarjeta ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.CmbClasificacion.SelectedIndex == 0)
                {
                    this.CmbClasificacion.Focus();
                    MessageBox.Show("Seleccione una clasifiacion para el cliente ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.TxtReferidoPor.Text.Length == 0)
                {
                    Model.Model.ReferidoPor = null;
                }
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Eventos

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog elegirImagen = new OpenFileDialog
                {
                    Multiselect = false,
                    Filter = "Image Files|*.png;*.jpg;*.jpeg",
                    Title = "Seleccione una imagen",
                    CheckFileExists = true,
                    CheckPathExists = true
                };
                if (elegirImagen.ShowDialog(this) == DialogResult.OK)
                {
                    string _filename = elegirImagen.FileName;
                    Model.Model.FotoCliente = Comun.VaryQualityLevel(_filename);
                }
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_ClienteAdd ~ pictureBox1_Click");
                MessageBox.Show("Ocurrió un error al cargar la información. ", "Sistema Venta Boletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e) 
        {

            var Aux = Model.Model;
            try
            {
                if (ValidarCampos())
                {
                    int Verificador = 0;
                    if (esModificar)
                        Model.ModificarCliente(ref Verificador);
                    else
                        Model.InsertarCliente(ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// An image was capture
        /// </summary>
        /// <param name="source">control raising the event</param>
        /// <param name="e">WebCamEventArgs</param>
        private void WebCamCapture_ImageCaptured(object source, WebcamEventArgs e)
        {
            // set the picturebox picture
            //Model.Model.FotoCliente = e.WebCamImage;
            pictureBox1.Image = e.WebCamImage;
        }
        private void CmbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (estadoAux)
                {
                    if (CmbEstado.SelectedValue != null)
                    {
                        var aux = CmbEstado.SelectedValue;
                        LlenarComboMunicipios((int)aux);
                    }
                }
                else
                estadoAux = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            // change the capture time frame
            this.webCamCapture1.TimeToCapture_milliseconds = 100;//(int)this.numCaptureTime.Value;

            // start the video capture. let the control handle the
            // frame numbers.
            this.webCamCapture1.Start(0);
        }

        private void frm_v2_ClienteAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.webCamCapture1.Stop();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            this.webCamCapture1.Stop();
            Model.Model.FotoCliente = pictureBox1.Image;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_ClienteAdd ~ btn_Cancelar_Click");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frm_v2_AsignarTarjeta Add = new frm_v2_AsignarTarjeta(Model.Model.CodigoTarjeta);
                Add.ShowDialog();
                Add.Dispose();
                this.TxtTarjeta.Text = Add.FolioCliente;
            }
            catch (Exception ex)
            {
                Comun.AddExcFileTxt(ex, "frm_v2_ClienteAdd ~ btnBuscar_Click");
            }

        }

        private void TxtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtCruces_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtRFC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtReferidoPor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtCP_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
    }
}
