using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kt19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Круг", "Квадрат", "Треугольник" });
            pictureBox1.Image = Image.FromFile("C:\\Users\\hutor\\Downloads\\kt19.png");
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\hutor\\Downloads\\circlepng.png");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\hutor\\Downloads\\kvadrat.png");
            }
            else pictureBox1.Image = Image.FromFile("C:\\Users\\hutor\\Downloads\\treugol.jpg");
        }
        
    }
}
