﻿using System;
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
    /// Interaktionslogik für TransferToMe.xaml
    /// </summary>
    public partial class TransferToMe : Window
    {
        public TransferToMe()
        {
            InitializeComponent();
            DataGridAllAccount.ItemsSource = AlleListen.User.Accounts;
        }

        private void btnDeposit_Click(object sender, RoutedEventArgs e)
        {
            var accountWithdraw = AlleListen.User.Accounts.Find(n => n.IBAN == txtbxIBANFrom.Text);
            var accountDeposit = AlleListen.User.Accounts.Find(n => n.IBAN == txtbxIBANTo.Text);

            if (accountWithdraw != null)
            {

                if (accountWithdraw != null)
                {
                    if (double.TryParse(txtbxBalance.Text, out double TransferGeld))
                    {
                        if (TransferGeld <= accountWithdraw.Balance)
                        {
                            accountWithdraw.Withdraw(TransferGeld);
                            accountDeposit.Deposit(TransferGeld);

                            JSONHelper.saveAsJson(AlleListen.Users, "users.json");

                            AlleListen.aktullenGridData(DataGridAllAccount);

                            MessageBox.Show($"money was transferred succesfully from {accountWithdraw.AccountName} to {accountDeposit.AccountName}");
                            txtbxIBANFrom.Text = string.Empty;
                            txtbxIBANTo.Text = string.Empty;
                            txtbxBalance.Text = string.Empty;

                        }
                        else MessageBox.Show("insufficient funds");

                    }
                    else MessageBox.Show("please enter a valid numbers");


                }
                else MessageBox.Show("there is no such account");


            }
            else MessageBox.Show("there is no such account");


        }
    }
}
