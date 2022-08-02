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
    /// Interaction logic for Save.xaml
    /// </summary>
    public partial class Save : Window
    {
        public String reason = "";
        public double amountToSave = 0;
        public int intRate = 0;
        public int yearSave = 0;
        
        public double totalAmountSaved = 0;


        public Save()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow myWindow = new MainWindow();
            myWindow.Show();
        }

        private void txtBox_Reason_TextChanged(object sender, TextChangedEventArgs e)
        {
            reason = Convert.ToString(txtBox_Reason.Text);
        }

        private void txtBox_saveAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            amountToSave = Convert.ToDouble(txtBox_saveAmount);
        }

        private void txtBox_interestRate_TextChanged(object sender, TextChangedEventArgs e)
        {
            intRate = Convert.ToInt32(txtBox_interestRate.Text);
        }

        private void txtBox_Year_TextChanged(object sender, TextChangedEventArgs e)
        {
            yearSave = Convert.ToInt32(txtBox_TimePeriod);
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
          double finalCalc = (Convert.ToDouble(txtBox_saveAmount.Text)) * 
                (1 +(( Convert.ToInt32(txtBox_interestRate.Text) / 100) 
                * (Convert.ToInt32(txtBox_TimePeriod.Text) / 12)));


           

            totalAmountSaved = (Convert.ToDouble(txtBox_saveAmount.Text) + finalCalc);

            MessageBox.Show("*****************************"+ "\n" +
                            "\n"+ "SAVINGS GOAL"
                            +"\n"+"*****************************" +
                           "\n"+ "Your reason for choosing to save: " + txtBox_Reason.Text +
                           "\n"+ "The amount you wish to save: " + txtBox_saveAmount.Text +
                           "\n"+ "The time period you wish to save: " + txtBox_TimePeriod.Text +
                           "\n" + "Your total savings are: " + totalAmountSaved);

        
        }
    }
}
