using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9prac
{
    internal class Program7
    {
        static void Main0(string[] args)
        {
            StringBuilder sb = new StringBuilder();


            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    sb.AppendLine($"{i} x {j} = {i * j}");
                }
                if (i < 5) // разделение по 5
                {
                    sb.AppendLine();
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
