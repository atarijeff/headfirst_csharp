using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTravelled;
        double reimbursementRate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int)startingMileageNumeric.Value;
            endingMileage = (int)endingMileageNumeric.Value;
            
            if (startingMileage > endingMileage)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage",
                    "Cannot Calculate Mileage");
            }
            else
            {
                milesTravelled = endingMileage - startingMileage;
                amountOwed = milesTravelled * reimbursementRate;
                amountOwedLabel.Text = "$" + amountOwed;
            }
        }

        private void displayMilesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Travelled " + milesTravelled + " miles",
                "Miles Travelled");
        }
    }
}
