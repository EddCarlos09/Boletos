using System;
using System.Collections.Generic;
using System.Text;
using CreativaSL.Dll.VentaBoletosGlobal;
using Microsoft.ApplicationBlocks.Data;

namespace CreativaSL.Dll.VentaBoletosDatos
{
    public class DisenioCamionDatos
    {

        public DisenioCamion AgregarCamionDiseño(DisenioCamion diseño)
        {
            string idControl = SqlHelper.ExecuteScalar(diseño.Conexion, "" ).ToString();

            if (idControl == "")
            {
                throw new Exception("No se pudo agregar el Diseño de Camion");
            }

            diseño.idDisenio = idControl;
            return diseño;
                  
        }

        public void ModificarCamionDiseño(DisenioCamion diseño)
        {
            if (SqlHelper.ExecuteNonQuery(diseño.Conexion, "") <= 0)
            {
                throw new Exception("No se pudo Modificar el Diseño de Camion");
            }

        }

        public void EliminarCamionDiseño(DisenioCamion diseño)
        {
            if (SqlHelper.ExecuteNonQuery(diseño.Conexion, "") <= 0)
            {
                throw new Exception("No se pudo Eliminar el Diseño de Camion");
            }

        }

        public void ObtenerCamionDiseño(DisenioCamion diseño)
        {
            if (SqlHelper.ExecuteNonQuery(diseño.Conexion, "") <= 0)
            {
                throw new Exception("No se pudo Eliminar el Diseño de Camion");
            }

        }


    }
}
