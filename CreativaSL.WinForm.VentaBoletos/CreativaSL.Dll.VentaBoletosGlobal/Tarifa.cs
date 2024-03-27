using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Tarifa
    {

        public Tarifa(string conexion)
        {
            this.strcnx = conexion;
        }

        private string _strcnx;

        public string strcnx
        {
            get { return _strcnx; }
            set { _strcnx = value; }
        }

        private string _id_usuario;

        public string id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        private string _id_tarifa;

        public string id_tarifa
        {
            get { return _id_tarifa; }
            set { _id_tarifa = value; }
        }

        private string _id_viaje;

        public string id_viaje
        {
            get { return _id_viaje; }
            set { _id_viaje = value; }
        }

        private string _id_terminalXruta;

        public string id_terminalXruta
        {
            get { return _id_terminalXruta; }
            set { _id_terminalXruta = value; }
        }

        private string _id_terminalOrigen;

        public string id_terminalOrigen
        {
            get { return _id_terminalOrigen; }
            set { _id_terminalOrigen = value; }
        }

        private string _id_terminalDestino;

        public string id_terminalDestino
        {
            get { return _id_terminalDestino; }
            set { _id_terminalDestino = value; }
        }
        private float _precioNormal1piso;

        public float precioNormal1piso
        {
            get { return _precioNormal1piso; }
            set { _precioNormal1piso = value; }
        }

        private float _precioInfantil1piso;

        public float precioInfantil1piso
        {
            get { return _precioInfantil1piso; }
            set { _precioInfantil1piso = value; }
        }

        private float _precioTerceraEdad1piso;

        public float precioTerceraEdad1piso
        {
            get { return _precioTerceraEdad1piso; }
            set { _precioTerceraEdad1piso = value; }
        }

        private float _precioEspecial1piso;

        public float precioEspecial1piso
        {
            get { return _precioEspecial1piso; }
            set { _precioEspecial1piso = value; }
        }

        private float _precioNormal2piso;

        public float precioNormal2piso
        {
            get { return _precioNormal2piso; }
            set { _precioNormal2piso = value; }
        }

        private float _precioInfantil2piso;

        public float precioInfantil2piso
        {
            get { return _precioInfantil2piso; }
            set { _precioInfantil2piso = value; }
        }

        private float _precioTerceraEdad2piso;

        public float precioTerceraEdad2piso
        {
            get { return _precioTerceraEdad2piso; }
            set { _precioTerceraEdad2piso = value; }
        }

        private float _precioEspecial2piso;

        public float precioEspecial2piso
        {
            get { return _precioEspecial2piso; }
            set { _precioEspecial2piso = value; }
        }
        private DataTable _datatable_tarifas;

        public DataTable datatable_tarifas
        {
            get { return _datatable_tarifas; }
            set { _datatable_tarifas = value; }
        }

        private List<Tarifa> _listaTarifas;

        public List<Tarifa> listaTarifas
        {
            get { return _listaTarifas; }
            set { _listaTarifas = value; }
        }

        private int _indice;
        public int indice
        {
            get { return _indice; }
            set { _indice = value; }
        }

        private int _id_tipoTerminal;
        public int id_tipoTerminal
        {
            get { return _id_tipoTerminal; }
            set { _id_tipoTerminal = value; }
        }
    }
}
