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
using System.Xml.Linq;

namespace WpfBankApp
{
    /// <summary>
    /// Interaktionslogik für AddNewAccountPage.xaml
    /// </summary>
    public partial class AddNewAccountPage : Window
    {
        public AddNewAccountPage()
        {
            InitializeComponent();
            
            DG1.ItemsSource = AlleListen.User.Accounts;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (txtbxAccountName.Text.Length > 0)
            {
                if (double.TryParse(txtbxBalance.Text, out double balance))
                {
                    if (balance >= 0)
                    {
                        AlleListen.User.Accounts.Add(new BankAccount(IBAN.ibanGenerator(), txtbxAccountName.Text, Convert.ToDouble(txtbxBalance.Text)));
                        JSONHelper.saveAsJson(AlleListen.Users, "users.json");
                        txtbxBalance.Text = string.Empty;
                        txtbxAccountName.Text = string.Empty;
                        MessageBox.Show(txtbxAccountName.Text + " account is created");
                    }
                    else
                    {
                        MessageBox.Show(txtbxBalance.Text + " account cannot be less than 0 ");
                        txtbxBalance.Text = string.Empty;
                        txtbxAccountName.Text = string.Empty;
                    }

                }
                else
                {
                    MessageBox.Show(txtbxBalance.Text + " The account must consist of numbers ");
                    txtbxBalance.Text = string.Empty;
                    txtbxAccountName.Text = string.Empty;
                }


            }
            else MessageBox.Show("account name cannot be empty !");

        }
       
    }
}
