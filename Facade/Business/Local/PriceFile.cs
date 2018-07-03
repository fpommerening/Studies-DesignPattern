using Business.BusinessObjects;

namespace Business.Local
{
    internal class PriceFile
    {
        public PriceList LoadPriceList()
        {
            return new PriceList
            {
                {"book", 24.6m },
                {"pen", 4.55m }
            };
        }
    }
}
