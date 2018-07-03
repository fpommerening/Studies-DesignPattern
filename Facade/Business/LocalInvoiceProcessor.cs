using Business.BusinessObjects;
using Business.Local;

namespace Business
{
    public class LocalInvoiceProcessor : InvoiceProcessor
    {
        private readonly PriceFile _file = new PriceFile();
        private readonly PrintExport  _export = new PrintExport();

        public override void InvoiceAndExport(Contract contract)
        {
            var priceList = _file.LoadPriceList();
            var invoice = new Invoice();
            invoice.Positions.AddRange(Calculate(contract, priceList));
            _export.CreatePrintDocument(invoice);
        }
    }
}
