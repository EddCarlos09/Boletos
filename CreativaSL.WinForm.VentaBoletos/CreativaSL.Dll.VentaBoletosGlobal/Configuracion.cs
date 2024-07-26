﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Configuracion
    {
        private Caja caja = new Caja(Comun.Conexion);

        public Configuracion(string cadena)
        {
            this.strcnx = cadena;
        }

        private int _opcion;
        public int opcion
        {
            get { return _opcion; }
            set { _opcion = value; }
        }

        private string _strcnx;
        public string strcnx
        {
            get { return _strcnx; }
            set { _strcnx = value; }
        }


        private string _idConfiguracion;
        public string idConfiguracion
        {
            get { return _idConfiguracion; }
            set { _idConfiguracion = value; }
        }

        private string _razonSocial;
        public string razonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        private string _rfc;
        public string rfc
        {
            get { return _rfc; }
            set { _rfc = value; }
        }

        private string _logourl;
        public string logourl
        {
            get { return _logourl; }
            set { _logourl = value; }
        }

        private string _mensaje1;

        public string mensaje1
        {
            get { return _mensaje1; }
            set { _mensaje1 = value; }
        }

        private string _mensaje2;
        public string mensaje2
        {
            get { return _mensaje2; }
            set { _mensaje2 = value; }
        }

        private string _mensaje3;

        public string mensaje3
        {
            get { return _mensaje3; }
            set { _mensaje3 = value; }
        }

        private string _namePrinter;
        public string namePrinter
        {
            get { return _namePrinter; }
            set { _namePrinter = value; }
        }

        private string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _caja_name;
        public string caja_name
        {
            get { return _caja_name; }
            set { _caja_name = value; }
        }

        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _macAddress;
        public string macAddress
        {
            get { return _macAddress; }
            set { _macAddress = value; }
        }

        private string _idCaja;
        public string idCaja
        {
            get { return _idCaja; }
            set { _idCaja = value; }
        }

        private string _calle;
        public string calle
        {
            get { return _calle; }
            set { _calle = value; }
        }
        private string _noExterior;
        public string noExterior
        {
            get { return _noExterior; }
            set { _noExterior = value; }
        }

        private string _noInterior;
        public string noInterior
        {
            get { return _noInterior; }
            set { _noInterior = value; }
        }

        private string _colonia;
        public string colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }

        private string _localidad;
        public string localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }
        private string _municipio;
        public string municipio
        {
            get { return _municipio; }
            set { _municipio = value; }
        }

        private string _estado;
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private string _pais;
        public string pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        private string _telefono;
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
    }
}
