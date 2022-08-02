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
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Window
    {
        String Modelandmake = "";
        int interestRateVeh = 0;
        int numOfMonths = 0;
        double purchasePriceVeh = 0;
        double totalDepositVeh = 0;
        double Estinsuranceprem = 0;
        double monthlyRepayVeh = 0;
        double totalRepaymentVeh = 0;
        double monthlyRepWithIns = 0;

        public Vehicle()
        {
            InitializeComponent();
        }
        Window myWindow = new Window();



        private void txtBox_vehPurPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            purchasePriceVeh = Convert.ToDouble(txtBox_vehPurPrice.Text);
        }

        private void txtBox_model_TextChanged(object sender, TextChangedEventArgs e)
        {
            Modelandmake = Convert.ToString(txtBox_model.Text);

        }

        private void txtBox_TotDepVeh_TextChanged(object sender, TextChangedEventArgs e)
        {
            totalDepositVeh = Convert.ToDouble(txtBox_TotDepVeh.Text);
        }

        private void txtBox_IntRateVeh_TextChanged(object sender, TextChangedEventArgs e)
        {
            interestRateVeh = Convert.ToInt32(txtBox_IntRateVeh.Text);
        }

        private void txtBox_InsPrem_TextChanged(object sender, TextChangedEventArgs e)
        {
            Estinsuranceprem = Convert.ToDouble(txtBox_InsPrem.Text);
        }

        private void txtBox_numMonths_TextChanged(object sender, TextChangedEventArgs e)
        {
            numOfMonths = Convert.ToInt32(txtBox_numMonths.Text);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //formula to display deposit price 

            Convert.ToDouble(txtBox_vehPurPrice.Text);
            //Formula to calculate total loan repayment or total repayment
            //note: totalRepayment can be A, purchasePrice is P
            totalRepaymentVeh = ((Convert.ToDouble(txtBox_vehPurPrice.Text) ) - (Convert.ToDouble(txtBox_vehPurPrice.Text) - Convert.ToDouble(txtBox_TotDepVeh.Text))) * (1 + (Convert.ToInt32(txtBox_IntRateVeh.Text) * Convert.ToInt32(txtBox_numMonths.Text) / 12));

            //Formula to calculate The totalRepayment / months of 32
            monthlyRepayVeh = (totalRepaymentVeh / Convert.ToInt32(txtBox_numMonths.Text));
            monthlyRepWithIns = (monthlyRepayVeh + (Estinsuranceprem * monthlyRepayVeh));






            MessageBox.Show("\n\n***RECIEPT FOR VEHICLE REPAYMENT***"
                    + "\nPurchase price of vehicle: R" + txtBox_vehPurPrice.Text
                    + "\nTotal deposit Fee: " + "R " + txtBox_TotDepVeh.Text
                    + "\nInterest rate: " + "% " + txtBox_IntRateVeh.Text
                    + "\nNumber of months entered: " + txtBox_numMonths.Text
                    + "\nNumber of months to repay: " + monthlyRepayVeh
                    + "\nTotal vehicle loan repayment amount: R " + totalRepaymentVeh
                    + "\nTotal monthly vehicle loan repayment amount: R " + monthlyRepayVeh
                    + "\nTotal monthly vehicle loan repayment with insurance amount: R " + monthlyRepWithIns);

        }



        private void btn_goBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow myWindow = new MainWindow();
            myWindow.Show();
        }

    }
}
