using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isAnyRadioButtonChecked1 = false;
            bool isAnyRadioButtonChecked2 = false;
            bool isAnyRadioButtonChecked3 = false;
            bool isAnyRadioButtonChecked4 = false;
            foreach (RadioButton rdo in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked1 = true;
                    break;
                }
            }
            foreach (RadioButton rdo in groupBox2.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked2 = true;
                    break;
                }
            }
            foreach (RadioButton rdo in groupBox3.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked3 = true;
                    break;
                }
            }
            foreach (RadioButton rdo in groupBox4.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnyRadioButtonChecked4 = true;
                    break;
                }
            }
            if (isAnyRadioButtonChecked1 && isAnyRadioButtonChecked2 && isAnyRadioButtonChecked2 && isAnyRadioButtonChecked3 && isAnyRadioButtonChecked4)
            {
                //1 6 10 8 кнопки с ответами

                if (radioButton1.Checked)
                {
                    label1.Text = "1) правильно";

                }
                else if(radioButton2.Checked|| radioButton3.Checked) label1.Text = "1) подними голову вверх";
                if (radioButton6.Checked)
                {
                    label2.Text = "2) горька правда";
                }
                else if (radioButton4.Checked || radioButton5.Checked) label2.Text = "2) оптимист?";
                if (radioButton10.Checked)
                {
                    label3.Text = "3) молодец правильно";
                }
                else if (radioButton11.Checked || radioButton12.Checked) label3.Text = "3) чо зумерок мультики не смотрел да?🤣🤣🤣🤣";
                if (radioButton8.Checked)
                {
                    label4.Text = "4) другие типа да 😎😎😎";
                }
                else if (radioButton7.Checked || radioButton8.Checked) label4.Text = "4) чето ты позер какой-то";
                if(radioButton1.Checked && radioButton6.Checked && radioButton10.Checked && radioButton8.Checked )
                {
                    button2.Enabled = true;
                    MessageBox.Show("Поздравляю");
                    MessageBox.Show("вы");
                    MessageBox.Show("прошли");
                    MessageBox.Show("игру");

                }
                
               
            }
            else
            {
                MessageBox.Show("Вы не выбрали ответ в одном из пунктов");
            }
            
            
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
