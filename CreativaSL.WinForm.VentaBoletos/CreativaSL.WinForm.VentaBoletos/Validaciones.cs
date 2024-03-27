using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CreativaSL.WinForm.VentaBoletos
{
    class Validaciones
    {
        public void SoloTexto(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '´')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void SoloAlfaNumerico(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void SoloDecimal(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }    
        public void PermitirSoloNumerosDecimales(KeyPressEventArgs e, string cadena)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (e.KeyChar == (char)'.')
                    {
                        if (cadena.IndexOf('.') == -1)
                            e.Handled = false;
                        else
                            e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
        }
        public void TextoNumerosPuntoGuionTilde(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ':')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '_')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '´')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void SoloNumerico(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void NumeroTelefono(KeyPressEventArgs e)
        {
            string validar = "-0123456789";

            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (!(validar.IndexOf(e.KeyChar) >= 0))
            {
                e.Handled = true;
            }
        }
        public bool ValidarCorreoElectronico(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void Mensaje(string msj, Form fm)
        {
            DialogResult ds;
            ds = MessageBox.Show(fm, msj, "Sistema Punto de Venta CSL" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static bool invalid = false;
        public bool IsValidEmails(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
        public bool ValidarIFE(string cadena)
        {
            try
            {

                return Regex.IsMatch(cadena,
                         @"^\d{13}$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool ValidarTarjetaCreditoDebito(string cadena)
        {
            try
            {
                return Regex.IsMatch(cadena,
                         @"^\d{16}$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool ValidarCedulaProfesional(string cadena)
        {
            try
            {

                return Regex.IsMatch(cadena,
                       @"^\d{7}$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ValidarLicenciaConducir(string cadena)
        {
            try
            {
                return Regex.IsMatch(cadena,
                      @"^[A-Za-záéíóúñÁÉÍÓÚÑ0-9]*$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ValidarTarjetaCliente(string cadena)
        {
            try
            {
                return this.validarCodigoEAN13(cadena);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool validarCodigoEAN13(string code)
        {
            try
            {
                if (code == null || code.Length != 13)
                    return false;

                int res;
                foreach (char c in code)
                    if (!int.TryParse(c.ToString(), out res))
                        return false;

                char check = (char)('0' + CalculateChecksum(code.Substring(0, 12)));

                return code[12] == check;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int CalculateChecksum(string code)
        {
            try
            {

                if (code == null || code.Length != 12)
                    throw new ArgumentException("Code length should be 12, i.e. excluding the checksum digit");

                int sum = 0;
                for (int i = 0; i < 12; i++)
                {
                    int v;
                    if (!int.TryParse(code[i].ToString(), out v))
                        throw new ArgumentException("Invalid character encountered in specified code.");
                    sum += (i % 2 == 0 ? v : v * 3);
                }
                int check = 10 - (sum % 10);
                return check % 10;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
