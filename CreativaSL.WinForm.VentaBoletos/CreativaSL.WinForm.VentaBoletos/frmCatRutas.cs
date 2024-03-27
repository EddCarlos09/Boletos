using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmCatRutas : Form_Creativa
    {
        #region Variables
        private bool _banModificar = false;
        private Ruta _ruta_principal;
        public Ruta ruta_principal
        {
            get { return _ruta_principal; }
            set { _ruta_principal = value; }
        }
        private int aux = 0;
        #endregion
        #region Constructor
        public frmCatRutas()
        {
            InitializeComponent();
            this.llenarCombos();
            this.ruta_principal = new Ruta(Comun.Conexion);
            this.llenarGridRutasInt();
            aux = 0;
            _banModificar = false;
        }
        public frmCatRutas(Ruta ruta_princ)
        {
            InitializeComponent();
            this.llenarCombos();
            this.ruta_principal = ruta_princ;
            this.obtenerRutasIntermedias();
            this.llenarGridRutasInt();
            this.llenarDatosTiempo();
            aux = 0;
            _banModificar = true;
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
        private void llenarGridRutasInt()
        {
            try
            {
                this.dgv_Rutasinter.AutoGenerateColumns = false;
                BindingSource binding = new BindingSource();
                binding.DataSource = this.ruta_principal.rutas_intermedias;
                this.dgv_Rutasinter.DataSource = binding;
            }
            catch (Exception ex)
            {
            }
        }
        private void obtenerDatos()
        {
            try
            {
                Terminal origen = (Terminal)this.cmbOrigen.SelectedItem;
                Terminal destino = (Terminal)this.cmbDestino.SelectedItem;
                this.ruta_principal.id_terminalOrigen = origen.id_terminal;
                this.ruta_principal.id_terminalDestino = destino.id_terminal;
                this.ruta_principal.id_tipoTerminal = 1;
                this.ruta_principal.terminalOrigen = origen.nombre;
                this.ruta_principal.terminalDestino = destino.nombre;
                this.ruta_principal.tiempo = this.txtTiempo2.Text;
                this.ruta_principal.tiempo_minutos = this.obtenerTiempoMinutos();
                this.ruta_principal.indice = 0;
            }
            catch (Exception ex)
            {
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
        private void obtenerRutasIntermedias()
        {
            try
            {
                Ruta_Negocio rn = new Ruta_Negocio();
                ruta_principal = rn.obtenerRutasIntermedias(ruta_principal);
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
                this.cmbOrigen.SelectedValue = this.ruta_principal.id_terminalOrigen;
                this.cmbDestino.SelectedValue = this.ruta_principal.id_terminalDestino;
                if (this.ruta_principal.tiempo_minutos.ToString().Length == 4)
                    this.txtTiempo2.Text = this.ruta_principal.tiempo_minutos.ToString();
                else
                {
                    string aux = "";
                    for (int i = 0; i < (4 - this.ruta_principal.tiempo_minutos.ToString().Length); i++)
                    {
                        aux += "0";
                    }
                    aux += this.ruta_principal.tiempo_minutos.ToString();
                    this.txtTiempo2.Text = aux;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void llenarDatosTiempo()
        {
            try
            {
                this.cmbOrigen.SelectedValue = this.ruta_principal.id_terminalOrigen;
                this.cmbDestino.SelectedValue = this.ruta_principal.id_terminalDestino;
                int hora = 0, minutos = 0;

                hora = (int)(ruta_principal.tiempo_minutos / 60);
                minutos = ruta_principal.tiempo_minutos % 60;
                this.txtTiempo2.Text = ("00" + hora).Substring(hora.ToString().Length, 2) + ("00" + minutos).Substring(minutos.ToString().Length, 2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void actualizarindices()
        {
            try
            {
                //for (int i = 0; i < this.ruta_principal.rutas_intermedias.Count; i++)
                //{
                //    for (int j = 0; j < this.ruta_principal.rutas_intermedias.Count; j++)
                //    {
                //        if (this.ruta_principal.rutas_intermedias[j].indice > this.ruta_principal.rutas_intermedias[j + 1].indice)
                //        {
                //            Ruta auxiliar = this.ruta_principal.rutas_intermedias[j];
                //            this.ruta_principal.rutas_intermedias[j] = this.ruta_principal.rutas_intermedias[j + 1];
                //            this.ruta_principal.rutas_intermedias[j + 1] = auxiliar;
                //        }
                //    }
                //}
                for (int k = 0; k < this.ruta_principal.rutas_intermedias.Count; k++)
                {
                    Ruta aux = this.ruta_principal.rutas_intermedias[k];
                    aux.indice = k + 1;
                }
            }
            catch (Exception ex)
            {
            }
        }
        #endregion
        #region Eventos
        private void frmRutas_Load(object sender, EventArgs e)
        {
            if(_banModificar == true)
            {
                this.cmbOrigen.Enabled = false;
                this.cmbDestino.Enabled = false;
                this.btnAddTerminal.Enabled = false;
                this.btnDelTerminal.Enabled = false;
                this.btnUpdTerminal.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.txtTiempo2.Enabled = false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txt_mensaje.Visible = false;
                this.obtenerDatos();
                Ruta_Negocio rn = new Ruta_Negocio();
                if (string.IsNullOrEmpty(this.ruta_principal.id_ruta))
                    rn.agregarRuta(this.ruta_principal);
                else
                    rn.modificarRuta(this.ruta_principal);
                MessageBox.Show("Ruta agregada correctamente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                this.txt_mensaje.Visible = true;
                this.txt_mensaje.Text = ex.Message;
                //MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }
        private void btnAddTerminal_Click(object sender, EventArgs e)
        {
            try
            {
                frmCatTerminalIntermedia frmt = new frmCatTerminalIntermedia();
                frmt.ShowDialog();
                if (frmt.DialogResult == DialogResult.OK)
                {
                    aux += 1;
                    if (frmt.rutaint.nuevo == 1)
                        frmt.rutaint.id_ruta = "ruta" + aux;
                    frmt.rutaint.indice = ruta_principal.rutas_intermedias.Count + 1;
                    ruta_principal.rutas_intermedias.Add(frmt.rutaint);
                    this.llenarGridRutasInt();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnDelTerminal_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgv_Rutasinter.SelectedRows.Count > 0)
                {
                    string id_rutadel = this.dgv_Rutasinter.SelectedRows[0].Cells["id_ruta"].Value.ToString();
                    if (DialogResult.Yes == MessageBox.Show("¿Está seguro que desea eliminar la ruta intermedia?", "Sistema Punto de Venta CSL", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        foreach (Ruta subruta in this.ruta_principal.rutas_intermedias)
                        {
                            if (subruta.id_ruta == id_rutadel)
                            {
                                this.ruta_principal.listasubrutas_eliminadas.Add(subruta);
                                this.ruta_principal.rutas_intermedias.Remove(subruta);
                                break;
                            }
                        }
                        this.actualizarindices();
                        this.llenarGridRutasInt();
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un Ruta intermedia", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUpdTerminal_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgv_Rutasinter.SelectedRows.Count > 0)
                {
                    string id_rutaupd = this.dgv_Rutasinter.SelectedRows[0].Cells["id_ruta"].Value.ToString();
                    Ruta ruta_upd = new Ruta(Comun.Conexion);
                    Ruta subruta_upd;
                    foreach (Ruta subruta in this.ruta_principal.rutas_intermedias)
                    {
                        if (subruta.id_ruta == id_rutaupd)
                        {
                            subruta_upd = subruta;

                            ruta_upd.id_ruta = subruta.id_ruta;
                            ruta_upd.id_terminalOrigen = subruta.id_terminalOrigen;
                            ruta_upd.id_terminalDestino = subruta.id_terminalDestino;
                            ruta_upd.terminalOrigen = subruta.terminalOrigen;
                            ruta_upd.terminalDestino = subruta.terminalDestino;
                            ruta_upd.tiempo = subruta.tiempo;
                            ruta_upd.tiempo_minutos = subruta.tiempo_minutos;
                            ruta_upd.id_usuario = subruta.id_usuario;
                            ruta_upd.id_tipoTerminal = subruta.id_tipoTerminal;
                        }
                    }
                    frmCatTerminalIntermedia frmti = new frmCatTerminalIntermedia(ruta_upd);
                    frmti.ShowDialog();
                    if (frmti.DialogResult == DialogResult.OK)
                    {
                        foreach (Ruta subruta in this.ruta_principal.rutas_intermedias)
                        {
                            if (subruta.id_ruta == frmti.rutaint.id_ruta)
                            {
                                subruta.id_ruta = frmti.rutaint.id_ruta;
                                subruta.id_terminalOrigen = frmti.rutaint.id_terminalOrigen;
                                subruta.id_terminalDestino = frmti.rutaint.id_terminalDestino;
                                subruta.terminalOrigen = frmti.rutaint.terminalOrigen;
                                subruta.terminalDestino = frmti.rutaint.terminalDestino;
                                subruta.tiempo = frmti.rutaint.tiempo;
                                subruta.tiempo_minutos = frmti.rutaint.tiempo_minutos;
                                subruta.id_usuario = frmti.rutaint.id_usuario;
                                subruta.id_tipoTerminal = frmti.rutaint.id_tipoTerminal;
                            }
                        }
                    }
                    this.llenarGridRutasInt();
                }
                else
                {
                    MessageBox.Show("Seleccione un Ruta intermedia", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
