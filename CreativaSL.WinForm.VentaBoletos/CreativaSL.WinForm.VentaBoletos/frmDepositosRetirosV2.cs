﻿using MaterialSkin.Controls;
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
    public partial class frmDepositosRetirosV2 : MaterialForm
    {
        public frmDepositosRetirosV2()
        {
            InitializeComponent();
            loadMaterial(this);
        }

        private void frmDepositosRetirosV2_Load(object sender, EventArgs e)
        {

        }
    }
}