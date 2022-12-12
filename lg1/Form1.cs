using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lg1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(1);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(2);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(3);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(4);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(5);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(6);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(7);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(8);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(9);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(10);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(11);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(12);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(13);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Table tableForm = new Table(14);
            tableForm.ShowDialog();
            tableForm.Owner = this;
        }
    }
}
