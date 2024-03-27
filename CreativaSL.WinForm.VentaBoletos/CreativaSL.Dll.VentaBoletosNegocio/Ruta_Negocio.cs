using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Ruta_Negocio
    {
        public Ruta llenarComboTerminales(Ruta ruta)
        {
            try
            {
                Ruta_Datos rd = new Ruta_Datos();
                return rd.llenarComboTerminales(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarRuta(Ruta ruta)
        {
            try
            {
                if (string.IsNullOrEmpty(ruta.id_terminalOrigen))
                    throw new Exception("Seleccione la terminal Origen");
                if (string.IsNullOrEmpty(ruta.id_terminalDestino))
                    throw new Exception("Seleccione la terminal Destino");
                if (ruta.tiempo_minutos <= 0)
                    throw new Exception("Ingrese un tiempo válido: 99:59");
                Ruta_Datos rd = new Ruta_Datos();
                rd.agregarRuta(ruta);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void modificarRuta(Ruta ruta)
        {
            try
            {
                if (string.IsNullOrEmpty(ruta.id_terminalOrigen))
                    throw new Exception("Seleccione la terminal Origen");
                if (string.IsNullOrEmpty(ruta.id_terminalDestino))
                    throw new Exception("Seleccione la terminal Destino");
                if (ruta.tiempo_minutos <= 0)
                    throw new Exception("Ingrese un tiempo válido: 99:59");
                Ruta_Datos rd = new Ruta_Datos();
                rd.modifcarRuta(ruta);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void EliminarRuta(ref int identificador, Ruta ruta)
        {
            try
            {
                Ruta_Datos rd = new Ruta_Datos();
                rd.EliminarRuta(ref identificador, ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ruta obtenerRutasPrincipales(Ruta ruta)
        {
            try
            {
                Ruta_Datos rd = new Ruta_Datos();
                return rd.obtenerRutasPrincipales(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ruta obtenerRutasIntermedias(Ruta ruta)
        {
            try
            {
                Ruta_Datos rd = new Ruta_Datos();
                return rd.obtenerRutasIntermedias(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ruta obtenerRutas(Ruta ruta)
        {
            try
            {
                Ruta_Datos rd = new Ruta_Datos();
                return rd.obtenerRutas(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ruta obtenerComboRutas(Ruta ruta)
        {
            try
            {
                Ruta_Datos rd = new Ruta_Datos();
                return rd.obtenerComboRutas(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ruta Obtener_RutasxIDRuta(Ruta ruta)
        {
            try
            {
                Ruta_Datos rd = new Ruta_Datos();
                return rd.Obtener_RutasxIDRuta(ruta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Ruta Obtener_RutasxIDRutaTodas(Ruta rutanuevaviaje)
        {
            try
            {
                Ruta_Datos rd = new Ruta_Datos();
                return rd.Obtener_RutasxIDRutaTodas(rutanuevaviaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
