using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class ClasificacionCliente 
    {
        //public ClasificacionCliente(/*string conexion*/)
        //{
        //    //this.strcnx = conexion;            
        //}

        private string _strcnx;

        public string strcnx
        {
            get { return _strcnx; }
            set { _strcnx = value; }
        }

        private int _IDClasificacion;

        public int IDClasificacion
        {
            get { return _IDClasificacion; }
            set { _IDClasificacion = value; }
        }        

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }                         
        }

        private decimal _Porcentaje;//mostrar get

        public decimal Porcentaje
        {
            get { return _Porcentaje; }
            set { _Porcentaje = value; }            
        }

        private decimal _PorcentajeConver { get; set; } //sp set
        public decimal PorcentajeConver
        {
            get { return Porcentaje / 100; }
            set { _PorcentajeConver = value; }                
        }

        private decimal _PorcentajeConver2 { get; set; } //sp set
        public decimal PorcentajeConver2
        {
            get { return Porcentaje * 100; }
            set { _PorcentajeConver2 = value; }
        }

        private DataTable _dataTable_Clasificaciones;
        public DataTable dataTable_Clasificaciones
        {
            get { return _dataTable_Clasificaciones; }
            set { _dataTable_Clasificaciones = value; }
        }
    }
}
