using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BankApp.Models;

namespace BankApp.Forms
{
    public partial class newCustomerForm : Form
    {

        public newCustomerForm()
        {
            InitializeComponent();
        }
        private void btnNewCustomerApply_Click(object sender, EventArgs e)
        {
            string folderPath = $"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\";
            lblPasswordsDontMatch_TextChanged("");
            if (txtNewCustomerPassword1.Text != txtNewCustomerPassword2.Text)
            {
                lblPasswordsDontMatch_TextChanged("Passwords don`t match!");
            }
            else
            {
                if (Directory.Exists(folderPath + $"{txtNewCustomerEmail.Text}"))
                {
                    customerExists();
                }
                else
                {
                    Directory.CreateDirectory(folderPath + $"{txtNewCustomerEmail.Text}");
                    lblPasswordsDontMatch_TextChanged("");
                    TextWriter sw = new StreamWriter($"D:\\OneDrive\\school\\10. programmering avancerad - objektorienterad\\coding\\BankApp\\Data\\{txtNewCustomerEmail.Text}\\{txtNewCustomerEmail.Text}.txt");
                    sw.WriteLine($"{txtNewCustomerSocialSecurityNumber.Text}");
                    sw.WriteLine($"{txtNewCustomerEmail.Text}");
                    sw.WriteLine($"{txtNewCustomerFirstName.Text}");
                    sw.WriteLine($"{txtNewCustomerLastName.Text}");
                    sw.WriteLine($"{txtNewCustomerAddress.Text}");
                    sw.WriteLine($"{txtNewCustomerZipcode.Text}");
                    sw.WriteLine($"{txtNewCustomerCity.Text}");
                    sw.WriteLine($"{txtNewCustomerPhoneNumber.Text}");
                    sw.WriteLine($"{txtNewCustomerPassword1.Text}");
                    sw.Close();

                    //empty textboxes
                    txtNewCustomerSocialSecurityNumber.Text = "";
                    txtNewCustomerEmail.Text = "";
                    txtNewCustomerFirstName.Text = "";
                    txtNewCustomerLastName.Text = "";
                    txtNewCustomerAddress.Text = "";
                    txtNewCustomerZipcode.Text = "";
                    txtNewCustomerCity.Text = "";
                    txtNewCustomerPhoneNumber.Text = "";
                    txtNewCustomerPassword1.Text = "";
                    txtNewCustomerPassword2.Text = "";

                    this.Hide();
                }
            }
        }
        private void btynCancelNewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void lblPasswordsDontMatch_TextChanged(string pass)
        {
            lblPasswordsDontMatch.Text = pass.ToString();
        }

        private void customerExists()
        {
            lblNewCustomerExists.Text = "Customer already exists";
        }

        private void newCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void txtNewCustomerPassword2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
