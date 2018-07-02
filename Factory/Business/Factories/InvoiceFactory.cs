using System;
using Business.BusinessObjects;
using Edifact;

namespace Business.Factories
{
    public class InvoiceFactory : IBusinessMessageFactory
    {
        public Predicate<IEdifactMessage> Predicate { get; } =
            edi => edi.MessageId == "INVOIC" && edi.Version == "2.3c";

        public IBusinessMessage GetMessage(IEdifactMessage edifactMessage)
        {
            return new Invoice
            {
                Id = Guid.NewGuid(),
                Timestamp = edifactMessage.TimestampUtc
            };
        }
    }
}
