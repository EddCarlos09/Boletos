using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmPrecio : Form
    {
        private bool _BanVenta = false;
        private float _Precio = 0F;
        private float _Descuento = 0F;
        private int _TipoTarifa = 0;
        private List<Item> lst_precios;
        public bool getBanVenta()
        {
            return _BanVenta;
        }
        public float getDescuento()
        {
            return _Descuento;
        }
        public float getPrecio()
        {
            return _Precio;
        }
        public int getTipoTarifa()
        {
            return _TipoTarifa;
        }

        public V2Cliente DatosCliente { get; set; }

        //public Cliente DatosCliente { get; set; }

        public bool TieneCliente { get; set; }

        public frmPrecio(List<Item> lst__precios, V2Cliente _TieneCliente)
        {
            InitializeComponent();
            DatosCliente = _TieneCliente;
            IniciarForm();
            this.lst_precios = lst__precios;
            this.CmbPrecio.DataSource = lst_precios;
            this.CmbPrecio.ValueMember = "Value";
            this.CmbPrecio.DisplayMember = "Name";
        }

        private void IniciarForm()
        {
            try
            {
                if(DatosCliente._TieneCliente)
                {
                    lblMensaje.Visible = false;
                    lblCliente.Visible = false;
                    lblNombre.Visible = false;
                    txtCodigoTarjeta.Visible = false;
                    txtNombreCliente.Visible = false;
                    BtnBuscar.Visible = false;
                    this.Size = new Size(461, 210);
                }
                else
                {
                    ActiveControl = txtCodigoTarjeta;
                    txtCodigoTarjeta.Visible = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Item> lst = (List<Item>)this.CmbPrecio.DataSource;
                Item Aux = (Item) this.CmbPrecio.SelectedItem;
                this._Precio = Convert.ToSingle(lst[0].Name);
                this._Descuento = Convert.ToSingle(lst[0].Name) - Convert.ToSingle(Aux.Name);
                this._TipoTarifa = Convert.ToInt32(Aux.Value);
                 this._BanVenta = true;
                 this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbPrecio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(this.CmbPrecio.SelectedValue.ToString()) == 1)
                    this.lblPrecio.Text = "Precio Normal:";
                else if (Convert.ToInt32(this.CmbPrecio.SelectedValue.ToString()) == 2)
                    this.lblPrecio.Text = "Precio Infantil:";
                else if (Convert.ToInt32(this.CmbPrecio.SelectedValue.ToString()) == 3)
                    this.lblPrecio.Text = "Precio 3er Edad:";
                else if (Convert.ToInt32(this.CmbPrecio.SelectedValue.ToString()) == 4)
                    this.lblPrecio.Text = "Precio Especial:";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigoTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((Keys)e.KeyChar == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(txtCodigoTarjeta.Text.Trim()))
                    {
                        V2Cliente Aux = new V2Cliente { CodigoTarjeta = txtCodigoTarjeta.Text };
                        Cliente_Negocio cliente_Negocio = new Cliente_Negocio();
                        cliente_Negocio.ObtenerClienteXCodigo(Comun.Conexion, Aux);
                        if (Aux.IDCliente != 0)
                        {
                            DatosCliente = Aux;
                            txtNombreCliente.Text = Aux.Nombre;
                            Aux._TieneCliente = true;
                        }
                        ActiveControl = btn_Aceptar;
                        btn_Aceptar.Focus();
                        e.Handled = true;
                    }
                    else
                    {
                        btnAceptar_Click(btn_Aceptar, new EventArgs());
                    }
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigoTarjeta.Text.Trim()))
                {
                    V2Cliente Aux = new V2Cliente { CodigoTarjeta = txtCodigoTarjeta.Text };
                    Cliente_Negocio cliente_Negocio = new Cliente_Negocio();
                    cliente_Negocio.ObtenerClienteXCodigo(Comun.Conexion, Aux);
                    if (Aux.IDCliente != 0)
                    {
                        DatosCliente = Aux;
                        txtNombreCliente.Text = Aux.Nombre;
                        DatosCliente._TieneCliente = true;
                    }
                    ActiveControl = btn_Aceptar;
                    //btn_Aceptar.Focus();
                }
                else
                {
                    btnAceptar_Click(btn_Aceptar, new EventArgs());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
