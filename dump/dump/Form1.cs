using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace dump
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "umnikithubDataSet1.uspevaemost". При необходимости она может быть перемещена или удалена.
            this.uspevaemostTableAdapter1.Fill(this.umnikithubDataSet1.uspevaemost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "umnikithubDataSet.uspevaemost". При необходимости она может быть перемещена или удалена.
        

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.uspevaemostTableAdapter1.Update(this.umnikithubDataSet1.uspevaemost);
        }

        private void AddDB_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
