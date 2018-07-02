using System;

namespace Business.BusinessObjects
{
    public class Measurement : IBusinessMessage
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
