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
    public partial class frmCatDiseñoCamion : Form
    {
        private DataTable DatosCamion;
        private int numPiso;
        public DataTable Datos_Camion
        {
            get { return DatosCamion; }
            set { DatosCamion = value; }
        }
        #region Constructor
        public frmCatDiseñoCamion(int numpiso)
        {
            try
            {
                InitializeComponent();
                this.numPiso = numpiso;
                if (numpiso == 1) txtPiso.Text = "Primer Piso"; else if (numpiso == 2) txtPiso.Text = "Segundo Piso";
                InicializarCrear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public frmCatDiseñoCamion(int numpiso, DataTable DatosCamion)
        {
            try
            {
                InitializeComponent();
                this.numPiso = numpiso;
                this.DatosCamion = DatosCamion;
                if (numpiso == 1) txtPiso.Text = "Primer Piso"; else if (numpiso == 2) txtPiso.Text = "Segundo Piso";
                InicializarEditar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void frmCatDiseñoCamion_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion
        #region Metodos Generales
        private void InicializarEditar()
        {
            try
            {
                string Numero;
                PictureBox PictureBoxAux;
                TextBox TextBoxAux;
                foreach (DataRow row in this.DatosCamion.Rows)
                {
                    if (Convert.ToInt32(row["idTipoObj"]) == 1 && Convert.ToInt32(row["numPiso"]) == numPiso)
                    {
                        PictureBoxAux = (PictureBox)this.FindControl(this, row["descripcion"].ToString());
                        Numero = PictureBoxAux.Name.Replace("asiento", "");
                        PictureBoxAux.Tag = "1";
                        PictureBoxAux.BackColor = Color.Gainsboro;
                        PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.disponible;
                        TextBox TextAux = (TextBox)this.FindControl(this, "pasilloasiento" + Numero);
                        if (TextAux.Text.ToString().Equals("TV"))
                        {
                            TextAux.Text = " " + "TV";
                        }
                        TextAux.Text = row["indice"].ToString() + TextAux.Text;  
                    }
                    else if (Convert.ToInt32(row["idTipoObj"]) == 3 && Convert.ToInt32(row["numPiso"]) == numPiso)
                    {
                        PictureBoxAux = (PictureBox)this.FindControl(this, row["descripcion"].ToString());
                        Numero = PictureBoxAux.Name.Replace("asiento", "");
                        PictureBoxAux.Tag = "1";
                        PictureBoxAux.BackColor = Color.GreenYellow;
                        PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.wc;
                        TextBox TextAux = (TextBox)this.FindControl(this, "pasilloasiento" + Numero);
                        if (TextAux.Text.ToString().Equals("TV"))
                        {
                            TextAux.Text = " " + "TV";
                        }
                        TextAux.Text = row["tipoObj"].ToString() + TextAux.Text; 
                    }
                    else if (Convert.ToInt32(row["idTipoObj"]) == 4 && Convert.ToInt32(row["numPiso"]) == numPiso)
                    {
                        PictureBoxAux = (PictureBox)this.FindControl(this, row["descripcion"].ToString());
                        Numero = PictureBoxAux.Name.Replace("asiento", "");
                        PictureBoxAux.Tag = "1";
                        PictureBoxAux.BackColor = Color.Plum;
                        PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.bar; 
                        TextBox TextAux = (TextBox)this.FindControl(this, "pasilloasiento" + Numero);
                        if (TextAux.Text.ToString().Equals("TV"))
                        {
                            TextAux.Text = " " + "TV";
                        }
                        TextAux.Text = row["tipoObj"].ToString() + TextAux.Text;
                    }
                    else if (Convert.ToInt32(row["idTipoObj"]) == 2 && Convert.ToInt32(row["numPiso"]) == numPiso)
                    {
                        TextBoxAux = (TextBox)this.FindControl(this, "pasilloasiento" + row["indice"].ToString());
                        TextBoxAux.Text = TextBoxAux.Text + " " + row["tipoObj"].ToString();
                        TextBoxAux.BackColor = Color.Silver;
                    }
                    else if (Convert.ToInt32(row["idTipoObj"]) == 5 && Convert.ToInt32(row["numPiso"]) == numPiso)
                    {
                        PictureBoxAux = (PictureBox)this.FindControl(this, row["descripcion"].ToString());
                        PictureBoxAux.Tag = "1";
                        PictureBoxAux.BackColor = Color.Gainsboro;
                        PictureBoxAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.puerta;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void InicializarCrear()
        {
            try
            {
                this.DatosCamion = new DataTable();
                this.DatosCamion.Columns.Add("indice", typeof(int));
                this.DatosCamion.Columns.Add("idTipoObj", typeof(int));
                this.DatosCamion.Columns.Add("tipoObj", typeof(string));
                this.DatosCamion.Columns.Add("descripcion", typeof(string));
                this.DatosCamion.Columns.Add("numPiso", typeof(int));
                this.DatosCamion.Columns.Add("idStatus", typeof(int));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool BuscarAsientoDataTable(int Asiento)
        {
            try
            {
                foreach (DataRow row in this.DatosCamion.Rows)
                {
                    if (Convert.ToInt32(row["indice"]) == Asiento && Convert.ToInt32(row["idTipoObj"]) == 1)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void AgregarDataTable(Object[] Datos)
        {
            try
            {
                this.DatosCamion.Rows.Add(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void EliminarDataTable(string descripcion)
        {
            try
            {
                foreach (DataRow row in this.DatosCamion.Rows)
                {
                    if (row["descripcion"].ToString().Equals(descripcion))
                    {
                        this.DatosCamion.Rows.Remove(row);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AsignarGenerico(PictureBox PicAux)
        {
            try
            {
                string Numero;
                if (!PicAux.Tag.Equals("1"))
                {
                    frmTipoObjeto frmt = new frmTipoObjeto();
                    if (frmt.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (frmt.Tipoobjeto == 1)
                        {
                            if (!this.BuscarAsientoDataTable(frmt.Numeroasiento))
                            {
                                this.AgregarDataTable(new Object[] { frmt.Numeroasiento, frmt.Tipoobjeto, "Asiento", PicAux.Name, numPiso , 0});
                                Numero = PicAux.Name.Replace("asiento", "");
                                PicAux.Tag = "1";
                                PicAux.BackColor = Color.Gainsboro;
                                PicAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.disponible;
                                TextBox TextAux = (TextBox)this.FindControl(this, "pasilloasiento" + Numero);
                                if (TextAux.Text.ToString().Equals("TV"))
                                {
                                    TextAux.Text = " " + "TV";
                                }
                                TextAux.Text = frmt.Numeroasiento.ToString() + TextAux.Text;
                                TextAux.Focus();
                            }
                            else
                            {
                                MessageBox.Show("El Asiento " + frmt.Numeroasiento.ToString() + " ya esta asignado", "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (frmt.Tipoobjeto == 3)
                        {
                            this.AgregarDataTable(new Object[] { frmt.Numeroasiento, frmt.Tipoobjeto, "WC", PicAux.Name, numPiso, 0 });
                            Numero = PicAux.Name.Replace("asiento", "");
                            PicAux.Tag = "1";
                            PicAux.BackColor = Color.GreenYellow;
                            PicAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.wc;
                            TextBox TextAux = (TextBox)this.FindControl(this, "pasilloasiento" + Numero);
                            if (TextAux.Text.ToString().Equals("TV"))
                            {
                                TextAux.Text = " " + "TV";
                            }
                            TextAux.Text = "WC" + TextAux.Text;
                            TextAux.Focus();
                        }
                        else if (frmt.Tipoobjeto == 4)
                        {
                            this.AgregarDataTable(new Object[] { frmt.Numeroasiento, frmt.Tipoobjeto, "BAR", PicAux.Name, numPiso, 0 });
                            Numero = PicAux.Name.Replace("asiento", "");
                            PicAux.Tag = "1";
                            PicAux.BackColor = Color.Plum;
                            PicAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.bar;
                            TextBox TextAux = (TextBox)this.FindControl(this, "pasilloasiento" + Numero);
                            if (TextAux.Text.ToString().Equals("TV"))
                            {
                                TextAux.Text = " " + "TV";
                            }
                            TextAux.Text = "BAR" + TextAux.Text;
                            TextAux.Focus();
                        }
                    }
                }
                else
                {
                    PicAux.Tag = "0";
                    PicAux.BackColor = Color.White;
                    PicAux.Image = null;
                    Numero = PicAux.Name.Replace("asiento", "");
                    TextBox TextAux = (TextBox)this.FindControl(this, "pasilloasiento" + Numero);
                    if (TextAux.Text.Contains("TV"))
                        TextAux.Text = "TV";
                    else
                        TextAux.Text = "";
                    TextAux.Focus();
                    this.EliminarDataTable(PicAux.Name);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AsignarTV(TextBox TextAux)
        {
            try
            {
                if (TextAux.Text.Contains("TV"))
                {
                    if (TextAux.Text.ToString().Equals("TV"))
                        TextAux.Text = "";
                    else
                        TextAux.Text = TextAux.Text.Replace(" " + "TV", "");
                    TextAux.BackColor = Color.Gainsboro;
                    TextAux.Focus();
                    this.EliminarDataTable(TextAux.Name);
                }
                else
                {
                    TextAux.Text = TextAux.Text + " " + "TV";
                    TextAux.BackColor = Color.Silver;
                    TextAux.Focus();
                    this.AgregarDataTable(new Object[] { Convert.ToInt32(TextAux.Name.Replace("pasilloasiento", "")), 2, "TV", TextAux.Name, numPiso, 0 });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AsignarPuertas(PictureBox PicAux)
        {
            try
            {
                if (!PicAux.Tag.Equals("1"))
                {
                    this.AgregarDataTable(new Object[] { Convert.ToInt32(PicAux.Name.Replace("puerta", "")), 5, "Puertas", PicAux.Name, numPiso , 0 });
                    PicAux.Tag = "1";
                    PicAux.BackColor = Color.Gainsboro;
                    PicAux.Image = global::CreativaSL.WinForm.VentaBoletos.Properties.Resources.puerta;
                }
                else
                {
                    PicAux.Tag = "0";
                    PicAux.BackColor = Color.White;
                    PicAux.Image = null;
                    this.EliminarDataTable(PicAux.Name);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Control FindControl(Control root, string target)
        {
            if (root.Name.Equals(target))
                return root;
            for (var i = 0; i < root.Controls.Count; ++i)
            {
                if (root.Controls[i].Name.Equals(target))
                    return root.Controls[i];
            }
            for (var i = 0; i < root.Controls.Count; ++i)
            {
                Control result;
                for (var k = 0; k < root.Controls[i].Controls.Count; ++k)
                {
                    result = FindControl(root.Controls[i].Controls[k], target);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }
        #endregion
        #region Eventos
        private void Asignar_Click(object sender, EventArgs e)
        {
            try
            {
                this.AsignarGenerico((PictureBox) sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void AsignarTV_Click(object sender, EventArgs e)
        {
            try
            {
                this.AsignarTV((TextBox) sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void AsiganarPuertas_Click(object sender, EventArgs e)
        {
            try
            {
                this.AsignarPuertas((PictureBox)sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Punto de Venta CSL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion
    }
}
