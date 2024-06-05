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
    /// Interaktionslogik für TransferPage.xaml
    /// </summary>
    public partial class TransferPage : Window
    {
        public TransferPage()
        {
            InitializeComponent();
        }
        private void btnDeposit_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new DepositPage().Content;
        }

        private void btnWithdraw_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new WithDrawPage().Content;
        }

        private void btnTransferToMe_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new TransferToMe().Content;
        }

        private void btnTransferToAnother_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new TransferToAnother().Content;
        }
    }
}
