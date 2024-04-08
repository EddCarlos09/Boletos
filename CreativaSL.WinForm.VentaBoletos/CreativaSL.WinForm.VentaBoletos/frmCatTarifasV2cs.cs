using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;
using MaterialSkin.Controls;
using System.Windows.Forms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmCatTarifasV2cs : MaterialForm
    {
        Tarifa tarifas;
        public frmCatTarifasV2cs()
        {
            InitializeComponent();
            this.llenarComboViaje();
            this.EstablecerPropiedadesListRutas();
        }

        public frmCatTarifasV2cs(Tarifa tarifa)
        {
            InitializeComponent();
            this.llenarComboViaje();
            this.EstablecerPropiedadesListRutas();
            tarifas = tarifa;
            this.llenarDatos();
        }

        private void llenarDatos()
        {
            try
            {
                this.cmbViajes.SelectedValue = tarifas.id_viaje;
                this.cmbViajes.Enabled = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void frmCatSalidas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarComboViaje()
        {
            try
            {
                Viaje_Negocio vn = new Viaje_Negocio();
                Viaje viajes = new Viaje(Comun.Conexion);
                viajes = vn.llenarComboViajes(viajes);
                this.cmbViajes.DataSource = viajes.comboViajes;
                this.cmbViajes.DisplayMember = "nombre";
                this.cmbViajes.ValueMember = "id_viaje";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void RecorrerFor(List<string> campos, MaterialListView materialListView)
        {
            materialListView.Columns.Clear();
            for (var index = 0; index < campos.Count; index++)
            {
                // this.HeaderTextGridGeneral(index, campos[index]);
                ColumnHeader columna = materialListView.Columns.Add(campos[index]);
                columna.Width = 150;
            }
        }

        private void EstablecerPropiedadesListRutas()
        {
            try
            {
                var Headertexts = new List<string> { "Terminal Origen", "Terminal Destino", "Precio 1 Piso","Precio 2 piso" };
                var Names = new List<string> { "terminalOrigen" };

                this.RecorrerFor(Headertexts, this.dgvTarifas);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarGridTarifas(Tarifa tarifas)
        {
            //try
            //{
            //    Tarifa_Negocio tn = new Tarifa_Negocio();
            //    tarifas = tn.obtenerTarifas(tarifas);
            //    this.dgvTarifas.AutoGenerateColumns = false;
            //    BindingSource binding = new BindingSource();
            //    binding.DataSource = tarifas.datatable_tarifas;
            //    this.dgvTarifas.DataSource = binding;
            //}
            //catch (Exception ex)
            //{
            //}

            try
            {
                // Limpiar los elementos existentes en el ListView
                this.dgvTarifas.Items.Clear();

                Tarifa_Negocio tn = new Tarifa_Negocio();
                tarifas = tn.obtenerTarifas(tarifas);
                // Iterar sobre tus datos y agregarlos al ListView
                foreach (DataRow row in tarifas.datatable_tarifas.Rows)
                {
                    // Crear un ListViewItem con la información de cada fila de la tabla de tarifas
                    ListViewItem item = new ListViewItem(row["terminalOrigen"].ToString()); // Reemplaza "Columna1" con el nombre de la primera columna

                    // Agregar subelementos al ListViewItem para las columnas adicionales
                    item.SubItems.Add(row["terminalDestino"].ToString()); // Reemplaza "Columna2" con el nombre de la segunda columna, y así sucesivamente
                    item.SubItems.Add(row["precioNormal1"].ToString());
                    item.SubItems.Add(row["precioNormal2"].ToString());
                    // Agregar el ListViewItem al ListView
                    this.dgvTarifas.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Tarifa tarifas = new Tarifa(Comun.Conexion);
                Viaje viaje = (Viaje)this.cmbViajes.SelectedItem;
                tarifas.id_viaje = viaje.id_viaje;
                this.llenarGridTarifas(tarifas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbViajes_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void dgvTarifas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        //private List<Tarifa> obtenerDatos()
        //{
        //    try
        //    {
        //        List<Tarifa> tarifas = new List<Tarifa>();

        //        foreach (DataGridViewRow fila in this.dgvTarifas.Rows)
        //        {
        //            Tarifa tarifa = new Tarifa(Comun.Conexion);
        //            tarifa.id_tarifa = fila.Cells["id_tarifa"].Value.ToString();
        //            tarifa.id_viaje = fila.Cells["id_identificador"].Value.ToString();
        //            tarifa.id_terminalXruta = fila.Cells["id_terminalXruta"].Value.ToString();
        //            tarifa.precioEspecial1piso = float.Parse(fila.Cells["precioEspecial1"].Value.ToString());
        //            tarifa.precioInfantil1piso = float.Parse(fila.Cells["precioInfantil1"].Value.ToString());
        //            tarifa.precioNormal1piso = float.Parse(fila.Cells["precioNormal1"].Value.ToString());
        //            tarifa.precioTerceraEdad1piso = float.Parse(fila.Cells["precioTerceraEdad1"].Value.ToString());

        //            tarifa.precioEspecial2piso = float.Parse(fila.Cells["precioEspecial2"].Value.ToString());
        //            tarifa.precioInfantil2piso = float.Parse(fila.Cells["precioInfantil2"].Value.ToString());
        //            tarifa.precioNormal2piso = float.Parse(fila.Cells["precioNormal2"].Value.ToString());
        //            tarifa.precioTerceraEdad2piso = float.Parse(fila.Cells["precioTerceraEdad2"].Value.ToString());
        //            tarifas.Add(tarifa);
        //        }
        //        return tarifas;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Tarifa tarifas = new Tarifa(Comun.Conexion);
                //tarifas.listaTarifas = this.obtenerDatos();
                Tarifa_Negocio tn = new Tarifa_Negocio();
                tn.ActualizarDatos(tarifas);
                MessageBox.Show("Datos guardados correctamente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Viaje viaje = (Viaje)this.cmbViajes.SelectedItem;
                tarifas.id_viaje = viaje.id_viaje;
                this.llenarGridTarifas(tarifas);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos guardados correctamente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
