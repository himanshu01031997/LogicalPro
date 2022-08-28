using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class Reverse
    {
        int rem,count =0;

        public void CheckReverse()
        {
            Console.Write("\n");
            Console.Write("To Print Reverse no:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.WriteLine("enter the Number to Print Reverse no : ");
            int num = Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                int rem = num % 10;
                count = count * 10 + rem;
                num = num / 10;
                Console.WriteLine(count);
            }
        }
    }
}
