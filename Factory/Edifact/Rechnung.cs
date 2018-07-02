using System;

namespace Edifact
{
    public class Rechnung : IEdifactMessage
    {
        public string MessageId { get; } = "INVOIC";
        public string Version { get; } = "2.3c";
        public DateTime TimestampUtc { get; set; }
    }
}
