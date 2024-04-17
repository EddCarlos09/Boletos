using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmConfiguracionV2 : MaterialForm
    {
        Configuracion configuracion = new Configuracion(Comun.Conexion);
        private Caja caja = new Caja(Comun.Conexion);
        private bool ModificarImagen = false;
        private string imgurl = "";
        public frmConfiguracionV2()
        {
            InitializeComponent();
            this.CargarCombos();
            this.inicializar();
            loadMaterial(this);
        }


        private void button_Creativa1_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.AllowCurrentPage = false;
                printDialog1.AllowPrintToFile = false;
                printDialog1.AllowSelection = false;
                printDialog1.AllowSomePages = false;
                printDialog1.ShowHelp = false;
                printDialog1.ShowNetwork = false;
                printDialog1.PrintToFile = false;
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PrinterSettings ps = printDialog1.PrinterSettings;
                    this.txtnameprinter.Text = ps.PrinterName;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.obtenerDatos();
                if (ModificarImagen)
                    this.pbImage.Image.Save(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + configuracion.logourl.ToLower()));
                Configuracion_Negocio cn = new Configuracion_Negocio();
                cn.agregarConfiguracion(configuracion);
                MessageBox.Show("Los datos se agregaron correctamente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                this.txt_mensajeError.Visible = true;
                this.txt_mensajeError.Text = ex.Message;
            }
        }

        private void obtenerDatos()
        {
            try
            {
                this.configuracion.razonSocial = this.txtrazonsocial.Text;
                this.configuracion.rfc = this.txtrfc.Text;
                this.configuracion.logourl = this.txturlimg.Text;
                this.configuracion.mensaje1 = this.txt_msjboletos.Text + " ";
                this.configuracion.mensaje2 = this.txt_msjanticipos.Text + " ";
                this.configuracion.mensaje3 = this.txt_msjmaletas.Text + " ";
                this.configuracion.direccion = this.txtdireccion.Text;
                this.configuracion.macAddress = Comun.macAdress;
                this.configuracion.namePrinter = this.txtnameprinter.Text;
                this.configuracion.idCaja = this.CmbCaja.SelectedValue.ToString();
                this.configuracion.descripcion = this.txtDescripcion.Text;
            }
            catch (Exception ex)
            {
            }
        }

        private void inicializar()
        {
            try
            {
                Configuracion_Negocio cn = new Configuracion_Negocio();
                configuracion = cn.obtenerConfiguracion(configuracion);
                this.txtrazonsocial.Text = configuracion.razonSocial;
                this.txtrfc.Text = configuracion.rfc;
                this.txtdireccion.Text = configuracion.direccion;
                this.txturlimg.Text = configuracion.logourl;
                if (configuracion.mensaje1.Length > 0)
                    this.txt_msjboletos.Text = configuracion.mensaje1.Substring(0, configuracion.mensaje1.Length - 1);
                else
                    this.txt_msjboletos.Text = configuracion.mensaje1;
                if (configuracion.mensaje2.Length > 0)
                    this.txt_msjanticipos.Text = configuracion.mensaje2.Substring(0, configuracion.mensaje2.Length - 1);
                else
                    this.txt_msjboletos.Text = configuracion.mensaje2;
                if (configuracion.mensaje3.Length > 0)
                    this.txt_msjmaletas.Text = configuracion.mensaje3.Substring(0, configuracion.mensaje3.Length - 1);
                else
                    this.txt_msjmaletas.Text = configuracion.mensaje3;

                this.TxtMac.Text = configuracion.macAddress;
                this.CmbCaja.SelectedValue = configuracion.idCaja;
                this.txtDescripcion.Text = configuracion.descripcion;
                this.txtnameprinter.Text = configuracion.namePrinter;
                if (File.Exists(@"Resources\documents\" + configuracion.logourl))
                {
                    this.pbImage.Image = Image.FromFile(@"Resources\documents\" + configuracion.logourl);
                    imgurl = configuracion.logourl;
                }
                else
                {
                    this.pbImage.Image = Image.FromFile(@"Resources\documents\aury.jpg");
                    imgurl = "aury.jpg";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                this.ObtenerImagen();
                this.txturlimg.Text = configuracion.logourl;
            }
            catch (Exception ex)
            {

            }
        }
        private void CargarCombos()
        {
            try
            {
                this.caja.listaCaja = new List<Caja>();
                Caja_Negocio caja_Negocio = new Caja_Negocio();
                caja_Negocio.CargarComboCajasOcupadas(Comun.Conexion, ref this.caja);
                this.CmbCaja.DataSource = this.caja.listaCaja;
                this.CmbCaja.ValueMember = "id_cajaCat";
                this.CmbCaja.DisplayMember = "cajaCat";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerImagen()
        {
            try
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Archivos de Imagen PNG Image |*.png| JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif ";
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Seleccione la imagen";
                BuscarImagen.InitialDirectory = "C:\\";
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    if (imgurl != BuscarImagen.SafeFileName)
                        ModificarImagen = true;
                    else
                        ModificarImagen = false;
                    configuracion.logourl = BuscarImagen.SafeFileName;
                    this.pbImage.ImageLocation = BuscarImagen.FileName;
                }
                else
                    ModificarImagen = false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ObtenerImagen" + ex.Message);
            }
        }

        private void btn_LiberarBoletos_Click(object sender, EventArgs e)
        {
            try
            {
                Home_Negocio hn = new Home_Negocio();
                hn.LiberarAsientoApartadosPorTiempoSistema(Comun.Conexion);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
