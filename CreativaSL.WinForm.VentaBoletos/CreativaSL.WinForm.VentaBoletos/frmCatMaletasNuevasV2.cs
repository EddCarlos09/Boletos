using System;
using System.Collections.Generic;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;
using System.Windows.Forms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using System.Globalization;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCatMaletasNuevasV2 : MaterialForm
    {
        private Maletas infoMaletas = new Maletas();
        private int Verificador;
        public frmCatMaletasNuevasV2(Maletas maletas)
        {
            try
            {
                InitializeComponent();
                loadMaterial(this);
                infoMaletas = maletas;

                this.label1.ForeColor = Color.Navy; // Cambiar el color del texto
                this.label1.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
                this.label15.ForeColor = Color.Navy; // Cambiar el color del texto
                this.label15.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);

                this.label9.ForeColor = Color.DimGray;
                this.label9.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                this.label17.ForeColor = Color.DimGray;
                this.label17.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                this.label8.ForeColor = Color.DimGray;
                this.label8.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);


                this.label12.ForeColor = Color.DimGray;
                this.label12.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

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
                this.Txt_Folio.Text = this.infoMaletas.folioMaleta;
                this.Txt_Descripcion.Text = this.infoMaletas.descripcion;
                this.Txt_NumeroMaletas.Text = "0";
                this.Txt_PrecioMaleta.Text = string.Format("{0:c}", 0.0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Txt_Folio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones Val = new Validaciones();
                Val.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones Val = new Validaciones();
                Val.SoloAlfaNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            if (this.Txt_Folio.Text.Length == 0)
            {
                MessageBox.Show("Debes de ingresar el folio de la maleta", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (this.Txt_Descripcion.Text.Length == 0)
            {
                MessageBox.Show("Debes de ingresar la descripción", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (this.Txt_NumeroMaletas.Text.Length == 0)
            {
                MessageBox.Show("Debes de ingresar el numero de maletas", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (this.Txt_PrecioMaleta.Text.Length == 0)
            {
                MessageBox.Show("Debes de ingresar el precio", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validar())
                {
                    Maletas_Negocio maletas_negocio = new Maletas_Negocio();
                    this.obtenerDatos();
                    maletas_negocio.AgregarMaletas(Comun.Conexion, ref Verificador, ref infoMaletas);

                    Boleto boleto = new Boleto(Comun.Conexion);
                    ImprimirTicket imptk = new ImprimirTicket();
                    boleto.id_boleto = infoMaletas.id_boleto;
                    boleto.id_maleta = infoMaletas.idMaleta;
                    imptk.imprimirboleto(boleto, 3);

                    boleto = new Boleto(Comun.Conexion);
                    imptk = new ImprimirTicket();
                    boleto.id_boleto = infoMaletas.id_boleto;
                    boleto.id_maleta = infoMaletas.idMaleta;
                    imptk.imprimirboleto(boleto, 3);

                    if (this.Verificador == 1)
                    {
                        MessageBox.Show("Maleta Agregada Correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void obtenerDatos()
        {
            try
            {
                this.infoMaletas.folioMaleta = this.Txt_Folio.Text;
                this.infoMaletas.descripcion = this.Txt_Descripcion.Text;
                this.infoMaletas.numeroMaletas = Convert.ToInt32(this.Txt_NumeroMaletas.Text);
                this.infoMaletas.precioMaleta = float.Parse(this.Txt_PrecioMaleta.Text, NumberStyles.Currency);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Txt_PrecioMaleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones Val = new Validaciones();
                Val.PermitirSoloNumerosDecimales(e, this.Txt_PrecioMaleta.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
