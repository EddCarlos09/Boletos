using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Cliente
    {
/******************************************************  Inicio Propiedades Clientes *********************************************************/       
        private string _id_cliente;
        public string IDCliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apePat;
        public string ApePat
        {
            get { return _apePat; }
            set { _apePat = value; }
        }
        private string _apeMat;
        public string ApeMat
        {
            get { return _apeMat; }
            set { _apeMat = value; }
        }
        private string _CorreoElectronico;
        public string CorreoElectronico
        {
            get { return _CorreoElectronico; }
            set { _CorreoElectronico = value; }
        }
        private int? _id_municipio;
        public int? IDMunicipio
        {
            get { return _id_municipio; }
            set { _id_municipio = value; }
        }
        private int? _id_estado;
        public int? IDEstado
        {
            get { return _id_estado; }
            set { _id_estado = value; }
        }
        private int? _id_pais;
        public int? IDPais
        {
            get { return _id_pais; }
            set { _id_pais = value; }
        }
        private string _municipio;
        public string Municipio
        {
            get { return _municipio; }
            set { _municipio = value; }
        }
        private string _estado;
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private string _pais;
        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        private string _colonia;
        public string Colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }
        private DateTime? _fechaNacimiento;
        public DateTime? FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        private int? _id_ocupacion;
        public int? IDOcupacion
        {
            get { return _id_ocupacion; }
            set { _id_ocupacion = value; }
        }
        private int? _id_genero;
        public int? IDGenero
        {
            get { return _id_genero; }
            set { _id_genero = value; }
        }
        private string _curp;
        public string Curp
        {
            get { return _curp; }
            set { _curp = value; }
        }
        private bool? _activo;
        public bool? Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
        private string _usuins;
        public string Usuins
        {
            get { return _usuins; }
            set { _usuins = value; }
        }
        private DateTime _fecins;
        public DateTime Fecins
        {
            get { return _fecins; }
            set { _fecins = value; }
        }
        private string _usuupd;
        public string Usuupd
        {
            get { return _usuupd; }
            set { _usuupd = value; }
        }
        private DateTime _fecupd;
        public DateTime Fecupd
        {
            get { return _fecupd; }
            set { _fecupd = value; }
        }
        private DateTime? _fechaInicio;
        public DateTime? FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }
        private string _id_credencial;
        public string IDCredencial
        {
            get { return _id_credencial; }
            set { _id_credencial = value; }
        }
        private int? _id_tipocredencial;
        public int? IDTipocredencial
        {
            get { return _id_tipocredencial; }
            set { _id_tipocredencial = value; }
        }
        private float? _puntos;
        public float? Puntos
        {
            get { return _puntos; }
            set { _puntos = value; }
        }
        private float? _monedero;
        public float? Monedero
        {
            get { return _monedero; }
            set { _monedero = value; }
        }
        private string _id_codigoEab;
        public string IDCodigoEab
        {
            get { return _id_codigoEab; }
            set { _id_codigoEab = value; }
        }
        private string _Genero;
        public string Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }

        private string _NombreCompleto;
        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set { _NombreCompleto = value; }
        }
        private string _Ocupacion;
        public string Ocupacion
        {
            get { return _Ocupacion; }
            set { _Ocupacion = value; }
        }
        private string _Id_U;
        public string Id_U
        {
            get { return _Id_U; }
            set { _Id_U = value; }
        }
        private DateTime _U_FechaNac;
        public DateTime U_FechaNac
        {
            get { return _U_FechaNac; }
            set { _U_FechaNac = value; }
        }

        private string _Credencial;
        public string Credencial
        {
            get { return _Credencial; }
            set { _Credencial = value; }
        }

        private int _IDEstadoCivil;
        public int IDEstadoCivil
        {
            get { return _IDEstadoCivil; }
            set { _IDEstadoCivil = value; }
        }

        private string _EstadoCivil;
        public string EstadoCivil
        {
            get { return _EstadoCivil; }
            set { _EstadoCivil = value; }
        }

/******************************************************  Fin Propiedades Clientes *********************************************************/









/******************************************************  Inicio Tabla Clientes *********************************************************/

        private DataTable _Clientes;
        public DataTable Clientes
        {
            get { return _Clientes; }
            set { _Clientes = value; }
        }

/******************************************************  Fin Tabla Clientes *********************************************************/





/******************************************************  Inicio Lista Genero *********************************************************/

        private List<Cliente> _lista_Genero;
        public List<Cliente> lista_Genero
        {
            get { return _lista_Genero; }
            set { _lista_Genero = value; }
        }
/******************************************************  Fin Lista Genero *********************************************************/




/******************************************************  Inicio Lista Ocupacion *********************************************************/

        private List<Cliente> _lista_Ocupacion;
        public List<Cliente> lista_Ocupacion
        {
            get { return _lista_Ocupacion; }
            set { _lista_Ocupacion = value; }
        }
/******************************************************  Fin Lista Ocupacion *********************************************************/





/******************************************************  Inicio Lista Ocupacion *********************************************************/

        private List<Cliente> _lista_EstadoCivil;
        public List<Cliente> lista_EstadoCivil
        {
            get { return _lista_EstadoCivil; }
            set { _lista_EstadoCivil = value; }
        }
/******************************************************  Fin Lista Ocupacion *********************************************************/






/******************************************************  Inicio Lista Pais *********************************************************/

        private List<Cliente> _lista_Pais;
        public List<Cliente> lista_Pais
        {
            get { return _lista_Pais; }
            set { _lista_Pais = value; }
        }
/******************************************************  Fin Lista Pais *********************************************************/



/******************************************************  Inicio Lista Estado *********************************************************/

        private List<Cliente> _lista_Estado;
        public List<Cliente> lista_Estado
        {
            get { return _lista_Estado; }
            set { _lista_Estado = value; }
        }
/******************************************************  Fin Lista Estado *********************************************************/



/******************************************************  Inicio Lista Municipio *********************************************************/

        private List<Cliente> _lista_Municipio;
        public List<Cliente> lista_Municipio
        {
            get { return _lista_Municipio; }
            set { _lista_Municipio = value; }
        }
/******************************************************  Fin Lista Municipio *********************************************************/

    }

}
