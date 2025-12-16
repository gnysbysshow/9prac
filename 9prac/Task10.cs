using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    internal class Program10
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            StringBuilder password = new StringBuilder();

            //Генерация символов
            for (int i = 0; i < 3; i++)
                password.Append((char)('a' + random.Next(26)));

            for (int i = 0; i < 3; i++)
                password.Append(random.Next(10));

            for (int i = 0; i < 2; i++)
                password.Append((char)('A' + random.Next(26)));


            for (int i = password.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (password[i], password[j]) = (password[j], password[i]);
            }

            Console.WriteLine($"Пароль: {password}");
        }
    }
}
