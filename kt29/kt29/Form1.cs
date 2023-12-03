using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kt29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "umnikithubDataSet.uspevaemost". При необходимости она может быть перемещена или удалена.
            this.uspevaemostTableAdapter.Fill(this.umnikithubDataSet.uspevaemost);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            uspevaemostTableAdapter.Update(umnikithubDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }
    }
}
