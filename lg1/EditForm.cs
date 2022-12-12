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
    public partial class EditForm : Form
    {
        private string id;
        private string name;
        private string octe;
        private string price;
        public EditForm(string id, string name, string octe, string price)
        {
            this.id = id;
            this.name = name;
            this.octe = octe;
            this.price = price;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Table)Owner).DeletRow(id);
            ((Table)Owner).AddRow(id, textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            textBox2.Text = name;
            textBox3.Text = octe;
            textBox4.Text = price;
        }
    }
}
