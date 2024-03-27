using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Chofer
    {
/******************************************************  Inicio Propiedades Choferes *********************************************************/       

        private string   _IDChofer;
        public string  IDChofer
        {
            get { return _IDChofer; }
            set { _IDChofer = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _ApellidoPaterno;
        public string ApellidoPaterno
        {
            get { return _ApellidoPaterno; }
            set { _ApellidoPaterno = value; }
        }

        private string _ApellidoMaterno;
        public string ApellidoMaterno
        {
            get { return _ApellidoMaterno; }
            set { _ApellidoMaterno = value; }
        }

        private string _Curp;
        public string Curp
        {
            get { return _Curp; }
            set { _Curp = value; }
        }

        private DateTime ? _FechaNacimiento;
        public DateTime ? FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        private string _Observaciones;
        public string Observaciones
        {
            get { return _Observaciones; }
            set { _Observaciones = value; }
        }


/******************************************************  Fin Propiedades Choferes *********************************************************/




/******************************************************  Inicio Tabla Clientes *********************************************************/

        private DataTable _Choferes;
        public DataTable Choferes
        {
            get { return _Choferes; }
            set { _Choferes = value; }
        }

/******************************************************  Fin Tabla Clientes *********************************************************/

    }
}
