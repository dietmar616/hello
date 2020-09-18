using System;



    class Program
    {
        static void Main(string[] args)
        {
            float  n = float.Parse(Console.ReadLine());
            bool result = false;

            if (n > 20 && n % 2 != 0)
            {
                result = true;
                Console.WriteLine(result);
            }

            else
            {
                Console.WriteLine(result);
            }
        }
    }

