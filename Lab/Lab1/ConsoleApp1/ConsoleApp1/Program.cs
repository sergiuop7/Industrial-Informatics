// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x = 3, a = 0, b = 1;
            Console.WriteLine("Enter n the number of Fibonacci terms:");
            n = int.Parse(Console.ReadLine());
            if (n == 0)
                Console.WriteLine("No Fibonacci terms");
            else if (n == 1)
                Console.WriteLine(a);
            else if (n == 2)
                Console.WriteLine("{0}, {1}", a, b);
            else
            {
                Console.Write("{0}, {1}", a, b);
                while (x <= n)
                {
                    int c = a + b;
                    a = b; b = c;
                    Console.Write(", " + c);
                    x++;
                }
            }
        }
    }
}
