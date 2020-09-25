using System;

namespace Factorial
{
    class Program
    {
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The Factrial of number {0} is {1}", num, factorial);
            Console.WriteLine("This program ends here..");
        }
    }
}