using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    internal class Program4
    {
        static void Main0(string[] args)
        {
            string email = "user.example@gmail.com";

            Console.WriteLine($"Исходный email: {email}");

            if (email.Contains("@"))
            {
                int atIndex = email.IndexOf('@');

                // часть до @
                string userName = email.Substring(0, atIndex);

                // часть после @
                string domain = email.Substring(atIndex);

                // маскировка ***
                string maskedUserName = new string('*', userName.Length);


                string maskedEmail = maskedUserName + domain;

                Console.WriteLine($"Замаскированный email: {maskedEmail}");
            }
            else
            {
                Console.WriteLine("Ошибка: email не содержит символ '@'");
            }
        }
    }
}
