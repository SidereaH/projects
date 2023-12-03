using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace itogKT
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.bibliotekaDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc -1 ;
                nRow[1] = tbAuthor.Text;
                nRow[2] = tbName.Text;
                nRow[3] = tbCol.Text;
                nRow[4] = tbColruk.Text;
                main.bibliotekaDataSet.Tables[0].Rows.Add(nRow);
                main.catalogTableAdapter.Update(main.bibliotekaDataSet.catalog);
                main.bibliotekaDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbAuthor.Text = "";
                tbName.Text = "";
                tbCol.Text = "";
                tbColruk.Text = "";
            }
        }
    }
}
