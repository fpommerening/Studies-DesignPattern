using System;

namespace Business
{
    public interface IBusinessMessage
    {
        Guid Id { get; set; }

        DateTime Timestamp { get; set; }
    }
}
