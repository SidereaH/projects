using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachettt
{
    public class ArrayChangeMinMaxEx16
    {
        public static void MainChange()
        {
            Console.Clear();
            Console.WriteLine("16. Дан массив, содержащий 10 трехзначных чисел. Заменить каждый элемент массива разностью максимальной и минимальной из его цифр.");
            int[] arr = new int[10];
            WriteArray.RandWrite(arr, 100, 1000);
            WriteArray.Write(arr);
            int n;
            int k = 0;
            int mx;
            int mn;
            int raznost;
            for(int i =0; i<arr.Length;i++){
                mx = Max(arr[i]);
                mn = Min(arr[i]);
                raznost = mx-mn;
                arr[i] = raznost;
            }
            Console.WriteLine("Новый массив:");
            WriteArray.Write(arr);

        }
        public static int Max(int n)
        {
            int x1 = n % 100;
            int x2 = (n / 10) % 10;
            int x3 = n % 10;
            int max;
            
            if ((x1 > x2) && (x1 > x3))   max = x1;
            else if ((x2 > x1) && (x2 > x3)) max = x2;
            else max = x3;
            return max;
        }
        public static int Min(int n)
        {
            int x1 = n % 100;
            int x2 = (n / 10) % 10;
            int x3 = n % 10;
            
            int min;
            if ((x1 < x2) && (x1 < x3)) min = x1;
            else if ((x2 < x1) && (x2 < x3)) min = x2;
            else min = x3;
            return min;
        }


    }
}
