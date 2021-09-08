using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch13_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double milesDriven = 0;
            double gallonUsed = 0;
            try
            {
                Console.WriteLine("Please enter miles driven:");
                milesDriven = Convert.ToDouble(Console.ReadLine());

                if (milesDriven > 1000)
                    throw new IndexOutOfRangeException();
                //Convert.ToChar(milesDriven);

                Console.WriteLine("Please enter gallons used");
                gallonUsed = Convert.ToDouble(Console.ReadLine());

                double milesPerGallon = milesDriven / gallonUsed;
                Console.WriteLine("Mileage is {0} miles per gallon", milesPerGallon);

      
            }
            catch(FormatException e)
            {
                Console.WriteLine("Wrong division happened.\n{0}", e.Message);

            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("The number entered is not in the given range.\n", e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("What are you trying to do?\n{0}", e.Message);

            }
            
        }
    }
}
