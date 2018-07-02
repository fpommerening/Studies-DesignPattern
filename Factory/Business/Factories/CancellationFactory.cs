using System;
using Business.BusinessObjects;
using Edifact;

namespace Business.Factories
{
    public class CancellationFactory : IBusinessMessageFactory
    {
        public Predicate<IEdifactMessage> Predicate { get; } = 
            edi => edi.MessageId == "UTILMD" && edi.Version == "5.1g";

        public IBusinessMessage GetMessage(IEdifactMessage edifactMessage)
        {
            return new Cancellation
            {
                Id = Guid.NewGuid(),
                Timestamp = edifactMessage.TimestampUtc
            };
        }
    }
}
