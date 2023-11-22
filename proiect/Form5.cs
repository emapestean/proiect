using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (radioButton2.Checked)
                a++;
            if (radioButton5.Checked)
                a++;
            if (radioButton9.Checked)
                a++;
            if (radioButton10.Checked)
                a++;
            if (radioButton12.Checked)
                a++;
            if (radioButton15.Checked)
                a++;
            if (radioButton19.Checked)
                a++;
            if (radioButton23.Checked)
                a++;
            if (radioButton27.Checked)
                a++;
            if (a >= 5) textBox1.Visible = true;
            else textBox2.Visible = true;

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
