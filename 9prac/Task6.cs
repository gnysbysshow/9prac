using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    internal class Program6
    {
        static void Main0(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                sb.Append(i);
                sb.Append(',');
            }

            if (sb.Length > 0 && sb[sb.Length - 1] == ',')
            {
                sb.Length--;
            }

            sb.Insert(0, "Числа: ");
            sb.Append('.');

            Console.WriteLine($"Результат: \"{sb.ToString()}\"");

        }
    }
}
