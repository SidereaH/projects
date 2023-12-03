using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Timers;
using System.Reflection.Emit;
using System.Threading;

namespace kt20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeTimer()
        { 

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for(int z=20; z>0;z-=5)
            {
                MessageBox.Show("До конца пары осталось " + z + " секунд (нажми чтобы продолжить отсчет");
                System.Threading.Thread.Sleep(5000);
            }
     
        }
        
    }
}
