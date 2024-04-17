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
    public partial class frmCancelacionesTransferenciasGrupalV2 : MaterialForm
    {
        private List<MotivoCancelacionesTrasferencias> lstMotivoCancelacionesTrasferencias;
        private int _tipoCancelacionesTransferencias = 0;
        private int _tipoCancelaciones = 0;
        private bool _CancelacionTrasfencia;
        public bool CancelacionTrasfencia
        {
            get { return _CancelacionTrasfencia; }
            set { _CancelacionTrasfencia = value; }
        }
        private MotivoCancelacionesTrasferencias _motivoCancelacionesTransferencias;
        public MotivoCancelacionesTrasferencias motivoCancelacionesTransferencias
        {
            get { return _motivoCancelacionesTransferencias; }
            set { _motivoCancelacionesTransferencias = value; }
        }

        private int _numeroBoletos;
        public int numeroBoletos
        {
            get { return _numeroBoletos; }
            set { _numeroBoletos = value; }
        }
        public frmCancelacionesTransferenciasGrupalV2(int tipoCancelacionesTransferencias, int tipoCancelaciones, int numeroBoletos)
        {
            InitializeComponent();
            loadMaterial(this);
            _tipoCancelacionesTransferencias = tipoCancelacionesTransferencias;
            _tipoCancelaciones = tipoCancelaciones;
            _numeroBoletos = numeroBoletos;
            inicializar();
        }


        #region Metodos Generales
        private bool Validaciones()
        {
            if (Convert.ToInt32(this.cmb_motivoCancelacionTransferencia.SelectedValue) == 0)
            {
                MessageBox.Show("Debes selecionar un motivo de la transferencia", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmb_motivoCancelacionTransferencia.Focus();
                return false;
            }
            if (this.txt_motivoCancelacionTransferencia.Text == string.Empty || this.txt_motivoCancelacionTransferencia.Text == "")
            {
                MessageBox.Show("Debes ingresar un motivo de la transferencia", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_motivoCancelacionTransferencia.Focus();
                return false;
            }
            return true;
        }
        private void inicializar()
        {
            this._CancelacionTrasfencia = false;
            this.txt_FechaCancelacionTransferencia.Text = DateTime.Now.ToShortDateString();
            this.txt_horaCancelacionTransferencia.Text = DateTime.Now.ToString("HH:mm:ss");
            this.txt_usuarioCancelacionTransferencia.Text = Comun.U_Nombre + " " + Comun.U_Apellidop + " " + Comun.U_Apellidom;
            if (_tipoCancelacionesTransferencias == 1)
                if (_tipoCancelaciones == 1)
                    this.txt_penalizacion.Text = string.Format("{0:c}", Comun.monto_cancelacion * numeroBoletos);
                else
                    this.txt_penalizacion.Text = string.Format("{0:c}", 0.0);
            else
                this.txt_penalizacion.Text = string.Format("{0:c}", 0.0);


            CargarCombos();
        }
        private void CargarCombos()
        {
            try
            {
                lstMotivoCancelacionesTrasferencias = new List<MotivoCancelacionesTrasferencias>();
                Cancelacion_Negocio cancelacion_Negocio = new Cancelacion_Negocio();
                cancelacion_Negocio.CargarMotivoCancelacionesTrasferencias(Comun.Conexion, ref lstMotivoCancelacionesTrasferencias, _tipoCancelacionesTransferencias);
                this.cmb_motivoCancelacionTransferencia.DataSource = lstMotivoCancelacionesTrasferencias;
                this.cmb_motivoCancelacionTransferencia.ValueMember = "id_motivoCancelacionTransferencia";
                this.cmb_motivoCancelacionTransferencia.DisplayMember = "descripcion";
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
                if (Validaciones() == true)
                {
                    _CancelacionTrasfencia = true;
                    ObtenerDatos();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                _CancelacionTrasfencia = false;
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private void cmb_motivoCancelacionTransferencia_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(this.cmb_motivoCancelacionTransferencia.SelectedValue) != 4)
                {
                    if (Convert.ToInt32(this.cmb_motivoCancelacionTransferencia.SelectedValue) != 0)
                    {
                        MotivoCancelacionesTrasferencias aux = (MotivoCancelacionesTrasferencias)this.cmb_motivoCancelacionTransferencia.SelectedItem;
                        this.txt_motivoCancelacionTransferencia.Text = aux.descripcion;
                        this.txt_motivoCancelacionTransferencia.Enabled = false;
                    }
                    else
                    {
                        this.txt_motivoCancelacionTransferencia.Text = "";
                        this.txt_motivoCancelacionTransferencia.Enabled = false;
                    }
                }
                else
                {
                    this.txt_motivoCancelacionTransferencia.Text = "";
                    this.txt_motivoCancelacionTransferencia.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                this.txt_motivoCancelacionTransferencia.Text = "";
            }
        }
        private void ObtenerDatos()
        {
            try
            {
                motivoCancelacionesTransferencias = new MotivoCancelacionesTrasferencias();
                motivoCancelacionesTransferencias.id_motivoCancelacionTransferencia = Convert.ToInt32(this.cmb_motivoCancelacionTransferencia.SelectedValue);
                motivoCancelacionesTransferencias.descripcion = this.txt_motivoCancelacionTransferencia.Text;
                motivoCancelacionesTransferencias.id_tipo = _tipoCancelacionesTransferencias;
                motivoCancelacionesTransferencias.ID_U = Comun.Id_U;
            }
            catch (Exception ex)
            {
            }
        }
        #endregion
    }
}
