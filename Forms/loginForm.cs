using System;
using System.IO;
using System.Windows.Forms;
using BankApp.Forms;

namespace BankApp
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string folderPath = $"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\";
            user u = new user();


            if (Directory.Exists(folderPath + txtUserName.Text))
            {
                u.PopulateUser(txtUserName.Text);
                var pass = u.password;
                if (txtPassword.Text != pass)
                {
                    wrongPassword();
                }
                else
                {
                    this.Hide();
                    accountForm f = new accountForm(txtUserName.Text);
                    f.Show();
                }
            }
            else
            {
                wrongPassword();
            }
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            //this.Hide();
            newCustomerForm f = new newCustomerForm();
            f.Show();
        }

        public void wrongPassword()
        {
            lblWrongPasword.Text = "Username or Password incorrect!";
        }
    }
}
