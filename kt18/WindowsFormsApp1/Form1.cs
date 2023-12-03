using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = Image.FromFile("C:\\Users\\hutor\\Downloads\\b74e798a2f7170ee239a68ea899ac2b4.jpg");
            pictureBox1.ErrorImage = Image.FromFile("C:\\Users\\hutor\\Downloads\\b74e798a2f7170ee239a68ea899ac2b4.jpg"); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // no smaller than design time size
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            // no larger than screen size
            
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            // rest of your code here...
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\hutor\\Downloads\\1.1.jpg");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\hutor\\Downloads\\22.jpg");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\hutor\\Downloads\\33.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
