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

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmFechaViajeDetalleV2 : MaterialForm
    {
        private Viaje _infoViajes = new Viaje(Comun.Conexion);
        public frmFechaViajeDetalleV2(Viaje viaje)
        {
            InitializeComponent();
            _infoViajes = viaje;
        }
        private void frmFechasViajesDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                inicalizar();
            }
            catch (Exception ex)
            {
            }
        }

        private void inicalizar()
        {
            DateTime FechaInicio = new DateTime(dtPickerAnioMes.Value.Year, dtPickerAnioMes.Value.Month, 1);
            DateTime FechaFin = new DateTime(dtPickerAnioMes.Value.Year, dtPickerAnioMes.Value.Month, DateTime.DaysInMonth(this.dtPickerAnioMes.Value.Year, this.dtPickerAnioMes.Value.Month));
            Viaje_Negocio vn = new Viaje_Negocio();
            vn.obtenerViajesXFechas(Comun.Conexion, _infoViajes, FechaInicio, FechaFin);
            this.dgvdatosViajesXFechas.AutoGenerateColumns = false;
            this.dgvdatosViajesXFechas.DataSource = _infoViajes.datatable_viajes;
            ImagenGrid();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }
        private void ImagenGrid()
        {
            foreach (DataGridViewRow Grid in this.dgvdatosViajesXFechas.Rows)
            {
                if (Convert.ToInt32(Grid.Cells[3].Value) == 0)
                    Grid.Cells[4].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_RED.png"), new Size(25, 25));
                else if (Convert.ToInt32(Grid.Cells[3].Value) == 1)
                    Grid.Cells[4].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_GREEN.png"), new Size(25, 25));
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void dtPickerAnioMes_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                inicalizar();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
