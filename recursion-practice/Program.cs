using System;

namespace recursion_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfNumbers s1 = new SumOfNumbers();
            int range = 5;
            s1.sumOfRange(range);
            Console.WriteLine("The sum of " + range + " is: " + s1.result);

            SumOfDigits s2 = new SumOfDigits();
            int num = 25;
            s2.SumDigits(num);
            Console.WriteLine("The sum of the digits of number " + num + " is: " + s2.result);

            PrimeNumber p1 = new PrimeNumber();
            int number = 7;
            p1.IsPrime(number);
            Console.WriteLine("The number" + number + " " + p1.result);
        }
    }
}
