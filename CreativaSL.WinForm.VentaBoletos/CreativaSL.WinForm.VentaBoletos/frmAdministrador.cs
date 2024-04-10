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
using CreativaSL.WinForm.VentaBoletos.Clientes;
using static CreativaSL.WinForm.VentaBoletos.MaterialUI;
using MaterialSkin.Controls;


namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class frmAdministrador : MaterialForm
    {
        int tipoCatalogo = 0;
        DataTable lstAuxBuscadorDisenio = new DataTable();
        DataTable lstAuxDatosDisenio = new DataTable();
        DataTable lstAuxBuscadorCamiones = new DataTable();
        DataTable lstAuxDatosCamiones = new DataTable();
        DataTable lstAuxBuscadorTerminales = new DataTable();
        DataTable lstAuxDatosTerminales = new DataTable();
        DataTable lstAuxBuscadorRutas = new DataTable();
        DataTable lstAuxDatosRutas = new DataTable();
        DataTable lstAuxBuscadorViajes = new DataTable();
        DataTable lstAuxDatosViajes = new DataTable();
        DataTable lstAuxBuscadorTarifas = new DataTable();
        DataTable lstAuxDatosTarifas = new DataTable();
        DataTable lstAuxBuscadorClientes = new DataTable();
        DataTable lstAuxDatosClientes = new DataTable();
        DataTable lstAuxBuscadorUsuarios = new DataTable();
        DataTable lstAuxDatosUsuarios = new DataTable();
        DataTable lstAuxBuscadorChoferes = new DataTable();
        DataTable lstAuxDatosChoferes = new DataTable();
        DataTable lstAuxBuscadorMarca = new DataTable();
        DataTable lstAuxDatosMarca = new DataTable();
        DataTable lstAuxBuscadorSubMarca = new DataTable();
        DataTable lstAuxDatosSubMarca = new DataTable();
        DataTable lstAuxBuscadorTipoCamion = new DataTable();
        DataTable lstAuxDatosTipoCamion = new DataTable();
        DataTable lstAuxBuscadorConfiguracion = new DataTable();
        DataTable lstAuxDatosConfiguracion = new DataTable();
        DataTable lstAuxBuscadorClasificacionClientes = new DataTable();
        DataTable lstAuxDatosClasificacionClientes = new DataTable();

        DataTable lstAuxBuscadorTarjeta = new DataTable();
        DataTable lstAuxDatosTarjeta = new DataTable();

        public frmAdministrador()
        {
            try
            {
                InitializeComponent();
                loadMaterial(this);
                this.CargarGridPropiedades();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #region MetodosGenerales
        private void Eliminar(Object obj)
        {
            try
            {
                if (this.tipoCatalogo == 1)
                {
                    this.EliminarDisenio(obj);
                }
                else if (this.tipoCatalogo == 2)
                {
                    this.EliminarCamion(obj);
                }
                else if (this.tipoCatalogo == 3)
                {
                    this.EliminarTerminal(obj);
                }
                else if (this.tipoCatalogo == 4)
                {
                    this.EliminarRutas(obj);
                }
                else if (this.tipoCatalogo == 5)
                {
                    this.EliminarSalidas(obj);
                }
                else if (this.tipoCatalogo == 6)
                {
                }
                else if (this.tipoCatalogo == 7)
                {
                    this.EliminarCliente(obj);
                }
                else if (this.tipoCatalogo == 8)
                {
                    this.EliminarUsuario(obj);
                }
                else if (this.tipoCatalogo == 9)
                {
                    this.EliminarChofer(obj);   
                }
                else if (this.tipoCatalogo == 10)
                {
                    this.EliminarMarca(obj);
                }
                else if (this.tipoCatalogo == 11)
                {
                    this.EliminarSubMarca(obj);
                }
                else if (this.tipoCatalogo == 12)
                {
                    this.EliminarTipoCamion(obj);
                }
                else if (this.tipoCatalogo == 13)
                {
                    this.EliminarPorcentajeMonedero(obj);
                }
                else if (this.tipoCatalogo == 14)
                {
                    this.EliminarClasificacion(obj);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarGridPropiedades()
        {
            try
            {
                this.btnNuevo.Visible = true;
                this.btnEliminar.Visible = true;
                this.btnModificar.Visible = true;
                this.btnGenerarFolio.Visible = false;
                this.btn_ReporteFolio.Visible = false;
                this.reestablecerFormato();
                this.GridViewGeneral.Visible = true;
                if (this.tipoCatalogo == 0)
                {
                    this.GridViewGeneral.Visible = false;
                    this.btnNuevo.Visible = false;
                    this.btnEliminar.Visible = false;
                    this.btnModificar.Visible = false;
                }
                if (this.tipoCatalogo == 1)
                {
                    this.EstablecerPropiedadesGridDisenio();
                }
                else if (this.tipoCatalogo == 2)
                {
                    this.EstablecerPropiedadesGridCamiones();
                }
                else if (this.tipoCatalogo == 3)
                {
                    this.EstablecerPropiedadesGridTerminales();
                }
                else if (this.tipoCatalogo == 4)
                {
                    //this.btnModificar.Visible = false;
                    this.EstablecerPropiedadesGridRutas();
                }
                else if (this.tipoCatalogo == 5)
                {
                    this.EstablecerPropiedadesGridSalidas();
                    this.pictureBox1.Visible = true;
                    this.pictureBox2.Visible = true;
                    this.pictureBox3.Visible = true;
                    this.label3.Visible = true;
                    this.label4.Visible = true;
                    this.label5.Visible = true;

                    this.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_ORANGE.png");
                    this.label3.Text = "Activo ";
                    this.label4.Text = "Activo sin salida hoy";

                    this.btnNuevaFecha.Visible = true;
                    this.btn_ElimnarFecha.Visible = true;
                    this.btn_Calendario.Visible = true;
                }
                else if (this.tipoCatalogo == 6)
                {
                    this.btnNuevo.Visible = false;
                    this.btnEliminar.Visible = false;
                    this.EstablecerPropiedadesGridTarifas();
                }
                else if (this.tipoCatalogo == 7)
                {
                    this.EstablecerPropiedadesGridClientes();
                }
                else if (this.tipoCatalogo == 8)
                {
                    this.EstablecerPropiedadesGridUsuario();
                }
                else if (this.tipoCatalogo == 9)
                {
                    this.EstablecerPropiedadesGridChofer();
                }
                else if (this.tipoCatalogo == 10)
                {
                    this.EstablecerPropiedadesGridMarcas();
                }
                else if (this.tipoCatalogo == 11)
                {
                    this.EstablecerPropiedadesGridSubMarcas();
                }
                else if (this.tipoCatalogo == 12)
                {
                    this.EstablecerPropiedadesGridTipoCamion();
                }
                else if (this.tipoCatalogo == 13)
                {
                    this.btnModificar.Visible = true;
                    this.btnNuevo.Visible = false;
                    this.btnEliminar.Visible = false;
                    this.EstablecerPropiedadesGridPorcentajeMonedero();
                }
                else if (this.tipoCatalogo == 14)
                {
                    this.EstablecerPropiedadesGridClasificacion();

                }
                else if (this.tipoCatalogo == 15)
                {
                    
                    this.btnNuevo.Visible = false;
                    this.btnEliminar.Visible = false;
                    this.btnModificar.Visible = false;
                    this.btnGenerarFolio.Visible = true;
                    this.btn_ReporteFolio.Visible = true;
                    this.EstablecerPropiedadesGridTarjetas();
                    this.pictureBox1.Visible = true;
                    this.pictureBox2.Visible = true;
                    this.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_RED.png");
                    this.label3.Visible = true;
                    this.label3.Text = "Disponible";
                    this.label4.Visible = true;
                    this.label4.Text = "Asignado a Cliente";
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void CargarGridCatalogos()
        {
            try
            {
                if (this.tipoCatalogo == 1)
                {
                    this.CargarGridDisenio();
                }
                else if (this.tipoCatalogo == 2)
                {
                    this.CargarGridCamiones();
                }
                else if (this.tipoCatalogo == 3)
                {
                    this.CargarGridTerminales();
                }
                else if (this.tipoCatalogo == 4)
                {
                    this.CargarGridRutas();
                }
                else if (this.tipoCatalogo == 5)
                {
                    this.CargarGridSalidas();
                }
                else if (this.tipoCatalogo == 6)
                {
                    this.CargarGridTarifas();
                }
                else if (this.tipoCatalogo == 7)
                {
                    this.CargarGridClientes();
                }
                else if (this.tipoCatalogo == 8)
                {
                    this.CargarGridUsuario();
                }
                else if (this.tipoCatalogo == 9)
                {
                    this.CargarGridChofer();
                }
                else if (this.tipoCatalogo == 10)
                {
                    this.CargarGridMarcas();
                }
                else if (this.tipoCatalogo == 11)
                {
                    this.CargarGridSubMarcas();
                }
                else if (this.tipoCatalogo == 12)
                {
                    this.CargarGridTipoCamion();
                }
                else if (this.tipoCatalogo == 13)
                {
                    this.CargarGridPorcentajeMonedero();
                }
                else if (this.tipoCatalogo == 15)
                {
                    this.CargarGridTarjetas();
                }
                else if (this.tipoCatalogo == 14)
                {
                    this.CargarGridClasificacion();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarCatCatalogosNuevos()
        {
            try
            {
                if (this.tipoCatalogo == 1)
                {
                    frmCatDisenioV2 frmd = new frmCatDisenioV2(new DisenioCamion());
                    frmd.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmd.Dispose();

                }
                else if (this.tipoCatalogo == 2)
                {
                    frmCatCamionesV2 frmc = new frmCatCamionesV2();
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                else if (this.tipoCatalogo == 3)
                {
                    frmCatTerminalesV2 frmt = new frmCatTerminalesV2();
                    frmt.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmt.Dispose();
                }
                else if (this.tipoCatalogo == 4)
                {
                    frmCatRutasV2 frmr = new frmCatRutasV2();
                    frmr.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmr.Dispose();
                }
                else if (this.tipoCatalogo == 5)
                {
                    frmCatSalidasV2 frms = new frmCatSalidasV2();
                    frms.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frms.Dispose();
                }
                else if (this.tipoCatalogo == 6)
                {
                    frmCatTarifasV2cs frms = new frmCatTarifasV2cs();
                    frms.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frms.Dispose();
                }
                else if (this.tipoCatalogo == 7)
                {
                    frm_v2_ClienteAdd frmc = new frm_v2_ClienteAdd();
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                //else if (this.tipoCatalogo == 7)
                //{
                //    frmCatClientes frmc = new frmCatClientes(new Cliente());
                //    frmc.ShowDialog();
                //    this.CargarGridPropiedades();
                //    this.CargarGridCatalogos();
                //    frmc.Dispose();
                //}
                else if (this.tipoCatalogo == 8)
                {
                    frmCatUsuariosV2 frmu = new frmCatUsuariosV2(new Usuario());
                    frmu.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmu.Dispose();
                }
                else if (this.tipoCatalogo == 9)
                {
                    frmCatChoferes frmc = new frmCatChoferes(new Chofer());
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                else if (this.tipoCatalogo == 10)
                {
                    frmCatMarcasV2 frmc = new frmCatMarcasV2(new Marca());
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                else if (this.tipoCatalogo == 11)
                {
                    frmCatSubMarcasV2 frmc = new frmCatSubMarcasV2(new SubMarca());
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                else if (this.tipoCatalogo == 12)
                {
                    frmCatTipoCamionV2 frmc = new frmCatTipoCamionV2(new TipoCamion());
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                else if (this.tipoCatalogo == 13)
                {
                    frmPorentajeMonederoV2 frmPM = new frmPorentajeMonederoV2(new PorcentajeMonedero());
                    frmPM.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmPM.Dispose();
                }
                else if (this.tipoCatalogo == 14)
                {
                    frm_v2_ClasificacionClienteAddV2 frmCC = new frm_v2_ClasificacionClienteAddV2(new ClasificacionCliente());
                    frmCC.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmCC.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarCatCatalogosModificar(Object obj)
        {
            try
            {
                if (this.tipoCatalogo == 1)
                {
                    frmCatDisenioV2 frmd = new frmCatDisenioV2((DisenioCamion)obj);
                    frmd.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmd.Dispose();
                }
                else if (this.tipoCatalogo == 2)
                {
                    frmCatCamionesV2 frmc = new frmCatCamionesV2((Camion) obj);
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                else if (this.tipoCatalogo == 3)
                {
                    frmCatTerminalesV2 frmt = new frmCatTerminalesV2((Terminal)obj);
                    frmt.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmt.Dispose();
                }
                else if (this.tipoCatalogo == 4)
                {
                    frmCatRutasV2 frmr = new frmCatRutasV2((Ruta)obj);
                    frmr.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmr.Dispose();
                }
                else if (this.tipoCatalogo == 5)
                {
                    frmCatSalidasV2 frms = new frmCatSalidasV2((Viaje)obj);
                    frms.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frms.Dispose();
                }
                else if (this.tipoCatalogo == 6)
                {
                    frmCatTarifasV2cs frms = new frmCatTarifasV2cs((Tarifa) obj);
                    frms.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frms.Dispose();
                }
                else if (this.tipoCatalogo == 7)
                {
                    V2Cliente ClienteV = (V2Cliente)obj;
                    frm_v2_ClienteAdd frmc = new frm_v2_ClienteAdd(ClienteV.IDCliente);
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                //else if (this.tipoCatalogo == 7)
                //{
                //    frmCatClientes frmc = new frmCatClientes((Cliente)obj);
                //    frmc.ShowDialog();
                //    this.CargarGridPropiedades();
                //    this.CargarGridCatalogos();
                //    frmc.Dispose();
                //}
                else if (this.tipoCatalogo == 8)
                {
                    frmCatUsuariosV2 frmu = new frmCatUsuariosV2((Usuario)obj);
                    frmu.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmu.Dispose();
                }
                else if (this.tipoCatalogo == 9)
                {
                    frmCatChoferesV2 frmc = new frmCatChoferesV2((Chofer) obj);
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                else if (this.tipoCatalogo == 10)
                {
                    frmCatMarcasV2 frmc = new frmCatMarcasV2((Marca)obj);
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                else if (this.tipoCatalogo == 11)
                {
                    frmCatSubMarcasV2 frmc = new frmCatSubMarcasV2((SubMarca)obj);
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                else if (this.tipoCatalogo == 12)
                {
                    frmCatTipoCamionV2 frmc = new frmCatTipoCamionV2((TipoCamion)obj);
                    frmc.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmc.Dispose();
                }
                else if (this.tipoCatalogo == 13)
                {
                    frmPorentajeMonederoV2 frmPM = new frmPorentajeMonederoV2((PorcentajeMonedero) obj);
                    frmPM.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmPM.Dispose();
                }
                else if (this.tipoCatalogo == 14)
                {
                    frm_v2_ClasificacionClienteAddV2 frmCC = new frm_v2_ClasificacionClienteAddV2((ClasificacionCliente)obj);
                    frmCC.ShowDialog();
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                    frmCC.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Object ObtenerDatos()
        {
            Object Datos = new Object();
            if (this.tipoCatalogo == 1)
            {
                this.ObtenerDatosGridDisenio(ref Datos);
            }
            else if (this.tipoCatalogo == 2)
            {
                this.ObtenerDatosGridCamiones(ref Datos);
            }
            else if (this.tipoCatalogo == 3)
            {
                this.ObtenerDatosGridTerminales(ref Datos);
            }
            else if (this.tipoCatalogo == 4)
            {
                this.ObtenerDatosGridRutas(ref Datos);
            }
            else if (this.tipoCatalogo == 5)
            {
                this.ObtenerDatosGridSalidas(ref Datos);
            }
            else if (this.tipoCatalogo == 6)
            {
                this.ObtenerDatosGridTarifas(ref Datos);
            }
            else if (this.tipoCatalogo == 7)
            {
                this.ObtenerDatosGridCliente(ref Datos);
            }
            else if (this.tipoCatalogo == 8)
            {
                this.ObtenerDatosGridUsuario(ref Datos);
            }
            else if (this.tipoCatalogo == 9)
            {
                this.ObtenerDatosGridChofer(ref Datos);
            }
            else if (this.tipoCatalogo == 10)
            {
                this.ObtenerDatosGridMarca(ref Datos);
            }
            else if (this.tipoCatalogo == 11)
            {
                this.ObtenerDatosGridSubMarca(ref Datos);
            }
            else if (this.tipoCatalogo == 12)
            {
                this.ObtenerDatosGridTipoCamion(ref Datos);
            }
            else if (this.tipoCatalogo == 13)
            {
                this.ObtenerDatosGridPorcentajeMonedero(ref Datos);
            }
            else if (this.tipoCatalogo == 14)
            {
                this.ObtenerDatosGridClasificacion(ref Datos);
            }
            return Datos;
        }
        #endregion
        #region Eventos
        private void btnCatDisenio_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 1;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnCatCamiones_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 2;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_CatTerminal_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 3;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnCatRutas_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 4;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnSalidas_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 5;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnCatTarifas_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 6;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnCatClientes_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 7;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnCatUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 8;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnCatChoferes_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 9;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_Marca_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 10;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_SubMarca_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 11;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_TipoCamion_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 12;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarCatCatalogosNuevos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarCatCatalogosModificar(this.ObtenerDatos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar este Registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Eliminar(this.ObtenerDatos());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_CambioCamionVendido_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 0;
                this.CargarGridPropiedades();
                frmCambioBoletoViajeV2 frmC = new frmCambioBoletoViajeV2();
                frmC.ShowDialog();
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_ViajeXFechas_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 0;
                this.CargarGridPropiedades();
                frmViajesXFechas frmVxF = new frmViajesXFechas();
                frmVxF.ShowDialog();
                frmVxF.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_PorcentajeMonedero_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 13;
                this.CargarGridPropiedades();
                this.CargarGridPorcentajeMonedero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btnNuevaFecha_Click(object sender, EventArgs e)
        {
            try
            {
                frmNuevaFechaViaje nuevaFecha = new frmNuevaFechaViaje((Viaje)this.ObtenerDatos(), 1);
                nuevaFecha.ShowDialog();
                if (nuevaFecha.Guardar == true)
                {
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
                nuevaFecha.Dispose();
            }
            catch (Exception ex)
            {
            }
        }
        private void btn_ElimnarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                frmNuevaFechaViaje eliminarFecha = new frmNuevaFechaViaje((Viaje)this.ObtenerDatos(), 2);
                eliminarFecha.ShowDialog();
                if (eliminarFecha.Guardar == true)
                {
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
                eliminarFecha.Dispose();
            }
            catch (Exception ex)
            {
            }
        }
        private void btn_Calendario_Click(object sender, EventArgs e)
        {
            try
            {
                frmFechasViajesDetalle fechaViajesDetalles = new frmFechasViajesDetalle((Viaje)this.ObtenerDatos());
                fechaViajesDetalles.ShowDialog();
                fechaViajesDetalles.Dispose();
            }
            catch (Exception ex)
            {
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
       {
            try
            {
                DataRow[] rows;
                switch (tipoCatalogo)
                {
                    case 1: //DISEÑO 
                        lstAuxBuscadorDisenio = null;
                        rows = this.lstAuxDatosDisenio.Select("nombre like '%" + this.txtBuscador.Text + "%' OR descripcion like '%" + this.txtBuscador.Text + "%' OR numasientos =" + this.txtBuscador.Text + "");
                        if (rows.Count() > 0)
                            lstAuxBuscadorDisenio = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorDisenio;
                        break;
                    case 2: //CAMIONES 
                        lstAuxBuscadorCamiones = null;
                        rows = this.lstAuxDatosCamiones.Select("descripcion like '%" + this.txtBuscador.Text + "%' OR marca like '%" + this.txtBuscador.Text + "%' OR submarca like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorCamiones = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorCamiones;
                        break;
                    case 3: //TERMINALES 
                        lstAuxBuscadorTerminales = null;
                        rows = this.lstAuxDatosTerminales.Select("nombre like '%" + this.txtBuscador.Text + "%' OR direccion like '%" + this.txtBuscador.Text + "%' OR telefonos like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorTerminales = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorTerminales;
                        break;
                    case 4: //RUTAS
                        lstAuxBuscadorRutas = null;
                        rows = this.lstAuxDatosRutas.Select("terminalOrigen like '%" + this.txtBuscador.Text + "%' OR terminalDestino like '%" + this.txtBuscador.Text + "%' OR tiempo like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorRutas = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorRutas;
                        break;
                    case 5: //VIAJES 
                        lstAuxBuscadorViajes = null;
                        rows = this.lstAuxDatosViajes.Select("nombre like '%" + this.txtBuscador.Text + "%' OR descripcion like '%" + this.txtBuscador.Text + "%' OR terminalOrigen like '%" + this.txtBuscador.Text + "%' OR terminalDestino like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorViajes = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorViajes;
                        ImagenGrid();
                        break;
                    case 6: //TARIFAS DE AQUI FALTA   
                        lstAuxBuscadorTarifas = null;
                        rows = this.lstAuxDatosTarifas.Select("nombre like '%" + this.txtBuscador.Text + "%' OR descripcion like '%" + this.txtBuscador.Text + "%' OR terminalOrigen like '%" + this.txtBuscador.Text + "%' OR terminalDestino like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorTarifas = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorTarifas;
                        break;
                    case 7: //CLIENTES
                        lstAuxBuscadorClientes = null;
                        rows = this.lstAuxDatosClientes.Select("Codigo like '%" + this.txtBuscador.Text + "%' OR Nombre like '%" + this.txtBuscador.Text + "%'");
                        //rows = this.lstAuxDatosClientes.Select("IDCodigoEab like '%" + this.txtBuscador.Text + "%' OR NombreCompleto like '%" + this.txtBuscador.Text + "%' OR Genero like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorClientes = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorClientes;
                        break;
                    case 8: //USUARIOS
                        lstAuxBuscadorUsuarios = null;
                        rows = this.lstAuxDatosUsuarios.Select("NombreCompleto like '%" + this.txtBuscador.Text + "%' OR U_DirCalle like '%" + this.txtBuscador.Text + "%' OR U_DirColonia like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorUsuarios = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorUsuarios;
                        break;
                    case 9: //CHOFERES
                        lstAuxBuscadorChoferes = null;
                        rows = this.lstAuxDatosChoferes.Select("Nombre like '%" + this.txtBuscador.Text + "%' OR Curp like '%" + this.txtBuscador.Text + "%' OR Observaciones like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorChoferes = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorChoferes;
                        break;
                    case 10: //MARCA
                        lstAuxBuscadorMarca = null;
                        rows = this.lstAuxDatosMarca.Select("marca like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorMarca = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorMarca;
                        break;
                    case 11: //SUBMARCA 
                        lstAuxBuscadorSubMarca = null;
                        rows = this.lstAuxDatosSubMarca.Select("submarca like '%" + this.txtBuscador.Text + "%' OR marca like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorSubMarca = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorSubMarca;
                        break;
                    case 12: //TIPO CAMION
                        lstAuxBuscadorTipoCamion = null;
                        rows = this.lstAuxDatosTipoCamion.Select("tipoCamion like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorTipoCamion = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorTipoCamion;
                        break;
                    case 13: //CAMBIO CAMION
                        break;
                    case 14: //VIAJES POR FECHAS (Se usó para Clasificacion cliente)
                        lstAuxBuscadorClasificacionClientes = null;
                        rows = this.lstAuxDatosClasificacionClientes.Select("Descripcion like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorClasificacionClientes = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorClasificacionClientes;
                        break;
                    //case 15: //CONFIGURACION
                    //    break;
                    //Buscar Tarjetas
                    case 15:
                        lstAuxBuscadorTarjeta = null;
                        rows = this.lstAuxDatosTarjeta.Select("folio like '%" + this.txtBuscador.Text + "%'");
                        if (rows.Count() > 0)
                            lstAuxBuscadorTarjeta = rows.CopyToDataTable();
                        this.GridViewGeneral.DataSource = lstAuxBuscadorTarjeta;
                        ImagenGridTarjeta();
                        break;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtBuscador.Text = "";
                switch (tipoCatalogo)
                {
                    case 1: //DISEÑO
                        this.GridViewGeneral.DataSource = lstAuxDatosDisenio;
                        break;
                    case 2: //CAMIONES
                        this.GridViewGeneral.DataSource = lstAuxDatosCamiones;
                        break;
                    case 3: //TERMINALES
                        this.GridViewGeneral.DataSource = lstAuxDatosTerminales;
                        break;
                    case 4: //RUTAS
                        this.GridViewGeneral.DataSource = lstAuxDatosRutas;
                        break;
                    case 5: //VIAJES
                        this.GridViewGeneral.DataSource = lstAuxDatosViajes;
                        ImagenGrid();
                        break;
                    case 6: //TARIFAS
                        this.GridViewGeneral.DataSource = lstAuxDatosTarifas;
                        break;
                    case 7: //CLIENTES
                        this.GridViewGeneral.DataSource = lstAuxDatosClientes;
                        break;
                    case 8: //USUARIOS
                        this.GridViewGeneral.DataSource = lstAuxDatosUsuarios;
                        break;
                    case 9: //CHOFERES
                        this.GridViewGeneral.DataSource = lstAuxDatosChoferes;
                        break;
                    case 10: //MARCA
                        this.GridViewGeneral.DataSource = lstAuxDatosMarca;
                        break;
                    case 11: //SUBMARCA
                        this.GridViewGeneral.DataSource = lstAuxDatosSubMarca;
                        break;
                    case 12: //TIPO CAMION
                        this.GridViewGeneral.DataSource = lstAuxDatosTipoCamion;
                        break;
                    case 13: //CAMBIO CAMION
                        break;
                    case 14: //VIAJES POR FECHAS(Se usó para Clasificacion cliente)
                        this.GridViewGeneral.DataSource = lstAuxDatosClasificacionClientes;
                        break;
                    //case 15: //CONFIGURACION
                    //    break;
                    case 15: // Tarjetas y folios
                        this.GridViewGeneral.DataSource = lstAuxDatosTarjeta;
                        ImagenGridTarjeta();
                        break;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void txtBuscador_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                btnBuscar_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }
        #endregion
        #region Grid
        #region GridCatDisenio
        private void CargarGridDisenio()
        {
            try
            {
                DisenioCamion_Negocio DisenioCamion_Negocio = new DisenioCamion_Negocio();
                DisenioCamion DisenioCamion = new DisenioCamion();
                DisenioCamion_Negocio.LlenarGridDisenio(Comun.Conexion, ref DisenioCamion);
                lstAuxDatosDisenio = DisenioCamion.DisenioCamiones;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosDisenio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridDisenio()
        {
            try
            {
                var Headertexts = new List<string> { "Nombre", "Descripción", "Núm Asientos", "Núm TVS", "Núm WC", "Núm Bares", "Núm Pisos", "Núm Puerta" };
                var Names = new List<string> { "nombre", "descripcion", "numasientos", "numtvs", "numwcsnt", "numbares", "numpisos", "numpuerta", "id_disenioCamion" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);

                this.GridViewGeneral.Columns[0].Visible = true;
                this.GridViewGeneral.Columns[1].Visible = true;
                this.GridViewGeneral.Columns[2].Visible = true;
                this.GridViewGeneral.Columns[3].Visible = true;
                this.GridViewGeneral.Columns[4].Visible = true;
                this.GridViewGeneral.Columns[5].Visible = true;
                this.GridViewGeneral.Columns[6].Visible = true;

                this.GridViewGeneral.Columns[0].Width = 300;
                this.GridViewGeneral.Columns[1].Width = 300;
                this.GridViewGeneral.Columns[2].Width = 80;
                this.GridViewGeneral.Columns[3].Width = 80;
                this.GridViewGeneral.Columns[4].Width = 80;
                this.GridViewGeneral.Columns[5].Width = 80;
                this.GridViewGeneral.Columns[6].Width = 80;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridDisenio(ref Object Datos)
        {
            try
            {
                DisenioCamion Disenio = new DisenioCamion();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    Disenio.id_disenioCamion = row.Cells["id_disenioCamion"].Value.ToString();
                    Disenio.Nombre = row.Cells["nombre"].Value.ToString();
                    Disenio.Descripcion = row.Cells["descripcion"].Value.ToString();
                    Disenio.NumPisos = Convert.ToInt32(row.Cells["numpisos"].Value.ToString());
                    Disenio.NumTvs = Convert.ToInt32(row.Cells["numtvs"].Value.ToString());
                    Disenio.NumBaños = Convert.ToInt32(row.Cells["numwcsnt"].Value.ToString());
                    Disenio.NumBares = Convert.ToInt32(row.Cells["numbares"].Value.ToString());
                    Disenio.NumAsientos = Convert.ToInt32(row.Cells["numasientos"].Value.ToString());
                    Disenio.NumPuertas = Convert.ToInt32(row.Cells["numpuerta"].Value.ToString());
                }
                DataTable DatosAuxObject = new DataTable();
                DisenioCamion_Negocio DisenioCamion_Negocio = new DisenioCamion_Negocio();
                DisenioCamion_Negocio.ObtenerDatosCamion(Comun.Conexion, ref DatosAuxObject, Disenio.id_disenioCamion);
                Disenio.TablaObjetos = DatosAuxObject;
                Datos = Disenio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarDisenio(Object Datos)
        {
            try
            {
                DisenioCamion Disenio = (DisenioCamion) Datos;
                int Verificador = 0;
                DisenioCamion_Negocio DisenioCamion_Negocio = new DisenioCamion_Negocio();
                DisenioCamion_Negocio.EliminarDisenio(Disenio, Comun.Conexion, ref Verificador);
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridCatCamiones
        private void CargarGridCamiones()
        {
            try
            {
                Camion_Negocio cn = new Camion_Negocio();
                Camion camiones = new Camion(Comun.Conexion);
                camiones = cn.obtenerCamiones(camiones);
                lstAuxDatosCamiones = camiones.datatable_camiones;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosCamiones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridCamiones()
        {
            try
            {
                var Headertexts = new List<string> { "id_camion", "Descripción", "Marca", "SubMarca", "Tipo de Camión", "Número de Camión", "Características", "Diseño" };
                var Names = new List<string> { "id_camion", "descripcion", "marca", "submarca", "tipoCamion", "numcamion", "caracteristicas", "nombre", "id_marca", "id_submarca", "id_tipocamion", "id_disenioCamion" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);
                this.GridViewGeneral.Columns[1].Width = 175;
                this.GridViewGeneral.Columns[2].Width = 140;
                this.GridViewGeneral.Columns[3].Width = 140;
                this.GridViewGeneral.Columns[4].Width = 150;
                this.GridViewGeneral.Columns[5].Width = 130;
                this.GridViewGeneral.Columns[6].Width = 270;
                this.GridViewGeneral.Columns[7].Width = 100;

                this.GridViewGeneral.Columns[1].Visible = true;
                this.GridViewGeneral.Columns[2].Visible = true;
                this.GridViewGeneral.Columns[3].Visible = true;
                this.GridViewGeneral.Columns[4].Visible = true;
                this.GridViewGeneral.Columns[5].Visible = true;
                this.GridViewGeneral.Columns[6].Visible = true;
                this.GridViewGeneral.Columns[7].Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridCamiones(ref Object Datos)
        {
            try
            {
                Camion camion = new Camion(Comun.Conexion);
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    camion.id_camion = row.Cells["id_camion"].Value.ToString();
                    camion.descripcion = row.Cells["descripcion"].Value.ToString();
                    camion.caracteristicas = row.Cells["caracteristicas"].Value.ToString();
                    camion.num_camion = row.Cells["numcamion"].Value.ToString();
                    camion.id_marca = Convert.ToInt32(row.Cells["id_marca"].Value);
                    camion.id_submarca = Convert.ToInt32(row.Cells["id_submarca"].Value);
                    camion.id_Tipocamion = Convert.ToInt32(row.Cells["id_tipocamion"].Value);
                    camion.id_diseniocamion = row.Cells["id_disenioCamion"].Value.ToString();
                }
                Datos = camion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarCamion(Object Datos)
        {
            try
            {
                Camion camion = (Camion)Datos;
                int Verificador = 0;
                Camion_Negocio cn = new Camion_Negocio();
                cn.EliminarCamion(ref Verificador, camion);
                if (Verificador > 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridCatTerminal
        private void CargarGridTerminales()
        {
            try
            {
                Terminal_Negocio tn = new Terminal_Negocio();
                Terminal terminales = new Terminal(Comun.Conexion);
                terminales = tn.obtenerTerminales(terminales);
                lstAuxDatosTerminales = terminales.datatable_terminales;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosTerminales;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridTerminales()
        {
            try
            {
                var Headertexts = new List<string> { "id_terminal", "Nombre Sucursal", "País", "Estado", "Municipio", "Dirección", "Teléfono" };
                var Names = new List<string> { "id_terminal", "nombre", "pais", "estado", "municipio", "direccion", "telefonos", "id_pais", "id_estado", "id_municipio" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);
                this.GridViewGeneral.Columns[1].Width = 190;
                this.GridViewGeneral.Columns[2].Width = 140;
                this.GridViewGeneral.Columns[3].Width = 140;
                this.GridViewGeneral.Columns[4].Width = 150;
                this.GridViewGeneral.Columns[5].Width = 290;
                this.GridViewGeneral.Columns[6].Width = 190;

                this.GridViewGeneral.Columns[1].Visible = true;
                this.GridViewGeneral.Columns[2].Visible = true;
                this.GridViewGeneral.Columns[3].Visible = true;
                this.GridViewGeneral.Columns[4].Visible = true;
                this.GridViewGeneral.Columns[5].Visible = true;
                this.GridViewGeneral.Columns[6].Visible = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridTerminales(ref Object Datos)
        {
            try
            {
                Terminal terminal = new Terminal(Comun.Conexion);
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    terminal.id_terminal = row.Cells["id_terminal"].Value.ToString();
                    terminal.nombre = row.Cells["nombre"].Value.ToString();
                    terminal.direccion = row.Cells["direccion"].Value.ToString();
                    terminal.telefonos = row.Cells["telefonos"].Value.ToString();
                    terminal.id_pais = Convert.ToInt32(row.Cells["id_pais"].Value);
                    terminal.id_estado = Convert.ToInt32(row.Cells["id_estado"].Value);
                    terminal.id_municipio = Convert.ToInt32(row.Cells["id_municipio"].Value);
                }
                Datos = terminal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarTerminal(Object Datos)
        {
            try
            {
                Terminal terminal = (Terminal)Datos;
                int Verificador = 0;
                Terminal_Negocio tn = new Terminal_Negocio();
                tn.EliminarTerminal(ref Verificador, terminal);
                if (Verificador > 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridCatRutas
        private void CargarGridRutas()
        {
            try
            {
                Ruta_Negocio rn = new Ruta_Negocio();
                Ruta rutas = new Ruta(Comun.Conexion);
                rutas = rn.obtenerRutasPrincipales(rutas);
                lstAuxDatosRutas = rutas.dataTable_terminalesintermedias;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosRutas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EstablecerPropiedadesGridRutas()
        {
            try
            {
                var Headertexts = new List<string> { "id_terminalXruta", "Terminal Origen", "Terminal Destino", "Tiempo de recorrido", "id_terminalSalida", "id_terminalDestino", "id_tipoTerminal", "tiempo_int", "id_ruta", "indice" };
                var Names = new List<string> { "id_terminalXruta", "terminalOrigen", "terminalDestino", "tiempo", "id_terminalSalida", "id_terminalDestino", "id_tipoTerminal", "tiempoMinutos", "id_ruta", "indice" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);


                this.GridViewGeneral.Columns[1].Width = 300;
                this.GridViewGeneral.Columns[2].Width = 300;
                this.GridViewGeneral.Columns[3].Width = 200;

                this.GridViewGeneral.Columns[1].Visible = true;
                this.GridViewGeneral.Columns[2].Visible = true;
                this.GridViewGeneral.Columns[3].Visible = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerDatosGridRutas(ref Object Datos)
        {
            try
            {
                Ruta ruta = new Ruta(Comun.Conexion);
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    ruta.id_ruta = row.Cells["id_terminalXruta"].Value.ToString();
                    ruta.id_rutaPadre = row.Cells["id_ruta"].Value.ToString();
                    ruta.id_terminalOrigen = row.Cells["id_terminalSalida"].Value.ToString();
                    ruta.id_terminalDestino = row.Cells["id_terminalDestino"].Value.ToString();
                    ruta.id_tipoTerminal = Convert.ToInt32(row.Cells["id_tipoTerminal"].Value.ToString());
                    ruta.tiempo_minutos = Convert.ToInt32(row.Cells["tiempoMinutos"].Value);
                    ruta.indice = Convert.ToInt32(row.Cells["indice"].Value);
                }
                Datos = ruta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EliminarRutas(Object Datos)
        {
            try
            {
                Ruta ruta = (Ruta)Datos;
                int Verificador = 0;
                Ruta_Negocio rn = new Ruta_Negocio();
                rn.EliminarRuta(ref Verificador, ruta);
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar esta ruta ya que se encuentra asignadas a almenos un viaje", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        #region GridCatSalidas
        private void CargarGridSalidas()
        {
            try
            {
                Viaje_Negocio vn = new Viaje_Negocio();
                Viaje viajes = new Viaje(Comun.Conexion);
                viajes = vn.obtenerViajes(viajes);
                lstAuxDatosViajes = viajes.datatable_viajes;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosViajes;
                ImagenGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EstablecerPropiedadesGridSalidas()
        {
            try
            {
                var Headertexts = new List<string> { "id_identificador", "id_ruta", "id_camion", "id_tipoViaje", "fec_PeriodoIni", "fec_PeriodoFin", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo", "Nombre Viaje", "Camión", "T. Origen", "T. Destino", "Periodo", "Hora" };
                var Names = new List<string> { "id_identificador", "id_ruta", "id_camion", "id_tipoViaje", "fec_PeriodoIni", "fec_PeriodoFin", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo", "nombre", "descripcion", "terminalOrigen", "terminalDestino", "Periodo", "horario", "status_viaje" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);

                this.GridViewGeneral.Columns[13].Width = 250;
                this.GridViewGeneral.Columns[14].Width = 250;
                this.GridViewGeneral.Columns[15].Width = 180;
                this.GridViewGeneral.Columns[16].Width = 180;
                this.GridViewGeneral.Columns[17].Width = 180;
                this.GridViewGeneral.Columns[18].Width = 180;

                this.GridViewGeneral.Columns[13].Visible = true;
                this.GridViewGeneral.Columns[14].Visible = true;
                this.GridViewGeneral.Columns[15].Visible = true;
                this.GridViewGeneral.Columns[16].Visible = true;
                this.GridViewGeneral.Columns[17].Visible = true;
                this.GridViewGeneral.Columns[18].Visible = true;
                this.GridViewGeneral.Columns[25].Visible = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ObtenerDatosGridSalidas(ref Object Datos)
        {
            try
            {
                Viaje viaje = new Viaje(Comun.Conexion);
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    viaje.id_viaje = row.Cells["id_identificador"].Value.ToString();
                    viaje.id_ruta = row.Cells["id_ruta"].Value.ToString();
                    viaje.id_camion = row.Cells["id_camion"].Value.ToString();
                    viaje.id_tipoViaje = Convert.ToInt32(row.Cells["id_tipoViaje"].Value.ToString());
                    viaje.fec_PeriodoIni = Convert.ToDateTime(row.Cells["fec_PeriodoIni"].Value);
                    viaje.fec_PeriodoFin = Convert.ToDateTime(row.Cells["fec_PeriodoFin"].Value);
                    viaje.lunes = Convert.ToBoolean(row.Cells["Lunes"].Value);
                    viaje.martes = Convert.ToBoolean(row.Cells["Martes"].Value);
                    viaje.miercoles = Convert.ToBoolean(row.Cells["Miercoles"].Value);
                    viaje.jueves = Convert.ToBoolean(row.Cells["Jueves"].Value);
                    viaje.viernes = Convert.ToBoolean(row.Cells["Viernes"].Value);
                    viaje.sabado = Convert.ToBoolean(row.Cells["Sabado"].Value);
                    viaje.domingo = Convert.ToBoolean(row.Cells["Domingo"].Value);
                    viaje.nombre = row.Cells["nombre"].Value.ToString();
                    viaje.horario = row.Cells["horario"].Value.ToString();
                }
                Datos = viaje;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EliminarSalidas(Object Datos)
        {
            try
            {
                Viaje viaje = (Viaje)Datos;
                int Verificador = 0;
                Viaje_Negocio vn = new Viaje_Negocio();
                vn.EliminarViaje(ref Verificador, viaje);
                if (Verificador > 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        #region GridCatTarifas
        private void CargarGridTarifas()
        {
            try
            {
                Tarifa_Negocio tn = new Tarifa_Negocio();
                Tarifa tarifas = new Tarifa(Comun.Conexion);
                tarifas = tn.obtenerDataGridTarifas(tarifas);
                lstAuxDatosTarifas = tarifas.datatable_tarifas;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosTarifas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridTarifas()
        {
            try
            {
                var Headertexts = new List<string> { "id_tarifa", "id_identificador", "id_terminalXruta", "Nombre Viaje", "Camión", "Terminal Origen", "Terminal Destino", "Precio 1 Piso", "Precio Especial", "Precio Infantil", "Precio Tercera Edad", "Precio 2 Piso" };
                var Names = new List<string> { "id_tarifa", "id_identificador", "id_terminalXruta", "nombre", "descripcion", "terminalOrigen", "terminalDestino", "precioNormal1", "precioEspecial1", "precioInfantil1", "precioTerceraEdad1", "precioNormal2", "precioEspecial2", "precioInfantil2", "precioTerceraEdad2" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);

                this.GridViewGeneral.Columns[3].Width = 200;
                this.GridViewGeneral.Columns[4].Width = 150;
                this.GridViewGeneral.Columns[5].Width = 150;
                this.GridViewGeneral.Columns[6].Width = 150;
                this.GridViewGeneral.Columns[7].Width = 120;
                this.GridViewGeneral.Columns[8].Width = 120;
                this.GridViewGeneral.Columns[9].Width = 120;
                this.GridViewGeneral.Columns[10].Width = 120;
                this.GridViewGeneral.Columns[11].Width = 120;
                this.GridViewGeneral.Columns[12].Width = 120;
                this.GridViewGeneral.Columns[13].Width = 120;
                this.GridViewGeneral.Columns[14].Width = 120;

                this.GridViewGeneral.Columns[3].Visible = true;
                this.GridViewGeneral.Columns[4].Visible = true;
                this.GridViewGeneral.Columns[5].Visible = true;
                this.GridViewGeneral.Columns[6].Visible = true;
                this.GridViewGeneral.Columns[7].Visible = true;

                this.GridViewGeneral.Columns[7].DefaultCellStyle.Format = "c";
                this.GridViewGeneral.Columns[8].DefaultCellStyle.Format = "c";
                this.GridViewGeneral.Columns[9].DefaultCellStyle.Format = "c";
                this.GridViewGeneral.Columns[10].DefaultCellStyle.Format = "c";
                this.GridViewGeneral.Columns[11].DefaultCellStyle.Format = "c";
                this.GridViewGeneral.Columns[12].DefaultCellStyle.Format = "c";
                this.GridViewGeneral.Columns[13].DefaultCellStyle.Format = "c";
                this.GridViewGeneral.Columns[14].DefaultCellStyle.Format = "c";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridTarifas(ref Object Datos)
        {
            try
            {
                Tarifa tarifa = new Tarifa(Comun.Conexion);
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    tarifa.id_tarifa = row.Cells["id_tarifa"].Value.ToString();
                    tarifa.id_viaje = row.Cells["id_identificador"].Value.ToString();
                }
                Datos = tarifa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridCatClientes
        private void CargarGridClientes()
        {
            try
            {
                Cliente_Negocio Cliente_Negocio = new Cliente_Negocio();
                Cliente Clientes = new Cliente();
                Cliente_Negocio.LlenarGridCliente(Comun.Conexion, ref Clientes);
                lstAuxDatosClientes = Clientes.Clientes;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridClientes()
        {
            try
            {
                var Headertexts = new List<string> { "Codigo Cliente", "Nombre", "Fecha Nacimiento", "Correo Electronico", "Pais", "Estado", "Municipio", "Monedero", "Saldo Retenido", "Saldo Disponible" };
                var Names = new List<string> { "Codigo", "Nombre", "FechaNacimiento", "CorreoElectronico", "Pais", "Estado", "Municipio", "Monedero", "saldoRetenido", "saldoDisponible", "IDCliente", "IDPais", "IDEstado", "IDMunicipio" };

                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);
                this.GridViewGeneral.Columns[0].Visible = true;
                this.GridViewGeneral.Columns[1].Visible = true;
                this.GridViewGeneral.Columns[2].Visible = true;
                this.GridViewGeneral.Columns[3].Visible = true;
                this.GridViewGeneral.Columns[4].Visible = true;
                this.GridViewGeneral.Columns[5].Visible = true;
                this.GridViewGeneral.Columns[6].Visible = true;
                this.GridViewGeneral.Columns[7].Visible = true;
                this.GridViewGeneral.Columns[8].Visible = true;
                this.GridViewGeneral.Columns[9].Visible = true;
                this.GridViewGeneral.Columns[0].Width = 150;
                this.GridViewGeneral.Columns[1].Width = 250;
                this.GridViewGeneral.Columns[2].Width = 150;
                this.GridViewGeneral.Columns[3].Width = 100;
                this.GridViewGeneral.Columns[4].Width = 200;
                this.GridViewGeneral.Columns[5].Width = 120;
                this.GridViewGeneral.Columns[6].Width = 120;
                this.GridViewGeneral.Columns[7].Width = 120;
                this.GridViewGeneral.Columns[8].Width = 100;
                this.GridViewGeneral.Columns[9].Width = 100;
                //var Headertexts = new List<string> { "Código Cliente", "Nombre", "Fecha Nacimiento", "Género", "Correo Electrónico", "Ocupación", "Estado Civil", "Curp", "País", "Estado", "Municipio", "Colonia" ,"Monedero"};
                //var Names = new List<string> { "IDCodigoEab", "NombreCompleto", "FechaNacimiento", "Genero", "CorreoElectronico", "Ocupacion", "EstadoCivil", "Curp", "Pais", "Estado", "Municipio", "Colonia","Monedero","IDCliente", "Nombre", "ApePat", "ApeMat", "IDGenero", "IDOcupacion", "IDPais", "IDEstado", "IDMunicipio", "IDEstadoCivil" };
                //this.RecorrerFor(Headertexts, 1);
                //this.RecorrerFor(Names, 2);
                //this.RecorrerFor(Names, 3);
                //this.GridViewGeneral.Columns[0].Visible = true;
                //this.GridViewGeneral.Columns[1].Visible = true;
                //this.GridViewGeneral.Columns[2].Visible = true;
                //this.GridViewGeneral.Columns[3].Visible = true;
                //this.GridViewGeneral.Columns[4].Visible = true;
                //this.GridViewGeneral.Columns[5].Visible = true;
                //this.GridViewGeneral.Columns[6].Visible = true;
                //this.GridViewGeneral.Columns[7].Visible = true;
                //this.GridViewGeneral.Columns[8].Visible = true;
                //this.GridViewGeneral.Columns[9].Visible = true;
                //this.GridViewGeneral.Columns[10].Visible = true;
                //this.GridViewGeneral.Columns[11].Visible = true;
                //this.GridViewGeneral.Columns[12].Visible = true;
                //this.GridViewGeneral.Columns[0].Width = 150;
                //this.GridViewGeneral.Columns[1].Width = 250;
                //this.GridViewGeneral.Columns[2].Width = 150;
                //this.GridViewGeneral.Columns[3].Width = 100;
                //this.GridViewGeneral.Columns[4].Width = 200;
                //this.GridViewGeneral.Columns[5].Width = 120;
                //this.GridViewGeneral.Columns[6].Width = 120;
                //this.GridViewGeneral.Columns[7].Width = 120;
                //this.GridViewGeneral.Columns[8].Width = 120;
                //this.GridViewGeneral.Columns[9].Width = 120;
                //this.GridViewGeneral.Columns[10].Width = 120;
                //this.GridViewGeneral.Columns[11].Width = 120;
                //this.GridViewGeneral.Columns[12].Width = 120;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridCliente(ref Object Datos)
        {
            try
            {
                V2Cliente Cliente = new V2Cliente();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    Cliente.IDCliente = Convert.ToInt32(row.Cells["IDCliente"].Value.ToString());
                    Cliente.CodigoTarjeta = row.Cells["Codigo"].Value.ToString();
                    Cliente.Nombre = row.Cells["Nombre"].Value.ToString();
                }
                Datos = Cliente;
                //Cliente Cliente = new Cliente();
                //foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                //{
                //    Cliente.Nombre = row.Cells["Nombre"].Value.ToString();
                //    Cliente.ApePat = row.Cells["ApePat"].Value.ToString();
                //    Cliente.ApeMat = row.Cells["ApeMat"].Value.ToString();
                //    Cliente.FechaNacimiento = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value.ToString());
                //    Cliente.IDGenero = Convert.ToInt32(row.Cells["IDGenero"].Value.ToString());
                //    Cliente.CorreoElectronico = row.Cells["CorreoElectronico"].Value.ToString();
                //    Cliente.IDOcupacion = Convert.ToInt32(row.Cells["IDOcupacion"].Value.ToString());
                //    Cliente.IDEstadoCivil = Convert.ToInt32(row.Cells["IDEstadoCivil"].Value.ToString());
                //    Cliente.Curp = row.Cells["Curp"].Value.ToString();
                //    Cliente.IDPais = Convert.ToInt32(row.Cells["IDPais"].Value.ToString());
                //    Cliente.IDEstado = Convert.ToInt32(row.Cells["IDEstado"].Value.ToString());
                //    Cliente.IDMunicipio = Convert.ToInt32(row.Cells["IDMunicipio"].Value.ToString());
                //    Cliente.Colonia = row.Cells["Colonia"].Value.ToString();
                //    Cliente.IDCodigoEab = row.Cells["IDCodigoEab"].Value.ToString();
                //    Cliente.IDCliente = row.Cells["IDCliente"].Value.ToString();  
                //}
                //Datos = Cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarCliente(Object Datos)
        {
            try
            {
                V2Cliente Cliente = (V2Cliente)Datos;
                if (Cliente.IDCliente != 0)
                {
                    int verificador = 0;
                    V2Cliente_Negocio negocio = new V2Cliente_Negocio(Comun.Conexion, false, Cliente.IDCliente, Comun.Id_U);
                    negocio.Eliminar(ref verificador);
                    this.CargarGridClientes();
                }
                else
                {
                    MessageBox.Show("Seleccione un Cliente.", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Cliente Cliente = (Cliente)Datos;
                //int Verificador = 0;
                //Cliente_Negocio Cliente_Negocio = new Cliente_Negocio();
                //Cliente_Negocio.EliminarCliente(Comun.Conexion, Cliente, Verificador);
                //if (Verificador == 0)
                //{
                //    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    this.CargarGridClientes();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridCatUsuarios
        private void CargarGridUsuario()
        {
            try
            {
                Usuario_Negocio Usuario_Negocio = new Usuario_Negocio();
                Usuario Usuarios = new Usuario();
                Usuario_Negocio.LlenarGridUsuario(Comun.Conexion, ref Usuarios);
                lstAuxDatosUsuarios = Usuarios.Usuarios;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridUsuario()
        {
            try
            {
                var Headertexts = new List<string> { "Nombre", "Calle", "Colonia", "Número", "Fecha de nacimiento","Usuario", "Tipo usuario","Turno","Sucursal"};
                var Names = new List<string> { "NombreCompleto", "U_DirCalle", "U_DirColonia", "U_DirNumero", "U_FechaNac_Short", "Cu_User", "Tu_Descripcion", "Turno", "Nombre_Sucursal", "Id_Turno", "U_Nombre", "U_Apellidop", "U_Apellidom", "Cu_Pass", "Id_Tu", "Id_U", "id_sucursal", "U_FechaNac" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);

                this.GridViewGeneral.Columns[0].Visible = true;
                this.GridViewGeneral.Columns[1].Visible = true;
                this.GridViewGeneral.Columns[2].Visible = true;
                this.GridViewGeneral.Columns[3].Visible = true;
                this.GridViewGeneral.Columns[4].Visible = true;
                this.GridViewGeneral.Columns[5].Visible = true;
                this.GridViewGeneral.Columns[6].Visible = true;
                this.GridViewGeneral.Columns[7].Visible = true;
                this.GridViewGeneral.Columns[8].Visible = true;

                this.GridViewGeneral.Columns[0].Width = 350;
                this.GridViewGeneral.Columns[1].Width = 200;
                this.GridViewGeneral.Columns[2].Width = 200;
                this.GridViewGeneral.Columns[3].Width = 80;
                this.GridViewGeneral.Columns[4].Width = 120;
                this.GridViewGeneral.Columns[5].Width = 120;
                this.GridViewGeneral.Columns[6].Width = 120;
                this.GridViewGeneral.Columns[7].Width = 120;
                this.GridViewGeneral.Columns[8].Width = 200;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridUsuario(ref Object Datos)
        {
            try
            {
                Usuario usuario = new Usuario(); 
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    usuario.Id_U = row.Cells["Id_U"].Value.ToString();
                    usuario.U_Nombre = row.Cells["U_Nombre"].Value.ToString();
                    usuario.U_Apellidop = row.Cells["U_Apellidop"].Value.ToString();
                    usuario.U_Apellidom = row.Cells["U_Apellidom"].Value.ToString();
                    usuario.U_FechaNac = Convert.ToDateTime(row.Cells["U_FechaNac"].Value);
                    usuario.U_DirCalle = row.Cells["U_DirCalle"].Value.ToString();
                    usuario.U_DirColonia = row.Cells["U_DirColonia"].Value.ToString();
                    usuario.U_DirNumero = row.Cells["U_DirNumero"].Value.ToString();
                    usuario.Id_Tu = Convert.ToInt32(row.Cells["Id_Tu"].Value);
                    usuario.Id_Turno = Convert.ToInt32(row.Cells["Id_Turno"].Value);
                    usuario.id_sucursal = row.Cells["id_sucursal"].Value.ToString();
                    usuario.Cu_User = row.Cells["Cu_User"].Value.ToString();
                    usuario.Cu_Pass = row.Cells["Cu_Pass"].Value.ToString();
                }
                Datos = usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarUsuario(Object Datos)
        {
            try
            {
                Usuario usuario = (Usuario) Datos;
                int Verificador = 0;
                Usuario_Negocio Usuario_Negocio = new Usuario_Negocio();
                Usuario_Negocio.EliminarUsuario(usuario, Comun.Conexion, ref Verificador);
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridCatChoferes
        private void CargarGridChofer()
        {
            try
            {
                Chofer_Negocio Chofer_Negocio = new Chofer_Negocio();
                Chofer Choferes = new Chofer();
                Chofer_Negocio.LlenarGridChofer(Comun.Conexion, ref Choferes);
                lstAuxDatosChoferes = Choferes.Choferes;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosChoferes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridChofer()
        {
            try
            {
                var Headertexts = new List<string> { "Nombre", "Curp", "Fecha de nacimiento", "Observaciones"};
                var Names = new List<string> { "NombreCompleto", "Curp", "FechaNacimiento", "Observaciones", "Nombre", "ApellidoPaterno", "ApellidoMaterno", "IDChofer" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);

                this.GridViewGeneral.Columns[0].Visible = true;
                this.GridViewGeneral.Columns[1].Visible = true;
                this.GridViewGeneral.Columns[2].Visible = true;
                this.GridViewGeneral.Columns[3].Visible = true;

                this.GridViewGeneral.Columns[0].Width = 250;
                this.GridViewGeneral.Columns[1].Width = 150;
                this.GridViewGeneral.Columns[2].Width = 120;
                this.GridViewGeneral.Columns[3].Width = 350;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridChofer(ref Object Datos)
        {
            try
            {
                Chofer chofer = new Chofer();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    chofer.IDChofer = row.Cells["IDChofer"].Value.ToString();
                    chofer.Nombre = row.Cells["Nombre"].Value.ToString();
                    chofer.ApellidoPaterno = row.Cells["ApellidoPaterno"].Value.ToString();
                    chofer.ApellidoMaterno = row.Cells["ApellidoMaterno"].Value.ToString();
                    chofer.Curp = row.Cells["ApellidoMaterno"].Value.ToString();
                    chofer.FechaNacimiento = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value.ToString());
                    chofer.Observaciones = row.Cells["Observaciones"].Value.ToString();
                }
                Datos = chofer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarChofer(Object Datos)
        {
            try
            {
                Chofer chofer = (Chofer)Datos;
                int Verificador = 0;
                Chofer_Negocio Chofer_Negocio = new Chofer_Negocio();
                Chofer_Negocio.EliminarChofer(chofer, Comun.Conexion, ref Verificador);
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridCatMarcas
        private void CargarGridMarcas()
        {
            try
            {
                Marca_Negocio Marca_Negocio = new Marca_Negocio();
                Marca Marcas = new Marca();
                Marca_Negocio.LlenarGridMarca(Comun.Conexion, ref Marcas);
                lstAuxDatosMarca = Marcas.Marcas;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosMarca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridMarcas()
        {
            try
            {
                var Headertexts = new List<string> { "Marca" };
                var Names = new List<string> { "marca", "id_marca" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);

                this.GridViewGeneral.Columns[0].Visible = true;

                this.GridViewGeneral.Columns[0].Width = 350;
                this.GridViewGeneral.Columns[1].Width = 200;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridMarca(ref Object Datos)
        {
            try
            {
                Marca marca = new Marca();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    marca.nombreMarca = row.Cells["marca"].Value.ToString();
                    marca.id_marca = Convert.ToInt32(row.Cells["id_marca"].Value);
                }
                Datos = marca;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarMarca(Object Datos)
        {
            try
            {
                Marca marca = (Marca)Datos;
                int Verificador = 0;
                Marca_Negocio Marca_Negocio = new Marca_Negocio();
                Marca_Negocio.EliminarMarca(marca, Comun.Conexion, ref Verificador);
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridCatSubmarcas
        private void CargarGridSubMarcas()
        {
            try
            {
                SubMarca_Negocio SubMarca_Negocio = new SubMarca_Negocio();
                SubMarca SubMarcas = new SubMarca();
                SubMarca_Negocio.LlenarGridSubMarca(Comun.Conexion, ref SubMarcas);
                lstAuxDatosSubMarca = SubMarcas.SubMarcas;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosSubMarca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridSubMarcas()
        {
            try
            {
                var Headertexts = new List<string> { "SubMarca", "Marca" };
                var Names = new List<string> { "submarca", "marca", "id_submarca", "id_marca" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);

                this.GridViewGeneral.Columns[0].Visible = true;
                this.GridViewGeneral.Columns[1].Visible = true;

                this.GridViewGeneral.Columns[0].Width = 350;
                this.GridViewGeneral.Columns[1].Width = 350;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridSubMarca(ref Object Datos)
        {
            try
            {
                SubMarca submarca = new SubMarca();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    submarca.nombreSubMarca = row.Cells["submarca"].Value.ToString();
                    submarca.id_submarca = Convert.ToInt32(row.Cells["id_submarca"].Value);
                    submarca.id_marca = Convert.ToInt32(row.Cells["id_marca"].Value);
                }
                Datos = submarca;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EliminarSubMarca(Object Datos)
        {
            try
            {
                SubMarca submarca = (SubMarca)Datos;
                int Verificador = 0;
                SubMarca_Negocio SubMarca_Negocio = new SubMarca_Negocio();
                SubMarca_Negocio.EliminarSubMarca(submarca, Comun.Conexion, ref Verificador);
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        #region GridCatTarejtas
        private void EstablecerPropiedadesGridTarjetas()
        {
            try
            {
                var Headertexts = new List<string> { "Folio", "Estatus", "Imagen" };
                var Names = new List<string> { "folio", "estatus","EstatusIMG", "id_tarjeta" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);

                this.GridViewGeneral.Columns[0].Visible = true;
                this.GridViewGeneral.Columns[25].Visible = true;
                
                this.GridViewGeneral.Columns[0].Width = 350;
                this.GridViewGeneral.Columns[25].Width = 350;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CargarGridTarjetas()
        {
            try
            {
                V2TarejetaGrid_Negocio Tarjeta_Negocio = new V2TarejetaGrid_Negocio();
                V2Tarjeta Tarjetas = new V2Tarjeta();
                Tarjeta_Negocio.LlenarGridTarjeta(Comun.Conexion, ref Tarjetas);
                lstAuxDatosTarjeta = Tarjetas.FolioTarjeta;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosTarjeta;
                ImagenGridTarjeta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ImagenGridTarjeta()
        {
            foreach (DataGridViewRow Grid in this.GridViewGeneral.Rows)
            {
                if (Convert.ToInt32(Grid.Cells[1].Value) == 1)
                    Grid.Cells[25].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_RED.png"), new Size(25, 25));
                else if (Convert.ToInt32(Grid.Cells[1].Value) == 2)
                    Grid.Cells[25].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_ORANGE.png"), new Size(25, 25));
                else if (Convert.ToInt32(Grid.Cells[1].Value) == 3)
                    Grid.Cells[25].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_GREEN.png"), new Size(25, 25));
            }
        }
        #endregion
        #region GridCatTipoCamion
        private void CargarGridTipoCamion()
        {
            try
            {
                TipoCamion_Negocio TipoCamion_Negocio = new TipoCamion_Negocio();
                TipoCamion TipoCamiones = new TipoCamion();
                TipoCamion_Negocio.LlenarGridTipoCamion(Comun.Conexion, ref TipoCamiones);
                lstAuxDatosTipoCamion = TipoCamiones.TipoCamiones;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosTipoCamion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridTipoCamion()
        {
            try
            {
                var Headertexts = new List<string> { "Tipo de Camión","Maximo Descuento" };
                var Names = new List<string> { "tipoCamion", "maximoDescuentoLinea", "id_tipoCamion" };
                //Hasta aquí
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);

                this.GridViewGeneral.Columns[0].Visible = true;

                this.GridViewGeneral.Columns[0].Width = 350;
                this.GridViewGeneral.Columns[1].Width = 150;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridTipoCamion(ref Object Datos)
        {
            try
            {
                TipoCamion tipocamion = new TipoCamion();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    tipocamion.nombreTipoCamion = row.Cells["tipoCamion"].Value.ToString();
                    tipocamion.maximoDescuentoLinea = Convert.ToSingle(row.Cells["maximoDescuentoLinea"].Value.ToString());
                    tipocamion.id_tipocamion = Convert.ToInt32(row.Cells["id_tipoCamion"].Value);
                }
                Datos = tipocamion;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarTipoCamion(Object Datos)
        {
            try
            {
                TipoCamion tipocamion = (TipoCamion)Datos;
                int Verificador = 0;
                TipoCamion_Negocio TipoCamion_Negocio = new TipoCamion_Negocio();
                TipoCamion_Negocio.EliminarTipoCamion(tipocamion, Comun.Conexion, ref Verificador);
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridCatPorcentajeMonedero
        private void CargarGridPorcentajeMonedero()
        {
            try
            {
                PorcentajeMonedero_Negocio PorcentajeMonedero_Negocio = new PorcentajeMonedero_Negocio();
                PorcentajeMonedero PorcentajeMonedero = new PorcentajeMonedero();
                PorcentajeMonedero_Negocio.LlenarGridPorcentajeMonedero(Comun.Conexion, ref PorcentajeMonedero);
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = PorcentajeMonedero.PorcentajesMonedero;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridPorcentajeMonedero()
        {
            try
            {
                var Headertexts = new List<string> { "% Monedero", "$ Cancelación / Anticipo" };
                var Names = new List<string> { "Porcentaje_Monedero","Cancelacion", "IDSucursal" };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);

                this.GridViewGeneral.Columns[0].Visible = true;
                this.GridViewGeneral.Columns[1].Visible = true;

                this.GridViewGeneral.Columns[0].Width = 350;
                this.GridViewGeneral.Columns[0].DefaultCellStyle.Format = "N2";
                this.GridViewGeneral.Columns[1].Width = 350;
                this.GridViewGeneral.Columns[1].DefaultCellStyle.Format = "c";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ObtenerDatosGridPorcentajeMonedero(ref Object Datos)
        {
            try
            {
                PorcentajeMonedero PorcentajeMonedero = new PorcentajeMonedero();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    PorcentajeMonedero.IDSucursal = row.Cells["IDSucursal"].Value.ToString();
                    PorcentajeMonedero.Porcentaje_Monedero = Convert.ToSingle(row.Cells["Porcentaje_Monedero"].Value);
                    PorcentajeMonedero.MontoCancelacion = Convert.ToSingle(row.Cells["Cancelacion"].Value);
                }
                Datos = PorcentajeMonedero;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarPorcentajeMonedero(Object Datos)
        {
            try
            {
                PorcentajeMonedero PorcentajeMonedero = (PorcentajeMonedero)Datos;
                int Verificador = 0;
                PorcentajeMonedero_Negocio PorcentajeMonedero_Negocio = new PorcentajeMonedero_Negocio();
                PorcentajeMonedero_Negocio.EliminarPorcentajeMonedero(PorcentajeMonedero, Comun.Conexion, ref Verificador);
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region GridCatClasificacionClientes
        private void CargarGridClasificacion()
        {
            try
            {
                Clasificacion_Negocio cn = new Clasificacion_Negocio();
                ClasificacionCliente Clasificacion = new ClasificacionCliente();
                cn.LlenarGridClasificacion(Comun.Conexion, ref Clasificacion);
                lstAuxDatosClasificacionClientes = Clasificacion.dataTable_Clasificaciones;
                this.GridViewGeneral.AutoGenerateColumns = false;
                this.GridViewGeneral.DataSource = lstAuxDatosClasificacionClientes;

                //Marca_Negocio Marca_Negocio = new Marca_Negocio();
                //Marca Marcas = new Marca();
                //Marca_Negocio.LlenarGridMarca(Comun.Conexion, ref Marcas);
                //lstAuxDatosMarca = Marcas.Marcas;
                //this.GridViewGeneral.AutoGenerateColumns = false;
                //this.GridViewGeneral.DataSource = lstAuxDatosMarca;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EstablecerPropiedadesGridClasificacion()
        {
            try
            {
                var Headertexts = new List<string> { "IDClasificacion", "Clasificacion", "Porcentaje"/*, "Porcentaje"*/ };
                var Names = new List<string> { "IDClasificacion", "Descripcion", "Porcentaje"/*, "Porcentaje"*/ };
                this.RecorrerFor(Headertexts, 1);
                this.RecorrerFor(Names, 2);
                this.RecorrerFor(Names, 3);


                this.GridViewGeneral.Columns[1].Width = 300;
                this.GridViewGeneral.Columns[2].Width = 300;
                

                this.GridViewGeneral.Columns[2].DefaultCellStyle.Format = "P";

                this.GridViewGeneral.Columns[1].Visible = true;
                this.GridViewGeneral.Columns[2].Visible = true;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }                              

        private void ObtenerDatosGridClasificacion(ref Object Datos)
        {
            try
            {
                ClasificacionCliente Clasificacion = new ClasificacionCliente();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    Clasificacion.IDClasificacion = Convert.ToInt32(row.Cells["IDClasificacion"].Value);
                    Clasificacion.Descripcion = row.Cells["Descripcion"].Value.ToString();
                    decimal.TryParse(row.Cells["Porcentaje"].Value.ToString(), out decimal procentaje);
                    Clasificacion.Porcentaje = procentaje;
                }
                Datos = Clasificacion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void EliminarClasificacion(Object Datos)
        {
            try
            {
                ClasificacionCliente Clasificacion = (ClasificacionCliente)Datos;
                int Verificador = 0;
                Clasificacion_Negocio Clasificacion_negocio = new Clasificacion_Negocio();
                Clasificacion_negocio.EliminarClasificacion(Clasificacion, Comun.Conexion, ref Verificador);
                if (Verificador == 0)
                {
                    MessageBox.Show("Los datos se eliminaron correctamente", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CargarGridPropiedades();
                    this.CargarGridCatalogos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Clasificación", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        #endregion
        #endregion
        #region MetodosGeneralesGrid
        private void reestablecerFormato()
        {
            try
            {
                this.GridViewGeneral.Columns[0].Visible = false;
                this.GridViewGeneral.Columns[1].Visible = false;
                this.GridViewGeneral.Columns[2].Visible = false;
                this.GridViewGeneral.Columns[3].Visible = false;
                this.GridViewGeneral.Columns[4].Visible = false;
                this.GridViewGeneral.Columns[5].Visible = false;
                this.GridViewGeneral.Columns[6].Visible = false;
                this.GridViewGeneral.Columns[7].Visible = false;
                this.GridViewGeneral.Columns[8].Visible = false;
                this.GridViewGeneral.Columns[9].Visible = false;
                this.GridViewGeneral.Columns[10].Visible = false;
                this.GridViewGeneral.Columns[11].Visible = false;
                this.GridViewGeneral.Columns[12].Visible = false;
                this.GridViewGeneral.Columns[13].Visible = false;
                this.GridViewGeneral.Columns[14].Visible = false;
                this.GridViewGeneral.Columns[15].Visible = false;
                this.GridViewGeneral.Columns[16].Visible = false;
                this.GridViewGeneral.Columns[17].Visible = false;
                this.GridViewGeneral.Columns[18].Visible = false;
                this.GridViewGeneral.Columns[19].Visible = false;
                this.GridViewGeneral.Columns[20].Visible = false;
                this.GridViewGeneral.Columns[21].Visible = false;
                this.GridViewGeneral.Columns[22].Visible = false;
                this.GridViewGeneral.Columns[23].Visible = false;
                this.GridViewGeneral.Columns[24].Visible = false;
                this.GridViewGeneral.Columns[25].Visible = false;

                this.GridViewGeneral.Columns[1].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[2].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[3].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[4].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[5].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[6].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[7].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[8].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[9].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[10].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[11].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[12].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[13].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[14].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[15].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[16].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[17].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[18].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[19].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[20].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[21].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[22].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[23].DefaultCellStyle.Format = "";
                this.GridViewGeneral.Columns[24].DefaultCellStyle.Format = "";

                this.pictureBox1.Visible = false;
                this.pictureBox2.Visible = false;
                this.pictureBox3.Visible = false;
                this.label3.Visible = false;
                this.label4.Visible = false;
                this.label5.Visible = false;
                this.btnNuevaFecha.Visible = false;
                this.btn_ElimnarFecha.Visible = false;
                this.btn_Calendario.Visible = false;
            }
            catch (Exception ex)
            {
            }
        }
        private void RecorrerFor(List<string> campos, int opcion)
        {
            for (var index = 0; index < campos.Count; index++)
            {
                if (opcion == 1)
                    this.HeaderTextGridGeneral(index, campos[index]);
                else if (opcion == 2)
                    this.NameGridGeneral(index, campos[index]);
                else if (opcion == 3)
                    this.DataPropertyNameGridGeneral(index, campos[index]);
            }
        }
        private void HeaderTextGridGeneral(int numColum, string nombre)
        {
            try
            {
                this.GridViewGeneral.Columns[numColum].HeaderText = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void NameGridGeneral(int numColum, string nombre)
        {
            try
            {
                this.GridViewGeneral.Columns[numColum].Name = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DataPropertyNameGridGeneral(int numColum, string nombre)
        {
            try
            {
                this.GridViewGeneral.Columns[numColum].DataPropertyName = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<DataGridViewRow> ObtenerFilaSeleccionada()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in GridViewGeneral.Rows)
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
        private bool ValidarFilaSeleccionada(List<DataGridViewRow> rowSelected)
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
        private void ImagenGrid()
        {
            foreach (DataGridViewRow Grid in this.GridViewGeneral.Rows)
            {
                if (Convert.ToInt32(Grid.Cells[19].Value) == 0)
                    Grid.Cells[25].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_RED.png"), new Size(25, 25));
                else if (Convert.ToInt32(Grid.Cells[19].Value) == 1)
                    Grid.Cells[25].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_ORANGE.png"), new Size(25, 25));
                else if (Convert.ToInt32(Grid.Cells[19].Value) == 2)
                    Grid.Cells[25].Value = resizeImage(Image.FromFile(Application.StartupPath + @"\Resources\Estatus\GLOBES_GREEN.png"), new Size(25, 25));
            }
        }
       
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        #endregion

        private void button_Creativa1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 14;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button_Creativa2_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoCatalogo = 15;
                this.CargarGridPropiedades();
                this.CargarGridCatalogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnGenerarFolio_Click(object sender, EventArgs e)
        {
            try
            {
                frm_v2_AsignarTarjetaV2 generar = new frm_v2_AsignarTarjetaV2(true);
                generar.ShowDialog();
                generar.Dispose();
                CargarGridTarjetas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_ReporteFolio_Click(object sender, EventArgs e)
        {
            try
            {
                frmReportes frmReportesVista = new frmReportes(13);
                frmReportesVista.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
