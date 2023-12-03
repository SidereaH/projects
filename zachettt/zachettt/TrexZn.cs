using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class TrexZn
    {
        public static void TrexZnN()
        {
            Console.Clear();
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            double m = 0;
            int k2 = 0;
            for (int i = 100; i <= 999; i++)
            {
                k = i;
                while (k != 0)
                {
                    m = k % 10;
                    if (m == n)
                    {
                        Console.WriteLine($" Число {i} содержит {n}");
                    }

                    k = k / 10;

                }

            }
            for (int i = 100; i <= 999; i++)
            {
                k2 = i;
                if (k2 % n == 0)
                {
                    Console.WriteLine($"Число {i} нацело делится на {n} ");
                }
            }
            Form1 f1 = new Form1();
            f1.Show();


        }
    }
}
