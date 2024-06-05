using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBankApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AlleListen.aktullenListen();

        }

        private void btnRegistrieren_Click(object sender, RoutedEventArgs e)
        {
            new RegistrierenFenster().Show();
            this.Close();
        }

        private void btnAnmelden_Click(object sender, RoutedEventArgs e)
        {



            AlleListen.aktullenListen();


            if (LoginController.loginControll(txtbxBenutzername.Text, txtbxPassword.Password))
            {
                new UserFenster().Show();
                this.Close();
            }
            else MessageBox.Show("Ungültig benutzername oder passwort.\nbitte prüfenSie wieder");
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }
    }
}