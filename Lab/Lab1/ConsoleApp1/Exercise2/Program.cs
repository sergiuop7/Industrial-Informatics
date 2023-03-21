// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public class Number {
            
            public float x;
            public Number() { }
            public Number(float x) {
                this.x = x;    
            }
            public Number add(Number b) {
                return new Number(this.x + b.x);
            }
            public Number subtract(Number b)
            {
                return new Number(this.x - b.x);
            }
            public Number multiply(Number b)
            {
                return new Number(this.x * b.x);
            }
            public Number divide(Number b)
            {
                return new Number(this.x / b.x);
            }

            public void afisaRerezultat(Number y) {
                 Console.WriteLine(y);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            float a = float.Parse(Console.ReadLine());
            Number firstNumber = new Number(a);
            Console.Write("Enter the second number:");
            float b = float.Parse(Console.ReadLine());
            Number secondNumber = new Number(b);
            Console.WriteLine("Enter the operation sign:");
            Number rezultat = new Number(0);
            char c = Console.ReadLine()[0];
            switch (c) {
                case '+':
                    {
                        rezultat = firstNumber.add(secondNumber);
                        break;
                    }
                case '-':
                    {
                        rezultat = firstNumber.subtract(secondNumber);
                        break;
                    }
                case '*':
                    {
                        rezultat = firstNumber.multiply(secondNumber); 
                        break;
                    }
                case '/':
                    {
                        rezultat = firstNumber.divide(secondNumber);
                        break;
                    }
            }
            Console.WriteLine("Rezultatul este " + rezultat.x);
        }
    }
}
