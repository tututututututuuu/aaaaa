namespace MedicalSystem
{
    partial class frm_Login
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
            this.lbl_Hint = new System.Windows.Forms.Label();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserNo = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_UserNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Hint
            // 
            this.lbl_Hint.AutoSize = true;
            this.lbl_Hint.Location = new System.Drawing.Point(369, 239);
            this.lbl_Hint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Hint.Name = "lbl_Hint";
            this.lbl_Hint.Size = new System.Drawing.Size(142, 15);
            this.lbl_Hint.TabIndex = 12;
            this.lbl_Hint.Text = "请输入用户号、密码";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(369, 271);
            this.btn_LogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(100, 29);
            this.btn_LogIn.TabIndex = 11;
            this.btn_LogIn.Text = "登录";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(302, 199);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(52, 15);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "密码：";
            // 
            // lbl_UserNo
            // 
            this.lbl_UserNo.AutoSize = true;
            this.lbl_UserNo.Location = new System.Drawing.Point(290, 155);
            this.lbl_UserNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserNo.Name = "lbl_UserNo";
            this.lbl_UserNo.Size = new System.Drawing.Size(67, 15);
            this.lbl_UserNo.TabIndex = 9;
            this.lbl_UserNo.Text = "用户号：";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(369, 195);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(132, 25);
            this.txb_Password.TabIndex = 8;
            // 
            // txb_UserNo
            // 
            this.txb_UserNo.Location = new System.Drawing.Point(369, 151);
            this.txb_UserNo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_UserNo.Name = "txb_UserNo";
            this.txb_UserNo.Size = new System.Drawing.Size(132, 25);
            this.txb_UserNo.TabIndex = 7;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Hint);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserNo);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_UserNo);
            this.Name = "frm_Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Hint;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserNo;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_UserNo;
    }
}