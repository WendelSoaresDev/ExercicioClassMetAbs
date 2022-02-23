using System;
using System.Collections;
using ExercicioClassMetAbs.Entities;
using System.Globalization;
namespace ExercicioClassMetAbs
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company?(i / c) ");
                char typePerson = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (typePerson == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine());
                    list.Add(new PhysicalPerson(name, anualIncome, healthExp));
                }
                else if (typePerson == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numEmployeer = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, anualIncome, numEmployeer));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double sum = 0;
            foreach(TaxPayer obj in list)
            {
                Console.WriteLine(obj.Name + ": $" + obj.Tax().ToString("F2"));
                sum += obj.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2"));

        }
    }
}