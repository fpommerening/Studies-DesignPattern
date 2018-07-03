using System.Collections.Generic;

namespace Business.BusinessObjects
{
    internal class Invoice
    {
        public Invoice()
        {
            Positions = new List<InvoicePosition>();
        }
        public int Id { get; set; }

        public List<InvoicePosition> Positions { get; }
    }

    internal class InvoicePosition
    {
        public int Number { get; set; }

        public int Amount { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal PosPrice { get; set; }
    }
}
