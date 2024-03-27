using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.VentaBoletosGlobal;
using CreativaSL.Dll.VentaBoletosNegocio;
using System.Data;
using GenCode128;
namespace CreativaSL.WinForm.VentaBoletos
{

    public class ImprimirTicket
    {
        private Maletas infoMaletas = new Maletas();
        #region imprimirTicket

        int position_y = 0;
        int tipo_impresion = 0;
        Boleto datosboleto = new Boleto(Comun.Conexion);

        public void imprimirboleto(Boleto boleto, int opcion)
        {
            tipo_impresion = opcion;
            datosboleto = boleto;
            PrintDocument documento = new PrintDocument();
            PaperSize plantilla = new PaperSize("Ticket", 0, 0);
            switch (tipo_impresion)
            {
                case 1:
                    plantilla = new PaperSize("Ticket", 280, 880);
                    break;

                case 2:
                    plantilla = new PaperSize("Ticket", 280, 660);
                    break;

                case 3:
                    plantilla = new PaperSize("Ticket", 280, 700);
                    break;

                case 4:
                    plantilla = new PaperSize("Ticket", 280, 600);
                    break;

                default:
                    plantilla = new PaperSize("Ticket", 0, 0);
                    break;
            }
            documento.DefaultPageSettings.PaperSize = plantilla;
            documento.PrintPage += new PrintPageEventHandler(Document_PrintPage);
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = Comun.namePrinter_ticket;
            ps.DefaultPageSettings.PaperSize = plantilla;
            documento.PrinterSettings = ps;
            if (ps.IsValid)
                documento.Print();
        }
        void Document_PrintPage(object sender, PrintPageEventArgs e)
        {

            PrintDocument dc = (PrintDocument)sender;
            PaperSize plantilla;
            Graphics g = e.Graphics;
            SolidBrush Brush = new SolidBrush(Color.Black);
            PageSettings ps;

            switch (tipo_impresion)
            {
                case 1:
                    plantilla = new PaperSize("Ticket", 280, 880);
                    dc.DefaultPageSettings.PaperSize = plantilla;
                    ps = dc.DefaultPageSettings;
                    diseñoBoleto(ref g, Brush, ps);
                    break;
                case 2:
                    plantilla = new PaperSize("Ticket", 280, 660);
                    dc.DefaultPageSettings.PaperSize = plantilla;
                    ps = dc.DefaultPageSettings;
                    diseñoPago(ref g, Brush, ps);
                    break;
                case 3:
                    plantilla = new PaperSize("Ticket", 280, 700);
                    dc.DefaultPageSettings.PaperSize = plantilla;
                    ps = dc.DefaultPageSettings;
                    diseñoMaleta(ref g, Brush, ps);
                    break;
                case 4:
                    plantilla = new PaperSize("Ticket", 280,600);
                    dc.DefaultPageSettings.PaperSize = plantilla;
                    ps = dc.DefaultPageSettings;
                    diseñoVentaGrupal(ref g, Brush, ps);
                    break;

                default: break;
            }
        }

        private void diseñoBoleto(ref Graphics h, SolidBrush brush, PageSettings ps)
        {
            try
            {
                Reportes_Negocio reportes = new Reportes_Negocio();
                Image logoTicket = Image.FromFile(new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.url_logo_ticket.ToLower())).LocalPath);
                logoTicket = resizeImage(logoTicket, new Size(160, 100));
                h.DrawImage(logoTicket, 50, 0);
                PointF pf = new PointF();
                pf.X = 10;
                StringFormat sf = new StringFormat();


                sf.Alignment = StringAlignment.Near;
                int incrementoy = 15;
                int tamx = 260;

               // Image logoFolio = Code128Rendering.MakeBarcodeImage(datosboleto.folio.ToUpper(), 1, true);
               // logoFolio.Save(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\CodigoBarra\" + datosboleto.folio.ToUpper() + "." + "jpg"));
               // Image LogoFolio = Image.FromFile(new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\CodigoBarra\" + datosboleto.folio.ToLower() + "." + "jpg")).LocalPath);
               //// logoFolio = resizeImage(logoFolio, new Size(280, 40));
               //// h.DrawImage(LogoFolio, 0, 95, 280, 40);
               
