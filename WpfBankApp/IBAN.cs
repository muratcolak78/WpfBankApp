using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBankApp
{
    internal static class IBAN
    {
        public static string ibanGenerator()
        {
            string iban = "DE";
            bool exit = false;
            Random random = new Random();
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    iban += random.Next(0, 10).ToString();
                }
                if (AlleListen.Ibans.Count == 0)
                {

                    exit = true;
                }
                else
                {
                    if (!AlleListen.Ibans.Contains(iban)) exit = true;
                    else exit = false;
                }

            } while (!exit);
            AlleListen.Ibans.Add(iban);
            JSONHelper.saveAsJson<string>(AlleListen.Ibans, "ibans.json");
            return iban;
        }
    }
}
