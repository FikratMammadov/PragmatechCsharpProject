using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text.Trim().ToLower();
            string surname = surnameText.Text.Trim().ToLower();
            string phoneNumber = phoneTextBox.Text;
            string birthDate = dateTimePicker1.Text;

            ListViewItem user = new ListViewItem();
            user.Text = name;
            user.SubItems.Add(surname);
            user.SubItems.Add(phoneNumber);
            user.SubItems.Add(birthDate);

            listView1.Items.Add(user);

            nameText.Clear();
            surnameText.Clear();
            phoneTextBox.Clear();
            dateTimePicker1.Value = DateTime.Now;
            nameText.Focus();
             
            
        }
    }
}
