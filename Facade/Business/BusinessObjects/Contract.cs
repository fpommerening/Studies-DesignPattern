using System.Collections.Generic;

namespace Business.BusinessObjects
{
    public class Contract
    {
        public int Id { get; set; }

        public IEnumerable<ContractPosition> Positions { get; set; }
    }

    public class ContractPosition
    {
        public string Type { get; set; }

        public int Amount { get; set; }
    }
}
