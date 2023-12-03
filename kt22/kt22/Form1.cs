using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kt22
{
    public partial class Form1 : Form
    {
        bool f_open, f_save;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Открытие окна и проверка, выбран ли файл
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 2. Вывести имя файла на форме в компоненте label1
                label1.Text = openFileDialog1.FileName;

                // 3. Установить флажки f_open и f_save
                f_open = true;
                f_save = false;

                // 4. Прочитать файл в richTextBox1
                // очистить предыдущий текст в richTextBox1
                richTextBox1.Clear();

                // 5. Создать объект класса StreamReader и прочитать данные из файла
                StreamReader sr = File.OpenText(openFileDialog1.FileName);

                // дополнительная переменная для чтения строки из файла
                string line = null;
                line = sr.ReadLine(); // чтение первой строки

                // 6. Цикл чтения строк из файла, если строки уже нет, то line=null
                while (line != null)
                {
                    // 6.1. Добавить строку в richTextBox1
                    richTextBox1.AppendText(line);

                    // 6.2. Добавить символ перевода строки
                    richTextBox1.AppendText("\r\n");

                    // 6.3. Считать следующую строку
                    line = sr.ReadLine();
                }

                // 7. Закрыть соединение с файлом
                sr.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            f_save = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Проверка, открыт ли файл
            if (!f_open) return;

            // 2. Если файл открыт, то проверка – сохранен ли он
            if (f_save) return;

            // 3. Создание объекта типа StreamWriter и получение строчных данных
            StreamWriter sw = File.CreateText(openFileDialog1.FileName);

            // 4. Чтение строк с richTextBox1 и добавление их в файл
            string line;
            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                // 4.1. Чтение одной строки
                line = richTextBox1.Lines[i].ToString();

                // 4.2. Добавление этой строки в файл
                sw.WriteLine(line);
            }

            // 5. Закрыть объект sw
            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f_open = false; // файл не открыт
            f_save = false;
            label1.Text = "-";
            richTextBox1.Text = "";
        }
    }
}
