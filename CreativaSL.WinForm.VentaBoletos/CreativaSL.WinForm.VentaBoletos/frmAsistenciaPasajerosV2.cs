using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmAsistenciaPasajerosV2 : MaterialForm
    {
        Validaciones Val;
        Asistencia infoasistencia = new Asistencia();
        public frmAsistenciaPasajerosV2()
        {
            InitializeComponent();
            loadMaterial(this);
        }
   

        #region Eventos
        private void frmAsistenciaPasajeros_Load(object sender, EventArgs e)
        {
            try
            {
                Inicializar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_folio_KeyPress(object sender, KeyPressEventArgs e)
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
        private void CmbViaje_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Asistencia_Negocio asistenciaNegocio = new Asistencia_Negocio();
                DataRowView drv = (DataRowView)CmbViaje.SelectedItem;
                infoasistencia.id_viaje = drv["id_viaje"].ToString();
                infoasistencia.fechaViaje = Convert.ToDateTime(drv["fechaOrigen"].ToString());
                infoasistencia.horaViaje = drv["horaOrigen"].ToString();
                asistenciaNegocio.CargarListaPasajeros(Comun.Conexion, ref infoasistencia);
                this.dgvdatosboleto.AutoGenerateColumns = false;
                this.dgvdatosboleto.DataSource = infoasistencia.datosPasajeros;
                ImagenGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_folio_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int Verificador = 0;
                    Asistencia_Negocio asistenciaNegocio = new Asistencia_Negocio();
                    infoasistencia.folioBoleto = this.txt_folio.Text;
                    asistenciaNegocio.AsistenciaPasjero(Comun.Conexion, ref infoasistencia, ref Verificador);

                    DataRowView drv = (DataRowView)CmbViaje.SelectedItem;
                    infoasistencia.id_viaje = drv["id_viaje"].ToString();
                    infoasistencia.fechaViaje = Convert.ToDateTime(drv["fechaOrigen"].ToString());
                    infoasistencia.horaViaje = drv["horaOrigen"].ToString();
                    asistenciaNegocio.CargarListaPasajeros(Comun.Conexion, ref infoasistencia);
                    this.dgvdatosboleto.AutoGenerateColumns = false;
                    this.dgvdatosboleto.DataSource = infoasistencia.datosPasajeros;
                    ImagenGrid();
                    VerificarMensaje(Verificador);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Metodos Generales
        private void VerificarMensaje(int Verificador)
        {
            try
            {
                switch (Verificador)
                {
                    case 1:
                        MessageBox.Show("Para poder marcar asistencia debe de pagar el boleto", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        MessageBox.Show("Asistencia ya marcada", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("Asistencia registrada correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        MessageBox.Show("Folio del boleto no Encontrado", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void Inicializar()
        {
            try
            {
                Asistencia_Negocio asistenciaNegocio = new Asistencia_Negocio();
                infoasistencia.fechaViaje = DateTime.Now;
                asistenciaNegocio.CargarComboViaje(Comun.Conexion, ref infoasistencia);
                this.CmbViaje.SelectedValueChanged -= new System.EventHandler(this.CmbViaje_SelectedValueChanged);
                this.CmbViaje.DataSource = infoasistencia.datosViajes;
                this.CmbViaje.ValueMember = "id_viaje";
                this.CmbViaje.DisplayMember = "nombreViaje";
                this.CmbViaje.SelectedValueChanged += new System.EventHandler(this.CmbViaje_SelectedValueChanged);

                DataRowView drv = (DataRowView)CmbViaje.SelectedItem;
                infoasistencia.id_viaje = drv["id_viaje"].ToString();
                infoasistencia.fechaViaje = Convert.ToDateTime(drv["fechaOrigen"].ToString());
                infoasistencia.horaViaje = drv["horaOrigen"].ToString();
                asistenciaNegocio.CargarListaPasajeros(Comun.Conexion, ref infoasistencia);
                this.dgvdatosboleto.AutoGenerateColumns = false;
                this.dgvdatosboleto.DataSource = infoasistencia.datosPasajeros;
                ImagenGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ImagenGrid()
        {
            foreach (DataGridViewRow Grid in this.dgvdatosboleto.Rows)
            {
                if (Convert.ToBoolean(Grid.Cells[5].Value) == false && Convert.ToString(Grid.Cells[2].Value) == "")
                    Grid.Cells[6].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_BLUE.png"), new Size(25, 25));
                else if (Convert.ToBoolean(Grid.Cells[5].Value) == false)
                    Grid.Cells[6].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_ORANGE.png"), new Size(25, 25));
                else if (Convert.ToBoolean(Grid.Cells[5].Value) == true)
                    Grid.Cells[6].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_GREEN.png"), new Size(25, 25));
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        #endregion
    }
}
