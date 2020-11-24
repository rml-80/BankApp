using System.IO;

namespace BankApp.Models
{
	public class account
	{
		public string accountNumber { get; set; }
        public string type { get; set; }
        public string balance { get; set; } = "0";
        public string cardNumber { get; set; }
        public string cvv { get; set; }
        public string credit { get; set; }
        public string maxCredit { get; set; } = "0";
		public string coustomerId { get; set; }

		string[] details;

        public void populateAccountInfo(string userName,string accountNo)
        {
            var file = $"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{userName}\\accounts\\{accountNo}.txt";

            details = File.ReadAllLines(file);

            accountNumber = details[0];
            type = details[1];
            balance = details[2];
            cardNumber = details[3];
            if (cardNumber.Length > 8)
            {
                cvv = cardNumber.Substring(cardNumber.Length - 3, 3);
                cardNumber = cardNumber.Substring(0, cardNumber.Length - 5);
                
            }
            credit = details[4];
            maxCredit = details[5];
            coustomerId = details[6];
        }

    }

}