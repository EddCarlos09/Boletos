using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    #region TipoCamion
    public class TipoCamion
    {
        #region PropiedadesTipoCamion
        private int _id_tipocamion;
        private string _tipocamion;
        private float _maximoDescuentoLinea;
        private string _usuins;
        private DateTime _fecins;
        private string _usuupd;
        private DateTime _fecupd;
        private bool _activo;

        public int id_tipocamion
        {
            get { return _id_tipocamion; }
            set { _id_tipocamion = value; }
        }

        public string nombreTipoCamion
        {
            get { return _tipocamion; }
            set { _tipocamion = value; }
        }

        public float maximoDescuentoLinea
        {
            get { return _maximoDescuentoLinea; }
            set { _maximoDescuentoLinea = value; }
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
        #region TablaTipoCamiones
        private DataTable _TipoCamiones;
        public DataTable TipoCamiones
        {
            get { return _TipoCamiones; }
            set { _TipoCamiones = value; }
        }
        #endregion
    }
    #endregion
}
