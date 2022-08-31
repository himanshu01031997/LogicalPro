using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class CoupanNo
    {
        public void Distinct()
        {
            int[] arr = new int[10];
            int[] Distinct = new int[10];
            Random random = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
               arr[i] = random.Next(1,10);//1,2,3,4,5,6,7,3,5,9
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])//random values(1-9) = sequntial value(1-9)
                    {
                        count++;
                    }

                }
                if (count == 1)
                {
                    Distinct[i] = arr[i];
                }

            }
            foreach (int i in Distinct)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
