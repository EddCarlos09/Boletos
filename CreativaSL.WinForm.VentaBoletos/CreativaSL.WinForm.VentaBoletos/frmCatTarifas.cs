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
    public partial class frmCatTarifas : Form_Creativa
    {
        Tarifa tarifas;
        public frmCatTarifas()
        {
            InitializeComponent();
            this.llenarComboViaje();
        }

        public frmCatTarifas(Tarifa tarifa)
        {
            InitializeComponent();
            this.llenarComboViaje();
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

        private void llenarGridTarifas(Tarifa tarifas)
        {
            try
            {
                Tarifa_Negocio tn = new Tarifa_Negocio();
                tarifas = tn.obtenerTarifas(tarifas);
                this.dgvTarifas.AutoGenerateColumns = false;
                BindingSource binding = new BindingSource();
                binding.DataSource = tarifas.datatable_tarifas;
                this.dgvTarifas.DataSource = binding;
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

        private List<Tarifa> obtenerDatos()
        {
            try
            {
                List<Tarifa> tarifas = new List<Tarifa>();

                foreach (DataGridViewRow fila in this.dgvTarifas.Rows)
                {
                    Tarifa tarifa = new Tarifa(Comun.Conexion);
                    tarifa.id_tarifa = fila.Cells["id_tarifa"].Value.ToString();
                    tarifa.id_viaje = fila.Cells["id_identificador"].Value.ToString();
                    tarifa.id_terminalXruta = fila.Cells["id_terminalXruta"].Value.ToString();
                    tarifa.precioEspecial1piso = float.Parse(fila.Cells["precioEspecial1"].Value.ToString());
                    tarifa.precioInfantil1piso = float.Parse(fila.Cells["precioInfantil1"].Value.ToString());
                    tarifa.precioNormal1piso = float.Parse(fila.Cells["precioNormal1"].Value.ToString());
                    tarifa.precioTerceraEdad1piso = float.Parse(fila.Cells["precioTerceraEdad1"].Value.ToString());

                    tarifa.precioEspecial2piso = float.Parse(fila.Cells["precioEspecial2"].Value.ToString());
                    tarifa.precioInfantil2piso = float.Parse(fila.Cells["precioInfantil2"].Value.ToString());
                    tarifa.precioNormal2piso = float.Parse(fila.Cells["precioNormal2"].Value.ToString());
                    tarifa.precioTerceraEdad2piso = float.Parse(fila.Cells["precioTerceraEdad2"].Value.ToString());
                    tarifas.Add(tarifa);
                }
                return tarifas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Tarifa tarifas = new Tarifa(Comun.Conexion);
                tarifas.listaTarifas = this.obtenerDatos();
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
