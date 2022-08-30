using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class WeekDays
    {
        int m, d, y;
        public void Day()
        { //calculate the day monday=1,tuesday=2,wednesday=3-------sunday=7
            Console.WriteLine("enter the month");
            int m= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the date");
            int d= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the year" );
            int y= Convert.ToInt32(Console.ReadLine());

           
            int x,y1,m1,d1;
            y1 = y - (14 - m) / 12;
            x  = y1 + y1 / 4 - y1 / 100 + y1 / 400;
            m1 = m + 12 *((14 -m) / 12)-2;
            d1 =(d + x + 31 *m1/12)% 7;
            Console.WriteLine(d1);
            
        }
    }
}
