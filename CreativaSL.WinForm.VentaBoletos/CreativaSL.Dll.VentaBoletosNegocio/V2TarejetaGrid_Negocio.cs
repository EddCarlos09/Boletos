using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System.Data;
using System.ComponentModel;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class V2TarejetaGrid_Negocio
    {
        #region Propiedades / Variables globales
        public string Conexion { get; set; }
        public BindingList<V2Tarjeta> ListaTarjetaBL { get; set; }
        private int Pagina { get; set; }
        private int MaxRows { get; set; }
        //private int TotalRecords { get; set; }
        //private int TotalPages { get { return (TotalRecords / MaxRows) + (((TotalRecords % MaxRows) > 0) ? 1 : 0); } }

        #endregion
        

        #region Constructor
        V2Tarjeta_Datos tarjeta;
        public V2TarejetaGrid_Negocio()
        {
            try
            {
                tarjeta = new V2Tarjeta_Datos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public V2TarejetaGrid_Negocio(string _Conexion)
        {
            try
            {
                Conexion = _Conexion;
                Pagina = 1;
                MaxRows = 40;
                //TotalRecords = 0;
                ListaTarjetaBL = new BindingList<V2Tarjeta>(new List<V2Tarjeta>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        #region Metodos
        public List<V2Tarjeta> ObtenerDatosClientesXPagina()
        {
            try
            {
                V2Tarjeta_Datos RegionDatos = new V2Tarjeta_Datos();
                List<V2Tarjeta> ListaTarjetas = RegionDatos.ObtenerClientesXPagina(Conexion, Pagina, MaxRows);
                return ListaTarjetas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<V2Tarjeta> ObtenerDatosTarjetaXPagina()
        {
            try
            {
                V2Tarjeta_Datos RegionDatos = new V2Tarjeta_Datos();
                List<V2Tarjeta> ListaTarjetas = RegionDatos.ObtenerTarjetasXPagina(Conexion);
                return ListaTarjetas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void LlenarLista(List<V2Tarjeta> ListaTarjeta)
        {
            try
            {
                if (ListaTarjeta.Count > 0)
                {
                    foreach (var Item in ListaTarjeta)
                    {
                        ListaTarjetaBL.Add(Item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void NextPage()
        {
            try
            {
                Pagina++;
                    LlenarLista(ObtenerDatosClientesXPagina());
                 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerarFolio (ref int Verificador, int cantidad)
        {
            try
            {
                V2Tarjeta_Datos RegionDatos = new V2Tarjeta_Datos();
                RegionDatos.GenerarFolio(Conexion, ref Verificador, cantidad);
            }
            catch (Exception ex)
            {
                throw new Exception("Error GenerarFolio" + ex.Message);
            }
        }

        public void LlenarGridTarjeta(string Conexion, ref V2Tarjeta Tarjeta)
        {
            try
            {
                tarjeta.LlenarGridTarjeta(Conexion, ref Tarjeta);
            }
            catch (Exception ex)
            {
                throw new Exception("Error LlenarGridsubMarca" + ex.Message);
            }
        }
        #endregion

    }
}
