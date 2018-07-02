using System;
using System.Collections.Generic;
using System.Text;

namespace Business.BusinessObjects
{
    public class Invoice : IBusinessMessage
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
