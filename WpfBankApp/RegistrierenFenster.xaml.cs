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
    /// Interaktionslogik für RegistrierenFenster.xaml
    /// </summary>
    public partial class RegistrierenFenster : Window
    {
        public RegistrierenFenster()
        {
            InitializeComponent();
        }
        private void btnRegistrieren2_Click(object sender, RoutedEventArgs e)
        {

            bool istGültig = RegisterController.registerControll(txtbxBenutzername.Text, txtbxPassword.Password, txtbxPassword2.Password, txtbxVorname.Text, txtbxSurname.Text, txtbxAdress.Text, txtbxMail.Text);
            if (istGültig)
            {

                AlleListen.Users.Add(new User(txtbxBenutzername.Text, txtbxPassword.Password, txtbxVorname.Text, txtbxSurname.Text, txtbxMail.Text, txtbxAdress.Text, IBAN.ibanGenerator()));
                JSONHelper.saveAsJson(AlleListen.Users, "users.json");
                new MainWindow().Show();
                this.Close();
            }

        }
    }
}
