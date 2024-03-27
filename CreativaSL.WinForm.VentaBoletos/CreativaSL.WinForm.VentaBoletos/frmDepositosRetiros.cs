using CreativaSL.LibControls.WinForms;
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
using System.Globalization;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmDepositosRetiros : Form_Creativa
    {

        int TipoForm;
        private CultureInfo provider = CultureInfo.CurrentCulture;
        public frmDepositosRetiros(int op)
        {
            InitializeComponent();
            TipoForm = op;
            TipoFormDatos();
        }

        private void TipoFormDatos()
        {
            switch (TipoForm)
            {
                case 1: //Deposito
                    this.Text = "Deposito";
                    label9.Text = "Deposito de Efectivo a Caja";
                    break;
                case 2: //retiro por Caja LLena
                    this.Text = "Retiro";
                    label9.Text = "Retiro de Efectivo, por caja llena";
                    break;

                case 3: //Retir por pago 
                    this.Text = "Retiro";
                    label9.Text = "Retiro de Efectivo, por concepto de pago";
                    break;

            }
        }

        private void frmDepositosRetiros_Load(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dc = Convert.ToDecimal(txtMonto.Text, provider);
                if (dc > 0)
                {
                    Caja_Negocio cajneg = new Caja_Negocio();
                     if (txtConcepto.Text != "")
                    {
                        switch (TipoForm)
                        {
                            case 1: //deposito
                                cajneg.AgregarDeposito(dc, txtConcepto.Text);
                                break;
                            case 2: //retiro caja llena
                                cajneg.AgregarRetiro(dc, txtConcepto.Text, 1);
                                break;
                            case 3: //retiro pago
                                cajneg.AgregarRetiro(dc, txtConcepto.Text, 2);
                                break;
                        }

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        MessageBox.Show("Se ha agregado correctamento el movimiento", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Debe indicar el concepto por el cual se está realizando el movimiento", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMonto_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal dc = Convert.ToDecimal(txtMonto.Text,provider);
            }
            catch (Exception)
            {
                txtMonto.Focus();
                MessageBox.Show("El dato capturado debe ser un monto numérico", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
