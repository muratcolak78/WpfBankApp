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
    /// Interaktionslogik für DeleteAccountPage.xaml
    /// </summary>

    public partial class DeleteAccountPage : Window
    {

        public DeleteAccountPage()
        {
            InitializeComponent();
            DG1.ItemsSource = AlleListen.User.Accounts;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("The account will be deleted?", "Are you sure?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result.ToString() == "Yes")
            {
                if (AlleListen.Ibans.Contains(txtbxDeleteIban.Text))
                {
                    try
                    {
                        var deletedString = AlleListen.User.Accounts.Find(n => n.IBAN == txtbxDeleteIban.Text);
                        AlleListen.User.Accounts.Remove(deletedString);
                        MessageBox.Show("Account deleted");

                        AlleListen.Ibans.Remove(deletedString.IBAN);

                        JSONHelper.saveAsJson(AlleListen.Users, "users.json");
                        JSONHelper.saveAsJson(AlleListen.Ibans, "ibans.json");
                        txtbxDeleteIban.Text = string.Empty;

                        AlleListen.aktullenGridData(DG1);

                        //DataGridAllAccount.ItemsSource = null;
                        //DataGridAllAccount.ItemsSource = AlleListen.User.Accounts;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Error while delteting account " + ex.Message);
                    }
                }
                else MessageBox.Show("There is no such account, Please check the IBAN numbers  ");


            }

        }
        private void DG1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DG1.SelectedItem is BankAccount account)
            {
                txtbxDeleteIban.Text = account.IBAN;
            }
        }
    }
}
