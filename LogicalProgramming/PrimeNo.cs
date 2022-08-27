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
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("the {0} is prime", num);
            }
            else
            {
                Console.WriteLine("the {0} is not prime", num);
            }
        }
       
    }
}
