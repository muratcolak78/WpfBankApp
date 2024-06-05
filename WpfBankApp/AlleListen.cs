using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfBankApp
{
    public static class AlleListen
    {
        static User user = null;
        static DataGrid dataGrid = null;

        static List<User> users = new List<User>()
        {


        };
        static List<string> ibans = new List<string>();

        public static List<string> Ibans { get => ibans; set => ibans = value; }




        internal static List<User> Users { get => users; set => users = value; }
        internal static User User { get => user; set => user = value; }
        public static DataGrid DataGrid { get => dataGrid; set => dataGrid = value; }

        public static void aktullenListen()
        {

            if (!File.Exists("users.json"))
            {
                Users.Add(new User("murat", "12345a", "murat", "colak", "@mail", "sakarya", IBAN.ibanGenerator()));
                Users.Add(new User("salih", "12345a", "salih", "duran", "@mail", "ankara", IBAN.ibanGenerator()));
                JSONHelper.saveAsJson<User>(Users, "users.json");

            }
            else
            {
                Users = JSONHelper.readFromJson<User>("users.json");

            }

            if (!File.Exists("ibans.json"))
            {
                Ibans.Add("DE123456789");
                Ibans.Add(IBAN.ibanGenerator());
                Ibans.Add(IBAN.ibanGenerator());
                JSONHelper.saveAsJson(Ibans, "ibans.json");
            }
            else Ibans = JSONHelper.readFromJson<string>("ibans.json");

        }
        public static void aktullenGridData(DataGrid dataGrid)
        {
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = AlleListen.User.Accounts;
        }
    }
}
