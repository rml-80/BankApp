namespace BankApp
{
	partial class loginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblNewCoustomer = new System.Windows.Forms.Label();
            this.lblWrongPasword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(345, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 15);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(518, 18);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(414, 15);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 23);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(587, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(704, 15);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(326, 415);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(149, 23);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply for account";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblNewCoustomer
            // 
            this.lblNewCoustomer.AutoSize = true;
            this.lblNewCoustomer.Location = new System.Drawing.Point(354, 397);
            this.lblNewCoustomer.Name = "lblNewCoustomer";
            this.lblNewCoustomer.Size = new System.Drawing.Size(94, 15);
            this.lblNewCoustomer.TabIndex = 7;
            this.lblNewCoustomer.Text = "Not a customer?";
            // 
            // lblWrongPasword
            // 
            this.lblWrongPasword.AutoSize = true;
            this.lblWrongPasword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWrongPasword.ForeColor = System.Drawing.Color.Red;
            this.lblWrongPasword.Location = new System.Drawing.Point(587, 45);
            this.lblWrongPasword.Name = "lblWrongPasword";
            this.lblWrongPasword.Size = new System.Drawing.Size(0, 15);
            this.lblWrongPasword.TabIndex = 8;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWrongPasword);
            this.Controls.Add(this.lblNewCoustomer);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.DoubleBuffered = true;
            this.Name = "loginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblNewCoustomer;
        private System.Windows.Forms.Label lblWrongPasword;
    }
}

