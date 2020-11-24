namespace BankApp.Forms
{
    partial class transferForm
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cbToAccount = new System.Windows.Forms.ComboBox();
            this.lblToAccount = new System.Windows.Forms.Label();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.cbFromAccount = new System.Windows.Forms.ComboBox();
            this.lblFromAccount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(45, 232);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(25, 194);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 23);
            this.txtAmount.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(49, 176);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // cbToAccount
            // 
            this.cbToAccount.FormattingEnabled = true;
            this.cbToAccount.Location = new System.Drawing.Point(25, 132);
            this.cbToAccount.Name = "cbToAccount";
            this.cbToAccount.Size = new System.Drawing.Size(121, 23);
            this.cbToAccount.TabIndex = 2;
            // 
            // lblToAccount
            // 
            this.lblToAccount.AutoSize = true;
            this.lblToAccount.Location = new System.Drawing.Point(46, 114);
            this.lblToAccount.Name = "lblToAccount";
            this.lblToAccount.Size = new System.Drawing.Size(65, 15);
            this.lblToAccount.TabIndex = 1;
            this.lblToAccount.Text = "To account";
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Location = new System.Drawing.Point(45, 9);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(48, 15);
            this.lblTransfer.TabIndex = 0;
            this.lblTransfer.Text = "Transfer";
            // 
            // cbFromAccount
            // 
            this.cbFromAccount.FormattingEnabled = true;
            this.cbFromAccount.Location = new System.Drawing.Point(25, 62);
            this.cbFromAccount.Name = "cbFromAccount";
            this.cbFromAccount.Size = new System.Drawing.Size(121, 23);
            this.cbFromAccount.TabIndex = 2;
            // 
            // lblFromAccount
            // 
            this.lblFromAccount.AutoSize = true;
            this.lblFromAccount.Location = new System.Drawing.Point(49, 44);
            this.lblFromAccount.Name = "lblFromAccount";
            this.lblFromAccount.Size = new System.Drawing.Size(81, 15);
            this.lblFromAccount.TabIndex = 1;
            this.lblFromAccount.Text = "From account";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(45, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // transferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 284);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.lblFromAccount);
            this.Controls.Add(this.lblToAccount);
            this.Controls.Add(this.cbFromAccount);
            this.Controls.Add(this.cbToAccount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnTransfer);
            this.Name = "transferForm";
            this.Text = "transferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cbToAccount;
        private System.Windows.Forms.Label lblToAccount;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.ComboBox cbFromAccount;
        private System.Windows.Forms.Label lblFromAccount;
        private System.Windows.Forms.Button btnCancel;
    }
}