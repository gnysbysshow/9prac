using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    internal class Program9
    {
        static void Main0(string[] args)
        {
            Console.Write("Введите слово: ");
            int shift = 3;
            string word = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char c in word)
            {
                char encrypted = (char)('a' + (c - 'a' + shift) % 26);
                sb.Append(encrypted);
            }

            Console.WriteLine($"Зашифрованное слово: {sb.ToString()}");
        }
    }
}
