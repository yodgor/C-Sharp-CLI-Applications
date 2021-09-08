using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesYodgor_ch20_11
{
    // PairTest.cs
    // Generic Pair class testing program.

    public class pairtest
    {
        public static void Main(string[] args)
        {
            // create a pair of int and string
            Pair<int, string> numberPair =
               new Pair<int, string>(1, "one");

            // display original numberPair
            Console.WriteLine("Original pair: < {0}, {1} >",
               numberPair.getFist(), numberPair.getSecond());

            // modify pair
            Pair<int, string> numberPair1 = numberPair;
            numberPair1.setFirst(2);
            numberPair.setSecond("two");

            // display modified numberPair
            Console.WriteLine("Modified pair: < {0}, {1} >",
               numberPair.getFist(), numberPair.getSecond());
        } // end Main
    } // end class PairTest

}
