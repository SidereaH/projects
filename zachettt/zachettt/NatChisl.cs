using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class NatChisl
    {
        public static void NatChislo()
        {
            Console.Clear();

            Console.WriteLine("Задание 2:");
            Console.WriteLine("Введите натуральное число с содержащее хотя-бы один 0 и одну девятку");
            double n = double.Parse(Console.ReadLine());
            double m = 0;
            int k1 = 0;
            int k2 = 0;
            while (n != 0)
            {
                m = n % 10;
                if (m == 0)
                {
                    k1 += 1;
                }
                if (m == 9)
                {
                    k2 += 1;
                }
                n = n / 10;

            }
            Console.WriteLine("Кол-во нулей: " + k1);
            Console.WriteLine("Кол-во девяток: " + k2);
            if (k1 > k2)
            {
                Console.WriteLine("Нулей больше чем девяток");
            }
            else if (k1 == k2)
            {
                Console.WriteLine("Их количество равно");
            }
            else
            {
                Console.WriteLine("Девяток больше чем нулей");
            }
            Console.WriteLine("Основа работы: \r\n double n = double.Parse(Console.ReadLine());\n            double m =0;\n            int k1 = 0;\n            int k2 = 0;\n            while (n != 0) {\n                m = n % 10;\n                if (m == 0)\n                {\n                    k1+=1;\n                }\n                if (m == 9)\n                {\n                    k2 += 1;\n                }\n                n = n / 10;\n            }\n            Console.WriteLine(\"Кол-во нулей: \" + k1);\n            Console.WriteLine(\"Кол-во девяток: \" + k2);\n            if (k1>k2){\n                Console.WriteLine(\"Нулей больше чем девяток\");\n            }\n            else if (k1 == k2)\n            {\n                Console.WriteLine(\"Их количество равно\");\n            }\n            else\n            {\n                Console.WriteLine(\"Девяток больше чем нулей\");\n            } ");
            Console.WriteLine("Нажмите enter для продолжения");
            Console.ReadLine();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
