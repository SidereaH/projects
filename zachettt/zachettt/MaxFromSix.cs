using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class MaxFromSix
    {
        public static void Max()
        {
            Console.WriteLine("Даны шесть различных натуральных чисел. Определить максимальное из них. \n Введите 6 чисел");
            int[] array = new int [6];
            WriteArray.Read(array);
            Console.WriteLine($"Максимальное число: {array.Max()}");
            
        }
    }
}
