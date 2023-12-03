using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zachettt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*Start:
            
            
            Console.WriteLine("Вернуться к выбору задания? y/n");
            char ans = char.Parse(Console.ReadLine());
            if (ans == 'y')
            {
                goto Start;
                Console.Clear();
            }
            else
            {
                Environment.Exit(0);
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "1. Дано натуральное число N. Найти сумму его четных делителей.\r\n\r\n2. Дано натуральное число. Определить, какая цифра встречается чаще: 0 или 9.\r\n\r\n3. Найти сумму -12 + 22 – 32 + 42 – 5 2 + . . . + 402 .\r\n\r\n4. Найти все трехзначные числа, которые делятся на n или содержат цифру n (n вводится с клавиатуры).\r\n\r\n5. Дано натуральное число n . Вычислить: P = 2 × 4 × 6 × . . . × (2n)\r\n\r\n6. Дано вещественное число a. Напечатать все значения n, при которых: 1+1/2+1/3+...+1/n>a \r\n\r\n7. Дано натуральное число. Определить, является ли разность его максимальной и минимальной цифр четным числом.\r\n\r\n8. Даны два натуральных числа. Выяснить, в каком из них сумма цифр больше.\r\n\r\n9. Даны шесть различных натуральных чисел. Определить максимальное из них.\r\n\r\n10. Даны стороны двух треугольников. Найти сумму их площадей.\r\n\r\n11. Вычислить значение выражения (2*5!+3*8!)/(6!+4!), используя функцию для вычисления n!\r\n\r\n12. Даны 3 натуральных числа. Определить, у какого из них среднее арифметическое цифр больше\r\n\r\n13. Дан одномерный массив целых чисел. Найти максимальный элемент массива и поменять его местами с первым элементом.\r\n\r\n14. Известно, что в одномерном массиве имеются элементы, равные 5. Определить номер первого из них.\r\n\r\n15. Дан одномерный массив из четного числа элементов. Поменять местами его первый элемент со вторым, третий с четвертым и т.д.\r\n\r\n16. Дан массив, содержащий 10 трехзначных чисел. Заменить каждый элемент массива разностью максимальной и минимальной из его цифр.\r\n\r\n17. Дан одномерный массив целых чисел. Напечатать все элементы, следующие за последним, оканчивающиеся цифрой \"7\". Если элементов, оканчивающихся цифрой \"7\", в массиве нет, то ни один элемент не должен быть напечатан.\r\n\r\n18. Дан двумерный массив размером n на n, заполненный целыми числами. Все его отрицательные элементы записать в первый одномерный массив, все его четные элементы - во второй, а нечетные - в третий.\r\n\r\n19. Дан двумерный массив целых чисел. В каждой его строке найти сумму отрицательных элементов.\r\n\r\n20. Дан двумерный массив целых чисел. Определить минимальный номер столбца, состоящего только из элементов, больших числа 10 (считать, что такой столбец обязательно есть).\r\n\r\n21. Дан двумерный массив. Найти строку с максимальной суммой элементов. ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(textBox1.Text);

                switch (i)
                {
                    case 1:
                        ChetChisl.ChetChsilo();
                        break;
                    case 2:
                        NatChisl.NatChislo();
                        break;
                    case 3:
                        SearchSum.SearchSumS();
                        break;
                    case 4:
                        TrexZn.TrexZnN();
                        break;
                    case 5:
                        SearchP.SearchPN();
                        break;
                    case 6:
                        VeshChisl.VeshChislN();
                        break;
                    case 7:
                        RaznMinMax.RaznMinMAxN();
                        break;
                    case 8:
                        SumCifrvChisle.SumCifrex8();
                        break;
                    case 9:
                        MaxFromSix.Max();
                        break;
                    case 10:
                        Ploshtr.SumPlosh();
                        break;
                    case 11:
                        FactFunVar.Reshex11();
                        
                        break;
                    case 12:
                        SrArifmCifr.Cifri();
                        break;
                    case 13:
                        MassMaxChange.Ex13();
                        break;
                    case 14:
                        Ex14Search5.SearchMain();
                        break;
                    case 15:
                        ChangePlacesArrEx15.Changearr();
                        break;
                    case 16:
                        ArrayChangeMinMaxEx16.MainChange();
                        break;
                    case 17:

                        break;
                    case 18:

                        break;
                    case 19:

                        break;
                    case 20:

                        break;
                    case 21:

                        break;

                    default:
                        MessageBox.Show("Такого задания не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
            catch (System.FormatException eeee)
            {
                MessageBox.Show($"Неправильный формат ввода \r\n{eeee} ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
