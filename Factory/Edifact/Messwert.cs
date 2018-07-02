using System;

namespace Edifact
{
    public class Messwert : IEdifactMessage
    {
        public string MessageId { get; } = "MSCONS";
        public string Version { get; } = "2.2h";
        public DateTime TimestampUtc { get; set; }
    }
}
