using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class Camion
    {
        public Camion(string cadena)
        {
            this.strcnx = cadena;
        }

        private string _strcnx;

        public string strcnx
        {
            get { return _strcnx; }
            set { _strcnx = value; }
        }


        /* **************************************   tbl_CatMarca   ********************************* */

        private int _id_marca;
        private string _marca;
        private List<Camion> _lista_marcas;

        public int id_marca
        {
            get { return _id_marca; }
            set { _id_marca = value; }
        }

        public string marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public List<Camion> lista_marcas
        {
            get { return _lista_marcas; }
            set { _lista_marcas = value; }
        }

        /* **************************************   tbl_CatSubmarca   ********************************* */

        private int _id_submarca;
        private string _submarca;
        private List<Camion> _lista_submarcas;

        public int id_submarca
        {
            get { return _id_submarca; }
            set { _id_submarca = value; }
        }

        public string submarca
        {
            get { return _submarca; }
            set { _submarca = value; }
        }

        public List<Camion> lista_submarcas
        {
            get { return _lista_submarcas; }
            set { _lista_submarcas = value; }
        }

        /* **************************************   tbl_CatTipocamion   ********************************* */

        private int _idTipoCamion;
        private string _tipoCamion;
        private List<Camion> _lista_tiposCam;

        public int id_Tipocamion
        {
            get { return _idTipoCamion; }
            set { _idTipoCamion = value; }
        }

        public string tipoCamion
        {
            get { return _tipoCamion; }
            set { _tipoCamion = value; }
        }

        public List<Camion> lista_tipoCam
        {
            get { return _lista_tiposCam; }
            set { _lista_tiposCam = value; }
        }

        /* **************************************   tbl_CatCamiones   ********************************* */

        private string _id_camion;
        private string _descripcion;
        private string _num_camion;
        private string _caracteristicas;
        private DataTable _datatable_camiones;

        public string id_camion
        {
            get { return _id_camion; }
            set { _id_camion = value; }
        }

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string num_camion
        {
            get { return _num_camion; }
            set { _num_camion = value; }
        }

        public string caracteristicas
        {
            get { return _caracteristicas; }
            set { _caracteristicas = value; }
        }

        public DataTable datatable_camiones
        {
            get { return _datatable_camiones; }
            set { _datatable_camiones = value; }
        }

        /* **************************************   tbl_CatDiseño  ********************************* */

        private string _id_diseniocamion;
        private string _descripciondisenio;
        private List<Camion> _lista_disenios;

        public string id_diseniocamion
        {
            get { return _id_diseniocamion; }
            set { _id_diseniocamion = value; }
        }

        public string descripciondisenio
        {
            get { return _descripciondisenio; }
            set { _descripciondisenio = value; }
        }

        public List<Camion> lista_disenios
        {
            get { return _lista_disenios; }
            set { _lista_disenios = value; }
        }

        private List<Camion> _comboCamiones;

        public List<Camion> comboCamiones
        {
            get { return _comboCamiones; }
            set { _comboCamiones = value; }
        }

    }
}
