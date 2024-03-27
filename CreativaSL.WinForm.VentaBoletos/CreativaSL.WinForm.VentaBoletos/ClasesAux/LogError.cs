using System;
using System.IO;

namespace CreativaSL.WinForm.VentaBoletos.ClasesAux
{
    public class LogError
    {
        public static void AddExcFileTxt(Exception ex, string funcion)
        {
            try
            {
                string mydocpath = "Resources/Documents/ErrorLog.txt";

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
    }
}
