using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.WinForm.VentaBoletos
{
    public class MaterialUI
    {
        public static MaterialSkinManager loadMaterial(MaterialForm actualForm)
        {
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(actualForm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900,Primary.Blue500, Accent.Indigo700,TextShade.WHITE);
            return materialSkinManager;
        }
    }
}
