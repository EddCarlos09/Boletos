using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativaSL.WinForm.VentaBoletos
{
    public static class buttonRadius
    {
        public static void SetButtonRoundBorder(Button button, int borderRadius)
        {
            // Crear una región con bordes redondeados
            GraphicsPath path = new GraphicsPath();
            path.AddArc(button.Width - borderRadius, -1, borderRadius, borderRadius, 270, 90); //ezquina superior derecho
            path.AddArc(button.Width - borderRadius, button.Height - borderRadius, borderRadius, borderRadius, 0, 90); // ezquina inferior derecho
            path.AddArc(-1, button.Height - borderRadius, borderRadius, borderRadius, 100, 90); // //eszuina inferior izquierdo
            path.AddArc(-1, -1, borderRadius, borderRadius, 180, 90);   //eszuina superios izquierdo
            path.CloseFigure();

            button.Region = new Region(path);
        }

    }
}
