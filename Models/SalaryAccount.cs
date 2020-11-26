using System;
using System.Collections.Generic;
using System.IO;

namespace BankApp.Models
{
	public class SalaryAccount : account
	{
        public string cardNumber { get; set; }
        public string cvv { get; set; }
        public bool credit { get; set; }
        public int maxCredit { get; set; }

        public void populateAccountInfo(string userName,string accountNo)
        {
            var file = $"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{userName}\\accounts\\{accountNo}.txt";

            string[] details = File.ReadAllLines(file);

            accountNumber = details[0];
            type = details[1];
            balance = Convert.ToInt32(details[2]);
            cardNumber = details[3];
            cvv = details[4];           
            credit = Convert.ToBoolean(details[5]);
            maxCredit = Convert.ToInt32(details[6]);
            coustomerId = details[7];
            populateTransactionList();
        }
        public void populateTransactionList()
        {
            var folderPath = $"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{coustomerId}\\accounts\\transactions";
            if (Directory.Exists(folderPath))
            {
                transactions.Clear();
                List<string> trans = new List<string>();
                StreamReader sw = new StreamReader(folderPath + $"\\{accountNumber}.txt");
                string line;
                while ((line = sw.ReadLine()) != null)
                {
                    trans.Clear();
                    foreach (var item in line.Split(";"))
                    {
                        trans.Add(item);
                    }
                    Transaction t = new Transaction();
                    t.accountNumber = trans[0];
                    t.date = Convert.ToDateTime(trans[1]);
                    t.type = trans[2];
                    t.fromAccount = trans[3];
                    t.toAccount = trans[4];
                    t.note = trans[5];
                    t.amount = Convert.ToInt32(trans[6]);

                    transactions.Add(t);
                }
                sw.Close();
            }
        }
    }
}