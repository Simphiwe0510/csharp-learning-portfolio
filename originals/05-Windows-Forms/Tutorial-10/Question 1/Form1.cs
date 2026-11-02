using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
       
           
            string customerName = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            double interest = 0.25;
            double total = price + (price * interest);
            double balance = total;
           
            lstOutput.Items.Add("Payment \t New Payment");
            lstOutput.Items.Add("======  \t ===========");
            lstOutput.Items.Add(0 + "\t" +"R"+total);

            while (balance > 15)
            {
                double monthlyPay = balance * 0.12;
                balance -= monthlyPay;

                lstOutput.Items.Add("R"+ monthlyPay.ToString("F2") +"\tR"+ balance.ToString("F2"));
                
            }
            if (balance > 0 && balance <= 15)
            {
                lstOutput.Items.Add("Final Payment = R" + balance.ToString("F2"));
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPrice.Clear();
            lstOutput.Items.Clear();
        }
    }
}
