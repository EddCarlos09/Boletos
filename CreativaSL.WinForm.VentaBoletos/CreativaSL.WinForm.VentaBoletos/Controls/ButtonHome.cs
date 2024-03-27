using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.WinForm.VentaBoletos.Controls
{
    public partial class ButtonHome: SfButton
    {
        public ButtonHome()
        {
            Style.BackColor = Color.FromArgb(65, 95, 153);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
        }
    }
}
