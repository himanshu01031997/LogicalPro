using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNo
    {
        int count=0;
        public void checkprime()
        {
            Console.Write("\n");
            Console.Write("To Print Prime no:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("\n");
            Console.WriteLine("Enter the Number to check prime no: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num/2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("no is prime");
            }
           
        }
       
    }
}
