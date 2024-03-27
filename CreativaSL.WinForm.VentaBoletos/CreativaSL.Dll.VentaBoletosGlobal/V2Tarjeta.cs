using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class V2Tarjeta
    {
        private int _IDTarjeta;

        public int IDTarjeta
        {
            get { return _IDTarjeta; }
            set { _IDTarjeta = value; }
        }

        private string _Folio;

        public string Folio
        {
            get { return _Folio; }
            set { _Folio = value; }
        }

        private string _EstatusDes;

        public string EstatusDes
        {
            get { return _EstatusDes; }
            set { _EstatusDes = value; }
        }

        private int _Estatus;

        public int Estatus
        {
            get { return _Estatus; }
            set { _Estatus = value; }
        }

        #region TablaTarjeta
        private DataTable _FolioTarjeta;
        public DataTable FolioTarjeta
        {
            get { return _FolioTarjeta; }
            set { _FolioTarjeta = value; }
        }
        #endregion

    }
}
