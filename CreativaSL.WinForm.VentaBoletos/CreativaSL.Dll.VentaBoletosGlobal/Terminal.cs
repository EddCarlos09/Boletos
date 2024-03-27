using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Terminal
    {

        public Terminal(string cadena)
        {
            this.strcnx = cadena;
        }

        private string _strcnx;

        public string strcnx
        {
            get { return _strcnx; }
            set { _strcnx = value; }
        }

        private int _verificador;

        public int verificador
        {
            get { return _verificador; }
            set { _verificador = value; }
        }

        private DataTable _datatable_terminales;

        public DataTable datatable_terminales
        {
            get { return _datatable_terminales; }
            set { _datatable_terminales = value; }
        }

        private string _id_terminal;

        public string id_terminal
        {
            get { return _id_terminal; }
            set { _id_terminal = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _direccion;

        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _telefonos;

        public string telefonos
        {
            get { return _telefonos; }
            set { _telefonos = value; }
        }

        private int _id_pais;

        public int id_pais
        {
            get { return _id_pais; }
            set { _id_pais = value; }
        }

        private string _pais;

        public string pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        private int _id_estado;

        public int id_estado
        {
            get { return _id_estado; }
            set { _id_estado = value; }
        }

        private string _estado;

        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private int _id_municipio;

        public int id_municipio
        {
            get { return _id_municipio; }
            set { _id_municipio = value; }
        }

        private string _municipio;

        public string municipio
        {
            get { return _municipio; }
            set { _municipio = value; }
        }

        private string _siglas;

        public string siglas
        {
            get { return _siglas; }
            set { _siglas = value; }
        }

        private string _id_usuario;

        public string id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        private List<Terminal> _paises;

        public List<Terminal> paises
        {
            get { return _paises; }
            set { _paises = value; }
        }

        private List<Terminal> _estados;

        public List<Terminal> estados
        {
            get { return _estados; }
            set { _estados = value; }
        }

        private List<Terminal> _municipios;

        public List<Terminal> municipios
        {
            get { return _municipios; }
            set { _municipios = value; }
        }

    }
}
