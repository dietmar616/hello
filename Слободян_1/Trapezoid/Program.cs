using System;



    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());

            float area = ((a + b) / 2) * h;

            Console.WriteLine(area);
        }
    }

