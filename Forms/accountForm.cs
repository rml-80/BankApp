using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using BankApp.Forms;
using BankApp.Models;

namespace BankApp
{
    public partial class accountForm : Form
    {
        user u = new user();
        account a = new account();
        string temp;
        public accountForm(string userName)
        {
            InitializeComponent();
            u.PopulateUser(userName);
            changeName();
            listView2_SelectedIndexChanged(userName);
        }
        private void changeName()
        {
            lblWelcomeUser.Text = $"Welcome, {u.firstName} {u.lastName}";
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            withdrawForm f = new withdrawForm();
            f.Show();
        }
        private void insert_Click(object sender, EventArgs e)
        {
            insertForm f = new insertForm();
            f.Show();
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            transferForm f = new transferForm();
            f.Show(this);
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            newAccountForm f = new newAccountForm(u.email.ToString());
            f.ShowDialog();
            updateInfo();
            refreshList();
        }
        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f = new loginForm();
            f.Show();
        }
        public void listView2_SelectedIndexChanged(string userName)
        {
            updateList(userName);
        }
        private void noAccounts()
        {
            lbAccountList.Items.Add("You have no account");
        }
        public void updateInfo()
        {
            lblTxtBalance.Text = a.balance;
            lblTxtAccountType.Text = a.type;
            lblTxtAccountNumber.Text = a.accountNumber;
            lblTxtCardNumber.Text = a.cardNumber;
            if (a.cardNumber == string.Empty)
            {
                lblTxtCvv.Text = string.Empty;
            } else
            {
                lblTxtCvv.Text = a.cvv;

            }
            lblTxtCredit.Text = a.maxCredit;
        }
        private void lbAccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = this.lbAccountList.SelectedItem.ToString();
            temp = temp.Substring(0, 11);
            var user = u.email;
            a.populateAccountInfo(user, temp);
            temp = a.accountNumber;
            updateInfo();
        }
        public void updateList(string userName)
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
                            lbAccountList.Items.Add(item);
                        }
                    }
                }
            }
            else
            {
                noAccounts();
            }
        }
        public void refreshList()
        {
            lbAccountList.Items.Clear();
            updateList(u.email);
        }
    }
}
