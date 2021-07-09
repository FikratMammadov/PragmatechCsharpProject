using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(user))
            {
                listBox1.Items.Add(user);

                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void mixBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int listLen = listBox1.Items.Count;

            int[] rndNums = new int[listLen];
            ArrayList users = new ArrayList();

            for (int i = 0; i < listLen; i++)
            {
                int rndNum = rnd.Next(1, listLen+1);

                if (!rndNums.Contains(rndNum))
                {
                    rndNums[i] = rndNum;
                    users.Add(listBox1.Items[rndNums[i]-1].ToString());
                }
                else
                {
                    i--;
                }
            }

            for (int i = 0; i < listLen; i++)
            {
                listBox1.Items[i] = users[i];
            }

        }
    }
}
