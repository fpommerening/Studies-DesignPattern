using System;

namespace Edifact
{
    public interface IEdifactMessage
    {
        string MessageId { get; }

        string Version { get;  }

        DateTime TimestampUtc { get; }
    }
}
