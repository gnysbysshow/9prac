using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    internal class Program2
    {
        static void Main0(string[] args)
        {
            string text = "C# это современный язык программирования.";

            int totalCharacters = text.Length;
            Console.WriteLine($"Общее количество символов: {totalCharacters}");

            string[] words = text.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            Console.WriteLine($"Количество слов: {wordCount}");

            int wordPosition = text.IndexOf("язык");
            Console.WriteLine($"Позиция слова 'язык': {wordPosition}");

            bool startsWithCSharp = text.StartsWith("C#");
            Console.WriteLine($"Текст начинается с 'C#': {startsWithCSharp}");
        }
    }
}
