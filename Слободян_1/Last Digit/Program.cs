using System;

    class Program
    {
        static void Main(string[] args)
        {
            int lastDigit, n;
            n = int.Parse(Console.ReadLine());

            lastDigit = n % 10;
            Console.WriteLine(lastDigit);
        }
    }

