using System;
using Business.BusinessObjects;

namespace Business.Cloud
{
    internal class PdfExport
    {
        public void CreatePdf(Invoice invoice)
        {
            Console.WriteLine("Create PDF");
            Console.WriteLine("##############################");
            foreach (var pos in invoice.Positions)
            {
                Console.WriteLine($"{pos.Number} | {pos.Amount} | {pos.UnitPrice} | {pos.PosPrice}");
            }
            Console.WriteLine("##############################");
        }

    }
}
