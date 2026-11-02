using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_2
{
    public partial class Form1 : Form
    {
        private const double SMALL_PRICE = 20;
        private const double MEDIUM_PRICE = 35;
        private const double LARGE_PRICE = 55;

       
        private const double THICK_PRICE = 2;
        private const double THIN_PRICE = 1;

       

        public Form1()
        {
            InitializeComponent();
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        { 
        }
        public void totalAmount()
        {
            double toppingAmount = 7;
            double total = 0;
            if (rdSmall.Checked)
                total += SMALL_PRICE;
            else if (rdMedium.Checked)
                total += MEDIUM_PRICE;
            else if (rdLarge.Checked)
                total += LARGE_PRICE;

            if (rdThick.Checked)
                total += THICK_PRICE;
            else if (rdThin.Checked)
                total += THIN_PRICE;

            if (chkPepperoni.Checked == true || chkJalapeno.Checked == true || chkSpinach.Checked == true || chkExtraCheese.Checked == true ||
               chkPineapple.Checked == true || chkSheddedChicken.Checked == true || chkMushroom.Checked == true ||
               chkDriedShrimp.Checked == true || chkGroundedBeef.Checked == true)

                toppingAmount += toppingAmount;
                total += toppingAmount;

            lblAmountDue.Text = $"Amount Due: R {total}";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            totalAmount();
        }
    }
}

