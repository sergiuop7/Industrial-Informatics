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
        public class Transformare {

            float x, y;
            public Transformare(float x, float y) {
                this.x = x;
                this.y = y;
            }

            public float celsiusToFahrenheit() {
                return this.x * 9 / 5 + 32;                
            }
            public float fahrenheitToCelsius() 
            {
                return (this.y-32)*5/9;
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti temperatura in grade Celsius:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti temperatura in grade Fahrenheit:");
            float b = float.Parse(Console.ReadLine());
            Transformare t = new Transformare(a, b);

            Console.WriteLine("Celsius in Fahrenheit -> " + t.celsiusToFahrenheit());
            Console.WriteLine("Fahrenheit in Celsius -> " + t.fahrenheitToCelsius());
        }
    }
}

