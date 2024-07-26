using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmFacturaDatos : MaterialForm
    {
        DatosFacturaEmisor configuracion = new DatosFacturaEmisor(Comun.Conexion);
        string idemisor = null;
        bool isCerBase64 = true;
        bool isKeyBase64 = true;
        public frmFacturaDatos()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            Configuracion_Negocio cn = new Configuracion_Negocio();
            configuracion = cn.obtenerFacturaDatos(configuracion);
            this.txtrfc.Text = configuracion.rfc;
            this.txtrazonsocial.Text = configuracion.razonSocial;
            this.txtcp.Text = configuracion.cp;
            this.txtcorreo.Text = configuracion.correo;
            this.txtcertificado.Text = configuracion.noCertificado;
            this.idemisor = configuracion.idDatosEmisor;
            this.txtpasswordkey.Text = string.Empty;
            this.txtkey.Text = configuracion.archivoKey;
            this.txtcer.Text = configuracion.archivoCer;
        }

        private void obtenerDatosInput()
        {
            this.configuracion.razonSocial = this.txtrazonsocial.Text;
            this.configuracion.rfc = this.txtrfc.Text;
            this.configuracion.cp = this.txtcp.Text;
            this.configuracion.correo = this.txtcorreo.Text;
            this.configuracion.noCertificado = this.txtcertificado.Text;
             

            if (!string.IsNullOrEmpty(this.txtcer.Text))
            {
                if (!isCerBase64)
                {
                    this.configuracion.archivoCer = ConvertFileToBase64(this.txtcer.Text);
                }
                else
                {
                    this.configuracion.archivoCer = this.txtcer.Text;
                }
            }
            if (!string.IsNullOrEmpty(this.txtkey.Text))
            {
                if (!isKeyBase64)
                {
                    this.configuracion.archivoKey = ConvertFileToBase64(this.txtkey.Text);
                }
                else
                {
                    this.configuracion.archivoKey = this.txtkey.Text;
                }
            }

            if (!string.IsNullOrEmpty(this.txtpasswordkey.Text))
            {
                byte[] salt = GenerateSalt();
                byte[] hash = HashPassword(this.txtpasswordkey.Text, salt);
                this.configuracion.passwordKey = hash;
                this.configuracion.salt = salt; 
            }
            else
            {
                this.configuracion.passwordKey = configuracion.passwordKey;
                this.configuracion.salt = configuracion.salt;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerDatosInput();
            Configuracion_Negocio cn = new Configuracion_Negocio();
            cn.agregarFacturaDatos(configuracion);
            MessageBox.Show("Configuración guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.inicializar();
        }

        private void btnCer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Certificate Files (*.cer)|*.cer",
                Title = "Seleccione el archivo .cer"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtcer.Text = openFileDialog.FileName;
                isCerBase64 = false;
            }
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Key Files (*.key)|*.key",
                Title = "Seleccione el archivo .key"
            };

            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                this.txtkey.Text = openFileDialog.FileName;
                isKeyBase64 = false;
            }
        }

        private string ConvertFileToBase64(string filePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            return Convert.ToBase64String(fileBytes);
        }

        public static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                return salt;
            }
        }

        public static byte[] HashPassword(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                return pbkdf2.GetBytes(20);
            }
        }
    }
}
