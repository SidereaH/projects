using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class Ploshtr
    {
        public static void SumPlosh()
        {
            Console.WriteLine("Даны стороны двух треугольников. Найти сумму их площадей. \n Введите все стороны треугольников:");
            Console.WriteLine("Расчет по формуле Герона");
            Console.WriteLine("Первый треугольник:");
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Второй треугольник");
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double c2 = double.Parse(Console.ReadLine());
            
            double p1 = (a1 + b1 + c1) / 2;
            double p2 = (a2 + b2 + c2) / 2;
            double s1 = Math.Sqrt(p1*(p1-a1)*(p1-b1)*(p1-c1));
            double s2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
            Console.WriteLine($"Площадь первого треугольника: {s1}; \n Площадь второго треугольника: {s2}. \r\n Сумма площадей: {s1+s2}");
            Console.WriteLine("Код работы программы: \r \n Console.WriteLine(\"Даны стороны двух треугольников. Найти сумму их площадей. \\n Введите все стороны треугольников:\");\r\n            Console.WriteLine(\"Расчет по формуле Герона\");\n            Console.WriteLine(\"Первый треугольник:\");\n            double a1 = double.Parse(Console.ReadLine());\n            double b1 = double.Parse(Console.ReadLine());\n            double c1 = double.Parse(Console.ReadLine());\n            Console.WriteLine(\"Второй треугольник\");\n            double a2 = double.Parse(Console.ReadLine());\n            double b2 = double.Parse(Console.ReadLine());\n            double c2 = double.Parse(Console.ReadLine());\r\n                    double p1 = (a1 + b1 + c1) / 2;\r\n            \r\n            double p2 = (a2 + b2 + c2) / 2;\r\n            double s1 = Math.Sqrt(p1*(p1-a1)*(p1-b1)*(p1-c1));\r\n            double s2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));\r\n            Console.WriteLine($\"Площадь первого треугольника: {s1}; \\n Площадь второго треугольника: {s2}. \\r\\n Сумма площадей: {s1+s2}\"); ");
        }

    }
}
