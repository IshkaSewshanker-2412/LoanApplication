using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LoanApplicationCalculator
{
    /// <summary>
    /// Interaction logic for HomeLoan.xaml
    /// </summary>
    public partial class HomeLoan : Window
    {
        public double purchPrice = 0;
        public double totalDeposit = 0;
        public int interestRate = 0;
        public int numOfMonths = 0;
        public HomeLoan()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           double depositAmount = (Convert.ToDouble(txtBox_propPrice.Text) - (Convert.ToDouble(txtBox_propPrice.Text) - Convert.ToDouble(txtBox_TotDep.Text)));

            double totalRepay = (Convert.ToDouble(txtBox_propPrice.Text) - depositAmount * (1 + ((Convert.ToInt32(txtBox_IntRate.Text) / 100) 
                * (Convert.ToInt32(txtBox_numMonths.Text) / 12))));

            double monthlyRepay = totalRepay / (Convert.ToInt32(txtBox_numMonths.Text));

            MessageBox.Show("\n\n***RECIEPT FOR LOAN REPAYMENT***"
           + "\nPurchase price of property: R" + txtBox_propPrice.Text
           + "\nTotal deposit Fee: " + "R " + txtBox_TotDep.Text 
           + "\nInterest rate: (%) "  + txtBox_IntRate.Text 
           + "\nNumber of months to repay: " + txtBox_numMonths.Text
           + "\n Total deposit amount" + depositAmount
           + "\nTotal home loan repayment amount: R " + totalRepay
           + "\nMonthly repayment amount: R " + monthlyRepay);
                
        }

        private void txtBox_propPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            purchPrice = Convert.ToDouble(txtBox_propPrice.Text);
        }

        private void txtBox_TotDep_TextChanged(object sender, TextChangedEventArgs e)
        {
            totalDeposit = Convert.ToDouble(txtBox_TotDep.Text);
        }

        private void txtBox_IntRate_TextChanged(object sender, TextChangedEventArgs e)
        {
            interestRate = Convert.ToInt32(txtBox_IntRate.Text);
        }

        private void txtBox_numMonths_TextChanged(object sender, TextChangedEventArgs e)
        {
            numOfMonths = Convert.ToInt32(txtBox_numMonths.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow myWindow = new MainWindow();
            myWindow.Show();
        }
    }
}
