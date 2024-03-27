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
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCatDisenio : Form_Creativa
    {
        private DisenioCamion infoDisenioCamion;
        #region Constructor
        private void frmCatDisenio_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        public frmCatDisenio(DisenioCamion Diseño)
        {
            try
            {
                this.infoDisenioCamion = Diseño;
                InitializeComponent();
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public frmCatDisenio(DisenioCamion Diseño,int aux)
        {
            try
            {
                this.infoDisenioCamion = Diseño;
                InitializeComponent();
                this.Inicializar2();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos Generales
        private void Inicializar2()
        {
            try
            {
                this.txt_Nombre.ReadOnly = true;
                this.txt_Descripcion.ReadOnly = true;
                this.btnGuardar.Visible = false;
                this.cmbNumPisos.SelectedIndex = 1;
                if (this.infoDisenioCamion.id_disenioCamion != null)
                {
                    this.ActualizarDatos();
                    this.LLenarDatos();
                }
                this.cmbNumPisos.Enabled = false;
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
                this.cmbNumPisos.SelectedIndex = 0;
                if(this.infoDisenioCamion.id_disenioCamion != null)
                       this.LLenarDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ActualizarDatos()
        {
            try
            {
                int NumTv = 0, NumWC = 0, NumBares = 0, NumAsientos = 0, NumPuertas = 0;
                foreach (DataRow row in this.infoDisenioCamion.TablaObjetos.Rows)
                {
                    if (Convert.ToInt32(row["idTipoObj"]) == 1)
                        NumAsientos = NumAsientos + 1;
                    else if (Convert.ToInt32(row["idTipoObj"]) == 2)
                        NumTv = NumTv + 1;
                    else if (Convert.ToInt32(row["idTipoObj"]) == 3)
                        NumWC = NumWC + 1;
                    else if (Convert.ToInt32(row["idTipoObj"]) == 4)
                        NumBares = NumBares + 1;
                    else if (Convert.ToInt32(row["idTipoObj"]) == 5)
                        NumPuertas = NumPuertas + 1;
                }
                this.infoDisenioCamion.NumAsientos = NumAsientos;
                this.infoDisenioCamion.NumTvs = NumTv;
                this.infoDisenioCamion.NumBaños = NumWC;
                this.infoDisenioCamion.NumBares = NumBares;
                this.infoDisenioCamion.NumPuertas = NumPuertas;
                this.Txt_NumAsientos.Text = NumAsientos.ToString();
                this.txt_NumTv.Text = NumTv.ToString();
                this.txt_NumWC.Text = NumWC.ToString();
                this.Txt_NumBares.Text = NumBares.ToString();
                this.Txt_NumPuertas.Text = NumPuertas.ToString();
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
                this.txt_Nombre.Text = infoDisenioCamion.Nombre.ToString();
                this.txt_Descripcion.Text = infoDisenioCamion.Descripcion.ToString();
                this.cmbNumPisos.Text = infoDisenioCamion.NumPisos.ToString();
                this.txt_NumTv.Text = infoDisenioCamion.NumTvs.ToString();
                this.txt_NumWC.Text = infoDisenioCamion.NumBaños.ToString();
                this.Txt_NumBares.Text = infoDisenioCamion.NumBares.ToString();
                this.Txt_NumAsientos.Text = infoDisenioCamion.NumAsientos.ToString();
                this.Txt_NumPuertas.Text = infoDisenioCamion.NumPuertas.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GuadarDisenio()
        {
            try
            {
                if (this.ValidarCampos())
                {
                    int Verificador = 0;
                    DisenioCamion Disenio = new DisenioCamion();
                    DisenioCamion_Negocio DisenioCamion_Negocio = new DisenioCamion_Negocio();
                    this.ObtenerDatos(Disenio);
                    if (Disenio.id_disenioCamion != null)
                    {
                        DisenioCamion_Negocio.ModificarDisenio(Comun.Conexion, Disenio, ref Verificador);
                    }
                    else
                    {
                        DisenioCamion_Negocio.InsertarDisenio(Comun.Conexion, Disenio, ref Verificador);
                    }
                    this.VerifcarMensajeAccion(Verificador);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatos(DisenioCamion Disenio)
        {
            try
            {
                Disenio.id_disenioCamion = this.infoDisenioCamion.id_disenioCamion;
                Disenio.Nombre = this.txt_Nombre.Text.ToString();
                Disenio.Descripcion = this.txt_Descripcion.Text.ToString();
                Disenio.NumPisos = Convert.ToInt32(this.cmbNumPisos.Text.ToString());
                Disenio.NumTvs = Convert.ToInt32(this.txt_NumTv.Text.ToString());
                Disenio.NumBaños = Convert.ToInt32(this.txt_NumWC.Text.ToString());
                Disenio.NumBares = Convert.ToInt32(this.Txt_NumBares.Text.ToString());
                Disenio.NumAsientos = Convert.ToInt32(this.Txt_NumAsientos.Text.ToString());
                Disenio.NumPuertas = Convert.ToInt32(this.Txt_NumPuertas.Text.ToString());
                Disenio.TablaObjetos = infoDisenioCamion.TablaObjetos;
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
                if (this.txt_Nombre.Text.Length == 0)
                {
                    this.txt_Nombre.Focus();
                    MessageBox.Show("Escriba el nombre ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.txt_Descripcion.Text.Length == 0)
                {
                    this.txt_Descripcion.Focus();
                    MessageBox.Show("Escriba la descripcion ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (this.infoDisenioCamion.TablaObjetos == null)
                {
                    MessageBox.Show("Ingrese las propiedades del camion ", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void cmbNumPisos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbNumPisos.Text == "1")
                {
                    btnSegundoPiso.Enabled = false;
                }
                else
                {
                    btnSegundoPiso.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrimerPiso_Click(object sender, EventArgs e)
        {
            try
            {
                int numpiso = 1;
                if (infoDisenioCamion.TablaObjetos == null)
                {
                    frmCatDiseñoCamion frmd = new frmCatDiseñoCamion(numpiso);
                    frmd.ShowDialog();
                    infoDisenioCamion.TablaObjetos = frmd.Datos_Camion;
                    frmd.Dispose();
                }
                else
                {
                    frmCatDiseñoCamion frmd = new frmCatDiseñoCamion(numpiso,infoDisenioCamion.TablaObjetos);
                    frmd.ShowDialog();
                    infoDisenioCamion.TablaObjetos = frmd.Datos_Camion;
                    frmd.Dispose();
                }
                this.ActualizarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnSegundoPiso_Click(object sender, EventArgs e)
        {
            try
            {
                int numpiso = 2;
                if (infoDisenioCamion.TablaObjetos == null)
                {
                    frmCatDiseñoCamion frmd = new frmCatDiseñoCamion(numpiso);
                    frmd.ShowDialog();
                    infoDisenioCamion.TablaObjetos = frmd.Datos_Camion;
                    frmd.Dispose();
                }
                else
                {
                    frmCatDiseñoCamion frmd = new frmCatDiseñoCamion(numpiso, infoDisenioCamion.TablaObjetos);
                    frmd.ShowDialog();
                    infoDisenioCamion.TablaObjetos = frmd.Datos_Camion;
                    frmd.Dispose();
                }
                this.ActualizarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.GuadarDisenio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
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
        #endregion


    }
}
