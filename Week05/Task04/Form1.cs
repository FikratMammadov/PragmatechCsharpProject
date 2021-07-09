using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim().ToUpper();
            if (!string.IsNullOrEmpty(user))
            {
                listBox1.Items.Add(user);

                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            MessageBox.Show("Count: "+count.ToString());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim().ToUpper();

            if (listBox1.Items.Contains(name))
            {
                MessageBox.Show(name+ " liste daxildir.");
            }
            else
            {
                MessageBox.Show(name + " liste daxil deyil.");
            }
        }
    }
}
