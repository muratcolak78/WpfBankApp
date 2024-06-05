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
    /// Interaktionslogik für AllAcountPage.xaml
    /// </summary>
    public partial class AllAcountPage : Window
    {
        public AllAcountPage()
        {
            InitializeComponent();
            DG1.ItemsSource = AlleListen.User.Accounts;
        }
    }
}
