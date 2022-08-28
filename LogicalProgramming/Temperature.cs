using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class Temperature
    {
        int celsius, fahrenheit;
        public void convert()
        {
            Console.WriteLine("please enter your choice \n 1.Degree to Fahrenheit \n 2.Fahrenheit to Degree\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("converting value from celsius to fahrenheit");
                    celsius = Convert.ToInt32(Console.ReadLine());
                    fahrenheit= (celsius * 9 / 5) +32;
                    Console.WriteLine(fahrenheit);
                    break;
                case 2:
                    Console.WriteLine("converting value from  fahrenheit to degree");
                    fahrenheit = Convert.ToInt32(Console.ReadLine());
                    celsius = (fahrenheit -32) *(5 / 9);
                    Console.WriteLine(celsius);
                    break;
                    default:
                    break;

            }

        }
    }
}
