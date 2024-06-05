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
    /// Interaktionslogik für WithDrawPage.xaml
    /// </summary>
    public partial class WithDrawPage : Window
    {
        public WithDrawPage()
        {
            InitializeComponent();
            DG1.ItemsSource = AlleListen.User.Accounts;
        }

        private void btnDeposit_Click(object sender, RoutedEventArgs e)
        {
            var account = AlleListen.User.Accounts.Find(n => n.IBAN == txtbxIBAN.Text);


            if (account != null)
            {

                if (double.TryParse(txtbxBalance.Text, out double deposit))
                {
                    if (deposit <= account.Balance)
                    {
                        account.Withdraw(deposit);

                        JSONHelper.saveAsJson(AlleListen.Users, "users.json");

                        AlleListen.aktullenGridData(DG1);

                        MessageBox.Show("money withdrwad from account");
                        txtbxIBAN.Text = string.Empty;
                        txtbxBalance.Text = string.Empty;
                    }
                    else MessageBox.Show("insufficient funds");

                }
                else MessageBox.Show("please enter a valid numbers");
            }
            else MessageBox.Show("there is no such account");
        }
        private void DG1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DG1.SelectedItem is BankAccount account)
            {
                 txtbxIBAN.Text = account.IBAN;
            }
        }
    }
}
