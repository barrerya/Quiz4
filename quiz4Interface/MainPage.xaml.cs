using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace quiz4Interface
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            
            double deposit = Convert.ToDouble(tbDeposit.Text);
            double interest = Convert.ToDouble(tbInterest.Text);
            double years = Convert.ToDouble(tbYears.Text);

            calcInterest.Service1Client client = new calcInterest.Service1Client();
            double result = client.calculateInterest(deposit, interest, years);
            tBlockOutput.Text = "You will have $" + result;
            client.Close();

        }
        
    }
}
