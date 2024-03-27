using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Camion_Negocio
    {
        public Camion obtener_tiposCamiones(Camion camion)
        {
            try
            {
                Camion_Datos cd = new Camion_Datos();
                return cd.obtener_tiposCamiones(camion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Camion obtener_marcas(Camion camion)
        {
            try
            {
                Camion_Datos cd = new Camion_Datos();
                return cd.obtener_marcas(camion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Camion obtener_submarcasxmarca(Camion camion)
        {
            try
            {
                Camion_Datos cd = new Camion_Datos();
                return cd.obtener_submarcasxmarca(camion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Camion obtener_diseniosCamiones(Camion camion)
        {
            try
            {
                Camion_Datos cd = new Camion_Datos();
                return cd.obtener_diseniosCamiones(camion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarCamion(Camion camion)
        {
            try
            {
                if (camion.id_Tipocamion <= 0)
                    throw new Exception("Seleccione un tipo de camion");
                if (camion.id_marca <= 0)
                    throw new Exception("Seleccione una marca del camion");
                if (camion.id_submarca <= 0)
                    throw new Exception("Seleccione un modelo de camion");
                if (string.IsNullOrWhiteSpace(camion.num_camion))
                    throw new Exception("Ingrese el número del camion");
                if (string.IsNullOrWhiteSpace(camion.descripcion))
                    throw new Exception("Ingrese la descripcion del camion");
                if (string.IsNullOrWhiteSpace(camion.caracteristicas))
                    throw new Exception("Ingrese las características del camion");
                if (string.IsNullOrWhiteSpace(camion.id_diseniocamion))
                    throw new Exception("Seleccione un diseño del camion");
                Camion_Datos cd = new Camion_Datos();
                cd.registrarCamion(camion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Camion obtenerCamiones(Camion camion)
        {
            try
            {
                Camion_Datos cd = new Camion_Datos();
                return cd.obtenerCamiones(camion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarCamion(ref int identificador, Camion camion)
        {
            try
            {
                Camion_Datos cd = new Camion_Datos();
                cd.EliminarCamion(ref identificador, camion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarCamion(Camion camion)
        {
            try
            {
                if (camion.id_Tipocamion <= 0)
                    throw new Exception("Seleccione un tipo de camion");
                if (camion.id_marca <= 0)
                    throw new Exception("Seleccione una marca del camion");
                if (camion.id_submarca <= 0)
                    throw new Exception("Seleccione un modelo de camion");
                if (string.IsNullOrWhiteSpace(camion.num_camion))
                    throw new Exception("Ingrese el número del camion");
                if (string.IsNullOrWhiteSpace(camion.descripcion))
                    throw new Exception("Ingrese la descripcion del camion");
                if (string.IsNullOrWhiteSpace(camion.caracteristicas))
                    throw new Exception("Ingrese las características del camion");
                if (string.IsNullOrWhiteSpace(camion.id_diseniocamion))
                    throw new Exception("Seleccione un diseño del camion");
                Camion_Datos cd = new Camion_Datos();
                cd.modificarCamion(camion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Camion obtenerCamionesCombo(Camion camiones)
        {
            try
            {
                Camion_Datos cd = new Camion_Datos();
                return cd.obtenerCamionesCombo(camiones);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ObtenerDatosCamion(string Conexion, ref System.Data.DataTable DatosCamion, string IDDiseñoCamion)
        {
            try
            {
                Camion_Datos cd = new Camion_Datos();
                cd.ObtenerDatosCamion(Conexion, ref DatosCamion, IDDiseñoCamion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
