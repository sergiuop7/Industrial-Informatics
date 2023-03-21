// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numere separate prin spatiu:");
            string[] input = Console.ReadLine().Split(' ');

            int[] numbers = new int[input.Length];
            double geometricMean = 1.0;
            double arithmeticMean = 0.0;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
                geometricMean *= numbers[i];
                arithmeticMean += numbers[i];
            }

            geometricMean = Math.Pow(geometricMean, 1.0 / input.Length);
            arithmeticMean /= input.Length;

            Console.WriteLine("Media geometrica este: {0}", geometricMean);
            Console.WriteLine("Media aritmetica este: {0}", arithmeticMean);
        }
    }
}



