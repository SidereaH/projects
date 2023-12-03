using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kt29
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.umnikithubDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                nRow[2] = tbIO.Text;
                nRow[3] = tbBall.Text;
                
                main.umnikithubDataSet.Tables[0].Rows.Add(nRow);
                main.uspevaemostTableAdapter.Update(main.umnikithubDataSet.uspevaemost);
                main.umnikithubDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
                tbIO.Text = "";
                tbBall.Text = "";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
