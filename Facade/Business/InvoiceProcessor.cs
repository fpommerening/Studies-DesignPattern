using System.Collections.Generic;
using System.Linq;
using Business.BusinessObjects;

namespace Business
{
    public abstract class InvoiceProcessor
    {
        public abstract void InvoiceAndExport(Contract contract);

        internal virtual IEnumerable<InvoicePosition> Calculate(Contract contract, PriceList priceList)
        {
            int pos = 1;

            foreach (var conPos in contract.Positions.GroupBy(x=>x.Type))
            {
                var invPos = new InvoicePosition
                {
                    Amount = conPos.Sum(x => x.Amount),
                    Number = pos,
                    UnitPrice = priceList[conPos.Key],
                    PosPrice = conPos.Sum(x => x.Amount) * priceList[conPos.Key]
                };
                pos++;
                yield return invPos;
            }
            
        }
    }
}
