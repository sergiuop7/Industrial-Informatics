using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFirstClient.ServiceReference1.WebService1SoapClient service = new MyFirstClient.ServiceReference1.WebService1SoapClient();

            int sum = service.Add(2,  3);
            Console.WriteLine("The sum is " + sum.ToString());
            Console.ReadKey();

            Console.Write("Introduceti temperatura in grade Celsius:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti temperatura in grade Fahrenheit:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Celsius in Fahrenheit -> " + service.CelsiusToFahrenheit(a));
            Console.WriteLine("Fahrenheit in Celsius -> " + service.FahrenheitToCelsius(b));
            Console.ReadKey();

            Console.Write("Introduceti valuta in lei:");
            float m = float.Parse(Console.ReadLine());
            Console.Write("Introduceti valuta in euro:");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Lei in euro -> " + service.ConvertLeiToEuro(m));
            Console.WriteLine("Euro in lei -> " + service.ConvertEuroToLei(n));
            Console.ReadKey();

            Console.WriteLine(service.GetDateTime());
            Console.ReadKey();

            Console.WriteLine(string.Join(", ", service.AfisareLista()));
            Console.ReadKey();
        }
    }
}
