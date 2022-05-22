using Invoices.Domain.Entities;

namespace Invoices.Application;

public static class Mappings 
{
    public static InvoiceDto ToDto(this Invoice invoice) 
    {
        return new InvoiceDto(invoice.Id, invoice.Date, invoice.Status, invoice.Items.Select(i => i.ToDto()),   invoice.SubTotal, invoice.Vat, invoice.VatRate, invoice.Total, invoice.Paid);
    }

    public static InvoiceItemDto ToDto(this InvoiceItem item) 
    {
        return new InvoiceItemDto(item.Id, item.Description, item.UnitPrice, item.VatRate, item.Quantity, item.LineTotal);
    }
}