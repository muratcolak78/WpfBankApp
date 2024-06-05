using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBankApp
{
    public static class LoginController
    {

        public static bool loginControll(string userName, string passWort)
        {


            List<User> list = JSONHelper.readFromJson<User>("users.json");

            AlleListen.User = AlleListen.Users.Find(n => n.username == userName && n.password == passWort);


            AlleListen.User = AlleListen.Users.Find(n => n.username == userName && n.password == passWort);



            if (AlleListen.User == null) return false;

            return true;
        }
    }
}
