namespace MedicalSystem
{
    partial class frm_Connection
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
            this.gpb_ConnectionParameter = new System.Windows.Forms.GroupBox();
            this.ckb_IsWindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.txb_Database = new System.Windows.Forms.TextBox();
            this.txb_Server = new System.Windows.Forms.TextBox();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.gpb_ConnectionParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_ConnectionParameter
            // 
            this.gpb_ConnectionParameter.Controls.Add(this.ckb_IsWindowsAuthentication);
            this.gpb_ConnectionParameter.Controls.Add(this.txb_Database);
            this.gpb_ConnectionParameter.Controls.Add(this.txb_Server);
            this.gpb_ConnectionParameter.Controls.Add(this.lbl_Database);
            this.gpb_ConnectionParameter.Controls.Add(this.lbl_Server);
            this.gpb_ConnectionParameter.Location = new System.Drawing.Point(244, 152);
            this.gpb_ConnectionParameter.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_ConnectionParameter.Name = "gpb_ConnectionParameter";
            this.gpb_ConnectionParameter.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_ConnectionParameter.Size = new System.Drawing.Size(313, 110);
            this.gpb_ConnectionParameter.TabIndex = 4;
            this.gpb_ConnectionParameter.TabStop = false;
            this.gpb_ConnectionParameter.Text = "连接参数";
            this.gpb_ConnectionParameter.Enter += new System.EventHandler(this.gpb_ConnectionParameter_Enter);
            // 
            // ckb_IsWindowsAuthentication
            // 
            this.ckb_IsWindowsAuthentication.AutoSize = true;
            this.ckb_IsWindowsAuthentication.Location = new System.Drawing.Point(87, 82);
            this.ckb_IsWindowsAuthentication.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_IsWindowsAuthentication.Name = "ckb_IsWindowsAuthentication";
            this.ckb_IsWindowsAuthentication.Size = new System.Drawing.Size(115, 19);
            this.ckb_IsWindowsAuthentication.TabIndex = 5;
            this.ckb_IsWindowsAuthentication.Text = "Windows验证";
            this.ckb_IsWindowsAuthentication.UseVisualStyleBackColor = true;
            // 
            // txb_Database
            // 
            this.txb_Database.Location = new System.Drawing.Point(87, 50);
            this.txb_Database.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Database.Name = "txb_Database";
            this.txb_Database.Size = new System.Drawing.Size(132, 25);
            this.txb_Database.TabIndex = 4;
            // 
            // txb_Server
            // 
            this.txb_Server.Location = new System.Drawing.Point(87, 20);
            this.txb_Server.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Server.Name = "txb_Server";
            this.txb_Server.Size = new System.Drawing.Size(132, 25);
            this.txb_Server.TabIndex = 3;
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(8, 54);
            this.lbl_Database.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(67, 15);
            this.lbl_Database.TabIndex = 1;
            this.lbl_Database.Text = "数据库：";
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.Location = new System.Drawing.Point(8, 24);
            this.lbl_Server.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(67, 15);
            this.lbl_Server.TabIndex = 0;
            this.lbl_Server.Text = "服务器：";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(457, 269);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(100, 29);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // frm_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpb_ConnectionParameter);
            this.Controls.Add(this.btn_Connect);
            this.Name = "frm_Connection";
            this.Text = "数据库连接";
            this.gpb_ConnectionParameter.ResumeLayout(false);
            this.gpb_ConnectionParameter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_ConnectionParameter;
        private System.Windows.Forms.CheckBox ckb_IsWindowsAuthentication;
        private System.Windows.Forms.TextBox txb_Database;
        private System.Windows.Forms.TextBox txb_Server;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Button btn_Connect;
    }
}