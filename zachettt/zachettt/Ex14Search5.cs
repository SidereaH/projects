using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class Ex14Search5
    {
        public static void SearchMain ()
        {
            Console.WriteLine("14. Известно, что в одномерном массиве имеются элементы, равные 5. Определить номер первого из них.");
            Random rand = new Random();
            Console.WriteLine("Размер массива?");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i<array.Length; i++)
            {
                array[i] = rand.Next(100);
            }
            int k = rand.Next(n);
            array[k] = 5;
            Console.WriteLine("Массив:");
            WriteArray.Write(array);
            SearchFive(array);

        }
        
        public static void SearchFive(int[] array)
        {
            for(int i = 0; i<array.Length;i++)
            {
                if (array[i] == 5)
                {
                    Console.WriteLine($"Пятерка в массиве находится под номером: {i}");
                    break;
                }
               
            }
        }
    }
}
