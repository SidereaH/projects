using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class RaznMinMax
    {
        public static void RaznMinMAxN()
        {
            Console.Clear();
            Console.WriteLine("7. Дано натуральное число. Определить, является ли разность его максимальной и минимальной цифр четным числом.");
            Console.WriteLine("Введите натуральное число:");
            int n = int.Parse(Console.ReadLine());
            
            int max = 0;
            int min = 9;
            while(n % 10 >0)
            { 
                if (n / 10  > max)  max= n / 10;
                if (n / 10 < min) min = n / 10;
                n /= 10;

            }
            Console.WriteLine($"максимальная цифра: {max}\n Минимальная цифра: {min} ");
            if ((max-min) % 2 == 0) {
                Console.WriteLine("Разность его максимальной и минимальной цифр четное число");
            }
        }
    }
}
