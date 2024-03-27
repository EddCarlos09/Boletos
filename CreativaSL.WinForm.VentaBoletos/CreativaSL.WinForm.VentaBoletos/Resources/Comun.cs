using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public static class Comun
    {
        private static string _ipservidor;
        private static string _Id_U;
        private static int _Id_Tu;
        private static string _U_Nombre;
        private static string _U_Apellidop;
        private static string _U_Apellidom;
        private static string _id_sucursal;
        private static string _Conexion;
        private static string _Id_Provedores;
        private static string _CostoCadena;
        private static string _Costo;
        private static string _Existencia;
        private static string _id_caja;
        private static string _InventarioOptimo;
        private static string _DiasInventario;
        private static string _Medida;
        private static float _porcentaje_puntos;


        private static string _turno;
        public static string turno
        {
            get { return _turno; }
            set { _turno = value; }
        }


        private static string _namePrinter;

        public static string namePrinter
        {
            get { return _namePrinter; }
            set { _namePrinter = value; }
        }


        public static string Medida
        {
            get { return _Medida; }
            set { _Medida = value; }
        }
        public static string InventarioOptimo
        {
            get { return _InventarioOptimo; }
            set { _InventarioOptimo = value; }
        }
        public static string DiasInventario
        {
            get { return _DiasInventario; }
            set { _DiasInventario = value; }
        }
        public static string ipservidor
        {
            get { return _ipservidor; }
            set { _ipservidor = value; }
        }
        public static string Id_Provedores
        {
            get { return _Id_Provedores; }
            set { _Id_Provedores = value; }
        }
        public static string CostoCadena
        {
            get { return _CostoCadena; }
            set { _CostoCadena = value; }
        }
        public static string Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }
        public static string Existencia
        {
            get { return _Existencia; }
            set { _Existencia = value; }
        }
        public static string Id_U
        {
            get { return _Id_U; }
            set { _Id_U = value; }
        }
        public static int Id_Tu
        {
            get { return _Id_Tu; }
            set { _Id_Tu = value; }
        }
        public static string U_Nombre
        {
            get { return _U_Nombre; }
            set { _U_Nombre = value; }
        }
        public static string U_Apellidop
        {
            get { return _U_Apellidop; }
            set { _U_Apellidop = value; }
        }
        public static string U_Apellidom
        {
            get { return _U_Apellidom; }
            set { _U_Apellidom = value; }
        }
        public static string id_sucursal
        {
            get { return _id_sucursal; }
            set { _id_sucursal = value; }
        }
        public static string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public static string id_caja
        {
            get { return _id_caja; }
            set { _id_caja = value; }
        }

        public static float porcentaje_puntos
        {
            get { return _porcentaje_puntos; }
            set { _porcentaje_puntos = value; }
        }


        /*william*/
        private static string _sucursalCaja;
        public static string SucursalCaja
        {
            get { return Comun._sucursalCaja; }
            set { Comun._sucursalCaja = value; }
        }
        private static int _id_empresa;
        public static int Id_empresa
        {
            get { return Comun._id_empresa; }
            set { Comun._id_empresa = value; }
        }
        private static int _id_tipoSucursal;
        public static int Id_tipoSucursal
        {
            get { return Comun._id_tipoSucursal; }
            set { Comun._id_tipoSucursal = value; }
        }
        private static string _Nombre_Sucursal;
        public static string Nombre_Sucursal
        {
            get { return Comun._Nombre_Sucursal; }
            set { Comun._Nombre_Sucursal = value; }
        }
        private static string _direccion;
        public static string Direccion
        {
            get { return Comun._direccion; }
            set { Comun._direccion = value; }
        }
        private static string _telefono;
        public static string Telefono
        {
            get { return Comun._telefono; }
            set { Comun._telefono = value; }
        }
        private static int _id_municipio;
        public static int Id_municipio
        {
            get { return Comun._id_municipio; }
            set { Comun._id_municipio = value; }
        }
        private static int _id_estado;
        public static int Id_estado
        {
            get { return Comun._id_estado; }
            set { Comun._id_estado = value; }
        }
        private static int _id_pais;
        public static int Id_pais
        {
            get { return Comun._id_pais; }
            set { Comun._id_pais = value; }
        }
        private static int _codigopostal;
        public static int Codigopostal
        {
            get { return Comun._codigopostal; }
            set { Comun._codigopostal = value; }
        }
        private static float _ConfigMargenUtilidad;
        public static float ConfigMargenUtilidad
        {
            get { return Comun._ConfigMargenUtilidad; }
            set { Comun._ConfigMargenUtilidad = value; }
        }
        private static float _ConfigPuntosPlata;
        public static float ConfigPuntosPlata
        {
            get { return Comun._ConfigPuntosPlata; }
            set { Comun._ConfigPuntosPlata = value; }
        }
        private static float _ConfigPuntosOro;
        public static float ConfigPuntosOro
        {
            get { return Comun._ConfigPuntosOro; }
            set { Comun._ConfigPuntosOro = value; }
        }
        private static float _ConfigTiempoEspera;
        public static float ConfigTiempoEspera
        {
            get { return Comun._ConfigTiempoEspera; }
            set { Comun._ConfigTiempoEspera = value; }
        }
        private static float _ConfigTiempoCobro;
        public static float ConfigTiempoCobro
        {
            get { return Comun._ConfigTiempoCobro; }
            set { Comun._ConfigTiempoCobro = value; }
        }
        private static float _ImpuestoBoletos;
        public static float ImpuestoBoletos
        {
            get { return Comun._ImpuestoBoletos; }
            set { Comun._ImpuestoBoletos = value; }
        }

        private static string _CTU_TipoUsuario;
        public static string CTU_TipoUsuario
        {
            get { return Comun._CTU_TipoUsuario; }
            set { Comun._CTU_TipoUsuario = value; }
        }


        private static string _Cu_User;
        public static string Cu_User
        {
            get { return Comun._Cu_User; }
            set { Comun._Cu_User = value; }
        }

        private static string _Cu_Pass;
        public static string Cu_Pass
        {
            get { return Comun._Cu_Pass; }
            set { Comun._Cu_Pass = value; }
        }

        private static DateTime _FechaIngreso;
        public static DateTime FechaIngreso
        {
            get { return Comun._FechaIngreso; }
            set { Comun._FechaIngreso = value; }
        }

        private static string _macAdress;
        public static string macAdress
        {
            get { return Comun._macAdress; }
            set { Comun._macAdress = value; }
        }

        private static string _idCajaCat;
        public static string idCajaCat
        {
            get { return Comun._idCajaCat; }
            set { Comun._idCajaCat = value; }
        }

    }
}
