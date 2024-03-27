using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Terminal_Negocio
    {
        public Terminal llenarGridPaises(Terminal datos)
        {
            try
            {
                Terminal_Datos td = new Terminal_Datos();
                return td.llenarGridPaises(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Terminal llenarGridEstados(Terminal datos)
        {
            try
            {
                Terminal_Datos td = new Terminal_Datos();
                return td.llenarGridEstados(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Terminal llenarGridMunicipios(Terminal datos)
        {
            try
            {
                Terminal_Datos td = new Terminal_Datos();
                return td.llenarGridMunicipios(datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void registrarTerminal(Terminal terminal)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(terminal.nombre))
                    throw new Exception("Escriba el nombre de la terminal");
                if (terminal.id_pais == 0)
                    throw new Exception("Seleccione un país");
                if (terminal.id_estado == 0)
                    throw new Exception("Seleccione un estado");
                if (terminal.id_municipio == 0)
                    throw new Exception("Seleccione un municipio");

                Terminal_Datos td = new Terminal_Datos();
                td.registrarTerminal(terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Terminal obtenerTerminales(Terminal terminal)
        {
            try
            {
                Terminal_Datos td = new Terminal_Datos();
                return td.obtenerTerminales(terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarTerminal(ref int identificador, Terminal terminal)
        {
            try
            {
                Terminal_Datos td = new Terminal_Datos();
                td.EliminarTerminal(ref identificador, terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarTerminal(Terminal terminal)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(terminal.nombre))
                    throw new Exception("Escriba el nombre de la terminal");
                if (terminal.id_pais == 0)
                    throw new Exception("Seleccione un país");
                if (terminal.id_estado == 0)
                    throw new Exception("Seleccione un estado");
                if (terminal.id_municipio == 0)
                    throw new Exception("Seleccione un municipio");
                Terminal_Datos td = new Terminal_Datos();
                td.modificarTerminal(terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
