namespace BankApp.Forms
{
    partial class insertForm
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
            this.lblInsert = new System.Windows.Forms.Label();
            this.lblToAccount = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(74, 33);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(36, 15);
            this.lblInsert.TabIndex = 0;
            this.lblInsert.Text = "Insert";
            // 
            // lblToAccount
            // 
            this.lblToAccount.AutoSize = true;
            this.lblToAccount.Location = new System.Drawing.Point(74, 89);
            this.lblToAccount.Name = "lblToAccount";
            this.lblToAccount.Size = new System.Drawing.Size(65, 15);
            this.lblToAccount.TabIndex = 1;
            this.lblToAccount.Text = "To account";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(74, 160);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(37, 178);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 23);
            this.txtAmount.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(62, 233);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(62, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // insertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 319);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblToAccount);
            this.Controls.Add(this.lblInsert);
            this.Name = "insertForm";
            this.Text = "insertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Label lblToAccount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
    }
}