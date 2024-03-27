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
    public partial class frmNuevaFechaViaje : Form_Creativa
    {
        private Validaciones Val;
        private Viaje infoViaje;
        private int _opcion;
        private bool _Guardar = true;
        public bool Guardar
        {
            get { return _Guardar; }
            set { _Guardar = value; }
        }
        private bool _Exception = true;
        public bool Exception
        {
            get { return _Exception; }
            set { _Exception = value; }
        }
        public frmNuevaFechaViaje(Viaje viaje, int opcion)
        {
            try
            {
                InitializeComponent();
                _opcion = opcion;
                this.infoViaje = viaje;
                this.Inicializar();
                Guardar = false;
                if (_opcion == 1)
                {
                    this.Text = "Nueva Fechas Viaje";
                    this.label8.Text = "Nueva Fechas Viaje";
                }
                else if (_opcion == 2)
                {
                    this.Text = "Eliminar Fechas Viaje";
                    this.label8.Text = "Eliminar Fechas Viaje";
                }
                this.chkLunes.Checked = true;
                this.chkMartes.Checked = true;
                this.chkMiercoles.Checked = true;
                this.chkJueves.Checked = true;
                this.chkViernes.Checked = true;
                this.chkSabado.Checked = true;
                this.chkDomingo.Checked = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region FechasViaje
        private void GuardarFechasViaje()
        {
            try
            {
                Val = new Validaciones();
                int Verificador = 0;
                Viaje_Negocio viajeNegocio = new Viaje_Negocio();
                Viaje viaje = new Viaje(Comun.Conexion);
                this.ObtenerDatos(viaje);
                if (_opcion == 1)
                {
                    viajeNegocio.registrarNuevaFechasViaje(viaje, ref Verificador);
                    this.VerifcarMensajeAccion(Verificador);
                }
                else if (_opcion == 2)
                {
                    viajeNegocio.eliminarFechasViaje(viaje, ref Verificador);
                    this.VerifcarMensajeAccion2(Verificador);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerDatos(Viaje viaje)
        {
            try
            {
                viaje.id_viaje = infoViaje.id_viaje;
                viaje.fec_PeriodoIni = this.dtpFecInicio.Value;
                viaje.fec_PeriodoFin = this.dtpFecFin.Value;

                viaje.nombre = this.TxtViaje.Text;
                viaje.lunes = this.chkLunes.Checked;
                viaje.martes = this.chkMartes.Checked;
                viaje.miercoles = this.chkMiercoles.Checked;
                viaje.jueves = this.chkJueves.Checked;
                viaje.viernes = this.chkViernes.Checked;
                viaje.sabado = this.chkSabado.Checked;
                viaje.domingo = this.chkDomingo.Checked;
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
                if (infoViaje.id_viaje != null)
                    this.LlenarDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarDatos()
        {
            try
            {
                this.TxtViaje.Text = infoViaje.nombre;
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
                    Val.Mensaje("Las fechas se agregaron correctamente", this);
                    this.Exception = false;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void VerifcarMensajeAccion2(int Verificador)
        {
            try
            {
                if (Verificador == 0)
                {
                    Val.Mensaje("Las fechas se eliminaron correctamente", this);
                    this.Exception = false;
                    this.Close();
                }
                else if (Verificador == 1)
                {
                    Val.Mensaje("No se pudo eliminar las fechas ya que algunas fechas contaban con boletos vendidods", this);
                    this.Exception = false;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarCampos()
        {
            try
            {
                Val = new Validaciones();
                if (this.TxtViaje.Text == string.Empty || this.TxtViaje.Text == "")
                {
                    MessageBox.Show("Debes ingresar un viaje", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtViaje.Focus();
                    return false;
                }
                if(Convert.ToDateTime(this.dtpFecInicio.Value.ToShortDateString()) > Convert.ToDateTime(this.dtpFecFin.Value.ToShortDateString()))
                {
                   MessageBox.Show("Debes ingresar una fecha fin mayor a la fecha inicio", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TxtViaje.Focus();
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

        #region Eventos
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos())
                {
                    this.GuardarFechasViaje();
                    Guardar = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TxtNombreMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void dtpFecInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDateTime(this.dtpFecFin.Value.ToShortDateString()) < Convert.ToDateTime(this.dtpFecInicio.Value.ToShortDateString()))
                    this.dtpFecFin.Value = this.dtpFecInicio.Value;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
