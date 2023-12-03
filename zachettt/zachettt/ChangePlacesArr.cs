using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zachettt
{
    public class ChangePlacesArrEx15
    {
        public static void Changearr()
        {
            Console.WriteLine("15. Дан одномерный массив из четного числа элементов. Поменять местами его первый элемент со вторым, третий с четвертым и т.д.");
            Error:
            Console.WriteLine("Введите четный размер массива:  ");
            int razmarr = int.Parse(Console.ReadLine());
            if (razmarr % 2 == 0)
            {
                Random rand = new Random();
                int[] arr = new int[razmarr];
                WriteArray.RandWrite(arr, 0, 100);
                WriteArray.Write(arr);
                int temp;
                for (int i = 0; i < arr.Length; i ++) 
                {
                    temp = arr[i+1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
                Console.WriteLine("Ваш массив: после перемены мест");
                WriteArray.Write(arr);


            }
            else
            {
                MessageBox.Show($"Размер массива нечетный \r\n ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto Error;
            }

        }
    }
}
