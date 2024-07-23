using CreativaSL.Dll.VentaBoletosDatos;
using CreativaSL.Dll.VentaBoletosGlobal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.VentaBoletosNegocio
{
    public class Factura_Negocio
    {
        #region Propiedades

        public Facturas Model { get; set; }
        public string Conexion { get; set; }
        public bool NuevoRegistro { get; set; }
        public string UserID { get; set; }

        #endregion

        #region Constructor

        public Factura_Negocio(string _Conexion, string _UserID)
        {
            Conexion = _Conexion;
            UserID = _UserID;
        }

        #endregion
        #region Metodos
        public void InsertarFactura( Facturas Factura, ref int Verificador)
        {
            try
            {
                Factura_Datos Datos = new Factura_Datos();
                Datos.GuardarFactura(Conexion, Factura, ref Verificador);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarCliente" + ex.Message);
            }
        }

        public void CancelarFactura(int id)
        {
            try
            {
                Factura_Datos Datos = new Factura_Datos();
                Datos.ActualizarEstadoFactura(Conexion,id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error InsertarCliente" + ex.Message);
            }
        }
        #endregion
    }
}
