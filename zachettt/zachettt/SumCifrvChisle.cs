using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class SumCifrvChisle
    {
        public static void SumCifrex8()
        {
            Console.WriteLine("Даны два натуральных числа. Выяснить, в каком из них сумма цифр больше. \n Введите два числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum1 = Sum(ref a);
            int sum2 = Sum(ref b);
            Console.WriteLine($"Сумма первого числа: {sum1} \n Сумма второго числа: {sum2}");
            if (sum1 > sum2)
            {
                Console.WriteLine("Сумма цифр первого числа больше суммы цифр второго числа");
            }
            else if (sum1 < sum2)
            {
                Console.WriteLine(" Сумма цифр второго числа больше суммы цифр первого числа");
            }
            else Console.WriteLine("Суммы цифр равны");
        }
        public static int Sum ( ref int n)
        {
            int sum = 0;
            int k = 0;
            while (n != 0)
            {
                k = n % 10;
                sum += k;
                n /= 10;
            }
            return sum;
        }
    }
}
