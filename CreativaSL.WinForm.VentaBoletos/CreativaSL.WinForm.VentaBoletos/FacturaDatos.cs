using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.WinForm.VentaBoletos
{
    public class FacturaDatos
    {
        public V2Cliente Cliente { get; set; }
        public string ClaveProdServ { get; set; }
        public string NoIdentificacion { get; set; }
        public int Cantidad { get; set; }
        public string ClaveUnidad { get;set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public float ValorUnitario { get; set; }
        public float Importe { get; set; } 
        public int ObjetoImp {  get; set; }
    }

}
