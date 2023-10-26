namespace PrototypePattern;

public class Invoice
{
    public Guid Id { get; set; }
    public string Prefix { get; set; }
    public DateTime InvoiceDate { get; set; }
    public decimal TotalAmount { get; set; }
    public List<object> InvoiceItems { get; set; }

    public Invoice(Guid id , string prefix , DateTime invoiceDate , decimal totalAmount)
    {
        Id = id;
        Prefix = prefix;
        InvoiceDate = invoiceDate;
        TotalAmount = totalAmount;
    }
    public Invoice Clone()
    {
        return new Invoice(Id, Prefix, InvoiceDate, TotalAmount);
    }
}