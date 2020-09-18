using System;

    class Program
    {
        static void Main(string[] args)
        {
            double nDigit;
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            nDigit = (number / Math.Pow(10, n - 1)) % 10;

            Console.WriteLine(nDigit);
        }
    }

