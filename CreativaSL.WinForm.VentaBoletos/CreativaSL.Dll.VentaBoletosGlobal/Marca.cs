using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    #region Marca
    public class Marca
    {
        #region PropiedadesMarca
        private int _id_marca;
        private string _marca;
        private string _usuins;
        private DateTime _fecins;
        private string _usuupd;
        private DateTime _fecupd;
        private bool _activo;

        public int id_marca
        {
            get { return _id_marca; }
            set { _id_marca = value; }
        }

        public string nombreMarca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string usuins
        {
            get { return _usuins; }
            set { _usuins = value; }
        }

        public DateTime fecins
        {
            get { return _fecins; }
            set { _fecins = value; }
        }

        public string usuupd
        {
            get { return _usuupd; }
            set { _usuupd = value; }
        }

        public DateTime fecupd
        {
            get { return _fecupd; }
            set { _fecupd = value; }
        }

        public bool activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
        #endregion

        #region TablaMarcas
        private DataTable _Marcas;
        public DataTable Marcas
        {
            get { return _Marcas; }
            set { _Marcas = value; }
        }
        #endregion
    }
    #endregion
}
