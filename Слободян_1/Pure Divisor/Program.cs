using System;



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            n = int.Parse(Console.ReadLine());
            if (n % 9 == 0 || n % 11 == 0 || n % 13 == 0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }

