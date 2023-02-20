using System;
using System.Data.SqlClient;                                                                 
using System.Windows.Forms;


namespace MedicalSystem
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                               
            sqlConnection.ConnectionString =
                "Server=(local);Database=MedicalSystem;Integrated Security=sspi";              
            SqlCommand sqlCommand = new SqlCommand();                                        
            sqlCommand.Connection = sqlConnection;                                           
            sqlCommand.CommandText =                                                         
                $"SELECT COUNT(1) FROM tb_User" +
                $" WHERE No='{this.txb_UserNo.Text.Trim()}'" +								 
                $" AND Password=HASHBYTES('MD5','{this.txb_Password.Text.Trim()}');";
            sqlConnection.Open();                                                            
            int rowCount = (int)sqlCommand.ExecuteScalar();                                 
                                                                                             
            sqlConnection.Close();                                                           
            if (rowCount == 1)                                                               
            {
                MessageBox.Show("登录成功。");												 
            }
            else                                                                             
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");								 
                this.txb_Password.Focus();                                                   
                this.txb_Password.SelectAll();
            }
        }
    }
}
