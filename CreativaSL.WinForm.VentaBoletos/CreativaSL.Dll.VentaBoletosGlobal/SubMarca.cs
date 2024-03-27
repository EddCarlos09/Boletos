using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    #region Submarca
    public class SubMarca
    {
        #region PropiedadesSubMarca
        private int _id_submarca;
        private int _id_marca;
        private string _submarca;
        private string _marca;
        private string _usuins;
        private DateTime _fecins;
        private string _usuupd;
        private DateTime _fecupd;
        private bool _activo;

        public int id_submarca
        {
            get { return _id_submarca; }
            set { _id_submarca = value; }
        }

        public int id_marca
        {
            get { return _id_marca; }
            set { _id_marca = value; }
        }

        public string nombreSubMarca
        {
            get { return _submarca; }
            set { _submarca = value; }
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

        #region TablaSubmarcas
        private DataTable _SubMarcas;
        public DataTable SubMarcas
        {
            get { return _SubMarcas; }
            set { _SubMarcas = value; }
        }
        #endregion

        #region ComboMarcas
        private List<SubMarca> _lista_Marcas;
        public List<SubMarca> lista_Marcas
        {
            get { return _lista_Marcas; }
            set { _lista_Marcas = value; }
        }
        #endregion
    }
    #endregion
}
