using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class SearchSum
    {
        public static void SearchSumS()
        {
            Console.Clear();
            Console.WriteLine("Задание: Найти сумму -12 + 22 – 32 + 42 – 5 2 + . . . + 402 .");
            int k1 = -12;
            int k2 = 22;
            int n = 0;
            for (int i = 0; i <= k2; i++)
            {
                k1 += -20;
                k2 += 10;
                n = k1 + k2;
            }
            Console.WriteLine("Ответ: " + n);
            Console.ReadLine();
            Console.WriteLine($"Основа работы: \r\n for (int i = 0; i <= k2; i++) {{\r\n                k1 += -20;\r\n                k2 += 10;\r\n                n = k1 + k2;\r\n            }}  ");
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
