using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_12
{
    class DateTest
    {
        static void Main()
        {
            Date date1 = new Date(7, 4, 2018);

            Console.Write("The initial date is: ");
            Console.Write(date1.DisplayDate());

            // change date values
            date1.Month = 11;
            date1.Day = 1;
            date1.Year = 2018;

            Console.Write("\nDate with new values is: ");
            Console.Write(date1.DisplayDate());

            Console.WriteLine(); // output a new line
        }
    }
}
