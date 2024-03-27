using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.WinForm.VentaBoletos.ClasesAux;

namespace CreativaSL.WinForm.VentaBoletos.Controls
{
    class CSLDataGridView : DataGridView
    {
        public CSLDataGridView()
        {
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
        }

        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                base.OnCellFormatting(e);
                Comun.BindingDataGridView(this, e);
            }
            catch (Exception ex)
            {
                LogError.AddExcFileTxt(ex, "CSLDataGridView ~ OnCellFormatting");
                MessageBox.Show("Se ha generado el siguiente error: " + Environment.NewLine + ex.Message + Environment.NewLine + "Contacte a soporte técnico.", "Conagro Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public event EventHandler ScrollMax;

        protected override void OnScroll(ScrollEventArgs e)
        {
            try
            {
                base.OnScroll(e);
                if (Comun.PaginacionDataGridView(this, e))
                {
                    //Lanzar el evento onScrollTop
                    OnScrollMax(e);
                }
            }
            catch (Exception ex)
            {
                LogError.AddExcFileTxt(ex, "CSLDataGridView ~ OnScroll");
                MessageBox.Show("Se ha generado el siguiente error: " + Environment.NewLine + ex.Message + Environment.NewLine + "Contacte a soporte técnico.", "Conagro Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void OnScrollMax(EventArgs e)
        {
            ScrollMax?.Invoke(this, e);
        }
    }
}
