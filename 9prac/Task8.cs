using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    internal class Program8
    {
        static void Main0(string[] args)
        {
            string fruits = "яблоко, банан , апельсин,киви, груша";

            Console.WriteLine($"Исходная строка: \"{fruits}\"");

            //Разделить строку на массив по запятой
            string[] fruitsArray = fruits.Split(',');

            // Убрать лишние пробелы
            for (int i = 0; i < fruitsArray.Length; i++)
            {
                fruitsArray[i] = fruitsArray[i].Trim();
            }

            // сортировка по алфавиту
            Array.Sort(fruitsArray);

            Console.WriteLine($"Результат: \"{string.Join("; ", fruitsArray)}\"");
        }
    }
}
