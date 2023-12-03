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

namespace kt23
{
    public partial class Form1 : Form
    {
        public struct Flight
        {
            public int num_r; // номер рейса
            public string punkt_vd; // пункт отправления
            public int time_v; // время вылета
            public int n_places; // общее количество мест
        }
        public struct Tickets
        {
            public int num_t; // номер билета
            public int num_r; // номер рейса
            public int place; // место
            public string date_v; // дата вылета
            public string punkt_pr; //пункт назначения
            public string data_pr; // дата прибытия
            public int time_pr; // время прибытия
            public double price; // цена
            public string time_prod; // время продажи билета
        }
        Dictionary<int, Flight> avia = new Dictionary<int, Flight>();
        List<Tickets> tickets = new List<Tickets>();
        public void Read_Avia()
        {
            StreamReader sr = new StreamReader("Flight.txt", Encoding.Default);
            string s = "";
            string[] fields;
            Flight sa; // дополнительная переменная - структура типа Flight

            // Основной цикл.
            // В цикле:
            // 1. Читаются данные из файла "Flight.txt"
            // 2. Формируется словарь avia типа Dictionary<int, Flight>

            while (s != null)
            {
                s = sr.ReadLine(); // прочитать строку из файла
                if (s != null)
                {
                    fields = s.Split(',');
                    // формирование структуры sa типа struct Flight
                    sa.num_r = Convert.ToInt32(fields[0]);
                    sa.punkt_vd = fields[1];
                    sa.time_v = Convert.ToInt32(fields[2]);
                    sa.n_places = Convert.ToInt32(fields[3]);

                    // добавляем пару <num_r, sa> в словарь avia
                    // ключом к структуре есть номер рейса num_r
                    avia.Add(sa.num_r, sa);

                    // добавить строку s в listBox1
                    listBox1.Items.Add(s);
                }
            }
        }

        public void Read_Tickets()
        {
            StreamReader sr = new StreamReader("Tickets.txt", Encoding.Default);
            string s;
            string[] fields; // массив строк-полей структуры Tickets
            Tickets tk; // вспомогательная переменная-структура

            s = sr.ReadLine();

            // Основной цикл.
            // В цикле:
            // 1. Читаются данные из файла "Tickets.txt"
            // 2. Формируется список tickets типа List<Tickets>

            // используем цикл do...while()
            do
            {
                // разбить строку s на части по признаку символа ','
                fields = s.Split(',');

                // заполнить структуру tk
                tk.num_t = Convert.ToInt32(fields[0]);
                tk.num_r = Convert.ToInt32(fields[1]);
                tk.place = Convert.ToInt32(fields[2]);
                tk.date_v = fields[3];
                tk.punkt_pr = fields[4];
                tk.data_pr = fields[5];
                tk.time_pr = Convert.ToInt32(fields[6]);
                tk.price = Convert.ToDouble(fields[7]);
                tk.time_prod = fields[8];

                // добавить заполненную структуру в список tickets
                tickets.Add(tk);

                listBox2.Items.Add(s);
                s = sr.ReadLine();
            }
            while (s != null);
        }
        public Form1()
        {
            InitializeComponent();
            Read_Avia();
            Read_Tickets();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Расчет
            // 1. Рейсы с максимальной продолжительностью полета
            int i, j;
            int max, tmp;
            bool f_first = true;

            max = 0;

            foreach (var a in avia)
            {
                foreach (var t in tickets)
                    if (a.Value.num_r == t.num_r)
                    {
                        if (f_first)
                        {
                            max = t.time_pr - a.Value.time_v;
                            f_first = false;
                        }
                        else
                        {
                            tmp = t.time_pr - a.Value.time_v;
                            if (max < tmp) max = tmp;
                        }
                    }
            } // на выходе получаем максимальную длительность полета в переменной max

            // формирование списка рейсов с максимальной продолжительностью полета
            listBox3.Items.Clear();

            foreach (var a in avia)
            {
                foreach (var t in tickets)
                    if (a.Value.num_r == t.num_r)
                    {
                        tmp = t.time_pr - a.Value.time_v;
                        if (tmp == max)
                        {
                            string s;
                            s = a.Value.num_r.ToString() + ", " +
                                a.Value.punkt_vd + ", " +
                                a.Value.time_v.ToString() + ", " +
                                a.Value.n_places.ToString() + " - " +
                                t.num_t.ToString() + ", " +
                                t.punkt_pr + ", " +
                                t.time_pr.ToString() + ", " +
                                t.place.ToString();

                            listBox3.Items.Add(s);
                        }
                    }
            }

            label4.Text = "Рейсы с максимальной продолжительностью полета: " + max.ToString();

            // 2. Число пассажиров, которые ждут отправления в введенный момент времени
            int tm, k;

            tm = Int32.Parse(textBox1.Text); // получить время
            k = 0; // число пассажиров
            foreach (var a in avia)
            {
                foreach (var t in tickets)
                    if ((a.Value.num_r == t.num_r) && (tm == a.Value.time_v))
                        k++;
            }

            label5.Text = "Число пассажиров, которые ждут отправления: " + k.ToString();
        }
    }
}
