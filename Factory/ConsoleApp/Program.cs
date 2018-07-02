using System;
using Business;
using Business.Factories;
using Edifact;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var factoryImpl = new IBusinessMessageFactory[]
                {
                    new CancellationFactory(),
                    new InvoiceFactory(), 
                    new MeasurementFactory()
                };

                var boMessageFactory = new BusinessMessageFactory(factoryImpl);

                var kündigung = new Kündigung { TimestampUtc = DateTime.UtcNow };
                var messwert = new Messwert { TimestampUtc = DateTime.UtcNow };
                var rechnung = new Rechnung { TimestampUtc = DateTime.UtcNow };

                var boMessage = boMessageFactory.GetMessage(rechnung);

                Console.WriteLine(boMessage);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
