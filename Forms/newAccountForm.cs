using BankApp.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace BankApp.Forms
{
    public partial class newAccountForm : Form
    {
        readonly SalaryAccount a = new SalaryAccount();
        public newAccountForm(string userName)
        {
            InitializeComponent();
            user u = new user();
            u.PopulateUser(userName);
            a.coustomerId = u.email;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewAccountCreate_Click_1(object sender, EventArgs e)
        {
            if (cbNewAccountType.Text == string.Empty)
            {
                //Show popup "You must choose a type for the account"
                Popup p = new Popup();
                p.Show();
            }
            else
            {
                if ((bool)rbNewAccountCardNo.Checked)
                {
                    a.cardNumber = string.Empty;
                }
                else
                {
                    a.cardNumber = generateCardNumber();
                    a.cvv = generateCvv();
                }
                if ((bool)rbNewAccountCreditNo.Checked)
                {
                    a.credit = false;
                }
                else
                {
                    a.credit = true;
                    a.maxCredit = 1500;
                }

                a.accountNumber = generateAccountNumber();
                a.type = cbNewAccountType.Text;
                if (Directory.Exists($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{a.coustomerId}\\accounts"))
                {
                    writeToFile();
                }
                else
                {
                    Directory.CreateDirectory($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{a.coustomerId}\\accounts");
                    writeToFile();
                }
                this.Close();
            }
        }

        private void writeToFile()
        {
            TextWriter sw = new StreamWriter($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{a.coustomerId}\\accounts\\{a.accountNumber}.txt");
            sw.WriteLine($"{a.accountNumber}");
            sw.WriteLine($"{cbNewAccountType.Text}");
            sw.WriteLine($"{a.balance}");
            sw.WriteLine($"{a.cardNumber}");
            sw.WriteLine($"{a.cvv}");
            sw.WriteLine($"{a.credit}");
            sw.WriteLine($"{a.maxCredit}");
            sw.WriteLine($"{a.coustomerId}");
            sw.Close();
        }
        private string generateAccountNumber()
        {
            var clearingNumber = "2565-";

            Random r = new Random();
            var a = r.Next(100000, 999999);

            var accountNumber = clearingNumber + a.ToString();
            return accountNumber;
        }

        private string generateCardNumber()
        {
            var cardNumber = string.Empty;

            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {

                var a = r.Next(0, 9);
                var b = r.Next(0, 9);
                var c = r.Next(0, 9);
                var d = r.Next(0, 9);

                string tempCardNumber = a.ToString() + b.ToString() + c.ToString() + d.ToString() + " ";
                cardNumber += tempCardNumber;
            }

            return cardNumber;
        }
        private string generateCvv()
        {
            Random r = new Random();
            var cvv = r.Next(100, 999).ToString();
            return cvv;
        }

    }
}
