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
        private user u = new user();
        private SalaryAccount a = new SalaryAccount();
        string temp;
        ListView LV1 = new ListView();
        bool isPop = false;
        public accountForm(string userName)
        {
            InitializeComponent();
            u.PopulateUser(userName);
            changeName();
            listView2_SelectedIndexChanged(userName);
            lbAccountList.SelectedIndex = 0;
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
            insertForm f = new insertForm(u.email.ToString());
            f.ShowDialog();
            updateInfo();
            refreshList();
            lbAccountList.SelectedIndex = 0;
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
            foreach (var item in a.transactions)
            {
                Console.WriteLine(item);
            }
        }
        private void noAccounts()
        {
            lbAccountList.Items.Add("You have no account");
        }
        public void updateInfo()
        {
            lblTxtBalance.Text = a.balance.ToString();
            lblTxtAccountType.Text = a.type;
            lblTxtAccountNumber.Text = a.accountNumber;
            lblTxtCardNumber.Text = a.cardNumber;
            if (a.cardNumber == string.Empty)
            {
                lblTxtCvv.Text = string.Empty;
            }
            else
            {
                lblTxtCvv.Text = a.cvv;

            }
            lblTxtCredit.Text = a.maxCredit.ToString();
            populateTransactions();

        }
        private void lbAccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = this.lbAccountList.SelectedItem.ToString();
            temp = temp.Substring(0, 11);
            var user = u.email;
            a.populateAccountInfo(user, temp);
            temp = a.accountNumber;
            LV1.Items.Clear();
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
        public void populateTransactions()
        {
            

            if (isPop == false)
            {


            LV1.Bounds = new System.Drawing.Rectangle(new System.Drawing.Point(241, 174), new System.Drawing.Size(550, 230));

            LV1.View = View.Details;

            LV1.Columns.Add("Date", -2, HorizontalAlignment.Left);
            LV1.Columns.Add("Type", 80, HorizontalAlignment.Left);
            LV1.Columns.Add("Note", 2120, HorizontalAlignment.Left);
            LV1.Columns.Add("Amount", -2, HorizontalAlignment.Left);

                isPop = true;
            }


            foreach (var item in a.transactions)
            {
                ListViewItem item1 = new ListViewItem(item.date.ToString());
                item1.SubItems.Add(item.type.ToString());
                item1.SubItems.Add(item.note.ToString());
                item1.SubItems.Add(item.amount.ToString());
                LV1.Items.Add(item1);
            }

            this.Controls.Add(LV1);
        }
    }
}
