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

namespace Task01
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productComboBox.Enabled = false;
        }  
        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(categoryComboBox.Text)||string.IsNullOrEmpty(productComboBox.Text)
                || weightNumericUpDown.Value==0 || priceNumericUpDown.Value==0 || string.IsNullOrEmpty(deliveryComboBox.Text))
            {
                MessageBox.Show("Zəhmət olmasa xanaların hamısını doldurun.");
            }
            else
            {
                string productCategory = categoryComboBox.Text;
                string productName = productComboBox.Text.ToLower();
                decimal productWeight = weightNumericUpDown.Value;
                decimal productPrice = priceNumericUpDown.Value;
                string productDelivery = deliveryComboBox.Text;
                DateTime date = DateTime.Now;

                Product prd = new Product()
                {
                    ProductCategory = productCategory,
                    ProductName = productName,
                    ProductWeight = productWeight,
                    ProductPrice = productPrice,
                    ProductDelivery = productDelivery,
                    Date = date
                };
                Order(prd);
                 
            }
        }
        public void Order(Product p)
        {
            ListViewItem lst = new ListViewItem();
            lst.Text = p.ProductCategory;
            lst.SubItems.Add(p.ProductName);
            lst.SubItems.Add(p.ProductWeight.ToString());
            lst.SubItems.Add(p.ProductPrice.ToString());
            lst.SubItems.Add(p.ProductDelivery);
            lst.SubItems.Add(p.Date.ToString("dd-MM-yyyy HH:mm"));
            listView1.Items.Add(lst);

            // Xanalari sifirla
            categoryComboBox.SelectedIndex = -1;
            productComboBox.SelectedIndex = -1;
            weightNumericUpDown.Value = 0;
            priceNumericUpDown.Value = 0;
            deliveryComboBox.SelectedIndex = -1;
        }


        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productComboBox.Enabled = true;
            string productCategory = categoryComboBox.Text.ToLower();

            switch (productCategory)
            {
                case "meyve":
                    productComboBox.Items.Clear();
                    productComboBox.Items.Add("Alma");
                    productComboBox.Items.Add("Armud");
                    productComboBox.Items.Add("Alca");
                    break;
                case "terevez":
                    productComboBox.Items.Clear();
                    productComboBox.Items.Add("Kartof");
                    productComboBox.Items.Add("Xiyar");
                    productComboBox.Items.Add("Pomidor");
                    break;
                default:
                    break;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int listCount = listView1.Items.Count;
            string productName = searchTextBox.Text.ToLower();
            string msg = "";
            int index = 0;
            for (int i = 0; i < listCount; i++)
            {
                if (listView1.Items[i].SubItems[1].Text==productName)
                {
                    msg += "Kateqoriya: " + listView1.Items[i].Text + "  Adi: " + listView1.Items[i].SubItems[1].Text+
                      "  Çəki: "+ listView1.Items[i].SubItems[2].Text + "  Qiymet: "+ listView1.Items[i].SubItems[3].Text +"\n";
                    index++;
                }
            }
            if (index==0)
            {
                MessageBox.Show(productName + " siyahida yoxdur.");
            }
            else
            {
                MessageBox.Show(msg);
            } 
        }

        private void deleteCheckedBtn_Click(object sender, EventArgs e)
        {
            int checkedItemNum = listView1.CheckedItems.Count;
            foreach (ListViewItem checkedItem in listView1.CheckedItems)
            {
                checkedItem.Remove();
            }
            MessageBox.Show(checkedItemNum +" mehsul silindi.");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedItemNum = listView1.SelectedItems.Count;
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                selectedItem.Remove();
            }
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
