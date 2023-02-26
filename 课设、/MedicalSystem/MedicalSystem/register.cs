using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            register_Load();
            NATIONALITY();
            MARRY();
            PAYTYPE();
            lblMedicalID.Visible = false;
            txtmedicalid.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnregisterconserve_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            sqlConnection.Open();
            string name = this.txbname.Text.Trim();
            this.txbpinying.Text = FirstPinYin(name);
            int age = DateTime.Now.Year - dtpbirthdate.Value.Year;
            this.txtage.Text = age.ToString();
            string paytype = cmbpaytype.Text.Trim();
            SqlCommand sqlCommand = new SqlCommand();
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand2.Connection = sqlConnection;
            sqlCommand.CommandText =
                "INSERT INTO tb_PATIENTINFOR (PatientNAME, pinying, GENDER, BIRTHDATE, AGE, NATIONALITY, PROVINCE, CITY, ADDRESS, TEL, IDCARD, PAYTYPE, MARRYSITUATION, registerTime) VALUES (@PatientNAME,@pinying,@GENDER,@BIRTHDATE,@AGE,@NATIONALITY,@PROVINCE,@CITY,@ADDRESS,@TEL,@IDCARD,@PAYTYPE,@MARRYSITUATION,@registerTime);";

            sqlCommand2.CommandText = "SELECT @@IDENTITY";

            sqlCommand.Parameters.AddWithValue("@PatientNAME", this.txbname.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@pinying", FirstPinYin(name));
            sqlCommand.Parameters.AddWithValue("@GENDER", (bool)this.rbtnman.Checked);
            sqlCommand.Parameters.AddWithValue("@BIRTHDATE", this.dtpbirthdate.Value.Date);
            sqlCommand.Parameters.AddWithValue("@AGE", age);
            sqlCommand.Parameters.AddWithValue("@NATIONALITY", cmbnationality.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@PROVINCE", cmbprovince.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@CITY", cmbcity.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@ADDRESS", this.txbaddress.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@TEL", this.txbtel.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@IDCARD", this.txbidcard.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@PAYTYPE", this.cmbpaytype.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@MARRYSITUATION", cmbmarry.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@registerTime", DateTime.Now);
            int rowAffected = sqlCommand.ExecuteNonQuery();
            long mdnumber = Convert.ToInt64(sqlCommand2.ExecuteScalar());
            if (rowAffected == 1)
            {
                MessageBox.Show(
      $"你已经完成患者:{mdnumber}的信息输入",
      "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                Patientinfor patientinfor = new Patientinfor(mdnumber);
                patientinfor.Show();
                this.Close();
            }
            sqlConnection.Close();
        }


        public void MARRY()
        {
           
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT MARRYSITUATION FROM tb_MARRYSITUATION", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "MARRYSITUATION");
            cmbmarry.DataSource = dataSet.Tables["MARRYSITUATION"];
            cmbmarry.DisplayMember = "MARRYSITUATION";
            //SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            //sqlCommand.CommandText =
            //"SELECT MARRYSITUATION FROM tb_MARRYSITUATION;";
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    string name = sqlDataReader.GetString(sqlDataReader.GetOrdinal("MARRYSITUATION"));

            //    cmbmarry.Items.Add(name);
            //}
            sqlConnection.Close();
        }
        public void PAYTYPE()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT PAYTYPENAME FROM tb_PAYTYPE;", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "PAYTYPENAME");
            cmbpaytype.DataSource = dataSet.Tables["PAYTYPENAME"];
            cmbpaytype.DisplayMember = "PAYTYPENAME";
            //SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            //sqlCommand.CommandText =
            //"SELECT PAYTYPENAME FROM tb_PAYTYPE;";
            //sqlConnection.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //if (sqlDataReader.Read())
            //{
            //    string name = sqlDataReader.GetString(sqlDataReader.GetOrdinal("PAYTYPENAME"));

            //    cmbpaytype.Items.Add(name);
            //}
            sqlConnection.Close();
        }
        public void NATIONALITY()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT NATIONALITY FROM tb_NATIONALITY", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "NATIONALITY");
            cmbnationality.DataSource = dataSet.Tables["NATIONALITY"];
            cmbnationality.DisplayMember = "NATIONALITY";
            sqlConnection.Close();
        }
        public void register_Load()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT PROVINCENAME FROM tb_PROVINCE;", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "PROVINCENAME");
            cmbprovince.DataSource = dataSet.Tables["PROVINCENAME"];
            cmbprovince.DisplayMember = "PROVINCENAME";
            sqlConnection.Close();
        }

        public void cmbprovince_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbcity.DataSource = null;
            cmbcity.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText =
            "SELECT CITYNAME FROM tb_CITY AS C,tb_PROVINCE AS P WHERE C.PROVINCEID=P.PROVINCEID AND P.PROVINCENAME='" + cmbprovince.Text.ToString() + "'; ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand.CommandText, sqlConnection);
            DataSet dS = new DataSet();
            sqlDataAdapter.Fill(dS, "CITYNAME");
            cmbcity.DataSource = dS.Tables["CITYNAME"];
            cmbcity.DisplayMember = "CITYNAME";
            sqlConnection.Close();
        }
        public static string PinYin(string chinese)
        {
            string retValue = string.Empty;
            foreach (char chr in chinese)
            {
                try
                {
                    if (ChineseChar.IsValidChar(chr))
                    {
                        ChineseChar chineseChar = new ChineseChar(chr);
                        string t = chineseChar.Pinyins[0].ToString();
                        retValue += t.Substring(0, t.Length - 1);
                    }
                    else
                    {
                        retValue += chr.ToString();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("全拼转化出错！" + e.Message);
                    return string.Empty;
                }
            }
            return retValue;
        }
        public static string FirstPinYin(string chinese)
        {
            string retValue = string.Empty;

            foreach (char chr in chinese)
            {
                try
                {
                    if (ChineseChar.IsValidChar(chr))
                    {
                        ChineseChar chineseChar = new ChineseChar(chr);
                        string t = chineseChar.Pinyins[0].ToString();
                        retValue += t.Substring(0, 1);
                    }
                    else
                    {
                        retValue += chr.ToString();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("首字母转化出错！" + e.Message);
                    return string.Empty;
                }
            }
            return retValue;
        }
        private void register_Load(object sender, EventArgs e)
        {
            this.txblblRegisterTime.Text = DateTime.Now.ToString();
        }

        public void dtpbirthdate_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dtpbirthdate.Value.Year;
            this.txtage.Text = age.ToString();
        }

        private void btnregisterback_Click(object sender, EventArgs e)
        {
            Desktop desktop = new Desktop();
            desktop.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            foreach (Control cl in Controls)
            {
                if (cl is ComboBox)
                {
                    ComboBox cob = cl as ComboBox;
                    cob.SelectedIndex = -1;

                }
                else if (cl is TextBox)
                {
                    TextBox tb = cl as TextBox;
                    tb.Text = string.Empty;
                }

            }
        }

        private void cmbcity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        //private void txbidcard_TextChanged(object sender, EventArgs e)
        //{
        //    if (txbidcard.Text.Length!=18)
        //    {
        //        erID.SetError(txbidcard, "身份证号码输入有误！");
        //        erID.Icon = new System.Drawing.Icon(@"D:\DeskTop\医学数据库\MedicalSystem\错误.ico");
        //    }
        //}

        //private void txbtel_TextChanged(object sender, EventArgs e)
        //{
        //    if (txbtel.Text.Length!=11)
        //    {
        //        erID.SetError(txbtel, "手机号是11位数！");
        //        erID.Icon = new System.Drawing.Icon(@"D:\DeskTop\医学数据库\MedicalSystem\错误.ico");
        //    }
        //}

        //private void txbidcard_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (txbidcard.Text.Length != 18)
        //    {
        //        erID.SetError(txbidcard, "身份证号码输入有误！");
        //        erID.Icon = new System.Drawing.Icon(@"D:\DeskTop\医学数据库\MedicalSystem\错误.ico");
        //    }
            
        //}

        private void txbidcard_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbidcard_MouseLeave(object sender, EventArgs e)
        {
            if (txbidcard.Text.Length != 18)
            {
                erID.SetError(txbidcard, "身份证号码输入有误！");
                //erID.Icon = new System.Drawing.Icon(@"D:\DeskTop\医学数据库\MedicalSystem\错误.ico");
            }
        }

        private void txbidcard_MouseEnter(object sender, EventArgs e)
        {
            erID.Dispose();
        }

        private void txbtel_MouseLeave(object sender, EventArgs e)
        {
            if (txbtel.Text.Length != 11)
            {
                erPhone.SetError(txbtel, "手机号是11位数！");
                //erPhone.Icon = new System.Drawing.Icon(@"D:\DeskTop\医学数据库\MedicalSystem\错误.ico");
            }
        }

        private void txbtel_MouseEnter(object sender, EventArgs e)
        {
            erPhone.Dispose();
        }
    }
}
