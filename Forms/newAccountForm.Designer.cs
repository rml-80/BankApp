namespace BankApp.Forms
{
    partial class newAccountForm
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
            this.lblNewAccount = new System.Windows.Forms.Label();
            this.lblNewAccountType = new System.Windows.Forms.Label();
            this.lblNewAccountCard = new System.Windows.Forms.Label();
            this.cbNewAccountType = new System.Windows.Forms.ComboBox();
            this.rbNewAccountCardNo = new System.Windows.Forms.RadioButton();
            this.rbNewAccountCardYes = new System.Windows.Forms.RadioButton();
            this.lblNewAccountCredit = new System.Windows.Forms.Label();
            this.rbNewAccountCreditNo = new System.Windows.Forms.RadioButton();
            this.rbNewAccountCreditYes = new System.Windows.Forms.RadioButton();
            this.btnNewAccountCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panCard = new System.Windows.Forms.Panel();
            this.panCredit = new System.Windows.Forms.Panel();
            this.panCard.SuspendLayout();
            this.panCredit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewAccount
            // 
            this.lblNewAccount.AutoSize = true;
            this.lblNewAccount.Location = new System.Drawing.Point(12, 9);
            this.lblNewAccount.Name = "lblNewAccount";
            this.lblNewAccount.Size = new System.Drawing.Size(112, 15);
            this.lblNewAccount.TabIndex = 0;
            this.lblNewAccount.Text = "Create new account";
            // 
            // lblNewAccountType
            // 
            this.lblNewAccountType.AutoSize = true;
            this.lblNewAccountType.Location = new System.Drawing.Point(13, 49);
            this.lblNewAccountType.Name = "lblNewAccountType";
            this.lblNewAccountType.Size = new System.Drawing.Size(94, 15);
            this.lblNewAccountType.TabIndex = 1;
            this.lblNewAccountType.Text = "Type of account:";
            // 
            // lblNewAccountCard
            // 
            this.lblNewAccountCard.AutoSize = true;
            this.lblNewAccountCard.Location = new System.Drawing.Point(0, 0);
            this.lblNewAccountCard.Name = "lblNewAccountCard";
            this.lblNewAccountCard.Size = new System.Drawing.Size(73, 15);
            this.lblNewAccountCard.TabIndex = 1;
            this.lblNewAccountCard.Text = "Want a card:";
            // 
            // cbNewAccountType
            // 
            this.cbNewAccountType.FormattingEnabled = true;
            this.cbNewAccountType.Items.AddRange(new object[] {
            "Salary",
            "Savings",
            "Payments"});
            this.cbNewAccountType.Location = new System.Drawing.Point(113, 46);
            this.cbNewAccountType.Name = "cbNewAccountType";
            this.cbNewAccountType.Size = new System.Drawing.Size(121, 23);
            this.cbNewAccountType.TabIndex = 3;
            // 
            // rbNewAccountCardNo
            // 
            this.rbNewAccountCardNo.AutoSize = true;
            this.rbNewAccountCardNo.Checked = true;
            this.rbNewAccountCardNo.Location = new System.Drawing.Point(79, -2);
            this.rbNewAccountCardNo.Name = "rbNewAccountCardNo";
            this.rbNewAccountCardNo.Size = new System.Drawing.Size(41, 19);
            this.rbNewAccountCardNo.TabIndex = 4;
            this.rbNewAccountCardNo.TabStop = true;
            this.rbNewAccountCardNo.Text = "No";
            this.rbNewAccountCardNo.UseVisualStyleBackColor = true;
            // 
            // rbNewAccountCardYes
            // 
            this.rbNewAccountCardYes.AutoSize = true;
            this.rbNewAccountCardYes.Location = new System.Drawing.Point(126, -2);
            this.rbNewAccountCardYes.Name = "rbNewAccountCardYes";
            this.rbNewAccountCardYes.Size = new System.Drawing.Size(42, 19);
            this.rbNewAccountCardYes.TabIndex = 4;
            this.rbNewAccountCardYes.TabStop = true;
            this.rbNewAccountCardYes.Text = "Yes";
            this.rbNewAccountCardYes.UseVisualStyleBackColor = true;
            // 
            // lblNewAccountCredit
            // 
            this.lblNewAccountCredit.AutoSize = true;
            this.lblNewAccountCredit.Location = new System.Drawing.Point(0, 0);
            this.lblNewAccountCredit.Name = "lblNewAccountCredit";
            this.lblNewAccountCredit.Size = new System.Drawing.Size(71, 15);
            this.lblNewAccountCredit.TabIndex = 1;
            this.lblNewAccountCredit.Text = "Want credit:";
            // 
            // rbNewAccountCreditNo
            // 
            this.rbNewAccountCreditNo.AutoSize = true;
            this.rbNewAccountCreditNo.Checked = true;
            this.rbNewAccountCreditNo.Location = new System.Drawing.Point(79, -2);
            this.rbNewAccountCreditNo.Name = "rbNewAccountCreditNo";
            this.rbNewAccountCreditNo.Size = new System.Drawing.Size(41, 19);
            this.rbNewAccountCreditNo.TabIndex = 4;
            this.rbNewAccountCreditNo.TabStop = true;
            this.rbNewAccountCreditNo.Text = "No";
            this.rbNewAccountCreditNo.UseVisualStyleBackColor = true;
            // 
            // rbNewAccountCreditYes
            // 
            this.rbNewAccountCreditYes.AutoSize = true;
            this.rbNewAccountCreditYes.Location = new System.Drawing.Point(126, -2);
            this.rbNewAccountCreditYes.Name = "rbNewAccountCreditYes";
            this.rbNewAccountCreditYes.Size = new System.Drawing.Size(42, 19);
            this.rbNewAccountCreditYes.TabIndex = 4;
            this.rbNewAccountCreditYes.TabStop = true;
            this.rbNewAccountCreditYes.Text = "Yes";
            this.rbNewAccountCreditYes.UseVisualStyleBackColor = true;
            // 
            // btnNewAccountCreate
            // 
            this.btnNewAccountCreate.Location = new System.Drawing.Point(70, 151);
            this.btnNewAccountCreate.Name = "btnNewAccountCreate";
            this.btnNewAccountCreate.Size = new System.Drawing.Size(75, 23);
            this.btnNewAccountCreate.TabIndex = 5;
            this.btnNewAccountCreate.Text = "Create";
            this.btnNewAccountCreate.UseVisualStyleBackColor = true;
            this.btnNewAccountCreate.Click += new System.EventHandler(this.btnNewAccountCreate_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(159, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panCard
            // 
            this.panCard.Controls.Add(this.rbNewAccountCardYes);
            this.panCard.Controls.Add(this.lblNewAccountCard);
            this.panCard.Controls.Add(this.rbNewAccountCardNo);
            this.panCard.Location = new System.Drawing.Point(34, 85);
            this.panCard.Name = "panCard";
            this.panCard.Size = new System.Drawing.Size(200, 19);
            this.panCard.TabIndex = 10;
            // 
            // panCredit
            // 
            this.panCredit.Controls.Add(this.lblNewAccountCredit);
            this.panCredit.Controls.Add(this.rbNewAccountCreditNo);
            this.panCredit.Controls.Add(this.rbNewAccountCreditYes);
            this.panCredit.Location = new System.Drawing.Point(34, 107);
            this.panCredit.Name = "panCredit";
            this.panCredit.Size = new System.Drawing.Size(200, 19);
            this.panCredit.TabIndex = 11;
            // 
            // newAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 186);
            this.Controls.Add(this.panCredit);
            this.Controls.Add(this.panCard);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewAccountCreate);
            this.Controls.Add(this.cbNewAccountType);
            this.Controls.Add(this.lblNewAccountType);
            this.Controls.Add(this.lblNewAccount);
            this.Name = "newAccountForm";
            this.Text = "newAccountForm";
            this.Enter += new System.EventHandler(this.btnNewAccountCreate_Click_1);
            this.panCard.ResumeLayout(false);
            this.panCard.PerformLayout();
            this.panCredit.ResumeLayout(false);
            this.panCredit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewAccount;
        private System.Windows.Forms.Label lblNewAccountType;
        private System.Windows.Forms.Label lblNewAccountCard;
        private System.Windows.Forms.ComboBox cbNewAccountType;
        private System.Windows.Forms.RadioButton rbNewAccountCardNo;
        private System.Windows.Forms.RadioButton rbNewAccountCardYes;
        private System.Windows.Forms.Label lblNewAccountCredit;
        private System.Windows.Forms.RadioButton rbNewAccountCreditNo;
        private System.Windows.Forms.RadioButton rbNewAccountCreditYes;
        private System.Windows.Forms.Button btnNewAccountCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panCard;
        private System.Windows.Forms.Panel panCredit;
    }
}