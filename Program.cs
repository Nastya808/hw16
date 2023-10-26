using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace hw16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();

            Console.WriteLine("Введіть назви міст (введіть 'end' для завершення вводу):");

            string city;
            while ((city = Console.ReadLine()) != "end")
            {
                cities.Add(city);
            }

            Console.WriteLine("Весь масив міст:");
            cities.ForEach(Console.WriteLine);

            Console.Write("Введіть довжину назви міста для фільтрації: ");
            int lengthFilter = int.Parse(Console.ReadLine());

            var filteredCities = cities.Where(c => c.Length == lengthFilter);
            Console.WriteLine($"Міста з довжиною назви {lengthFilter}:");
            filteredCities.ToList().ForEach(Console.WriteLine);

            Console.Write("Введіть літеру, з якої починаються назви міст: ");
            char startsWithFilter = char.Parse(Console.ReadLine());

            var startsWithCities = cities.Where(c => c.StartsWith(startsWithFilter.ToString(), StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Міста, назви яких починаються на '{startsWithFilter}':");
            startsWithCities.ToList().ForEach(Console.WriteLine);

            Console.Write("Введіть літеру, якою закінчуються назви міст: ");
            char endsWithFilter = char.Parse(Console.ReadLine());

            var endsWithCities = cities.Where(c => c.EndsWith(endsWithFilter.ToString(), StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Міста, назви яких закінчуються на '{endsWithFilter}':");
            endsWithCities.ToList().ForEach(Console.WriteLine);

            Console.Write("Введіть початкову літеру та закінчувальну літеру (наприклад, 'N' та 'K'): ");
            string startAndEndFilter = Console.ReadLine();

            var startAndEndCities = cities.Where(c =>
                c.StartsWith(startAndEndFilter.Substring(0, 1), StringComparison.OrdinalIgnoreCase) &&
                c.EndsWith(startAndEndFilter.Substring(1, 1), StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"Міста, назви яких починаються на '{startAndEndFilter[0]}' і закінчуються на '{startAndEndFilter[1]}':");
            startAndEndCities.ToList().ForEach(Console.WriteLine);

            Console.Write("Введіть початкові символи (наприклад, 'Ne'): ");
            string startsWithNe = Console.ReadLine();

            var startsWithNeCities = cities.Where(c => c.StartsWith(startsWithNe, StringComparison.OrdinalIgnoreCase)).OrderByDescending(c => c);
            Console.WriteLine($"Міста, назви яких починаються на '{startsWithNe}' (відсортовані за спаданням):");
            startsWithNeCities.ToList().ForEach(Console.WriteLine);
        }
    }
}