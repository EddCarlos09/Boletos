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
using System.Windows.Forms;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;


namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCatMaletasV2 : MaterialForm
    {

        private void frmCatMaletasV2_Load(object sender, EventArgs e)
        {

        }
        private Maletas infoMaletas = new Maletas();
        private int Verificador;
        public frmCatMaletasV2(Maletas maletas)
        {
            try
            {
                InitializeComponent();
                infoMaletas = maletas;
                loadMaterial(this);
                this.Inicializar();

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
                this.infoMaletas.folioMaleta = "";
                this.infoMaletas.numeroMaletas = 0;
                this.infoMaletas.descripcion = "";
                this.infoMaletas.precioMaletaTotal = 0.0F;

                Maletas_Negocio mn = new Maletas_Negocio();
                DataTable lstMaletas = new DataTable();
                mn.LlenarGridMaletas(Comun.Conexion, ref lstMaletas, infoMaletas.id_boleto);

                this.dgvdatosMaletas.AutoGenerateColumns = false;
                this.dgvdatosMaletas.DataSource = lstMaletas;

                this.txt_folioBoleto.Text = infoMaletas.folioBoleto;
                this.txt_linea.Text = infoMaletas.lineaMarca;
                this.txt_origen.Text = infoMaletas.origen;
                this.txt_destino.Text = infoMaletas.destino;
                this.txt_fecha.Text = infoMaletas.fechaSalida.ToShortDateString();
                this.txt_hora.Text = infoMaletas.horaSalida;
                this.txt_nombre.Text = infoMaletas.cliente;
                this.txt_precio.Text = string.Format("{0:c}", infoMaletas.precioIva);
                this.txt_asiento.Text = infoMaletas.asiento.ToString();

                int Numero_Maletas = 0;
                float Total_Monto_Maletas = 0.0F;

                foreach (DataRow row in lstMaletas.Rows)
                {
                    Numero_Maletas = Numero_Maletas + Convert.ToInt32(row["numeroMaletas"].ToString());
                    Total_Monto_Maletas = Total_Monto_Maletas + Convert.ToSingle(row["precio"].ToString());
                }
                this.Txt_NumeroMaletas.Text = Convert.ToString(Numero_Maletas);
                this.Txt_TotalMaletas.Text = string.Format("{0:c}", Total_Monto_Maletas);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCatMaletasNueva fcmn = new frmCatMaletasNueva(infoMaletas);
                fcmn.ShowDialog();
                fcmn.Dispose();
                this.Inicializar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar este registro?", "Sistema Punto de Venta CSL", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.obtenerDatos();
                    Maletas_Negocio maletas_negocio = new Maletas_Negocio();
                    maletas_negocio.EliminarMaletas(Comun.Conexion, ref Verificador, ref infoMaletas);
                    if (this.Verificador == 1)
                    {
                        this.Inicializar();
                        MessageBox.Show("Maleta Eliminada Correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Txt_PrecioMaleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Validaciones Val = new Validaciones();
                Val.PermitirSoloNumerosDecimales(e, this.Txt_TotalMaletas.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Boleto boleto = new Boleto(Comun.Conexion);
                ImprimirTicket imptk = new ImprimirTicket();
                this.obtenerDatos();
                boleto.id_boleto = infoMaletas.id_boleto;
                boleto.id_maleta = infoMaletas.idMaleta;
                imptk.imprimirboleto(boleto, 3);

                boleto = new Boleto(Comun.Conexion);
                imptk = new ImprimirTicket();
                boleto.id_boleto = infoMaletas.id_boleto;
                boleto.id_maleta = infoMaletas.idMaleta;
                imptk.imprimirboleto(boleto, 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnImprimirC_Click(object sender, EventArgs e)
        {
            try
            {
                this.obtenerDatos();
                frmReportes frmReportesVista = new frmReportes(14, infoMaletas);
                frmReportesVista.ShowDialog();
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

        private List<DataGridViewRow> ObtenerFilaSeleccionada()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in this.dgvdatosMaletas.Rows)
                {
                    if (row.Selected)
                    {
                        rowSelected.Add(row);
                    }
                }
                return rowSelected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void obtenerDatos()
        {
            try
            {
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    this.infoMaletas.idMaleta = row.Cells["id_maleta"].Value.ToString();
                    this.infoMaletas.id_boleto = row.Cells["id_boleto"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
