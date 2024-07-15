using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.WinForm.VentaBoletos
{
    public class ApiResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public Data Data { get; set; }
    }

    public class Data
    {
        public string XML { get; set; }
        public string PDF { get; set; }
    }

}
