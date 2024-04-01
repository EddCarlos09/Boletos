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
    public partial class FormAdministrador : MaterialForm
    {
        public FormAdministrador()
        {
            InitializeComponent();
            loadMaterial(this);
            
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            // Crear el MaterialTabControl
            MaterialTabControl materialTabControl = this.materialTabControl1;
            //this.TopMost = true;
           

            // Crear el MaterialListView
            MaterialListView materialListView = new MaterialListView();
            materialListView.Dock = DockStyle.Fill;
            materialListView.AutoSizeTable = true;

            // Configurar el MaterialListView
            //materialListView.BorderStyle = BorderStyle.None;
            //materialListView.FullRowSelect = true;

            

            // Agregar columnas al MaterialListView
            materialListView.Columns.Add("Columna1");
            materialListView.Columns.Add("Columna2");

            // Agregar elementos al MaterialListView
            materialListView.Items.Add(new ListViewItem(new[] { "Elemento 1", "Subítem 1" }));
            materialListView.Items.Add(new ListViewItem(new[] { "Elemento 2", "Subítem 2" }));
            materialListView.Items.Add(new ListViewItem(new[] { "Elemento 3", "Subítem 3" }));

            materialTabControl.TabPages[2].Controls.Add(materialListView);
            // Agregar el MaterialListView al formulario

            // Controls.Add(materialListView);
        }
    }
}
