using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;


namespace ReservationApp.Panel.UI.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");

            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf");
            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf","application/pdf","dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");

            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);
            //1. kullanıcı
            pdfPTable.AddCell("Misafir Adı:");
            pdfPTable.AddCell("Misafir Soyadı:");
            pdfPTable.AddCell("Misafir TC:");

            pdfPTable.AddCell("Deneme");
            pdfPTable.AddCell("Kullanıcı");
            pdfPTable.AddCell("111111111");
            //2. kullanıcı
            pdfPTable.AddCell("Deneme");
            pdfPTable.AddCell("Kullanıcı2");
            pdfPTable.AddCell("2222222222");
            //3. Kullanıcı
            pdfPTable.AddCell("Deneme");
            pdfPTable.AddCell("Kullanıcı3");
            pdfPTable.AddCell("33333333");

            document.Add(pdfPTable);
            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya1.pdf");
        }
    }
}
