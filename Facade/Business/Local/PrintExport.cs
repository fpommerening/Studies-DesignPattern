using System;
using Business.BusinessObjects;

namespace Business.Local
{
    internal class PrintExport
    {
        public void CreatePrintDocument(Invoice invoice)
        {
            Console.WriteLine("Create Print Document");
            Console.WriteLine("##############################");
            foreach (var pos in invoice.Positions)
            {
                Console.WriteLine($"{pos.Number} | {pos.Amount} | {pos.UnitPrice} | {pos.PosPrice}");
            }
            Console.WriteLine("##############################");
        }
    }
}

