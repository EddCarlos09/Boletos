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

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmTipoObjeto : Form_Creativa
    {
        public frmTipoObjeto()
        {
            try
            {
                InitializeComponent();
                DialogResult = System.Windows.Forms.DialogResult.Ignore;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private int _numeroasiento = 0;
        public int Numeroasiento
        {
            get { return _numeroasiento; }
           
        }
        
        private int _tipoobjeto = 0;
        public int Tipoobjeto
        {
            get { return _tipoobjeto; }
           
        }


        private void txtWC_Click(object sender, EventArgs e)
        {
            try
            {
                _numeroasiento = 0;
                _tipoobjeto = 3;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void txtBar_Click(object sender, EventArgs e)
        {
            try
            {
                _numeroasiento =0;
                _tipoobjeto = 4;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void txtAsiento_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                { 
                    int numero = Convert.ToInt32(txtAsiento.Text);
                    if (numero > 0)
                    {
                        _numeroasiento = numero;
                        _tipoobjeto = 1;
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();

                    }
                    else
                    MessageBox.Show("EL número debe ser mayor de Cero", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();                
            }
        }



       

       
    }
}
