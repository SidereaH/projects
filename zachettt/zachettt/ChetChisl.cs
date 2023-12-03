using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zachettt;

namespace zachettt
{
    public class ChetChisl
    {
        public static void  ChetChsilo(){
            Console.Clear();

            Console.WriteLine("Задание 1:");
            Console.WriteLine("Введите число:");
            int i = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    if (j % 2 == 0)
                    {
                        sum += j;
                    }
                }
            }
            Console.WriteLine("Сумма всех четных делителей: " + sum);
            Console.WriteLine("Основа работы: \r\n int i = int.Parse(Console.ReadLine());\n            int sum = 0;\n            for (int j = 1; j <= i; j++)\n            {\n                if (i % j == 0)\n                {\n                    if (j % 2 == 0)\n                    {\n                        sum += j;\n                    }\n                }\n            } ");
            Console.WriteLine("Нажмите enter для продолжения");
            Console.ReadLine();
            Form1 f1 = new Form1();
            f1.Show();
        }

    }
}
