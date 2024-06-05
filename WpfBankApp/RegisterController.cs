using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBankApp
{
    public static class RegisterController
    {
        private static bool usernameControll(string username)
        {
            if (username.Length >= 5) return true;
            return false;
        }
        private static bool passwordControll(string password)
        {

            char[] chars = password.ToCharArray();
            int digit = 0;
            int letter = 0;

            foreach (char c in chars)
            {
                if (Char.IsDigit(c)) digit++;
                if (Char.IsLetter(c)) letter++;
            }

            if (password.Length >= 6 && digit > 0 && letter > 0) return true;
            else return false;
        }
        private static bool istPasswortGleich(string password1, string password2)
        {
            if (password1 == password2) return true;
            else return false;
        }
        private static bool nameSurnameAdressConrtoll(string name, string surname, string adress)
        {
            if (name.Length > 1 && surname.Length > 1 && adress.Length > 1) return true;
            return false;
        }
        private static bool mailControl(string mail)
        {
            if (mail.Contains("@")) return true;
            return false;
        }

        public static bool registerControll(string username, string password1, string password2, string name, string surname, string adress, string mail)
        {
            if (usernameControll(username))
            {
                if (passwordControll(password1))
                {
                    if (istPasswortGleich(password1, password2))
                    {
                        if (nameSurnameAdressConrtoll(name, surname, adress))
                        {
                            if (mailControl(mail))
                            {
                                MessageBox.Show("Benutzer erfolgreich registriert");
                                return true;

                            }
                            MessageBox.Show("ungültig mail");

                        }
                        else MessageBox.Show("Vor- oder Nachname oder Adresse dürfen nicht leer sein");

                    }
                    else MessageBox.Show("passworten sind nicht gleich");

                }
                else MessageBox.Show("passwort muss mindesten 6 zeichen, 1 nummer und 1 buchstabe");

            }
            else MessageBox.Show("username muss mindesten 5 zeichen ");



            return false;
        }

    }
}
