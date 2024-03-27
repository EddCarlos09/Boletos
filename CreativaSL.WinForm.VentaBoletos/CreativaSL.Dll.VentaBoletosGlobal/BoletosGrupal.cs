using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class BoletosGrupal
    {
        private string _id_viajeGrupal;
        public string id_viajeGrupal
        {
            get { return _id_viajeGrupal; }
            set { _id_viajeGrupal = value; }
        }
        private DateTime _fechaViajeGrupal;
        public DateTime fechaViajeGrupal
        {
            get { return _fechaViajeGrupal; }
            set { _fechaViajeGrupal = value; }
        }
        private string _horaViajeGrupal;
        public string horaViajeGrupal
        {
            get { return _horaViajeGrupal; }
            set { _horaViajeGrupal = value; }
        }
        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private DateTime _fechaNacimiento;
        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private string _numeroTelefono;
        public string numeroTelefono
        {
            get { return _numeroTelefono; }
            set { _numeroTelefono = value; }
        }

        private bool _ventaGrupal;
        public bool ventaGrupal
        {
            get { return _ventaGrupal; }
            set { _ventaGrupal = value; }
        }
        
        
    }
}
