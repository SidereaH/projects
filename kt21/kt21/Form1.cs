using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kt21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label5.Text = String.Format(e.Start.ToLongDateString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surName = textBox1.Text;
            string name = textBox2.Text;
            string secondname = textBox3.Text;
            string dateofBirth = label5.Text;
            MessageBox.Show("Сотрудник:" + Environment.NewLine + "Фамилия: " + surName + Environment.NewLine + "Имя: " + name + Environment.NewLine + "Отчество: " + secondname+ Environment.NewLine + "Дата рождения: " + dateofBirth);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
