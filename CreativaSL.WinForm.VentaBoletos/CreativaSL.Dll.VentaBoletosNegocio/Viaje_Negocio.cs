using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Viaje_Negocio
    {

        public void registrarViaje(Viaje viaje)
        {
            try
            {
                if (string.IsNullOrEmpty(viaje.nombre))
                    throw new Exception("Se requiere un nombre de viaje.");
                if (string.IsNullOrEmpty(viaje.id_ruta))
                    throw new Exception("Seleccione una ruta.");
                if (string.IsNullOrEmpty(viaje.id_camion))
                    throw new Exception("Seleccione un camión.");
                if (viaje.fec_PeriodoFin < viaje.fec_PeriodoIni)
                    throw new Exception("La fecha de fin no puede ser menor a la fecha de inicio.");
                if (viaje.fec_PeriodoFin < DateTime.Parse(DateTime.Today.ToShortDateString()))
                    throw new Exception("La fecha de fin no puede ser menor a la fecha actual.");
                Viaje_Datos vd = new Viaje_Datos();
                vd.registrarViaje(viaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void registrarNuevaFechasViaje(Viaje viaje, ref int Verificador)
        {
            try
            {
                Viaje_Datos vd = new Viaje_Datos();
                vd.registrarNuevaFechasViaje(viaje,ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Viaje obtenerViajes(Viaje viaje)
        {
            try
            {
                Viaje_Datos vd = new Viaje_Datos();
                return vd.obtenerViajes(viaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarViaje(ref int identificador, Viaje viaje)
        {
            try
            {
                Viaje_Datos vd = new Viaje_Datos();
                vd.EliminarViaje(ref identificador, viaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void eliminarFechasViaje(Viaje viaje, ref int Verificador)
        {
            try
            {
                Viaje_Datos vd = new Viaje_Datos();
                vd.eliminarFechasViaje(viaje,ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarViaje(Viaje viaje)
        {
            try
            {
                if (string.IsNullOrEmpty(viaje.nombre))
                    throw new Exception("Se requiere un nombre de viaje.");
                if (string.IsNullOrEmpty(viaje.id_ruta))
                    throw new Exception("Seleccione una ruta.");
                if (string.IsNullOrEmpty(viaje.id_camion))
                    throw new Exception("Seleccione un camión.");
                if (viaje.fec_PeriodoFin < viaje.fec_PeriodoIni)
                    throw new Exception("La fecha de fin no puede ser menor a la fecha de inicio.");
                if (viaje.fec_PeriodoFin < DateTime.Parse(DateTime.Today.ToShortDateString()))
                    throw new Exception("La fecha de fin no puede ser menor a la fecha actual.");
                if (viaje.id_tipoViaje != 3)
                {
                    if (
                       viaje.lunes == false
                       && viaje.martes == false
                       && viaje.miercoles == false
                       && viaje.jueves == false
                       && viaje.viernes == false
                       && viaje.sabado == false
                       && viaje.domingo == false
                       )
                        throw new Exception("Seleccione al menos un día de salida.");
                }
                Viaje_Datos vd = new Viaje_Datos();
                vd.modificarViaje(viaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Viaje llenarComboViajes(Viaje viajes)
        {
            try
            {
                Viaje_Datos vd = new Viaje_Datos();
                return vd.llenarComboViajes(viajes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Viaje obtenerHorarios(Viaje horarios)
        {
            try
            {
                Viaje_Datos vd = new Viaje_Datos();
                return vd.obtenerHorarios(horarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Viaje obtenerViajesXFechas(string Conexion, Viaje viaje, DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            try
            {
                Viaje_Datos vd = new Viaje_Datos();
                return vd.obtenerViajesXFechas(viaje, Fecha_Inicio, Fecha_Fin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarRutaViaje(Viaje viajePrincipalViejo, Viaje viajeprincipal, ref int Verificador)
        {
            try
            {
                Viaje_Datos vd = new Viaje_Datos();
                vd.modificarRutaViaje(viajePrincipalViejo, viajeprincipal, ref Verificador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string NEWID(string Conexion)
        {
            try
            {
                Viaje_Datos vd = new Viaje_Datos();
                return vd.NEWID(Conexion);
            }
            catch (Exception ex)
            {
                return Guid.NewGuid().ToString();
            }
        }
    }
}
