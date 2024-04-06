//S2337
//CIS 199-50
// 03/30/2023

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        //arrays
        string[] carTypeLookup = { "PreOwned", "Certified", "New" };
        double[] discountLoop = { 0.20, 0.15, 0.10 };

        string[] carName = { "Chevy Volt", "Mclaren 720S", "Subaru Outback", "Toyota Camry", "Saturn Sky", "Ford Mustang GT", "Honda Civic" };
        double[] carPrices = { 27495.00, 305000.00, 28395.00, 30771.00, 11583.00, 27770.00, 25050.00 };

        double[] creditLowlimit = { 0, 501, 601, 701 };
        double[] loanAmount = { 0, 500, 1500, 2500 };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //declare variables
            bool cartypeFound = false;
            bool carnameFound = false;
            bool creditFound = false;
            double discount = 0;
            double loan = 0;

            //Validating car type
            if (carTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a car type!");
                return;
            }

            //Validating car name
            if (carComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a car!");
                return;
            }

            //Validating down payment
            if (!double.TryParse(txtDownPayment.Text, out double downPayment) || downPayment < 0)
            {
                MessageBox.Show("You must enter a valid down payment!");
                return;
            }

            //Validating credit score
            if (!double.TryParse(txtCreditScore.Text, out double creditScore) || creditScore < 0 || creditScore > 800)
            {
                MessageBox.Show("You must enter a valid credit score!");
                return;
            }

            // loop for car type discount
            for (int i = 0; i < carTypeLookup.Length && !cartypeFound; i++)
            {
                if (carTypeComboBox.SelectedItem.ToString() == carTypeLookup[i])
                {
                    cartypeFound = true;
                    discount = discountLoop[i];
                }
            }

            //loop for car name
            for (int i = 0; i < carName.Length && !carnameFound; i++)
            {
                if (carComboBox.SelectedItem.ToString() == carName[i])
                {
                    carnameFound = true;
                    lblCarPrice.Text = carPrices[i].ToString();
                }

            }

            //Finding loan amount from credit score
            for (int i = 0; i < creditLowlimit.Length && !creditFound; i++)
            {
                if (creditScore >= creditLowlimit[i])
                {
                    creditFound = true;
                    loan = loanAmount[i];
                }
            }

            //Adding loan amount for a credit score of 650
            if (creditScore == 650)
            {
                loan += 1500;
            }

            //Calculating total owed
            double carPrice = double.Parse(lblCarPrice.Text);
            double totalOwed = carPrice - (carPrice * discount) - downPayment - loan;

            //outputs
            lblCarPrice.Text = carPrice.ToString("C");
            lblDiscount.Text = (discount * 100).ToString("0.##") + "%";
            lblDownPayment.Text = downPayment.ToString("C");
            lblLoanOffered.Text = loan.ToString("C");
            lblTotalOwed.Text = totalOwed.ToString("C");
       
        }
    }
}
