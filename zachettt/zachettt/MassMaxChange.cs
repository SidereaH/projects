using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class MassMaxChange
    {
        public static void Ex13()
        {
            Console.WriteLine("Дан одномерный массив целых чисел. Найти максимальный элемент массива и поменять его местами с первым элементом.");
            Console.WriteLine("Введите размер массива:");
            int z = int.Parse(Console.ReadLine());
            int[] array = new int[z];
            Console.WriteLine("До какого числа от 0 будет работать Random?");
            int chisl = int.Parse(Console.ReadLine());
            Console.WriteLine("Массив рандомно заполнится числами от 0 до " + chisl);
            ZapolRand(ref array,chisl);
            //максимальный элемент массива
            int tempMax = array.Max();
            array[0] = tempMax; // ставим на первое место максимальный элемент
            Console.WriteLine("Новый вид массива после выполнения задачи: ");
            for(int i =0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Код: \r\n public static void Ex13()\r\n        {\r\n            Console.WriteLine(\"Дан одномерный массив целых чисел. Найти максимальный элемент массива и поменять его местами с первым элементом.\");\r\n            Console.WriteLine(\"Введите размер массива:\");\r\n            int z = int.Parse(Console.ReadLine());\r\n            int[] array = new int[z];\r\n            Console.WriteLine(\"До какого числа от 0 будет работать Random?\");\n            int chisl = int.Parse(Console.ReadLine());\n            Console.WriteLine(\"Массив рандомно заполнится числами от 0 до \" + chisl);\n            ZapolRand(ref array,chisl);\r\n            //максимальный элемент массива\r\n            int tempMax = array.Max();\r\n            array[0] = tempMax; // ставим на первое место максимальный элемент\r\n            Console.WriteLine(\"Новый вид массива после выполнения задачи: \");\r\n            for(int i =0; i< array.Length; i++)\r\n            {\r\n                Console.WriteLine(array[i]);\r\n            }\r\n            Console.WriteLine(\"Код: \\r\\n \");\r\n        }\r\n        //метод заполнения  массива рандомом \r\n        public static void ZapolRand(ref int[] array, int chisl)\r\n        {\r\n            Random rand = new Random();\r\n            for(int i=0; i< array.Length; i++)\r\n            {\r\n                array[i] = rand.Next(chisl);\r\n            }\r\n            for (int i = 0; i < array.Length; i++)\r\n            {\r\n                Console.WriteLine(array[i]);\r\n            }\r\n            \r\n        } ");
        }
        //метод заполнения  массива рандомом 
        public static void ZapolRand(ref int[] array, int chisl)
        {
            WriteArray.RandWrite(array, 0, chisl);
            WriteArray.Write(array);
        }
    }
}
