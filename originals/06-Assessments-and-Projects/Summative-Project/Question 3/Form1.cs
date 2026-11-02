using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Routine = 20;
            double ChechUP = 25;
            double Extended = 30;

            double Rabies = 17;
            double HeartwormPreventions = 21;
            double total = 0;

            if(rdRoutine.Checked)
            {
                total += Routine;
            }
            if(rdCheckup.Checked)
            {
                total += ChechUP;
            }
            if(rdExtended.Checked)
            {
                total += Extended;
            }
            if(chkHeartworm.Checked)
            {
                total += HeartwormPreventions;
            }
            if(chkRables.Checked)
            {
                total += Rabies;
            }
            if(chkHospitalizationNumberOfDays.Checked)
            {
                total += 2;
            }
            string petName = txtPetName.Text;
            MessageBox.Show("The total bill for " + petName + "is: "+total);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPetName.Clear();
            txtHospitalizationNumberofdays.Clear();

            rdCheckup.Checked = false;
            rdExtended.Checked = false;
            rdRoutine.Checked = false;
            chkHeartworm.Checked = false;
            chkHospitalizationNumberOfDays.Checked = false;
            chkRables.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
