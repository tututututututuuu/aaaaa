namespace MedicalSystem
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txb_UserID = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbloffice = new System.Windows.Forms.Label();
            this.txboffice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(57, 75);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "用户名:";
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.Location = new System.Drawing.Point(60, 138);
            this.lblUserPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(45, 15);
            this.lblUserPass.TabIndex = 1;
            this.lblUserPass.Text = "密码:";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(163, 71);
            this.txb_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(132, 25);
            this.txb_UserName.TabIndex = 2;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(163, 134);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(132, 25);
            this.txb_Password.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(60, 36);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 15);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "用户ID:";
            // 
            // txb_UserID
            // 
            this.txb_UserID.Location = new System.Drawing.Point(163, 30);
            this.txb_UserID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_UserID.Name = "txb_UserID";
            this.txb_UserID.Size = new System.Drawing.Size(132, 25);
            this.txb_UserID.TabIndex = 5;
            this.txb_UserID.TextChanged += new System.EventHandler(this.txb_UserID_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(148, 194);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 29);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbloffice
            // 
            this.lbloffice.AutoSize = true;
            this.lbloffice.Location = new System.Drawing.Point(62, 107);
            this.lbloffice.Name = "lbloffice";
            this.lbloffice.Size = new System.Drawing.Size(52, 15);
            this.lbloffice.TabIndex = 7;
            this.lbloffice.Text = "科室：";
            // 
            // txboffice
            // 
            this.txboffice.Location = new System.Drawing.Point(163, 104);
            this.txboffice.Name = "txboffice";
            this.txboffice.Size = new System.Drawing.Size(132, 25);
            this.txboffice.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 268);
            this.Controls.Add(this.txboffice);
            this.Controls.Add(this.lbloffice);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txb_UserID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.lblUserPass);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txb_UserID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbloffice;
        private System.Windows.Forms.TextBox txboffice;
    }
}

