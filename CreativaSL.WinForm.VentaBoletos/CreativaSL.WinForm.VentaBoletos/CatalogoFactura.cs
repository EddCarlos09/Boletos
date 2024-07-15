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
using System.Data.SqlClient;
using CreativaSL.Dll.VentaBoletosGlobal;

namespace CreativaSL.WinForm.VentaBoletos
{
    public partial class CatalogoFactura : MaterialForm
    {
        public CatalogoFactura()
        {
            InitializeComponent();
            LoadFacturas();
        }

        private void LoadFacturas()
        {
          
            string connectionString = Comun.Conexion;

  
            string query = "sp_GetFacturas";

      
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                
                    connection.Open();

          
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                  
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

     
                        DataTable dataTable = new DataTable();

                 
                        adapter.Fill(dataTable);

                   
                        dtgvFactura.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                
                    MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvFactura.SelectedRows.Count > 0)
            {
                
                int selectedId = Convert.ToInt32(dtgvFactura.SelectedRows[0].Cells["Id"].Value);

                
                DeleteFactura(selectedId);

           
                LoadFacturas();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una factura para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DeleteFactura(int id)
        {
            string connectionString = Comun.Conexion;
            string query = "sp_DeleteFactura";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
