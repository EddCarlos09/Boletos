using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class V2Cliente_Negocio
    {
        #region Propiedades

        public V2Cliente Model { get; set; }
        public string Conexion { get; set; }
        public bool NuevoRegistro { get; set; }
        public string UserID { get; set; }
        public BindingList<CatEstados> ListaEstados { get; set; }
        public BindingList<CatMunicipio> ListaMunicipios { get; set; }
        public BindingList<ClasificacionCliente> ListaClasificacion { get; set; }
        #endregion

        #region Constructor

        public V2Cliente_Negocio(string _Conexion, bool _NuevoRegistro, int _ClienteID, string _UserID)
        {
            Conexion = _Conexion;
            NuevoRegistro = _NuevoRegistro;
            UserID = _UserID;
            Model = new V2Cliente { IDCliente = _ClienteID };
            ListaEstados = new BindingList<CatEstados>(new List<CatEstados>());
            ListaMunicipios = new BindingList<CatMunicipio>(new List<CatMunicipio>());
            ListaClasificacion = new BindingList<ClasificacionCliente>(new List<ClasificacionCliente>());
            Iniciar();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Obtener los datos del cliente para su modificación /Jm/02/12/2018
        /// </summary>
        public V2Cliente ObtenerDatosXIDCliente()
        {
            try
            {
                V2Cliente_Datos Datos = new V2Cliente_Datos();
                V2Cliente Aux = new V2Cliente();
                Aux = Datos.ObtenerClientesXID(Conexion, Model.IDCliente);
                return Aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Para activar las notificaciones y se refresque en automático
        /// </summary>
        /// <param name="_Datos">Información del cliente que se obtuvo de la BD</param>
        public void LlenarDatos(V2Cliente _Datos)
        {
            try
            {
                Model.Nombre = _Datos.Nombre;
                Model.Empresa = _Datos.Empresa;
                Model.Domicilio = _Datos.Domicilio;
                Model.Cruces = _Datos.Cruces;
                Model.Colonia = _Datos.Colonia;
                Model.CodigoPostal = _Datos.CodigoPostal;
                Model.IDEstado = _Datos.IDEstado;
                Model.IDMunicipio = _Datos.IDMunicipio;
                Model.Email = _Datos.Email;
                Model.RFC = _Datos.RFC;
                Model.FechaNacimiento = _Datos.FechaNacimiento;
                Model.Telefono = _Datos.Telefono;
                Model.TelefonoCelular = _Datos.TelefonoCelular;
                Model.CodigoTarjeta = _Datos.CodigoTarjeta;
                Model.Clasificacion = _Datos.Clasificacion;
                Model.ReferidoPor = _Datos.ReferidoPor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Guardar los datos del modelo actual
        /// </summary>
        public int GuardarDatos()
        {
            try
            {
                V2Cliente_Datos Datos = new V2Cliente_Datos();
                //int Result = Datos.GuardarPerfilUsuario(Conexion, NuevoRegistro, Model, UserID);
                int Result = 0;
                if (Result > 0)
                {
                    Model.IDCliente = Result;
                }
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        /// <summary>
        /// Metodo Para Guardar Un nuevo Cliente JM
        /// </summary>
        public void InsertarCliente(ref int Verificador)
        {
            try
            {
                V2Cliente_Datos Datos = new V2Cliente_Datos();
                Datos.GuardarCliente(Conexion, Model, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarCliente" + ex.Message);
            }
        }
        /// <summary>
        /// Metodo Para Modificar un Cliente JM
        /// </summary>
        public void ModificarCliente(ref int Verificador)
        {
            try
            {
                V2Cliente_Datos Datos = new V2Cliente_Datos();
                Datos.ModificarCliente(Conexion, Model, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarCliente" + ex.Message);
            }
        }

        public void Eliminar(ref int Verificador)
        {
            try
            {
                V2Cliente_Datos Datos = new V2Cliente_Datos();
                Datos.Eliminar(Conexion, Model, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarCliente" + ex.Message);
            }
        }

        private void LlenarListaEstados()
        {
            try
            {
                Combo_Datos RegionDatos = new Combo_Datos();
                List<CatEstados> ListaAux = RegionDatos.ObtenerComboEstados(Conexion, true);
                foreach (var Item in ListaAux)
                {
                    ListaEstados.Add(Item);
                }
                Model.IDMunicipio = 101;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LlenarListaMunicipios(int _IDEstado)
        {
            try
            {
                Combo_Datos RegionDatos = new Combo_Datos();
                ListaMunicipios.Clear();
                List<CatMunicipio> ListaAux = RegionDatos.ObtenerComboMunicipios(Conexion, _IDEstado, true);
                foreach (var Item in ListaAux)
                {
                    ListaMunicipios.Add(Item);
                }
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LlenarListaClasificacionCliente()
        {
            try
            {
                Combo_Datos RegionDatos = new Combo_Datos();
                List<ClasificacionCliente> ListaAux = RegionDatos.ObtenerComboClasificacion(Conexion, true);
                foreach (var Item in ListaAux)
                {
                    ListaClasificacion.Add(Item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Iniciar()
        {
            try
            {
                LlenarListaEstados();
                LlenarListaMunicipios(0);
                LlenarListaClasificacionCliente();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setTarjetaCliente(ref int Verificado)
        {
            try
            {
                V2Cliente_Datos cd = new V2Cliente_Datos();
                cd.setTarjetaCliente(Model, ref Verificado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
