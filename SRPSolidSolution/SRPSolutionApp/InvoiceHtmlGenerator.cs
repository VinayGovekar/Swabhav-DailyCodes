using System;
using System.Text;
using System.IO;

namespace SRPSolutionApp
{
    public class InvoiceHtmlGenerator
    {
        public void GenerateHTML(Invoice invoice)
        {
            StringBuilder htmlString = new StringBuilder();
            htmlString.Append("<html><head><title>"+invoice.Description+"</title></head><body>");
            htmlString.Append("<table><tr><th>Invoice Details</th></tr><tr><td>Invoice ID</td><td>"+Convert.ToString(invoice.ID)+"</td></tr>");
            htmlString.Append("<tr><td>Description</td><td>" + invoice.Description + "</td></tr>");
            htmlString.Append("<tr><td>Amount</td><td>" + Convert.ToString(invoice.Amount) + "</td></tr>");
            htmlString.Append("<tr><td>Tax</td><td>" + Convert.ToString(invoice.Tax) + "%</td></tr>");
            htmlString.Append("<tr><td>Discount</td><td>" + Convert.ToString(invoice.Discount) + "%</td></tr>");
            htmlString.Append("<tr><td>Tax Amount</td><td>" + Convert.ToString(invoice.CalculateTax()) + "</td></tr>");
            htmlString.Append("<tr><td>Discount Amount</td><td>" +Convert.ToString(invoice.CalculateDiscount())+ "</td></tr>");
            htmlString.Append("<tr><td>Final Amount</td><td>" +Convert.ToString(invoice.CalculateFinalAmount()) + 
                              "</td></tr></table></body></html>");
            SaveToFile(Directory.GetCurrentDirectory()+"//invoice.html", htmlString);
        }
        private void SaveToFile(string fileName,StringBuilder data)
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            File.WriteAllText(fileName,data.ToString());
        }
    }
}
