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
    public partial class Form1 : Form
    {
        int x, y, z;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            z = 0;

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 platon = new Form2();
            platon.ShowDialog();
            x = 1;
            if (x * y * z == 1) button4.Enabled = true; ;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 test = new Form5();
            test.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 socrate = new Form3();
            socrate.ShowDialog();
            y = 1;
            if (x * y * z == 1) button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 aristotel = new Form4();
            aristotel.ShowDialog();
            z = 1;
            if (x * y * z == 1) button4.Enabled = true; ;
        }
    }
}
