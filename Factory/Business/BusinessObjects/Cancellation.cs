using System;

namespace Business.BusinessObjects
{
    public class Cancellation : IBusinessMessage
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
