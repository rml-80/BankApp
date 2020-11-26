using BankApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BankApp.Forms
{
    public partial class insertForm : Form
    {
        public SalaryAccount a = new SalaryAccount();
        public string userName;
        string temp;
        string toAccount;
        int amount = 0;
        public insertForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            updateList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toAccount = cbToAccount.SelectedItem.ToString();
        }
        void updateList()
        {
            var filePath = $"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{userName}\\accounts";
            DirectoryInfo dirPath = new DirectoryInfo(filePath);
            List<string> accountList = new List<string>();
            if (Directory.Exists(filePath))
            {
                if (dirPath.GetFiles().Length != 0)
                {
                    foreach (var item in Directory.GetFiles(filePath))
                    {
                        //get the filename only - .txt
                        temp = item.Substring(item.Length - 15, 11);
                        accountList.Add(temp);
                    }
                    if (dirPath.GetFiles().Length != 0)
                    {
                        foreach (var item in accountList)
                        {
                            cbToAccount.Items.Add(item.ToString());
                        }
                    }
                }
            }
            else
            {
                cbToAccount.Items.Add("You have no account");
            }
        }

        void makeInsert(string accountNumber)
        {
            if (cbToAccount.Text == string.Empty)
            {
                lblNoAccountChoosen.Text = "Choose a account!";
            }
            if (txtAmount.Text == string.Empty)
            {
                lblWrongAmount.Text = "How much do you want to insert?";
            }
            if (txtAmount.Text != string.Empty)
            {
                amount = Convert.ToInt32(txtAmount.Text);
            }
            if (amount < 0)
            {
                lblWrongAmount.Text = "You can`t make a withdraw here!";
            }
            getAccountInfo();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            makeInsert(toAccount);
            a.balance += amount;
            writeToFile();
            this.Close();
        }
        void getAccountInfo()
        {
            a.populateAccountInfo(userName, toAccount);       
        }
        private void writeToFile()
        {
            TextWriter sw = new StreamWriter($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{a.coustomerId}\\accounts\\{a.accountNumber}.txt");
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
        private void saveTransaction()
        {
            TextWriter sw = new StreamWriter($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{a.coustomerId}\\accounts\\trans_{a.accountNumber}.txt");

            sw.WriteLine($"Datum:");
            sw.WriteLine($"TransTyp:");
            sw.WriteLine($"Note:");
            sw.WriteLine($"Amount:");
            sw.WriteLine($"?Amount after?:"); //Maybe

        }
    }
}
