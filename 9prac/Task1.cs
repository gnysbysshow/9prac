using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    internal class Task1
    {
        static void Main0(string[] args)
        {
            // Исходные данные
            string name = "анна ";
            string city = "москва";

            name = name.Trim();
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            city = city.ToUpper();

            Console.WriteLine($"Привет, {name} из {city}!");
        }
    }
}
