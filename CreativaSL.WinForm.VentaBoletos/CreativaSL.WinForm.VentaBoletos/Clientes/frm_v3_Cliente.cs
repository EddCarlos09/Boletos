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

namespace CreativaSL.WinForm.VentaBoletos.Clientes
{
    public partial class frm_v3_Cliente : MaterialForm
    {
        public frm_v3_Cliente()
        {
            InitializeComponent();
            loadMaterial(this);
        }
    }
}
