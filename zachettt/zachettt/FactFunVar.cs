using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class FactFunVar
    {
        public static void Reshex11()
        {
            Console.WriteLine("11. Вычислить значение выражения (2*5!+3*8!)/(6!+4!), используя функцию для вычисления n!");

            double vyr = (2 * Fact(5) + 3* Fact(8))/(Fact(6) + Fact(4));
            Console.WriteLine($"Ответ: {vyr} \r\n Код функции факториала: \r\n public static double Fact(double n)\r\n        {{\r\n            double z = 0;\r\n            for (int i = 1; i<=n;i++)\r\n            {{\r\n                z = z * i; \r\n            }}\r\n            return z;\r\n        }} ");
        }
        public static double Fact(double n)
        {
            double z = 0;
            for (int i = 1; i<=n;i++)
            {
                z = z * i; 
            }
            return z;
        }
    }
}
