using System;
using System.Collections.Generic;
using System.Text;

namespace Edifact
{
    public class Kündigung : IEdifactMessage
    {
        public string MessageId { get; } = "UTILMD";
        public string Version { get; } = "5.1g";
        public DateTime TimestampUtc { get; set; }
    }
}
