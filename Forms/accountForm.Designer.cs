
namespace BankApp
{
    partial class accountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbAccountList = new System.Windows.Forms.ListBox();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.lblaccountType = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCvv = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblTxtBalance = new System.Windows.Forms.Label();
            this.lblTxtAccountType = new System.Windows.Forms.Label();
            this.lblTxtAccountNumber = new System.Windows.Forms.Label();
            this.lblTxtCardNumber = new System.Windows.Forms.Label();
            this.lblTxtCvv = new System.Windows.Forms.Label();
            this.lblTxtCredit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Location = new System.Drawing.Point(13, 13);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(153, 15);
            this.lblWelcomeUser.TabIndex = 0;
            this.lblWelcomeUser.Text = "Welcome, {customerName}";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(241, 76);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(51, 15);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance:";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(13, 414);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(140, 25);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(305, 414);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(140, 25);
            this.insert.TabIndex = 3;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(648, 414);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(140, 25);
            this.btnCreateAccount.TabIndex = 7;
            this.btnCreateAccount.Text = "Create new account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(159, 414);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(140, 25);
            this.btnTransfer.TabIndex = 8;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLogOut.Location = new System.Drawing.Point(13, 32);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(50, 15);
            this.lblLogOut.TabIndex = 9;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(241, 167);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 225);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbAccountList
            // 
            this.lbAccountList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAccountList.FormattingEnabled = true;
            this.lbAccountList.ItemHeight = 15;
            this.lbAccountList.Location = new System.Drawing.Point(13, 76);
            this.lbAccountList.Name = "lbAccountList";
            this.lbAccountList.Size = new System.Drawing.Size(206, 92);
            this.lbAccountList.TabIndex = 11;
            this.lbAccountList.SelectedIndexChanged += new System.EventHandler(this.lbAccountList_SelectedIndexChanged);
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(13, 58);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(57, 15);
            this.lblAccounts.TabIndex = 12;
            this.lblAccounts.Text = "Accounts";
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Location = new System.Drawing.Point(241, 149);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(72, 15);
            this.lblTransactions.TabIndex = 13;
            this.lblTransactions.Text = "Transactions";
            // 
            // lblaccountType
            // 
            this.lblaccountType.AutoSize = true;
            this.lblaccountType.Location = new System.Drawing.Point(241, 97);
            this.lblaccountType.Name = "lblaccountType";
            this.lblaccountType.Size = new System.Drawing.Size(82, 15);
            this.lblaccountType.TabIndex = 14;
            this.lblaccountType.Text = "Account Type:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(241, 121);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(102, 15);
            this.lblAccountNumber.TabIndex = 15;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(564, 76);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(82, 15);
            this.lblCardNumber.TabIndex = 17;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // lblCvv
            // 
            this.lblCvv.AutoSize = true;
            this.lblCvv.Location = new System.Drawing.Point(564, 97);
            this.lblCvv.Name = "lblCvv";
            this.lblCvv.Size = new System.Drawing.Size(28, 15);
            this.lblCvv.TabIndex = 18;
            this.lblCvv.Text = "cvv:";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(564, 121);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(42, 15);
            this.lblCredit.TabIndex = 19;
            this.lblCredit.Text = "Credit:";
            // 
            // lblTxtBalance
            // 
            this.lblTxtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTxtBalance.Location = new System.Drawing.Point(346, 76);
            this.lblTxtBalance.Name = "lblTxtBalance";
            this.lblTxtBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTxtBalance.Size = new System.Drawing.Size(120, 15);
            this.lblTxtBalance.TabIndex = 0;
            this.lblTxtBalance.Text = "???";
            this.lblTxtBalance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTxtAccountType
            // 
            this.lblTxtAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTxtAccountType.Location = new System.Drawing.Point(346, 97);
            this.lblTxtAccountType.Name = "lblTxtAccountType";
            this.lblTxtAccountType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTxtAccountType.Size = new System.Drawing.Size(120, 15);
            this.lblTxtAccountType.TabIndex = 20;
            this.lblTxtAccountType.Text = "???";
            this.lblTxtAccountType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTxtAccountNumber
            // 
            this.lblTxtAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTxtAccountNumber.Location = new System.Drawing.Point(346, 121);
            this.lblTxtAccountNumber.Name = "lblTxtAccountNumber";
            this.lblTxtAccountNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTxtAccountNumber.Size = new System.Drawing.Size(120, 15);
            this.lblTxtAccountNumber.TabIndex = 20;
            this.lblTxtAccountNumber.Text = "???";
            this.lblTxtAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTxtCardNumber
            // 
            this.lblTxtCardNumber.Location = new System.Drawing.Point(666, 76);
            this.lblTxtCardNumber.Name = "lblTxtCardNumber";
            this.lblTxtCardNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTxtCardNumber.Size = new System.Drawing.Size(120, 15);
            this.lblTxtCardNumber.TabIndex = 20;
            this.lblTxtCardNumber.Text = "???";
            this.lblTxtCardNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTxtCvv
            // 
            this.lblTxtCvv.Location = new System.Drawing.Point(666, 97);
            this.lblTxtCvv.Name = "lblTxtCvv";
            this.lblTxtCvv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTxtCvv.Size = new System.Drawing.Size(120, 15);
            this.lblTxtCvv.TabIndex = 20;
            this.lblTxtCvv.Text = "???";
            this.lblTxtCvv.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTxtCredit
            // 
            this.lblTxtCredit.Location = new System.Drawing.Point(666, 121);
            this.lblTxtCredit.Name = "lblTxtCredit";
            this.lblTxtCredit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTxtCredit.Size = new System.Drawing.Size(120, 15);
            this.lblTxtCredit.TabIndex = 20;
            this.lblTxtCredit.Text = "???";
            this.lblTxtCredit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // accountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTxtCredit);
            this.Controls.Add(this.lblTxtCvv);
            this.Controls.Add(this.lblTxtCardNumber);
            this.Controls.Add(this.lblTxtAccountNumber);
            this.Controls.Add(this.lblTxtAccountType);
            this.Controls.Add(this.lblTxtBalance);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblCvv);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblaccountType);
            this.Controls.Add(this.lblTransactions);
            this.Controls.Add(this.lblAccounts);
            this.Controls.Add(this.lbAccountList);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblWelcomeUser);
            this.Name = "accountForm";
            this.Text = "accountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox lbAccountList;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.Label lblaccountType;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblTxtBalance;
        private System.Windows.Forms.Label lblTxtAccountType;
        private System.Windows.Forms.Label lblTxtAccountNumber;
        private System.Windows.Forms.Label lblTxtCardNumber;
        private System.Windows.Forms.Label lblTxtCvv;
        private System.Windows.Forms.Label lblTxtCredit;
    }
}