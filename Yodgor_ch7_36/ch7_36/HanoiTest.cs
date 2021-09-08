using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
namespace ch7_36
{
    class HanoiTest
    {
        static void Main()
        {
        int disks; // number of disks in the tower

        // prompt user for number of disks and read value
        Console.Write("Enter number of disks ( 1-9 ): ");
        disks = Convert.ToInt32(Console.ReadLine());

        // actually sort the number of discs specified by user
        string result = TowerOfHanoi.Tower(disks, 1, 3, 2);
        Console.WriteLine(result);

        Console.Read();
         }
    }
}
