using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class Form1 : Form
    {
        private Pizza _pizza;
        List<string> ingridients = new List<string>();
        string ingridientsMsg = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sizeComboBox.Text) && !string.IsNullOrEmpty(pizzaList.SelectedItem.ToString())
                && (radioFine.Checked==true || radioThick.Checked ==true))
            {
                Pizza pizza = CreatePizza();
                double totalPrice = PizzaPrice(pizza);

                totalPriceLabel.Text = totalPrice.ToString();
                _pizza = pizza;
            }
            else
            {
                MessageBox.Show("Xanalarin hamisini doldurun.");
            }

        }

        public Pizza CreatePizza()
        {
             
            var pizza = new Pizza();
            pizza.Size = sizeComboBox.Text.ToLower();
            pizza.Name = pizzaList.SelectedItem.ToString();
            pizza.IsFineEdged = IsFineEdged();
            pizza.IngridientCount = IngridientCount();
            return pizza;
        }

        public double PizzaSize(Pizza pizza)
        {
            double pizzaSize = 0;
            string size = pizza.Size;
            switch (size)
            {
                case "kicik":
                    pizzaSize = 1;
                    break;
                case "orta":
                    pizzaSize = 1.25;
                    break;
                case "boyuk":
                    pizzaSize = 1.75;
                    break;
                case "maxi":
                    pizzaSize = 2;
                    break;
                default:
                    break;
            }
            return pizzaSize;
        }

        public double PizzaPrice(Pizza pizza)
        {
            double totalPrice = 0;
            string pizzaName = pizza.Name.ToLower();
            double pizzaSize = PizzaSize(pizza);
            if (!pizza.IsFineEdged)
            {
                totalPrice += 2 * (double)numberUpDown.Value;
            }

            switch (pizzaName)
            {
                case "klassik":
                    totalPrice += (pizza.IngridientCount * 2 + (9 * pizzaSize)) * (int)numberUpDown.Value;
                    break;
                case "qarisiq":
                    totalPrice += (pizza.IngridientCount * 2 + (10 * pizzaSize)) * (int)numberUpDown.Value;
                    break;
                case "pendirli":
                    totalPrice += (pizza.IngridientCount * 2 + (13 * pizzaSize)) * (int)numberUpDown.Value;
                    break;
                case "kolbasali":
                    totalPrice += (pizza.IngridientCount * 2 + (11 * pizzaSize)) * (int)numberUpDown.Value;
                    break;
                case "italiano":
                    totalPrice += (pizza.IngridientCount * 2 + (14 * pizzaSize)) * (int)numberUpDown.Value;
                    break;
                case "mexicano":
                    totalPrice += (pizza.IngridientCount * 2 + (13 * pizzaSize)) * (int)numberUpDown.Value;
                    break;
                default:
                    break;
            }

            return totalPrice;
        }

        public bool IsFineEdged()
        {
            if (radioFine.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }        
        }

        public int IngridientCount()
        {
            
            int count = 0;
            foreach (CheckBox item in groupBoxIngridients.Controls)
            {
                if (item.Checked && !ingridients.Contains(item.Text))
                {
                    ingridients.Add(item.Text);
                    count++;
                }
            }
            return count;
        }

        public void ClearControls()
        {
            sizeComboBox.SelectedIndex = -1;
            pizzaList.SelectedIndex = -1;
            radioFine.Checked = false;
            radioThick.Checked = false;

            foreach (CheckBox item in groupBoxIngridients.Controls)
            {
                item.Checked = false;
            }

            numberUpDown.Value = 0;
            _pizza.Name = "";
            _pizza.Size = "";
            ingridientsMsg = "";
            ingridients.Clear();
        }

        private void addShoppingCartBtn_Click(object sender, EventArgs e)
        {
            if (!numberUpDown.Value.Equals(0m))
            {
                double totalPrice = PizzaPrice(_pizza);
                 
                foreach (string ingridient in ingridients)
                {
                    ingridientsMsg += $" {ingridient}";
                }

                string pizzaInfo = $"{_pizza.Size} {_pizza.Name} pizza,     Ingridients: {ingridientsMsg}     Qiymet: {totalPrice}";
                shoppingCartListBox.Items.Add(pizzaInfo);
                ClearControls();
            }
            else
            {
                MessageBox.Show("Xanalar tam doldurulmayib ve ya pizza miqdari 0 dir.");
            }


            // reset
             
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (shoppingCartListBox.Items.Count==0)
            {
                MessageBox.Show("Sebet bosdur.");
            }
            else
            {
                MessageBox.Show("Sifaris tesdiq olundu.");
                shoppingCartListBox.Items.Clear();
            }
             
        }
    }   
}
