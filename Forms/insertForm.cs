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
        public Transaction t = new Transaction();
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
            //functionTest.writeToFileInsertTest(a.coustomerId, a.accountNumber);
            writeToFileInsert();
            writeInsertTransaction();
            this.Close();
        }
        void getAccountInfo()
        {
            a.populateAccountInfo(userName, toAccount);       
        }
        private void writeToFileInsert()
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
        private void writeInsertTransaction()
        {
            t.date = DateTime.UtcNow;
            t.type = "Insert";
            t.fromAccount = "Insert"; //TODO: Make a field for this
            t.toAccount = string.Empty;
            t.amount = amount;
            t.accountNumber = a.accountNumber;
            saveInsertTransaction();
            var tr = new Transaction {
                date = t.date,
                accountNumber = t.accountNumber,
                amount = t.amount,
                fromAccount = t.fromAccount,
                //id = t.id,
                note = t.note,
                toAccount = t.toAccount,
                type = t.type
            };
            a.transactions.Add(tr);
        }

        private void saveInsertTransaction()
        {
            if (Directory.Exists($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{a.coustomerId}\\accounts\\transactions"))
            {
                TextWriter sw = File.AppendText($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{a.coustomerId}\\accounts\\transactions\\{a.accountNumber}.txt");

                sw.Write($"{t.accountNumber};");
                sw.Write($"{t.date};");
                sw.Write($"{t.type};");
                sw.Write($"{t.fromAccount};");
                sw.Write($"{t.toAccount};");
                sw.Write($"{t.note};");
                sw.Write($"{t.amount}\n");
                //sw.WriteLine($"?Amount after?:"); //Maybe
                sw.Close();
            } else {
                Directory.CreateDirectory($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{a.coustomerId}\\accounts\\transactions");

                TextWriter sw = File.AppendText($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{a.coustomerId}\\accounts\\transactions\\{a.accountNumber}.txt");

                sw.Write($"{t.accountNumber};");
                sw.Write($"{t.date};");
                sw.Write($"{t.type};");
                sw.Write($"{t.fromAccount};");
                sw.Write($"{t.toAccount};");
                sw.Write($"{t.note};");
                sw.Write($"{t.amount}\n");
                //sw.WriteLine($"?Amount after?:"); //Maybe
                sw.Close();
            }
        }
    }
}
