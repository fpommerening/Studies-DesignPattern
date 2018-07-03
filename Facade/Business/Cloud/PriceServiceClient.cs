using Business.BusinessObjects;

namespace Business.Cloud
{
    internal class PriceServiceClient
    {
        public PriceList GetPriceListFromService()
        {
            return new PriceList
            {
                {"book", 24.6m },
                {"pen", 4.55m }
            };
        }
    }
}
