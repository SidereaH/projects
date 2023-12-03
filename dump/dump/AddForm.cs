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

namespace dump
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.umnikithubDataSet1.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbSurName.Text;
                nRow[2] = tbIni.Text;
                nRow[3] = tbBall.Text;
               
                main.umnikithubDataSet1.Tables[0].Rows.Add(nRow);
                main.uspevaemostTableAdapter1.Update(main.umnikithubDataSet1.uspevaemost);
                main.umnikithubDataSet1.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbSurName.Text = "";
                tbIni.Text = "";
                tbBall.Text = "";
                
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
