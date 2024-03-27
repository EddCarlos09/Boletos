using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class V2ClienteGrid_Negocio : INotifyPropertyChanged
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
        public BindingList<V2Cliente> ListaClientesBL { get; set; }
        private int Pagina { get; set; }
        private int MaxRows { get; set; }
        private int TotalRecords { get; set; }
        private int TotalPages { get { return (TotalRecords / MaxRows) + (((TotalRecords % MaxRows) > 0) ? 1 : 0); } } 
        public bool EsBusqueda { get; set; }

        #endregion

        #region Constructor

        public V2ClienteGrid_Negocio(string _Conexion)
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
                ListaClientesBL = new BindingList<V2Cliente>(new List<V2Cliente>());
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
                ListaClientesBL.Clear();
                V2Cliente_Datos RegionDatos = new V2Cliente_Datos();
                TotalRecords = RegionDatos.ObtenerTotalRecordsQuery(Conexion, EsBusqueda, ItemTipoBusqueda.IDTipoBusqueda, TextoBusqueda);   
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
                if (Pagina <= TotalPages)
                {                    
                    LlenarLista(ObtenerDatosClientesXPagina());
                    //Pagina++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarLista(List<V2Cliente> ListaClientes)
        {
            try
            {
                if (ListaClientes.Count > 0)
                {
                    foreach (var Item in ListaClientes)
                    {
                        ListaClientesBL.Add(Item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<V2Cliente> ObtenerDatosClientesXPagina()
        {
            try
            {
                V2Cliente_Datos RegionDatos = new V2Cliente_Datos();
                List<V2Cliente> ListaClientes = RegionDatos.ObtenerClientesXPagina(Conexion, Pagina, MaxRows, EsBusqueda, ItemTipoBusqueda.IDTipoBusqueda, TextoBusqueda);
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
                    new TipoBusqueda { IDTipoBusqueda = 1, Descripcion = "Nombre" },
                    new TipoBusqueda { IDTipoBusqueda = 2, Descripcion = "Codigo Credencial" }
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
}
