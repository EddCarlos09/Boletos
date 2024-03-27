using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Usuario
    {

        
/******************************************************  Inicio Propiedades Usuarios *********************************************************/       
        private string _Id_U;
        private int _Id_Tu;
        private string _U_Nombre;
        private string _U_Apellidop;
        private string _U_Apellidom;
        private DateTime _U_FechaNac;
        private string _U_DirCalle;
        private string _U_DirColonia;
        private string _U_DirNumero;
        private bool _Cu_Estatus;
        private DateTime _Cu_FBloq;
        private DateTime _Cu_FCaducidad;
        private bool _CuentaCaducada;
        private string _id_sucursal;
        private string _Cu_Usuer;
        private string _Cu_Pass;
        private int _Validador;
        private string _Conexion;
        private string _Id_UModifico;
        private string _NombreCompleto;
        private string _Tu_Descripcion;
        private string _Nombre_Sucursal;
        private int? _Id_Turno;
        private string _Turno;
        private string _id_sucursalModifcada;
        private bool _Crearid_caja;
        private int? _BanPass;


        public int? Id_Turno
        {
            get { return _Id_Turno; }
            set { _Id_Turno = value; }
        }
        public string Turno
        {
            get { return _Turno; }
            set { _Turno = value; }
        }
        public int? BanPass
        {
            get { return _BanPass; }
            set { _BanPass = value; }
        }
        public string Id_U
        {
            get { return _Id_U; }
            set { _Id_U = value; }
        }
        public string Id_UModifico
        {
            get { return _Id_UModifico; }
            set { _Id_UModifico = value; }
        }
        public int Id_Tu
        {
            get { return _Id_Tu; }
            set { _Id_Tu = value; }
        }
        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set { _NombreCompleto = value; }
        }
        public string U_Nombre
        {
            get { return _U_Nombre; }
            set { _U_Nombre = value; }
        }
        public string U_Apellidop
        {
            get { return _U_Apellidop; }
            set { _U_Apellidop = value; }
        }
        public string U_Apellidom
        {
            get { return _U_Apellidom; }
            set { _U_Apellidom = value; }
        }
        public DateTime U_FechaNac
        {
            get { return _U_FechaNac; }
            set { _U_FechaNac = value; }
        }
        public string U_DirCalle
        {
            get { return _U_DirCalle; }
            set { _U_DirCalle = value; }
        }
        public string U_DirColonia
        {
            get { return _U_DirColonia; }
            set { _U_DirColonia = value; }
        }
        public string U_DirNumero
        {
            get { return _U_DirNumero; }
            set { _U_DirNumero = value; }
        }
        public bool Cu_Estatus
        {
            get { return _Cu_Estatus; }
            set { _Cu_Estatus = value; }
        }
        public DateTime Cu_Bloq
        {
            get { return _Cu_FBloq; }
            set { _Cu_FBloq = value; }
        }
        public DateTime Cu_Fcaducidad
        {
            get { return _Cu_FCaducidad; }
            set { _Cu_FCaducidad = value; }
        }
        public bool CuentaCaducada
        {
            get { return _CuentaCaducada; }
            set { _CuentaCaducada = value; }
        }
        public string id_sucursal
        {
            get { return _id_sucursal; }
            set { _id_sucursal = value; }
        }
        public string Cu_User
        {
            get { return _Cu_Usuer; }
            set { _Cu_Usuer = value; }
        }
        public string Cu_Pass
        {
            get { return _Cu_Pass; }
            set { _Cu_Pass = value; }
        }
        public int Validador
        {
            get { return _Validador; }
            set { _Validador = value; }
        }
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public bool Crearid_caja
        {
            get { return _Crearid_caja; }
            set { _Crearid_caja = value; }
        }
        public string Tu_Descripcion
        {
            get { return _Tu_Descripcion; }
            set { _Tu_Descripcion = value; }
        }
        public string Nombre_Sucursal
        {
            get { return _Nombre_Sucursal; }
            set { _Nombre_Sucursal = value; }
        }
        public string id_sucursalModifcada
        {
            get { return _id_sucursalModifcada; }
            set { _id_sucursalModifcada = value; }
        }
        private string _idcaja;
        public string idcaja
        {
            get { return _idcaja; }
            set { _idcaja = value; }
        }
        private string _idcajero;
        public string idcajero
        {
            get { return _idcajero; }
            set { _idcajero = value; }
        }
        private DateTime _fechaApertura;
        public DateTime fechaApertura
        {
            get { return _fechaApertura; }
            set { _fechaApertura = value; }
        }


/******************************************************  Fin Propiedades Usuarios *********************************************************/









/******************************************************  Inicio Tabla Usuarios *********************************************************/       

        private DataTable _Usuarios;
        public DataTable Usuarios
        {
            get { return _Usuarios; }
            set { _Usuarios = value; }
        }

/******************************************************  Fin Tabla Usuarios *********************************************************/







/******************************************************  Inicio Lista TipoUsuarios *********************************************************/

        private List<Usuario> _lista_TipoUsuarios;
        public List<Usuario> lista_TipoUsuarios
        {
            get { return _lista_TipoUsuarios; }
            set { _lista_TipoUsuarios = value; }
        }
/******************************************************  Fin Lista TipoUsuarios *********************************************************/





 /******************************************************  Inicio Lista Turno *********************************************************/       

        private List<Usuario> _lista_Turno;
        public List<Usuario> lista_Turno
        {
            get { return _lista_Turno; }
            set { _lista_Turno = value; }
        }
 /******************************************************  Fin Lista Turno *********************************************************/





/******************************************************  Inicio Sucursal *********************************************************/

        private List<Usuario> _lista_Sucursal;
        public List<Usuario> lista_Sucursal
        {
            get { return _lista_Sucursal; }
            set { _lista_Sucursal = value; }
        }
/******************************************************  Fin Sucursal *********************************************************/

    }
}
