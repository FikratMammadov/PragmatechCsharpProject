using System;
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

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double result = 0;
            string _operator = operatorBox.SelectedItem.ToString() ;
            double num1 = Convert.ToInt32(numericUpDown1.Value);
            double num2 = Convert.ToInt32(numericUpDown2.Value);

            switch (_operator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("0-a bolme emeliyyati yoxdur");
                    }
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "%":
                    if (num2 != 0)
                    {
                        result = num1 % num2;
                    }
                    else
                    {
                        MessageBox.Show("0-a bolme emeliyyati yoxdur");
                    }
                     
                    break;
                default:
                    break;
            }

            labelAnswer.Text = result.ToString();
        }
    }
}
