using System;
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
        }
    }
}