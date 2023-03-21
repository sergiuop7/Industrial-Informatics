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
        public class Persoana {
            char sex;
            int inaltime;
            int varsta;

            public Persoana(char sex, int inaltime, int varsta) {
                this.sex = sex;
                this.inaltime = inaltime;
                this.varsta = varsta;
            }

            public double calculatorGreutateIdealaBarbati() 
            {
                return (this.inaltime - 100 - ((this.inaltime - 150) / 4)) + ((this.varsta - 20) / 4);        
            }

            public double calculatorGreutateIdealaFemei()
            {
                return (this.inaltime - 100 - ((this.inaltime - 150) / 2.5)) + ((this.varsta - 20) / 6);
            }

            public void afisareGreutateIdealaBarbati(Persoana p) {
                Console.WriteLine("Greutatea ideala a barbatului este: " + p.calculatorGreutateIdealaBarbati());
            }
            public void afisareGreutateIdealaFemei(Persoana p)
            {
                Console.WriteLine("Greutatea ideala a femeii este: " + p.calculatorGreutateIdealaFemei());
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Sex(f/m): ");
            char sex = Console.ReadLine()[0];
            Console.Write("Introduceti inaltimea(cm): ");
            int inaltime = int.Parse(Console.ReadLine());
            Console.Write("Introduceti varsta: ");
            int varsta = int.Parse(Console.ReadLine());

            Persoana p = new Persoana(sex, inaltime, varsta);
            if (sex == 'm')
            {
                p.afisareGreutateIdealaBarbati(p);
            }
            else
            {
                p.afisareGreutateIdealaFemei(p);
            }
        }
    }
}


