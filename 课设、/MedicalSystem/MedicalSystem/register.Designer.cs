namespace MedicalSystem
{
    partial class register
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
            this.components = new System.ComponentModel.Container();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnregisterconserve = new System.Windows.Forms.Button();
            this.btnregisterback = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMedicalID = new System.Windows.Forms.Label();
            this.lblpatientname = new System.Windows.Forms.Label();
            this.lblpinying = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.lblnationility = new System.Windows.Forms.Label();
            this.lblprovince = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblIDcard = new System.Windows.Forms.Label();
            this.lblpay = new System.Windows.Forms.Label();
            this.lblmarry = new System.Windows.Forms.Label();
            this.txbname = new System.Windows.Forms.TextBox();
            this.txbpinying = new System.Windows.Forms.TextBox();
            this.cmbnationality = new System.Windows.Forms.ComboBox();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.cmbprovince = new System.Windows.Forms.ComboBox();
            this.cmbmarry = new System.Windows.Forms.ComboBox();
            this.cmbpaytype = new System.Windows.Forms.ComboBox();
            this.txtmedicalid = new System.Windows.Forms.TextBox();
            this.txbidcard = new System.Windows.Forms.TextBox();
            this.txbaddress = new System.Windows.Forms.TextBox();
            this.txbtel = new System.Windows.Forms.TextBox();
            this.dtpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.rbtnman = new System.Windows.Forms.RadioButton();
            this.rbtnwoman = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblRegisterTime = new System.Windows.Forms.Label();
            this.txblblRegisterTime = new System.Windows.Forms.TextBox();
            this.erID = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPhone = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(35, 12);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 22);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "建档";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnregisterconserve
            // 
            this.btnregisterconserve.Location = new System.Drawing.Point(329, 12);
            this.btnregisterconserve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregisterconserve.Name = "btnregisterconserve";
            this.btnregisterconserve.Size = new System.Drawing.Size(75, 22);
            this.btnregisterconserve.TabIndex = 10;
            this.btnregisterconserve.Text = "保存";
            this.btnregisterconserve.UseVisualStyleBackColor = true;
            this.btnregisterconserve.Click += new System.EventHandler(this.btnregisterconserve_Click);
            // 
            // btnregisterback
            // 
            this.btnregisterback.Location = new System.Drawing.Point(589, 12);
            this.btnregisterback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregisterback.Name = "btnregisterback";
            this.btnregisterback.Size = new System.Drawing.Size(75, 22);
            this.btnregisterback.TabIndex = 11;
            this.btnregisterback.Text = "返回";
            this.btnregisterback.UseVisualStyleBackColor = true;
            this.btnregisterback.Click += new System.EventHandler(this.btnregisterback_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMedicalID
            // 
            this.lblMedicalID.AutoSize = true;
            this.lblMedicalID.Location = new System.Drawing.Point(494, 381);
            this.lblMedicalID.Name = "lblMedicalID";
            this.lblMedicalID.Size = new System.Drawing.Size(75, 15);
            this.lblMedicalID.TabIndex = 13;
            this.lblMedicalID.Text = "医保卡号:";
            // 
            // lblpatientname
            // 
            this.lblpatientname.AutoSize = true;
            this.lblpatientname.Location = new System.Drawing.Point(105, 94);
            this.lblpatientname.Name = "lblpatientname";
            this.lblpatientname.Size = new System.Drawing.Size(45, 15);
            this.lblpatientname.TabIndex = 14;
            this.lblpatientname.Text = "姓名:";
            // 
            // lblpinying
            // 
            this.lblpinying.AutoSize = true;
            this.lblpinying.Location = new System.Drawing.Point(509, 425);
            this.lblpinying.Name = "lblpinying";
            this.lblpinying.Size = new System.Drawing.Size(60, 15);
            this.lblpinying.TabIndex = 15;
            this.lblpinying.Text = "拼音码:";
            this.lblpinying.Visible = false;
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(524, 87);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(45, 15);
            this.lblsex.TabIndex = 16;
            this.lblsex.Text = "性别:";
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Location = new System.Drawing.Point(75, 141);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(75, 15);
            this.lblbirthdate.TabIndex = 17;
            this.lblbirthdate.Text = "出生日期:";
            // 
            // lblnationility
            // 
            this.lblnationility.AutoSize = true;
            this.lblnationility.Location = new System.Drawing.Point(524, 253);
            this.lblnationility.Name = "lblnationility";
            this.lblnationility.Size = new System.Drawing.Size(52, 15);
            this.lblnationility.TabIndex = 18;
            this.lblnationility.Text = "国籍：";
            // 
            // lblprovince
            // 
            this.lblprovince.AutoSize = true;
            this.lblprovince.Location = new System.Drawing.Point(98, 203);
            this.lblprovince.Name = "lblprovince";
            this.lblprovince.Size = new System.Drawing.Size(52, 15);
            this.lblprovince.TabIndex = 19;
            this.lblprovince.Text = "省份：";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(524, 199);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(52, 15);
            this.lblcity.TabIndex = 20;
            this.lblcity.Text = "县市：";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(68, 253);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 15);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "具体地址：";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(495, 299);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(82, 15);
            this.lbltel.TabIndex = 22;
            this.lbltel.Text = "手机号码：";
            // 
            // lblIDcard
            // 
            this.lblIDcard.AutoSize = true;
            this.lblIDcard.Location = new System.Drawing.Point(68, 299);
            this.lblIDcard.Name = "lblIDcard";
            this.lblIDcard.Size = new System.Drawing.Size(82, 15);
            this.lblIDcard.TabIndex = 23;
            this.lblIDcard.Text = "身份证号：";
            // 
            // lblpay
            // 
            this.lblpay.AutoSize = true;
            this.lblpay.Location = new System.Drawing.Point(494, 340);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(82, 15);
            this.lblpay.TabIndex = 24;
            this.lblpay.Text = "计费类型：";
            // 
            // lblmarry
            // 
            this.lblmarry.AutoSize = true;
            this.lblmarry.Location = new System.Drawing.Point(68, 345);
            this.lblmarry.Name = "lblmarry";
            this.lblmarry.Size = new System.Drawing.Size(75, 15);
            this.lblmarry.TabIndex = 25;
            this.lblmarry.Text = "婚姻状况:";
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(170, 84);
            this.txbname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(121, 25);
            this.txbname.TabIndex = 26;
            // 
            // txbpinying
            // 
            this.txbpinying.Location = new System.Drawing.Point(590, 415);
            this.txbpinying.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbpinying.Name = "txbpinying";
            this.txbpinying.Size = new System.Drawing.Size(120, 25);
            this.txbpinying.TabIndex = 27;
            this.txbpinying.Visible = false;
            // 
            // cmbnationality
            // 
            this.cmbnationality.FormattingEnabled = true;
            this.cmbnationality.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbnationality.Location = new System.Drawing.Point(589, 245);
            this.cmbnationality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbnationality.Name = "cmbnationality";
            this.cmbnationality.Size = new System.Drawing.Size(121, 23);
            this.cmbnationality.TabIndex = 28;
            // 
            // cmbcity
            // 
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Location = new System.Drawing.Point(589, 196);
            this.cmbcity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(121, 23);
            this.cmbcity.TabIndex = 29;
            this.cmbcity.SelectedIndexChanged += new System.EventHandler(this.cmbcity_SelectedIndexChanged);
            // 
            // cmbprovince
            // 
            this.cmbprovince.FormattingEnabled = true;
            this.cmbprovince.Location = new System.Drawing.Point(172, 195);
            this.cmbprovince.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbprovince.Name = "cmbprovince";
            this.cmbprovince.Size = new System.Drawing.Size(121, 23);
            this.cmbprovince.TabIndex = 30;
            this.cmbprovince.SelectedIndexChanged += new System.EventHandler(this.cmbprovince_SelectedIndexChanged);
            // 
            // cmbmarry
            // 
            this.cmbmarry.FormattingEnabled = true;
            this.cmbmarry.Location = new System.Drawing.Point(170, 337);
            this.cmbmarry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbmarry.Name = "cmbmarry";
            this.cmbmarry.Size = new System.Drawing.Size(123, 23);
            this.cmbmarry.TabIndex = 31;
            // 
            // cmbpaytype
            // 
            this.cmbpaytype.FormattingEnabled = true;
            this.cmbpaytype.Location = new System.Drawing.Point(590, 332);
            this.cmbpaytype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbpaytype.Name = "cmbpaytype";
            this.cmbpaytype.Size = new System.Drawing.Size(121, 23);
            this.cmbpaytype.TabIndex = 32;
            // 
            // txtmedicalid
            // 
            this.txtmedicalid.Location = new System.Drawing.Point(590, 374);
            this.txtmedicalid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmedicalid.Name = "txtmedicalid";
            this.txtmedicalid.Size = new System.Drawing.Size(120, 25);
            this.txtmedicalid.TabIndex = 33;
            // 
            // txbidcard
            // 
            this.txbidcard.Location = new System.Drawing.Point(172, 289);
            this.txbidcard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbidcard.Name = "txbidcard";
            this.txbidcard.Size = new System.Drawing.Size(121, 25);
            this.txbidcard.TabIndex = 34;
            this.txbidcard.TextChanged += new System.EventHandler(this.txbidcard_TextChanged);
            this.txbidcard.MouseEnter += new System.EventHandler(this.txbidcard_MouseEnter);
            this.txbidcard.MouseLeave += new System.EventHandler(this.txbidcard_MouseLeave);
            // 
            // txbaddress
            // 
            this.txbaddress.Location = new System.Drawing.Point(170, 245);
            this.txbaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbaddress.Name = "txbaddress";
            this.txbaddress.Size = new System.Drawing.Size(123, 25);
            this.txbaddress.TabIndex = 35;
            // 
            // txbtel
            // 
            this.txbtel.Location = new System.Drawing.Point(590, 290);
            this.txbtel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtel.Name = "txbtel";
            this.txbtel.Size = new System.Drawing.Size(121, 25);
            this.txbtel.TabIndex = 36;
            this.txbtel.MouseEnter += new System.EventHandler(this.txbtel_MouseEnter);
            this.txbtel.MouseLeave += new System.EventHandler(this.txbtel_MouseLeave);
            // 
            // dtpbirthdate
            // 
            this.dtpbirthdate.Location = new System.Drawing.Point(170, 135);
            this.dtpbirthdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpbirthdate.Name = "dtpbirthdate";
            this.dtpbirthdate.Size = new System.Drawing.Size(158, 25);
            this.dtpbirthdate.TabIndex = 37;
            this.dtpbirthdate.ValueChanged += new System.EventHandler(this.dtpbirthdate_ValueChanged);
            // 
            // rbtnman
            // 
            this.rbtnman.AutoSize = true;
            this.rbtnman.Location = new System.Drawing.Point(583, 83);
            this.rbtnman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnman.Name = "rbtnman";
            this.rbtnman.Size = new System.Drawing.Size(43, 19);
            this.rbtnman.TabIndex = 38;
            this.rbtnman.TabStop = true;
            this.rbtnman.Text = "男";
            this.rbtnman.UseVisualStyleBackColor = true;
            // 
            // rbtnwoman
            // 
            this.rbtnwoman.AutoSize = true;
            this.rbtnwoman.Location = new System.Drawing.Point(647, 83);
            this.rbtnwoman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnwoman.Name = "rbtnwoman";
            this.rbtnwoman.Size = new System.Drawing.Size(43, 19);
            this.rbtnwoman.TabIndex = 39;
            this.rbtnwoman.TabStop = true;
            this.rbtnwoman.Text = "女";
            this.rbtnwoman.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "年龄：";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(589, 131);
            this.txtage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 25);
            this.txtage.TabIndex = 41;
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            // 
            // lblRegisterTime
            // 
            this.lblRegisterTime.AutoSize = true;
            this.lblRegisterTime.Location = new System.Drawing.Point(68, 384);
            this.lblRegisterTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterTime.Name = "lblRegisterTime";
            this.lblRegisterTime.Size = new System.Drawing.Size(82, 15);
            this.lblRegisterTime.TabIndex = 42;
            this.lblRegisterTime.Text = "登记时间：";
            // 
            // txblblRegisterTime
            // 
            this.txblblRegisterTime.Location = new System.Drawing.Point(170, 381);
            this.txblblRegisterTime.Margin = new System.Windows.Forms.Padding(4);
            this.txblblRegisterTime.Name = "txblblRegisterTime";
            this.txblblRegisterTime.Size = new System.Drawing.Size(123, 25);
            this.txblblRegisterTime.TabIndex = 43;
            // 
            // erID
            // 
            this.erID.ContainerControl = this;
            // 
            // erPhone
            // 
            this.erPhone.ContainerControl = this;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 505);
            this.Controls.Add(this.txblblRegisterTime);
            this.Controls.Add(this.lblRegisterTime);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnwoman);
            this.Controls.Add(this.rbtnman);
            this.Controls.Add(this.dtpbirthdate);
            this.Controls.Add(this.txbtel);
            this.Controls.Add(this.txbaddress);
            this.Controls.Add(this.txbidcard);
            this.Controls.Add(this.txtmedicalid);
            this.Controls.Add(this.cmbpaytype);
            this.Controls.Add(this.cmbmarry);
            this.Controls.Add(this.cmbprovince);
            this.Controls.Add(this.cmbcity);
            this.Controls.Add(this.cmbnationality);
            this.Controls.Add(this.txbpinying);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.lblmarry);
            this.Controls.Add(this.lblpay);
            this.Controls.Add(this.lblIDcard);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lblprovince);
            this.Controls.Add(this.lblnationility);
            this.Controls.Add(this.lblbirthdate);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.lblpinying);
            this.Controls.Add(this.lblpatientname);
            this.Controls.Add(this.lblMedicalID);
            this.Controls.Add(this.btnregisterback);
            this.Controls.Add(this.btnregisterconserve);
            this.Controls.Add(this.btnRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "register";
            this.Text = "门诊登记";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnregisterconserve;
        private System.Windows.Forms.Button btnregisterback;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMedicalID;
        private System.Windows.Forms.Label lblpatientname;
        private System.Windows.Forms.Label lblpinying;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.Label lblnationility;
        private System.Windows.Forms.Label lblprovince;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblIDcard;
        private System.Windows.Forms.Label lblpay;
        private System.Windows.Forms.Label lblmarry;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.TextBox txbpinying;
        private System.Windows.Forms.ComboBox cmbnationality;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.ComboBox cmbprovince;
        private System.Windows.Forms.ComboBox cmbmarry;
        private System.Windows.Forms.ComboBox cmbpaytype;
        private System.Windows.Forms.TextBox txtmedicalid;
        private System.Windows.Forms.TextBox txbidcard;
        private System.Windows.Forms.TextBox txbaddress;
        private System.Windows.Forms.TextBox txbtel;
        private System.Windows.Forms.DateTimePicker dtpbirthdate;
        private System.Windows.Forms.RadioButton rbtnman;
        private System.Windows.Forms.RadioButton rbtnwoman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblRegisterTime;
        private System.Windows.Forms.TextBox txblblRegisterTime;
        private System.Windows.Forms.ErrorProvider erID;
        private System.Windows.Forms.ErrorProvider erPhone;
    }
}