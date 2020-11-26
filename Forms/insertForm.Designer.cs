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
            this.cbToAccount = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWrongAmount = new System.Windows.Forms.Label();
            this.lblNoAccountChoosen = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(12, 9);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(36, 15);
            this.lblInsert.TabIndex = 0;
            this.lblInsert.Text = "Insert";
            // 
            // lblToAccount
            // 
            this.lblToAccount.AutoSize = true;
            this.lblToAccount.Location = new System.Drawing.Point(45, 86);
            this.lblToAccount.Name = "lblToAccount";
            this.lblToAccount.Size = new System.Drawing.Size(65, 15);
            this.lblToAccount.TabIndex = 1;
            this.lblToAccount.Text = "To account";
            // 
            // cbToAccount
            // 
            this.cbToAccount.FormattingEnabled = true;
            this.cbToAccount.Location = new System.Drawing.Point(45, 104);
            this.cbToAccount.Name = "cbToAccount";
            this.cbToAccount.Size = new System.Drawing.Size(121, 23);
            this.cbToAccount.TabIndex = 2;
            this.cbToAccount.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(45, 148);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(45, 166);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 23);
            this.txtAmount.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(30, 218);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(111, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblWrongAmount
            // 
            this.lblWrongAmount.AutoSize = true;
            this.lblWrongAmount.Location = new System.Drawing.Point(45, 196);
            this.lblWrongAmount.Name = "lblWrongAmount";
            this.lblWrongAmount.Size = new System.Drawing.Size(38, 15);
            this.lblWrongAmount.TabIndex = 7;
            this.lblWrongAmount.Text = "label1";
            // 
            // lblNoAccountChoosen
            // 
            this.lblNoAccountChoosen.AutoSize = true;
            this.lblNoAccountChoosen.Location = new System.Drawing.Point(45, 130);
            this.lblNoAccountChoosen.Name = "lblNoAccountChoosen";
            this.lblNoAccountChoosen.Size = new System.Drawing.Size(38, 15);
            this.lblNoAccountChoosen.TabIndex = 8;
            this.lblNoAccountChoosen.Text = "label1";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(45, 28);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 15);
            this.lblNote.TabIndex = 9;
            this.lblNote.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(45, 46);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(121, 23);
            this.txtNote.TabIndex = 10;
            // 
            // insertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 270);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblNoAccountChoosen);
            this.Controls.Add(this.lblWrongAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cbToAccount);
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
        private System.Windows.Forms.ComboBox cbToAccount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWrongAmount;
        private System.Windows.Forms.Label lblNoAccountChoosen;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
    }
}