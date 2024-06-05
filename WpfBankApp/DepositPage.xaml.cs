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
    /// Interaktionslogik für DepositPage.xaml
    /// </summary>
    public partial class DepositPage : Window
    {
        public DepositPage()
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
                    account.Deposit(deposit);

                    JSONHelper.saveAsJson(AlleListen.Users, "users.json");
                    //AlleListen.aktullenListen();

                    AlleListen.aktullenGridData(DG1);

                    MessageBox.Show("money deposited into account");
                    txtbxIBAN.Text = string.Empty;
                    txtbxBalance.Text = string.Empty;
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
