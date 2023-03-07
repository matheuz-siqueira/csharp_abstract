using System.Collections.Generic;
using csharp_abstract.Entities;

namespace csharp_abstract; 

class Program
{
    static void Main(string[] args)
    {
        List<Person> list = new List<Person>();
        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Tax payer #{i} data: ");
            Console.Write("Individual or company (i/c)? ");
            char resp = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual income: ");
            double annualIncome = double.Parse(Console.ReadLine());

            if (resp == 'i')
            {
                Console.Write("Health expenditures: ");
                double healthExpenses = double.Parse(Console.ReadLine());
                list.Add(new PhysicalPerson(name, annualIncome, healthExpenses));
            }else if(resp == 'c')
            {
                Console.Write("Number of employees: ");
                int numberEmployees = int.Parse(Console.ReadLine());
                list.Add(new LegalPerson(name, annualIncome, numberEmployees));
            }
        }

        Console.WriteLine();
        Console.WriteLine("TAXES PAID: ");
        foreach(Person p in list)
        {
            Console.WriteLine(p.ToString());
        }
        double totalTax = 0.0;
        foreach(Person p in list)
        {
            totalTax += p.Tax();
        }
        Console.WriteLine($"TOTAL TAXES: {totalTax.ToString("C")}");

    }
}