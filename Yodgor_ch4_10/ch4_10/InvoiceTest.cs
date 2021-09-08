using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_10
{
    class InvoiceTest
    {
        static void Main()
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 1, 14.95M);
            // display invoice1
            Console.WriteLine("Original invoice information");
            Console.WriteLine($"Part number: {invoice1.PNumber}");
            Console.WriteLine($"Description: {invoice1.partDescription}");
            Console.WriteLine($"Quantity: {invoice1.QPurchased}");
            Console.WriteLine($"Price: {invoice1.PriceperItem:C}");
            Console.WriteLine($"Invoice amount: {invoice1.GetInvoiceAmount():C}");

            // change invoice1's data
            invoice1.PNumber = "001234";
            invoice1.partDescription = "Yellow Hammer";
            invoice1.QPurchased = 3;
            invoice1.PriceperItem = 19.49M;

            // display invoice1 with new data
            Console.WriteLine("\nUpdated invoice information");
            Console.WriteLine($"Part number: {invoice1.PNumber}");
            Console.WriteLine($"Description: {invoice1.partDescription}");
            Console.WriteLine($"Quantity: {invoice1.QPurchased}");
            Console.WriteLine($"Price: {invoice1.PriceperItem:C}");
            Console.WriteLine($"Invoice amount: {invoice1.GetInvoiceAmount():C}");

            Invoice invoice2 = new Invoice("5678", "PaintBrush", -5, -9.99M);

            // display invoice2
            Console.WriteLine("\nOriginal invoice information");
            Console.WriteLine($"Part number: {invoice2.PNumber}");
            Console.WriteLine($"Description: {invoice2.partDescription}");
            Console.WriteLine($"Quantity: {invoice2.QPurchased}");
            Console.WriteLine($"Price: {invoice2.PriceperItem:C}");
            Console.WriteLine($"Invoice amount: {invoice2.GetInvoiceAmount():C}");

            // change invoice2's data
            invoice2.QPurchased = 3;
            invoice2.PriceperItem = 9.49M;

            // display invoice2 with new data
            Console.WriteLine("\nUpdated invoice information");
            Console.WriteLine($"Part number: {invoice2.PNumber}");
            Console.WriteLine($"Description: {invoice2.partDescription}");
            Console.WriteLine($"Quantity: {invoice2.QPurchased}");
            Console.WriteLine($"Price: {invoice2.PriceperItem:C}");
            Console.WriteLine($"Invoice amount: {invoice2.GetInvoiceAmount():C}");
        }
    }
}
