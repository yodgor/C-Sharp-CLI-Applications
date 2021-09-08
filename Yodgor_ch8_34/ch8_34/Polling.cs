using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8_34
{
    class Polling
    {
        static void Main(string[] args)
        {
            string[] topics = new string[]{"global warming", "the economy", "war", "health care", "education"};
            int[,] responses = new int[5, 10];
            int response;
            int totalResponses = 0;
            int totalUsers = 0;
            bool notFinished = true;
            int cnt = 0;
            int[] highestLowest = new int[5];
            Random rnd = new Random();
            while (notFinished)
            {
                totalUsers += 1;
                
                for (int r = 0; r < 5; r++)
                {
                    
                    Console.WriteLine($"On a scale of 1-10, how important is {topics[cnt]}?");
                    response = Convert.ToInt32(rnd.Next(1, 11));
                    Console.WriteLine(response);
                    cnt += 1;
                    responses[r, response - 1] += 1;
                    
                }
                Console.WriteLine();
                Console.Write("Enter more data? (1 = yes, 0 = no): ");
                int moredata = Int32.Parse(Console.ReadLine());
               
                if (moredata == 0)
                {
                    notFinished = false;
                }
                else
                {
                    notFinished = true;
                    cnt = 0;
                }
            }

            var header = String.Format("\n{0,-20}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}{6,-7}{7,-7}{8,-7}{9,-7}{10,-7}{11,-20}",
                                    "Topic", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Average");
            Console.WriteLine(header);
            for (int r = 0; r <5; r++)
                {
                var topic = String.Format("{0,-20}", topics[r]);
                Console.Write(topic);
                    for (int c=0; c<10; c++)
                    {
                    //Console.Write(c);
                    var numbers = String.Format("{0,-7}", responses[r, c]);
                        
                        Console.Write(numbers);
                        totalResponses += responses[r, c] * (c + 1);
                    }
                highestLowest[r] = totalResponses;
                Console.Write("{0,7:N1}", (double)totalResponses / totalUsers);
                Console.WriteLine();
                totalResponses = 0;
                }
            int highest = highestLowest[0];
            int lowest = highestLowest[0];
            int tempHighest = 0;
            int tempLowest = 0;
            for (int i = 1; i<5; i++)
            {
                if (highestLowest[i]>highest)
                {
                    highest = highestLowest[i];
                    tempHighest = i;
                }
                if (highestLowest[i] < lowest)
                {
                    lowest = highestLowest[i];
                    tempLowest = i;
                }
            }
            Console.WriteLine($"\nHighest points: {topics[tempHighest]} ({highest})");
            Console.WriteLine($"\nLowest points: {topics[tempLowest]} ({lowest})");
            Console.ReadLine();
            
        }
    }
}
