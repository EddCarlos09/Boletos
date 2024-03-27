using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreativaSL.Dll.VentaBoletosGlobal
{
    public static class Comun
    {
        private static string _ipservidor;
        private static string _Id_U;
        private static int _Id_Tu;
        private static string _U_Nombre;
        private static string _U_Apellidop;
        private static string _U_Apellidom;
        private static string _id_sucursal;
        private static string _Conexion;
        private static string _Id_Provedores;
        private static string _CostoCadena;
        private static string _Costo;
        private static string _Existencia;
        private static string _id_caja;
        private static string _InventarioOptimo;
        private static string _DiasInventario;
        private static string _Medida;
        private static float _porcentaje_puntos;


        private static string _turno;
        public static string turno
        {
            get { return _turno; }
            set { _turno = value; }
        }


        private static string _namePrinter;

        public static string namePrinter
        {
            get { return _namePrinter; }
            set { _namePrinter = value; }
        }


        public static string Medida
        {
            get { return _Medida; }
            set { _Medida = value; }
        }
        public static string InventarioOptimo
        {
            get { return _InventarioOptimo; }
            set { _InventarioOptimo = value; }
        }
        public static string DiasInventario
        {
            get { return _DiasInventario; }
            set { _DiasInventario = value; }
        }
        public static string ipservidor
        {
            get { return _ipservidor; }
            set { _ipservidor = value; }
        }
        public static string Id_Provedores
        {
            get { return _Id_Provedores; }
            set { _Id_Provedores = value; }
        }
        public static string CostoCadena
        {
            get { return _CostoCadena; }
            set { _CostoCadena = value; }
        }
        public static string Costo
        {
            get { return _Costo; }
            set { _Costo = value; }
        }
        public static string Existencia
        {
            get { return _Existencia; }
            set { _Existencia = value; }
        }
        public static string Id_U
        {
            get { return _Id_U; }
            set { _Id_U = value; }
        }
        public static int Id_Tu
        {
            get { return _Id_Tu; }
            set { _Id_Tu = value; }
        }
        public static string U_Nombre
        {
            get { return _U_Nombre; }
            set { _U_Nombre = value; }
        }
        public static string U_Apellidop
        {
            get { return _U_Apellidop; }
            set { _U_Apellidop = value; }
        }
        public static string U_Apellidom
        {
            get { return _U_Apellidom; }
            set { _U_Apellidom = value; }
        }
        public static string id_sucursal
        {
            get { return _id_sucursal; }
            set { _id_sucursal = value; }
        }
        public static string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public static string id_caja
        {
            get { return _id_caja; }
            set { _id_caja = value; }
        }

        public static float porcentaje_puntos
        {
            get { return _porcentaje_puntos; }
            set { _porcentaje_puntos = value; }
        }


        /*william*/
        private static string _sucursalCaja;
        public static string SucursalCaja
        {
            get { return Comun._sucursalCaja; }
            set { Comun._sucursalCaja = value; }
        }
        private static int _id_empresa;
        public static int Id_empresa
        {
            get { return Comun._id_empresa; }
            set { Comun._id_empresa = value; }
        }
        private static int _id_tipoSucursal;
        public static int Id_tipoSucursal
        {
            get { return Comun._id_tipoSucursal; }
            set { Comun._id_tipoSucursal = value; }
        }
        private static string _Nombre_Sucursal;
        public static string Nombre_Sucursal
        {
            get { return Comun._Nombre_Sucursal; }
            set { Comun._Nombre_Sucursal = value; }
        }
        private static string _direccion;
        public static string Direccion
        {
            get { return Comun._direccion; }
            set { Comun._direccion = value; }
        }
        private static string _telefono;
        public static string Telefono
        {
            get { return Comun._telefono; }
            set { Comun._telefono = value; }
        }
        private static int _id_municipio;
        public static int Id_municipio
        {
            get { return Comun._id_municipio; }
            set { Comun._id_municipio = value; }
        }
        private static int _id_estado;
        public static int Id_estado
        {
            get { return Comun._id_estado; }
            set { Comun._id_estado = value; }
        }
        private static int _id_pais;
        public static int Id_pais
        {
            get { return Comun._id_pais; }
            set { Comun._id_pais = value; }
        }
        private static int _codigopostal;
        public static int Codigopostal
        {
            get { return Comun._codigopostal; }
            set { Comun._codigopostal = value; }
        }
        private static float _ConfigMargenUtilidad;
        public static float ConfigMargenUtilidad
        {
            get { return Comun._ConfigMargenUtilidad; }
            set { Comun._ConfigMargenUtilidad = value; }
        }
        private static float _ConfigPuntosPlata;
        public static float ConfigPuntosPlata
        {
            get { return Comun._ConfigPuntosPlata; }
            set { Comun._ConfigPuntosPlata = value; }
        }
        private static float _ConfigPuntosOro;
        public static float ConfigPuntosOro
        {
            get { return Comun._ConfigPuntosOro; }
            set { Comun._ConfigPuntosOro = value; }
        }
        private static float _ConfigTiempoEspera;
        public static float ConfigTiempoEspera
        {
            get { return Comun._ConfigTiempoEspera; }
            set { Comun._ConfigTiempoEspera = value; }
        }
        private static float _ConfigTiempoCobro;
        public static float ConfigTiempoCobro
        {
            get { return Comun._ConfigTiempoCobro; }
            set { Comun._ConfigTiempoCobro = value; }
        }
        private static float _ImpuestoBoletos;
        public static float ImpuestoBoletos
        {
            get { return Comun._ImpuestoBoletos; }
            set { Comun._ImpuestoBoletos = value; }
        }

        private static string _CTU_TipoUsuario;
        public static string CTU_TipoUsuario
        {
            get { return Comun._CTU_TipoUsuario; }
            set { Comun._CTU_TipoUsuario = value; }
        }


        private static string _Cu_User;
        public static string Cu_User
        {
            get { return Comun._Cu_User; }
            set { Comun._Cu_User = value; }
        }

        private static string _Cu_Pass;
        public static string Cu_Pass
        {
            get { return Comun._Cu_Pass; }
            set { Comun._Cu_Pass = value; }
        }

        private static DateTime _FechaIngreso;
        public static DateTime FechaIngreso
        {
            get { return Comun._FechaIngreso; }
            set { Comun._FechaIngreso = value; }
        }

        private static string _macAdress;
        public static string macAdress
        {
            get { return Comun._macAdress; }
            set { Comun._macAdress = value; }
        }

        private static string _idCajaCat;
        public static string idCajaCat
        {
            get { return Comun._idCajaCat; }
            set { Comun._idCajaCat = value; }
        }

        private static float _anticipoMinimo;
        public static float anticipoMinimo
        {
            get { return Comun._anticipoMinimo; }
            set { Comun._anticipoMinimo = value; }
        }

        private static DataTable _MaximoDescuentoLinea;
        public static DataTable MaximoDescuentoLinea
        {
            get { return _MaximoDescuentoLinea; }
            set { _MaximoDescuentoLinea = value; }
        }

        //Datos Generales Tickets
        private static string _razonsocial_ticket;
        public static string razonsocial_ticket
        {
            get { return _razonsocial_ticket; }
            set { _razonsocial_ticket = value; }
        }

        private static string _rfc_ticket;
        public static string rfc_ticket
        {
            get { return _rfc_ticket; }
            set { _rfc_ticket = value; }
        }

        private static string _mensaje1_ticket;
        public static string mensaje1_ticket
        {
            get { return _mensaje1_ticket; }
            set { _mensaje1_ticket = value; }
        }

        private static string _mensaje2_ticket;
        public static string mensaje2_ticket
        {
            get { return _mensaje2_ticket; }
            set { _mensaje2_ticket = value; }
        }

        private static string _mensaje3_ticket;
        public static string mensaje3_ticket
        {
            get { return _mensaje3_ticket; }
            set { _mensaje3_ticket = value; }
        }

        private static string _nombresucursal_ticket;
        public static string nombresucursal_ticket
        {
            get { return _nombresucursal_ticket; }
            set { _nombresucursal_ticket = value; }
        }

        private static string _direccion_ticket;
        public static string direccion_ticket
        {
            get { return _direccion_ticket; }
            set { _direccion_ticket = value; }
        }
        private static string _municipio_ticket;
        public static string municipio_ticket
        {
            get { return _municipio_ticket; }
            set { _municipio_ticket = value; }
        }

        private static string _estado_ticket;
        public static string estado_ticket
        {
            get { return _estado_ticket; }
            set { _estado_ticket = value; }
        }

        private static string _codigopostal_ticket;
        public static string codigopostal_ticket
        {
            get { return _codigopostal_ticket; }
            set { _codigopostal_ticket = value; }
        }

        private static string _idventa_ticket;
        public static string idventa_ticket
        {
            get { return _idventa_ticket; }
            set { _idventa_ticket = value; }
        }


        private static string _id_sucursal_ticket;
        public static string id_sucursal_ticket
        {
            get { return _id_sucursal_ticket; }
            set { _id_sucursal_ticket = value; }
        }

        private static string _strcnx_ticket;
        public static string strcnx_ticket
        {
            get { return _strcnx_ticket; }
            set { _strcnx_ticket = value; }
        }

        private static bool _error_ticket;
        public static bool error_ticket
        {
            get { return _error_ticket; }
            set { _error_ticket = value; }
        }

        private static string _namePrinter_ticket;
        public static string namePrinter_ticket
        {
            get { return _namePrinter; }
            set { _namePrinter = value; }
        }

        private static string _url_logo_ticket;
        public static string url_logo_ticket
        {
            get { return _url_logo_ticket; }
            set { _url_logo_ticket = value; }
        }

        private static float _monto_cancelacion;
        public static float monto_cancelacion
        {
            get { return _monto_cancelacion; }
            set { _monto_cancelacion = value; }
        }

        public static void AddExcFileTxt(Exception ex, string funcion)
        {
            try
            {
                //string mydocpath = Comun.UrlTxtLog;
                string mydocpath = "Resources/documents/logerror.txt";

                if (File.Exists(mydocpath))
                {
                    using (StreamWriter outputFile = new StreamWriter(mydocpath, true))
                    {
                        outputFile.WriteLine(ex.HResult + " - " + DateTime.Now + " - " + funcion + " - " + ex.Message);
                    }
                }
                else
                {
                    using (StreamWriter outputFile = new StreamWriter(mydocpath))
                    {
                        outputFile.WriteLine(ex.HResult + " - " + DateTime.Now + " - " + funcion + " - " + ex.Message);
                    }
                }
            }
            catch (Exception)
            {
            }
        }


        public static bool PaginacionDataGridView(object sender, ScrollEventArgs e)
        {
            try
            {
                if (e.NewValue > e.OldValue)
                {
                    DataGridView dgv = sender as DataGridView;
                    int verticalScroollingOffset = dgv.VerticalScrollingOffset;
                    int firstDisplayed = dgv.FirstDisplayedScrollingRowIndex;
                    int displayed = dgv.DisplayedRowCount(true);
                    int lastVisible = (firstDisplayed + displayed);
                    int lastIndex = dgv.RowCount;

                    if (lastVisible == lastIndex)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Imagen
        private static ImageFormat GetImageFormat(string extension)
        {
            try
            {
                ImageFormat Formato = null;
                switch (extension.ToLower())
                {
                    case ".jpg":
                    case ".jpeg":
                        Formato = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        Formato = ImageFormat.Png;
                        break;
                }
                return Formato;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        public static Image VaryQualityLevel(string _filename)
        {
            // Get a bitmap. The using statement ensures objects  
            // are automatically disposed from memory after use. 
            using (Bitmap bmp1 = new Bitmap(_filename))
            {
                string _extension = Path.GetExtension(_filename);
                ImageFormat _formato = GetImageFormat(_extension);
                ImageCodecInfo jpgEncoder = GetEncoder(_formato);
                // Create an Encoder object based on the GUID  
                // for the Quality parameter category.  
                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                // Create an EncoderParameters object.  
                // An EncoderParameters object has an array of EncoderParameter  
                // objects. In this case, there is only one  
                // EncoderParameter object in the array.  
                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                Stream stream = new MemoryStream();
                bmp1.Save(stream, jpgEncoder, myEncoderParameters);
                Image image = Image.FromStream(stream);
                return image;
            }
        }

        public static Bitmap Base64ToBitmap(string base64String)
        {
            Bitmap bmpReturn = null;

            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer)
            {
                Position = 0
            };

            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);

            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;

            return bmpReturn;
        }

        public static ImageFormat GetImageFormat(Image img)
        {
            if (img.RawFormat.Equals(ImageFormat.Jpeg))
                return ImageFormat.Jpeg;
            if (img.RawFormat.Equals(ImageFormat.Bmp))
                return ImageFormat.Bmp;
            if (img.RawFormat.Equals(ImageFormat.Png))
                return ImageFormat.Png;
            if (img.RawFormat.Equals(ImageFormat.Emf))
                return ImageFormat.Emf;
            if (img.RawFormat.Equals(ImageFormat.Exif))
                return ImageFormat.Exif;
            if (img.RawFormat.Equals(ImageFormat.Gif))
                return ImageFormat.Gif;
            if (img.RawFormat.Equals(ImageFormat.Icon))
                return ImageFormat.Icon;
            if (img.RawFormat.Equals(ImageFormat.MemoryBmp))
                return ImageFormat.MemoryBmp;
            if (img.RawFormat.Equals(ImageFormat.Tiff))
                return ImageFormat.Tiff;
            else
                return ImageFormat.Wmf;
        }

        public static string BitmapToBase64String(Bitmap bitmap, ImageFormat imageFormart)
        {
            try
            {


                string base64String = string.Empty;

                MemoryStream memoryStream = new MemoryStream();
                if (imageFormart == ImageFormat.MemoryBmp)
                    imageFormart = ImageFormat.Jpeg;
                bitmap.Save(memoryStream, imageFormart);

                memoryStream.Position = 0;
                byte[] byteBuffer = memoryStream.ToArray();

                memoryStream.Close();

                base64String = Convert.ToBase64String(byteBuffer);
                byteBuffer = null;

                return base64String;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Binding DatagridView con propiedades de diferentes clases
        public static void BindingDataGridView(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridView dgv = sender as DataGridView;

                    //Ejemplo: El data source originalente tiene 3 items, pero se borra el último, queda con 2 items
                    //Pero en dgv.Rows aún esta los 3 items, por lo que marca error, así que antes obtenemos los "objetos" 
                    //del datasource y comparamos los la cantidad de filas que tiene el datagridview con la sig. instrucción
                    //dgv.RowCount <= rowsDataSource.Count

                    List<Object> rowsDataSource = ((IEnumerable)dgv.DataSource).Cast<object>().ToList();

                    if ((dgv.RowCount <= rowsDataSource.Count) && (dgv.Rows[e.RowIndex].DataBoundItem != null) && (dgv.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                    {
                        e.Value = BindProperty(dgv.Rows[e.RowIndex].DataBoundItem, dgv.Columns[e.ColumnIndex].DataPropertyName);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// Accedemos a las propiedades que esten en un objeto sin importar el nivel de acceso
        /// es un método recursivo.
        /// </summary>
        /// <param name="property">El objeto en donde se realizará la busqueda.</param>
        /// <param name="propertyName">Propiedad a buscar, puede ser directo Id_persona o puede estar adentro de 
        /// otra clase, empleado.persona.Id_persona</param>
        /// <returns>Regresa un string con el valor de la propiedad buscada dentro del objeto.</returns>
        private static string BindProperty(object property, string propertyName)
        {
            try
            {
                string retValue;

                retValue = "";

                if (propertyName.Contains("."))
                {
                    PropertyInfo[] arrayProperties;
                    string leftPropertyName;

                    leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                    arrayProperties = property.GetType().GetProperties();

                    foreach (PropertyInfo propertyInfo in arrayProperties)
                    {
                        if (propertyInfo.Name == leftPropertyName)
                        {
                            retValue = BindProperty(propertyInfo.GetValue(property, null), propertyName.Substring(propertyName.IndexOf(".") + 1));
                            break;
                        }
                    }
                }
                else
                {
                    Type propertyType;
                    PropertyInfo propertyInfo;

                    propertyType = property.GetType();
                    propertyInfo = propertyType.GetProperty(propertyName);
                    retValue = propertyInfo.GetValue(property, null).ToString();
                }

                return retValue;
            }
            catch (Exception)
            {
                throw;
            }

        }
        #endregion

    }
}
