using System;
using System.Collections.Generic;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCaja_AperturaCajaV2 : MaterialForm
    {
        public frmCaja_AperturaCajaV2()
        {
            try
            {
                InitializeComponent();
                this.inicializar();
                loadMaterial(this);
                this.label2.ForeColor = Color.Navy;
                this.label2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label3.ForeColor = Color.Navy;
                this.label3.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label4.ForeColor = Color.Navy; // Cambiar el color del texto
                this.label4.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                this.label1.ForeColor = Color.DimGray;
                this.label1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label5.ForeColor = Color.DimGray;
                this.label5.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label6.ForeColor = Color.DimGray;
                this.label6.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label7.ForeColor = Color.DimGray;
                this.label7.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label8.ForeColor = Color.DimGray;
                this.label8.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label9.ForeColor = Color.DimGray;
                this.label9.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label10.ForeColor = Color.DimGray;
                this.label10.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label11.ForeColor = Color.DimGray;
                this.label11.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label12.ForeColor = Color.DimGray;
                this.label12.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label13.ForeColor = Color.DimGray;
                this.label13.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label14.ForeColor = Color.DimGray;
                this.label14.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label15.ForeColor = Color.DimGray;
                this.label15.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label16.ForeColor = Color.DimGray;
                this.label16.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label17.ForeColor = Color.DimGray;
                this.label17.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label20.ForeColor = Color.DimGray;
                this.label20.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                this.label22.ForeColor = Color.DimGray;
                this.label22.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eventos

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                this.guardarAperturaCaja();
                this.Exception = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TxtM50C_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM1P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM2P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM5P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM10P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtM20P_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.permitirSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
