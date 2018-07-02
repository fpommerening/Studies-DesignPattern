using System;
using Business.BusinessObjects;
using Edifact;

namespace Business.Factories
{
    public class MeasurementFactory : IBusinessMessageFactory
    {
        public Predicate<IEdifactMessage> Predicate { get; } =
            edi => edi.MessageId == "MSCONS" && edi.Version == "2.2h";

        public IBusinessMessage GetMessage(IEdifactMessage edifactMessage)
        {
            return new Measurement
            {
                Id = Guid.NewGuid(),
                Timestamp = edifactMessage.TimestampUtc
            };
        }
    }
}
