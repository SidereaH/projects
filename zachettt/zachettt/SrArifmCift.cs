using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class SrArifmCifr
    {
        public static void Cifri()
        {
            Console.WriteLine($"12. Даны 3 натуральных числа. Определить, у какого из них среднее арифметическое цифр больше");
            Console.WriteLine("Введите первое число");
            Console.WriteLine("Введите второе число");
            Console.WriteLine("Введите третье число");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double sra = SrArifm(a);
            double srb = SrArifm(b);
            double src = SrArifm(c);

            double[] arraysum = new double[3];
            arraysum[0] = sra;
            arraysum[1] = srb;
            arraysum[2] = src;
            if( arraysum.Max() == arraysum[0])
            {
                Console.WriteLine($"Наибольшее среднее арифметическое цифр у числа {a}:  {arraysum.Max()}");
            }
            else if(arraysum.Max() == arraysum[1]){
                Console.WriteLine($"Наибольшее среднее арифметическое цифр у числа {b}:  {arraysum.Max()}");
            }
            else
            {
                Console.WriteLine($"Наибольшее среднее арифметическое цифр у числа {b}:  {arraysum.Max()}");
            }
            Console.WriteLine("Код решения: \r\n Метод нахождения среднего арифметического числа: \r\n  public static double SrArifm(int n)\r\n        {\r\n            double sum = 0;\r\n            double k = 0;\r\n            int chet = 0;\r\n            while (n != 0)\r\n            {\r\n                k = n % 10;\r\n                sum += k;\r\n                n /= 10;\r\n                chet+=1;\r\n            }\r\n\r\n            double srarifm = sum / chet; \r\n            return srarifm;\r\n        } \r\n Основной код: \r\n Console.WriteLine($\"12. Даны 3 натуральных числа. Определить, у какого из них среднее арифметическое цифр больше\");\r\nConsole.WriteLine(\"Введите первое число\");\r\nConsole.WriteLine(\"Введите второе число\");\r\nConsole.WriteLine(\"Введите третье число\");\r\nint a = int.Parse(Console.ReadLine());\r\nint b = int.Parse(Console.ReadLine());\r\nint c = int.Parse(Console.ReadLine());\r\ndouble sra = SrArifm(a);\r\ndouble srb = SrArifm(b);\r\ndouble src = SrArifm(c);\r\n\r\ndouble[] arraysum = new double[3];\r\narraysum[0] = sra;\r\narraysum[1] = srb;\r\narraysum[2] = src;\r\nif( arraysum.Max() == arraysum[0])\r\n{\r\nConsole.WriteLine($\"Наибольшее среднее арифметическое цифр у числа {a}:  {arraysum.Max()}\");\r\n}\r\nelse if(arraysum.Max() == arraysum[1]){\r\nConsole.WriteLine($\"Наибольшее среднее арифметическое цифр у числа {b}:  {arraysum.Max()}\");\r\n}\r\nelse\r\n{\r\nConsole.WriteLine($\"Наибольшее среднее арифметическое цифр у числа {b}:{arraysum.Max()}\");\r\n}");

        }
        
        public static double SrArifm(int n)
        {
            double sum = 0;
            double k = 0;
            int chet = 0;
            while (n != 0)
            {
                k = n % 10;
                sum += k;
                n /= 10;
                chet+=1;
            }

            double srarifm = sum / chet; 
            return srarifm;
        }
    }
}
