using PrototypePattern;

public class Program
{
    public static void Main()
    {
        Invoice NewInvoice = new Invoice(new Guid(), "SAL", DateTime.Now, 1000);
        
        //Some Code 
        
        Invoice NewInvoice2 = NewInvoice.Clone() as Invoice;

        NewInvoice.TotalAmount = 0;
        
        Console.WriteLine(NewInvoice.TotalAmount);
        Console.WriteLine(NewInvoice2.TotalAmount);
    }
}