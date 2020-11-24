namespace BankApp.Forms
{
    partial class withdrawForm
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
            this.lblMakeAWithdraw = new System.Windows.Forms.Label();
            this.lblFromAccount = new System.Windows.Forms.Label();
            this.cbFromAccount = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMakeAWithdraw
            // 
            this.lblMakeAWithdraw.AutoSize = true;
            this.lblMakeAWithdraw.Location = new System.Drawing.Point(22, 20);
            this.lblMakeAWithdraw.Name = "lblMakeAWithdraw";
            this.lblMakeAWithdraw.Size = new System.Drawing.Size(97, 15);
            this.lblMakeAWithdraw.TabIndex = 0;
            this.lblMakeAWithdraw.Text = "Make a withdraw";
            // 
            // lblFromAccount
            // 
            this.lblFromAccount.AutoSize = true;
            this.lblFromAccount.Location = new System.Drawing.Point(22, 67);
            this.lblFromAccount.Name = "lblFromAccount";
            this.lblFromAccount.Size = new System.Drawing.Size(81, 15);
            this.lblFromAccount.TabIndex = 1;
            this.lblFromAccount.Text = "From account";
            // 
            // cbFromAccount
            // 
            this.cbFromAccount.FormattingEnabled = true;
            this.cbFromAccount.Location = new System.Drawing.Point(22, 85);
            this.cbFromAccount.Name = "cbFromAccount";
            this.cbFromAccount.Size = new System.Drawing.Size(121, 23);
            this.cbFromAccount.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(22, 140);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 23);
            this.txtAmount.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(22, 122);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(22, 184);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(121, 23);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Make withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(22, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // withdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cbFromAccount);
            this.Controls.Add(this.lblFromAccount);
            this.Controls.Add(this.lblMakeAWithdraw);
            this.Name = "withdrawForm";
            this.Text = "withdrawForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMakeAWithdraw;
        private System.Windows.Forms.Label lblFromAccount;
        private System.Windows.Forms.ComboBox cbFromAccount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnCancel;
    }
}