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
    public partial class frmViajesXFechas : Form
    {

        private bool _salir = false;
        private Home homes = new Home();

        public frmViajesXFechas()
        {
            try
            {
                InitializeComponent();
                this.Inicializar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region MetodosGenerales
        private void dtmFechaSalida_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToDateTime(dtmFechaSalida.Value.ToShortDateString()) > Convert.ToDateTime(DateTime.Now.AddDays(30).ToShortDateString()))
                {
                    MessageBox.Show("No puedes buscar a una fecha mayor a " + DateTime.Now.AddDays(30).ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtmFechaSalida.Value = DateTime.Now;
                }
                if (Convert.ToDateTime(dtmFechaSalida.Value.ToShortDateString()) < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    MessageBox.Show("No puedes buscar a una fecha menor a " + DateTime.Now.ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtmFechaSalida.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarDatosBusqueda()
        {
            try
            {

                if (dtmFechaSalida.Value > DateTime.Now.AddDays(30))
                {
                    MessageBox.Show("No puedes buscar a una fecha mayor a " + DateTime.Now.AddDays(30).ToShortDateString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtmFechaSalida.Value = DateTime.Now;
                    return false;
                }
                if (this.cmbComboOrigen.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione un Origen", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (this.cmbComboDestino.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione un Destino", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CargarCombos()
        {
            Home_Negocio home_negocio = new Home_Negocio();
            home_negocio.CargarComboTerminales(Comun.Conexion, ref homes);

            this.cmbComboOrigen.DataSource = this.homes.lista_Origen;
            this.cmbComboOrigen.DisplayMember = "terminal";
            this.cmbComboOrigen.ValueMember = "id_terminal";

            this.cmbComboDestino.DataSource = this.homes.lista_Destino;
            this.cmbComboDestino.DisplayMember = "terminal";
            this.cmbComboDestino.ValueMember = "id_terminal";

        }
        private void Inicializar()
        {
            try
            {
                homes.IDBoleto = "";
                homes.IDViaje = "";
                homes.IDTarifa = "";
                homes.IDTipoTarifa = 0;
                homes.NumCamion = "";
                homes.TipoLinea = "";
                homes.Asiento = 0;
                homes.DescripcionIndice = "";
                homes.IDCamionDiseño = "";
                homes.FechaSalida = DateTime.Now;
                homes.HoraSalida = "";
                homes.FechaSalidaV = DateTime.Now;
                homes.HoraSalidaV = "";
                homes.FechaLLegadaV = DateTime.Now;
                homes.HoraLlegadaV = "";
                homes.Origen = "";
                homes.Destino = "";
                homes.Precio = 0F;
                homes.Descuentos = 0F;
                homes.TipoDescuento = 0;
                homes.Nombre = "";
                homes.precioNormal1 = 0F;
                homes.precioInfantil1 = 0F;
                homes.precioTerceraEdad1 = 0F;
                homes.precioEspecial1 = 0F;
                homes.precioNormal2 = 0F;
                homes.precioInfantil2 = 0F;
                homes.precioTerceraEdad2 = 0F;
                homes.precioEspecial2 = 0F;
                homes.IDStatus = 0;
                homes.Anticipo = 0F;
                homes.IDBoletoTransferencia = "";

                homes.TipoTerminal = 0;
                homes.NumAsientos = 0;
                homes.NumAsientosDiponibles = 0;
                homes.NumAsientosApartado = 0;
                homes.Recorrido = "";

                homes.OrdenOrigen = 0;
                homes.OrdenDestino = 0;

                homes.PagoExtra = 0F;

                this.EstablecerPropiedadesGridViewViajes();
                this.CargarCombos();

                this.Txt_NumAsientos.Text = this.homes.NumAsientos.ToString();
                this.Txt_NumAsientosDisponibles.Text = this.homes.NumAsientosDiponibles.ToString();
                this.Txt_NumAsientosApartados.Text = this.homes.NumAsientosApartado.ToString();
                this.Txt_Recorrido.Text = this.homes.Recorrido.ToString();

                this.GridViewViajes.DataSource = homes.Salidas;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridViewViajes
        private void CargarGridViewViajes(string IDTerminalOrigen, string IDTerminalDestino, DateTime FechaBusqueda)
        {
            try
            {
                Home_Negocio catalogoNegocio = new Home_Negocio();
                Home home = new Home();
                catalogoNegocio.LlenarGridSalidas(Comun.Conexion, ref home, IDTerminalOrigen, IDTerminalDestino, FechaBusqueda);
                this.GridViewViajes.AutoGenerateColumns = false;
                this.GridViewViajes.DataSource = home.Salidas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridViewViajes()
        {
            try
            {
                var Headertexts = new List<string> { "Tipo Linea", "Origen", "Fecha", "Hora", "Destino", "Fecha", "Hora", "Precio", "Tipo Viaje" };
                var Names = new List<string> { "camion", "terminalOrigen", "fechaOrigenV", "horaOrigenV", "terminalDestino", "fechaDestinoV", "horaDestinoV", "precioNormal1", "tipoTerminal", "numAsiento", "precioInfantil1", "precioTerceraEdad1", "precioEspecial1", "precioNormal2", "precioInfantil2", "precioTerceraEdad2", "precioEspecial2", "nombreViaje", "numCamion", "tiempoMinutos", "numPiso", "id_tipoViaje", "id_tipoTerminal", "id_viaje", "id_ruta", "id_camion", "id_disenioCamion", "id_terminalOrigen", "id_terminalDestino", "id_terminalXruta", "id_tarifa", "ordenOrigen", "ordenDestino", "fechaOrigen", "horaOrigen" };
                this.RecorrerForGridViewViajes(Headertexts, 1);
                this.RecorrerForGridViewViajes(Names, 2);
                this.RecorrerForGridViewViajes(Names, 3);
                this.GridViewViajes.Columns[0].Width = 180;
                this.GridViewViajes.Columns[1].Width = 105;
                this.GridViewViajes.Columns[2].Width = 90;
                this.GridViewViajes.Columns[3].Width = 95;
                this.GridViewViajes.Columns[4].Width = 105;
                this.GridViewViajes.Columns[5].Width = 90;
                this.GridViewViajes.Columns[6].Width = 95;
                this.GridViewViajes.Columns[7].Width = 100;
                this.GridViewViajes.Columns[7].DefaultCellStyle.Format = "c";
                this.GridViewViajes.Columns[8].Width = 100;
                this.GridViewViajes.Columns[9].Visible = false;
                this.GridViewViajes.Columns[10].Visible = false;
                this.GridViewViajes.Columns[11].Visible = false;
                this.GridViewViajes.Columns[12].Visible = false;
                this.GridViewViajes.Columns[13].Visible = false;
                this.GridViewViajes.Columns[14].Visible = false;
                this.GridViewViajes.Columns[15].Visible = false;
                this.GridViewViajes.Columns[16].Visible = false;
                this.GridViewViajes.Columns[17].Visible = false;
                this.GridViewViajes.Columns[18].Visible = false;
                this.GridViewViajes.Columns[19].Visible = false;
                this.GridViewViajes.Columns[20].Visible = false;
                this.GridViewViajes.Columns[21].Visible = false;
                this.GridViewViajes.Columns[22].Visible = false;
                this.GridViewViajes.Columns[23].Visible = false;
                this.GridViewViajes.Columns[24].Visible = false;
                this.GridViewViajes.Columns[25].Visible = false;
                this.GridViewViajes.Columns[26].Visible = false;
                this.GridViewViajes.Columns[27].Visible = false;
                this.GridViewViajes.Columns[28].Visible = false;
                this.GridViewViajes.Columns[29].Visible = false;
                this.GridViewViajes.Columns[30].Visible = false;
                this.GridViewViajes.Columns[31].Visible = false;
                this.GridViewViajes.Columns[32].Visible = false;
                this.GridViewViajes.Columns[33].Visible = false;
                this.GridViewViajes.Columns[34].Visible = false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void RecorrerForGridViewViajes(List<string> campos, int opcion)
        {
            for (var index = 0; index < campos.Count; index++)
            {
                if (opcion == 1)
                    this.HeaderTextGridViewViajes(index, campos[index]);
                else if (opcion == 2)
                    this.NameGridViewViajes(index, campos[index]);
                else if (opcion == 3)
                    this.DataPropertyNameGridViewViajes(index, campos[index]);
            }
        }
        private void HeaderTextGridViewViajes(int numColum, string nombre)
        {
            try
            {
                this.GridViewViajes.Columns[numColum].HeaderText = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void NameGridViewViajes(int numColum, string nombre)
        {
            try
            {
                this.GridViewViajes.Columns[numColum].Name = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DataPropertyNameGridViewViajes(int numColum, string nombre)
        {
            try
            {
                this.GridViewViajes.Columns[numColum].DataPropertyName = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<DataGridViewRow> ObtenerFilaSeleccionadaGridViewViajes()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in GridViewViajes.Rows)
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
        private bool ValidarFilaSeleccionadaGridViewViajes(List<DataGridViewRow> rowSelected)
        {
            try
            {
                if (rowSelected.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una fila del grid", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion     

        private void btn_BuscarViajes_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarDatosBusqueda())
                {
                    this.CargarGridViewViajes(Convert.ToString(this.cmbComboOrigen.SelectedValue), Convert.ToString(this.cmbComboDestino.SelectedValue), Convert.ToDateTime(this.dtmFechaSalida.Value));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CancelarBuscarViajes_Click(object sender, EventArgs e)
        {
            try
            {
                this.GridViewViajes.DataSource = null;
                this.cmbComboOrigen.SelectedIndex = 0;
                this.cmbComboDestino.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void GridViewViajes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (GridViewViajes.SelectedRows.Count > 0)
                {
                    homes.IDBoleto = "";
                    homes.IDViaje = this.GridViewViajes.SelectedRows[0].Cells["id_viaje"].Value.ToString();
                    homes.FechaSalida = Convert.ToDateTime(this.GridViewViajes.SelectedRows[0].Cells["fechaOrigen"].Value.ToString());
                    homes.HoraSalida = this.GridViewViajes.SelectedRows[0].Cells["horaOrigen"].Value.ToString();
                    homes.IDTarifa = this.GridViewViajes.SelectedRows[0].Cells["id_tarifa"].Value.ToString();
                    homes.IDTipoTarifa = 0; //Se Vuelve A Pedir
                    homes.NumCamion = this.GridViewViajes.SelectedRows[0].Cells["numCamion"].Value.ToString();
                    homes.TipoLinea = this.GridViewViajes.SelectedRows[0].Cells["camion"].Value.ToString();
                    homes.Asiento = 0; //Se Vuelve A Pedir
                    homes.DescripcionIndice = ""; //Se Vuelve A Pedir
                    homes.IDCamionDiseño = this.GridViewViajes.SelectedRows[0].Cells["id_disenioCamion"].Value.ToString();
                    homes.FechaSalidaV = Convert.ToDateTime(this.GridViewViajes.SelectedRows[0].Cells["fechaOrigenV"].Value.ToString());
                    homes.HoraSalidaV = this.GridViewViajes.SelectedRows[0].Cells["horaOrigenV"].Value.ToString();
                    homes.FechaLLegadaV = Convert.ToDateTime(this.GridViewViajes.SelectedRows[0].Cells["fechaDestinoV"].Value.ToString());
                    homes.HoraLlegadaV = this.GridViewViajes.SelectedRows[0].Cells["horaDestinoV"].Value.ToString();
                    homes.Origen = this.GridViewViajes.SelectedRows[0].Cells["terminalOrigen"].Value.ToString(); ;
                    homes.Destino = this.GridViewViajes.SelectedRows[0].Cells["terminalDestino"].Value.ToString();
                    homes.Precio = 0F; //Se Vuelve A Pedir
                    homes.Descuentos = 0F; //Se Vuelve A Pedir
                    homes.TipoDescuento = 0; //Se Vuelve A Pedir
                    homes.Nombre = ""; //Se Vuelve A Pedir
                    homes.precioNormal1 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioNormal1"].Value.ToString(), NumberStyles.Currency);
                    homes.precioInfantil1 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioInfantil1"].Value.ToString(), NumberStyles.Currency);
                    homes.precioTerceraEdad1 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioTerceraEdad1"].Value.ToString(), NumberStyles.Currency);
                    homes.precioEspecial1 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioEspecial1"].Value.ToString(), NumberStyles.Currency);
                    homes.precioNormal2 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioNormal2"].Value.ToString(), NumberStyles.Currency);
                    homes.precioInfantil2 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioInfantil2"].Value.ToString(), NumberStyles.Currency);
                    homes.precioTerceraEdad2 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioTerceraEdad2"].Value.ToString(), NumberStyles.Currency);
                    homes.precioEspecial2 = float.Parse(this.GridViewViajes.SelectedRows[0].Cells["precioEspecial2"].Value.ToString(), NumberStyles.Currency);
                    homes.IDStatus = 0;
                    homes.Anticipo = 0F;

                    homes.TipoTerminal = Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["id_tipoTerminal"].Value.ToString());
                    homes.NumAsientos = Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["numAsientos"].Value.ToString());
                    homes.NumAsientosDiponibles = 0;
                    homes.NumAsientosApartado = 0;
                    homes.Recorrido = this.GridViewViajes.SelectedRows[0].Cells["recorridoViaje"].Value.ToString();
                    homes.IDBoletoTransferencia = "";
                    homes.OrdenOrigen = Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["ordenOrigen"].Value.ToString());
                    homes.OrdenDestino = Convert.ToInt32(this.GridViewViajes.SelectedRows[0].Cells["ordenDestino"].Value.ToString());
                    homes.PagoExtra = 0F;


                    Home_Negocio home_negocio = new Home_Negocio();
                    home_negocio.ObtenerDatosCamion(Comun.Conexion, ref homes);


                    this.Txt_NumAsientos.Text = this.homes.NumAsientos.ToString();
                    this.Txt_NumAsientosDisponibles.Text = this.homes.NumAsientosDiponibles.ToString();
                    this.Txt_NumAsientosApartados.Text = this.homes.NumAsientosApartado.ToString();
                    this.Txt_Recorrido.Text = this.homes.Recorrido.ToString();

                }
                else
                {
                    homes.IDBoleto = "";
                    homes.IDViaje = "";
                    homes.IDTarifa = "";
                    homes.IDTipoTarifa = 0;
                    homes.NumCamion = "";
                    homes.TipoLinea = "";
                    homes.Asiento = 0;
                    homes.DescripcionIndice = "";
                    homes.IDCamionDiseño = "";
                    homes.FechaSalida = DateTime.Now;
                    homes.HoraSalida = "";
                    homes.FechaSalidaV = DateTime.Now;
                    homes.HoraSalidaV = "";
                    homes.FechaLLegadaV = DateTime.Now;
                    homes.HoraLlegadaV = "";
                    homes.Origen = "";
                    homes.Destino = "";
                    homes.Precio = 0F;
                    homes.Descuentos = 0F;
                    homes.TipoDescuento = 0;
                    homes.Nombre = "";
                    homes.precioNormal1 = 0F;
                    homes.precioInfantil1 = 0F;
                    homes.precioTerceraEdad1 = 0F;
                    homes.precioEspecial1 = 0F;
                    homes.precioNormal2 = 0F;
                    homes.precioInfantil2 = 0F;
                    homes.precioTerceraEdad2 = 0F;
                    homes.precioEspecial2 = 0F;
                    homes.numPiso = 0;
                    homes.IDStatus = 0;
                    homes.Anticipo = 0F;
                    homes.IDBoletoTransferencia = "";
                    homes.OrdenOrigen = 0;
                    homes.OrdenDestino = 0;
                    homes.PagoExtra = 0F;
                    homes.NumAsientos = 0;
                    homes.NumAsientosDiponibles = 0;
                    homes.NumAsientosApartado = 0;
                    homes.Recorrido = "";
                    homes.TipoTerminal = 0;


                    this.Txt_NumAsientos.Text = this.homes.NumAsientos.ToString();
                    this.Txt_NumAsientosDisponibles.Text = this.homes.NumAsientosDiponibles.ToString();
                    this.Txt_NumAsientosApartados.Text = this.homes.NumAsientosApartado.ToString();
                    this.Txt_Recorrido.Text = this.homes.Recorrido.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar este Viaje en esta Fecha?", "Eliminar Fecha del Viaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int Verificador = 0;
                    ViajesXFecha_Negocio VXF = new ViajesXFecha_Negocio();
                    VXF.EliminarFechaViaje(Comun.Conexion, homes, ref Verificador);
                    if (this.homes.NumAsientosApartado == 0)
                    {
                        if (Verificador == 1)
                        {
                            this.CargarGridViewViajes(Convert.ToString(this.cmbComboOrigen.SelectedValue), Convert.ToString(this.cmbComboDestino.SelectedValue), Convert.ToDateTime(this.dtmFechaSalida.Value));
                            MessageBox.Show("Se elimino la fecha de este Viaje", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No puedes eliminar la fecha de este Viaje", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (this.homes.NumAsientosApartado > 0)
                    {
                       MessageBox.Show("No puedes eliminar la fecha de este Viaje porque tiene boletos ya ocupados", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
