using System;
using Business;
using Business.BusinessObjects;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var contract = new Contract
            {
                Id = 42,
                Positions = new[]
                {
                    new ContractPosition
                    {
                        Amount = 3,
                        Type = "pen",
                    },
                    new ContractPosition
                    {
                        Amount = 1,
                        Type = "book"
                    }
                }
            };

            InvoiceProcessor processor = new CloudInvoiceProcessor();
            //InvoiceProcessor processor = new LocalInvoiceProcessor();
            processor.InvoiceAndExport(contract);

            Console.ReadLine();
        }
    }
}