               // pf.Y = position_y += incrementoy + 130;
                pf.Y = position_y += incrementoy + 100;
                this.addTitulos(ref h, ps, Comun.razonsocial_ticket, new Font("Arial", 12), StringAlignment.Center, ps.PaperSize.Width / 2);
                //this.addTitulos(ref h, ps, Comun.regimenFiscal, new Font("Arial", 10), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.rfc_ticket, new Font("Arial", 10), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.direccion_ticket, new Font("Arial", 8), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.Direccion, new Font("Arial", 7), StringAlignment.Center, ps.PaperSize.Width / 2);

                pf.Y = position_y += incrementoy;
                this.addTitulos(ref h, ps, "****Boleto Viaje****", new Font("Arial", 8), StringAlignment.Center, ps.PaperSize.Width / 2);


                this.addTextCenter("VÁLIDO PARA:", ref h, ps.PaperSize.Width, ps.PaperSize.Height);
                //Primer Línea
                pf.X = 10;
                pf.Y = position_y += incrementoy;
                h.DrawString("MARCA (LINEA):", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("SERVICIO:", new Font("Arial", 8), brush, pf, sf);
                //Segunda Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.lineaMarca.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.servicio.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                //Tercer Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("ORIGEN:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("TERMINAL DE SALIDA:", new Font("Arial", 8), brush, pf, sf);
                //Cuarta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.origen.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.terminalSalida.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                //Quinta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("DESTINO:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("TERMINAL DE LLEGADA:", new Font("Arial", 8), brush, pf, sf);
                //Sexta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.destino.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.terminalLlegada.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FECHA DE SALIDA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                h.DrawString("CORRIDA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("ASIENTO:", new Font("Arial", 8), brush, pf, sf);
                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.fechaSalida.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                h.DrawString(datosboleto.corrida, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.asiento.ToString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("HORA DE SALIDA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("PRECIO BOLETO:", new Font("Arial", 8), brush, pf, sf);
                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.horaSalida, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", datosboleto.total), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FOLIO:", new Font("Arial", 8), brush, pf, sf);
                pf.X = 120;
                sf.Alignment = StringAlignment.Near;
                h.DrawString("TIPO:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("DESCUENTO:", new Font("Arial", 8), brush, pf, sf);
                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.folio.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 120;
                sf.Alignment = StringAlignment.Near;
                h.DrawString(datosboleto.tipo.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", datosboleto.descuento), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FORMA DE PAGO:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("SUBTOTAL:", new Font("Arial", 8), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.formaPago.ToUpper(), new Font("Arial", 7, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", datosboleto.Subtotal), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);


                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("NOMBRE: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("IVA (" + string.Format("{0:F2}", datosboleto.porcIva) + "%)", new Font("Arial", 8), brush, pf, sf);


                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                if (datosboleto.cliente_nombre.Length > 25)
                    h.DrawString(datosboleto.cliente_nombre.Substring(0, 25).ToUpper(), new Font("Arial", 7, FontStyle.Bold), brush, pf, sf);
                else
                    h.DrawString(datosboleto.cliente_nombre.ToUpper(), new Font("Arial", 7, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", datosboleto.iva), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                pf.Y = position_y += incrementoy;
                h.DrawString("TOTAL PAGADO ", new Font("Arial", 8), brush, pf, sf);


                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                pf.Y = position_y += incrementoy;
                h.DrawString(string.Format("{0:C2}", datosboleto.precioIva), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                this.addletterspace('*', ref h, ps.PaperSize.Width, ps.PaperSize.Height, new Font("Arial", 7, FontStyle.Bold));

                this.addMensaje(ref h, ps, Comun.mensaje1_ticket.Replace(System.Environment.NewLine, " "), new Font("Arial", 5), StringAlignment.Near, 10);

                this.addletterspace('-', ref h, ps.PaperSize.Width, ps.PaperSize.Height, new Font("Arial", 7, FontStyle.Bold));

                //Parte que le queda a la empresa

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FECHA DE SALIDA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                h.DrawString("CORRIDA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("ASIENTO:", new Font("Arial", 8), brush, pf, sf);
                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.fechaSalida.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                h.DrawString(datosboleto.corrida, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.asiento.ToString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);


                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("HORA SALIDA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = 100;
                sf.Alignment = StringAlignment.Near;
                h.DrawString("FOLIO:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("TIPO:", new Font("Arial", 8), brush, pf, sf);
                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.horaSalida, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 100;
                sf.Alignment = StringAlignment.Near;
                h.DrawString(datosboleto.folio.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.tipo.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("NOMBRE: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("TOTAL PAGADO:", new Font("Arial", 8), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                if (datosboleto.cliente_nombre.Length > 25)
                    h.DrawString(datosboleto.cliente_nombre.Substring(0, 25).ToUpper(), new Font("Arial", 7, FontStyle.Bold), brush, pf, sf);
                else
                    h.DrawString(datosboleto.cliente_nombre.ToUpper(), new Font("Arial", 7, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", datosboleto.precioIva), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                this.addletterspace('-', ref h, ps.PaperSize.Width, ps.PaperSize.Height, new Font("Arial", 7, FontStyle.Bold));

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("VENDEDOR: ", new Font("Arial", 8), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                if (datosboleto.cajero.Length > 25)
                    h.DrawString(datosboleto.cajero.ToUpper().Substring(0, 25).ToUpper(), new Font("Arial", 7, FontStyle.Bold), brush, pf, sf);
                else
                    h.DrawString(datosboleto.cajero.ToUpper(), new Font("Arial", 7, FontStyle.Bold), brush, pf, sf);
                this.addletterspace('-', ref h, ps.PaperSize.Width, ps.PaperSize.Height, new Font("Arial", 7, FontStyle.Bold));
                Image logoFolio = Code128Rendering.MakeBarcodeImage(datosboleto.folio.ToUpper(), 1, true);
                h.DrawImage(logoFolio, 0, position_y += incrementoy, 280, 40);
                //logoFolio = resizeImage(logoFolio, new Size(280, 40));
                //h.DrawImage(logoFolio, 0, position_y += incrementoy);

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void diseñoPago(ref Graphics h, SolidBrush brush, PageSettings ps)
        {
            try
            {
                Reportes_Negocio reportes = new Reportes_Negocio();
                Image logoTicket = Image.FromFile(new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.url_logo_ticket.ToLower())).LocalPath);
                logoTicket = resizeImage(logoTicket, new Size(160, 100));
                h.DrawImage(logoTicket, 50, 0);
                PointF pf = new PointF();
                pf.X = 10;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                int incrementoy = 15;
                int tamx = 260;
                pf.Y = position_y += incrementoy + 100;


                this.addTitulos(ref h, ps, Comun.razonsocial_ticket, new Font("Arial", 12), StringAlignment.Center, ps.PaperSize.Width / 2);
                //this.addTitulos(ref h, ps, Comun.regimenFiscal, new Font("Arial", 10), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.rfc_ticket, new Font("Arial", 10), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.direccion_ticket, new Font("Arial", 8), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.Direccion, new Font("Arial", 7), StringAlignment.Center, ps.PaperSize.Width / 2);

                pf.Y = position_y += incrementoy;
                this.addTitulos(ref h, ps, "****Anticipo Boleto Viaje****", new Font("Arial", 8), StringAlignment.Center, ps.PaperSize.Width / 2);


                //Primer Línea
                position_y += 15;
                pf.X = 10;
                pf.Y = position_y += incrementoy;
                h.DrawString("FOLIO: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 90;
                h.DrawString(datosboleto.folio, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FECHA DE VENTA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("HORA DE VENTA:", new Font("Arial", 8), brush, pf, sf);
                //Cuarta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.fecha_venta.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.hora_venta, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                sf.Alignment = StringAlignment.Near;
                pf.X = 10;
                pf.Y = position_y += incrementoy;
                h.DrawString("CLIENTE: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 70;
                h.DrawString(datosboleto.cliente_nombre, new Font("Arial", 8), brush, pf, sf);

                //Tercer Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FECHA DE SALIDA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("HORA DE SALIDA:", new Font("Arial", 8), brush, pf, sf);
                //Cuarta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.fechaSalida.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.horaSalida, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("VENDEDOR: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 120;
                h.DrawString(datosboleto.cajero.ToUpper(), new Font("Arial", 8), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("ORIGEN:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("TERMINAL DE SALIDA:", new Font("Arial", 8), brush, pf, sf);
                //Cuarta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.origen.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.terminalSalida.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                //Quinta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("DESTINO:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("TERMINAL DE LLEGADA:", new Font("Arial", 8), brush, pf, sf);
                //Sexta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.destino.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.terminalLlegada.ToUpper(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FECHA DE SALIDA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                h.DrawString("CORRIDA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("ASIENTO:", new Font("Arial", 8), brush, pf, sf);
                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.fechaSalida.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                h.DrawString(datosboleto.corrida, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.asiento.ToString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("PRECIO BOLETO: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("DESCUENTO: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(string.Format("{0:C2}", datosboleto.total), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", datosboleto.descuento), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("SUBTOTAL: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("IVA (" + string.Format("{0:F2}", datosboleto.porcIva) + "%): ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(string.Format("{0:C2}", datosboleto.Subtotal), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", datosboleto.iva), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("TOTAL: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 110;
                sf.Alignment = StringAlignment.Near;
                h.DrawString("PAGO: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("PENDIENTE: ", new Font("Arial", 8), brush, pf, sf);
                //Septima Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(string.Format("{0:C2}", datosboleto.precioIva), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 110;
                sf.Alignment = StringAlignment.Near;
                h.DrawString(string.Format("{0:C2}", datosboleto.pago), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", datosboleto.pendiente), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                position_y += 10;

                this.addletterspace('*', ref h, ps.PaperSize.Width, ps.PaperSize.Height, new Font("Arial", 7, FontStyle.Bold));
                this.addMensaje(ref h, ps, Comun.mensaje2_ticket.Replace(System.Environment.NewLine, " "), new Font("Arial", 5), StringAlignment.Near, 10);
                this.addletterspace('-', ref h, ps.PaperSize.Width, ps.PaperSize.Height, new Font("Arial", 7, FontStyle.Bold));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void diseñoMaleta(ref Graphics h, SolidBrush brush, PageSettings ps)
        {
            try
            {

                Reportes_Negocio reportes = new Reportes_Negocio();
                Maletas impMaletas = new Maletas();
                int tamx = 260;
                impMaletas = this.obtenerDatosTicketMaleta(datosboleto);
                Image logoTicket = Image.FromFile(new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.url_logo_ticket.ToLower())).LocalPath);
                logoTicket = resizeImage(logoTicket, new Size(160, 100));
                h.DrawImage(logoTicket, 50, 0);
                PointF pf = new PointF();
                pf.X = 10;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                int incrementoy = 15;
                pf.Y = position_y += incrementoy + 100;


                this.addTitulos(ref h, ps, Comun.razonsocial_ticket, new Font("Arial", 12), StringAlignment.Center, ps.PaperSize.Width / 2);
                //this.addTitulos(ref h, ps, Comun.regimenFiscal, new Font("Arial", 10), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.rfc_ticket, new Font("Arial", 10), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.direccion_ticket, new Font("Arial", 8), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.Direccion, new Font("Arial", 7), StringAlignment.Center, ps.PaperSize.Width / 2);

                pf.Y = position_y += incrementoy;
                this.addTitulos(ref h, ps, "****Cobro Extra Equipaje ****", new Font("Arial", 8), StringAlignment.Center, ps.PaperSize.Width / 2);


                //Primer Línea
                position_y += 15;
                pf.X = 10;
                pf.Y = position_y += incrementoy;
                h.DrawString("FOLIO: Boleto", new Font("Arial", 8), brush, pf, sf);
                pf.X = 90;
                h.DrawString(impMaletas.folioBoleto, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FECHA DE VENTA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("HORA DE VENTA:", new Font("Arial", 8), brush, pf, sf);
                //Cuarta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(impMaletas.fechaVenta.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(impMaletas.horaVenta, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                sf.Alignment = StringAlignment.Near;
                pf.X = 10;
                pf.Y = position_y += incrementoy;
                h.DrawString("CLIENTE: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 90;
                h.DrawString(impMaletas.cliente, new Font("Arial", 8), brush, pf, sf);

                position_y += 10;

                //Tercer Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FECHA DE SALIDA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("HORA DE SALIDA:", new Font("Arial", 8), brush, pf, sf);
                //Cuarta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(impMaletas.fechaSalida.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(impMaletas.horaSalida, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);



                position_y += 10;


                agregarEncabezadoContenidoMaleta(ref h);
                agregarDatosContenidoMaleta(ref h, impMaletas);


                pf.Y = position_y += incrementoy;
                pf.Y = position_y += incrementoy;

                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("IMPORTE: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 110;

                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", impMaletas.precioMaleta), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);


                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("IVA: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 110;

                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", 0.0), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                //h.DrawString(string.Format("{0:c}", impMaletas.IVA), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("TOTAL: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 110;

                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", impMaletas.precioMaletaTotal), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                position_y += 10;

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("VENDEDOR: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 120;
                h.DrawString(impMaletas.cajero.ToUpper(), new Font("Arial", 8), brush, pf, sf);



                this.addletterspace('*', ref h, ps.PaperSize.Width, ps.PaperSize.Height, new Font("Arial", 7, FontStyle.Bold));
                this.addMensaje(ref h, ps, Comun.mensaje3_ticket.Replace(System.Environment.NewLine, " "), new Font("Arial", 5), StringAlignment.Near, 10);
                this.addletterspace('-', ref h, ps.PaperSize.Width, ps.PaperSize.Height, new Font("Arial", 7, FontStyle.Bold));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void diseñoVentaGrupal(ref Graphics h, SolidBrush brush, PageSettings ps)
        {
            try
            {
                Reportes_Negocio reportes = new Reportes_Negocio();
                Image logoTicket = Image.FromFile(new Uri(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + Comun.url_logo_ticket.ToLower())).LocalPath);
                logoTicket = resizeImage(logoTicket, new Size(160, 100));
                h.DrawImage(logoTicket, 50, 0);
                PointF pf = new PointF();
                pf.X = 10;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                int incrementoy = 15;
                int tamx = 260;
                pf.Y = position_y += incrementoy + 100;


                this.addTitulos(ref h, ps, Comun.razonsocial_ticket, new Font("Arial", 12), StringAlignment.Center, ps.PaperSize.Width / 2);
                //this.addTitulos(ref h, ps, Comun.regimenFiscal, new Font("Arial", 10), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.rfc_ticket, new Font("Arial", 10), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.direccion_ticket, new Font("Arial", 8), StringAlignment.Center, ps.PaperSize.Width / 2);
                this.addTitulos(ref h, ps, Comun.Direccion, new Font("Arial", 7), StringAlignment.Center, ps.PaperSize.Width / 2);

                pf.Y = position_y += incrementoy;
                this.addTitulos(ref h, ps, "****Venta Grupal Boletos****", new Font("Arial", 8), StringAlignment.Center, ps.PaperSize.Width / 2);


                //Primer Línea
                position_y += 15;
                pf.X = 10;
                pf.Y = position_y += incrementoy;
                h.DrawString("FOLIO: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 90;
                h.DrawString(datosboleto.folio, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FECHA DE VENTA:", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("HORA DE VENTA:", new Font("Arial", 8), brush, pf, sf);
                //Cuarta Línea
                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.fecha_venta.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(datosboleto.hora_venta, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                sf.Alignment = StringAlignment.Near;
                pf.X = 10;
                pf.Y = position_y += incrementoy;
                h.DrawString("CLIENTE: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 70;
                h.DrawString(datosboleto.cliente_nombre, new Font("Arial", 8), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("Origen: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                h.DrawString("Destino: ", new Font("Arial", 8), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.origen, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 140;
                sf.Alignment = StringAlignment.Near;
                h.DrawString(datosboleto.destino, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("FECHA: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 80;
                sf.Alignment = StringAlignment.Near;
                h.DrawString("HORA: ", new Font("Arial", 8), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.fechaSalida.ToShortDateString(), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 80;
                sf.Alignment = StringAlignment.Near;
                h.DrawString(datosboleto.horaSalida, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("ASIENTO: ", new Font("Arial", 8), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(datosboleto.asientoText, new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("VENDEDOR: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 120;
                h.DrawString(datosboleto.cajero.ToUpper(), new Font("Arial", 8), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString("TOTAL: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = 110;
                sf.Alignment = StringAlignment.Near;
                h.DrawString("PAGO: ", new Font("Arial", 8), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString("PENDIENTE: ", new Font("Arial", 8), brush, pf, sf);

                pf.X = 10;
                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += incrementoy;
                h.DrawString(string.Format("{0:C2}", datosboleto.precioIva), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = 110;
                sf.Alignment = StringAlignment.Near;
                h.DrawString(string.Format("{0:C2}", datosboleto.pago), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);
                pf.X = tamx;
                sf.Alignment = StringAlignment.Far;
                h.DrawString(string.Format("{0:C2}", datosboleto.pendiente), new Font("Arial", 8, FontStyle.Bold), brush, pf, sf);

                position_y += 10;

                this.addletterspace('*', ref h, ps.PaperSize.Width, ps.PaperSize.Height, new Font("Arial", 7, FontStyle.Bold));
                this.addMensaje(ref h, ps, Comun.mensaje2_ticket.Replace(System.Environment.NewLine, " "), new Font("Arial", 5), StringAlignment.Near, 10);
                this.addletterspace('-', ref h, ps.PaperSize.Width, ps.PaperSize.Height, new Font("Arial", 7, FontStyle.Bold));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void agregarEncabezadoContenidoMaleta(ref Graphics g)
        {
            try
            {
                SolidBrush Brush = new SolidBrush(Color.Black);
                PointF pf = new PointF();
                StringFormat sf = new StringFormat();
                pf.X = 10;
                pf.Y = position_y += 15;
                sf.Alignment = StringAlignment.Near;
                g.DrawString("Folio", new Font("Arial", 9), Brush, pf, sf);
                pf.X = 80;
                g.DrawString("Descripcion", new Font("Arial", 9), Brush, pf, sf);
                pf.X = 190;
                g.DrawString("Cant.", new Font("Arial", 9), Brush, pf, sf);
                pf.X = 230;
                g.DrawString("Precio", new Font("Arial", 9), Brush, pf, sf);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void agregarDatosContenidoMaleta(ref Graphics g, Maletas impMaletas)
        {
            try
            {
                SolidBrush Brush = new SolidBrush(Color.Black);
                PointF pf = new PointF();
                StringFormat sf = new StringFormat();


                sf.Alignment = StringAlignment.Near;
                pf.Y = position_y += 15;
                pf.X = 10;
                g.DrawString(impMaletas.folioMaleta, new Font("Arial", 8), Brush, pf, sf);
                pf.X = 80;
                if (impMaletas.descripcion.Length > 18)
                    g.DrawString(impMaletas.descripcion.ToString().Substring(0, 18), new Font("Arial", 8), Brush, pf, sf);
                else
                    g.DrawString(impMaletas.descripcion.ToString(), new Font("Arial", 8), Brush, pf, sf);
                sf.Alignment = StringAlignment.Far;
                pf.X = 220;
                g.DrawString(impMaletas.numeroMaletas.ToString(), new Font("Arial", 8), Brush, pf, sf);

                pf.X = 270;
                g.DrawString(string.Format("{0:C2}", impMaletas.precioMaletaTotal), new Font("Arial", 8), Brush, pf, sf);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Maletas obtenerDatosTicketMaleta(Boleto boleto)
        {
            try
            {
                Ticket_Negocio tn = new Ticket_Negocio();
                return tn.obtenerDatosMaleta(Comun.Conexion, boleto.id_boleto, boleto.id_maleta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void addTextCenter(string text, ref Graphics h, int max_x, int max_y)
        {
            SolidBrush Brush = new SolidBrush(Color.Black);
            PointF pf = new PointF();
            pf.X = max_x / 2;
            pf.Y = position_y += 15;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            h.DrawString(text, new Font("Arial", 9), Brush, pf, sf);
        }
        private void addTextLeft(string text, ref Graphics h, int max_x, int max_y)
        {
            SolidBrush Brush = new SolidBrush(Color.Black);
            PointF pf = new PointF();
            pf.X = 10;
            pf.Y = position_y += 15;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            h.DrawString(text, new Font("Arial", 9), Brush, pf, sf);
        }
        private void addTextRigth(string text, ref Graphics h, int max_x, int max_y)
        {
            SolidBrush Brush = new SolidBrush(Color.Black);
            PointF pf = new PointF();
            pf.X = max_x - 10;
            pf.Y = position_y += 15;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far;
            h.DrawString(text, new Font("Arial", 9), Brush, pf, sf);
        }
        private void addImageCenter(string url, ref Graphics h, int max_x, int max_y)
        {
            try
            {
                PointF pf = new PointF();
                Image imagen = Image.FromFile(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\documents\" + url));

                float x = imagen.HorizontalResolution; //Ancho pixeles por pulgada
                float y = imagen.VerticalResolution; //Alto pixeles por pulgada
                int tampx = imagen.Width; //Ancho en pixeles de la imagen
                int tampy = imagen.Height; //alto en pixeles de la imagen
                float pulgadasx = tampx / x;  //Ancho en pulgadas de la imagen
                float pulgadasy = tampy / y;  //Alto en pulgadas de la imagen
                //max_x esta en centesimas de  pulgada
                //max_y esta en centesimas de pulgada
                float ancho = pulgadasx * 100;
                float alto = pulgadasy * 100;
                pf.Y = position_y += 15;
                int width = 0;
                int heigth = 0;
                if (ancho > max_x)
                {
                    int diferencia = Convert.ToInt32(ancho - (max_x - 10));
                    float facdif = (diferencia * 100) / ancho;
                    width = max_x;
                    heigth = Convert.ToInt32(alto - (alto * (facdif / 100)));
                    pf.X = 5;
                }
                else
                {
                    width = Convert.ToInt32(ancho);
                    heigth = Convert.ToInt32(alto);
                    int positionx = 0;
                    positionx = (int)(max_x / 2);
                    positionx = positionx - Convert.ToInt32((ancho / 2));
                    pf.X = positionx;
                }


                h.DrawImage(imagen, pf.X, pf.Y, width, heigth);
                position_y += heigth;
            }
            catch (Exception ex)
            {

            }
        }
        private void addletterspace(char letra, ref Graphics h, int max_x, int may_y, Font fuente)
        {
            try
            {
                string cadena = "";
                while (h.MeasureString(cadena, fuente).Width < (max_x - 10))
                {
                    cadena += letra;
                }
                SolidBrush Brush = new SolidBrush(Color.Black);
                PointF pf = new PointF();
                pf.X = 10;
                pf.Y = position_y += 15;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                h.DrawString(cadena, fuente, Brush, pf, sf);
            }
            catch (Exception ex)
            {
            }
        }
        private void agregarEncabezadoContenido(ref Graphics g)
        {
            try
            {
                SolidBrush Brush = new SolidBrush(Color.Black);
                PointF pf = new PointF();
                StringFormat sf = new StringFormat();
                pf.X = 10;
                pf.Y = position_y += 15;
                sf.Alignment = StringAlignment.Near;
                g.DrawString("Cant", new Font("Arial", 9), Brush, pf, sf);
                pf.X = 50;
                g.DrawString("Concepto", new Font("Arial", 9), Brush, pf, sf);
                pf.X = 180;
                g.DrawString("P.U.", new Font("Arial", 9), Brush, pf, sf);
                pf.X = 220;
                g.DrawString("Importe", new Font("Arial", 9), Brush, pf, sf);
            }
            catch (Exception ex)
            {
            }
        }
        private void addTitulos(ref Graphics g, PageSettings ps, string mensaje, Font fuente, StringAlignment sa, int px)
        {
            try
            {
                SolidBrush Brush = new SolidBrush(Color.Black);
                PointF pf = new PointF();
                pf.X = px;
                pf.Y = position_y;
                StringFormat sf = new StringFormat();
                sf.Alignment = sa;

                string cadena = "", palabra = "", lastcadena = "", lastpalabra = "";
                int i = 0;

                while (i < mensaje.Length)
                {
                    while (g.MeasureString(cadena, fuente).Width < (ps.PaperSize.Width - 20) && i < mensaje.Length)
                    {
                        while (mensaje[i] != ' ')
                        {
                            palabra += mensaje[i];
                            i++;
                            if (i >= mensaje.Length)
                                break;
                        }
                        palabra += ' ';
                        i++;
                        lastcadena = cadena;
                        lastpalabra = palabra;
                        cadena += palabra;
                        palabra = "";
                    }
                    if (i >= mensaje.Length)
                    {
                        g.DrawString(cadena, fuente, Brush, pf, sf);
                        pf.Y = position_y += 18;
                    }
                    else
                    {
                        g.DrawString(lastcadena, fuente, Brush, pf, sf);
                        pf.Y = position_y += 18;
                        cadena = lastpalabra;
                    }
                }
                //pf.Y = position_y += 5;
            }
            catch (Exception ex)
            {
            }
        }
        private void addMensaje(ref Graphics g, PageSettings ps, string mensaje, Font fuente, StringAlignment sa, int px)
        {
            try
            {
                SolidBrush Brush = new SolidBrush(Color.Black);
                PointF pf = new PointF();
                pf.X = px;
                pf.Y = position_y += 15;
                StringFormat sf = new StringFormat();
                sf.Alignment = sa;

                string cadena = "", palabra = "", lastcadena = "", lastpalabra = "";
                int i = 0;

                while (i < mensaje.Length)
                {
                    while ((g.MeasureString(cadena, fuente).Width < (ps.PaperSize.Width - 20)) && i < mensaje.Length)
                    {
                        while (mensaje[i] != ' ')
                        {
                            palabra += mensaje[i];
                            i++;
                            if (i >= mensaje.Length)
                                break;
                        }
                        palabra += ' ';
                        i++;
                        lastcadena = cadena;
                        lastpalabra = palabra;
                        cadena += palabra;
                        palabra = "";
                    }
                    if (i >= mensaje.Length)
                    {
                        g.DrawString(cadena, fuente, Brush, pf, sf);
                        pf.Y = position_y += 15;
                    }
                    else
                    {
                        g.DrawString(lastcadena, fuente, Brush, pf, sf);
                        pf.Y = position_y += 15;
                        cadena = lastpalabra;
                    }
                }
                pf.Y = position_y += 5;
            }
            catch (Exception ex)
            {
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        #endregion
    }
}

