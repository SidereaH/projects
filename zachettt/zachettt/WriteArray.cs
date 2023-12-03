using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class WriteArray
    {
        public static void Write(int[] arr)
        {
            for( int i =0; i< arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void RandWrite(int[] array, int chislstart, int chislend)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(chislstart, chislend);
            }
        }
        public static void Read(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
