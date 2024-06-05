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

namespace WpfBankApp
{
    /// <summary>
    /// Interaktionslogik für MyAccountsPage.xaml
    /// </summary>
    public partial class MyAccountsPage : Window
    {
        public MyAccountsPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            contentControl.Content = new AllAcountPage().Content;

        }

        private void btnAddNewAccount_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new AddNewAccountPage().Content;
        }

        private void btnAddNewAccount_Kopieren_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new DeleteAccountPage().Content;
        }
    }
}
