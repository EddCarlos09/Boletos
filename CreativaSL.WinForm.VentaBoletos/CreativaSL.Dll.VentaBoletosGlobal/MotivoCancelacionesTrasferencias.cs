using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public class MotivoCancelacionesTrasferencias
    {
        private int _id_motivoCancelacionTransferencia;
        public int id_motivoCancelacionTransferencia
        {
            get { return _id_motivoCancelacionTransferencia; }
            set { _id_motivoCancelacionTransferencia = value; }
        }

        private int _id_tipo;
        public int id_tipo
        {
            get { return _id_tipo; }
            set { _id_tipo = value; }
        }

        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _ID_U;
        public string ID_U
        {
            get { return _ID_U; }
            set { _ID_U = value; }
        }

        private string _id_boletoTransferencia;
        public string id_boletoTransferencia
        {
            get { return _id_boletoTransferencia; }
            set { _id_boletoTransferencia = value; }
        }

        private string _id_boleto;
        public string id_boleto
        {
            get { return _id_boleto; }
            set { _id_boleto = value; }
        }
        private bool _transferenciaCompleta;

        public bool transferenciaCompleta
        {
            get { return _transferenciaCompleta; }
            set { _transferenciaCompleta = value; }
        }

    }
}
