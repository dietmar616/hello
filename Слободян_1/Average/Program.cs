using System;



    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float average = (a + b + c) / 3;

            Console.WriteLine(average); 
        }
    }

