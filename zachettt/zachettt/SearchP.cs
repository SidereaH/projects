using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class SearchP
    {
        public static void SearchPN()
        {
            Console.Clear();
            Console.WriteLine("Вычислить: P = 2 × 4 × 6 × . . . × (2n)");
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());
            int P = 0;
            int k = 0;
            for (int i = 2; i <= 2 * n; i += 2)
            {
                k = i + 2;
                P = k * i;
            }
            Console.WriteLine($"P = {P}");
            Console.WriteLine("Основной метод: \r\n int n = int.Parse(Console.ReadLine());\r\n            int P = 0;\r\n            int k = 0;\r\n            for( int i = 2;  i <= 2*n; i+=2)\r\n            {\r\n                k = i + 2;\r\n                P = k * i;\r\n            } ");
            Console.WriteLine("Нажмите enter для продолжения...");
            Console.Read();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
