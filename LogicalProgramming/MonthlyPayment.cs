using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class MonthlyPayment
    {
        double P,  r, Emi;
        int n;
        public void pricipal()
        {
            
            while (true)
            {
                Console.Write("Enter Principal or 0 to quit : ");
                P = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Interest Rate per annum : ");
                r = Convert.ToDouble(Console.ReadLine()) / 1200;
                Console.Write("Enter Number of Months : ");
                n = Convert.ToInt32(Console.ReadLine());
                Emi = P * r * Math.Pow(1 + r, n) / (Math.Pow(1 + r, n) - 1);
                Console.WriteLine("payment for month is {0}",Emi);
            }
        }
       

    }
}
 