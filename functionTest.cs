using BankApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BankApp
{
    static class functionTest
    {
        public static void writeToFileInsertTest(string coustomerId, string accountNumber)
        {
            SalaryAccount a = new SalaryAccount();
            TextWriter sw = new StreamWriter($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{coustomerId}\\accounts\\{accountNumber}.txt");
            sw.WriteLine($"{a.accountNumber}");
            sw.WriteLine($"{a.type}");
            sw.WriteLine($"{a.balance}");
            sw.WriteLine($"{a.cardNumber}");
            sw.WriteLine($"{a.cvv}");
            sw.WriteLine($"{a.credit}");
            sw.WriteLine($"{a.maxCredit}");
            sw.WriteLine($"{a.coustomerId}");
            sw.Close();
        }
    }
}
