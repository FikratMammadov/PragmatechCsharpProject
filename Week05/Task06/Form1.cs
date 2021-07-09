using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modelComboBox.Enabled = false;
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
             
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                colorBtn.BackColor = colorDialog1.Color;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marka = markaComboBox.Text.Trim().ToLower();
            modelComboBox.Enabled = true;

            switch (marka)
            {
                case "bmw":
                    modelComboBox.Items.Clear();
                    modelComboBox.Items.Add("X4");
                    modelComboBox.Items.Add("X5");
                    modelComboBox.Items.Add("X6");
                    break;
                case "audi":
                    modelComboBox.Items.Clear();
                    modelComboBox.Items.Add("A4");
                    modelComboBox.Items.Add("A5");
                    modelComboBox.Items.Add("A6");
                    break;
                case "mercedes":
                    modelComboBox.Items.Clear();
                    modelComboBox.Items.Add("C200");
                    modelComboBox.Items.Add("C220");
                    modelComboBox.Items.Add("C230");
                    break;
                default:
                    break;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string marka = markaComboBox.Text.Trim().ToLower();
            string model = modelComboBox.Text.Trim().ToLower();
            string yanacaqTipi = yanacaqComboBox.Text.Trim().ToLower();
            string kuzaTipi = kuzaComboBox.Text.Trim().ToLower();
            string skorostTipi = skorostComboBox.Text.Trim().ToLower();
            string motorTipi = motorComboBox.Text.Trim().ToLower();
            string buraxilisIli = dateTimePicker1.Text.Trim().ToLower();

            ListViewItem masin = new ListViewItem();
            masin.Text = marka;
            masin.SubItems.Add(model);
            masin.SubItems.Add(yanacaqTipi);
            masin.SubItems.Add(kuzaTipi);
            masin.SubItems.Add(skorostTipi);
            masin.SubItems.Add(motorTipi);
            masin.UseItemStyleForSubItems = false;
            masin.SubItems.Add(string.Empty).BackColor = colorBtn.BackColor;
            masin.SubItems.Add(buraxilisIli);

            listView1.Items.Add(masin);

            markaComboBox.SelectedIndex =-1;
            modelComboBox.SelectedIndex = -1;
            yanacaqComboBox.SelectedIndex = -1;
            kuzaComboBox.SelectedIndex = -1;
            skorostComboBox.SelectedIndex = -1;
            motorComboBox.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            
        }
    }
}
