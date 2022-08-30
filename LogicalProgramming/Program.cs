namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Your choice \n1.fibonacci \n2. Prime no\n3.Perfect no\n4.Reverse no\n5.Temperature conversion\n6.Monthly payment");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Fibona();
                    break;
                case 2: 
                    PrimeNo prime=new PrimeNo();
                    prime.checkprime();
                    break;
                case 3:
                    PerfectNo perfect = new PerfectNo();
                    perfect.checkperfect();
                    break;
                case 4:
                    Reverse reverse = new Reverse();
                    reverse.CheckReverse();
                    break;
                case 5:
                    Temperature temp = new Temperature();
                    temp.convert();
                    break;
                case 6:
                    MonthlyPayment pay = new MonthlyPayment();
                    pay.pricipal();
                    break;
                default:
                    break;
            }
        }
    }
}