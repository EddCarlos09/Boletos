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
    public partial class frmVentaBoletoV2 : MaterialForm
    {
        public frmVentaBoletoV2()
        {
            try
            {
                float AuxPagoExtra = 0.0F;
                float Precio = 0F;
                float Anticipo = 0F;
                if (InfoVentaBoletosAux.ventaGrupal == false)
                {
                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                    {
                        AuxPagoExtra = Convert.ToSingle(row.Cells["PagoExtra"].Value);
                        Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                        Anticipo = Convert.ToSingle(row.Cells["Anticipo"].Value);
                    }
                    if (AuxPagoExtra > 0.0)
                    {
                        if (MessageBox.Show("Este boleto ya tiene aplicado un pago extra, ¿ desea eliminar el pago extra ? ", "¿Aplicar otro Descuento?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            frmPagoExtraV2 frmpe = new frmPagoExtraV2();
                            frmpe.ShowDialog();
                            if (frmpe.getBanPagoExtra())
                            {
                                AuxPagoExtra = frmpe.getPagoExtra();
                                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                {
                                    row.Cells["PagoExtra"].Value = AuxPagoExtra;
                                }
                                this.CalcularTotales();
                                this.AplicarReglas(4, GridViewVentaBoletos.SelectedRows[0].Index);
                            }
                            frmpe.Dispose();
                        }
                    }
                    else
                    {
                        frmPagoExtraV2 frmpe = new frmPagoExtraV2();
                        frmpe.ShowDialog();
                        if (frmpe.getBanPagoExtra())
                        {
                            AuxPagoExtra = AuxPagoExtra + frmpe.getPagoExtra();
                            foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                            {
                                row.Cells["PagoExtra"].Value = AuxPagoExtra;
                            }
                            this.CalcularTotales();
                            this.AplicarReglas(4, GridViewVentaBoletos.SelectedRows[0].Index);
                        }
                        frmpe.Dispose();
                    }
                }
                else
                {
                    float pagoExtraGrupal = 0.0F;
                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                    {
                        AuxPagoExtra = Convert.ToSingle(row.Cells["PagoExtra"].Value);
                        Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                        Anticipo = Convert.ToSingle(row.Cells["Anticipo"].Value);
                    }
                    frmPagoExtraV2 frmpe = new frmPagoExtraV2();
                    frmpe.ShowDialog();
                    if (frmpe.getBanPagoExtra())
                    {
                        AuxPagoExtra = AuxPagoExtra + frmpe.getPagoExtra();
                        pagoExtraGrupal = AuxPagoExtra / this.InfoVentaBoletosAux.BoletosDetalle.Rows.Count;
                        foreach (DataRow row in this.InfoVentaBoletosAux.BoletosDetalle.Rows)
                        {
                            row["PagoExtra"] = pagoExtraGrupal;
                        }
                        this.CargarGridViewVentaBoletos();
                        this.CalcularTotales();
                        for (int i = 0; i < this.InfoVentaBoletosAux.BoletosDetalle.Rows.Count; i++)
                            this.AplicarReglas(4, i);
                    }
                    frmpe.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void btn_Anticipo_Click(object sender, EventArgs e)
        {
            try
            {
                float AuxAnticipo = 0.0F;
                float Precio = 0F;
                float Descuentos = 0F;
                float CobroExtra = 0F;
                if (InfoVentaBoletosAux.ventaGrupal == false)
                {
                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                    {
                        AuxAnticipo = Convert.ToSingle(row.Cells["Anticipo"].Value);
                        Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                        Descuentos = Convert.ToSingle(row.Cells["Descuentos"].Value);
                        CobroExtra = Convert.ToSingle(row.Cells["PagoExtra"].Value);
                    }
                    if (AuxAnticipo > 0.0)
                    {
                        if (MessageBox.Show("Este boleto ya tiene aplicado un anticipo, ¿ desea eliminar el anticipo ?", "¿Aplicar nuevo Anticipo?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            frmAnticipoGenericoV2 frmd = new frmAnticipoGenericoV2();
                            frmd.ShowDialog();
                            if (frmd.getBanAnticipo())
                            {
                                AuxAnticipo = frmd.getAnticipoGenerico();
                                if (frmd.getAnticipoGenerico() > (Precio - Descuentos + CobroExtra))
                                {
                                    MessageBox.Show("La suma del nuevo anticipo es mas grande que el valor del precio", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    if (AuxAnticipo >= Comun.anticipoMinimo)
                                    {
                                        foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                        {
                                            row.Cells["Anticipo"].Value = AuxAnticipo;
                                        }
                                        this.CalcularTotales();
                                        this.AplicarReglas(0, GridViewVentaBoletos.SelectedRows[0].Index);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No puedes anticipar boletos con menos de $" + Comun.anticipoMinimo.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            frmd.Dispose();
                        }
                    }
                    else
                    {
                        frmAnticipoGenericoV2 frmd = new frmAnticipoGenericoV2();
                        frmd.ShowDialog();
                        if (frmd.getBanAnticipo())
                        {
                            foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                            {
                                Descuentos = Convert.ToSingle(row.Cells["Descuentos"].Value);
                                Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                            }
                            if (frmd.getAnticipoGenerico() > (Precio - Descuentos + CobroExtra))
                            {
                                MessageBox.Show("No aplicar un anticipo mas grande que el valor del precio", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                AuxAnticipo = frmd.getAnticipoGenerico();
                                if (AuxAnticipo >= Comun.anticipoMinimo)
                                {
                                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                    {
                                        row.Cells["Anticipo"].Value = AuxAnticipo;
                                    }
                                    this.CalcularTotales();
                                    this.AplicarReglas(0, GridViewVentaBoletos.SelectedRows[0].Index);
                                }
                                else
                                {
                                    MessageBox.Show("No puedes anticipar boletos con menos de $" + Comun.anticipoMinimo.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        frmd.Dispose();
                    }
                }
                else
                {
                    float anticipoGrupal = 0.0F;

                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                    {
                        AuxAnticipo = Convert.ToSingle(row.Cells["Anticipo"].Value);
                        Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                        Descuentos = Convert.ToSingle(row.Cells["Descuentos"].Value);
                        CobroExtra = Convert.ToSingle(row.Cells["PagoExtra"].Value);
                    }
                    frmAnticipoGenericoV2 frmd = new frmAnticipoGenericoV2();
                    frmd.ShowDialog();
                    if (frmd.getBanAnticipo())
                    {
                        AuxAnticipo = AuxAnticipo + frmd.getAnticipoGenerico();
                        anticipoGrupal = AuxAnticipo / this.InfoVentaBoletosAux.BoletosDetalle.Rows.Count;
                        if (anticipoGrupal > (Precio - Descuentos + CobroExtra))
                        {
                            MessageBox.Show("La suma del nuevo anticipo es mas grande que el valor del precio", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (AuxAnticipo >= (Comun.anticipoMinimo * this.InfoVentaBoletosAux.BoletosDetalle.Rows.Count))
                            {
                                foreach (DataRow row in this.InfoVentaBoletosAux.BoletosDetalle.Rows)
                                {
                                    row["Anticipo"] = anticipoGrupal;
                                }
                                this.CargarGridViewVentaBoletos();
                                this.CalcularTotales();
                                for (int i = 0; i < this.InfoVentaBoletosAux.BoletosDetalle.Rows.Count; i++)
                                    this.AplicarReglas(0, i);
                            }
                            else
                            {
                                MessageBox.Show("No puedes anticipar boletos con menos de $" + (Comun.anticipoMinimo * this.InfoVentaBoletosAux.BoletosDetalle.Rows.Count).ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    frmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_DescuentoGenerico_Click(object sender, EventArgs e)
        {
            try
            {
                float AuxDescuento = 0.0F;
                float Precio = 0F;
                float Anticipo = 0F;
                float CobroExtra = 0F;
                if (InfoVentaBoletosAux.ventaGrupal == false)
                {
                    frmLoginValidator frml = new frmLoginValidator();
                    frml.ShowDialog();
                    if (frml.getbanAutorizacion())
                    {
                        foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                        {
                            AuxDescuento = Convert.ToSingle(row.Cells["Descuentos"].Value);
                            Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                            Anticipo = Convert.ToSingle(row.Cells["Anticipo"].Value);
                            CobroExtra = Convert.ToSingle(row.Cells["PagoExtra"].Value);
                        }
                        if (AuxDescuento > 0.0)
                        {
                            if (MessageBox.Show("Este boleto ya tiene aplicado un descuento, ¿ desea eliminar el descuento ?", "¿Aplicar nuevo Descuento?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                frmDescuentoGenericoV2 frmd = new frmDescuentoGenericoV2();
                                frmd.ShowDialog();
                                if (frmd.getBanDescuento())
                                {
                                    AuxDescuento = frmd.getDescuentoGenerico();
                                    if (frmd.getDescuentoGenerico() > (Precio - Anticipo + CobroExtra))
                                    {
                                        MessageBox.Show("La suma del nuevo descuento es mas grande que el valor del precio", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                        {
                                            row.Cells["Descuentos"].Value = AuxDescuento;
                                            row.Cells["TipoDescuento"].Value = 2;
                                        }
                                        this.CalcularTotales();
                                        this.AplicarReglas(2, GridViewVentaBoletos.SelectedRows[0].Index);
                                    }
                                }
                                frmd.Dispose();
                            }
                        }
                        else
                        {
                            frmDescuentoGenericoV2 frmd = new frmDescuentoGenericoV2();
                            frmd.ShowDialog();
                            if (frmd.getBanDescuento())
                            {
                                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                {
                                    AuxDescuento = Convert.ToSingle(row.Cells["Descuentos"].Value);
                                    Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                                    Anticipo = Convert.ToSingle(row.Cells["Anticipo"].Value);
                                    CobroExtra = Convert.ToSingle(row.Cells["PagoExtra"].Value);
                                }
                                if (frmd.getDescuentoGenerico() > (Precio - Anticipo + CobroExtra))
                                {
                                    MessageBox.Show("No puedes aplicar un descuento mas grande que el valor del precio", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    AuxDescuento = AuxDescuento + frmd.getDescuentoGenerico();
                                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                    {
                                        row.Cells["Descuentos"].Value = AuxDescuento;
                                        row.Cells["TipoDescuento"].Value = 2;
                                    }
                                    this.CalcularTotales();
                                    this.AplicarReglas(2, GridViewVentaBoletos.SelectedRows[0].Index);
                                }
                            }
                            frmd.Dispose();
                        }
                    }
                    frml.Dispose();
                }
                else
                {
                    frmLoginValidator frml = new frmLoginValidator();
                    frml.ShowDialog();
                    if (frml.getbanAutorizacion())
                    {
                        float descuentoGrupal = 0.0F;

                        frmDescuentoGenericoV2 frmd = new frmDescuentoGenericoV2();
                        frmd.ShowDialog();
                        if (frmd.getBanDescuento())
                        {
                            foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                            {
                                AuxDescuento = Convert.ToSingle(row.Cells["Descuentos"].Value);
                                Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                                Anticipo = Convert.ToSingle(row.Cells["Anticipo"].Value);
                                CobroExtra = Convert.ToSingle(row.Cells["PagoExtra"].Value);
                            }
                            AuxDescuento = AuxDescuento + frmd.getDescuentoGenerico();
                            descuentoGrupal = AuxDescuento / this.InfoVentaBoletosAux.BoletosDetalle.Rows.Count;

                            if (descuentoGrupal > (Precio - Anticipo + CobroExtra))
                            {
                                MessageBox.Show("No puedes aplicar un descuento mas grande que el valor del precio", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                foreach (DataRow row in this.InfoVentaBoletosAux.BoletosDetalle.Rows)
                                {
                                    row["Descuentos"] = descuentoGrupal;
                                    row["TipoDescuento"] = 2;
                                }
                                this.CargarGridViewVentaBoletos();
                                this.CalcularTotales();
                                for (int i = 0; i < this.InfoVentaBoletosAux.BoletosDetalle.Rows.Count; i++)
                                    this.AplicarReglas(2, i);
                            }
                        }
                        frmd.Dispose();
                    }
                    frml.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_DescuentoCompleto_Click(object sender, EventArgs e)
        {
            try
            {
                if (InfoVentaBoletosAux.ventaGrupal == false)
                {
                    frmLoginValidator frml = new frmLoginValidator();
                    frml.ShowDialog();
                    if (frml.getbanAutorizacion())
                    {
                        float Anticipo = 0F;
                        foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                        {
                            Anticipo = Convert.ToSingle(row.Cells["Anticipo"].Value.ToString());
                        }
                        if (Anticipo > 0.0)
                        {
                            MessageBox.Show("No puedes aplicar el descuento completo ya que tiene un anticipo", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                            {
                                row.Cells["Descuentos"].Value = Convert.ToSingle(row.Cells["Precio"].Value.ToString()) + Convert.ToSingle(row.Cells["PagoExtra"].Value.ToString());
                                row.Cells["TipoDescuento"].Value = 3;
                            }
                            this.CalcularTotales();
                            this.AplicarReglas(3, GridViewVentaBoletos.SelectedRows[0].Index);
                        }
                    }
                    frml.Dispose();
                }
                else
                {
                    frmLoginValidator frml = new frmLoginValidator();
                    frml.ShowDialog();
                    if (frml.getbanAutorizacion())
                    {
                        float Anticipo = 0F;
                        foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                        {
                            Anticipo = Convert.ToSingle(row.Cells["Anticipo"].Value.ToString());
                        }
                        if (Anticipo > 0.0)
                        {
                            MessageBox.Show("No puedes aplicar el descuento completo ya que tiene un anticipo", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            foreach (DataRow row in this.InfoVentaBoletosAux.BoletosDetalle.Rows)
                            {
                                row["Descuentos"] = Convert.ToSingle(row["Precio"].ToString()) + Convert.ToSingle(row["PagoExtra"].ToString());
                                row["TipoDescuento"] = 3;
                            }
                            this.CargarGridViewVentaBoletos();
                            this.CalcularTotales();
                            this.AplicarReglas(3, GridViewVentaBoletos.SelectedRows[0].Index);
                        }
                    }
                    frml.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void GridViewVentaBoletos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (GridViewVentaBoletos.SelectedRows.Count > 0)
                {
                    this.Txt_NumCamion.Text = this.GridViewVentaBoletos.SelectedRows[0].Cells["NumCamion"].Value.ToString();
                    this.Txt_FechaHoraSalida.Text = this.GridViewVentaBoletos.SelectedRows[0].Cells["FechaSalidaV2"].Value.ToString() + " " + this.GridViewVentaBoletos.SelectedRows[0].Cells["HoraSalidaV"].Value.ToString();
                    this.Txt_Origen.Text = this.GridViewVentaBoletos.SelectedRows[0].Cells["Origen"].Value.ToString();
                    this.Txt_TipoLinea.Text = this.GridViewVentaBoletos.SelectedRows[0].Cells["TipoLinea"].Value.ToString();
                    this.Txt_FechaHoraLlegada.Text = this.GridViewVentaBoletos.SelectedRows[0].Cells["FechaLLegadaV2"].Value.ToString() + " " + this.GridViewVentaBoletos.SelectedRows[0].Cells["HoraLlegadaV"].Value.ToString();
                    this.Txt_Destino.Text = this.GridViewVentaBoletos.SelectedRows[0].Cells["Destino"].Value.ToString();
                    this.ReglasBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReglasBotones()
        {
            if (GridViewVentaBoletos.SelectedRows.Count > 0)
            {
                btn_Anticipo.Enabled = true;
                btn_CambioBoleto.Enabled = true;
                btn_DescuentoGenerico.Enabled = true;
                btn_DescuentoCompleto.Enabled = true;
                btn_PagoExtra.Enabled = true;
                btn_Apartar.Enabled = true;

                btn_Anticipo.Enabled = Convert.ToBoolean(Reglas[GridViewVentaBoletos.SelectedRows[0].Index, 0]);


                if (Comun.Id_Tu == 1 || Comun.Id_Tu == 3)
                {
                    btn_CambioBoleto.Enabled = Convert.ToBoolean(Reglas[GridViewVentaBoletos.SelectedRows[0].Index, 1]);
                    btn_DescuentoGenerico.Enabled = Convert.ToBoolean(Reglas[GridViewVentaBoletos.SelectedRows[0].Index, 2]);
                    btn_DescuentoCompleto.Enabled = Convert.ToBoolean(Reglas[GridViewVentaBoletos.SelectedRows[0].Index, 3]);
                }
                else
                {
                    btn_CambioBoleto.Enabled = false;
                    btn_DescuentoGenerico.Enabled = false;
                    btn_DescuentoCompleto.Enabled = false;
                }

                if (InfoVentaBoletosAux.ventaGrupal == true)
                    btn_CambioBoleto.Enabled = false;

                btn_PagoExtra.Enabled = Convert.ToBoolean(Reglas[GridViewVentaBoletos.SelectedRows[0].Index, 4]);
                for (int aux = 0; aux < Reglas.GetLength(0); aux++)
                {
                    if (Convert.ToBoolean(Reglas[aux, 5]) == false)
                    {
                        btn_Apartar.Enabled = Convert.ToBoolean(Reglas[aux, 5]);
                    }
                }

            }
        }
        private void btn_CambioBoleto_Click(object sender, EventArgs e)
        {
            try
            {
                bool banTransferenciaMismoBoleto = false;
                float MaximoDescuento = 0.0F;
                frmLoginValidator frml = new frmLoginValidator();
                frml.ShowDialog();
                if (frml.getbanAutorizacion())
                {
                    float AuxDescuento = 0.0F;
                    float Precio = 0F;
                    float Anticipo = 0F;
                    string IDTipoCamion = "";
                    string IDBoletoActual = "";
                    frmBusquedaCambioV2 frmb = new frmBusquedaCambioV2();
                    frmb.ShowDialog();
                    if (frmb.getBanCambio())
                    {
                        //if (frmb.getBloqueoTransferencia24Hrs() == 1)
                        //{
                        //    MessageBox.Show("Este boleto no puede ser transferido ya que no cumple con el requisito de las 24 horas minimo antes de la hora de salida", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    return;
                        //}
                        foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                        {
                            AuxDescuento = Convert.ToSingle(row.Cells["Descuentos"].Value);
                            Precio = Convert.ToSingle(row.Cells["Precio"].Value);
                            Anticipo = Convert.ToSingle(row.Cells["Anticipo"].Value);
                            IDTipoCamion = Convert.ToString(row.Cells["IDTipoCamion"].Value);
                            IDBoletoActual = row.Cells["IDBoleto"].Value.ToString();
                        }

                        foreach (MotivoCancelacionesTrasferencias aux in lstmotivoCancelacionesTransferencias)
                        {
                            if (aux.id_boletoTransferencia == frmb.motivoCancelacionesTransferencias.id_boletoTransferencia)
                                banTransferenciaMismoBoleto = true;
                        }
                        if (banTransferenciaMismoBoleto == false)
                        {
                            frmb.motivoCancelacionesTransferencias.id_boleto = IDBoletoActual;
                            lstmotivoCancelacionesTransferencias.Add(frmb.motivoCancelacionesTransferencias);
                        }
                        //MaximoDescuento
                        if (Comun.MaximoDescuentoLinea != null)
                        {
                            foreach (DataRow row in Comun.MaximoDescuentoLinea.Rows)
                            {
                                if (IDTipoCamion.Equals(row["id_tipoCamion"].ToString()))
                                    MaximoDescuento = Convert.ToSingle(row["maximoDescuentoLinea"]);
                            }
                        }
                        if (banTransferenciaMismoBoleto == true)
                        {
                            MessageBox.Show("No puedes aplicar la transferencia ya que este boleto se le esta aplicando una transferencia", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (Anticipo > 0.0)
                        {
                            MessageBox.Show("No puedes aplicar la transferencia ya que tiene un anticipo", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (AuxDescuento > 0.0)
                        {
                            MessageBox.Show("No puedes aplicar la transferencia este boleto tiene aplicado un descuento", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (AuxDescuento == 0.0)
                        {
                            if (frmb.getPrecio() == Precio)
                            {
                                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                {
                                    row.Cells["Descuentos"].Value = frmb.getPrecio();
                                    row.Cells["TipoDescuento"].Value = 4;
                                    row.Cells["IDBoletoTransferencia"].Value = frmb.getIDBoleto();
                                }
                                this.CalcularTotales();
                                this.AplicarReglas(1, GridViewVentaBoletos.SelectedRows[0].Index);
                            }
                            else if (frmb.getPrecio() < Precio)
                            {
                                if (frmb.getPrecio() + MaximoDescuento >= Precio)
                                {
                                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                    {
                                        row.Cells["Precio"].Value = frmb.getPrecio();
                                        row.Cells["Descuentos"].Value = frmb.getPrecio();
                                        row.Cells["TipoDescuento"].Value = 4;
                                        row.Cells["IDBoletoTransferencia"].Value = frmb.getIDBoleto();
                                    }
                                    this.CalcularTotales();
                                    this.AplicarReglas(1, GridViewVentaBoletos.SelectedRows[0].Index);
                                }
                                else if (frmb.motivoCancelacionesTransferencias.transferenciaCompleta == true)
                                {
                                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                    {
                                        row.Cells["Precio"].Value = frmb.getPrecio();
                                        row.Cells["Descuentos"].Value = frmb.getPrecio();
                                        row.Cells["TipoDescuento"].Value = 4;
                                        row.Cells["IDBoletoTransferencia"].Value = frmb.getIDBoleto();
                                    }
                                    this.CalcularTotales();
                                    this.AplicarReglas(1, GridViewVentaBoletos.SelectedRows[0].Index);
                                }
                                else if (MessageBox.Show("El precio del boleto a cambiar es menor que el nuevo, tiene que pagar la diferencia", "¿Aplicar transferencia?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                    {
                                        row.Cells["Descuentos"].Value = row.Cells["Precio"].Value;
                                        row.Cells["TipoDescuento"].Value = 4;
                                        row.Cells["IDBoletoTransferencia"].Value = frmb.getIDBoleto();
                                    }
                                    this.CalcularTotales();
                                    this.AplicarReglas(1, GridViewVentaBoletos.SelectedRows[0].Index);
                                }
                            }
                            if (frmb.getPrecio() > Precio)
                            {
                                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionadaGridViewVentaBoletos())
                                {
                                    row.Cells["Descuentos"].Value = row.Cells["Precio"].Value;
                                    row.Cells["TipoDescuento"].Value = 4;
                                    row.Cells["IDBoletoTransferencia"].Value = frmb.getIDBoleto();
                                }
                                this.CalcularTotales();
                                this.AplicarReglas(1, GridViewVentaBoletos.SelectedRows[0].Index);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GridViewVentaBoletos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (MessageBox.Show("¿Desea eliminar el descuento, anticipo y el cobro extra aplicado? ", "Eliminar Descuento-Anticipo-CobroExtra", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        GridViewVentaBoletos.Rows[e.RowIndex].Cells["Descuentos"].Value = 0.0;
                        GridViewVentaBoletos.Rows[e.RowIndex].Cells["Anticipo"].Value = 0.0;
                        GridViewVentaBoletos.Rows[e.RowIndex].Cells["PagoExtra"].Value = 0.0;
                        GridViewVentaBoletos.Rows[e.RowIndex].Cells["TipoDescuento"].Value = 0;
                        GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDTipoTarifa"].Value = 1;
                        string IDBoletoTransferencia = GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDBoletoTransferencia"].Value.ToString();
                        MotivoCancelacionesTrasferencias aux = new MotivoCancelacionesTrasferencias();
                        foreach (MotivoCancelacionesTrasferencias motivo in lstmotivoCancelacionesTransferencias)
                        {
                            if (motivo.id_boletoTransferencia == IDBoletoTransferencia)
                                aux = motivo;
                        }
                        lstmotivoCancelacionesTransferencias.Remove(aux);
                        GridViewVentaBoletos.Rows[e.RowIndex].Cells["IDBoletoTransferencia"].Value = "";
                        this.CalcularTotales();
                        for (int AuxColumnas = 0; AuxColumnas < columnas; AuxColumnas++)
                        {
                            Reglas[e.RowIndex, AuxColumnas] = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
        #region GridViewVentaBoletos
        private void CargarGridViewVentaBoletos()
        {
            try
            {
                this.GridViewVentaBoletos.AutoGenerateColumns = false;
                this.GridViewVentaBoletos.DataSource = this.InfoVentaBoletosAux.BoletosDetalle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EstablecerPropiedadesGridViewVentaBoletos()
        {
            try
            {

                var Headertexts = new List<string> { "Origen", "Destino", "Precio", "Descuento", "Anticipo", "PagoExtra", "#", "Nombre", "Fecha Nacimiento", "Teléfono" };
                var Names = new List<string> { "Origen", "Destino", "Precio", "Descuentos", "Anticipo", "PagoExtra", "Asiento", "Nombre", "FechaNacimiento", "NumeroTelefono", "IDViaje", "IDCamionDiseño", "NumCamion", "TipoLinea", "FechaLLegadaV", "FechaLLegadaV2", "HoraLLegadaV", "TipoDescuento", "FechaSalidaV2", "HoraSalidaV", "IDBoleto", "IDTarifa", "IDTipoTarifa", "DescripcionIndice", "FechaSalidaV", "FechaSalida", "HoraSalida", "IDStatus", "IDBoletoTransferencia", "IDTipoCamion", "codigoTarjeta" };

                this.RecorrerForGridViewVentaBoletos(Headertexts, 1);
                this.RecorrerForGridViewVentaBoletos(Names, 2);
                this.RecorrerForGridViewVentaBoletos(Names, 3);
                int valor = this.GridViewVentaBoletos.Columns.Count;
                this.GridViewVentaBoletos.Columns[0].Width = 130;
                this.GridViewVentaBoletos.Columns[1].Width = 130;
                this.GridViewVentaBoletos.Columns[2].Width = 95;
                this.GridViewVentaBoletos.Columns[2].DefaultCellStyle.Format = "c";
                this.GridViewVentaBoletos.Columns[3].Width = 95;
                this.GridViewVentaBoletos.Columns[3].DefaultCellStyle.Format = "c";
                this.GridViewVentaBoletos.Columns[4].Width = 95;
                this.GridViewVentaBoletos.Columns[4].DefaultCellStyle.Format = "c";
                this.GridViewVentaBoletos.Columns[5].Width = 95;
                this.GridViewVentaBoletos.Columns[5].DefaultCellStyle.Format = "c";
                this.GridViewVentaBoletos.Columns[6].Width = 50;
                this.GridViewVentaBoletos.Columns[7].Width = 240;
                this.GridViewVentaBoletos.Columns[8].Width = 240;
                this.GridViewVentaBoletos.Columns[9].Width = 120;
                this.GridViewVentaBoletos.Columns[10].Visible = false;
                this.GridViewVentaBoletos.Columns[11].Visible = false;
                this.GridViewVentaBoletos.Columns[12].Visible = false;
                this.GridViewVentaBoletos.Columns[13].Visible = false;
                this.GridViewVentaBoletos.Columns[14].Visible = false;
                this.GridViewVentaBoletos.Columns[15].Visible = false;
                this.GridViewVentaBoletos.Columns[16].Visible = false;
                this.GridViewVentaBoletos.Columns[17].Visible = false;
                this.GridViewVentaBoletos.Columns[18].Visible = false;
                this.GridViewVentaBoletos.Columns[19].Visible = false;
                this.GridViewVentaBoletos.Columns[20].Visible = false;
                this.GridViewVentaBoletos.Columns[21].Visible = false;
                this.GridViewVentaBoletos.Columns[22].Visible = false;
                this.GridViewVentaBoletos.Columns[23].Visible = false;
                this.GridViewVentaBoletos.Columns[24].Visible = false;
                this.GridViewVentaBoletos.Columns[25].Visible = false;
                this.GridViewVentaBoletos.Columns[26].Visible = false;
                this.GridViewVentaBoletos.Columns[27].Visible = false;
                this.GridViewVentaBoletos.Columns[28].Visible = false;
                this.GridViewVentaBoletos.Columns[29].Visible = false;
                this.GridViewVentaBoletos.Columns[30].Visible = false;
                //this.GridViewVentaBoletos.Columns[31].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void RecorrerForGridViewVentaBoletos(List<string> campos, int opcion)
        {
            for (var index = 0; index < campos.Count; index++)
            {
                if (opcion == 1)
                    this.HeaderTextGridViewVentaBoletos(index, campos[index]);
                else if (opcion == 2)
                    this.NameGridViewVentaBoletos(index, campos[index]);
                else if (opcion == 3)
                    this.DataPropertyNameGridViewVentaBoletos(index, campos[index]);
            }
        }
        private void HeaderTextGridViewVentaBoletos(int numColum, string nombre)
        {
            try
            {
                this.GridViewVentaBoletos.Columns[numColum].HeaderText = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void NameGridViewVentaBoletos(int numColum, string nombre)
        {
            try
            {
                this.GridViewVentaBoletos.Columns[numColum].Name = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void DataPropertyNameGridViewVentaBoletos(int numColum, string nombre)
        {
            try
            {
                this.GridViewVentaBoletos.Columns[numColum].DataPropertyName = nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<DataGridViewRow> ObtenerFilaSeleccionadaGridViewVentaBoletos()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in GridViewVentaBoletos.Rows)
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
        private bool ValidarFilaSeleccionadaGridViewVentaBoletos(List<DataGridViewRow> rowSelected)
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

        private void backgroundWorkerVenta_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (this.SegundosTiempoVenta >= 180)
                {
                    TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
                }
                else if (_stopTiempoVenta == false)
                {
                    this.SegundosTiempoVenta = SegundosTiempoVenta + 1;
                    TiempoVenta = DateTime.Parse(DateTime.Now.ToShortDateString(), CultureInfo.CurrentCulture);
                    TiempoVenta = TiempoVenta.AddSeconds(180);
                    TiempoVenta = TiempoVenta.AddSeconds(this.SegundosTiempoVenta * -1);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void backgroundWorkerVenta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.Txt_TiempoVenta.Text = this.TiempoVenta.ToString("mm:ss");
                if (this.SegundosTiempoVenta >= 180)
                {
                    this.Close();
                }
                ReglasBotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema tiene que Cerrarse, no se cuenta con internet", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void timerVenta_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.backgroundWorkerVenta.IsBusy)
                    this.backgroundWorkerVenta.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema tiene que Cerrarse, no se cuenta con internet", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarClienteV2 catBuscarCliente = new frmBuscarClienteV2();
                catBuscarCliente.ShowDialog();
                if (catBuscarCliente.getBanDatos())
                {
                    this.TxtIdCliente = catBuscarCliente.getCliente().IDCliente.ToString();
                    this.TxtNombreCliente.Text = catBuscarCliente.getCliente().NombreCompleto.ToString();
                    this.TxtCodigoCliente.Text = catBuscarCliente.getCliente().IDCodigoEab.ToString();
                    this.InfoVentaBoletosAux.Monedero = Convert.ToSingle(catBuscarCliente.getCliente().Monedero.Value);
                }
                else
                {
                    this.TxtIdCliente = "";
                    this.TxtNombreCliente.Text = null;
                    this.TxtCodigoCliente.Text = null;
                    this.InfoVentaBoletosAux.Monedero = 0.0F;

                }
                catBuscarCliente.Dispose();
                this.InfoVentaBoletosAux.id_cliente = this.TxtIdCliente;
                this.CalcularTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
