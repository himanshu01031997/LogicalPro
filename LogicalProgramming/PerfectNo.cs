using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PerfectNo
    {
        int rem, sum = 0, i;
        public void checkperfect()
        {
            Console.Write("\n");
            Console.Write("To Print Perfect no:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.WriteLine("enter the Number to Print perfect no : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; (i <= num / 2); i++)
            {
                rem = num % i;
                if (rem == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("no is perfect no");
            }
            else
            {
                Console.WriteLine("no is not a Pefect no ");
            }
        }
    }
}
