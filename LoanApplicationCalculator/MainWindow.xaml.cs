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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoanApplicationCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double gross = 0;
        public double incomeTaxDeduct = 0;
        public double groceries = 0;
        public double waterNLights = 0;
        public double cellPhone = 0;
        public double travelCost = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        public static List<double> itemsDisplay = new List<Double>();

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            HomeLoan myHome = new HomeLoan();
            myHome.Show();
        }

        private void btn_Vehicle_Click(object sender, RoutedEventArgs e)
        {
            Vehicle myVeh = new Vehicle();
            myVeh.Show();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            Save mySave = new Save();
            mySave.Show();
        }

        private void txtBox_gross_TextChanged(object sender, TextChangedEventArgs e)
        {
            gross = Convert.ToDouble(txtBox_gross.Text);
            
        }

        private void txtBox_income_TextChanged(object sender, TextChangedEventArgs e)
        {
            incomeTaxDeduct = Convert.ToDouble(txtBox_income.Text);
        }

        private void txtBox_Groc_TextChanged(object sender, TextChangedEventArgs e)
        {
            groceries = Convert.ToDouble(txtBox_Groc.Text);
        }

        private void txtBox_WNL_TextChanged(object sender, TextChangedEventArgs e)
        {
            waterNLights = Convert.ToDouble(txtBox_WNL.Text);
        }

        private void txtBox_Cell_TextChanged(object sender, TextChangedEventArgs e)
        {
            cellPhone = Convert.ToDouble(txtBox_Cell.Text);
        }

        private void txtBox_travel_TextChanged(object sender, TextChangedEventArgs e)
        {
            travelCost = Convert.ToDouble(txtBox_travel.Text);
        }
        
        private void btn_SaveAmounts_Click(object sender, RoutedEventArgs e)
        {
            itemsDisplay.Add(Convert.ToDouble(txtBox_gross.Text));
            itemsDisplay.Add(Convert.ToDouble(txtBox_income.Text));
            itemsDisplay.Add(Convert.ToDouble(txtBox_Groc.Text));
            itemsDisplay.Add(Convert.ToDouble(txtBox_WNL.Text));
            itemsDisplay.Add(Convert.ToDouble(txtBox_Cell.Text));
            itemsDisplay.Add(Convert.ToDouble(txtBox_travel.Text));

            MessageBox.Show("Your values entered were: " + "\n" + "Gross income: " +  
                (itemsDisplay[0].ToString()) +"\n"+ "Income tax deduct: "+ 
                (itemsDisplay[1].ToString()) + "\n" + "Groceries: "+
            (itemsDisplay[2].ToString()) + "\n" + "Water and lights: " +
            (itemsDisplay[3].ToString()) + "\n" + "Cellphone: " + 
            (itemsDisplay[4].ToString()) + "\n" + "Travel cost: " 
            + (itemsDisplay[5].ToString()));
            

        }

       
    }
}
