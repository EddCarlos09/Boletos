using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class DisenioCamion
    {
/******************************************************  Inicio Propiedades Disenio Camion *********************************************************/       

        private string _conexion;
        public string Conexion
        {
            get { return _conexion; }
            set { _conexion = value; }
        }
               
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _id_disenioCamion;
        public string id_disenioCamion
        {
            get { return _id_disenioCamion; }
            set { _id_disenioCamion = value; }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private int _numasientos;
        public int NumAsientos
        {
            get { return _numasientos; }
            set { _numasientos = value; }
        }

        private int _numbaños;
        public int NumBaños
        {
            get { return _numbaños; }
            set { _numbaños = value; }
        }

        private int _numtvs;
        public int NumTvs
        {
            get { return _numtvs; }
            set { _numtvs = value; }
        }

        private int _numbares;
        public int NumBares
        {
            get { return _numbares; }
            set { _numbares = value; }
        }

        private int _numpuertas;
        public int NumPuertas
        {
            get { return _numpuertas; }
            set { _numpuertas = value; }
        }

        private int _numpisos;
        public int NumPisos
        {
            get { return _numpisos; }
            set { _numpisos = value; }
        }

        public DisenioCamion()
        {
        }
/******************************************************  Fin Propiedades Disenio Camion*********************************************************/



/******************************************************  Inicio Tabla Objetos *********************************************************/

        private DataTable _tablaObjetos;
        public DataTable TablaObjetos
        {
            get { return _tablaObjetos; }
            set { _tablaObjetos = value; }
        }

/******************************************************  Fin Tabla Objetos *********************************************************/



/******************************************************  Inicio Tabla DisenioCamion *********************************************************/

        private DataTable _DisenioCamiones;
        public DataTable DisenioCamiones
        {
            get { return _DisenioCamiones; }
            set { _DisenioCamiones = value; }
        }

 /******************************************************  Fin Tabla DisenioCamion *********************************************************/



    }
}
