using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesYodgor_ch9_3
{
    class InvoiceTest
    {
        public static void Main(string[] args)
        {
            // initialize array of invoices
            Invoice[] invoices = {
         new Invoice( 83, "Electric sander", 7, 57.98M ),
         new Invoice( 24, "Power saw", 18, 99.99M ),
         new Invoice( 7, "Sledge hammer", 11, 21.5M ),
         new Invoice( 77, "Hammer", 76, 11.99M ),
         new Invoice( 39, "Lawn mower", 3, 79.5M ),
         new Invoice( 68, "Screwdriver", 106, 6.99M ),
         new Invoice( 56, "Jig saw", 21, 11M ),
         new Invoice( 3, "Wrench", 34, 7.5M ) }; // end initializer list

            // use LINQ to sort invoices by description
            var sortedByDescription = from item in invoices orderby item.PartDescription select item;

            //extensiion methods and lambda operator
            var sortedByDescription2 = invoices.OrderBy(item => item.PartDescription);

            // display invoices, sorted by description
            Console.WriteLine("Sorted by Part Description");
            foreach (var item in sortedByDescription)
            {
                Console.WriteLine(item);
            }

            // display invoices, sorted by description
            Console.WriteLine("\nSorted by Part Description2:");
            foreach (var item in sortedByDescription2)
            {
                Console.WriteLine(item);
            }

            // use LINQ to sort invoices by price
            var sortedByPrice = from item in invoices orderby item.Price select item;


            // display invoices, sorted by price
            Console.WriteLine("\nSorted By Price:");
            foreach (var item in sortedByPrice)
            {
                Console.WriteLine(item);
            }

            var sortedByPrice2 = invoices.OrderBy(item => item.Price);

            Console.WriteLine("\nSorted By Price:");
            foreach (var item in sortedByPrice2)
            {
                Console.WriteLine(item);
            }


            // use LINQ to select description and quantity, sort by quantity
            var sortedByQuantity = from item in invoices orderby item.Quantity select new { Description = item.PartDescription, item.Quantity };


            // display description and quantity, sorted by quantity
            Console.WriteLine("\nDescription and Sorted By Quantity");
            foreach (var item in sortedByQuantity)
            {
                Console.WriteLine(item);
            }

            //extension
            var sortedByQuantity2 = invoices.OrderBy(item => item.Quantity).Select(item => new { Description = item.PartDescription, item.Quantity });

            Console.WriteLine("\nDescription and Sorted By Quantity");
            foreach (var item in sortedByQuantity2)
            {
                Console.WriteLine(item);
            }
            // use LINQ to select description and calculated

            // invoice total; sort by invoice total
            var descriptionAndTotal = from item in invoices
                                      let total = item.Quantity * item.Price
                                      orderby total
                                      select new { item.PartDescription, InvoiceTotal = total };


            // display description and calculated invoice total
            Console.WriteLine("\nDescription and invoice total, sort by invoice total");
            foreach (var item in descriptionAndTotal)
            {
                Console.WriteLine(item);
            }


            // use LINQ to filter previous query results on range of totals
            var totalBetween200And500 = from item in descriptionAndTotal
                                        where item.InvoiceTotal > 200M &&
       item.InvoiceTotal < 500M
                                        select item;

            var totalBetween200And5002 = descriptionAndTotal.Where(item => item.InvoiceTotal > 200M && item.InvoiceTotal < 500M);

            // display filtered descriptions and invoice totals
            Console.WriteLine(string.Format($"\nInvoice totals between {200:C} and {500:C}"));
            foreach (var item in totalBetween200And500)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
        } // end Main
    } // end class LINQInvoiceArray
}