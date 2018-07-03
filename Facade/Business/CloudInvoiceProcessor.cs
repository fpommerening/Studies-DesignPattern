using Business.BusinessObjects;
using Business.Cloud;

namespace Business
{
    public class CloudInvoiceProcessor : InvoiceProcessor
    {
        private readonly PriceServiceClient _client = new PriceServiceClient();
        private readonly PdfExport _export = new PdfExport();

        public override void InvoiceAndExport(Contract contract)
        {
            var priceList = _client.GetPriceListFromService();
            var invoice = new Invoice();
            invoice.Positions.AddRange(Calculate(contract, priceList));
            _export.CreatePdf(invoice);
        }
    }
}
