using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    internal class Program5
    {
        static void Main0(string[] args)
        {
            Console.Write("Введите слово для проверки: ");
            string word = Console.ReadLine();


            string lowerWord = word.ToLower();

            bool isPalindrome = true;
            for (int i = 0; i < lowerWord.Length / 2; i++)
            {
                if (lowerWord[i] != lowerWord[lowerWord.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine($"Слово \"{word}\" является палиндромом!");
            }
            else
            {
                Console.WriteLine($"Слово \"{word}\" НЕ является палиндромом");
            }
        }
    }
}
