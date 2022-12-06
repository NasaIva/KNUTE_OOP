namespace Lab3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(666, "Anastasiia", "PM");
            Console.WriteLine(invoice.CalculateValueOrder());
        }
    }
}
