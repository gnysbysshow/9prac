using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    internal class Program3
    {
        static void Main0(string[] args)
        {
            string phone = "+79161234567";

            Console.WriteLine($"Исходный номер: {phone}");


            string countryCode = phone.Substring(0, 2);

            string operatorCode = phone.Substring(2, 3);

            string firstPart = phone.Substring(5, 3); 

            string secondPart = phone.Substring(8, 2);

            string thirdPart = phone.Substring(10, 2);

            string formattedPhone = $"{countryCode} ({operatorCode}) {firstPart}-{secondPart}-{thirdPart}";

            Console.WriteLine($"Форматированный номер: {formattedPhone}");
        }
    }
}
