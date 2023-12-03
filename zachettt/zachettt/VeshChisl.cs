using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class VeshChisl
    {
        public static void VeshChislN()
        {
            Console.Clear();
            Console.WriteLine("Дано вещественное число a. Напечатать все значения n, при которых: 1+1/2+1/3+...+1/n>a ");
            double a = double.Parse(Console.ReadLine());
            double sum = 0;
            double n = 1;
            while (sum < a)
            {
                sum += 1 / n;
                n++;
                Console.WriteLine("n =" + n);
            }
            Console.WriteLine("Основной код: \n double a = double.Parse(Console.ReadLine());\r\n            double sum = 0;\r\n            double n = 1;\r\n            while (sum < a) {\r\n                sum += 1 / n;\r\n                n++;\r\n                Console.WriteLine(\"n =\" + n);\r\n            } ");
            Console.ReadLine();
            Form1 f1 = new Form1();
            f1.Show();


        }
    }
}
