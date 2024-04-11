using System;
using System.Collections.Generic;
using System.ComponentModel;
using MaterialSkin.Controls;
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
    public partial class frmCatTerminalIntermediaV2 : MaterialForm
    {
        private Ruta _rutaint;

        public Ruta rutaint
        {
            get { return _rutaint; }
            set { _rutaint = value; }
        }

        #region Constructor

        public frmCatTerminalIntermediaV2()
        {
            InitializeComponent();
            this.llenarCombos();
        }

        public frmCatTerminalIntermediaV2(Ruta rut_mod)
        {
            InitializeComponent();
            this.llenarCombos();
            this.rutaint = rut_mod;
            this.llenarDatos();
        }

        #endregion

        #region Métodos

        private void llenarCombos()
        {
            try
            {
                this.llenarComboTerminalOrigen(string.Empty);
                this.llenarComboTerminalDestino(string.Empty);
            }
            catch (Exception ex)
            {
            }
        }

        private void llenarComboTerminalOrigen(string id_terminalAux)
        {
            try
            {
                Ruta_Negocio rn = new Ruta_Negocio();
                Ruta ruta = new Ruta(Comun.Conexion);
                ruta.id_terminalAux = id_terminalAux;
                ruta = rn.llenarComboTerminales(ruta);
                this.cmbOrigen.DataSource = ruta.lista_terminales;
                this.cmbOrigen.ValueMember = "id_terminal";
                this.cmbOrigen.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
            }
        }

        private void llenarComboTerminalDestino(string id_terminalAux)
        {
            try
            {
                Ruta_Negocio rn = new Ruta_Negocio();
                Ruta ruta = new Ruta(Comun.Conexion);
                ruta.id_terminalAux = id_terminalAux;
                ruta = rn.llenarComboTerminales(ruta);
                this.cmbDestino.DataSource = ruta.lista_terminales;
                this.cmbDestino.ValueMember = "id_terminal";
                this.cmbDestino.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
            }
        }

        private Ruta obtenerDatos()
        {
            try
            {
                Ruta rutaintermedia = new Ruta(Comun.Conexion);
                Terminal origen = (Terminal)this.cmbOrigen.SelectedItem;
                Terminal destino = (Terminal)this.cmbDestino.SelectedItem;
                rutaintermedia.id_terminalOrigen = origen.id_terminal;
                rutaintermedia.id_terminalDestino = destino.id_terminal;
                rutaintermedia.terminalOrigen = origen.nombre;
                rutaintermedia.terminalDestino = destino.nombre;
                rutaintermedia.tiempo_minutos = this.obtenerTiempoMinutos();
                rutaintermedia.id_usuario = Comun.Id_U;
                rutaintermedia.id_tipoTerminal = 2;
                rutaintermedia.tiempo = this.txtTiempo2.Text;
                rutaintermedia.nuevo = 1;
                if (rutaint != null)
                {
                    rutaintermedia.id_ruta = rutaint.id_ruta;
                    rutaintermedia.nuevo = rutaint.nuevo;
                }
                return rutaintermedia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int obtenerTiempo()
        {
            try
            {
                int tiempo = 0, minutos = 0;
                string aux;
                aux = (txtTiempo2.Text[3].ToString() + txtTiempo2.Text[4].ToString());
                int.TryParse(aux, out minutos);
                if (minutos >= 60)
                    return -1;
                else
                {
                    aux = (txtTiempo2.Text[0].ToString() + txtTiempo2.Text[1].ToString() + txtTiempo2.Text[3].ToString() + txtTiempo2.Text[4].ToString());
                    int.TryParse(aux, out tiempo);
                    return tiempo;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int obtenerTiempoMinutos()
        {
            try
            {
                int tiempo = 0, minutos = 0, hora = 0;
                string aux;
                aux = (txtTiempo2.Text[3].ToString() + txtTiempo2.Text[4].ToString());
                int.TryParse(aux, out minutos);
                if (minutos >= 60)
                    return -1;
                else
                {
                    aux = (txtTiempo2.Text[0].ToString() + txtTiempo2.Text[1].ToString());
                    int.TryParse(aux, out hora);
                    tiempo = (hora * 60) + minutos;
                    return tiempo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void llenarDatos()
        {
            try
            {
                this.cmbOrigen.SelectedValue = this.rutaint.id_terminalOrigen;
                this.cmbDestino.SelectedValue = this.rutaint.id_terminalDestino;
                this.txtTiempo2.Text = this.rutaint.tiempo;
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        #region Eventos
        private void frmCatTerminalIntermedia_Load(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;

                this.rutaint = this.obtenerDatos();
                if (string.IsNullOrWhiteSpace(rutaint.id_terminalOrigen))
                    throw new Exception("Seleccione terminal Origen");
                if (string.IsNullOrWhiteSpace(rutaint.id_terminalDestino))
                    throw new Exception("Seleccione terminal Destino");
                if (rutaint.tiempo_minutos <= 0)
                    throw new Exception("Ingrese el tiempo de viaje");
                this.DialogResult = DialogResult.OK;
                return;
            }
            catch (Exception ex)
            {
                this.txt_mensaje.Visible = true;
                this.txt_mensaje.Text = ex.Message;
            }
        }
        #endregion
    }
}
