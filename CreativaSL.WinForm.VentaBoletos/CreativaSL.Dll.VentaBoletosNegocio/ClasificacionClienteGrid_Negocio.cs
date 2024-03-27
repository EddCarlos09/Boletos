using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    /*
    public class ClasificacionClienteGrid_Negocio : INotifyPropertyChanged
    {
        #region Propiedades / Variables globales
        public string Conexion { get; set; }
        private TipoBusqueda _ItemTipoBusqueda;
        public TipoBusqueda ItemTipoBusqueda
        {
            get { return _ItemTipoBusqueda; }
            set
            {
                if (_ItemTipoBusqueda == value) return;
                _ItemTipoBusqueda = value;
                OnPropertyChanged("ItemTipoBusqueda");
            }
        }
        private string _TextoBusqueda;
        public string TextoBusqueda
        {
            get { return _TextoBusqueda; }
            set
            {
                if (_TextoBusqueda == value) return;
                _TextoBusqueda = value;
                OnPropertyChanged("TextoBusqueda");
            }
        }
        public BindingList<ClasificacionCliente> ListaClasificacionClienteBL { get; set; }
        private int Pagina { get; set; }
        private int MaxRows { get; set; }
        private int TotalRecords { get; set; }
        private int TotalPages { get { return (TotalRecords / MaxRows) + (((TotalRecords % MaxRows) > 0) ? 1 : 0); } }
        public bool EsBusqueda { get; set; }

        #endregion

        #region Constructor

        public ClasificacionClienteGrid_Negocio(string _Conexion)
        {
            try
            {
                Conexion = _Conexion;
                Pagina = 1;
                MaxRows = 40;
                TotalRecords = 0;
                EsBusqueda = false;
                ItemTipoBusqueda = new TipoBusqueda();
                TextoBusqueda = string.Empty;
                ListaClasificacionClienteBL = new BindingList<ClasificacionCliente>(new List<ClasificacionCliente>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos

        public void Reset()
        {
            try
            {
                Pagina = 1;
                ListaClasificacionClienteBL.Clear();
                ClasificacionCliente_Datos RegionDatos = new ClasificacionCliente_Datos();
                //TotalRecords = RegionDatos.ObtenerTotalRecordsQuery(Conexion, EsBusqueda, ItemTipoBusqueda.IDTipoBusqueda, TextoBusqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public void NextPage()
        //{
        //    try
        //    {
        //        Pagina++;
        //        if (Pagina <= TotalPages)
        //        {
        //            LlenarLista(ObtenerDatosClientesXPagina());
        //            //Pagina++;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void LlenarLista(List<ClasificacionCliente> ListaClasificacionClientes)
        {
            try
            {
                if (ListaClasificacionClientes.Count > 0)
                {
                    foreach (var Item in ListaClasificacionClientes)
                    {
                        ListaClasificacionClienteBL.Add(Item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ClasificacionCliente> ObtenerDatosClasificacionClientesXPagina()
        {
            try
            {
                ClasificacionCliente_Datos RegionDatos = new ClasificacionCliente_Datos();
                List<ClasificacionCliente> ListaClientes = RegionDatos.ObtenerClasificacionClienteXPagina(Conexion, Pagina, MaxRows, EsBusqueda, ItemTipoBusqueda.IDTipoBusqueda, TextoBusqueda);
                return ListaClientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TipoBusqueda> ObtenerMenuTipoBusqueda()
        {
            try
            {
                List<TipoBusqueda> Lista = new List<TipoBusqueda>
                {
                    new TipoBusqueda { IDTipoBusqueda = 1, Descripcion = "Descripcion" },
                    new TipoBusqueda { IDTipoBusqueda = 2, Descripcion = "Porcentaje" }
                };
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RestaurarPagina()
        {
            try
            {
                if (Pagina > 1)
                    Pagina--;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region InotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion  
    }
    */
}